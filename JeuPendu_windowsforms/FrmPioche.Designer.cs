namespace JeuPendu_windowsforms
{
	partial class FrmPioche
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstMotRetenu = new System.Windows.Forms.ListBox();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.btnAccepter = new System.Windows.Forms.Button();
            this.btnRefuser = new System.Windows.Forms.Button();
            this.lblMotsRetenus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(221, 248);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(89, 25);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(378, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 212);
            this.listBox1.TabIndex = 3;
            // 
            // lstMotRetenu
            // 
            this.lstMotRetenu.FormattingEnabled = true;
            this.lstMotRetenu.Location = new System.Drawing.Point(25, 62);
            this.lstMotRetenu.Name = "lstMotRetenu";
            this.lstMotRetenu.Size = new System.Drawing.Size(131, 212);
            this.lstMotRetenu.TabIndex = 4;
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(181, 62);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(173, 20);
            this.txtSaisie.TabIndex = 5;
            // 
            // btnAccepter
            // 
            this.btnAccepter.Location = new System.Drawing.Point(181, 128);
            this.btnAccepter.Name = "btnAccepter";
            this.btnAccepter.Size = new System.Drawing.Size(81, 29);
            this.btnAccepter.TabIndex = 6;
            this.btnAccepter.Text = "Accepter";
            this.btnAccepter.UseVisualStyleBackColor = true;
            // 
            // btnRefuser
            // 
            this.btnRefuser.Location = new System.Drawing.Point(273, 128);
            this.btnRefuser.Name = "btnRefuser";
            this.btnRefuser.Size = new System.Drawing.Size(81, 29);
            this.btnRefuser.TabIndex = 7;
            this.btnRefuser.Text = "Refuser";
            this.btnRefuser.UseVisualStyleBackColor = true;
            // 
            // lblMotsRetenus
            // 
            this.lblMotsRetenus.AutoSize = true;
            this.lblMotsRetenus.Location = new System.Drawing.Point(75, 25);
            this.lblMotsRetenus.Name = "lblMotsRetenus";
            this.lblMotsRetenus.Size = new System.Drawing.Size(35, 13);
            this.lblMotsRetenus.TabIndex = 8;
            this.lblMotsRetenus.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // FrmPioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMotsRetenus);
            this.Controls.Add(this.btnRefuser);
            this.Controls.Add(this.btnAccepter);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.lstMotRetenu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "FrmPioche";
            this.Text = "FrmPioche";
            this.Load += new System.EventHandler(this.FrmPioche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstMotRetenu;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.Button btnAccepter;
        private System.Windows.Forms.Button btnRefuser;
        private System.Windows.Forms.Label lblMotsRetenus;
        private System.Windows.Forms.Label label2;
    }
}