﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiKnCo_MoteurRechercheDeezer_V2
{
    public partial class FrmLecteurMultimedia : Form
    {
        public FrmLecteurMultimedia()
        {
            InitializeComponent();
        }

        private void btnChoisirFichier_Click(object sender, EventArgs e)
        {
            diaMultimedia.ShowDialog();
            wmpLecteur.URL = diaMultimedia.FileName;
        }

        private void wmpLecteur_Enter(object sender, EventArgs e)
        {

        }
    }
}
