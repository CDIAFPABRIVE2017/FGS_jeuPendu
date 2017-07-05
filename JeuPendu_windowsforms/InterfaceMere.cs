using System;
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
        
        private void piocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FrmPioche pioche = new FrmPioche();
			pioche.MdiParent = this;
			pioche.Show();
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			FrmOption option = new FrmOption();
			option.MdiParent = this;
			option.Show();
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

        //private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmScores score = new FrmScores();
        //    score.MdiParent = this;
        //    score.Show();
        //    this.LayoutMdi(MdiLayout.TileHorizontal);
        //}
    }
}
