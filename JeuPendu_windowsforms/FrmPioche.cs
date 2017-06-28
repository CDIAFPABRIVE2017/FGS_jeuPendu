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
	public partial class Pioche : Form
	{
		public Pioche()
		{
			InitializeComponent();
		}
        #region Proprietes 
        public int AjouterMot
        {
            get;
            set;
        }
        public bool isMotValide
        {
            get;
            set;
        }
        public int RetraiterMot
        {
            get;
            set;
        }
        public int ExtraireMot
        {
            get;
            set;
        }
        /// <summary>
        /// Ouverture de la boite de dialogue ouvrir un fichier 
        /// ouverture du fichier selectionné après click sur ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(sr.ReadToEnd());
                sr.Close();
            }


        }
        #endregion

        public Pioche()
        {
            

        }
            

        }


    }

