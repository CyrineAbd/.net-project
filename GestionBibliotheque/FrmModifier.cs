using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionBibliotheque
{
    public partial class FrmModifier : Form
    {
        public FrmModifier()
        {
            InitializeComponent();
        }

        private void FrmModifier_Load(object sender, EventArgs e)
        {

        }
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = Livre.mdb";
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
                MessageBox.Show("***Modification terminer avec succéé***");
            }
            catch (Exception ex)

            {
                MessageBox.Show("Exception  Généréé:" + ex.Message);
            }
        }

       

        private void btn_valider_Click_1(object sender, EventArgs e)
        {
            string txtsql = "update Livre set ISBN= '" + txt_ISBN.Text +
                            "',titre='" + txt_titre.Text +
                            "',auteur='" + txt_auteur.Text +
                            "',AnneeSortie='" + txt_annee_sortie.Text +
                            "',TypeLivre='" + txt_type.Text +
                            "',Editeur='" + txt_editeur.Text +
                            "' where ISBN= " + txt_ISBN.Text + "";
            lancerRequete(txtsql);
            Hide();
        }

        private void btn_anuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
