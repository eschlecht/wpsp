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
        Kader myKader;

        public Form1()
        {
            InitializeComponent();
            LoadSpielerData();
            comboBox1.SelectedIndex = 0;
            ChangeButtonEnabled(comboBox1.SelectedIndex);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void LoadSpielerData()
        {
            myKader = new Kader();
            XmlDocument doc = new XmlDocument();
            try
            {
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
                        myKader.AddToList(new Spieler(name, vorname, position, nummer, seit, bday, size, weight, games, goals, nation, internationl));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("XML konnte nicht komplett gelesen werden. " + myKader.count + " Einträge hinzugefügt.", "XML-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < myKader.count; i++)
            {
                comboBox1.Items.Add(myKader.getSpieler(i));
            }
        }

        private void ChangeButtonEnabled(int index)
        {
            if (comboBox1.Items.Count == 1)
            {
                toFirstBtn.Enabled = false;
                previousBtn.Enabled = false;
                lastBtn.Enabled = false;
                nextBtn.Enabled = false;
            }
            else if (index == 0)
            {
                toFirstBtn.Enabled = false;
                previousBtn.Enabled = false;
                lastBtn.Enabled = true;
                nextBtn.Enabled = true;

            }
            else if (index == comboBox1.Items.Count - 1)
            {
                lastBtn.Enabled = false;
                nextBtn.Enabled = false;
                toFirstBtn.Enabled = true;
                previousBtn.Enabled = true;
            }
            else
            {
                lastBtn.Enabled = true;
                nextBtn.Enabled = true;
                toFirstBtn.Enabled = true;
                previousBtn.Enabled = true;
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
                Spieler spieler = this.myKader.getSpieler(comboBox1.SelectedIndex);
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
                try
                {
                    image.Image = Image.FromFile(@"Images\" + spieler.Name + " " + spieler.Vorname + ".jpg");
                }
                catch (System.IO.FileNotFoundException)
                {
                    image.Image = Image.FromFile(@"Images\notfound.jpg");
                }
                ChangeButtonEnabled(comboBox1.SelectedIndex);
                Application.DoEvents();
                

            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
        private void toFirstBtn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            ChangeButtonEnabled(comboBox1.SelectedIndex);
            Application.DoEvents();
            
        }
        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                comboBox1.SelectedIndex -= 1;
            }
            ChangeButtonEnabled(comboBox1.SelectedIndex);
            Application.DoEvents();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < comboBox1.Items.Count - 1)
            {
                comboBox1.SelectedIndex += 1;
            }
            ChangeButtonEnabled(comboBox1.SelectedIndex);
            Application.DoEvents();
        }

        private void lastBtn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            ChangeButtonEnabled(comboBox1.SelectedIndex);
            Application.DoEvents();
        }
    }
}
