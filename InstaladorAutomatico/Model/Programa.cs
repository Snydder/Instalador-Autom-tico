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
using InstaladorAutomatico.View;

namespace InstaladorAutomatico.Model
{
    [Serializable, XmlRoot("Programa")]
    public class Programa
    {
        //declaracao da lista de objetos
        public static List<Model.Programa> ListaDeProgramas = new List<Model.Programa>();
        private String atributoXML = "Novos_Programas";

        //Indicando caminho padrão 
        static String nomeDeUsuario = Environment.UserName;
        private String caminhoPadrao = $"C:\\Users\\{nomeDeUsuario}\\Desktop\\Lista_de_programas.xml";

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
            resultado = mudarDiretorioXML.ShowDialog();
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
            OpenFileDialog mudarDiretorioXML = new OpenFileDialog();
            resultado = mudarDiretorioXML.ShowDialog();
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

        public void SelecionarLocalUAC()
        {
            DialogResult resultado = new DialogResult();
            OpenFileDialog mudarDiretorioUAC = new OpenFileDialog();
            resultado = mudarDiretorioUAC.ShowDialog();
            mudarDiretorioUAC.Filter = "Arquivo XML | * .xml";
            if (resultado == DialogResult.OK)
            {
                Properties.Settings.Default.LocalUAC = mudarDiretorioUAC.FileName;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.LocalUAC = "";
                Properties.Settings.Default.Save();
            }
        }

        public void VerificaPorXMLInicializacao()
        {
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para o arquivo XML está configurado. Deseja escolher um arquivo?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    SelecionarLocalSalvamentoXML();
                }
                else
                {
                    List<Model.Programa> listaVazia = new List<Model.Programa>();
                    Properties.Settings.Default.CaminhoXML = caminhoPadrao;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("O local padrão foi definido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (Properties.Settings.Default.CaminhoXML == caminhoPadrao)
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("O caminho padrão para o arquivo XML está configurado. Deseja alterá-lo?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    SelecionarLocalSalvamentoXML();
                }
                else
                {
                    if (File.Exists(caminhoPadrao))
                    {
                        return;
                    }
                    else
                    {
                        List<Model.Programa> listaVazia = new List<Model.Programa>();
                        Properties.Settings.Default.CaminhoXML = caminhoPadrao;
                        Properties.Settings.Default.Save();
                        SerializaPrograma(listaVazia);
                        if (File.Exists(caminhoPadrao))
                        {
                            MessageBox.Show("O arquivo foi criado com êxito.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao criar o arquivo. Escolher outro local?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (resultado == DialogResult.Yes)
                            {
                                SelecionarLocalSalvamentoXML();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }

        public void VerificaSelecionarLocalSalvamentoXML()
        {
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para o arquivo XML está configurado. Deseja escolher um arquivo?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    SelecionarLocalSalvamentoXML();
                }
                else
                {
                    List<Model.Programa> listaVazia = new List<Model.Programa>();
                    Properties.Settings.Default.CaminhoXML = caminhoPadrao;
                    Properties.Settings.Default.Save();
                    SerializaPrograma(listaVazia);
                    if (File.Exists(caminhoPadrao))
                    {
                        MessageBox.Show($"O local padrão foi definido em {caminhoPadrao} e o arquivo foi gerado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao criar o arquivo. Escolher outro local?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (resultado == DialogResult.Yes)
                        {
                            SelecionarLocalSalvamentoXML();
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        public void VerificaLocalUAC()
        {

            if (Properties.Settings.Default.LocalUAC == "")
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para script do UAC está configurado. Deseja escolher um arquivo?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    SelecionarLocalUAC();
                }
            }
        }

        public void SerializaPrograma(List<Model.Programa> ListaAlvoSerializacao)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute(atributoXML));
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                SelecionarLocalSalvamentoXML();
            }
            FileStream xmlWriter = new FileStream(Properties.Settings.Default.CaminhoXML, FileMode.Create);
            xs.Serialize(xmlWriter, ListaAlvoSerializacao);
            xmlWriter.Close();
        }

        public List<Model.Programa> DeserializaPrograma()
        {
            List<Model.Programa> listaSendoDeserializada = new List<Model.Programa>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute(atributoXML));
            if (Properties.Settings.Default.CaminhoXML == "")
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
