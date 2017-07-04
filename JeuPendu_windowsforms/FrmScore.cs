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
using System.IO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Data;




namespace JeuPendu_windowsforms
{
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();
        }

        Score scr = new Score();
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnDataPropertyNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            Scores affiche = new Scores();

            for (int i = 0; i < 10 ; i++)
            {
                MessageBox.Show("er"/*affiche[i].NomJoueur + affiche[i].ScoreJoueur*/);
            }
        }
    }
    
}
