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
            this.button20 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
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
            this.lb_consignesClavier = new System.Windows.Forms.Label();
            this.lb_consignesErreurs = new System.Windows.Forms.Label();
            this.txtB_nbEssaisRestants = new System.Windows.Forms.TextBox();
            this.lb_essais = new System.Windows.Forms.Label();
            this.lb_tpsEcoule = new System.Windows.Forms.Label();
            this.txtB_temps = new System.Windows.Forms.TextBox();
            this.ep_jeu = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.pn_clavier.Controls.Add(this.button20);
            this.pn_clavier.Controls.Add(this.button10);
            this.pn_clavier.Controls.Add(this.button21);
            this.pn_clavier.Controls.Add(this.button11);
            this.pn_clavier.Controls.Add(this.button22);
            this.pn_clavier.Controls.Add(this.button23);
            this.pn_clavier.Controls.Add(this.lb_consignesClavier);
            this.pn_clavier.Controls.Add(this.button12);
            this.pn_clavier.Controls.Add(this.button24);
            this.pn_clavier.Controls.Add(this.button13);
            this.pn_clavier.Controls.Add(this.button25);
            this.pn_clavier.Controls.Add(this.button14);
            this.pn_clavier.Controls.Add(this.button15);
            this.pn_clavier.Controls.Add(this.button16);
            this.pn_clavier.Controls.Add(this.button17);
            this.pn_clavier.Controls.Add(this.button18);
            this.pn_clavier.Controls.Add(this.button19);
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
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.Location = new System.Drawing.Point(289, 136);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 40);
            this.button20.TabIndex = 21;
            this.button20.Text = "N";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(455, 90);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 40);
            this.button10.TabIndex = 19;
            this.button10.Text = "M";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button21.Location = new System.Drawing.Point(243, 136);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 40);
            this.button21.TabIndex = 20;
            this.button21.Text = "B";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button20_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(409, 90);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 40);
            this.button11.TabIndex = 18;
            this.button11.Text = "L";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button20_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button22.Location = new System.Drawing.Point(197, 136);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 40);
            this.button22.TabIndex = 19;
            this.button22.Text = "V";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button20_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button23.Location = new System.Drawing.Point(151, 136);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 40);
            this.button23.TabIndex = 18;
            this.button23.Text = "C";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button20_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(363, 90);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 17;
            this.button12.Text = "K";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button20_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button24.Location = new System.Drawing.Point(105, 136);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(40, 40);
            this.button24.TabIndex = 17;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button20_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(317, 90);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 16;
            this.button13.Text = "J";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button20_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button25.Location = new System.Drawing.Point(59, 136);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(40, 40);
            this.button25.TabIndex = 16;
            this.button25.Text = "W";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button20_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(271, 90);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 40);
            this.button14.TabIndex = 15;
            this.button14.Text = "I";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button20_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(225, 90);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 40);
            this.button15.TabIndex = 14;
            this.button15.Text = "G";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button16.Location = new System.Drawing.Point(179, 90);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 40);
            this.button16.TabIndex = 13;
            this.button16.Text = "F";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button20_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Location = new System.Drawing.Point(133, 90);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(40, 40);
            this.button17.TabIndex = 12;
            this.button17.Text = "D";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button20_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button18.Location = new System.Drawing.Point(87, 90);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 40);
            this.button18.TabIndex = 11;
            this.button18.Text = "S";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button19.Location = new System.Drawing.Point(41, 90);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(40, 40);
            this.button19.TabIndex = 10;
            this.button19.Text = "Q";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button20_Click);
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
            // lb_consignesClavier
            // 
            this.lb_consignesClavier.AutoSize = true;
            this.lb_consignesClavier.Location = new System.Drawing.Point(23, 11);
            this.lb_consignesClavier.Name = "lb_consignesClavier";
            this.lb_consignesClavier.Size = new System.Drawing.Size(339, 13);
            this.lb_consignesClavier.TabIndex = 3;
            this.lb_consignesClavier.Text = "Cliquez sur une touche pour tester si la lettre est présente dans le mot :";
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
            this.lb_tpsEcoule.Location = new System.Drawing.Point(309, 123);
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
            this.txtB_temps.Location = new System.Drawing.Point(403, 120);
            this.txtB_temps.Name = "txtB_temps";
            this.txtB_temps.ReadOnly = true;
            this.txtB_temps.Size = new System.Drawing.Size(161, 13);
            this.txtB_temps.TabIndex = 8;
            // 
            // ep_jeu
            // 
            this.ep_jeu.ContainerControl = this;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(34, 388);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(239, 23);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Commencer";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manche numéro :";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(139, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(68, 13);
            this.textBox1.TabIndex = 11;
            // 
            // FrmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 508);
            this.Controls.Add(this.textBox1);
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
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

