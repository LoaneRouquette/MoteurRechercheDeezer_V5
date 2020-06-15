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
using System.Net;
using CDI.IndexCard3D;

namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    public partial class FrmCoverFlow : Form
    {


        #region Champs
        private List<Album> lesAlbums = new List<Album>();
        private List<Track> lesTracks = new List<Track>();
        Track selectedTrack = new Track();

        public Artist selectedArtistDetails = new Artist();
        #endregion


        #region méthodes 
        public FrmCoverFlow()
        {
            InitializeComponent();
        }


        private void chargerTitresSelectesdAlbum()
        { 
            lstTitres.Items.Clear();
            this.Cursor = Cursors.WaitCursor;
            Album selectedAlbum = lesAlbums.ElementAt(iC3DAlbum.ActiveCard-1);
            lesTracks = selectedAlbum.getLesTracks();
           
            int i = 0;
            while (i < lesTracks.Count)
            {
                Track unTrack = lesTracks[i];
                lstTitres.Items.Add(unTrack);
                lstTitres.DisplayMember = "title";
                i++;
            }

            int indexTitre = 1;

            wmpLecteur.currentPlaylist.clear();

            foreach (Track unTrack in lesTracks)
            {
                WMPLib.IWMPMedia unMedia = wmpLecteur.newMedia(unTrack.preview);
                wmpLecteur.currentPlaylist.appendItem(unMedia);
                unMedia.setItemInfo("nomTitre", unTrack.title);
                unMedia.setItemInfo("xSurY", indexTitre.ToString());
                indexTitre++;

            }
            this.Cursor = Cursors.Default;
        }

        #endregion





        private void FrmCoverFlow_Load(object sender, EventArgs e)
        {
            lesAlbums = selectedArtistDetails.getLesAlbums();
            WebClient wClient = new WebClient();
            string nomImage;
            int i;

            for (i = 0; i <lesAlbums.Count; i++)
            {
                nomImage = "image" + i + ".jpg";
                wClient.DownloadFile(lesAlbums[i].cover, nomImage);
                Card c = new Card(lesAlbums[i].title, nomImage);
                iC3DAlbum.IndexCards.Add(c);

            }
            iC3DAlbum.IndexCards.LoadTexturesToMemory();


            chargerTitresSelectesdAlbum();

        }

        private void iC3DAlbum_RenderText(object sender, EventArgs e)
        {
            Font fntNom = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitre = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);
            string titre = iC3DAlbum.IndexCards.ElementAt(iC3DAlbum.ActiveCard - 1).Title;

            iC3DAlbum.DrawText(0, iC3DAlbum.Height - 75, selectedArtistDetails.name, IC3D.TextAlignment.Center, fntNom, Color.FloralWhite);
            iC3DAlbum.DrawText(0, iC3DAlbum.Height - 45, titre, IC3D.TextAlignment.Center, fntTitre, Color.Wheat);
        }

        private void iC3DAlbum_IndexCardChanged(object sender, IndexCardEventArgs e)
        {
            chargerTitresSelectesdAlbum();
        }


        private void wmpLecteur_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            lblTitre.Text = wmpLecteur.currentMedia.getItemInfo("nomTitre");
            lblXsurY.Text = wmpLecteur.currentMedia.getItemInfo("xSurY") + " sur " + lesTracks.Count;

            
            string nbTitre = wmpLecteur.currentMedia.getItemInfo("xSurY");
            if (nbTitre != "")
                {
                int mon_int = Convert.ToInt32(nbTitre);
                lstTitres.SelectedIndex = mon_int-1;
                }
        }

        private void lstTitres_Click(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstTitres.SelectedItem;
            WMPLib.IWMPMedia unMedia = wmpLecteur.currentPlaylist.get_Item(lstTitres.SelectedIndex);
            wmpLecteur.Ctlcontrols.playItem(unMedia);
        }

        private void lblXsurY_MouseHover(object sender, EventArgs e)
        {
            panListeTitres.Visible = true;
        }

        private void lstTitres_MouseLeave(object sender, EventArgs e)
        {
            panListeTitres.Visible = false;
        }



    }
}
