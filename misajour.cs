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
    public partial class misajour : Form
    {
        private string role;

        public misajour()
        {
            InitializeComponent();
        }
        public misajour(string Role)
        {
            this.role = Role;
            InitializeComponent();
        }
        SqlConnection cs = new SqlConnection(db.ouvrirconection());
        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void visible(bool v)
        {
            btnedit.Visible = !v;
            btnsupprime.Visible = !v;
            btnadd.Visible = !v;
            btnsave.Visible = !v;
            btnclose.Visible = !v;

        }

        private void misajour_Load(object sender, EventArgs e)
        {
            lblnom.Text = role;
            //MessageBox.Show(role);
            // role et login pour un admistrateur
            if (role == "admisteur")
            {
                
                visible(false);
               
            }
            else if (role == "visiteur")
            {
                visible(true);
                
            }

            //combobox service

            SqlCommand com = new SqlCommand("select * from service", cs);
            cs.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbservice.Items.Add(dr[1]);
                

            }
            
            com = null;
            cs.Close();
            dr.Close();
            dr = null;
           
            // list des emplyes 
            SqlCommand c = new SqlCommand("select * from Employe", cs);
            cs.Open();
            SqlDataReader dr1 = c.ExecuteReader();
            while (dr1.Read())
            {
                lstemploye.Items.Add(dr1[1]);
              

            }

            c = null;
            cs.Close();
            dr1.Close();
            dr1 = null;
            //list des numerodesrv
            SqlCommand c1 = new SqlCommand("select * from service", cs);
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
            //la liste de matricule 
            SqlCommand c2 = new SqlCommand("select * from Employe", cs);
            cs.Open();
            SqlDataReader dr3 = c2.ExecuteReader();
            while (dr3.Read())
            {
                lstmatricule.Items.Add(dr3[0]);


             
            }
            c2 = null;
            cs.Close();
            dr3.Close();
            dr3 = null;




        }

        private void cbservice_SelectedIndexChanged(object sender, EventArgs e)
        {
         

             cbtest.SelectedIndex= cbservice.SelectedIndex;

            SqlCommand c1 = new SqlCommand("select * from Employe where Num_serv = " + cbtest.Text, cs);
            cs.Open();
            lstemploye.Items.Clear();
            SqlDataReader dr1 = c1.ExecuteReader();
            while (dr1.Read())
            {
                lstemploye.Items.Add(dr1[1]);


            }
            c1 = null;
            cs.Close();
            dr1.Close();
            dr1 = null;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                lstemploye.SelectedIndex = lstemploye.SelectedIndex + 1;

            }catch(Exception ex)
            {

            }
            
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            try
            {
                lstemploye.SelectedIndex = lstemploye.SelectedIndex - 1;

            }
            catch (Exception ex)
            {

            }
           
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            try
            {

           
            if (lstemploye.SelectedIndex==0)
            {
                lstemploye.SelectedIndex = lstemploye.Items.Count - 1;

            }
            else
            {
                lstemploye.SelectedIndex = lstemploye.SelectedIndex + 1;
                
            }
            }catch (Exception ex)
            {
                
            }
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            if (lstemploye.SelectedIndex == lstemploye.Items.Count-1)
            {
                lstemploye.SelectedIndex = 0;

            }
            else
            {
                lstemploye.SelectedIndex = lstemploye.Items.Count - 1;
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {

            
            SqlCommand c = new SqlCommand("select * from Employe where Num_serv = "+ cbtest.Text+"and nom like '%" + txtfind.Text+"%'", cs);
            cs.Open();
            lstemploye.Items.Clear();
            SqlDataReader dr1 = c.ExecuteReader();
            
            while (dr1.Read())
            {
                lstemploye.Items.Add(dr1[1]);


            }

            c = null;
            cs.Close();
            dr1.Close();
            dr1 = null;
        }

        private void lstemploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstmatricule.SelectedIndex = lstemploye.SelectedIndex;
            SqlCommand c = new SqlCommand("select * from Employe where matricule="+lstmatricule.Text, cs);
            cs.Open();
            SqlDataReader dr1 = c.ExecuteReader();
            while (dr1.Read())
            {
                txtmatricule.Text = dr1[0].ToString();
                txtnom.Text = dr1[1].ToString();
                txtprenom.Text = dr1[2].ToString();
                txtadresse.Text = dr1[4].ToString();
                txtdatenaissance.Text = dr1[5].ToString();
               txtgrade.Text = dr1[6].ToString();
                txtnumser.Text = dr1[7].ToString();



            }
            c = null;
            cs.Close();
            dr1.Close();
            dr1 = null;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

           
            SqlCommand c = new SqlCommand("select * from Employe", cs);
            SqlCommand com = new SqlCommand("insert into Employe values (" + " '" + txtnom.Text + "'" + ", ' " + txtprenom.Text + "'" + ","+"'" + txtadresse.Text +"'"+ ", '" +txtdatenaissance.Text+"'"+","+txtsalaire.Text+", '"+txtgrade.Text+"' ,"+txtnumser.Text+ ")", cs);
            cs.Open();
            com.ExecuteNonQuery();
            com = null;
            cs.Close();
            MessageBox.Show("insertion avec succes");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtmatricule.Text ="";
            txtnom.Text = "";
            txtprenom.Text ="";
            txtadresse.Text ="";
            txtdatenaissance.Text ="";
            txtgrade.Text ="";
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
        
           
            SqlCommand com = new SqlCommand("update Employe  set nom = ' " + txtnom.Text + "'" + "where matricule =" + lstmatricule.Text, cs);
            cs.Open();
            com.ExecuteNonQuery();
            lstemploye.Items.Clear();
            com = null;
            cs.Close();
            SqlCommand c = new SqlCommand("select * from Employe", cs);
            cs.Open();
            SqlDataReader dr1 = c.ExecuteReader();
            while (dr1.Read())
            {
                lstemploye.Items.Add(dr1[1]);


            }

            c = null;
            cs.Close();
            dr1.Close();
            dr1 = null;

            MessageBox.Show("modification avec succes");
        }

        private void btnsupprime_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
              
                SqlCommand com2 = new SqlCommand("delete from travaille where matricule =" + lstmatricule.Text, cs);
                SqlCommand com3 = new SqlCommand("delete from Employe where matricule =" + lstmatricule.Text, cs);
                cs.Open();
               
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();            
                com2 = null;
                com3 = null;
                cs.Close();
                lstemploye.Items.Clear();
                SqlCommand c = new SqlCommand("select * from Employe", cs);
                cs.Open();
                SqlDataReader dr1 = c.ExecuteReader();
                while (dr1.Read())
                {
                    lstemploye.Items.Add(dr1[1]);


                }

                c = null;
                cs.Close();
                dr1.Close();
                dr1 = null;



            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
