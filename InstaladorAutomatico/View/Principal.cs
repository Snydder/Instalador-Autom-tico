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
        public Principal()
        {
            InitializeComponent();
        }
        private void BtnMarcaDesmarca_Click(object sender, EventArgs e)
        {
            bool executouPrimeiroIf = false, executouSegundoIf = false;
            foreach (Control c in tblPnlOrganiza.Controls)
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
            }
        }


        private void btnInstlr_Click(object sender, EventArgs e)
        {

            String nomecheckbox;
            String pastaTI = "C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE";
            String fonteArquivos = "\\\\192.168.0.13\\InstaladorAutomatico\\Radmin\\InstalarRadmin.bat";
            String destinoArquivo = "C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarRadmin.bat";
            String testeFonte = "\\Ammyy\\InstalarAmmyy.bat";
            //View.ProgressoInstalacao FormProgressoInstalacao = new View.ProgressoInstalacao();
            //FormProgressoInstalacao.ShowDialog();

            //Process.Start("C:\\"); <- iniciar um programa
            //Version os_info = System.Environment.Version; <- não é confiável
            //Criando pasta para inserir cópia de arquivos
            bool ArchSys = System.Environment.Is64BitOperatingSystem; //checando.ToString()
            if (ArchSys == true)
            {
                //fazer alguma filtragem de programas.
            }
            else
            {
                //fazer outra filtragem de programas.
            }
            foreach (Control c in tblPnlOrganiza.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    
                    if (cb.Checked == true)
                    {
                        nomecheckbox = cb.Name;
                        CopiarArquivos(fonteArquivos, destinoArquivo);
                        MessageBox.Show("fonteArquivos:" +fonteArquivos);
                        cb.BackColor = Color.Yellow;
                    }
                }
            }
        }

            /*
            public  static async Task CopiarArquivoAsync(String sourceFile, String destinationFile)
            {
                //lblMarcaProgresso.Text = "Copiando Arquivos...";
                    using (var sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan))
                    using (var destinationStream = new FileStream(destinationFile, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.Asynchronous | FileOptions.SequentialScan))
                        await sourceStream.CopyToAsync(destinationStream);

            }
            */
            private void CopiarArquivos (String fonteArquivo, String destinoArquivo)
        {
                //System.IO.Directory.CreateDirectory(@"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");
            try
            {
                //System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Radmin\\InstalarRadmin.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarRadmin.bat");
                File.Copy(fonteArquivo, destinoArquivo);
            }
            catch (Exception ex)
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
            //abrindo o formulário para a adição de um novo programa
            View.Novo_Programa novoPrograma = new View.Novo_Programa();
            novoPrograma.ShowDialog();
        }

        private void AlterarArquivoDeConfiguraçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivoConfiguracao = new OpenFileDialog();
            arquivoConfiguracao.ShowDialog();
        }

        private void LblMarcaProgresso_Click(object sender, EventArgs e)
        {

        }

        private void BtnVrfcInstlc_Click(object sender, EventArgs e)
        {

        }
    }
}
