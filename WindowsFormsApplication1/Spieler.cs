using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("Spieler")]
    public class Spieler
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Vorname")]
        public string Vorname { get; set; }

        [XmlElement("Position")]
        public string Position { get; set; }

        [XmlElement("Rueckennummer")]
        public int Rueckennummer { get; set; }

        [XmlElement("Seit")]
        public string Seit { get; set; }

        [XmlElement("GeburtsDatum")]
        public string GeburtsDatum { get; set; }

        [XmlElement("GroesseInCm")]
        public int GroesseInCm { get; set; }

        [XmlElement("GewichtInKg")]
        public int GewichtInKg { get; set; }

        [XmlElement("SpieleInBundesliga")]
        public string SpieleInBundesliga { get; set; }

        [XmlElement("ToreInBundesliga")]
        public string ToreInBundesliga { get; set; }

        [XmlElement("Nation")]
        public string Nation { get; set; }

        [XmlElement("Laenderspiele")]
        public string Laenderspiele { get; set; }
        
        public override string ToString()
        {
            return Name + "," + Vorname;
        }
    }
    
}
