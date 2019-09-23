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
        //declarando lista local
        [XmlElement(ElementName = "ListaDePrograma")]
        List<Model.Programa> ListaDeProgramasXML;
        Model.Programa p = new Model.Programa();

        public Gerenciar_Programas()
        {
            InitializeComponent();
            ListaDeProgramasXML = new List<Model.Programa>();
            
            
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtBxCaminhoPrograma.Text = "";
            txtBxNomePrograma.Text = "";
            txtBxArg.Text = "";
            rdoBtn32bits.Checked = false;
            rdoBtn64bits.Checked = false;
        }

        private void BtnCaminhoPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarPrograma = new OpenFileDialog();
            selecionarPrograma.ShowDialog();
            String caminhoProgramaStr = selecionarPrograma.FileName;
            txtBxCaminhoPrograma.Text = caminhoProgramaStr;
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declarando variáveis
            //String validaNomePrograma;
            //String validaCaminhoPrograma;
            Int32 valorArquitetura = 0;

            //validaNomePrograma = GradeDeDadosXML.Rows[p.IDPrograma].Cells["nomeProgramaDataGridViewTextBoxColumn"].Value.ToString();
            //validaCaminhoPrograma = GradeDeDadosXML.Rows[p.IDPrograma].Cells["caminhoProgramaDataGridViewTextBoxColumn"].Value.ToString();
            if ((txtBxNomePrograma.Text.Length != 0 && txtBxCaminhoPrograma.Text.Length != 0) && (rdoBtn32bits.Checked == true || rdoBtn64bits.Checked == true))
            {
                txtBxNomePrograma.BackColor = Color.White;
                txtBxCaminhoPrograma.BackColor = Color.White;
                rdoBtn32bits.ForeColor = Color.Black;
                rdoBtn64bits.ForeColor = Color.Black;

                //depreciado
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
                p.caminhoPrograma = txtBxCaminhoPrograma.Text;
                try
                {
                    DeserializaPrograma();
                    ListaDeProgramasXML.Add(p);
                    SerializaPrograma(ListaDeProgramasXML);
                    Model.Programa.ListaDeProgramas.AddRange(ListaDeProgramasXML);
                    ListaDeProgramasXML.Clear();
                }
                catch (FileNotFoundException)
                {
                    Model.Programa.ListaDeProgramas.Add(p);
                    SerializaPrograma(Model.Programa.ListaDeProgramas);
                }
            }
            else
            {
                if (txtBxNomePrograma.Text.Length == 0 && txtBxCaminhoPrograma.Text.Length == 0)
                {
                    txtBxNomePrograma.BackColor = Color.Red;
                    txtBxCaminhoPrograma.BackColor = Color.Red;
                    MessageBox.Show("Preencha o nome e o caminho do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBxNomePrograma.Text.Length == 0)
                {
                    txtBxNomePrograma.BackColor = Color.Red;
                    MessageBox.Show("Preencha o nome do programa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBxCaminhoPrograma.Text.Length == 0)
                {
                    txtBxCaminhoPrograma.BackColor = Color.Red;
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
        public void SerializaPrograma(List<Model.Programa> ListaProgramasSerializada)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute("Novos_Programas"));
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                SelecionarCaminhoXML();
            }
            FileStream xmlWriter = new FileStream(Properties.Settings.Default.CaminhoXML, FileMode.Create);
            xs.Serialize(xmlWriter, ListaProgramasSerializada);
            xmlWriter.Close();
        }

        public void DeserializaPrograma()
        {
            List<Model.Programa> listaSendoDeserializada = new List<Model.Programa>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute("Novos_Programas"));
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                SelecionarCaminhoXML();
            }
            FileStream reader = new FileStream(Properties.Settings.Default.CaminhoXML, FileMode.Open, FileAccess.Read, FileShare.Read);
            listaSendoDeserializada = (List<Model.Programa>)serializer.Deserialize(reader);
            reader.Close();
            ListaDeProgramasXML.AddRange(listaSendoDeserializada);
        }

        private void TxtBxNomePrograma_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNomePrograma.BackColor == Color.Red)
            {
                txtBxNomePrograma.BackColor = Color.White;
            }
        }

        private void TxtBxCaminhoPrograma_TextChanged(object sender, EventArgs e)
        {
            if (txtBxCaminhoPrograma.BackColor == Color.Red)
            {
                txtBxCaminhoPrograma.BackColor = Color.White;
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

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelecionarCaminhoXML();
        }

        private void GradeDeDadosXML_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
