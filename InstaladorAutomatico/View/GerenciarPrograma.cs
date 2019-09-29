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
        List<Model.Programa> ListaDeProgramasXML;
        List<Model.Programa> ListaLocal = new List<Model.Programa>();
        Model.Programa p = new Model.Programa();
        public Gerenciar_Programas()
        {
            InitializeComponent();
            ListaDeProgramasXML = new List<Model.Programa>();
            ObterLista();
        }

        private void Gerenciar_Programas_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CaminhoXML != "")
            {
                /*try
                {
                    DeserializaPrograma();
                }
                catch (FileNotFoundException)
                {
                    if (MessageBox.Show("XML não encontrado. Deseja carregar a lista padrão?", "Aviso.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Carregar Lista Padrão de programas.
                        SerializaPrograma(ListaDeProgramasXML);
                        DeserializaPrograma();
                    }
                    else
                    {
                        //prosseguir sem carregar a lista.
                    }
                    
                }*/
            }
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
            //declarando variável
            Int32 valorArquitetura = 0;
            if ((txtBxNomePrograma.Text.Length != 0 && txtBxDiretorioPrograma.Text.Length != 0) && (rdoBtn32bits.Checked == true || rdoBtn64bits.Checked == true))
            {
                LimpaCampos();

                if (rdoBtn32bits.Checked == true)
                {
                    valorArquitetura = 32;
                    p.arquiteturaPrograma = valorArquitetura;
                }
                else if (rdoBtn64bits.Checked == true)
                {
                    valorArquitetura = 64;
                    p.arquiteturaPrograma = valorArquitetura;
                }


                //enviando dados para a lista
                //p.nomePrograma = GradeDeDadosXML.Rows[p.IDPrograma].Cells["nomeProgramaDataGridViewTextBoxColumn"].Value.ToString();
                //p.caminhoPrograma = GradeDeDadosXML.Rows[p.IDPrograma].Cells["caminhoProgramaDataGridViewTextBoxColumn"].Value.ToString();
                p.nomePrograma = txtBxNomePrograma.Text;
                //p.caminhoIcone = txtBxCaminhoIcone.Text;
                p.diretorioPrograma = txtBxDiretorioPrograma.Text;
                try
                {
                    ListaDeProgramasXML.AddRange(p.DeserializaPrograma());
                    ListaDeProgramasXML.Add(p);
                    SerializaPrograma(ListaDeProgramasXML);
                    Model.Programa.ListaDeProgramas.AddRange(ListaDeProgramasXML);
                    GradeDeDadosXML.DataSource = Model.Programa.ListaDeProgramas;
                    ListaDeProgramasXML.Clear();
                }
                catch (FileNotFoundException)
                {
                    Model.Programa.ListaDeProgramas.Add(p);
                    SerializaPrograma(Model.Programa.ListaDeProgramas);
                }
                /*try
                {
                    ListaDeProgramasXML.AddRange(p.DeserializaPrograma());
                    ListaDeProgramasXML.Add(p);
                    SerializaPrograma(ListaDeProgramasXML);
                    Model.Programa.ListaDeProgramas.AddRange(ListaDeProgramasXML);
                    GradeDeDadosXML.DataSource = Model.Programa.ListaDeProgramas;
                    ListaDeProgramasXML.Clear();
                }
                catch (FileNotFoundException)
                {
                    Model.Programa.ListaDeProgramas.Add(p);
                    SerializaPrograma(Model.Programa.ListaDeProgramas);
                }*/
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

        public Boolean ObterLista()
        {
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                MessageBox.Show("Nenhum caminho para o arquivo XML está configurado.", "Falha no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelecionarCaminhoXML();
            }

            try
            {
                ListaLocal.AddRange(p.DeserializaPrograma());
                GradeDeDadosXML.DataSource = ListaLocal;
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado. A tabela está vazia.", "Falha no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ObterLista() == true)
                {
                    this.p.DeserializaPrograma();
                }
                return false;
            }
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

        private void SelecionarCaminhoXML()
        {
            SaveFileDialog mudarDiretorioXML = new SaveFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            mudarDiretorioXML.ShowDialog();
            Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
            Properties.Settings.Default.Save();
        }

        private void ImportandoXML()
        {
            OpenFileDialog mudarDiretorioXML = new OpenFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            mudarDiretorioXML.ShowDialog();
            Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
            Properties.Settings.Default.Save();
            ListaLocal.Clear();
            ListaLocal.AddRange(p.DeserializaPrograma());
            GradeDeDadosXML.DataSource = null;
            GradeDeDadosXML.DataSource = ListaLocal;
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
            ImportandoXML();
        }
    }
}
