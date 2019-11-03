using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Model.Programa ProgramaFuncoes = new Model.Programa();

        public Principal()
        {
            //inicializando componente e Lista
            InitializeComponent();
            GradeDeDados.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProgramaFuncoes.VerificaPorXMLInicializacao();
            ObterLista();
            //Image image = Image.FromFile(@"C:\TI\Ammyy\Ammyy_v3.5.exe");
            //caminhoIconeDataGridViewTextBoxColumn.Image = image;
            //caminhoIconeDataGridViewTextBoxColumn.HeaderText = "Image";
            //caminhoIconeDataGridViewTextBoxColumn.Name = "img";
        }

        private int PercorreCheckBoxes()
        {
            Boolean valorCheckBox = false;
            int contaMarcacoes = 0;

            for (int i = 0; i <= GradeDeDados.RowCount - 1; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[4, i].Value);
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
                GradeDeDados[4, i].Value = valorBooleano;
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
            /*
             * depreciado
             * foreach (Control c in tblPnlOrganiza.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == false)
                    {
                        if (executouSegundoIf == false)
                        {
                            cb.Checked = true;
                            executouPrimeiroIf = true;
                            executouSegundoIf = false;
                            BtnMarcaDesmarca.Text = "Desmarcar Tudo";
                        }
                    }
                    if (cb.Checked == true)
                    {
                        if (executouPrimeiroIf == false)
                        {
                            cb.Checked = false;
                            executouSegundoIf = true;
                            executouPrimeiroIf = false;
                            BtnMarcaDesmarca.Text = "Marcar Tudo";
                        }
                    }
                }
            }*/
        }


        private void btnInstlr_Click(object sender, EventArgs e)
        {


            if (PercorreCheckBoxes() == 0)
            {
                MessageBox.Show("Nenhum programa está selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String ProgramaSendoInstalado;
            Queue<String> filaDeInstalacao = new Queue<String>();
            List<int> posicaoSelecionados = new List<int>();
            Boolean valorCheckBox;
            for (int i = 0; i <= GradeDeDados.RowCount - 1; i++)
            {
                valorCheckBox = Convert.ToBoolean(GradeDeDados[4, i].Value);
                if (valorCheckBox == true)
                {
                    filaDeInstalacao.Enqueue(ListaLocal[i].diretorioPrograma);
                    posicaoSelecionados.Add(i);
                    GradeDeDados.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

            GradeDeDados.ClearSelection();

            for (int i = 0; i <= GradeDeDados.RowCount - 1; i++)
            {

                if (filaDeInstalacao.Count == 0)
                {
                    MessageBox.Show("Instalação concluída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ProgramaSendoInstalado = filaDeInstalacao.Peek();
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(ProgramaSendoInstalado);

                System.Diagnostics.Process rfp = new System.Diagnostics.Process();
                rfp = System.Diagnostics.Process.Start(psi);

                rfp.WaitForExit(300000);
                GradeDeDados.Rows[posicaoSelecionados[i]].DefaultCellStyle.BackColor = Color.LightGreen;
                filaDeInstalacao.Dequeue();
            }
            posicaoSelecionados.Clear();

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
            /*foreach (Control c in tblPnlOrganiza.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    
                    if (cb.Checked == true)
                    {
                        //Executar instalador de cada programa
                    }
                }
            }*/
        }
        private void CopiarArquivos(String fonteArquivo, String destinoArquivo)
        {
            try
            {
                File.Copy(fonteArquivo, destinoArquivo);
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListaDeProgramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo o formulário para a adição de um novo programa
            View.Gerenciar_Programas novoPrograma = new View.Gerenciar_Programas();
            novoPrograma.ShowDialog();
        }

        private void BtnVrfcInstlc_Click(object sender, EventArgs e)
        {

        }

        public void ObterLista()
        {
            ProgramaFuncoes.VerificaSelecionarLocalSalvamentoXML();
            try
            {
                ListaLocal.Clear();
                ListaLocal.AddRange(ProgramaFuncoes.DeserializaPrograma());
                GradeDeDados.DataSource = null;
                GradeDeDados.DataSource = ListaLocal;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado. A tabela está vazia.", "Falha no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAtualizarDataGrid_Click(object sender, EventArgs e)
        {
            ObterLista();
            GradeDeDados.FirstDisplayedScrollingRowIndex = GradeDeDados.RowCount - 1;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
