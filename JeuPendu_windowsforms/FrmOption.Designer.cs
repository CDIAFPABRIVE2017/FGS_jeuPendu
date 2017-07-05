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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_style1 = new System.Windows.Forms.CheckBox();
            this.chb_style2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.chb_style2);
            this.panel1.Controls.Add(this.chb_style1);
            this.panel1.Location = new System.Drawing.Point(145, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 57);
            this.panel1.TabIndex = 4;
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
            // chb_style1
            // 
            this.chb_style1.AutoSize = true;
            this.chb_style1.Location = new System.Drawing.Point(9, 8);
            this.chb_style1.Name = "chb_style1";
            this.chb_style1.Size = new System.Drawing.Size(58, 17);
            this.chb_style1.TabIndex = 6;
            this.chb_style1.Text = "Style 1";
            this.chb_style1.UseVisualStyleBackColor = true;
            // 
            // chb_style2
            // 
            this.chb_style2.AutoSize = true;
            this.chb_style2.Location = new System.Drawing.Point(8, 31);
            this.chb_style2.Name = "chb_style2";
            this.chb_style2.Size = new System.Drawing.Size(85, 17);
            this.chb_style2.TabIndex = 7;
            this.chb_style2.Text = "Licorne style";
            this.chb_style2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(262, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 211);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox chb_style2;
        private System.Windows.Forms.CheckBox chb_style1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}