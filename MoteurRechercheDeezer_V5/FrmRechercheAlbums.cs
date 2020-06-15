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
    public partial class FrmRechercheAlbums : Form
    {
        private string recherche;
        List<Album> lesAlbums = new List<Album>();
        Album selectedAlbum = new Album();
        Track selectedTrack = new Track();


        private const string MESSAGE_ALBUM_INCONNU = "Désolé, l'album '#valeur#' est inconnu sur Deezer ...";
        private const string MESSAGE_SAISIE_ALBUM = "Veuillez saisir un artiste à rechercher";
        private const string MESSAGE_RECHERCHE_ALBUM = "Recherche en cours, veuillez patienter...";
        private string message;

        public FrmRechercheAlbums()
        {
            InitializeComponent();
        }



        private void btnRecherche_Click(object sender, EventArgs e)
        {
            recherche = txtAlbumRecherche.Text;
            lesAlbums = DeezerApi.getAllAlbumsByName(recherche);

            if (txtAlbumRecherche.Text == string.Empty)
            {
                erp.SetError(txtAlbumRecherche, MESSAGE_SAISIE_ALBUM);
                lblMessage.Text = MESSAGE_SAISIE_ALBUM;
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                lblMessage.Text = MESSAGE_RECHERCHE_ALBUM;
                lblMessage.Refresh();
                rechercherArtistes();
            }
        }
        private void rechercherArtistes()
        {
            if (lesAlbums.Count == 0)
            {
                //MessageBox.Show("Désolé, l'artiste " + recherche + " n'est pas connu ...", "ZiK'nCo : avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                message = MESSAGE_ALBUM_INCONNU.Replace("#valeur#", recherche);
                lblMessage.Text = message;
                erp.SetError(txtAlbumRecherche, message);
            }
            else
            {
                lblMessage.Text = string.Empty;
                grbAlbums.Visible = true; 
                lstAlbum.DataSource = lesAlbums;
                lstAlbum.DisplayMember = "title";
                grbAlbums.Visible = true;
                erp.SetError(txtAlbumRecherche, string.Empty);

                lstAlbum.SelectedIndexChanged += new System.EventHandler(this.lstAlbum_SelectedIndexChanged);
                lstAlbum_SelectedIndexChanged(this, new EventArgs());

            }
        }

        private void lstAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)lstAlbum.SelectedItem;

            selectedAlbum = DeezerApi.getDetailsAlbumById(selectedAlbum.id);

            lstTitresAlbum.DataSource = selectedAlbum.getLesTracks();
            lstTitresAlbum.DisplayMember = "title";


            lstTitresAlbum.SelectedIndexChanged += new System.EventHandler(this.lstTitresAlbum_SelectedIndexChanged);
            lstTitresAlbum_SelectedIndexChanged(this, new EventArgs());


            lblArtistName.Text = selectedAlbum.theArtist.name;
            picCoverAlbum.ImageLocation = selectedAlbum.cover;

            picArtist.ImageLocation = selectedAlbum.theArtist.picture;
            
        }

        private void lstTitresAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstTitresAlbum_Click(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstTitresAlbum.SelectedItem;

            wmpTitre.currentMedia = wmpTitre.newMedia(selectedTrack.preview);
            wmpTitre.Ctlcontrols.play();
        }
    }
}
