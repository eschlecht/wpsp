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
using System.Xml;
using System.Xml.Serialization;

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
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Kader));
                FileStream fs = new FileStream("SpielerData.xml", FileMode.Open);
                XmlReader reader = XmlReader.Create(fs);
                myKader = (Kader)serializer.Deserialize(reader);
                fs.Close();
            }
            catch (System.InvalidOperationException ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("XML konnte nicht komplett gelesen werden. ", "XML-Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            foreach (Spieler s in myKader.Spielers)
            {
                comboBox1.Items.Add(s);
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
                Spieler spieler = myKader.Spielers[comboBox1.SelectedIndex];
                nameTxt.Text = spieler.Name;
                nameTxt.IsAccessible = false;
                vornameTxt.Text = spieler.Vorname;
                positionTxt.Text = spieler.Position;
                nummerTxt.Text = spieler.Rueckennummer.ToString();
                sinceTxt.Text = spieler.Seit;
                bornTxt.Text = spieler.GeburtsDatum;
                sizeTxt.Text = spieler.GroesseInCm.ToString();
                weightTxt.Text = spieler.GewichtInKg.ToString();
                gamesGoalsTxt.Text = spieler.SpieleInBundesliga + "/" + spieler.ToreInBundesliga;
                nationTxt.Text = spieler.Nation;
                internationalTxt.Text = spieler.Laenderspiele;
                try
                {
                    image.Image = Image.FromFile(@"Images\" + spieler.Name + " " + spieler.Vorname + ".jpg");
                }
                catch (System.IO.FileNotFoundException)
                {
                    try
                    {
                        image.Image = Image.FromFile(@"Images\notfound.jpg");
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        MessageBox.Show("Stop removing pictures! ", "Error in OSI Layer 8", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
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
