namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    partial class FrmRechercheAlbums
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRechercheAlbums));
            this.lblRechercheAlbum = new System.Windows.Forms.Label();
            this.txtAlbumRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.grbAlbums = new System.Windows.Forms.GroupBox();
            this.wmpTitre = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnEcouterExtrait = new System.Windows.Forms.Button();
            this.picArtist = new System.Windows.Forms.PictureBox();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.picCoverAlbum = new System.Windows.Forms.PictureBox();
            this.lstAlbum = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTitresAlbum = new System.Windows.Forms.ListBox();
            this.lblAlbumsTrouves = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.grbAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpTitre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRechercheAlbum
            // 
            this.lblRechercheAlbum.AutoSize = true;
            this.lblRechercheAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercheAlbum.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRechercheAlbum.Location = new System.Drawing.Point(20, 14);
            this.lblRechercheAlbum.Name = "lblRechercheAlbum";
            this.lblRechercheAlbum.Size = new System.Drawing.Size(106, 13);
            this.lblRechercheAlbum.TabIndex = 0;
            this.lblRechercheAlbum.Text = "Album recherché:";
            // 
            // txtAlbumRecherche
            // 
            this.txtAlbumRecherche.Location = new System.Drawing.Point(132, 11);
            this.txtAlbumRecherche.Name = "txtAlbumRecherche";
            this.txtAlbumRecherche.Size = new System.Drawing.Size(166, 20);
            this.txtAlbumRecherche.TabIndex = 1;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(315, 11);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(107, 19);
            this.btnRecherche.TabIndex = 2;
            this.btnRecherche.Text = "Rechercher";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // grbAlbums
            // 
            this.grbAlbums.Controls.Add(this.wmpTitre);
            this.grbAlbums.Controls.Add(this.btnEcouterExtrait);
            this.grbAlbums.Controls.Add(this.picArtist);
            this.grbAlbums.Controls.Add(this.lblArtistName);
            this.grbAlbums.Controls.Add(this.picCoverAlbum);
            this.grbAlbums.Controls.Add(this.lstAlbum);
            this.grbAlbums.Controls.Add(this.label1);
            this.grbAlbums.Controls.Add(this.lstTitresAlbum);
            this.grbAlbums.Controls.Add(this.lblAlbumsTrouves);
            this.grbAlbums.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.grbAlbums.Location = new System.Drawing.Point(18, 60);
            this.grbAlbums.Name = "grbAlbums";
            this.grbAlbums.Size = new System.Drawing.Size(420, 295);
            this.grbAlbums.TabIndex = 3;
            this.grbAlbums.TabStop = false;
            this.grbAlbums.Text = "Informations DEEZER";
            this.grbAlbums.Visible = false;
            // 
            // wmpTitre
            // 
            this.wmpTitre.Enabled = true;
            this.wmpTitre.Location = new System.Drawing.Point(193, 180);
            this.wmpTitre.Name = "wmpTitre";
            this.wmpTitre.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpTitre.OcxState")));
            this.wmpTitre.Size = new System.Drawing.Size(211, 47);
            this.wmpTitre.TabIndex = 9;
            // 
            // btnEcouterExtrait
            // 
            this.btnEcouterExtrait.Location = new System.Drawing.Point(198, 146);
            this.btnEcouterExtrait.Name = "btnEcouterExtrait";
            this.btnEcouterExtrait.Size = new System.Drawing.Size(206, 24);
            this.btnEcouterExtrait.TabIndex = 8;
            this.btnEcouterExtrait.Text = "Ecouter tous les extraits de l\'album...";
            this.btnEcouterExtrait.UseVisualStyleBackColor = true;
            // 
            // picArtist
            // 
            this.picArtist.Location = new System.Drawing.Point(306, 76);
            this.picArtist.Name = "picArtist";
            this.picArtist.Size = new System.Drawing.Size(75, 64);
            this.picArtist.TabIndex = 7;
            this.picArtist.TabStop = false;
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Location = new System.Drawing.Point(303, 54);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(0, 13);
            this.lblArtistName.TabIndex = 6;
            // 
            // picCoverAlbum
            // 
            this.picCoverAlbum.Location = new System.Drawing.Point(198, 54);
            this.picCoverAlbum.Name = "picCoverAlbum";
            this.picCoverAlbum.Size = new System.Drawing.Size(82, 86);
            this.picCoverAlbum.TabIndex = 5;
            this.picCoverAlbum.TabStop = false;
            // 
            // lstAlbum
            // 
            this.lstAlbum.FormattingEnabled = true;
            this.lstAlbum.Location = new System.Drawing.Point(5, 44);
            this.lstAlbum.Name = "lstAlbum";
            this.lstAlbum.Size = new System.Drawing.Size(166, 95);
            this.lstAlbum.TabIndex = 3;
            this.lstAlbum.SelectedIndexChanged += new System.EventHandler(this.lstAlbum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titres de l\'album :";
            // 
            // lstTitresAlbum
            // 
            this.lstTitresAlbum.FormattingEnabled = true;
            this.lstTitresAlbum.Location = new System.Drawing.Point(6, 180);
            this.lstTitresAlbum.Name = "lstTitresAlbum";
            this.lstTitresAlbum.Size = new System.Drawing.Size(166, 108);
            this.lstTitresAlbum.TabIndex = 1;
            // 
            // lblAlbumsTrouves
            // 
            this.lblAlbumsTrouves.AutoSize = true;
            this.lblAlbumsTrouves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumsTrouves.Location = new System.Drawing.Point(15, 28);
            this.lblAlbumsTrouves.Name = "lblAlbumsTrouves";
            this.lblAlbumsTrouves.Size = new System.Drawing.Size(101, 13);
            this.lblAlbumsTrouves.TabIndex = 0;
            this.lblAlbumsTrouves.Text = "Albums trouvés :";
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(135, 37);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // FrmRechercheAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(457, 369);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.grbAlbums);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtAlbumRecherche);
            this.Controls.Add(this.lblRechercheAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRechercheAlbums";
            this.Text = "Recherche d\'Albums";
            this.grbAlbums.ResumeLayout(false);
            this.grbAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpTitre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRechercheAlbum;
        private System.Windows.Forms.TextBox txtAlbumRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.GroupBox grbAlbums;
        private System.Windows.Forms.Label lblAlbumsTrouves;
        private System.Windows.Forms.ListBox lstTitresAlbum;
        private System.Windows.Forms.ListBox lstAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEcouterExtrait;
        private System.Windows.Forms.PictureBox picArtist;
        private System.Windows.Forms.Label lblArtistName;
        private System.Windows.Forms.PictureBox picCoverAlbum;
        private AxWMPLib.AxWindowsMediaPlayer wmpTitre;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblMessage;
    }
}