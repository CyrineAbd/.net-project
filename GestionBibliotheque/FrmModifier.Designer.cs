namespace gestionBibliotheque
{
    partial class FrmModifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifier));
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titre = new System.Windows.Forms.TextBox();
            this.txt_auteur = new System.Windows.Forms.TextBox();
            this.txt_annee_sortie = new System.Windows.Forms.TextBox();
            this.txt_editeur = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_anuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_type
            // 
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.txt_type.Location = new System.Drawing.Point(319, 243);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(167, 21);
            this.txt_type.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(149, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Editeur :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Type de livre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Année de sortie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Auteur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Titre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "ISBN :";
            // 
            // txt_titre
            // 
            this.txt_titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_titre.Location = new System.Drawing.Point(319, 100);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(167, 20);
            this.txt_titre.TabIndex = 17;
            // 
            // txt_auteur
            // 
            this.txt_auteur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_auteur.Location = new System.Drawing.Point(319, 150);
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.Size = new System.Drawing.Size(167, 20);
            this.txt_auteur.TabIndex = 16;
            // 
            // txt_annee_sortie
            // 
            this.txt_annee_sortie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_annee_sortie.Location = new System.Drawing.Point(319, 190);
            this.txt_annee_sortie.Name = "txt_annee_sortie";
            this.txt_annee_sortie.Size = new System.Drawing.Size(167, 20);
            this.txt_annee_sortie.TabIndex = 15;
            // 
            // txt_editeur
            // 
            this.txt_editeur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_editeur.Location = new System.Drawing.Point(319, 298);
            this.txt_editeur.Name = "txt_editeur";
            this.txt_editeur.Size = new System.Drawing.Size(167, 20);
            this.txt_editeur.TabIndex = 14;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ISBN.Location = new System.Drawing.Point(319, 46);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(167, 20);
            this.txt_ISBN.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_valider);
            this.panel1.Controls.Add(this.btn_anuler);
            this.panel1.Controls.Add(this.txt_type);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_titre);
            this.panel1.Controls.Add(this.txt_auteur);
            this.panel1.Controls.Add(this.txt_annee_sortie);
            this.panel1.Controls.Add(this.txt_editeur);
            this.panel1.Controls.Add(this.txt_ISBN);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 365);
            this.panel1.TabIndex = 25;
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_valider.Image = ((System.Drawing.Image)(resources.GetObject("btn_valider.Image")));
            this.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_valider.Location = new System.Drawing.Point(538, 46);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(82, 40);
            this.btn_valider.TabIndex = 28;
            this.btn_valider.Text = "Modifier";
            this.btn_valider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click_1);
            // 
            // btn_anuler
            // 
            this.btn_anuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_anuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_anuler.Image = ((System.Drawing.Image)(resources.GetObject("btn_anuler.Image")));
            this.btn_anuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anuler.Location = new System.Drawing.Point(538, 113);
            this.btn_anuler.Name = "btn_anuler";
            this.btn_anuler.Size = new System.Drawing.Size(82, 35);
            this.btn_anuler.TabIndex = 27;
            this.btn_anuler.Text = "Annuler";
            this.btn_anuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anuler.UseVisualStyleBackColor = false;
            this.btn_anuler.Click += new System.EventHandler(this.btn_anuler_Click);
            // 
            // FrmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 439);
            this.Controls.Add(this.panel1);
            this.Name = "FrmModifier";
            this.Text = "FrmModifier";
            this.Load += new System.EventHandler(this.FrmModifier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox txt_type;
        public System.Windows.Forms.TextBox txt_titre;
        public System.Windows.Forms.TextBox txt_auteur;
        public System.Windows.Forms.TextBox txt_annee_sortie;
        public System.Windows.Forms.TextBox txt_ISBN;
        public System.Windows.Forms.TextBox txt_editeur;
        internal System.Windows.Forms.Button btn_valider;
        internal System.Windows.Forms.Button btn_anuler;
    }
}