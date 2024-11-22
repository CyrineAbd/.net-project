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
    public partial class Form1 : Form
    {
        public string sconstr = @"provider=Microsoft.jet.oleDB.4.0;Data source = Livre.mdb";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            charger_liste_livres();

        }
        public void charger_liste_livres()
        {
            dataGridView1.Rows.Clear();
            string txtsql;
            txtsql = "select * from livre";
            OleDbConnection ocn = new OleDbConnection(sconstr);
            OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
            ocm.Connection.Open();//la cnnction bin base 
            OleDbDataReader reader = ocm.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                string[] row = new string[] { reader.GetValue(0).ToString() ,
                    reader.GetString(1), 
                    reader.GetString(2),
                    reader.GetValue(3).ToString(),
                    reader.GetString(4),
                    reader.GetString(5)};
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
            ocn.Close(); 
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
                MessageBox.Show("***Suppression terminer avec succéé***");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception  Généréé:" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                string txtsql;
               
                txtsql = "select *  from Livre where  titre like '%" + txt_Recherche.Text + "%' or TypeLivre like '%" + txt_Recherche.Text + "%'";
                OleDbConnection ocn = new OleDbConnection(sconstr);
                OleDbCommand ocm = new OleDbCommand(txtsql, ocn);
                ocm.Connection.Open();
                OleDbDataReader reader = ocm.ExecuteReader(behavior: CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    string[] row = new string[] { reader.GetValue(0).ToString(),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetValue(3).ToString(),
                    reader.GetString(4),
                    reader.GetString(5), };
                    dataGridView1.Rows.Add(row);

                }
                reader.Close();
                ocn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btn_add_Click_1(object sender, EventArgs e)
        {
            FrmAjouter fm = new FrmAjouter();
            fm.ShowDialog();
        }

        private void btn_edit_Click_1(object sender, EventArgs e)
        {
            FrmModifier frm_modif = new FrmModifier();
            int lignecourrant;
            string ISBN, titre, auteur, anneeSortie, TypeLivre, editeur;

            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;

            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            titre = dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString();
            auteur = dataGridView1.Rows[lignecourrant].Cells[2].Value.ToString();
            anneeSortie = dataGridView1.Rows[lignecourrant].Cells[3].Value.ToString();
            TypeLivre = dataGridView1.Rows[lignecourrant].Cells[4].Value.ToString();
            editeur = dataGridView1.Rows[lignecourrant].Cells[5].Value.ToString();

            frm_modif.txt_ISBN.Text = ISBN;
            frm_modif.txt_titre.Text = titre;
            frm_modif.txt_auteur.Text = auteur;
            frm_modif.txt_annee_sortie.Text = anneeSortie;
            frm_modif.txt_type.Text = TypeLivre;
            frm_modif.txt_editeur.Text = editeur;
            frm_modif.txt_ISBN.Enabled = false;
            frm_modif.ShowDialog();
            charger_liste_livres();

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            int lignecourrant;
            string ISBN;
            string req_sup;
            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;

            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            DialogResult Supp_livre =
                (MessageBox.Show("voulez vous supprimer le livre '" +
                dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString() +
                "'", "supression livre", MessageBoxButtons.YesNo));
            if (Supp_livre == DialogResult.Yes)
            {
                req_sup = "delete from livre where ISBN=" + ISBN + "";
                lancerRequete(req_sup);
                charger_liste_livres();
            }
            else
            {
                return;
            }
        }

        private void btn_quitter_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }

        }
    }
}
