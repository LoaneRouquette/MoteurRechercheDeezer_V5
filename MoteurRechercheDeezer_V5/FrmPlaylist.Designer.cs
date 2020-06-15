namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    partial class FrmPlaylist
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
            this.lblMorceau = new System.Windows.Forms.Label();
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVersDroiteUn = new System.Windows.Forms.Button();
            this.btnVersDroiteTous = new System.Windows.Forms.Button();
            this.btnVersGaucheUn = new System.Windows.Forms.Button();
            this.btnJouerExtraits = new System.Windows.Forms.Button();
            this.btnVersGaucheTous = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMorceau
            // 
            this.lblMorceau.AutoSize = true;
            this.lblMorceau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMorceau.Location = new System.Drawing.Point(9, 9);
            this.lblMorceau.Name = "lblMorceau";
            this.lblMorceau.Size = new System.Drawing.Size(110, 13);
            this.lblMorceau.TabIndex = 0;
            this.lblMorceau.Text = "Morceaux de l\'album :";
            // 
            // lstGauche
            // 
            this.lstGauche.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(12, 25);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(220, 212);
            this.lstGauche.TabIndex = 1;
            this.lstGauche.Click += new System.EventHandler(this.lstGauche_Click);
            this.lstGauche.SelectedIndexChanged += new System.EventHandler(this.lstGauche_SelectedIndexChanged);
            // 
            // lstDroite
            // 
            this.lstDroite.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(370, 25);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(216, 160);
            this.lstDroite.TabIndex = 2;
            this.lstDroite.Click += new System.EventHandler(this.lstDroite_Click);
            this.lstDroite.SelectedIndexChanged += new System.EventHandler(this.lstDroite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Morceaux choisis (playlist) :";
            // 
            // btnVersDroiteUn
            // 
            this.btnVersDroiteUn.Location = new System.Drawing.Point(238, 25);
            this.btnVersDroiteUn.Name = "btnVersDroiteUn";
            this.btnVersDroiteUn.Size = new System.Drawing.Size(126, 33);
            this.btnVersDroiteUn.TabIndex = 4;
            this.btnVersDroiteUn.Text = "> Un";
            this.btnVersDroiteUn.UseVisualStyleBackColor = true;
            this.btnVersDroiteUn.Click += new System.EventHandler(this.boutonsTransfert_Click);
            // 
            // btnVersDroiteTous
            // 
            this.btnVersDroiteTous.Location = new System.Drawing.Point(238, 64);
            this.btnVersDroiteTous.Name = "btnVersDroiteTous";
            this.btnVersDroiteTous.Size = new System.Drawing.Size(126, 33);
            this.btnVersDroiteTous.TabIndex = 5;
            this.btnVersDroiteTous.Text = ">> Tous";
            this.btnVersDroiteTous.UseVisualStyleBackColor = true;
            this.btnVersDroiteTous.Click += new System.EventHandler(this.boutonsTransfert_Click);
            // 
            // btnVersGaucheUn
            // 
            this.btnVersGaucheUn.Location = new System.Drawing.Point(238, 116);
            this.btnVersGaucheUn.Name = "btnVersGaucheUn";
            this.btnVersGaucheUn.Size = new System.Drawing.Size(126, 33);
            this.btnVersGaucheUn.TabIndex = 6;
            this.btnVersGaucheUn.Text = "< Un";
            this.btnVersGaucheUn.UseVisualStyleBackColor = true;
            this.btnVersGaucheUn.Click += new System.EventHandler(this.boutonsTransfert_Click);
            // 
            // btnJouerExtraits
            // 
            this.btnJouerExtraits.Location = new System.Drawing.Point(371, 191);
            this.btnJouerExtraits.Name = "btnJouerExtraits";
            this.btnJouerExtraits.Size = new System.Drawing.Size(214, 46);
            this.btnJouerExtraits.TabIndex = 8;
            this.btnJouerExtraits.Text = "Jouer les extraits...";
            this.btnJouerExtraits.UseVisualStyleBackColor = true;
            this.btnJouerExtraits.Click += new System.EventHandler(this.btnJouerExtraits_Click);
            // 
            // btnVersGaucheTous
            // 
            this.btnVersGaucheTous.Location = new System.Drawing.Point(238, 155);
            this.btnVersGaucheTous.Name = "btnVersGaucheTous";
            this.btnVersGaucheTous.Size = new System.Drawing.Size(126, 33);
            this.btnVersGaucheTous.TabIndex = 7;
            this.btnVersGaucheTous.Text = "<< Tous";
            this.btnVersGaucheTous.UseVisualStyleBackColor = true;
            this.btnVersGaucheTous.Click += new System.EventHandler(this.boutonsTransfert_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(239, 198);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(126, 33);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Randomizer";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(597, 244);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnJouerExtraits);
            this.Controls.Add(this.btnVersGaucheTous);
            this.Controls.Add(this.btnVersGaucheUn);
            this.Controls.Add(this.btnVersDroiteTous);
            this.Controls.Add(this.btnVersDroiteUn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Controls.Add(this.lblMorceau);
            this.Name = "FrmPlaylist";
            this.Text = "PLAYLIST des Extraits de l\'album...";
            this.Load += new System.EventHandler(this.FrmPlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMorceau;
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVersDroiteUn;
        private System.Windows.Forms.Button btnVersDroiteTous;
        private System.Windows.Forms.Button btnVersGaucheUn;
        private System.Windows.Forms.Button btnJouerExtraits;
        public System.Windows.Forms.ListBox lstGauche;
        private System.Windows.Forms.Button btnVersGaucheTous;
        private System.Windows.Forms.Button btnRandom;
    }
}