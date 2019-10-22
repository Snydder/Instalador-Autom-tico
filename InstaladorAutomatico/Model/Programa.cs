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

namespace InstaladorAutomatico.Model
{
    [Serializable, XmlRoot("Programa")]
    public class Programa
    {
        //declaracao da lista de objetos
        public static List<Model.Programa> ListaDeProgramas = new List<Model.Programa>();

        //Indicando caminho padrão 
        static String nomeDeUsuario = Environment.UserName;
        public String caminhoPadrao = $"C:\\Users\\{nomeDeUsuario}\\Desktop\\Lista de programas.xml";

        [XmlElement(ElementName = "IDPrograma")]
        public Int32 IDPrograma { get; set; }

        [XmlElement(ElementName = "nomePrograma")]
        public String nomePrograma { get; set; }

        [XmlElement(ElementName = "caminhoIcone")]
        public String caminhoIcone { get; set; }

        [XmlElement(ElementName = "diretorioPrograma")]
        public String diretorioPrograma { get; set; }

        [XmlElement(ElementName = "arquiteturaPrograma")]
        public Int32 arquiteturaPrograma { get; set; }

        public Boolean MudarDiretorioDoXML()
        {
            OpenFileDialog mudarDiretorioXML = new OpenFileDialog();
            DialogResult resultado = new DialogResult();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            mudarDiretorioXML.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
                Properties.Settings.Default.Save(); 
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SelecionarLocalSalvamentoXML()
        {
            DialogResult resultado = new DialogResult();
            SaveFileDialog mudarDiretorioXML = new SaveFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            if (resultado == DialogResult.OK)
            {
                Properties.Settings.Default.CaminhoXML = mudarDiretorioXML.FileName;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.CaminhoXML = caminhoPadrao;
                Properties.Settings.Default.Save();
            }
        }

        public void VerificaSelecionarLocalSalvamentoXML()
        {
            if (Properties.Settings.Default.CaminhoXML == null);
            {
                DialogResult resultado = new DialogResult();
                MessageBox.Show("Nenhum caminho para o arquivo XML está configurado. Deseja escolher um arquivo?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    SelecionarLocalSalvamentoXML();
                }
                else
                {
                    Properties.Settings.Default.CaminhoXML = caminhoPadrao;
                    Properties.Settings.Default.Save();
                }
            }
        }
        public List<Model.Programa> DeserializaPrograma()
        {
            List<Model.Programa> listaSendoDeserializada = new List<Model.Programa>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute("Novos_Programas"));
            if (Properties.Settings.Default.CaminhoXML == "" || Properties.Settings.Default.CaminhoXML == caminhoPadrao);
            {
                SelecionarLocalSalvamentoXML();
            }
            FileStream reader = new FileStream(Properties.Settings.Default.CaminhoXML, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            try
            {
                listaSendoDeserializada = (List<Model.Programa>)serializer.Deserialize(reader);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erro ao importar o documento XML.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
            return listaSendoDeserializada;
        }
    }
}
