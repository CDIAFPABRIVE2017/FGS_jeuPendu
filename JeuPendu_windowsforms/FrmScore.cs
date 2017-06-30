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
            try
            {
                XmlReader  xmlFile;
                //xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
                DataSet ds = new DataSet();
                ds.ReadXml("scores.xml");
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns.Insert(0, new DataGridViewColumn(dataGridView1.Columns[0].CellTemplate));
                dataGridView1.Rows[1].Cells[1].Value = "azerty";
                dataGridView1.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
