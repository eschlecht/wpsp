using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("Kader")]
    public class Kader
    {
        [XmlArray("SpielerListe")]
        [XmlArrayItem("Spieler", typeof(Spieler))]
        public List<Spieler> Spielers { get; set; }
    }
}
