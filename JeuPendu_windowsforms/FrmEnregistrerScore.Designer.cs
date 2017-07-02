namespace JeuPendu_windowsforms
{
    partial class FrmEnregistrerScore
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
            this.lb_nomjoueur = new System.Windows.Forms.Label();
            this.txt_pseudo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_afficheScore = new System.Windows.Forms.Label();
            this.txtb_score = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_enregistrer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pn_enregistrer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nomjoueur
            // 
            this.lb_nomjoueur.AutoSize = true;
            this.lb_nomjoueur.Location = new System.Drawing.Point(12, 30);
            this.lb_nomjoueur.Name = "lb_nomjoueur";
            this.lb_nomjoueur.Size = new System.Drawing.Size(182, 13);
            this.lb_nomjoueur.TabIndex = 0;
            this.lb_nomjoueur.Text = "Veuillez entrer votre nom ou pseudo :";
            // 
            // txt_pseudo
            // 
            this.txt_pseudo.Location = new System.Drawing.Point(200, 27);
            this.txt_pseudo.Name = "txt_pseudo";
            this.txt_pseudo.Size = new System.Drawing.Size(286, 20);
            this.txt_pseudo.TabIndex = 1;
            this.txt_pseudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lb_afficheScore
            // 
            this.lb_afficheScore.AutoSize = true;
            this.lb_afficheScore.Location = new System.Drawing.Point(14, 18);
            this.lb_afficheScore.Name = "lb_afficheScore";
            this.lb_afficheScore.Size = new System.Drawing.Size(86, 13);
            this.lb_afficheScore.TabIndex = 2;
            this.lb_afficheScore.Text = "Votre Score est :";
            // 
            // txtb_score
            // 
            this.txtb_score.Location = new System.Drawing.Point(106, 15);
            this.txtb_score.Name = "txtb_score";
            this.txtb_score.ReadOnly = true;
            this.txtb_score.Size = new System.Drawing.Size(90, 20);
            this.txtb_score.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Valider Enregistrement";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn_enregistrer
            // 
            this.pn_enregistrer.Controls.Add(this.txtb_score);
            this.pn_enregistrer.Controls.Add(this.button2);
            this.pn_enregistrer.Controls.Add(this.lb_afficheScore);
            this.pn_enregistrer.Location = new System.Drawing.Point(15, 78);
            this.pn_enregistrer.Name = "pn_enregistrer";
            this.pn_enregistrer.Size = new System.Drawing.Size(471, 98);
            this.pn_enregistrer.TabIndex = 8;
            this.pn_enregistrer.Visible = false;
            // 
            // FrmEnregistrerScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 188);
            this.Controls.Add(this.pn_enregistrer);
            this.Controls.Add(this.txt_pseudo);
            this.Controls.Add(this.lb_nomjoueur);
            this.Name = "FrmEnregistrerScore";
            this.Text = "FrmEnregistrerScore";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pn_enregistrer.ResumeLayout(false);
            this.pn_enregistrer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nomjoueur;
        private System.Windows.Forms.TextBox txt_pseudo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pn_enregistrer;
        private System.Windows.Forms.TextBox txtb_score;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_afficheScore;
    }
}