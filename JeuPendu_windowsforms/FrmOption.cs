using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLJeuPendu;

namespace JeuPendu_windowsforms
{
	public partial class FrmOption : Form
	{
        Manche manche = new Manche();
		public FrmOption()
		{
			InitializeComponent();
		}

        private void btn_validermodifs_Click(object sender, EventArgs e)
        {
           // manche.IsNbManchesValid()
        }
    }

}
