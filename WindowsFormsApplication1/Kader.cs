using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Kader
    {
        public int count = 0;
        private List<Spieler> KaderCollection;

        public Spieler getSpieler(int index)
        {
            if (0 <= index)
            {
                if (this.KaderCollection.Count > index)
                {
                    return this.KaderCollection[index];
                }
            }
            return this.KaderCollection[0];
        }

        public Kader()
        {
            this.KaderCollection = new List<Spieler>();
        }
        public Boolean AddToList(Spieler spieler)
        {
            this.KaderCollection.Add(spieler);
            count++;
            return true;
        }
    }
}
