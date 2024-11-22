using gestionBibliotheque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet4formAjoutBase
{
    public partial class login : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = Livre.mdb";

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_connecter_Click_1(object sender, EventArgs e)
        {
            string txtsql = "select count (login) from connexion where login='" + txt_login.Text + "' and pwd='" + txt_pwd.Text + "'";
            OleDbConnection con = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, con);
            Int32 ival;
            try
            {
                ocm.Connection.Open();
                ival = Convert.ToInt32(ocm.ExecuteScalar());
                if (ival == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("verifier l'identifient ", "erreur login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_login.Text = "";
                    txt_pwd.Text = "";
                    txt_login.Focus();
                    ocm.Connection.Close();
                }
                else
                {
                    ocm.Connection.Close();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("eception générée:" + ex.Message);
            }
        }
    }
}
