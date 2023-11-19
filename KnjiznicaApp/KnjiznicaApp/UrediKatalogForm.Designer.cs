﻿namespace KnjiznicaApp
{
    partial class UrediKatalogForm
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
            this.UrediNazivTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoriCombobox = new System.Windows.Forms.ComboBox();
            this.UlogaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AutoreToLvButton = new System.Windows.Forms.Button();
            this.AutoriUlogeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.IDUrediTxtBox = new System.Windows.Forms.TextBox();
            this.DodajKnjiguButton = new System.Windows.Forms.Button();
            this.GodinaLabel = new System.Windows.Forms.Label();
            this.UrediIzdavaciCombiBoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteKnjiga = new System.Windows.Forms.Button();
            this.GodinaUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.JezikComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MjestoIzdavanjaComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UrediDataGridView = new System.Windows.Forms.DataGridView();
            this.KnjigaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prevoditelji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Godina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchIzborComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TraziTxtBox = new System.Windows.Forms.TextBox();
            this.AddAutor = new System.Windows.Forms.Button();
            this.AddUloga = new System.Windows.Forms.Button();
            this.AddMjestoIzdavanja = new System.Windows.Forms.Button();
            this.AddJezik = new System.Windows.Forms.Button();
            this.AddIzdavac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GodinaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrediDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UrediNazivTxtBox
            // 
            this.UrediNazivTxtBox.Location = new System.Drawing.Point(777, 85);
            this.UrediNazivTxtBox.Name = "UrediNazivTxtBox";
            this.UrediNazivTxtBox.Size = new System.Drawing.Size(100, 20);
            this.UrediNazivTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autori";
            // 
            // AutoriCombobox
            // 
            this.AutoriCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AutoriCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AutoriCombobox.DisplayMember = "AutorID";
            this.AutoriCombobox.FormattingEnabled = true;
            this.AutoriCombobox.Location = new System.Drawing.Point(778, 322);
            this.AutoriCombobox.Name = "AutoriCombobox";
            this.AutoriCombobox.Size = new System.Drawing.Size(121, 21);
            this.AutoriCombobox.TabIndex = 3;
            this.AutoriCombobox.ValueMember = "AutorID";
            // 
            // UlogaComboBox
            // 
            this.UlogaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UlogaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UlogaComboBox.FormattingEnabled = true;
            this.UlogaComboBox.Location = new System.Drawing.Point(778, 366);
            this.UlogaComboBox.Name = "UlogaComboBox";
            this.UlogaComboBox.Size = new System.Drawing.Size(121, 21);
            this.UlogaComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uloga";
            // 
            // AutoreToLvButton
            // 
            this.AutoreToLvButton.Location = new System.Drawing.Point(905, 338);
            this.AutoreToLvButton.Name = "AutoreToLvButton";
            this.AutoreToLvButton.Size = new System.Drawing.Size(98, 36);
            this.AutoreToLvButton.TabIndex = 6;
            this.AutoreToLvButton.Text = "Dodaj";
            this.AutoreToLvButton.UseVisualStyleBackColor = true;
            this.AutoreToLvButton.Click += new System.EventHandler(this.AutoreToLvButton_Click);
            // 
            // AutoriUlogeListView
            // 
            this.AutoriUlogeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.AutoriUlogeListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.AutoriUlogeListView.HideSelection = false;
            this.AutoriUlogeListView.Location = new System.Drawing.Point(1019, 306);
            this.AutoriUlogeListView.Name = "AutoriUlogeListView";
            this.AutoriUlogeListView.Size = new System.Drawing.Size(239, 214);
            this.AutoriUlogeListView.TabIndex = 7;
            this.AutoriUlogeListView.UseCompatibleStateImageBehavior = false;
            this.AutoriUlogeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // IDUrediTxtBox
            // 
            this.IDUrediTxtBox.Enabled = false;
            this.IDUrediTxtBox.Location = new System.Drawing.Point(804, 41);
            this.IDUrediTxtBox.Name = "IDUrediTxtBox";
            this.IDUrediTxtBox.Size = new System.Drawing.Size(358, 20);
            this.IDUrediTxtBox.TabIndex = 10;
            // 
            // DodajKnjiguButton
            // 
            this.DodajKnjiguButton.Location = new System.Drawing.Point(913, 177);
            this.DodajKnjiguButton.Name = "DodajKnjiguButton";
            this.DodajKnjiguButton.Size = new System.Drawing.Size(90, 38);
            this.DodajKnjiguButton.TabIndex = 11;
            this.DodajKnjiguButton.Text = "Dodaj Knjigu";
            this.DodajKnjiguButton.UseVisualStyleBackColor = true;
            this.DodajKnjiguButton.Click += new System.EventHandler(this.DodajKnjiguButton_Click);
            // 
            // GodinaLabel
            // 
            this.GodinaLabel.AutoSize = true;
            this.GodinaLabel.Location = new System.Drawing.Point(880, 69);
            this.GodinaLabel.Name = "GodinaLabel";
            this.GodinaLabel.Size = new System.Drawing.Size(44, 13);
            this.GodinaLabel.TabIndex = 13;
            this.GodinaLabel.Text = "Godina:";
            // 
            // UrediIzdavaciCombiBoc
            // 
            this.UrediIzdavaciCombiBoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UrediIzdavaciCombiBoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UrediIzdavaciCombiBoc.FormattingEnabled = true;
            this.UrediIzdavaciCombiBoc.Location = new System.Drawing.Point(777, 145);
            this.UrediIzdavaciCombiBoc.Name = "UrediIzdavaciCombiBoc";
            this.UrediIzdavaciCombiBoc.Size = new System.Drawing.Size(121, 21);
            this.UrediIzdavaciCombiBoc.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(774, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Izdavac:";
            // 
            // DeleteKnjiga
            // 
            this.DeleteKnjiga.Location = new System.Drawing.Point(723, 530);
            this.DeleteKnjiga.Name = "DeleteKnjiga";
            this.DeleteKnjiga.Size = new System.Drawing.Size(99, 43);
            this.DeleteKnjiga.TabIndex = 20;
            this.DeleteKnjiga.Text = "Izbrisi Knjige";
            this.DeleteKnjiga.UseVisualStyleBackColor = true;
            this.DeleteKnjiga.Click += new System.EventHandler(this.DeleteKnjiga_Click);
            // 
            // GodinaUpDown
            // 
            this.GodinaUpDown.Location = new System.Drawing.Point(883, 85);
            this.GodinaUpDown.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.GodinaUpDown.Name = "GodinaUpDown";
            this.GodinaUpDown.Size = new System.Drawing.Size(120, 20);
            this.GodinaUpDown.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Jezik:";
            // 
            // JezikComboBox
            // 
            this.JezikComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.JezikComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.JezikComboBox.FormattingEnabled = true;
            this.JezikComboBox.Location = new System.Drawing.Point(777, 187);
            this.JezikComboBox.Name = "JezikComboBox";
            this.JezikComboBox.Size = new System.Drawing.Size(121, 21);
            this.JezikComboBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mjesto Izdavanja:";
            // 
            // MjestoIzdavanjaComboBox
            // 
            this.MjestoIzdavanjaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MjestoIzdavanjaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MjestoIzdavanjaComboBox.FormattingEnabled = true;
            this.MjestoIzdavanjaComboBox.Location = new System.Drawing.Point(777, 230);
            this.MjestoIzdavanjaComboBox.Name = "MjestoIzdavanjaComboBox";
            this.MjestoIzdavanjaComboBox.Size = new System.Drawing.Size(121, 21);
            this.MjestoIzdavanjaComboBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1019, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "Dodaj Izabranoj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1168, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "Očisti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrediDataGridView
            // 
            this.UrediDataGridView.AllowUserToAddRows = false;
            this.UrediDataGridView.AllowUserToDeleteRows = false;
            this.UrediDataGridView.AllowUserToResizeRows = false;
            this.UrediDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrediDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KnjigaID,
            this.Naziv,
            this.Autori,
            this.Prevoditelji,
            this.Godina,
            this.MjestoIzdavanja,
            this.Izdavac});
            this.UrediDataGridView.Location = new System.Drawing.Point(13, 31);
            this.UrediDataGridView.Name = "UrediDataGridView";
            this.UrediDataGridView.ReadOnly = true;
            this.UrediDataGridView.RowHeadersVisible = false;
            this.UrediDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UrediDataGridView.Size = new System.Drawing.Size(679, 552);
            this.UrediDataGridView.TabIndex = 28;
            this.UrediDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrediDataGridView_CellDoubleClick);
            // 
            // KnjigaID
            // 
            this.KnjigaID.DataPropertyName = "KnjigaID";
            this.KnjigaID.HeaderText = "KnjigaID";
            this.KnjigaID.Name = "KnjigaID";
            this.KnjigaID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Autori
            // 
            this.Autori.DataPropertyName = "Autori";
            this.Autori.HeaderText = "Autori";
            this.Autori.Name = "Autori";
            this.Autori.ReadOnly = true;
            // 
            // Prevoditelji
            // 
            this.Prevoditelji.DataPropertyName = "Prevoditelji";
            this.Prevoditelji.HeaderText = "Prevoditelji";
            this.Prevoditelji.Name = "Prevoditelji";
            this.Prevoditelji.ReadOnly = true;
            // 
            // Godina
            // 
            this.Godina.DataPropertyName = "Godina";
            this.Godina.HeaderText = "Godina";
            this.Godina.Name = "Godina";
            this.Godina.ReadOnly = true;
            // 
            // MjestoIzdavanja
            // 
            this.MjestoIzdavanja.DataPropertyName = "MjestoIzdavanja";
            this.MjestoIzdavanja.HeaderText = "Mjesto Izdavanja";
            this.MjestoIzdavanja.Name = "MjestoIzdavanja";
            this.MjestoIzdavanja.ReadOnly = true;
            // 
            // Izdavac
            // 
            this.Izdavac.DataPropertyName = "Izdavac";
            this.Izdavac.HeaderText = "Izdavač";
            this.Izdavac.Name = "Izdavac";
            this.Izdavac.ReadOnly = true;
            // 
            // searchIzborComboBox
            // 
            this.searchIzborComboBox.FormattingEnabled = true;
            this.searchIzborComboBox.Items.AddRange(new object[] {
            "Katalog",
            "Naziv",
            "Autor",
            "KnjigaID"});
            this.searchIzborComboBox.Location = new System.Drawing.Point(322, 5);
            this.searchIzborComboBox.Name = "searchIzborComboBox";
            this.searchIzborComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchIzborComboBox.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Pretraga";
            // 
            // TraziTxtBox
            // 
            this.TraziTxtBox.Location = new System.Drawing.Point(65, 5);
            this.TraziTxtBox.Name = "TraziTxtBox";
            this.TraziTxtBox.Size = new System.Drawing.Size(251, 20);
            this.TraziTxtBox.TabIndex = 44;
            this.TraziTxtBox.TextChanged += new System.EventHandler(this.TraziTxtBox_TextChanged);
            // 
            // AddAutor
            // 
            this.AddAutor.Location = new System.Drawing.Point(745, 322);
            this.AddAutor.Name = "AddAutor";
            this.AddAutor.Size = new System.Drawing.Size(27, 21);
            this.AddAutor.TabIndex = 47;
            this.AddAutor.Text = "+";
            this.AddAutor.UseVisualStyleBackColor = true;
            this.AddAutor.Click += new System.EventHandler(this.AddAutor_Click);
            // 
            // AddUloga
            // 
            this.AddUloga.Location = new System.Drawing.Point(745, 366);
            this.AddUloga.Name = "AddUloga";
            this.AddUloga.Size = new System.Drawing.Size(27, 21);
            this.AddUloga.TabIndex = 48;
            this.AddUloga.Text = "+";
            this.AddUloga.UseVisualStyleBackColor = true;
            this.AddUloga.Click += new System.EventHandler(this.AddUloga_Click);
            // 
            // AddMjestoIzdavanja
            // 
            this.AddMjestoIzdavanja.Location = new System.Drawing.Point(745, 230);
            this.AddMjestoIzdavanja.Name = "AddMjestoIzdavanja";
            this.AddMjestoIzdavanja.Size = new System.Drawing.Size(27, 21);
            this.AddMjestoIzdavanja.TabIndex = 49;
            this.AddMjestoIzdavanja.Text = "+";
            this.AddMjestoIzdavanja.UseVisualStyleBackColor = true;
            this.AddMjestoIzdavanja.Click += new System.EventHandler(this.AddMjestoIzdavanja_Click);
            // 
            // AddJezik
            // 
            this.AddJezik.Location = new System.Drawing.Point(745, 187);
            this.AddJezik.Name = "AddJezik";
            this.AddJezik.Size = new System.Drawing.Size(27, 21);
            this.AddJezik.TabIndex = 50;
            this.AddJezik.Text = "+";
            this.AddJezik.UseVisualStyleBackColor = true;
            this.AddJezik.Click += new System.EventHandler(this.AddJezik_Click);
            // 
            // AddIzdavac
            // 
            this.AddIzdavac.Location = new System.Drawing.Point(745, 145);
            this.AddIzdavac.Name = "AddIzdavac";
            this.AddIzdavac.Size = new System.Drawing.Size(27, 21);
            this.AddIzdavac.TabIndex = 51;
            this.AddIzdavac.Text = "+";
            this.AddIzdavac.UseVisualStyleBackColor = true;
            this.AddIzdavac.Click += new System.EventHandler(this.AddIzdavac_Click);
            // 
            // UrediKatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 595);
            this.Controls.Add(this.AddIzdavac);
            this.Controls.Add(this.AddJezik);
            this.Controls.Add(this.AddMjestoIzdavanja);
            this.Controls.Add(this.AddUloga);
            this.Controls.Add(this.AddAutor);
            this.Controls.Add(this.searchIzborComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TraziTxtBox);
            this.Controls.Add(this.UrediDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MjestoIzdavanjaComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.JezikComboBox);
            this.Controls.Add(this.GodinaUpDown);
            this.Controls.Add(this.DeleteKnjiga);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UrediIzdavaciCombiBoc);
            this.Controls.Add(this.GodinaLabel);
            this.Controls.Add(this.DodajKnjiguButton);
            this.Controls.Add(this.IDUrediTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AutoriUlogeListView);
            this.Controls.Add(this.AutoreToLvButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UlogaComboBox);
            this.Controls.Add(this.AutoriCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrediNazivTxtBox);
            this.Name = "UrediKatalogForm";
            this.Text = "Knjižničar";
            this.Load += new System.EventHandler(this.UrediKatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GodinaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrediDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrediNazivTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AutoriCombobox;
        private System.Windows.Forms.ComboBox UlogaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AutoreToLvButton;
        private System.Windows.Forms.ListView AutoriUlogeListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDUrediTxtBox;
        private System.Windows.Forms.Button DodajKnjiguButton;
        private System.Windows.Forms.Label GodinaLabel;
        private System.Windows.Forms.ComboBox UrediIzdavaciCombiBoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteKnjiga;
        private System.Windows.Forms.NumericUpDown GodinaUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox JezikComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MjestoIzdavanjaComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridView UrediDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnjigaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prevoditelji;
        private System.Windows.Forms.DataGridViewTextBoxColumn Godina;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Izdavac;
        private System.Windows.Forms.ComboBox searchIzborComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TraziTxtBox;
        private System.Windows.Forms.Button AddAutor;
        private System.Windows.Forms.Button AddUloga;
        private System.Windows.Forms.Button AddMjestoIzdavanja;
        private System.Windows.Forms.Button AddJezik;
        private System.Windows.Forms.Button AddIzdavac;
    }
}