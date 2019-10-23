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
            MessageBox.Show(Properties.Settings.Default.CaminhoXML);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ProgramaFuncoes.VerificaPorXMLInicializacao();
            ObterLista();
        }
        private void BtnMarcaDesmarca_Click(object sender, EventArgs e)
        {
            bool executouPrimeiroIf = false, executouSegundoIf = false;
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
            //Process.Start("C:\\"); <- iniciar um programa

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
            private void CopiarArquivos (String fonteArquivo, String destinoArquivo)
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
