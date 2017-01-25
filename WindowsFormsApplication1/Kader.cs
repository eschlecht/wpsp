using System.Collections.Generic;
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
