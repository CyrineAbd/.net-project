using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionBibliotheque
{
    public partial class FrmAjouter : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = Livre.mdb";

        public FrmAjouter()
        {
            InitializeComponent();
        }

        private void FrmAjouter_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void lancerRequete(string requete)
        {
            OleDbConnection ocn = new OleDbConnection();
            OleDbCommand ocm = new OleDbCommand();
            ocn.ConnectionString = sconstr;
            try
            {
                ocn.Open();
                ocm.Connection = ocn;
                ocm.CommandText = requete;
                ocm.ExecuteNonQuery();
                ocn.Close();
                MessageBox.Show("***insertion terminer avec succéé***");
            }
            catch (Exception ex)
            
            {
                MessageBox.Show("Exception  Généréé:" + ex.Message);
            }
        }


        private void txt_editeur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click_1(object sender, EventArgs e)
        {
            string txtinsert;
            txtinsert = "INSERT INTO Livre  VALUES (" +
               "'" + txt_ISBN.Text + "', " +
               "'" + txt_titre.Text + "', " +
               "'" + txt_auteur.Text + "', " +
               "'" + txt_annee_sortie.Text + "', " +
               "'" + txt_type.Text + "', " +
               "'" + txt_editeur.Text + "')";

            lancerRequete(txtinsert);
            Hide();
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
