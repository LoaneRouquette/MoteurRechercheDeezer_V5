using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;
using System.Diagnostics;

namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    public partial class FrmDemarrage : Form
    {
        #region Champs

        Artist selectedArtist = new Artist();
        Album selectedAlbum = new Album();
        Track selectedTrack = new Track();

        List<Artist> lesArtistes = new List<Artist>();
        private string recherche;

        private const string MESSAGE_SAISIE_ARTISTE = "Veuillez saisir un artiste à rechercher";
        private const string MESSAGE_RECHERCHE_ARTISTE = "Recherche en cours, veuillez patienter...";
        private const string MESSAGE_ARTISTE_INCONNU = "Désolé, l'artiste '#valeur#' est inconnu sur Deezer ...";
        private const string MESSAGE_DISCOGRAPHIE_INDISPONIBLE = "Désolé, la discographie pour '#valeur#' n'est pas disponible...";
        private const string MESSAGE_CONNEXION_INTERNET = "La recherche Deezer est impossible...";
        private const string TITRE_CONNEXION_INTERNET = "Non connecté à internet";
        private string message;
        private bool isConnected;
        
        #endregion

        #region constructeurs
        public FrmDemarrage()
        {
            InitializeComponent();
        }
        #endregion

        #region méthodes gestionnaire d'évènement

        #region Traitement principal: Clic sur le btnRechercher
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if (!NetManager.isConnected())
            {
                notifyIconEtat.ShowBalloonTip(600, TITRE_CONNEXION_INTERNET, MESSAGE_CONNEXION_INTERNET, ToolTipIcon.Error);
                System.Media.SystemSounds.Exclamation.Play();
            }
            else
            {

            recherche = txtArtisteRecherche.Text;
            lesArtistes = DeezerApi.getAllArtistsByName(recherche);


            if (txtArtisteRecherche.Text == string.Empty )
            {
                erp.SetError(txtArtisteRecherche, MESSAGE_SAISIE_ARTISTE);
                lblMessage.Text = MESSAGE_SAISIE_ARTISTE;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = MESSAGE_RECHERCHE_ARTISTE;
                lblMessage.Refresh();
                rechercherArtistes();

            }
            txtArtisteRecherche.Text = string.Empty;

            }


        }


        private void txtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }


        #endregion

        #region Gestion des menus
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lecteurMultimédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            formulaire.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropos formulaire = new FrmPropos();
            formulaire.Show();
        }
        #endregion

        #region Gestion des listes
        private void lstArtistes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedArtist = (Artist)lstArtistes.SelectedItem;

            selectedArtist = DeezerApi.getDetailsArtistById(selectedArtist.id);

            lblArtisteNom.Text = selectedArtist.name;
            picArtiste.ImageLocation = selectedArtist.picture;
            lklDeezerLien.Text = selectedArtist.link;
            string urlWidget = DeezerPlugin.getUrlPluginRadio(selectedArtist.id, wbRadio.Size.Width, wbRadio.Size.Height);
            wbRadio.Navigate(urlWidget);
            
            pictDisco.ImageLocation = selectedArtist.picture;

            lstDiscoAlbum.DataSource = selectedArtist.getLesAlbums();
            lstDiscoAlbum.DisplayMember = "title";

        }

        private void lstDiscoAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)lstDiscoAlbum.SelectedItem;

            lstDiscoTitre.DataSource = selectedAlbum.getLesTracks();
            lstDiscoTitre.DisplayMember = "title";


            lstDiscoTitre.SelectedIndexChanged += new System.EventHandler(this.lstDiscoTitre_SelectedIndexChanged);
            lstDiscoTitre_SelectedIndexChanged(this, new EventArgs());

        }

        private void lstDiscoTitre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstDiscoTitre_Click(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstDiscoTitre.SelectedItem;
            //string urlTrack = DeezerPlugin.getUrlPluginTrack(selectedTrack.id);
            // wmpDisco.URL=urlTrack;
            //wbDisco.Navigate(urlTrack);

            wmpDisco.currentMedia = wmpDisco.newMedia(selectedTrack.preview);
            wmpDisco.Ctlcontrols.play();
        }
        private void lstDiscoAlbum_DoubleClick(object sender, EventArgs e)
        {
            FrmPlaylist formulaire = new FrmPlaylist();
            List<Track> lesTracks = selectedAlbum.getLesTracks();

            foreach (Track unTrack in lesTracks)
            {
                formulaire.lstGauche.Items.Add(unTrack);
                formulaire.lstGauche.DisplayMember = "name";

            }
            formulaire.Show();
        }
        #endregion

        #region Autres traitements


        private void rechercheDAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercheAlbums formulaire = new FrmRechercheAlbums();
            formulaire.Show();
        }


        private void rechercherArtistes()
        {
            if (lesArtistes.Count == 0)
            {
                //MessageBox.Show("Désolé, l'artiste " + recherche + " n'est pas connu ...", "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                message = MESSAGE_ARTISTE_INCONNU.Replace("#valeur#", recherche);
                lblMessage.Text = message;
                erp.SetError(txtArtisteRecherche, message);
            }
            else
            {
                lblMessage.Text = string.Empty;

                lstArtistes.DataSource = lesArtistes;
                lstArtistes.DisplayMember = "name";
                grbArtistInfos.Visible = true;
                erp.SetError(txtArtisteRecherche, string.Empty);
                panel1.Visible = true;

                lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged);
                lstArtistes_SelectedIndexChanged(this, new EventArgs());

            }
        }
        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {
            Artist selectedArtistDetails = new Artist();
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);

            if (selectedArtistDetails.nbAlbums == 0)
            {
                lblMessage.Text = "Désolé, les extraits pour '" + selectedArtist.name + "' ne sont pas disponibles...";
                btnEcouterExtraits.Enabled = false;
            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();

                foreach (Album unAlbum in lesAlbums)
                {
                    List<Track> lesTracks = unAlbum.getLesTracks();
                    foreach (Track unTrack in lesTracks)
                    {
                        WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                    }
                }
                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }

        private void picDeezer_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.deezer.com/fr/");
        }

        private void lklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lklDeezerLien.Text);
        }

        private void FrmDemarrage_Activated(object sender, EventArgs e)
        {
            txtArtisteRecherche.Focus();
        }

        private void FrmDemarrage_Load(object sender, EventArgs e)
        {
            if (!NetManager.isConnected())
            {
                MessageBox.Show(TITRE_CONNEXION_INTERNET);
                isConnected = false;
            }
            notifyIconEtat.ShowBalloonTip(600, "Bienvenue "+Environment.UserName , "Appli ZiK'nCo.DEEZER lançée le "+DateTime.Now.ToString("dd/MM/yyyy")+" à "+DateTime.Now.ToString("HH:mm:ss"), ToolTipIcon.None);

        }

        private void FrmDemarrage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isConnected == true)
            {
                Application.Exit();
            }
            else
            {
                if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "Zik'n Co : Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void picIpod_Click(object sender, EventArgs e)
        {
            if (selectedArtist.nbAlbums == 0)
            {
                lblMessage.Text = "Désolé, les extraits pour '" + selectedArtist.name + "' ne sont pas disponibles...";
                picIpod.Enabled = false;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                FrmCoverFlow formulaire = new FrmCoverFlow();
                formulaire.selectedArtistDetails = selectedArtist;

                formulaire.Show();
                this.Cursor = Cursors.Default;
            }
        }




        #endregion

        #endregion

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void masquerCtrlMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
