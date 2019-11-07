using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //private String caminhoPadrao = $"C:\\Users\\{nomeDeUsuario}\\Desktop\\Lista_de_programas.xml";
        private String caminhoPadrao = AppDomain.CurrentDomain.BaseDirectory + "\\Lista_de_programas.xml";
        String caminhoGeracaoXML;

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
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Save();
            }
        }

        public void SelecionarLocalUAC()
        {
            DialogResult resultado = new DialogResult();
            OpenFileDialog mudarDiretorioUAC = new OpenFileDialog();
            mudarDiretorioUAC.InitialDirectory = Properties.Settings.Default.LocalUAC;
            resultado = mudarDiretorioUAC.ShowDialog();
            mudarDiretorioUAC.Filter = "Arquivo .bat | * .bat";
            if (resultado == DialogResult.OK)
            {
                Properties.Settings.Default.Save();
                MessageBox.Show("O local do UAC foi alterado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        public void SelecionarLocalPastaTI()
        {
            DialogResult resultado = new DialogResult();
            FolderBrowserDialog mudarDiretorioTI = new FolderBrowserDialog();

            resultado = mudarDiretorioTI.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //Properties.Settings.Default.DestinoCopia = mudarDiretorioTI.SelectedPath;
                Properties.Settings.Default.Save();
                MessageBox.Show("O local da pasta TI foi alterada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Properties.Settings.Default.DestinoCopia = "C:\\TI";
                Properties.Settings.Default.Save();
            }
        }

        public Boolean VerificaPorXMLInicializacao()
        {
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para o arquivo XML está configurado. Deseja gerar um agora?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    List<Model.Programa> listaVazia = new List<Model.Programa>();
                    SerializaPrograma(listaVazia);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!File.Exists(Properties.Settings.Default.CaminhoXML))
                {
                    DialogResult resultado = new DialogResult();
                    resultado = MessageBox.Show("O arquivo XML não foi encontrado. Deseja gerar um agora?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        List<Model.Programa> listaVazia = new List<Model.Programa>();
                        SerializaPrograma(listaVazia);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
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
                    Process.Start("notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "\\InstaladorAutomatico.exe.config");
                    return;
                }
                else
                {
                    List<Model.Programa> listaVazia = new List<Model.Programa>();
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
                            Process.Start("notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "\\InstaladorAutomatico.exe.config");
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
                    Process.Start("notepad.exe", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\InstaladorAutomatico.exe.config"));
                }
            }
        }

        public void SerializaPrograma(List<Model.Programa> ListaAlvoSerializacao)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute(atributoXML));
            if (!File.Exists(Properties.Settings.Default.CaminhoXML))
            {
                caminhoGeracaoXML = AppDomain.CurrentDomain.BaseDirectory + "Lista_de_programas.xml";
            }
            else
            {
                caminhoGeracaoXML = Properties.Settings.Default.CaminhoXML;
            }
            FileStream xmlWriter = new FileStream(caminhoGeracaoXML, FileMode.Create);
            xs.Serialize(xmlWriter, ListaAlvoSerializacao);
            xmlWriter.Close();
        }

        public List<Model.Programa> DeserializaPrograma()
        {
            List<Model.Programa> listaSendoDeserializada = new List<Model.Programa>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute(atributoXML));
            if (Properties.Settings.Default.CaminhoXML == "")
            {
                Process.Start("notepad.exe", AppDomain.CurrentDomain.BaseDirectory + "\\InstaladorAutomatico.exe.config");
                return listaSendoDeserializada;
            }
            FileStream reader = new FileStream(caminhoGeracaoXML, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
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
