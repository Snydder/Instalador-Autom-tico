using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
            //pgrsBr.Minimum = 20;
            //pgrsBr.Maximum = 100;
            //pgrsBr.Step = 30;
            //pgrsBr.PerformStep();
        }



        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            MarcaDesmarca(true);
        }

        private void btnDsmrcTds_Click(object sender, EventArgs e)
        {
            MarcaDesmarca(false);
        }

        private void MarcaDesmarca(bool TrueFalse)
        {
            if (!chkBxAmmyy.Checked == TrueFalse)
            {
                chkBxAmmyy.Checked = TrueFalse;
            }
            if (!chkBxKspsk.Checked == TrueFalse)
            {
                chkBxKspsk.Checked = TrueFalse;
            }
            if (!chkBxCClnr.Checked == TrueFalse)
            {
                chkBxCClnr.Checked = TrueFalse;
            }
            if (!chkBxGglChrm.Checked == TrueFalse)
            {
                chkBxGglChrm.Checked = TrueFalse;
            }
            if (!chkBxCtPDF.Checked == TrueFalse)
            {
                chkBxCtPDF.Checked = TrueFalse;
            }
            if (!chkBxAtlzJv.Checked == TrueFalse)
            {
                chkBxAtlzJv.Checked = TrueFalse;
            }
            if (!chkBxLbrOffc.Checked == TrueFalse)
            {
                chkBxLbrOffc.Checked = TrueFalse;
            }
            if (!chkbxTmVwr.Checked == TrueFalse)
            {
                chkbxTmVwr.Checked = TrueFalse;
            }
            if (!chkBxThndbrd.Checked == TrueFalse)
            {
                chkBxThndbrd.Checked = TrueFalse;
            }
            if (!chkBxUltraVNC.Checked == TrueFalse)
            {
                chkBxUltraVNC.Checked = TrueFalse;
            }
            if (!chkBxWnRr.Checked == TrueFalse)
            {
                chkBxWnRr.Checked = TrueFalse;
            }
            if (!chkBxRdmn.Checked == TrueFalse)
            {
                chkBxRdmn.Checked = TrueFalse;
            }
        }

        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            return result;
        }

        private void btnInstlr_Click(object sender, EventArgs e)
        {
            //Process.Start("C:\\"); <- iniciar um programa
            //Version os_info = System.Environment.Version; <- não é confiável
            bool ArchSys = System.Environment.Is64BitOperatingSystem; //checando.ToString()
            if (ArchSys == true)
            {
                MessageBox.Show(GetOSFriendlyName() + " 64 bits", "Versão", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(GetOSFriendlyName() + "32bits", "Versão", MessageBoxButtons.OK);
            }

            if (chkBxAmmyy.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Ammyy\\InstalarAmmyy.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarAmmyy.bat");
                    
                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxKspsk.Checked)
            {
                //encontrar instalador silent e/ou offline
            }
            if (chkBxCClnr.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\InstaladorAutomatico\CCleaner\\InstalarCCleaner.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarCCleaner.bat");
                    
                }
                catch (System.IO.FileNotFoundException)
                {

                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxGglChrm.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Chrome\\InstalarChrome.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarChrome.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxCtPDF.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\CutePDF\\InstalarCutePDF.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarCutePDF.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxAtlzJv.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Java\\InstalarJava.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarJava.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if (chkBxLbrOffc.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");
                    if (ArchSys == true)
                    {
                        System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\LibreOffice\\LibreOffice_6.1.2_Win_x64.msi", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\LibreOffice_6.1.2_Win_x64.msi");
                    }
                    else 
                    {
                        System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\LibreOffice\\LibreOffice_6.1.2_Win_x86.msi", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\LibreOffice_6.1.2_Win_x86.msi");
                    }
                }
                catch (System.IO.FileNotFoundException)
                {

                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkbxTmVwr.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\TeamViewer\\InstalarTeamViewer.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarTeamViewer.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxThndbrd.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Thunderbird\\InstalarThunderbird.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarThunderbird.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxUltraVNC.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\UltraVNC\\InstalarUltraVNC.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarUltraVNC.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (chkBxWnRr.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Winrar\\InstalarWinrar.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarWinrar.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if (chkBxRdmn.Checked)
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE");

                    System.IO.File.Copy(@"\\192.168.0.13\\InstaladorAutomatico\\Radmin\\InstalarRadmin.bat", @"C:\\Users\\matheus.perches\\Desktop\\PASTA DE TESTE\\InstalarRadmin.bat");

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
