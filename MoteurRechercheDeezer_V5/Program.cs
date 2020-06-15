using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;

namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmDemarrage());
            Application.Run(new FrmDemarrage());


            #region Tests sur le parcours de collection
            //DeezerApi.discoComplete = true;
            //List<Artist> lesArtistes = new List<Artist>();
            //string recherche = "m";
            //lesArtistes = DeezerApi.getAllArtistsByName(recherche);



            //Console.WriteLine("Il y a " + lesArtistes.Count + " Artistes :");

            //Afichage Méthode Foreach
            //foreach (Artist unArtist in lesArtistes)
            //{
            //    Console.WriteLine(unArtist.name);
            //}



            //Affichage Méthode For
            //int i;
            //for (i = 0; i <= lesArtistes.Count - 1; i++)
            //{
            //    Console.WriteLine(lesArtistes[i]);
            //}
            #endregion

            #region Tests de méthodes dans la fenêtre de sortie
            //Artist monArtist = new Artist();
            //string recherche = "Buuren";
            //monArtist = DeezerApi.getFirstArtistByName(recherche);

            //if (!NetManager.isConnected())
            //{
            //    Console.WriteLine("Non connecté à internet");
            //}
            //else
            //{
            //    if (monArtist == null)
            //    {
            //        Console.WriteLine("Désolé, l'artiste " + recherche + " n'est pas connu ...");

            //    }
            //    else
            //    {
            //        Console.WriteLine("\nInformations du premier artiste trouvé :");
            //        Console.WriteLine("--------------------------------------------");
            //        Console.WriteLine("Nom : " + monArtist.name);
            //        Console.WriteLine("Image : " + monArtist.picture);
            //        Console.WriteLine("Lien du PLUGIN de la Radio de l'artiste : " + DeezerPlugin.getUrlPluginRadio(monArtist.id));
            //    }

            //}
            #endregion

            #region Exercice 1 : image du premier artiste trouvé
            //Artist theArtist = DeezerApi.getFirstArtistByName("vaughan");
            //Console.WriteLine(theArtist.picture);
            #endregion

            #region Exercice 2 : Afficher le titre du premier album trouvé
            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByName("djangology");
            //Album premierAlbum = lesAlbums[0];
            //Console.WriteLine(premierAlbum.title);
            #endregion

            #region Exercice 3 : Afficher nom de l'artiste de l'album
            // Console.WriteLine(premierAlbum.theArtist.name);
            #endregion

            #region Exercice 4 : Afficher le nom d'un artiste d'un track
            //List<Track> lesTracks = DeezerApi.getAllTracksByName("Minor Swing");
            //Track premierTrack = lesTracks[0];
            //Album albumDuTrack = premierTrack.theAlbum;
            //Artist artistDuTrack = albumDuTrack.theArtist;
            //Console.WriteLine(artistDuTrack.name);
            #endregion

            #region Exercice 1: Afficher toutes les couvertures d'albums
            //List<Album> lesAlbums2 = DeezerApi.getAllAlbumsByName("Bande Originale");
            //int i;
            //for (i = 0; i < lesAlbums2.Count; i++)
            //{
            //    Console.WriteLine(lesAlbums2[i].cover);
            //}
            #endregion

            #region Exercice 1 bis : idem dessus mais avec 3 albums
            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByName("Bande Originale");
            //int i;
            //for (i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(lesAlbums[i].cover);
            //}
            #endregion

            #region Exercice 1 ter : idem du dessus mais avec boucle while
            //List<Album> lesAlbums2 = DeezerApi.getAllAlbumsByName("Bande Originale");
            //int i=0;
            //while ( i < lesAlbums2.Count )
            //{
            //    Console.WriteLine(lesAlbums2[i].cover);
            //    i++;
            //}
            #endregion

            #region Exercice 2 : afficher les mp3 de l'album de stromae
            //Artist theArtist = DeezerApi.getFirstArtistByName("STROMAE");
            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByArtist(theArtist);
            //Album premierAlbum = lesAlbums[0];
            //premierAlbum = DeezerApi.getDetailsAlbumById(premierAlbum.id);
            //List<Track> lesTracks = premierAlbum.getLesTracks();
            //int i = 0;
            //while (i < lesTracks.Count)
            //{
            //    Track unTrack = lesTracks[i];
            //    Console.WriteLine(unTrack.preview);
            //    i++;
            //}
            #endregion

            #region Exercice 3 : Afficher tous les mp3 de 3 premiers albums
            //Artist theArtist = DeezerApi.getFirstArtistByName("STROMAE");
            //List<Album> lesAlbums = DeezerApi.getAllAlbumsByArtist(theArtist);
            //int n;
            //for (n = 0; n < 3; n++)
            //{
            //    Album premierAlbum = lesAlbums[n];
            //    premierAlbum = DeezerApi.getDetailsAlbumById(premierAlbum.id);
            //    List<Track> lesTracks = premierAlbum.getLesTracks();
            //    int i = 0;
            //    while (i < lesTracks.Count)
            //    {
            //        Track unTrack = lesTracks[i];
            //        Console.WriteLine(unTrack.preview);
            //        i++;
            //    }
            //}
            #endregion

        }
    }
}
