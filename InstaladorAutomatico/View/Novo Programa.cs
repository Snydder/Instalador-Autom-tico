using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaladorAutomatico.View
{
    public partial class Novo_Programa : Form
    {
        public Novo_Programa()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtBxCaminhoPrograma.Text = null;
            txtBxNomePrograma.Text = null;
        }

        private void BtnCaminhoPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarPrograma = new OpenFileDialog();
            selecionarPrograma.ShowDialog();
            string caminhoProgramaStr = selecionarPrograma.FileName;
            txtBxCaminhoPrograma.Text = caminhoProgramaStr;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtBxNomePrograma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
