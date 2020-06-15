namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    partial class FrmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCoverFlow));
            this.iC3DAlbum = new CDI.IndexCard3D.IC3D();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTitres = new System.Windows.Forms.Label();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.panListeTitres = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.panListeTitres.SuspendLayout();
            this.SuspendLayout();
            // 
            // iC3DAlbum
            // 
            this.iC3DAlbum.DisplayCards = 8;
            this.iC3DAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iC3DAlbum.Location = new System.Drawing.Point(0, -100);
            this.iC3DAlbum.Name = "iC3DAlbum";
            this.iC3DAlbum.Size = new System.Drawing.Size(600, 394);
            this.iC3DAlbum.TabIndex = 0;
            this.iC3DAlbum.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.iC3DAlbum_RenderText);
            this.iC3DAlbum.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.iC3DAlbum_IndexCardChanged);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(12, 297);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(34, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Titre :";
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Location = new System.Drawing.Point(530, 297);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(41, 13);
            this.lblXsurY.TabIndex = 2;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.MouseHover += new System.EventHandler(this.lblXsurY_MouseHover);
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(-6, 313);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(590, 45);
            this.wmpLecteur.TabIndex = 3;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            // 
            // lblTitres
            // 
            this.lblTitres.AutoSize = true;
            this.lblTitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitres.Location = new System.Drawing.Point(-3, 6);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(113, 13);
            this.lblTitres.TabIndex = 4;
            this.lblTitres.Text = "Titres de L\'Album :";
            // 
            // lstTitres
            // 
            this.lstTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(0, 22);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(163, 264);
            this.lstTitres.TabIndex = 5;
            this.lstTitres.Click += new System.EventHandler(this.lstTitres_Click);
            this.lstTitres.MouseLeave += new System.EventHandler(this.lstTitres_MouseLeave);
            // 
            // panListeTitres
            // 
            this.panListeTitres.Controls.Add(this.lblTitres);
            this.panListeTitres.Controls.Add(this.lstTitres);
            this.panListeTitres.Location = new System.Drawing.Point(428, -1);
            this.panListeTitres.Name = "panListeTitres";
            this.panListeTitres.Size = new System.Drawing.Size(172, 295);
            this.panListeTitres.TabIndex = 6;
            this.panListeTitres.Visible = false;
            // 
            // FrmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 361);
            this.Controls.Add(this.panListeTitres);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.iC3DAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCoverFlow";
            this.Text = "ZiK\'nCo : Affiche \"Cover Flow\"";
            this.Load += new System.EventHandler(this.FrmCoverFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.panListeTitres.ResumeLayout(false);
            this.panListeTitres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDI.IndexCard3D.IC3D iC3DAlbum;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblXsurY;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.Label lblTitres;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Panel panListeTitres;
    }
}