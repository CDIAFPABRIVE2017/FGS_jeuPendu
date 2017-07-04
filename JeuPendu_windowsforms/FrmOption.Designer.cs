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
            this.rbCouleur = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdImage = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // rbCouleur
            // 
            this.rbCouleur.AutoSize = true;
            this.rbCouleur.Location = new System.Drawing.Point(3, 3);
            this.rbCouleur.Name = "rbCouleur";
            this.rbCouleur.Size = new System.Drawing.Size(61, 17);
            this.rbCouleur.TabIndex = 3;
            this.rbCouleur.TabStop = true;
            this.rbCouleur.Text = "Couleur";
            this.rbCouleur.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdImage);
            this.panel1.Controls.Add(this.rbCouleur);
            this.panel1.Location = new System.Drawing.Point(145, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 47);
            this.panel1.TabIndex = 4;
            // 
            // rdImage
            // 
            this.rdImage.AutoSize = true;
            this.rdImage.Location = new System.Drawing.Point(2, 23);
            this.rdImage.Name = "rdImage";
            this.rdImage.Size = new System.Drawing.Size(93, 17);
            this.rdImage.TabIndex = 4;
            this.rdImage.TabStop = true;
            this.rdImage.Text = "Image de fond";
            this.rdImage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fond de la form :";
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_validermodifs);
            this.Controls.Add(this.txtB_nbmanches);
            this.Controls.Add(this.lb_nbmanchequestion);
            this.Name = "FrmOption";
            this.Text = "FrmOption";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label lb_nbmanchequestion;
        private System.Windows.Forms.TextBox txtB_nbmanches;
        private System.Windows.Forms.Button btn_validermodifs;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdImage;
        private System.Windows.Forms.RadioButton rbCouleur;
    }
}