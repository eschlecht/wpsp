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

       

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Spieler spieler = comboBox1.SelectedItem as Spieler;
                nameTxt.Text = spieler.Name;
                nameTxt.IsAccessible = false;
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
                image.Image = Image.FromFile(@"Images\" + spieler.Name + " " + spieler.Vorname + ".jpg");
                Application.DoEvents();
                if(comboBox1.SelectedIndex == 0)
                {
                    toFirstBtn.Enabled = false;
                    previousBtn.Enabled = false;
                }

            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
        private void toFirstBtn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            toFirstBtn.Enabled = false;
            previousBtn.Enabled = false;
            lastBtn.Enabled = true;
            nextBtn.Enabled = true;
            Application.DoEvents();
            
        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index == 0)
            {
                toFirstBtn.Enabled = false;
                previousBtn.Enabled = false;
                Application.DoEvents();
            }
            else
            {
                lastBtn.Enabled = true;
                nextBtn.Enabled = true;
                index = index - 1;
                comboBox1.SelectedIndex = index;
                Application.DoEvents();
            }
            
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index == 25)
            {
                nextBtn.Enabled = false;
                lastBtn.Enabled = false;
                toFirstBtn.Enabled = true;
                previousBtn.Enabled = true;
                index = index + 1;
                comboBox1.SelectedIndex = index;
                Application.DoEvents();
            }
            else
            {
                nextBtn.Enabled = true;
                lastBtn.Enabled = true;
                toFirstBtn.Enabled = true;
                previousBtn.Enabled = true;
                index = index + 1;
                comboBox1.SelectedIndex = index;
                Application.DoEvents();
            }
            
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex =26;
            toFirstBtn.Enabled = true;
            previousBtn.Enabled = true;
            lastBtn.Enabled = false;
            nextBtn.Enabled = false;
            Application.DoEvents();
        }
    }
}
