using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.CodeDom.Compiler;
using System.IO;


namespace examen
{
    public partial class recherche : Form
    {
        public recherche()
        {
            InitializeComponent();
        }
        SqlConnection cs = new SqlConnection(db.ouvrirconection());

        private void recherche_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from projet", cs);
            cs.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbtache.Items.Add(dr[1]);


            }

            com = null;
            cs.Close();
            dr.Close();
            dr = null;
            // listes des numtaches 
            SqlCommand c1 = new SqlCommand("select * from projet" +
                "" +
                "", cs);
            cs.Open();
            SqlDataReader dr2 = c1.ExecuteReader();
            while (dr2.Read())
            {
                cbtest.Items.Add(dr2[0]);


            }

            c1 = null;
            cs.Close();
            dr2.Close();
            dr2 = null;
        }

        private void lstprojet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtache_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtest.SelectedIndex = cbtache.SelectedIndex;

            SqlCommand c1 = new SqlCommand("select * from tache where Num_prj = " + cbtest.Text, cs);
            cs.Open();
            lstprojet.Items.Clear();
            SqlDataReader dr1 = c1.ExecuteReader();
            while (dr1.Read())
            {
                lstprojet.Items.Add(dr1[1]);


            }
            c1 = null;
            cs.Close();
            dr1.Close();
            dr1 = null;

            //
            SqlCommand c2 = new SqlCommand("select e.Nom,Nombre_heure from Projet p  inner join Tache t on p.Num_prj=t.Num_prj inner  join Travaille ta on t.Num_tach = ta.Num_tache inner join Employe e on ta.Matricule = e.Matricule  where t.Num_prj=" + cbtest.Text, cs);
            cs.Open();
            dgvemploye.Rows.Clear();
         
            SqlDataReader dr2 = c2.ExecuteReader();
            while (dr2.Read())
            {

                dgvemploye.Rows.Add(dr2[0],dr2[1]);
              

            }
            c2 = null;
            cs.Close();
            dr2.Close();
            dr2 = null;
            // la sum des heures d'un projet selectioneer
            SqlCommand c3 = new SqlCommand("select    sum(Nombre_heure) from Projet p  inner join Tache t on p.Num_prj=t.Num_prj  inner  join Travaille ta on t.Num_tach = ta.Num_tache inner join Employe e on ta.Matricule = e.Matricule where t.Num_prj=" + cbtest.Text, cs);
            cs.Open();


            int a =Convert.ToInt32( c3.ExecuteScalar());
            lblsum.Text = a.ToString();
            c2 = null;
            cs.Close();
           
           

        }

        private void lstemploye_SelectedIndexChanged(object sender, EventArgs e)


        {

            cbtest.SelectedIndex = cbtache.SelectedIndex;

         




        }

        private void dgvemploye_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
