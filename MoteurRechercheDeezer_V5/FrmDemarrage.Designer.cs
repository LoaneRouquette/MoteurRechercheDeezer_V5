namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    partial class FrmDemarrage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteurMultimédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheDAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtistInfos = new System.Windows.Forms.GroupBox();
            this.picIpod = new System.Windows.Forms.PictureBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.tbpDisco = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmpDisco = new AxWMPLib.AxWindowsMediaPlayer();
            this.wbDisco = new System.Windows.Forms.WebBrowser();
            this.lstDiscoTitre = new System.Windows.Forms.ListBox();
            this.lblDisco2 = new System.Windows.Forms.Label();
            this.lstDiscoAlbum = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictDisco = new System.Windows.Forms.PictureBox();
            this.tbpRadio = new System.Windows.Forms.TabPage();
            this.wbRadio = new System.Windows.Forms.WebBrowser();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.picBannière = new System.Windows.Forms.PictureBox();
            this.toolTipAppli = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIconEtat = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masquerCtrlMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tbc.SuspendLayout();
            this.tbpArtiste.SuspendLayout();
            this.grbArtistInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.tbpDisco.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDisco)).BeginInit();
            this.tbpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannière)).BeginInit();
            this.contextMenuStripNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecteurMultimédiaToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // lecteurMultimédiaToolStripMenuItem
            // 
            this.lecteurMultimédiaToolStripMenuItem.Name = "lecteurMultimédiaToolStripMenuItem";
            this.lecteurMultimédiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lecteurMultimédiaToolStripMenuItem.Text = "&Lecteur Multimédia";
            this.lecteurMultimédiaToolStripMenuItem.Click += new System.EventHandler(this.lecteurMultimédiaToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheDAlbumsToolStripMenuItem});
            this.rechercheToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rechercheToolStripMenuItem.Text = "&Recherche";
            // 
            // rechercheDAlbumsToolStripMenuItem
            // 
            this.rechercheDAlbumsToolStripMenuItem.Name = "rechercheDAlbumsToolStripMenuItem";
            this.rechercheDAlbumsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rechercheDAlbumsToolStripMenuItem.Text = "&Recherche d\'&Albums...";
            this.rechercheDAlbumsToolStripMenuItem.Click += new System.EventHandler(this.rechercheDAlbumsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aToolStripMenuItem.Text = "A &propos";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteRecherche.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(34, 125);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(95, 13);
            this.lblArtisteRecherche.TabIndex = 3;
            this.lblArtisteRecherche.Text = "Artiste Recherché:";
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtArtisteRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtisteRecherche.Location = new System.Drawing.Point(135, 122);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(233, 20);
            this.txtArtisteRecherche.TabIndex = 4;
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtisteRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechercher.Location = new System.Drawing.Point(374, 120);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpArtiste);
            this.tbc.Controls.Add(this.tbpDisco);
            this.tbc.Controls.Add(this.tbpRadio);
            this.tbc.Location = new System.Drawing.Point(37, 163);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(545, 256);
            this.tbc.TabIndex = 6;
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbpArtiste.Controls.Add(this.grbArtistInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(537, 230);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Infos Artiste";
            // 
            // grbArtistInfos
            // 
            this.grbArtistInfos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbArtistInfos.Controls.Add(this.picIpod);
            this.grbArtistInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtistInfos.Controls.Add(this.lstArtistes);
            this.grbArtistInfos.Controls.Add(this.label1);
            this.grbArtistInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtistInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtistInfos.Controls.Add(this.picArtiste);
            this.grbArtistInfos.Location = new System.Drawing.Point(7, 7);
            this.grbArtistInfos.Name = "grbArtistInfos";
            this.grbArtistInfos.Size = new System.Drawing.Size(524, 217);
            this.grbArtistInfos.TabIndex = 0;
            this.grbArtistInfos.TabStop = false;
            this.grbArtistInfos.Text = "Information DEEZER";
            this.grbArtistInfos.Visible = false;
            // 
            // picIpod
            // 
            this.picIpod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIpod.Image = global::ZiKnCo_MoteurRechercheDeezer_V2.Properties.Resources.ipod;
            this.picIpod.Location = new System.Drawing.Point(233, 164);
            this.picIpod.Name = "picIpod";
            this.picIpod.Size = new System.Drawing.Size(58, 47);
            this.picIpod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIpod.TabIndex = 8;
            this.picIpod.TabStop = false;
            this.toolTipAppli.SetToolTip(this.picIpod, "Accès au COVER FLOW (Type IPOD...)");
            this.picIpod.Click += new System.EventHandler(this.picIpod_Click);
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEcouterExtraits.Location = new System.Drawing.Point(21, 168);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(206, 41);
            this.btnEcouterExtraits.TabIndex = 7;
            this.btnEcouterExtraits.Text = "&Ecouter tous les extraits musicaux...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(21, 41);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(270, 121);
            this.lstArtistes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artistes trouvés :";
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.LinkColor = System.Drawing.Color.Black;
            this.lklDeezerLien.Location = new System.Drawing.Point(347, 187);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(74, 13);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien DEEZER";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerLien_LinkClicked);
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(334, 20);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(62, 26);
            this.lblArtisteNom.TabIndex = 2;
            this.lblArtisteNom.Text = "Nom";
            // 
            // picArtiste
            // 
            this.picArtiste.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picArtiste.ErrorImage")));
            this.picArtiste.InitialImage = ((System.Drawing.Image)(resources.GetObject("picArtiste.InitialImage")));
            this.picArtiste.Location = new System.Drawing.Point(339, 49);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(97, 123);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 0;
            this.picArtiste.TabStop = false;
            // 
            // tbpDisco
            // 
            this.tbpDisco.Controls.Add(this.panel1);
            this.tbpDisco.Location = new System.Drawing.Point(4, 22);
            this.tbpDisco.Name = "tbpDisco";
            this.tbpDisco.Size = new System.Drawing.Size(537, 230);
            this.tbpDisco.TabIndex = 2;
            this.tbpDisco.Text = "Discographie";
            this.tbpDisco.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wmpDisco);
            this.panel1.Controls.Add(this.wbDisco);
            this.panel1.Controls.Add(this.lstDiscoTitre);
            this.panel1.Controls.Add(this.lblDisco2);
            this.panel1.Controls.Add(this.lstDiscoAlbum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictDisco);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 227);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // wmpDisco
            // 
            this.wmpDisco.Enabled = true;
            this.wmpDisco.Location = new System.Drawing.Point(-2, 159);
            this.wmpDisco.Name = "wmpDisco";
            this.wmpDisco.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpDisco.OcxState")));
            this.wmpDisco.Size = new System.Drawing.Size(534, 45);
            this.wmpDisco.TabIndex = 6;
            // 
            // wbDisco
            // 
            this.wbDisco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbDisco.Location = new System.Drawing.Point(0, 144);
            this.wbDisco.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDisco.Name = "wbDisco";
            this.wbDisco.ScriptErrorsSuppressed = true;
            this.wbDisco.Size = new System.Drawing.Size(534, 83);
            this.wbDisco.TabIndex = 5;
            // 
            // lstDiscoTitre
            // 
            this.lstDiscoTitre.FormattingEnabled = true;
            this.lstDiscoTitre.Location = new System.Drawing.Point(331, 30);
            this.lstDiscoTitre.Name = "lstDiscoTitre";
            this.lstDiscoTitre.Size = new System.Drawing.Size(191, 108);
            this.lstDiscoTitre.TabIndex = 4;
            this.lstDiscoTitre.Click += new System.EventHandler(this.lstDiscoTitre_Click);
            this.lstDiscoTitre.SelectedIndexChanged += new System.EventHandler(this.lstDiscoTitre_SelectedIndexChanged);
            // 
            // lblDisco2
            // 
            this.lblDisco2.AutoSize = true;
            this.lblDisco2.Location = new System.Drawing.Point(328, 14);
            this.lblDisco2.Name = "lblDisco2";
            this.lblDisco2.Size = new System.Drawing.Size(39, 13);
            this.lblDisco2.TabIndex = 3;
            this.lblDisco2.Text = "Titres :";
            // 
            // lstDiscoAlbum
            // 
            this.lstDiscoAlbum.FormattingEnabled = true;
            this.lstDiscoAlbum.Location = new System.Drawing.Point(130, 30);
            this.lstDiscoAlbum.Name = "lstDiscoAlbum";
            this.lstDiscoAlbum.Size = new System.Drawing.Size(183, 108);
            this.lstDiscoAlbum.TabIndex = 2;
            this.lstDiscoAlbum.SelectedIndexChanged += new System.EventHandler(this.lstDiscoAlbum_SelectedIndexChanged);
            this.lstDiscoAlbum.DoubleClick += new System.EventHandler(this.lstDiscoAlbum_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Albums :";
            // 
            // pictDisco
            // 
            this.pictDisco.Image = ((System.Drawing.Image)(resources.GetObject("pictDisco.Image")));
            this.pictDisco.Location = new System.Drawing.Point(16, 30);
            this.pictDisco.Name = "pictDisco";
            this.pictDisco.Size = new System.Drawing.Size(105, 100);
            this.pictDisco.TabIndex = 0;
            this.pictDisco.TabStop = false;
            // 
            // tbpRadio
            // 
            this.tbpRadio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbpRadio.Controls.Add(this.wbRadio);
            this.tbpRadio.Location = new System.Drawing.Point(4, 22);
            this.tbpRadio.Name = "tbpRadio";
            this.tbpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRadio.Size = new System.Drawing.Size(537, 230);
            this.tbpRadio.TabIndex = 1;
            this.tbpRadio.Text = "Radio Artiste";
            // 
            // wbRadio
            // 
            this.wbRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbRadio.Location = new System.Drawing.Point(3, 3);
            this.wbRadio.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbRadio.Name = "wbRadio";
            this.wbRadio.ScriptErrorsSuppressed = true;
            this.wbRadio.ScrollBarsEnabled = false;
            this.wbRadio.Size = new System.Drawing.Size(531, 224);
            this.wbRadio.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMessage.Location = new System.Drawing.Point(138, 147);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "  ";
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erp.ContainerControl = this;
            // 
            // picDeezer
            // 
            this.picDeezer.Image = ((System.Drawing.Image)(resources.GetObject("picDeezer.Image")));
            this.picDeezer.Location = new System.Drawing.Point(466, 106);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(116, 50);
            this.picDeezer.TabIndex = 2;
            this.picDeezer.TabStop = false;
            this.picDeezer.Click += new System.EventHandler(this.picDeezer_Click);
            // 
            // picBannière
            // 
            this.picBannière.Image = ((System.Drawing.Image)(resources.GetObject("picBannière.Image")));
            this.picBannière.Location = new System.Drawing.Point(12, 39);
            this.picBannière.Name = "picBannière";
            this.picBannière.Size = new System.Drawing.Size(570, 61);
            this.picBannière.TabIndex = 1;
            this.picBannière.TabStop = false;
            // 
            // toolTipAppli
            // 
            this.toolTipAppli.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAppli.ToolTipTitle = "Pour info:";
            // 
            // notifyIconEtat
            // 
            this.notifyIconEtat.ContextMenuStrip = this.contextMenuStripNotifications;
            this.notifyIconEtat.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEtat.Icon")));
            this.notifyIconEtat.Text = "Zik\'nCo - Moteur de recherche DEEZER";
            this.notifyIconEtat.Visible = true;
            // 
            // contextMenuStripNotifications
            // 
            this.contextMenuStripNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.masquerCtrlMToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.contextMenuStripNotifications.Name = "contextMenuStripNotifications";
            this.contextMenuStripNotifications.Size = new System.Drawing.Size(166, 70);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // masquerCtrlMToolStripMenuItem
            // 
            this.masquerCtrlMToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("masquerCtrlMToolStripMenuItem.Image")));
            this.masquerCtrlMToolStripMenuItem.Name = "masquerCtrlMToolStripMenuItem";
            this.masquerCtrlMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.masquerCtrlMToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.masquerCtrlMToolStripMenuItem.Text = "Masquer";
            this.masquerCtrlMToolStripMenuItem.Click += new System.EventHandler(this.masquerCtrlMToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem1.Image")));
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.picBannière);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDemarrage";
            this.Text = "Moteur de Recherche DEEZER: Version 4";
            this.Activated += new System.EventHandler(this.FrmDemarrage_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemarrage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc.ResumeLayout(false);
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtistInfos.ResumeLayout(false);
            this.grbArtistInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.tbpDisco.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictDisco)).EndInit();
            this.tbpRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBannière)).EndInit();
            this.contextMenuStripNotifications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteurMultimédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBannière;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.GroupBox grbArtistInfos;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.TabPage tbpRadio;
        private System.Windows.Forms.WebBrowser wbRadio;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.TabPage tbpDisco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictDisco;
        private System.Windows.Forms.ListBox lstDiscoTitre;
        private System.Windows.Forms.Label lblDisco2;
        private System.Windows.Forms.ListBox lstDiscoAlbum;
        private System.Windows.Forms.WebBrowser wbDisco;
        private AxWMPLib.AxWindowsMediaPlayer wmpDisco;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheDAlbumsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIpod;
        private System.Windows.Forms.ToolTip toolTipAppli;
        private System.Windows.Forms.NotifyIcon notifyIconEtat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifications;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masquerCtrlMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
    }
}

