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
    public partial class FrmPlaylist : Form
    {
        public FrmPlaylist()
        {
            InitializeComponent();
        }



        private void FrmPlaylist_Load(object sender, EventArgs e)
        {
            Artist theArtist = DeezerApi.getFirstArtistByName("STROMAE");
            List<Album> lesAlbums = DeezerApi.getAllAlbumsByArtist(theArtist);
            Album premierAlbum = lesAlbums[0];
            premierAlbum = DeezerApi.getDetailsAlbumById(premierAlbum.id);
            List<Track> lesTracks = premierAlbum.getLesTracks();
            int i = 0;
            while (i < lesTracks.Count)
            {
                Track unTrack = lesTracks[i];
                lstGauche.Items.Add(unTrack);
                lstGauche.DisplayMember = "name";
                i++;
            }

            lstGauche.SelectedIndex = 0;

            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;
            btnJouerExtraits.Enabled = false;

        }
        private void lstGauche_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersDroiteUn.Enabled = true;
            btnVersDroiteTous.Enabled = true;

            if (lstDroite.Items.Count == 0)
            {
                btnVersGaucheUn.Enabled = false;
                btnVersGaucheTous.Enabled = false;
                btnJouerExtraits.Enabled = false;

            }

        }
        private void lstDroite_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersGaucheUn.Enabled = true;
            btnVersGaucheTous.Enabled = true;

            if (lstGauche.Items.Count == 0 )
            {
                btnVersDroiteUn.Enabled = false;
                btnVersDroiteTous.Enabled = false;
            }
        }




        private void boutonsTransfert_Click(object sender, EventArgs e)
        {
            Button boutonDeclencheur = (Button)(sender);

            switch (boutonDeclencheur.Name)
            {
                case "btnVersDroiteUn":
                    transferer(lstGauche, lstDroite, ModeTransfert.Un);
                    if (lstGauche.Items.Count==0)
                    {
                        btnVersDroiteUn.Enabled = false;
                        btnVersDroiteTous.Enabled = false;
                        lstDroite.SelectedIndex = 0;
                        btnJouerExtraits.Enabled = false;
                        btnRandom.Enabled =false;
                    }
                    else
                    {
                        lstGauche.SelectedIndex = 0;
                    }
                    if (btnJouerExtraits.Enabled == false)
                    {
                        btnJouerExtraits.Enabled = true;
                    }
                    break;
                case "btnVersDroiteTous":
                    transferer(lstGauche, lstDroite, ModeTransfert.Tous);
                    btnVersDroiteUn.Enabled = false;
                    btnVersDroiteTous.Enabled = false;
                    lstDroite.SelectedIndex = 0;
                    btnRandom.Enabled = false;
                    if (btnJouerExtraits.Enabled == false)
                    {
                        btnJouerExtraits.Enabled = true;
                    }
                    break;
                case "btnVersGaucheUn":
                    transferer(lstDroite, lstGauche, ModeTransfert.Un);
                    if (lstDroite.Items.Count == 0)
                    {
                        btnVersGaucheUn.Enabled = false;
                        btnVersGaucheTous.Enabled = false;
                        lstGauche.SelectedIndex = 0;
                        btnJouerExtraits.Enabled = false;
                        btnRandom.Enabled = true;
                    }
                    else
                    {
                        lstDroite.SelectedIndex = 0;
                    }
                    break;
                case "btnVersGaucheTous":
                    transferer(lstDroite, lstGauche, ModeTransfert.Tous);
                    btnVersGaucheUn.Enabled = false;
                    btnVersGaucheTous.Enabled = false;
                    lstGauche.SelectedIndex = 0;
                    if (lstDroite.Items.Count == 0)
                    {
                        btnJouerExtraits.Enabled = false;
                        btnRandom.Enabled = true;
                    }
                    break;
            }
        }
        


        private void transferer(ListBox lstSource, ListBox lstDestination, ModeTransfert mode)
        {
            switch (mode)
            {
                case ModeTransfert.Un :
                    lstDestination.Items.Add(lstSource.SelectedItem);
                    lstSource.Items.Remove(lstSource.SelectedItem);
                    break;

                case ModeTransfert.Tous:
                    foreach (object element in lstSource.Items)
                        lstDestination.Items.Add(element);
                    lstSource.Items.Clear();
                    break;
            }
        }
        

        enum ModeTransfert
        {
            Un,
            Tous,
            Certains
        }

        private void btnJouerExtraits_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            
            foreach (Track unTrack in lstDroite.Items)
            {
                WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
            }
            formulaire.Show();
            formulaire.wmpLecteur.Ctlcontrols.play();
        }

        private void lstDroite_Click(object sender, EventArgs e)
        {
            if (lstDroite.Items.Count>0)
            {
                if (lstDroite.SelectedIndex == -1)
                {
                    lstDroite.SelectedIndex = 0;
                }
            }
            
        }

        private void lstGauche_Click(object sender, EventArgs e)
        {
            if (lstGauche.Items.Count>0)
            {
                if (lstGauche.SelectedIndex == -1)
                {
                    lstGauche.SelectedIndex = 0;
                }
            }
            
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random randm = new Random();

            int nbTitres = lstGauche.Items.Count;
            //int rdm = randm.Next(0, nbTitres);
            int i;
            for (i = 0; i< nbTitres; i++)
            {
                int rdmTrack = randm.Next(0, lstGauche.Items.Count);
                lstDroite.Items.Add(lstGauche.Items[rdmTrack]);
                lstGauche.Items.Remove(lstGauche.Items[rdmTrack]);
            }

            //if (lstGauche.Items.Count == 0)
            //{
                btnVersDroiteUn.Enabled = false;
                btnVersDroiteTous.Enabled = false;
            //}
            //if (lstDroite.Items.Count != 0)
            //{
                btnVersGaucheUn.Enabled = true;
                btnVersGaucheTous.Enabled = true;
                btnJouerExtraits.Enabled = true;

            //}
            
            lstDroite.SelectedIndex = 0;
            btnRandom.Enabled = false;
            //btnJouerExtraits_Click(sender, e);
        }
    }
}
