namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toFirstBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.internationalTxt = new System.Windows.Forms.TextBox();
            this.nationTxt = new System.Windows.Forms.TextBox();
            this.gamesGoalsTxt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.sizeTxt = new System.Windows.Forms.TextBox();
            this.bornTxt = new System.Windows.Forms.TextBox();
            this.sinceTxt = new System.Windows.Forms.TextBox();
            this.nummerTxt = new System.Windows.Forms.TextBox();
            this.positionTxt = new System.Windows.Forms.TextBox();
            this.vornameTxt = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // toFirstBtn
            // 
            this.toFirstBtn.BackColor = System.Drawing.SystemColors.Window;
            this.toFirstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toFirstBtn.Image = ((System.Drawing.Image)(resources.GetObject("toFirstBtn.Image")));
            this.toFirstBtn.Location = new System.Drawing.Point(40, 486);
            this.toFirstBtn.Name = "toFirstBtn";
            this.toFirstBtn.Size = new System.Drawing.Size(75, 41);
            this.toFirstBtn.TabIndex = 0;
            this.toFirstBtn.UseVisualStyleBackColor = false;
            this.toFirstBtn.Click += new System.EventHandler(this.toFirstBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.SystemColors.Window;
            this.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.previousBtn.Image = ((System.Drawing.Image)(resources.GetObject("previousBtn.Image")));
            this.previousBtn.Location = new System.Drawing.Point(121, 485);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 42);
            this.previousBtn.TabIndex = 1;
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.Window;
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.Location = new System.Drawing.Point(214, 485);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 41);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.BackColor = System.Drawing.SystemColors.Window;
            this.lastBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lastBtn.Image = ((System.Drawing.Image)(resources.GetObject("lastBtn.Image")));
            this.lastBtn.Location = new System.Drawing.Point(295, 485);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(75, 41);
            this.lastBtn.TabIndex = 3;
            this.lastBtn.UseVisualStyleBackColor = false;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Länderspiele:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Spiele/Tore Bundesliga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gewicht (kg):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Größe (cm):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(682, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Geboren am:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Im Verein seit:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(682, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rückennummer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Vorname:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(682, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Position:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(475, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(821, 72);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(233, 20);
            this.nameTxt.TabIndex = 16;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // internationalTxt
            // 
            this.internationalTxt.Location = new System.Drawing.Point(821, 371);
            this.internationalTxt.Name = "internationalTxt";
            this.internationalTxt.Size = new System.Drawing.Size(233, 20);
            this.internationalTxt.TabIndex = 18;
            // 
            // nationTxt
            // 
            this.nationTxt.Location = new System.Drawing.Point(821, 345);
            this.nationTxt.Name = "nationTxt";
            this.nationTxt.Size = new System.Drawing.Size(233, 20);
            this.nationTxt.TabIndex = 19;
            // 
            // gamesGoalsTxt
            // 
            this.gamesGoalsTxt.Location = new System.Drawing.Point(821, 300);
            this.gamesGoalsTxt.Name = "gamesGoalsTxt";
            this.gamesGoalsTxt.Size = new System.Drawing.Size(233, 20);
            this.gamesGoalsTxt.TabIndex = 20;
            // 
            // weightTxt
            // 
            this.weightTxt.Location = new System.Drawing.Point(821, 271);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(233, 20);
            this.weightTxt.TabIndex = 21;
            // 
            // sizeTxt
            // 
            this.sizeTxt.Location = new System.Drawing.Point(821, 244);
            this.sizeTxt.Name = "sizeTxt";
            this.sizeTxt.Size = new System.Drawing.Size(233, 20);
            this.sizeTxt.TabIndex = 22;
            // 
            // bornTxt
            // 
            this.bornTxt.Location = new System.Drawing.Point(821, 218);
            this.bornTxt.Name = "bornTxt";
            this.bornTxt.Size = new System.Drawing.Size(233, 20);
            this.bornTxt.TabIndex = 23;
            // 
            // sinceTxt
            // 
            this.sinceTxt.Location = new System.Drawing.Point(821, 186);
            this.sinceTxt.Name = "sinceTxt";
            this.sinceTxt.Size = new System.Drawing.Size(233, 20);
            this.sinceTxt.TabIndex = 24;
            // 
            // nummerTxt
            // 
            this.nummerTxt.Location = new System.Drawing.Point(821, 155);
            this.nummerTxt.Name = "nummerTxt";
            this.nummerTxt.Size = new System.Drawing.Size(233, 20);
            this.nummerTxt.TabIndex = 25;
            // 
            // positionTxt
            // 
            this.positionTxt.Location = new System.Drawing.Point(821, 126);
            this.positionTxt.Name = "positionTxt";
            this.positionTxt.Size = new System.Drawing.Size(233, 20);
            this.positionTxt.TabIndex = 26;
            // 
            // vornameTxt
            // 
            this.vornameTxt.Location = new System.Drawing.Point(821, 98);
            this.vornameTxt.Name = "vornameTxt";
            this.vornameTxt.Size = new System.Drawing.Size(233, 20);
            this.vornameTxt.TabIndex = 27;
            // 
            // image
            // 
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.image.Location = new System.Drawing.Point(40, 75);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(330, 395);
            this.image.TabIndex = 28;
            this.image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1180, 569);
            this.Controls.Add(this.image);
            this.Controls.Add(this.vornameTxt);
            this.Controls.Add(this.positionTxt);
            this.Controls.Add(this.nummerTxt);
            this.Controls.Add(this.sinceTxt);
            this.Controls.Add(this.bornTxt);
            this.Controls.Add(this.sizeTxt);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.gamesGoalsTxt);
            this.Controls.Add(this.nationTxt);
            this.Controls.Add(this.internationalTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.toFirstBtn);
            this.Name = "Form1";
            this.Text = "Meine Fussball-Mannschaft";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toFirstBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox internationalTxt;
        private System.Windows.Forms.TextBox nationTxt;
        private System.Windows.Forms.TextBox gamesGoalsTxt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.TextBox sizeTxt;
        private System.Windows.Forms.TextBox bornTxt;
        private System.Windows.Forms.TextBox sinceTxt;
        private System.Windows.Forms.TextBox nummerTxt;
        private System.Windows.Forms.TextBox positionTxt;
        private System.Windows.Forms.TextBox vornameTxt;
        private System.Windows.Forms.PictureBox image;
    }
}

