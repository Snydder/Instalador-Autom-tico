using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InstaladorAutomatico
{
    public partial class Principal : Form
    {
        //declarando lista local
        List<Model.Programa> ListaLocal = new List<Model.Programa>();
        List<int> linhasSelecionadas = new List<int>();
        Queue<String> filaDeInstalacao = new Queue<String>();
        Model.Programa ProgramaFuncoes = new Model.Programa();
        public Principal()
        {
            //inicializando componente
            InitializeComponent();
            //Image image = Image.FromFile(@"C:\TI\Ammyy\Ammyy_v3.5.exe");
            //caminhoIconeDataGridViewTextBoxColumn.Image = image;
            //caminhoIconeDataGridViewTextBoxColumn.HeaderText = "Image";
            //caminhoIconeDataGridViewTextBoxColumn.Name = "img";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //declarando lista local
            List<Model.Programa> ListaLocal = new List<Model.Programa>();
            List<int> linhasSelecionadas = new List<int>();
            Queue<String> filaDeInstalacao = new Queue<String>();
            Model.Programa ProgramaFuncoes = new Model.Programa();
            GradeDeDados.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GradeDeDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            nomeProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            arquiteturaProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            Selecionar.ReadOnly = false;
            if (ProgramaFuncoes.VerificaPorXMLInicializacao() == false)
            {
                Application.Exit();
                return;
            }
            ProgramaFuncoes.VerificaLocalUAC();
            ObterLista();
            DefineValorCheckBox(true);
        }

        private int PercorreCheckBoxes()
        {
            Boolean valorCheckBox;
            int contaMarcacoes = 0;

            for (int i = 0; i <= GradeDeDados.RowCount - 1; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[2, i].Value);
                if (valorCheckBox == true)
                {
                    contaMarcacoes++;
                }
            }

            return contaMarcacoes;
        }

        private void DefineValorCheckBox(Boolean valorBooleano)
        {
            for (int i = 0; i <= GradeDeDados.RowCount - 1; i++)
            {
                GradeDeDados[2, i].Value = valorBooleano;
            }
        }
        private void BtnMarcaDesmarca_Click(object sender, EventArgs e)
        {
            if (PercorreCheckBoxes() == 0)
            {
                DefineValorCheckBox(true);
            }
            else if (PercorreCheckBoxes() == GradeDeDados.RowCount)
            {
                DefineValorCheckBox(false);
            }
            else if (PercorreCheckBoxes() < GradeDeDados.RowCount)
            {
                DefineValorCheckBox(true);
            }
        }

        private void ResetaLinhas()
        {
            //marcando todas as linhas com a cor branca 
            for (int i = 0; i < GradeDeDados.Rows.Count; i++)
            {
                GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void ObterLinhasSelecionadas()
        {
            linhasSelecionadas.Clear();
            Boolean valorCheckBox;
            for (int i = 0; i < GradeDeDados.RowCount; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[2, i].Value);
                if (valorCheckBox == true)
                {
                    GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    linhasSelecionadas.Add(i);
                }
            }
        }

        private void MarcaComoPendente()
        {
            Boolean valorCheckBox;
            for (int i = 0; i <= GradeDeDados.RowCount - 1; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[2, i].Value);
                if (valorCheckBox == true)
                {
                    GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void GeraFilaInstalacao()
        {
            for (int i = 0; i < linhasSelecionadas.Count; i++)
            {
                String nomeProgramaComExtensao = Path.GetFileName(ListaLocal[linhasSelecionadas[i]].diretorioPrograma);
                String destinoCopiaComNomePrograma = Path.Combine(System.Configuration.ConfigurationManager.AppSettings.Get("DestinoCopia"), ListaLocal[linhasSelecionadas[i]].nomePrograma);
                filaDeInstalacao.Enqueue(Path.Combine(destinoCopiaComNomePrograma, nomeProgramaComExtensao));
            }
        }

        private void ExecutaFilaDeInstalacao()
        {
            String ProgramaSendoInstalado;
            Boolean valorCheckBox;
            ObterLinhasSelecionadas();
            GeraFilaInstalacao();
            System.IO.Directory.CreateDirectory(System.Configuration.ConfigurationManager.AppSettings.Get("DestinoCopia"));
            if (PercorreCheckBoxes() == 0)
            {
                MessageBox.Show("Nenhum programa está selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CopiarArquivos();
            DesabilitaHabilitaBotoes(false);

            //marcando todas as linhas com a cor branca 
            ResetaLinhas();

            //marcando linhas selecionadas como amarela
            MarcaComoPendente();


            for (int i = 0; i <= GradeDeDados.Rows.Count - 1; i++)
            {
                if (filaDeInstalacao.Count == 0)
                {
                    MessageBox.Show("Instalação concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                valorCheckBox = Convert.ToBoolean(GradeDeDados[2, i].Value);
                if (valorCheckBox == true)
                {
                    ProgramaSendoInstalado = filaDeInstalacao.Dequeue();
                    if (File.Exists(ProgramaSendoInstalado))
                    {
                        ProcessStartInfo psi = new ProcessStartInfo(ProgramaSendoInstalado);
                        Process rfp = new Process();
                        rfp = Process.Start(psi);
                        rfp.WaitForExit(300000);
                        rfp.Dispose();
                        GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        continue;
                    }
                    if (i >= 5)
                    {
                        GradeDeDados.FirstDisplayedScrollingRowIndex = linhasSelecionadas[i];
                    }
                }
            }
            linhasSelecionadas.Clear();
            MessageBox.Show("Instalação concluída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabilitaHabilitaBotoes(true);
        }

        private void btnInstlr_Click(object sender, EventArgs e)
        {
            DesabilitaHabilitaBotoes(false);
            if (PercorreCheckBoxes() == 0)
            {
                MessageBox.Show("Nenhum programa está selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (System.Configuration.ConfigurationManager.AppSettings.Get("LocalUAC") != "")
            {
                if (File.Exists(System.Configuration.ConfigurationManager.AppSettings.Get("LocalUAC")))
                {
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(System.Configuration.ConfigurationManager.AppSettings.Get("LocalUAC"));
                    System.Diagnostics.Process rfp = new System.Diagnostics.Process();
                    rfp = System.Diagnostics.Process.Start(psi);
                    rfp.WaitForExit(300000);
                    if (rfp.ExitCode == 1)
                    {
                        MessageBox.Show("O UAC foi desativado. Reiniciando em breve.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo do UAC não foi encontrado no diretório especificado. A instalação prosseguirá sem a checagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GradeDeDados.ClearSelection();
            ExecutaFilaDeInstalacao();
            linhasSelecionadas.Clear();
            DesabilitaHabilitaBotoes(true);

            /*
            //chechando arquitetura do sistema
            bool ArchSys = System.Environment.Is64BitOperatingSystem;
            if (ArchSys == true)
            {
                //fazer uma filtragem de programas.
            }
            else
            {
                //fazer outra filtragem de programas.
            }
            */
        }
        private int CopiarArquivos()
        {
            Boolean valorCheckBox;
            String DestinoArquivo;
            int i;
            DesabilitaHabilitaBotoes(false);
            ResetaLinhas();
            for (i = 0; i < GradeDeDados.Rows.Count; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[2, i].Value);
                if (valorCheckBox == true)
                {
                    DestinoArquivo = System.Configuration.ConfigurationManager.AppSettings.Get("DestinoCopia");
                    try
                    {
                        FileSystem.CopyDirectory(Path.GetDirectoryName(ListaLocal[i].diretorioPrograma), Path.Combine(System.Configuration.ConfigurationManager.AppSettings.Get("DestinoCopia"), ListaLocal[i].nomePrograma), UIOption.AllDialogs);
                        GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    catch (System.OperationCanceledException ex)
                    {
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        return i;
                    }
                }
                
            }
            /*Boolean valorCheckBox;
            String DestinoArquivo;
            MarcaComoPendente();
            DesabilitaHabilitaBotoes(false);
            for (int i = 0; i < GradeDeDados.RowCount; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[2, i].Value);
                String nomeUltimaPasta = Path.GetDirectoryName(ListaLocal[i].diretorioPrograma);
                DirectoryInfo dir = new DirectoryInfo(nomeUltimaPasta);
                DestinoArquivo = System.Configuration.ConfigurationManager.AppSettings.Get("DestinoCopia") + "\\" + ListaLocal[i].nomePrograma;
                if (valorCheckBox == true)
                {
                    if (!Directory.Exists(DestinoArquivo))
                    {
                        Directory.CreateDirectory(DestinoArquivo);
                    }

                    foreach (string filename in Directory.EnumerateFiles(nomeUltimaPasta))
                    {
                        using (FileStream SourceStream = File.Open(filename, FileMode.Open, FileAccess.Read))
                        {
                            using (FileStream DestinationStream = File.Create(DestinoArquivo + filename.Substring(filename.LastIndexOf('\\'))))
                            {
                                await SourceStream.CopyToAsync(DestinationStream);
                            }
                        }
                    }
                    GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            MessageBox.Show($"Cópia concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DesabilitaHabilitaBotoes(true);
            */
            DesabilitaHabilitaBotoes(true);
            return i;
        }

        private void DesabilitaHabilitaBotoes(bool VF)
        {
            btnCopiarArquivos.Enabled = VF;
            btnInstalar.Enabled = VF;
            BtnMarcaDesmarca.Enabled = VF;
            btnAtualizarDataGrid.Enabled = VF;
            arquivoToolStripMenuItem.Enabled = VF;
        }

        private void BtnCopiarArquivos_Click(object sender, EventArgs e)
        {
            CopiarArquivos();
            MessageBox.Show($"Cópia concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListaDeProgramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo o formulário para a adição de um novo programa
            View.Gerenciar_Programas GerenciarPrograma = new View.Gerenciar_Programas();
            GerenciarPrograma.Show();
        }

        public void ObterLista()
        {
            ProgramaFuncoes.VerificaSelecionarLocalSalvamentoXML();
            try
            {
                ListaLocal.Clear();
                ListaLocal.AddRange(ProgramaFuncoes.DeserializaPrograma());
                if (ListaLocal.Count > 0)
                {
                    GradeDeDados.Enabled = true;
                    GradeDeDados.DataSource = null;
                    GradeDeDados.DataSource = ListaLocal;
                }
                else
                {
                    GradeDeDados.DataSource = null;
                    GradeDeDados.Enabled = false;
                }
            }
            catch (FileNotFoundException)
            {
                ProgramaFuncoes.SerializaPrograma(ListaLocal);
            }
        }

        private void BtnAtualizarDataGrid_Click(object sender, EventArgs e)
        {
            ObterLista();
            if (GradeDeDados.RowCount > 2)
            {
                GradeDeDados.FirstDisplayedScrollingRowIndex = GradeDeDados.RowCount - 1;
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerificarWindowsUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cplPath = Path.Combine(Environment.SystemDirectory, "control.exe");
            Process.Start(cplPath, "/name Microsoft.WindowsUpdate");
        }
    }
}
