using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InstaladorAutomatico.View
{
    public partial class Gerenciar_Programas : Form
    {
        //declarando listas locais
        [XmlElement(ElementName = "ListaDePrograma")]
        List<Model.Programa> ListaDeProgramasXML = new List<Model.Programa>();

        List<Model.Programa> ListaLocal = new List<Model.Programa>();
        //declarando novo objeto do tipo Model.Programa
        Model.Programa p = new Model.Programa();


        //declarando variável
        Int32 valorArquitetura = 0, i = 0;

        public Gerenciar_Programas()
        {
            InitializeComponent();
            ObterLista();
        }

        private void LimpaCampos()
        {
            txtBxNomePrograma.BackColor = Color.White;
            txtBxDiretorioPrograma.BackColor = Color.White;
            rdoBtn32bits.ForeColor = Color.Black;
            rdoBtn64bits.ForeColor = Color.Black;
            txtBxDiretorioPrograma.Text = "";
            txtBxNomePrograma.Text = "";
            txtBxArg.Text = "";
            rdoBtn32bits.Checked = false;
            rdoBtn64bits.Checked = false;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            MessageBox.Show(Properties.Settings.Default.CaminhoXML);
        }

        private void BtnCaminhoIcone_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarIcone = new OpenFileDialog();
            selecionarIcone.Filter = "Icones | * .ico";
            selecionarIcone.ShowDialog();
            String caminhoIconeStr = selecionarIcone.FileName;
            txtBxCaminhoIcone.Text = caminhoIconeStr;
        }

        private void BtnDiretorioPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarPrograma = new OpenFileDialog();
            selecionarPrograma.ShowDialog();
            String caminhoProgramaStr = selecionarPrograma.FileName;
            txtBxDiretorioPrograma.Text = caminhoProgramaStr;
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtBxNomePrograma.Text.Length != 0 && txtBxDiretorioPrograma.Text.Length != 0) && (rdoBtn32bits.Checked == true || rdoBtn64bits.Checked == true))
            {
                if (rdoBtn32bits.Checked == true)
                {
                    valorArquitetura = 32;
                }
                else if (rdoBtn64bits.Checked == true)
                {
                    valorArquitetura = 64;
                }
                //enviando dados para a lista
                SalvarXML();
                ObterLista();
                //DataGridToXML();
            }
            else
            {
                if (txtBxNomePrograma.Text.Length == 0 && txtBxDiretorioPrograma.Text.Length == 0)
                {
                    txtBxNomePrograma.BackColor = Color.Red;
                    txtBxDiretorioPrograma.BackColor = Color.Red;
                    MessageBox.Show("Preencha o nome e o caminho do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBxNomePrograma.Text.Length == 0)
                {
                    txtBxNomePrograma.BackColor = Color.Red;
                    MessageBox.Show("Preencha o nome do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBxDiretorioPrograma.Text.Length == 0)
                {
                    txtBxDiretorioPrograma.BackColor = Color.Red;
                    MessageBox.Show("Preencha o caminho do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (rdoBtn32bits.Checked == false && rdoBtn64bits.Checked == false)
                {
                    rdoBtn32bits.ForeColor = Color.Red;
                    rdoBtn64bits.ForeColor = Color.Red;
                    MessageBox.Show("Escolha uma das arquiteturas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SerializaPrograma(List<Model.Programa> ListaAlvoSerializacao)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute("Novos_Programas"));
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                SelecionarCaminhoXML();
            }
            FileStream xmlWriter = new FileStream(Properties.Settings.Default.CaminhoXML, FileMode.Create);
            xs.Serialize(xmlWriter, ListaAlvoSerializacao);
            xmlWriter.Close();
        }

        public void ObterLista()
        {
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                return;
            }

            try
            {
                ListaLocal.Clear();
                ListaLocal.AddRange(p.DeserializaPrograma());
                GradeDeDadosXML.DataSource = null;
                GradeDeDadosXML.DataSource = ListaLocal;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado. A tabela está vazia.", "Falha no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAdicionaNoDataGrid_Click(object sender, EventArgs e)
        {
            Int32 contagemDeLinhas = GradeDeDadosXML.Rows.Count;
            SalvaNaLista();
            GradeDeDadosXML.DataSource = null;
            GradeDeDadosXML.DataSource = ListaLocal;
        }

        private void TxtBxNomePrograma_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNomePrograma.BackColor == Color.Red)
            {
                txtBxNomePrograma.BackColor = Color.White;
            }
        }
        private void TxtBxDiretorioPrograma_TextChanged(object sender, EventArgs e)
        {
            if (txtBxDiretorioPrograma.BackColor == Color.Red)
            {
                txtBxDiretorioPrograma.BackColor = Color.White;
            }
        }

        private void RdoBtn32bits_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn32bits.ForeColor == Color.Red || rdoBtn64bits.ForeColor == Color.Red)
            {
                rdoBtn32bits.ForeColor = Color.Black;
                rdoBtn64bits.ForeColor = Color.Black;
            }
        }

        private void RdoBtn64bits_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtn32bits.ForeColor == Color.Red || rdoBtn64bits.ForeColor == Color.Red)
            {
                rdoBtn32bits.ForeColor = Color.Black;
                rdoBtn64bits.ForeColor = Color.Black;
            }
        }
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean SelecionarCaminhoXML()
        {
            SaveFileDialog mudarDiretorioXML = new SaveFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            if (mudarDiretorioXML.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
                Properties.Settings.Default.Save();
                return true;
            }
            else
            {
                Properties.Settings.Default.CaminhoXML = null;
                return false;
            }
        }

        private void SalvaNaLista()
        {
            p.IDPrograma = ListaLocal.Count;
            p.nomePrograma = txtBxNomePrograma.Text;
            p.caminhoIcone = txtBxCaminhoIcone.Text;
            p.diretorioPrograma = txtBxDiretorioPrograma.Text;
            p.arquiteturaPrograma = valorArquitetura;
        }

        private void ImportarXML()
        {
            OpenFileDialog mudarDiretorioXML = new OpenFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            mudarDiretorioXML.ShowDialog();
            Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
            Properties.Settings.Default.Save();
            ListaLocal.Clear();
            ListaLocal.AddRange(p.DeserializaPrograma());
            ObterLista();
        }

        private void CriarArquivoXML()
        {
            SaveFileDialog mudarDiretorioXML = new SaveFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            mudarDiretorioXML.ShowDialog();
            Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
            Properties.Settings.Default.Save();
            SerializaPrograma(ListaDeProgramasXML);
            ObterLista();
        }

        private void SalvarXML()
        {
            p.nomePrograma = txtBxNomePrograma.Text;
            //p.caminhoIcone = txtBxCaminhoIcone.Text;
            p.diretorioPrograma = txtBxDiretorioPrograma.Text;
            p.arquiteturaPrograma = valorArquitetura;
            p.IDPrograma = ListaLocal.Count;
            LimpaCampos();
            try
            {
                ListaDeProgramasXML.AddRange(p.DeserializaPrograma());
                ListaDeProgramasXML.Add(p);
                SerializaPrograma(ListaDeProgramasXML);
                ListaDeProgramasXML.Clear();
            }
            catch (FileNotFoundException)
            {
                Model.Programa.ListaDeProgramas.Add(p);
                SerializaPrograma(Model.Programa.ListaDeProgramas);
            }
            GradeDeDadosXML.FirstDisplayedScrollingRowIndex = GradeDeDadosXML.RowCount - 1;
        }

        private void GerarNovoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarArquivoXML();
        }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecionarCaminhoXML();
        }

        private void GradeDeDadosXML_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void ImportarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarXML();
        }

        private void BtnAvancarLista_Click(object sender, EventArgs e)
        {
            if (i < GradeDeDadosXML.Rows.Count)
            {
                if (i == 0)
                {
                    i++;
                }
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", i];
                i++;
                return;
            }
            if (i >= GradeDeDadosXML.Rows.Count)
            {
                i = 0;
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", i];
            }
        }
    }
}
