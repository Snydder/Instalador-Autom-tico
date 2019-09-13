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
    public partial class Novo_Programa : Form
    {
        //declaracao da lista de objetos
        [XmlElement("ListaDePrograma")]
        List<Model.Programa> ListaDeProgramas;

        List<Model.Programa> ListaDeProgramasXML;

        Model.Programa p = new Model.Programa();
        public Novo_Programa()
        {
            InitializeComponent();
            //inicializando a lista
            ListaDeProgramas = new List<Model.Programa>();
            ListaDeProgramasXML = new List<Model.Programa>();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtBxCaminhoPrograma.Text = null;
            txtBxNomePrograma.Text = null;
            txtBxArg.Text = null;
            rdoBtn32bits.Checked = false;
            rdoBtn64bits.Checked = false;
        }

        private void BtnCaminhoPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarPrograma = new OpenFileDialog();
            selecionarPrograma.ShowDialog();
            string caminhoProgramaStr = selecionarPrograma.FileName;
            txtBxCaminhoPrograma.Text = caminhoProgramaStr;
        }



        /*public void ObterConfiguracoes()
        {
            label4.Text = Properties.Settings.Default.NomePrograma;
             label5.Text = Properties.Settings.Default.LocalPrograma;
            label7.Text = Properties.Settings.Default.ArquiteturaPrograma.ToString();
        }

        public void SalvarConfiguracoes()
        {
            if ((txtBxNomePrograma.Text.Length != 0 && txtBxCaminhoPrograma.Text.Length != 0) && (rdoBtn32bits.Checked == true || rdoBtn64bits.Checked == true))
            {
                txtBxNomePrograma.BackColor = Color.White;
                txtBxCaminhoPrograma.BackColor = Color.White;
                rdoBtn32bits.ForeColor = Color.Black;
                rdoBtn64bits.ForeColor = Color.Black;
                Properties.Settings.Default.NomePrograma = txtBxNomePrograma.Text;
                Properties.Settings.Default.LocalPrograma = txtBxCaminhoPrograma.Text;
                if (rdoBtn32bits.Checked == true)
                {
                    Properties.Settings.Default.ArquiteturaPrograma = 32;
                }
                else if (rdoBtn64bits.Checked == true)
                {
                    Properties.Settings.Default.ArquiteturaPrograma = 64;
                }
                Properties.Settings.Default.Save();
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
        }*/

        private void Novo_Programa_Load(object sender, EventArgs e)
        {
            //ObterConfiguracoes();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //SalvarConfiguracoes();
            //ObterConfiguracoes();
            int valorArquitetura = 0;
            if ((txtBxNomePrograma.Text.Length != 0 && txtBxCaminhoPrograma.Text.Length != 0) && (rdoBtn32bits.Checked == true || rdoBtn64bits.Checked == true))
            {
                txtBxNomePrograma.BackColor = Color.White;
                txtBxCaminhoPrograma.BackColor = Color.White;
                rdoBtn32bits.ForeColor = Color.Black;
                rdoBtn64bits.ForeColor = Color.Black;
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
                p.nomePrograma = txtBxNomePrograma.Text;
                p.caminhoPrograma = txtBxCaminhoPrograma.Text;
                DeserializaPrograma(ListaDeProgramasXML);
                //ListaDeProgramas.AddRange(ListaDeProgramasXML);
                ListaDeProgramas.Add(p);
                SerializaPrograma(ListaDeProgramas);
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

            /*Model.Programa NP = new Model.Programa();

            NP = recebePrograma;

            XmlSerializer xs = new XmlSerializer(typeof(Model.Programa));

            TextWriter txtWriter = new StreamWriter(@"C:\\Users\\mperc\\Desktop\\teste.xml");

            xs.Serialize(txtWriter, NP);

            txtWriter.Close();*/

            XmlSerializer xs = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute("Novos_Programas"));

            StreamWriter txtWriter = new StreamWriter(@"C:\\Users\\mperc\\Desktop\\teste.xml");

            xs.Serialize(txtWriter.BaseStream, ListaProgramasSerializada);
            txtWriter.Close();
        }

        public void DeserializaPrograma(List<Model.Programa> listaProgramasDeserializada)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute("Novos_Programas"));
            StringReader reader = new StringReader(@"C:\\Users\\mperc\\Desktop\\teste.xml");

            listaProgramasDeserializada = (List<Model.Programa>) serializer.Deserialize(reader);
            reader.Close();
            listaProgramasDeserializada.AddRange(ListaDeProgramasXML);
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
    }


}
