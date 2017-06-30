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
            this.btnQuiter = new System.Windows.Forms.Button();
            this.lblMotsImpropres = new System.Windows.Forms.Label();
            this.lblDictionnaire = new System.Windows.Forms.Label();
            this.btnExclure = new System.Windows.Forms.Button();
            this.btnPiocher = new System.Windows.Forms.Button();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.listeInitiale = new System.Windows.Forms.ListBox();
            this.Corbeille = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvrirFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(181, 249);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(89, 25);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(286, 247);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(68, 27);
            this.btnQuiter.TabIndex = 10;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click_1);
            // 
            // lblMotsImpropres
            // 
            this.lblMotsImpropres.AutoSize = true;
            this.lblMotsImpropres.Location = new System.Drawing.Point(401, 33);
            this.lblMotsImpropres.Name = "lblMotsImpropres";
            this.lblMotsImpropres.Size = new System.Drawing.Size(78, 13);
            this.lblMotsImpropres.TabIndex = 18;
            this.lblMotsImpropres.Text = "Mots impropres";
            // 
            // lblDictionnaire
            // 
            this.lblDictionnaire.AutoSize = true;
            this.lblDictionnaire.Location = new System.Drawing.Point(47, 33);
            this.lblDictionnaire.Name = "lblDictionnaire";
            this.lblDictionnaire.Size = new System.Drawing.Size(66, 13);
            this.lblDictionnaire.TabIndex = 17;
            this.lblDictionnaire.Text = "Dictionnaire ";
            // 
            // btnExclure
            // 
            this.btnExclure.Location = new System.Drawing.Point(274, 75);
            this.btnExclure.Name = "btnExclure";
            this.btnExclure.Size = new System.Drawing.Size(81, 29);
            this.btnExclure.TabIndex = 16;
            this.btnExclure.Text = "Exclure";
            this.btnExclure.UseVisualStyleBackColor = true;
            this.btnExclure.Click += new System.EventHandler(this.btnExclure_Click);
            // 
            // btnPiocher
            // 
            this.btnPiocher.Location = new System.Drawing.Point(182, 75);
            this.btnPiocher.Name = "btnPiocher";
            this.btnPiocher.Size = new System.Drawing.Size(81, 29);
            this.btnPiocher.TabIndex = 15;
            this.btnPiocher.Text = "Piocher";
            this.btnPiocher.UseVisualStyleBackColor = true;
            this.btnPiocher.Click += new System.EventHandler(this.btnPiocher_Click_1);
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(182, 165);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(173, 20);
            this.txtSaisie.TabIndex = 14;
            // 
            // listeInitiale
            // 
            this.listeInitiale.FormattingEnabled = true;
            this.listeInitiale.Location = new System.Drawing.Point(26, 58);
            this.listeInitiale.Name = "listeInitiale";
            this.listeInitiale.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listeInitiale.Size = new System.Drawing.Size(131, 212);
            this.listeInitiale.Sorted = true;
            this.listeInitiale.TabIndex = 13;
            // 
            // Corbeille
            // 
            this.Corbeille.FormattingEnabled = true;
            this.Corbeille.Location = new System.Drawing.Point(379, 57);
            this.Corbeille.Name = "Corbeille";
            this.Corbeille.Size = new System.Drawing.Size(131, 212);
            this.Corbeille.Sorted = true;
            this.Corbeille.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirFichierToolStripMenuItem,
            this.supprimerMotsToolStripMenuItem,
            this.ajouterMotsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ouvrirFichierToolStripMenuItem
            // 
            this.ouvrirFichierToolStripMenuItem.Name = "ouvrirFichierToolStripMenuItem";
            this.ouvrirFichierToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.ouvrirFichierToolStripMenuItem.Text = "&Ouvrir Fichier";
            this.ouvrirFichierToolStripMenuItem.Click += new System.EventHandler(this.ouvrirFichierToolStripMenuItem_Click);
            // 
            // supprimerMotsToolStripMenuItem
            // 
            this.supprimerMotsToolStripMenuItem.Name = "supprimerMotsToolStripMenuItem";
            this.supprimerMotsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.supprimerMotsToolStripMenuItem.Text = "&Supprimer Mots";
            this.supprimerMotsToolStripMenuItem.Click += new System.EventHandler(this.supprimerMotsToolStripMenuItem_Click);
            // 
            // ajouterMotsToolStripMenuItem
            // 
            this.ajouterMotsToolStripMenuItem.Name = "ajouterMotsToolStripMenuItem";
            this.ajouterMotsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.ajouterMotsToolStripMenuItem.Text = "&Ajouter Mots";
            this.ajouterMotsToolStripMenuItem.Click += new System.EventHandler(this.ajouterMotsToolStripMenuItem_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(227, 127);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // FrmPioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 303);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblMotsImpropres);
            this.Controls.Add(this.lblDictionnaire);
            this.Controls.Add(this.btnExclure);
            this.Controls.Add(this.btnPiocher);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.listeInitiale);
            this.Controls.Add(this.Corbeille);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPioche";
            this.Text = "FrmPioche";
            this.Load += new System.EventHandler(this.FrmPioche_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Label lblMotsImpropres;
        private System.Windows.Forms.Label lblDictionnaire;
        private System.Windows.Forms.Button btnExclure;
        private System.Windows.Forms.Button btnPiocher;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.ListBox listeInitiale;
        private System.Windows.Forms.ListBox Corbeille;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerMotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMotsToolStripMenuItem;
        private System.Windows.Forms.Button btnAjouter;
    }
}