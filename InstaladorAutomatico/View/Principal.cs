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

namespace InstaladorAutomatico
{
    public partial class Principal : Form
    {
        //declarando lista local
        List<Model.Programa> ListaLocal = new List<Model.Programa>();
        public Principal()
        {
            //inicializando componente e Lista
            InitializeComponent();
            ListaLocal.AddRange(Model.Programa.ListaDeProgramas);
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

        private void NovoProgramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaDeProgramasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrindo o formulário para a adição de um novo programa
            View.Gerenciar_Programas novoPrograma = new View.Gerenciar_Programas();
            novoPrograma.ShowDialog();
        }

        private void LblMarcaProgresso_Click(object sender, EventArgs e)
        {

        }

        private void BtnVrfcInstlc_Click(object sender, EventArgs e)
        {

        }
    }
}
