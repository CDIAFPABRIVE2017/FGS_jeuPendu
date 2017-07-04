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
            this.SuspendLayout();
            // 
            // listbx_scores
            // 
            this.listbx_scores.FormattingEnabled = true;
            this.listbx_scores.Location = new System.Drawing.Point(22, 31);
            this.listbx_scores.Name = "listbx_scores";
            this.listbx_scores.Size = new System.Drawing.Size(235, 186);
            this.listbx_scores.TabIndex = 0;
            // 
            // FrmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listbx_scores);
            this.Name = "FrmScores";
            this.Text = "FrmScores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbx_scores;
    }
}