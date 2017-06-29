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
    public partial class FrmScore : Form
    {
        public FrmScore()
        {
            InitializeComponent();
        }

        Score scr = new Score();
        Scores scrs = new Scores();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnDataPropertyNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
}
