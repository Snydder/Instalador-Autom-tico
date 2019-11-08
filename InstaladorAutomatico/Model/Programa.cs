using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public void SelecionarLocalSalvamentoXML()
        {
            DialogResult resultado = new DialogResult();
            SaveFileDialog mudarDiretorioXML = new SaveFileDialog();
            mudarDiretorioXML.Filter = "Arquivo XML | * .xml";
            resultado = mudarDiretorioXML.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                List<Model.Programa> listaLimpa = new List<Model.Programa>();
                caminhoGeracaoXML = mudarDiretorioXML.FileName;
                SerializaPrograma(listaLimpa);
                if (File.Exists(caminhoGeracaoXML))
                {
                    MessageBox.Show("Altere o novo caminho do XML no arquivo de configuração para utilizá-lo, e reinicie o programa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        public Boolean VerificaPorXMLInicializacao()
        { 
            if (System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML") == null)
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para o arquivo XML está configurado. Deseja gerar um agora?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    List<Model.Programa> listaVazia = new List<Model.Programa>();
                    caminhoGeracaoXML = AppDomain.CurrentDomain.BaseDirectory + "\\Lista_de_Programas.xml";
                    SerializaPrograma(listaVazia);
                    if (File.Exists(caminhoGeracaoXML))
                    {
                        MessageBox.Show("O arquivo foi gerado na raiz desse programa. Aponte o novo local no arquivo de configuração.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!File.Exists(System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML")))
                {
                    DialogResult resultado = new DialogResult();
                    resultado = MessageBox.Show("O arquivo XML não foi encontrado. Deseja gerar um agora?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        List<Model.Programa> listaVazia = new List<Model.Programa>();
                        caminhoGeracaoXML = AppDomain.CurrentDomain.BaseDirectory + "\\Lista_de_Programas.xml";
                        SerializaPrograma(listaVazia);
                        if (File.Exists(caminhoGeracaoXML))
                        {
                            MessageBox.Show("O arquivo foi gerado na raiz desse programa. Aponte o novo local no arquivo de configuração.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        SerializaPrograma(listaVazia);
                        return false;
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
            if (System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML") == null)
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para o arquivo XML está configurado. Deseja escolher um arquivo?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML"));
                    return;
                }
                else
                {
                    List<Model.Programa> listaVazia = new List<Model.Programa>();
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
                            Process.Start("notepad.exe", System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML"));
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

            if (System.Configuration.ConfigurationManager.AppSettings.Get("LocalUAC") == null)
            {
                DialogResult resultado = new DialogResult();
                resultado = MessageBox.Show("Nenhum caminho para script do UAC está configurado. Deseja escolher um arquivo?", "Falha no carregamento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "\\InstaladorAutomatico.exe.config"));
                    Application.Exit();
                    return;
                }
            }
        }

        public void SerializaPrograma(List<Model.Programa> ListaAlvoSerializacao)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute(atributoXML));
            FileStream xmlWriter = new FileStream(caminhoGeracaoXML, FileMode.Create);
            xs.Serialize(xmlWriter, ListaAlvoSerializacao);
            xmlWriter.Close();
        }

        public List<Model.Programa> DeserializaPrograma()
        {
            List<Model.Programa> listaSendoDeserializada = new List<Model.Programa>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Model.Programa>), new XmlRootAttribute(atributoXML));
            if (System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML") == "")
            {
                MessageBox.Show("Nenhum caminho para o arquivo XML está configurado.", "Falha no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return listaSendoDeserializada;
            }
            if (!File.Exists(System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML")))
            {
                MessageBox.Show("O arquivo não existe. Verifique o arquivo de configuração e tente novamente.", "Falha no carregamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return listaSendoDeserializada;
            }
            else
            {
                caminhoGeracaoXML = System.Configuration.ConfigurationManager.AppSettings.Get("CaminhoXML");
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
