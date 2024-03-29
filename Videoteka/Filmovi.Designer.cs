﻿namespace Videoteka
{
    partial class Filmovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmovi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxNazad = new System.Windows.Forms.PictureBox();
            this.textBoxOcjena = new System.Windows.Forms.TextBox();
            this.labelOcjena = new System.Windows.Forms.Label();
            this.dataGridViewFilmovi = new System.Windows.Forms.DataGridView();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaIzlaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
            this.buttonKreiraj = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxGodinaIzlaska = new System.Windows.Forms.TextBox();
            this.labelGodinaIzlaska = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.bindingSourceFilm = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNazad
            // 
            this.pictureBoxNazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad.BackgroundImage")));
            this.pictureBoxNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNazad.Location = new System.Drawing.Point(367, 504);
            this.pictureBoxNazad.Name = "pictureBoxNazad";
            this.pictureBoxNazad.Size = new System.Drawing.Size(60, 45);
            this.pictureBoxNazad.TabIndex = 33;
            this.pictureBoxNazad.TabStop = false;
            this.pictureBoxNazad.Click += new System.EventHandler(this.pictureBoxNazad_Click);
            this.pictureBoxNazad.MouseLeave += new System.EventHandler(this.pictureBoxNazad_MouseLeave);
            this.pictureBoxNazad.MouseHover += new System.EventHandler(this.pictureBoxNazad_MouseHover);
            // 
            // textBoxOcjena
            // 
            this.textBoxOcjena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOcjena.Location = new System.Drawing.Point(367, 203);
            this.textBoxOcjena.Name = "textBoxOcjena";
            this.textBoxOcjena.Size = new System.Drawing.Size(206, 31);
            this.textBoxOcjena.TabIndex = 32;
            // 
            // labelOcjena
            // 
            this.labelOcjena.AutoSize = true;
            this.labelOcjena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOcjena.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOcjena.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelOcjena.Location = new System.Drawing.Point(226, 209);
            this.labelOcjena.Name = "labelOcjena";
            this.labelOcjena.Size = new System.Drawing.Size(88, 25);
            this.labelOcjena.TabIndex = 31;
            this.labelOcjena.Text = "Ocjena";
            // 
            // dataGridViewFilmovi
            // 
            this.dataGridViewFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilmovi.AutoGenerateColumns = false;
            this.dataGridViewFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmovi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilmovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFilmovi.ColumnHeadersHeight = 30;
            this.dataGridViewFilmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmID,
            this.Naziv,
            this.GodinaIzlaska,
            this.Ocjena});
            this.dataGridViewFilmovi.DataSource = this.bindingSourceFilm;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFilmovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFilmovi.Location = new System.Drawing.Point(68, 306);
            this.dataGridViewFilmovi.Name = "dataGridViewFilmovi";
            this.dataGridViewFilmovi.ReadOnly = true;
            this.dataGridViewFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmovi.Size = new System.Drawing.Size(660, 192);
            this.dataGridViewFilmovi.TabIndex = 30;
            this.dataGridViewFilmovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilmovi_CellContentClick);
            // 
            // FilmID
            // 
            this.FilmID.DataPropertyName = "FilmID";
            this.FilmID.HeaderText = "ID";
            this.FilmID.Name = "FilmID";
            this.FilmID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // GodinaIzlaska
            // 
            this.GodinaIzlaska.DataPropertyName = "Godina_Izlaska";
            this.GodinaIzlaska.HeaderText = "Godina Izlaska";
            this.GodinaIzlaska.Name = "GodinaIzlaska";
            this.GodinaIzlaska.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.BackColor = System.Drawing.Color.White;
            this.buttonIzbrisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzbrisi.Location = new System.Drawing.Point(602, 248);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(126, 36);
            this.buttonIzbrisi.TabIndex = 29;
            this.buttonIzbrisi.Text = "Izbriši";
            this.buttonIzbrisi.UseVisualStyleBackColor = false;
            this.buttonIzbrisi.Click += new System.EventHandler(this.buttonIzbrisi_Click);
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.BackColor = System.Drawing.Color.White;
            this.buttonPrikazi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrikazi.Location = new System.Drawing.Point(425, 248);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(126, 36);
            this.buttonPrikazi.TabIndex = 28;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = false;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.BackColor = System.Drawing.Color.White;
            this.buttonIzmjeni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzmjeni.Location = new System.Drawing.Point(248, 248);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(126, 36);
            this.buttonIzmjeni.TabIndex = 27;
            this.buttonIzmjeni.Text = "Izmijeni";
            this.buttonIzmjeni.UseVisualStyleBackColor = false;
            this.buttonIzmjeni.Click += new System.EventHandler(this.buttonIzmjeni_Click);
            // 
            // buttonKreiraj
            // 
            this.buttonKreiraj.BackColor = System.Drawing.Color.White;
            this.buttonKreiraj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKreiraj.Location = new System.Drawing.Point(68, 248);
            this.buttonKreiraj.Name = "buttonKreiraj";
            this.buttonKreiraj.Size = new System.Drawing.Size(126, 36);
            this.buttonKreiraj.TabIndex = 26;
            this.buttonKreiraj.Text = "Kreiraj";
            this.buttonKreiraj.UseVisualStyleBackColor = false;
            this.buttonKreiraj.Click += new System.EventHandler(this.buttonKreiraj_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(367, 35);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(206, 31);
            this.textBoxID.TabIndex = 25;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelID.Location = new System.Drawing.Point(281, 41);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 25);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID";
            // 
            // textBoxGodinaIzlaska
            // 
            this.textBoxGodinaIzlaska.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGodinaIzlaska.Location = new System.Drawing.Point(367, 147);
            this.textBoxGodinaIzlaska.Name = "textBoxGodinaIzlaska";
            this.textBoxGodinaIzlaska.Size = new System.Drawing.Size(206, 31);
            this.textBoxGodinaIzlaska.TabIndex = 23;
            // 
            // labelGodinaIzlaska
            // 
            this.labelGodinaIzlaska.AutoSize = true;
            this.labelGodinaIzlaska.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGodinaIzlaska.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGodinaIzlaska.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelGodinaIzlaska.Location = new System.Drawing.Point(150, 153);
            this.labelGodinaIzlaska.Name = "labelGodinaIzlaska";
            this.labelGodinaIzlaska.Size = new System.Drawing.Size(164, 25);
            this.labelGodinaIzlaska.TabIndex = 22;
            this.labelGodinaIzlaska.Text = "Godina izlaska";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNaziv.Location = new System.Drawing.Point(367, 91);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(206, 31);
            this.textBoxNaziv.TabIndex = 21;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNaziv.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaziv.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelNaziv.Location = new System.Drawing.Point(245, 97);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(69, 25);
            this.labelNaziv.TabIndex = 20;
            this.labelNaziv.Text = "Naziv";
            // 
            // bindingSourceFilm
            // 
            this.bindingSourceFilm.DataSource = typeof(Videoteka.Film);
            // 
            // Filmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBoxNazad);
            this.Controls.Add(this.textBoxOcjena);
            this.Controls.Add(this.labelOcjena);
            this.Controls.Add(this.dataGridViewFilmovi);
            this.Controls.Add(this.buttonIzbrisi);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.buttonKreiraj);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxGodinaIzlaska);
            this.Controls.Add(this.labelGodinaIzlaska);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelNaziv);
            this.Name = "Filmovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.Filmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNazad;
        private System.Windows.Forms.TextBox textBoxOcjena;
        private System.Windows.Forms.Label labelOcjena;
        private System.Windows.Forms.DataGridView dataGridViewFilmovi;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonIzmjeni;
        private System.Windows.Forms.Button buttonKreiraj;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxGodinaIzlaska;
        private System.Windows.Forms.Label labelGodinaIzlaska;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.BindingSource bindingSourceFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaIzlaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}