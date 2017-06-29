namespace JeuPendu_windowsforms
{
    partial class FrmScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mancheBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mancheBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mancheBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mancheBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mancheBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mancheBindingSource
            // 
            this.mancheBindingSource.DataSource = typeof(DLLJeuPendu.Manche);
            // 
            // mancheBindingSource1
            // 
            this.mancheBindingSource1.DataSource = typeof(DLLJeuPendu.Manche);
            // 
            // mancheBindingSource2
            // 
            this.mancheBindingSource2.DataSource = typeof(DLLJeuPendu.Manche);
            // 
            // mancheBindingSource3
            // 
            this.mancheBindingSource3.DataSource = typeof(DLLJeuPendu.Manche);
            // 
            // mancheBindingSource4
            // 
            this.mancheBindingSource4.DataSource = typeof(DLLJeuPendu.Manche);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 382);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmScore";
            this.Text = "FrmScore";
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mancheBindingSource;
        private System.Windows.Forms.BindingSource mancheBindingSource1;
        private System.Windows.Forms.BindingSource mancheBindingSource2;
        private System.Windows.Forms.BindingSource mancheBindingSource3;
        private System.Windows.Forms.BindingSource mancheBindingSource4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}