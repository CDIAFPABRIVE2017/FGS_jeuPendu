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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mancheBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.nbErreursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motATrouverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource3)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nbErreursDataGridViewTextBoxColumn,
            this.tempsDataGridViewTextBoxColumn,
            this.motATrouverDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mancheBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(192, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // mancheBindingSource3
            // 
            this.mancheBindingSource3.DataSource = typeof(DLLJeuPendu.Manche);
            // 
            // nbErreursDataGridViewTextBoxColumn
            // 
            this.nbErreursDataGridViewTextBoxColumn.DataPropertyName = "NbErreurs";
            this.nbErreursDataGridViewTextBoxColumn.HeaderText = "NbErreurs";
            this.nbErreursDataGridViewTextBoxColumn.Name = "nbErreursDataGridViewTextBoxColumn";
            // 
            // tempsDataGridViewTextBoxColumn
            // 
            this.tempsDataGridViewTextBoxColumn.DataPropertyName = "Temps";
            this.tempsDataGridViewTextBoxColumn.HeaderText = "Temps";
            this.tempsDataGridViewTextBoxColumn.Name = "tempsDataGridViewTextBoxColumn";
            // 
            // motATrouverDataGridViewTextBoxColumn
            // 
            this.motATrouverDataGridViewTextBoxColumn.DataPropertyName = "MotATrouver";
            this.motATrouverDataGridViewTextBoxColumn.HeaderText = "MotATrouver";
            this.motATrouverDataGridViewTextBoxColumn.Name = "motATrouverDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mancheBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mancheBindingSource;
        private System.Windows.Forms.BindingSource mancheBindingSource1;
        private System.Windows.Forms.BindingSource mancheBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbErreursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motATrouverDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mancheBindingSource3;
    }
}