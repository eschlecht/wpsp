using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSpielerData();
            comboBox1.SelectedIndex = 0;
        }
        private void LoadSpielerData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("SpielerData.xml");
            int i = 0;
            foreach (XmlNode node in doc.DocumentElement)
            {
                string spieler = node["Spieler"].InnerText;

                foreach (XmlNode childNode in node.ChildNodes)
                {

                    string name = childNode["Name"].InnerText;
                    string vorname = childNode["Vorname"].InnerText;
                    string position = childNode["Position"].InnerText;
                    int nummer = int.Parse(childNode["Rueckennummer"].InnerText);
                    string seit = childNode["Seit"].InnerText;
                    string bday = childNode["GeburtsDatum"].InnerText;
                    int size = int.Parse(childNode["GroesseInCm"].InnerText);
                    int weight = int.Parse(childNode["GewichtInKg"].InnerText);
                    string games = childNode["SpieleInBundesliga"].InnerText;
                    string goals = childNode["ToreInBundesliga"].InnerText;
                    string nation = childNode["Nation"].InnerText;
                    string internationl = childNode["Laenderspiele"].InnerText;
                    comboBox1.Items.Add(new Spieler(name, vorname, position, nummer, seit, bday, size, weight, games, goals, nation, internationl));

                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void toFirstBtn_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1)
            {
                propertyGrid1.SelectedObject = comboBox1.SelectedItem;

                Spieler spieler = comboBox1.SelectedItem as Spieler;
                nameTxt.Text = spieler.Name;
                vornameTxt.Text = spieler.Vorname;
                positionTxt.Text = spieler.Position;
                nummerTxt.Text = spieler.Nummer.ToString();
                sinceTxt.Text = spieler.Seit;
                bornTxt.Text = spieler.Bday;
                sizeTxt.Text = spieler.Size.ToString();
                weightTxt.Text = spieler.Weight.ToString();
                gamesGoalsTxt.Text = spieler.Games + "/" + spieler.Goals;
                nationTxt.Text = spieler.Nation;
                internationalTxt.Text = spieler.International;



                Application.DoEvents();
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

    }
}
