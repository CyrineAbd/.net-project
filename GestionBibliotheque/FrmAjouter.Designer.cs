namespace gestionBibliotheque
{
    partial class FrmAjouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjouter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_valider = new System.Windows.Forms.Button();
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
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Annuler);
            this.panel1.Controls.Add(this.btn_valider);
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
            this.panel1.Location = new System.Drawing.Point(87, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 357);
            this.panel1.TabIndex = 0;
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_valider.Image = ((System.Drawing.Image)(resources.GetObject("btn_valider.Image")));
            this.btn_valider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_valider.Location = new System.Drawing.Point(485, 39);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(82, 40);
            this.btn_valider.TabIndex = 15;
            this.btn_valider.Text = "Valider";
            this.btn_valider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click_1);
            // 
            // txt_type
            // 
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comédie",
            "Horreur"});
            this.txt_type.Location = new System.Drawing.Point(227, 235);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(177, 21);
            this.txt_type.TabIndex = 12;
            this.txt_type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Editeur :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type de livre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Année de sortie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Auteur :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "ISBN :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_titre
            // 
            this.txt_titre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_titre.Location = new System.Drawing.Point(227, 92);
            this.txt_titre.Name = "txt_titre";
            this.txt_titre.Size = new System.Drawing.Size(177, 20);
            this.txt_titre.TabIndex = 5;
            // 
            // txt_auteur
            // 
            this.txt_auteur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_auteur.Location = new System.Drawing.Point(227, 144);
            this.txt_auteur.Name = "txt_auteur";
            this.txt_auteur.Size = new System.Drawing.Size(177, 20);
            this.txt_auteur.TabIndex = 4;
            // 
            // txt_annee_sortie
            // 
            this.txt_annee_sortie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_annee_sortie.Location = new System.Drawing.Point(227, 184);
            this.txt_annee_sortie.Name = "txt_annee_sortie";
            this.txt_annee_sortie.Size = new System.Drawing.Size(177, 20);
            this.txt_annee_sortie.TabIndex = 3;
            // 
            // txt_editeur
            // 
            this.txt_editeur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_editeur.Location = new System.Drawing.Point(227, 290);
            this.txt_editeur.Name = "txt_editeur";
            this.txt_editeur.Size = new System.Drawing.Size(177, 20);
            this.txt_editeur.TabIndex = 1;
            this.txt_editeur.TextChanged += new System.EventHandler(this.txt_editeur_TextChanged);
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ISBN.Location = new System.Drawing.Point(227, 40);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(177, 20);
            this.txt_ISBN.TabIndex = 0;
            this.txt_ISBN.TextChanged += new System.EventHandler(this.txt_ISBN_TextChanged);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Annuler.Image = ((System.Drawing.Image)(resources.GetObject("btn_Annuler.Image")));
            this.btn_Annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Annuler.Location = new System.Drawing.Point(485, 107);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(82, 35);
            this.btn_Annuler.TabIndex = 16;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Annuler.UseVisualStyleBackColor = false;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // FrmAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 419);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAjouter";
            this.Text = "FrmAjouter";
            this.Load += new System.EventHandler(this.FrmAjouter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titre;
        private System.Windows.Forms.TextBox txt_auteur;
        private System.Windows.Forms.TextBox txt_annee_sortie;
        private System.Windows.Forms.TextBox txt_editeur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_type;
        internal System.Windows.Forms.Button btn_valider;
        internal System.Windows.Forms.Button btn_Annuler;
    }
}