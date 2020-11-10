namespace DatabaseH2
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.clientEmail = new System.Windows.Forms.TextBox();
            this.clientCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientSurname = new System.Windows.Forms.TextBox();
            this.clientTlf = new System.Windows.Forms.TextBox();
            this.clientCity = new System.Windows.Forms.TextBox();
            this.clientAdress = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sletKundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchName = new System.Windows.Forms.TextBox();
            this.searchSurname = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.searchEmail = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchVin = new System.Windows.Forms.TextBox();
            this.searchMerke = new System.Windows.Forms.TextBox();
            this.searchModel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 689);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "Søg Person";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clientEmail
            // 
            this.clientEmail.Location = new System.Drawing.Point(16, 611);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(151, 20);
            this.clientEmail.TabIndex = 7;
            this.clientEmail.Text = "Email";
            // 
            // clientCreate
            // 
            this.clientCreate.Location = new System.Drawing.Point(15, 689);
            this.clientCreate.Name = "clientCreate";
            this.clientCreate.Size = new System.Drawing.Size(151, 69);
            this.clientCreate.TabIndex = 6;
            this.clientCreate.Text = "Opret Person";
            this.clientCreate.UseVisualStyleBackColor = true;
            this.clientCreate.Click += new System.EventHandler(this.clientCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Administration - Opret Person";
            // 
            // clientSurname
            // 
            this.clientSurname.Location = new System.Drawing.Point(16, 559);
            this.clientSurname.Name = "clientSurname";
            this.clientSurname.Size = new System.Drawing.Size(151, 20);
            this.clientSurname.TabIndex = 4;
            this.clientSurname.Text = "Efternavn";
            // 
            // clientTlf
            // 
            this.clientTlf.Location = new System.Drawing.Point(16, 585);
            this.clientTlf.Name = "clientTlf";
            this.clientTlf.Size = new System.Drawing.Size(151, 20);
            this.clientTlf.TabIndex = 3;
            this.clientTlf.Text = "Tlf";
            // 
            // clientCity
            // 
            this.clientCity.Location = new System.Drawing.Point(16, 663);
            this.clientCity.Name = "clientCity";
            this.clientCity.Size = new System.Drawing.Size(151, 20);
            this.clientCity.TabIndex = 2;
            this.clientCity.Text = "City";
            // 
            // clientAdress
            // 
            this.clientAdress.Location = new System.Drawing.Point(16, 637);
            this.clientAdress.Name = "clientAdress";
            this.clientAdress.Size = new System.Drawing.Size(151, 20);
            this.clientAdress.TabIndex = 1;
            this.clientAdress.Text = "Adress";
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(16, 533);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(151, 20);
            this.clientName.TabIndex = 0;
            this.clientName.Text = "Navn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sletKundeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Opret lejeaftale";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sletKundeToolStripMenuItem
            // 
            this.sletKundeToolStripMenuItem.Name = "sletKundeToolStripMenuItem";
            this.sletKundeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sletKundeToolStripMenuItem.Text = "Slet kunde";
            this.sletKundeToolStripMenuItem.Click += new System.EventHandler(this.sletKundeToolStripMenuItem_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(172, 533);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(151, 20);
            this.searchName.TabIndex = 11;
            this.searchName.Text = "Søg på navn";
            // 
            // searchSurname
            // 
            this.searchSurname.Location = new System.Drawing.Point(172, 559);
            this.searchSurname.Name = "searchSurname";
            this.searchSurname.Size = new System.Drawing.Size(151, 20);
            this.searchSurname.TabIndex = 12;
            this.searchSurname.Text = "Søg på efternavn";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 585);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Søg på Telfon";
            // 
            // searchEmail
            // 
            this.searchEmail.Location = new System.Drawing.Point(172, 611);
            this.searchEmail.Name = "searchEmail";
            this.searchEmail.Size = new System.Drawing.Size(151, 20);
            this.searchEmail.TabIndex = 14;
            this.searchEmail.Text = "Søg på email";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 637);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Søg på KundeID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Administration - Søg Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Administration - Søg på Biler";
            // 
            // searchVin
            // 
            this.searchVin.Location = new System.Drawing.Point(329, 533);
            this.searchVin.Name = "searchVin";
            this.searchVin.Size = new System.Drawing.Size(151, 20);
            this.searchVin.TabIndex = 19;
            this.searchVin.Text = "VIN";
            // 
            // searchMerke
            // 
            this.searchMerke.Location = new System.Drawing.Point(329, 559);
            this.searchMerke.Name = "searchMerke";
            this.searchMerke.Size = new System.Drawing.Size(151, 20);
            this.searchMerke.TabIndex = 20;
            this.searchMerke.Text = "Søg efter Mærke";
            // 
            // searchModel
            // 
            this.searchModel.Location = new System.Drawing.Point(329, 585);
            this.searchModel.Name = "searchModel";
            this.searchModel.Size = new System.Drawing.Size(151, 20);
            this.searchModel.TabIndex = 21;
            this.searchModel.Text = "Søg efter Model";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 689);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 69);
            this.button1.TabIndex = 22;
            this.button1.Text = "Søg Biler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Administration - Opret Bil";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 533);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "VIN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(486, 559);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Mærke";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(486, 585);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 20);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "Model";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(486, 611);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(151, 20);
            this.textBox6.TabIndex = 27;
            this.textBox6.Text = "Farve";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(486, 663);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(151, 20);
            this.textBox7.TabIndex = 28;
            this.textBox7.Text = "Prisgruppe";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(486, 637);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(151, 20);
            this.textBox8.TabIndex = 28;
            this.textBox8.Text = "Årgang";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 689);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 69);
            this.button3.TabIndex = 29;
            this.button3.Text = "Opret bil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 791);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchModel);
            this.Controls.Add(this.searchMerke);
            this.Controls.Add(this.searchVin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.searchEmail);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.searchSurname);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.clientEmail);
            this.Controls.Add(this.clientAdress);
            this.Controls.Add(this.clientCity);
            this.Controls.Add(this.clientTlf);
            this.Controls.Add(this.clientSurname);
            this.Controls.Add(this.clientCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clientCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientSurname;
        private System.Windows.Forms.TextBox clientTlf;
        private System.Windows.Forms.TextBox clientCity;
        private System.Windows.Forms.TextBox clientAdress;
        public System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.TextBox clientEmail;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sletKundeToolStripMenuItem;
        public System.Windows.Forms.TextBox searchName;
        public System.Windows.Forms.TextBox searchSurname;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox searchEmail;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox searchVin;
        public System.Windows.Forms.TextBox searchMerke;
        public System.Windows.Forms.TextBox searchModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button3;
    }
}

