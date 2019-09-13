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
    [XmlRoot("Programa")]
    public class Programa
    {
        [XmlElement("var1")]
        public String nomePrograma { get; set; }
        [XmlElement("var2")]
        public String caminhoPrograma { get; set; }
        [XmlElement("var3")]
        public int arquiteturaPrograma { get; set; }

        public class GuardaProgramas
        {
            List<Programa> ListaProgramas = new List<Programa>();
        }
    }
}
