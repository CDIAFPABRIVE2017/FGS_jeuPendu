﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuPendu_windowsforms
{
    public partial class InterfaceMere : Form
    {
        public InterfaceMere()
        {
            InitializeComponent();
        }

        private void jeuDuPenduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJeu jeux = new FrmJeu();
            jeux.MdiParent = this;
            jeux.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScore score = new FrmScore();
            score.MdiParent = this;
            score.Show();
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void piocheToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}