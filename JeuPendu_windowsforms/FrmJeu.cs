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
	public partial class FrmJeu : Form
	{
		
		public FrmJeu()
		{
			InitializeComponent();
		}

		

        private void FrmJeu_Load(object sender, EventArgs e)
        {
			pn_clavier.Size = new Size(btn_clavier_A_fr_FR.Width * 3, btn_clavier_A_fr_FR.Width * 10);
        }
    }
}
