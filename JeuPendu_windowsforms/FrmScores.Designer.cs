namespace JeuPendu_windowsforms
{
    partial class FrmScores
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
            this.listbx_scores = new System.Windows.Forms.ListBox();
            this.listbx_pseudos = new System.Windows.Forms.ListBox();
            this.listBox_date = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listbx_scores
            // 
            this.listbx_scores.FormattingEnabled = true;
            this.listbx_scores.Location = new System.Drawing.Point(140, 31);
            this.listbx_scores.Name = "listbx_scores";
            this.listbx_scores.Size = new System.Drawing.Size(82, 186);
            this.listbx_scores.TabIndex = 0;
            this.listbx_scores.SelectedIndexChanged += new System.EventHandler(this.listbx_scores_SelectedIndexChanged);
            // 
            // listbx_pseudos
            // 
            this.listbx_pseudos.FormattingEnabled = true;
            this.listbx_pseudos.Location = new System.Drawing.Point(39, 31);
            this.listbx_pseudos.Name = "listbx_pseudos";
            this.listbx_pseudos.Size = new System.Drawing.Size(82, 186);
            this.listbx_pseudos.TabIndex = 1;
            // 
            // listBox_date
            // 
            this.listBox_date.FormattingEnabled = true;
            this.listBox_date.Location = new System.Drawing.Point(248, 31);
            this.listBox_date.Name = "listBox_date";
            this.listBox_date.Size = new System.Drawing.Size(120, 186);
            this.listBox_date.TabIndex = 2;
            // 
            // FrmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 313);
            this.Controls.Add(this.listBox_date);
            this.Controls.Add(this.listbx_pseudos);
            this.Controls.Add(this.listbx_scores);
            this.Name = "FrmScores";
            this.Text = "FrmScores";
            this.Load += new System.EventHandler(this.FrmScores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbx_scores;
        private System.Windows.Forms.ListBox listbx_pseudos;
        private System.Windows.Forms.ListBox listBox_date;
    }
}