namespace Videoteka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmovi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBoxNazad = new System.Windows.Forms.PictureBox();
            this.textBoxOcjena = new System.Windows.Forms.TextBox();
            this.labelOcjena = new System.Windows.Forms.Label();
            this.dataGridViewFilmovi = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNazad
            // 
            this.pictureBoxNazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad.BackgroundImage")));
            this.pictureBoxNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNazad.Location = new System.Drawing.Point(367, 493);
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
            this.textBoxOcjena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOcjena.Location = new System.Drawing.Point(350, 172);
            this.textBoxOcjena.Name = "textBoxOcjena";
            this.textBoxOcjena.Size = new System.Drawing.Size(206, 27);
            this.textBoxOcjena.TabIndex = 32;
            // 
            // labelOcjena
            // 
            this.labelOcjena.AutoSize = true;
            this.labelOcjena.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelOcjena.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcjena.ForeColor = System.Drawing.Color.White;
            this.labelOcjena.Location = new System.Drawing.Point(177, 176);
            this.labelOcjena.Name = "labelOcjena";
            this.labelOcjena.Size = new System.Drawing.Size(79, 23);
            this.labelOcjena.TabIndex = 31;
            this.labelOcjena.Text = "Ocjena";
            // 
            // dataGridViewFilmovi
            // 
            this.dataGridViewFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilmovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmovi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilmovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFilmovi.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFilmovi.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFilmovi.Location = new System.Drawing.Point(62, 287);
            this.dataGridViewFilmovi.Name = "dataGridViewFilmovi";
            this.dataGridViewFilmovi.ReadOnly = true;
            this.dataGridViewFilmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmovi.Size = new System.Drawing.Size(660, 192);
            this.dataGridViewFilmovi.TabIndex = 30;
            this.dataGridViewFilmovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilmovi_CellClick);
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.BackColor = System.Drawing.Color.White;
            this.buttonIzbrisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonIzbrisi.Location = new System.Drawing.Point(596, 220);
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
            this.buttonPrikazi.Location = new System.Drawing.Point(419, 220);
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
            this.buttonIzmjeni.Location = new System.Drawing.Point(242, 220);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(126, 36);
            this.buttonIzmjeni.TabIndex = 27;
            this.buttonIzmjeni.Text = "Izmijeni";
            this.buttonIzmjeni.UseVisualStyleBackColor = false;
            // 
            // buttonKreiraj
            // 
            this.buttonKreiraj.BackColor = System.Drawing.Color.White;
            this.buttonKreiraj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKreiraj.Location = new System.Drawing.Point(62, 220);
            this.buttonKreiraj.Name = "buttonKreiraj";
            this.buttonKreiraj.Size = new System.Drawing.Size(126, 36);
            this.buttonKreiraj.TabIndex = 26;
            this.buttonKreiraj.Text = "Kreiraj";
            this.buttonKreiraj.UseVisualStyleBackColor = false;
            this.buttonKreiraj.Click += new System.EventHandler(this.buttonKreiraj_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(350, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(206, 27);
            this.textBoxID.TabIndex = 25;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(177, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 23);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID";
            // 
            // textBoxGodinaIzlaska
            // 
            this.textBoxGodinaIzlaska.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGodinaIzlaska.Location = new System.Drawing.Point(350, 126);
            this.textBoxGodinaIzlaska.Name = "textBoxGodinaIzlaska";
            this.textBoxGodinaIzlaska.Size = new System.Drawing.Size(206, 27);
            this.textBoxGodinaIzlaska.TabIndex = 23;
            // 
            // labelGodinaIzlaska
            // 
            this.labelGodinaIzlaska.AutoSize = true;
            this.labelGodinaIzlaska.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelGodinaIzlaska.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGodinaIzlaska.ForeColor = System.Drawing.Color.White;
            this.labelGodinaIzlaska.Location = new System.Drawing.Point(177, 130);
            this.labelGodinaIzlaska.Name = "labelGodinaIzlaska";
            this.labelGodinaIzlaska.Size = new System.Drawing.Size(149, 23);
            this.labelGodinaIzlaska.TabIndex = 22;
            this.labelGodinaIzlaska.Text = "Godina Izlaska";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNaziv.Location = new System.Drawing.Point(350, 77);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(206, 27);
            this.textBoxNaziv.TabIndex = 21;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNaziv.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.ForeColor = System.Drawing.Color.White;
            this.labelNaziv.Location = new System.Drawing.Point(177, 81);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(62, 23);
            this.labelNaziv.TabIndex = 20;
            this.labelNaziv.Text = "Naziv";
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
    }
}