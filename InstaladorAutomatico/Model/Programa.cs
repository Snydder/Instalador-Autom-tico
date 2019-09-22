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


        [XmlElement(ElementName = "IDPrograma")]
        public Int32 IDPrograma { get; set; }

        [XmlElement(ElementName = "nomePrograma")]
        public String nomePrograma { get; set; }

        [XmlElement(ElementName = "caminhoPrograma")]
        public String caminhoPrograma { get; set; }

        [XmlElement(ElementName = "arquiteturaPrograma")]
        public Int32 arquiteturaPrograma { get; set; }
    }
}
