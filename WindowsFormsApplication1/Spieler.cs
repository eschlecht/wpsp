using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Spieler
    {
        public string Name { get; private set; }
        public string Vorname { get; private set; }
        public string Position { get; private set; }
        public int Nummer { get; private set; }
        public string Seit { get; private set; }
        public string Bday { get; private set; }
        public int Size { get; private set; }
        public int Weight { get; private set; }
        public string Games { get; private set; }
        public string Goals { get; private set; }
        public string Nation { get; private set; }
        public string International { get; private set; }

        public Spieler(string name, string vorname, string position, int nummer, string seit, string bday, int size, int weight, string games,
        string goals, string nation, string international)
        {
            Name = name;
            Vorname = vorname;
            Position = position;
            Nummer = nummer;
            Seit = seit;
            Bday = bday;
            Size = size;
            Weight = weight;
            Games = games;
            Goals = goals;
            Nation = nation;
            International = international;
    }
        public override string ToString()
        {
            return Name + "," + Vorname;
        }
    }
    
}
