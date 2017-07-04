namespace JeuPendu_windowsforms
{
	partial class FrmOption
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
            this.lb_nbmanchequestion = new System.Windows.Forms.Label();
            this.txtB_nbmanches = new System.Windows.Forms.TextBox();
            this.btn_validermodifs = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nbmanchequestion
            // 
            this.lb_nbmanchequestion.AutoSize = true;
            this.lb_nbmanchequestion.Location = new System.Drawing.Point(28, 35);
            this.lb_nbmanchequestion.Name = "lb_nbmanchequestion";
            this.lb_nbmanchequestion.Size = new System.Drawing.Size(111, 13);
            this.lb_nbmanchequestion.TabIndex = 0;
            this.lb_nbmanchequestion.Text = "Nombre de manches :";
            // 
            // txtB_nbmanches
            // 
            this.txtB_nbmanches.Location = new System.Drawing.Point(145, 32);
            this.txtB_nbmanches.Name = "txtB_nbmanches";
            this.txtB_nbmanches.Size = new System.Drawing.Size(50, 20);
            this.txtB_nbmanches.TabIndex = 1;
            // 
            // btn_validermodifs
            // 
            this.btn_validermodifs.Location = new System.Drawing.Point(31, 144);
            this.btn_validermodifs.Name = "btn_validermodifs";
            this.btn_validermodifs.Size = new System.Drawing.Size(197, 23);
            this.btn_validermodifs.TabIndex = 2;
            this.btn_validermodifs.Text = "Valider les modifications";
            this.btn_validermodifs.UseVisualStyleBackColor = true;
            this.btn_validermodifs.Click += new System.EventHandler(this.btn_validermodifs_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 191);
            this.Controls.Add(this.btn_validermodifs);
            this.Controls.Add(this.txtB_nbmanches);
            this.Controls.Add(this.lb_nbmanchequestion);
            this.Name = "FrmOption";
            this.Text = "FrmOption";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label lb_nbmanchequestion;
        private System.Windows.Forms.TextBox txtB_nbmanches;
        private System.Windows.Forms.Button btn_validermodifs;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}