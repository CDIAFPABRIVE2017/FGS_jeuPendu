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

        Manche manche = MonApplication.Manche;
        public FrmOption()
        {
            InitializeComponent();
        }

        private void btn_validermodifs_Click(object sender, EventArgs e)
        {
            if (txtB_nbmanches.Text != string.Empty)
            {
                if (manche.IsNbManchesValid(txtB_nbmanches.Text))
                {
                    manche.NbMancheMax = Convert.ToInt32(txtB_nbmanches.Text);
                }
                else
                    errorProvider1.SetError(btn_validermodifs, string.Format("{0} n'est pas une valeur correcte", txtB_nbmanches));
            }

            if (chb_style1.Checked)
            {
                Properties.Settings.Default.CouleurFond = Color.PeachPuff;
                Properties.Settings.Default.CouleurPolice = Color.SaddleBrown;
                Properties.Settings.Default.Police = new Font("Broadway", 20, System.Drawing.FontStyle.Bold);
            }

            if (chb_style2.Checked)
            {
                FrmJeu.ActiveForm.BackgroundImage = Properties.Resources.VatefaireEncornerparunelicorne;
                Properties.Settings.Default.CouleurFond = Color.MistyRose;
                Properties.Settings.Default.CouleurPolice = Color.DeepPink;
                Properties.Settings.Default.Police = new Font("Gigi", 20, System.Drawing.FontStyle.Bold);
            }

        }
    }

}
