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
            this.btnQuiter = new System.Windows.Forms.Button();
            this.lblMotsImpropres = new System.Windows.Forms.Label();
            this.btnExclure = new System.Windows.Forms.Button();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.ctl_lstInitiale = new System.Windows.Forms.ListBox();
            this.Corbeille = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvrirFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerDictionnaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btn_Recherche = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(410, 355);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(81, 27);
            this.btnQuiter.TabIndex = 10;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click_1);
            // 
            // lblMotsImpropres
            // 
            this.lblMotsImpropres.AutoSize = true;
            this.lblMotsImpropres.Location = new System.Drawing.Point(350, 39);
            this.lblMotsImpropres.Name = "lblMotsImpropres";
            this.lblMotsImpropres.Size = new System.Drawing.Size(80, 13);
            this.lblMotsImpropres.TabIndex = 18;
            this.lblMotsImpropres.Text = "Mots supprimés";
            this.lblMotsImpropres.Click += new System.EventHandler(this.lblMotsImpropres_Click);
            // 
            // btnExclure
            // 
            this.btnExclure.Location = new System.Drawing.Point(209, 303);
            this.btnExclure.Name = "btnExclure";
            this.btnExclure.Size = new System.Drawing.Size(81, 29);
            this.btnExclure.TabIndex = 16;
            this.btnExclure.Text = "Exclure";
            this.btnExclure.UseVisualStyleBackColor = true;
            this.btnExclure.Click += new System.EventHandler(this.btnExclure_Click);
            // 
            // txtSaisie
            // 
            this.txtSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaisie.Location = new System.Drawing.Point(19, 39);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(149, 23);
            this.txtSaisie.TabIndex = 14;
            // 
            // ctl_lstInitiale
            // 
            this.ctl_lstInitiale.FormattingEnabled = true;
            this.ctl_lstInitiale.Location = new System.Drawing.Point(19, 72);
            this.ctl_lstInitiale.Name = "ctl_lstInitiale";
            this.ctl_lstInitiale.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ctl_lstInitiale.Size = new System.Drawing.Size(149, 264);
            this.ctl_lstInitiale.TabIndex = 13;
            // 
            // Corbeille
            // 
            this.Corbeille.FormattingEnabled = true;
            this.Corbeille.Location = new System.Drawing.Point(347, 55);
            this.Corbeille.Name = "Corbeille";
            this.Corbeille.Size = new System.Drawing.Size(149, 277);
            this.Corbeille.Sorted = true;
            this.Corbeille.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirFichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ouvrirFichierToolStripMenuItem
            // 
            this.ouvrirFichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chargerDictionnaireToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.ajoutToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.ouvrirFichierToolStripMenuItem.Name = "ouvrirFichierToolStripMenuItem";
            this.ouvrirFichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ouvrirFichierToolStripMenuItem.Text = "&Fichier";
            // 
            // chargerDictionnaireToolStripMenuItem
            // 
            this.chargerDictionnaireToolStripMenuItem.Name = "chargerDictionnaireToolStripMenuItem";
            this.chargerDictionnaireToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.chargerDictionnaireToolStripMenuItem.Text = "Charger";
            this.chargerDictionnaireToolStripMenuItem.Click += new System.EventHandler(this.chargerDictionnaireToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ajoutToolStripMenuItem.Text = "Ajouter";
            this.ajoutToolStripMenuItem.Click += new System.EventHandler(this.ajoutToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(224, 37);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(81, 27);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btn_Recherche
            // 
            this.btn_Recherche.Image = global::JeuPendu_windowsforms.Properties.Resources.iconeRecherche;
            this.btn_Recherche.Location = new System.Drawing.Point(180, 40);
            this.btn_Recherche.Name = "btn_Recherche";
            this.btn_Recherche.Size = new System.Drawing.Size(31, 23);
            this.btn_Recherche.TabIndex = 24;
            this.btn_Recherche.UseVisualStyleBackColor = true;
            this.btn_Recherche.Click += new System.EventHandler(this.btRecherche_Click);
            // 
            // FrmPioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 400);
            this.Controls.Add(this.btn_Recherche);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblMotsImpropres);
            this.Controls.Add(this.btnExclure);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.ctl_lstInitiale);
            this.Controls.Add(this.Corbeille);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPioche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPioche";
            this.Load += new System.EventHandler(this.FrmPioche_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.Label lblMotsImpropres;
        private System.Windows.Forms.Button btnExclure;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.ListBox ctl_lstInitiale;
        private System.Windows.Forms.ListBox Corbeille;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierToolStripMenuItem;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ToolStripMenuItem chargerDictionnaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.Button btn_Recherche;
    }
}