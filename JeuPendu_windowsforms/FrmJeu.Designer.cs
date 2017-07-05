namespace JeuPendu_windowsforms
{
    partial class FrmJeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtb_MotenCours = new System.Windows.Forms.TextBox();
            this.lb_motADeviner = new System.Windows.Forms.Label();
            this.pn_clavier = new System.Windows.Forms.Panel();
            this.btn_clavier_N_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_M_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_B_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_L_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_V_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_C_frFR = new System.Windows.Forms.Button();
            this.lb_consignesClavier = new System.Windows.Forms.Label();
            this.btn_clavier_K_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_X_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_J_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_W_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_H_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_G_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_F_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_D_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_S_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_Q_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_P_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_O_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_I_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_U_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_Y_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_T_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_r_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_e_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_z_frFR = new System.Windows.Forms.Button();
            this.btn_clavier_A_fr_FR = new System.Windows.Forms.Button();
            this.lb_consignesErreurs = new System.Windows.Forms.Label();
            this.txtB_nbEssaisRestants = new System.Windows.Forms.TextBox();
            this.lb_essais = new System.Windows.Forms.Label();
            this.lb_tpsEcoule = new System.Windows.Forms.Label();
            this.txtB_temps = new System.Windows.Forms.TextBox();
            this.ep_jeu = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_numManche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_clavier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_jeu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_MotenCours
            // 
            this.txtb_MotenCours.Location = new System.Drawing.Point(115, 70);
            this.txtb_MotenCours.Name = "txtb_MotenCours";
            this.txtb_MotenCours.ReadOnly = true;
            this.txtb_MotenCours.Size = new System.Drawing.Size(449, 20);
            this.txtb_MotenCours.TabIndex = 0;
            // 
            // lb_motADeviner
            // 
            this.lb_motADeviner.AutoSize = true;
            this.lb_motADeviner.Location = new System.Drawing.Point(31, 73);
            this.lb_motADeviner.Name = "lb_motADeviner";
            this.lb_motADeviner.Size = new System.Drawing.Size(78, 13);
            this.lb_motADeviner.TabIndex = 1;
            this.lb_motADeviner.Text = "Mot à deviner :";
            // 
            // pn_clavier
            // 
            this.pn_clavier.Controls.Add(this.btn_clavier_N_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_M_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_B_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_L_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_V_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_C_frFR);
            this.pn_clavier.Controls.Add(this.lb_consignesClavier);
            this.pn_clavier.Controls.Add(this.btn_clavier_K_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_X_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_J_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_W_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_H_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_G_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_F_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_D_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_S_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_Q_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_P_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_O_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_I_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_U_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_Y_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_T_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_r_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_e_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_z_frFR);
            this.pn_clavier.Controls.Add(this.btn_clavier_A_fr_FR);
            this.pn_clavier.Location = new System.Drawing.Point(34, 167);
            this.pn_clavier.Name = "pn_clavier";
            this.pn_clavier.Size = new System.Drawing.Size(530, 191);
            this.pn_clavier.TabIndex = 2;
            this.pn_clavier.Visible = false;
            // 
            // btn_clavier_N_frFR
            // 
            this.btn_clavier_N_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_N_frFR.Location = new System.Drawing.Point(348, 133);
            this.btn_clavier_N_frFR.Name = "btn_clavier_N_frFR";
            this.btn_clavier_N_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_N_frFR.TabIndex = 21;
            this.btn_clavier_N_frFR.Text = "N";
            this.btn_clavier_N_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_N_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_M_frFR
            // 
            this.btn_clavier_M_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_M_frFR.Location = new System.Drawing.Point(440, 87);
            this.btn_clavier_M_frFR.Name = "btn_clavier_M_frFR";
            this.btn_clavier_M_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_M_frFR.TabIndex = 19;
            this.btn_clavier_M_frFR.Text = "M";
            this.btn_clavier_M_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_M_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_B_frFR
            // 
            this.btn_clavier_B_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_B_frFR.Location = new System.Drawing.Point(302, 133);
            this.btn_clavier_B_frFR.Name = "btn_clavier_B_frFR";
            this.btn_clavier_B_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_B_frFR.TabIndex = 20;
            this.btn_clavier_B_frFR.Text = "B";
            this.btn_clavier_B_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_B_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_L_frFR
            // 
            this.btn_clavier_L_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_L_frFR.Location = new System.Drawing.Point(394, 87);
            this.btn_clavier_L_frFR.Name = "btn_clavier_L_frFR";
            this.btn_clavier_L_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_L_frFR.TabIndex = 18;
            this.btn_clavier_L_frFR.Text = "L";
            this.btn_clavier_L_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_L_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_V_frFR
            // 
            this.btn_clavier_V_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_V_frFR.Location = new System.Drawing.Point(256, 133);
            this.btn_clavier_V_frFR.Name = "btn_clavier_V_frFR";
            this.btn_clavier_V_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_V_frFR.TabIndex = 19;
            this.btn_clavier_V_frFR.Text = "V";
            this.btn_clavier_V_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_V_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_C_frFR
            // 
            this.btn_clavier_C_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_C_frFR.Location = new System.Drawing.Point(210, 133);
            this.btn_clavier_C_frFR.Name = "btn_clavier_C_frFR";
            this.btn_clavier_C_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_C_frFR.TabIndex = 18;
            this.btn_clavier_C_frFR.Text = "C";
            this.btn_clavier_C_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_C_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // lb_consignesClavier
            // 
            this.lb_consignesClavier.AutoSize = true;
            this.lb_consignesClavier.Location = new System.Drawing.Point(23, 11);
            this.lb_consignesClavier.Name = "lb_consignesClavier";
            this.lb_consignesClavier.Size = new System.Drawing.Size(339, 13);
            this.lb_consignesClavier.TabIndex = 3;
            this.lb_consignesClavier.Text = "Cliquez sur une touche pour tester si la lettre est présente dans le mot :";
            // 
            // btn_clavier_K_frFR
            // 
            this.btn_clavier_K_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_K_frFR.Location = new System.Drawing.Point(348, 87);
            this.btn_clavier_K_frFR.Name = "btn_clavier_K_frFR";
            this.btn_clavier_K_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_K_frFR.TabIndex = 17;
            this.btn_clavier_K_frFR.Text = "K";
            this.btn_clavier_K_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_K_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_X_frFR
            // 
            this.btn_clavier_X_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_X_frFR.Location = new System.Drawing.Point(164, 133);
            this.btn_clavier_X_frFR.Name = "btn_clavier_X_frFR";
            this.btn_clavier_X_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_X_frFR.TabIndex = 17;
            this.btn_clavier_X_frFR.Text = "X";
            this.btn_clavier_X_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_X_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_J_frFR
            // 
            this.btn_clavier_J_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_J_frFR.Location = new System.Drawing.Point(302, 87);
            this.btn_clavier_J_frFR.Name = "btn_clavier_J_frFR";
            this.btn_clavier_J_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_J_frFR.TabIndex = 16;
            this.btn_clavier_J_frFR.Text = "J";
            this.btn_clavier_J_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_J_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_W_frFR
            // 
            this.btn_clavier_W_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_W_frFR.Location = new System.Drawing.Point(118, 133);
            this.btn_clavier_W_frFR.Name = "btn_clavier_W_frFR";
            this.btn_clavier_W_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_W_frFR.TabIndex = 16;
            this.btn_clavier_W_frFR.Text = "W";
            this.btn_clavier_W_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_W_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_H_frFR
            // 
            this.btn_clavier_H_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_H_frFR.Location = new System.Drawing.Point(256, 87);
            this.btn_clavier_H_frFR.Name = "btn_clavier_H_frFR";
            this.btn_clavier_H_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_H_frFR.TabIndex = 15;
            this.btn_clavier_H_frFR.Text = "H";
            this.btn_clavier_H_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_H_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_G_frFR
            // 
            this.btn_clavier_G_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_G_frFR.Location = new System.Drawing.Point(210, 87);
            this.btn_clavier_G_frFR.Name = "btn_clavier_G_frFR";
            this.btn_clavier_G_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_G_frFR.TabIndex = 14;
            this.btn_clavier_G_frFR.Text = "G";
            this.btn_clavier_G_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_G_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_F_frFR
            // 
            this.btn_clavier_F_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_F_frFR.Location = new System.Drawing.Point(164, 87);
            this.btn_clavier_F_frFR.Name = "btn_clavier_F_frFR";
            this.btn_clavier_F_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_F_frFR.TabIndex = 13;
            this.btn_clavier_F_frFR.Text = "F";
            this.btn_clavier_F_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_F_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_D_frFR
            // 
            this.btn_clavier_D_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_D_frFR.Location = new System.Drawing.Point(118, 87);
            this.btn_clavier_D_frFR.Name = "btn_clavier_D_frFR";
            this.btn_clavier_D_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_D_frFR.TabIndex = 12;
            this.btn_clavier_D_frFR.Text = "D";
            this.btn_clavier_D_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_D_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_S_frFR
            // 
            this.btn_clavier_S_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_S_frFR.Location = new System.Drawing.Point(72, 87);
            this.btn_clavier_S_frFR.Name = "btn_clavier_S_frFR";
            this.btn_clavier_S_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_S_frFR.TabIndex = 11;
            this.btn_clavier_S_frFR.Text = "S";
            this.btn_clavier_S_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_S_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_Q_frFR
            // 
            this.btn_clavier_Q_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_Q_frFR.Location = new System.Drawing.Point(26, 87);
            this.btn_clavier_Q_frFR.Name = "btn_clavier_Q_frFR";
            this.btn_clavier_Q_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_Q_frFR.TabIndex = 10;
            this.btn_clavier_Q_frFR.Text = "Q";
            this.btn_clavier_Q_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_Q_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_P_frFR
            // 
            this.btn_clavier_P_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_P_frFR.Location = new System.Drawing.Point(440, 41);
            this.btn_clavier_P_frFR.Name = "btn_clavier_P_frFR";
            this.btn_clavier_P_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_P_frFR.TabIndex = 9;
            this.btn_clavier_P_frFR.Text = "P";
            this.btn_clavier_P_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_P_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_O_frFR
            // 
            this.btn_clavier_O_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_O_frFR.Location = new System.Drawing.Point(394, 41);
            this.btn_clavier_O_frFR.Name = "btn_clavier_O_frFR";
            this.btn_clavier_O_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_O_frFR.TabIndex = 8;
            this.btn_clavier_O_frFR.Text = "O";
            this.btn_clavier_O_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_O_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_I_frFR
            // 
            this.btn_clavier_I_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_I_frFR.Location = new System.Drawing.Point(348, 41);
            this.btn_clavier_I_frFR.Name = "btn_clavier_I_frFR";
            this.btn_clavier_I_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_I_frFR.TabIndex = 7;
            this.btn_clavier_I_frFR.Text = "I";
            this.btn_clavier_I_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_I_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_U_frFR
            // 
            this.btn_clavier_U_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_U_frFR.Location = new System.Drawing.Point(302, 41);
            this.btn_clavier_U_frFR.Name = "btn_clavier_U_frFR";
            this.btn_clavier_U_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_U_frFR.TabIndex = 6;
            this.btn_clavier_U_frFR.Text = "U";
            this.btn_clavier_U_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_U_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_Y_frFR
            // 
            this.btn_clavier_Y_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_Y_frFR.Location = new System.Drawing.Point(256, 41);
            this.btn_clavier_Y_frFR.Name = "btn_clavier_Y_frFR";
            this.btn_clavier_Y_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_Y_frFR.TabIndex = 5;
            this.btn_clavier_Y_frFR.Text = "Y";
            this.btn_clavier_Y_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_Y_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_T_frFR
            // 
            this.btn_clavier_T_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_T_frFR.Location = new System.Drawing.Point(210, 41);
            this.btn_clavier_T_frFR.Name = "btn_clavier_T_frFR";
            this.btn_clavier_T_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_T_frFR.TabIndex = 4;
            this.btn_clavier_T_frFR.Text = "T";
            this.btn_clavier_T_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_T_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_r_frFR
            // 
            this.btn_clavier_r_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_r_frFR.Location = new System.Drawing.Point(164, 41);
            this.btn_clavier_r_frFR.Name = "btn_clavier_r_frFR";
            this.btn_clavier_r_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_r_frFR.TabIndex = 3;
            this.btn_clavier_r_frFR.Text = "R";
            this.btn_clavier_r_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_r_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_e_frFR
            // 
            this.btn_clavier_e_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_e_frFR.Location = new System.Drawing.Point(118, 41);
            this.btn_clavier_e_frFR.Name = "btn_clavier_e_frFR";
            this.btn_clavier_e_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_e_frFR.TabIndex = 2;
            this.btn_clavier_e_frFR.Text = "E";
            this.btn_clavier_e_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_e_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_z_frFR
            // 
            this.btn_clavier_z_frFR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_z_frFR.Location = new System.Drawing.Point(72, 41);
            this.btn_clavier_z_frFR.Name = "btn_clavier_z_frFR";
            this.btn_clavier_z_frFR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_z_frFR.TabIndex = 1;
            this.btn_clavier_z_frFR.Text = "Z";
            this.btn_clavier_z_frFR.UseVisualStyleBackColor = false;
            this.btn_clavier_z_frFR.Click += new System.EventHandler(this.button20_Click);
            // 
            // btn_clavier_A_fr_FR
            // 
            this.btn_clavier_A_fr_FR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_clavier_A_fr_FR.Location = new System.Drawing.Point(26, 41);
            this.btn_clavier_A_fr_FR.Name = "btn_clavier_A_fr_FR";
            this.btn_clavier_A_fr_FR.Size = new System.Drawing.Size(40, 40);
            this.btn_clavier_A_fr_FR.TabIndex = 0;
            this.btn_clavier_A_fr_FR.Text = "A";
            this.btn_clavier_A_fr_FR.UseVisualStyleBackColor = false;
            this.btn_clavier_A_fr_FR.Click += new System.EventHandler(this.button20_Click);
            // 
            // lb_consignesErreurs
            // 
            this.lb_consignesErreurs.AutoSize = true;
            this.lb_consignesErreurs.Location = new System.Drawing.Point(35, 123);
            this.lb_consignesErreurs.Name = "lb_consignesErreurs";
            this.lb_consignesErreurs.Size = new System.Drawing.Size(67, 13);
            this.lb_consignesErreurs.TabIndex = 4;
            this.lb_consignesErreurs.Text = "Il vous reste ";
            // 
            // txtB_nbEssaisRestants
            // 
            this.txtB_nbEssaisRestants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_nbEssaisRestants.Enabled = false;
            this.txtB_nbEssaisRestants.Location = new System.Drawing.Point(99, 123);
            this.txtB_nbEssaisRestants.Name = "txtB_nbEssaisRestants";
            this.txtB_nbEssaisRestants.ReadOnly = true;
            this.txtB_nbEssaisRestants.Size = new System.Drawing.Size(25, 13);
            this.txtB_nbEssaisRestants.TabIndex = 5;
            this.txtB_nbEssaisRestants.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb_essais
            // 
            this.lb_essais.AutoSize = true;
            this.lb_essais.Location = new System.Drawing.Point(127, 123);
            this.lb_essais.Name = "lb_essais";
            this.lb_essais.Size = new System.Drawing.Size(45, 13);
            this.lb_essais.TabIndex = 6;
            this.lb_essais.Text = "essai(s).";
            // 
            // lb_tpsEcoule
            // 
            this.lb_tpsEcoule.AutoSize = true;
            this.lb_tpsEcoule.Location = new System.Drawing.Point(377, 123);
            this.lb_tpsEcoule.Name = "lb_tpsEcoule";
            this.lb_tpsEcoule.Size = new System.Drawing.Size(80, 13);
            this.lb_tpsEcoule.TabIndex = 7;
            this.lb_tpsEcoule.Text = "Temps écoulé :";
            // 
            // txtB_temps
            // 
            this.txtB_temps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB_temps.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtB_temps.Enabled = false;
            this.txtB_temps.Location = new System.Drawing.Point(463, 123);
            this.txtB_temps.Name = "txtB_temps";
            this.txtB_temps.ReadOnly = true;
            this.txtB_temps.Size = new System.Drawing.Size(101, 13);
            this.txtB_temps.TabIndex = 8;
            // 
            // ep_jeu
            // 
            this.ep_jeu.ContainerControl = this;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(152, 381);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(270, 23);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Commencer";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manche numéro :";
            // 
            // txtb_numManche
            // 
            this.txtb_numManche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_numManche.Location = new System.Drawing.Point(127, 27);
            this.txtb_numManche.Name = "txtb_numManche";
            this.txtb_numManche.ReadOnly = true;
            this.txtb_numManche.Size = new System.Drawing.Size(68, 13);
            this.txtb_numManche.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // FrmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_numManche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.txtB_temps);
            this.Controls.Add(this.lb_tpsEcoule);
            this.Controls.Add(this.lb_essais);
            this.Controls.Add(this.txtB_nbEssaisRestants);
            this.Controls.Add(this.lb_consignesErreurs);
            this.Controls.Add(this.pn_clavier);
            this.Controls.Add(this.lb_motADeviner);
            this.Controls.Add(this.txtb_MotenCours);
            this.Name = "FrmJeu";
            this.Text = "Jeu du Pendu";
            this.Shown += new System.EventHandler(this.FrmJeu_Load);
            this.pn_clavier.ResumeLayout(false);
            this.pn_clavier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_jeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_MotenCours;
		private System.Windows.Forms.Label lb_motADeviner;
		private System.Windows.Forms.Panel pn_clavier;
		private System.Windows.Forms.Button btn_clavier_A_fr_FR;
		private System.Windows.Forms.Button btn_clavier_N_frFR;
		private System.Windows.Forms.Button btn_clavier_M_frFR;
		private System.Windows.Forms.Button btn_clavier_B_frFR;
		private System.Windows.Forms.Button btn_clavier_L_frFR;
		private System.Windows.Forms.Button btn_clavier_V_frFR;
		private System.Windows.Forms.Button btn_clavier_C_frFR;
		private System.Windows.Forms.Button btn_clavier_K_frFR;
		private System.Windows.Forms.Button btn_clavier_X_frFR;
		private System.Windows.Forms.Button btn_clavier_J_frFR;
		private System.Windows.Forms.Button btn_clavier_W_frFR;
		private System.Windows.Forms.Button btn_clavier_H_frFR;
		private System.Windows.Forms.Button btn_clavier_G_frFR;
		private System.Windows.Forms.Button btn_clavier_F_frFR;
		private System.Windows.Forms.Button btn_clavier_D_frFR;
		private System.Windows.Forms.Button btn_clavier_S_frFR;
		private System.Windows.Forms.Button btn_clavier_Q_frFR;
		private System.Windows.Forms.Button btn_clavier_P_frFR;
		private System.Windows.Forms.Button btn_clavier_O_frFR;
		private System.Windows.Forms.Button btn_clavier_I_frFR;
		private System.Windows.Forms.Button btn_clavier_U_frFR;
		private System.Windows.Forms.Button btn_clavier_Y_frFR;
		private System.Windows.Forms.Button btn_clavier_T_frFR;
		private System.Windows.Forms.Button btn_clavier_r_frFR;
		private System.Windows.Forms.Button btn_clavier_e_frFR;
		private System.Windows.Forms.Button btn_clavier_z_frFR;
		private System.Windows.Forms.Label lb_consignesClavier;
        private System.Windows.Forms.Label lb_consignesErreurs;
        private System.Windows.Forms.TextBox txtB_nbEssaisRestants;
        private System.Windows.Forms.Label lb_essais;
        private System.Windows.Forms.Label lb_tpsEcoule;
        private System.Windows.Forms.TextBox txtB_temps;
        private System.Windows.Forms.ErrorProvider ep_jeu;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtb_numManche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

