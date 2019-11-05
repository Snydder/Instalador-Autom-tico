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
        List<Model.Programa> ListaLocal2 = new List<Model.Programa>();

        //declarando novo objeto do tipo Model.Programa
        Model.Programa p = new Model.Programa();


        //declarando variável
        Int32 valorArquitetura = 0, l = 0;

        public Gerenciar_Programas()
        {
            InitializeComponent();
        }
        private void Gerenciar_Programas_Load(object sender, EventArgs e)
        {
            ObterLista();
            nomeProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            diretorioProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            arquiteturaProgramaDataGridViewTextBoxColumn.ReadOnly = true;
            GradeDeDadosXML.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GradeDeDadosXML.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GradeDeDadosXML.CellClick -= GradeDeDadosXML_CellClick;
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
            OpenFileDialog selecionarIcone = new OpenFileDialog
            {
                Filter = "Icones | * .ico"
            };
            selecionarIcone.ShowDialog();
            String caminhoIconeStr = selecionarIcone.FileName;
            txtBxCaminhoIcone.Text = caminhoIconeStr;
            selecionarIcone.Dispose();
        }

        private void BtnDiretorioPrograma_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarPrograma = new OpenFileDialog();
            selecionarPrograma.ShowDialog();
            String caminhoProgramaStr = selecionarPrograma.FileName;
            txtBxDiretorioPrograma.Text = caminhoProgramaStr;
            if (txtBxNomePrograma.Text == "")
            {
                txtBxNomePrograma.Text = Path.GetFileNameWithoutExtension(selecionarPrograma.SafeFileName);
            }
            selecionarPrograma.Dispose();
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidaSalvaXML();
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
            ValidaSalvaXML();
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

        private void ImportarXML()
        {
            if (p.MudarDiretorioDoXML() == true)
            {
                ListaLocal.Clear();
                ListaLocal.AddRange(p.DeserializaPrograma());
                ObterLista();
            }
            else
            {
                return;
            }
        }

        private void CriarArquivoXML()
        {
            p.SelecionarLocalSalvamentoXML();
            p.SerializaPrograma(ListaDeProgramasXML);
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
                ListaDeProgramasXML.Clear();
                ListaDeProgramasXML.AddRange(p.DeserializaPrograma());
                ListaDeProgramasXML.Add(p);
                p.SerializaPrograma(ListaDeProgramasXML);
            }
            catch (FileNotFoundException)
            {
                Model.Programa.ListaDeProgramas.Add(p);
                p.SerializaPrograma(Model.Programa.ListaDeProgramas);
            }
            if (GradeDeDadosXML.RowCount > 2)
            {
                GradeDeDadosXML.FirstDisplayedScrollingRowIndex = GradeDeDadosXML.RowCount - 1;
            }
        }

        private void MarcaCampos()
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
        private Boolean ValidaCampos()
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
                return true;
            }
            else return false;
        }

        private void ValidaSalvaXML()
        {
            if (ValidaCampos() == true)
            {
                //enviando dados para a lista
                SalvarXML();
                ObterLista();
            }
            else
            {
                MarcaCampos();
            }
        }

        private void BtnAdiciona(object sender, EventArgs e)
        {
            ValidaSalvaXML();
        }

        public virtual void RemoverDaLista(Int32 id)
        {
            //remover item da Lista aqui
            ListaLocal2.AddRange(ListaLocal);
            ListaLocal2 = ListaLocal2.Where(p => p.IDPrograma != id).ToList();
            ListaLocal.Clear();
            ListaLocal.AddRange(ListaLocal2);
            ListaLocal2.Clear();
            p.SerializaPrograma(ListaLocal);
            ReorganizaID();
            ObterLista();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverDaLista(Int32.Parse(Convert.ToString(GradeDeDadosXML.Rows[GradeDeDadosXML.CurrentCell.RowIndex].Cells["iDProgramaDataGridViewTextBoxColumn"].Value)));
            ReorganizaID();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarXML();
        }

        private void importarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportarXML();
        }

        private void gerarNovoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarArquivoXML();
        }

        private void localizarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog LocalizarXML = new OpenFileDialog
            {
                Filter = "Arquivo XML | * .xml",
                InitialDirectory = Properties.Settings.Default.CaminhoXML
            };
            LocalizarXML.ShowDialog();
            LocalizarXML.Dispose();
        }

        private void BtnSubirLista_Click(object sender, EventArgs e)
        {

            int indexFonte, indexAlvo;

            indexFonte = Int32.Parse(GradeDeDadosXML.CurrentCell.Value.ToString());
            indexAlvo = indexFonte - 1;

            if (indexAlvo < 0)
            {
                l = GradeDeDadosXML.RowCount - 1;
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", l];
                return;
                //indexFonte = GradeDeDadosXML.RowCount - 1;
                //indexAlvo = 0;
            }

            ListaLocal2.AddRange(ListaLocal);
            var itemLista = ListaLocal2[indexFonte];
            ListaLocal2.RemoveAt(indexFonte);
            ListaLocal2.Insert(indexAlvo, itemLista);
            ListaLocal2[indexAlvo].IDPrograma = ListaLocal2[indexFonte].IDPrograma;
            ListaLocal2[indexFonte].IDPrograma = ListaLocal2[indexAlvo].IDPrograma;
            ListaLocal.Clear();
            ListaLocal.AddRange(ListaLocal2);
            ListaLocal2.Clear();
            p.SerializaPrograma(ListaLocal);
            ReorganizaID();
            ObterLista();
            l = GradeDeDadosXML.CurrentCell.RowIndex - 1;
            if (l < GradeDeDadosXML.Rows.Count)
            {

                if (l < 0)
                {
                    l = GradeDeDadosXML.RowCount - 1;
                    GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", l];
                    return;
                }
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", l];
            }
        }

        private void BtnDescerLista_Click(object sender, EventArgs e)
        {
            int indexFonte, indexAlvo;

            indexFonte = Int32.Parse(GradeDeDadosXML.CurrentCell.Value.ToString());
            indexAlvo = indexFonte + 1;

            if (indexAlvo >= GradeDeDadosXML.RowCount)
            {
                l = 0;
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", l];
                return;
            }

            ListaLocal2.AddRange(ListaLocal);
            var itemLista = ListaLocal2[indexFonte];
            ListaLocal2.RemoveAt(indexFonte);
            ListaLocal2.Insert(indexAlvo, itemLista);
            ListaLocal2[indexAlvo].IDPrograma = ListaLocal2[indexFonte].IDPrograma;
            ListaLocal2[indexFonte].IDPrograma = ListaLocal2[indexAlvo].IDPrograma;
            ListaLocal.Clear();
            ListaLocal.AddRange(ListaLocal2);
            ListaLocal2.Clear();
            p.SerializaPrograma(ListaLocal);
            ReorganizaID();
            ObterLista();
            l = GradeDeDadosXML.CurrentCell.RowIndex + 1;

            if (l < GradeDeDadosXML.Rows.Count)
            {
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", l];
            }
            else if (l >= GradeDeDadosXML.RowCount)
            {
                l = 0;
                GradeDeDadosXML.CurrentCell = GradeDeDadosXML["iDProgramaDataGridViewTextBoxColumn", l];
            }
        }

        private void alterarLocalUACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.SelecionarLocalUAC();
        }

        private void GradeDeDadosXML_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
        }

        private void GradeDeDadosXML_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
        }

        private void alterarLocalPastaTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.SelecionarLocalPastaTI();
        }

        private void GradeDeDadosXML_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return; 
            }
        }

        private void ReorganizaID ()
        {
            int elementosLista = 0, i;
            ListaLocal2.AddRange(ListaLocal);
            ListaLocal2.Sort((ID1, ID2) => ID1.IDPrograma.CompareTo(ID2.IDPrograma));
            elementosLista = ListaLocal2.Count;
            for (i = 0; i < elementosLista; i++)
            {
                ListaLocal2[i].IDPrograma = i;
            }
            ListaLocal.Clear();
            ListaLocal.AddRange(ListaLocal2);
            ListaLocal2.Clear();
            p.SerializaPrograma(ListaLocal);
        }
    }
}
