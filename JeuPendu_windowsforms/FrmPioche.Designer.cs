namespace JeuPendu_windowsforms
{
	partial class Pioche
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.lsbDico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(293, 147);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(89, 25);
            this.btnOuvrir.TabIndex = 0;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // lsbDico
            // 
            this.lsbDico.FormattingEnabled = true;
            this.lsbDico.Location = new System.Drawing.Point(27, 25);
            this.lsbDico.Name = "lsbDico";
            this.lsbDico.Size = new System.Drawing.Size(104, 147);
            this.lsbDico.TabIndex = 1;
            // 
            // Pioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 307);
            this.Controls.Add(this.lsbDico);
            this.Controls.Add(this.btnOuvrir);
            this.Name = "Pioche";
            this.Text = "FrmPioche";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.ListBox lsbDico;
    }
}