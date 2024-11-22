namespace projet4formAjoutBase
{
    partial class login
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
            this.btn_connecter = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connecter
            // 
            this.btn_connecter.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_connecter.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_connecter.Location = new System.Drawing.Point(259, 282);
            this.btn_connecter.Name = "btn_connecter";
            this.btn_connecter.Size = new System.Drawing.Size(86, 34);
            this.btn_connecter.TabIndex = 11;
            this.btn_connecter.Text = "connecter";
            this.btn_connecter.UseVisualStyleBackColor = false;
            this.btn_connecter.Click += new System.EventHandler(this.btn_connecter_Click_1);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_quitter.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_quitter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_quitter.Location = new System.Drawing.Point(163, 282);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 34);
            this.btn_quitter.TabIndex = 10;
            this.btn_quitter.Text = "quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(197, 225);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(148, 20);
            this.txt_pwd.TabIndex = 9;
            this.txt_pwd.Text = "admin";
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(197, 182);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(148, 22);
            this.txt_login.TabIndex = 8;
            this.txt_login.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(69, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_connecter);
            this.panel1.Controls.Add(this.btn_quitter);
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(223, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 359);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::gestionBibliotheque.Properties.Resources._81a870ac42f2ad1095b522c9805f7103;
            this.pictureBox1.Location = new System.Drawing.Point(73, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connecter;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}