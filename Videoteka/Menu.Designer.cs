namespace Videoteka
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonClanovi = new System.Windows.Forms.Button();
            this.buttonFilmovi = new System.Windows.Forms.Button();
            this.buttonGlumci = new System.Windows.Forms.Button();
            this.buttonRedatelji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClanovi
            // 
            this.buttonClanovi.BackColor = System.Drawing.Color.White;
            this.buttonClanovi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClanovi.Location = new System.Drawing.Point(327, 43);
            this.buttonClanovi.Name = "buttonClanovi";
            this.buttonClanovi.Size = new System.Drawing.Size(150, 50);
            this.buttonClanovi.TabIndex = 0;
            this.buttonClanovi.Text = "Članovi";
            this.buttonClanovi.UseVisualStyleBackColor = false;
            this.buttonClanovi.Click += new System.EventHandler(this.buttonClanovi_Click);
            // 
            // buttonFilmovi
            // 
            this.buttonFilmovi.BackColor = System.Drawing.Color.White;
            this.buttonFilmovi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFilmovi.Location = new System.Drawing.Point(327, 126);
            this.buttonFilmovi.Name = "buttonFilmovi";
            this.buttonFilmovi.Size = new System.Drawing.Size(150, 50);
            this.buttonFilmovi.TabIndex = 1;
            this.buttonFilmovi.Text = "Filmovi";
            this.buttonFilmovi.UseVisualStyleBackColor = false;
            this.buttonFilmovi.Click += new System.EventHandler(this.buttonFilmovi_Click);
            // 
            // buttonGlumci
            // 
            this.buttonGlumci.BackColor = System.Drawing.Color.White;
            this.buttonGlumci.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGlumci.Location = new System.Drawing.Point(327, 209);
            this.buttonGlumci.Name = "buttonGlumci";
            this.buttonGlumci.Size = new System.Drawing.Size(150, 50);
            this.buttonGlumci.TabIndex = 2;
            this.buttonGlumci.Text = "Glumci";
            this.buttonGlumci.UseVisualStyleBackColor = false;
            // 
            // buttonRedatelji
            // 
            this.buttonRedatelji.BackColor = System.Drawing.Color.White;
            this.buttonRedatelji.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRedatelji.Location = new System.Drawing.Point(327, 292);
            this.buttonRedatelji.Name = "buttonRedatelji";
            this.buttonRedatelji.Size = new System.Drawing.Size(150, 50);
            this.buttonRedatelji.TabIndex = 3;
            this.buttonRedatelji.Text = "Redatelji";
            this.buttonRedatelji.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonRedatelji);
            this.Controls.Add(this.buttonGlumci);
            this.Controls.Add(this.buttonFilmovi);
            this.Controls.Add(this.buttonClanovi);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClanovi;
        private System.Windows.Forms.Button buttonFilmovi;
        private System.Windows.Forms.Button buttonGlumci;
        private System.Windows.Forms.Button buttonRedatelji;
    }
}