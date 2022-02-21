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
using System.Security.Cryptography;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;

namespace examen
{
    public partial class login : Form
    {

        public string role;
        public login()
        {
            InitializeComponent();
        }
        private byte[] cle = System.Convert.FromBase64String("6qrWTvD0mpOQrwCrnAROkqSZCJZXidW3");
        private byte[] iv = System.Convert.FromBase64String("FYhEQ5333RM=");
        static public string hash(string chaine)
        {
            byte[] textAsByte = Encoding.Default.GetBytes(chaine);

            SHA512 sha512 = SHA512Cng.Create();

            byte[] hash = sha512.ComputeHash(textAsByte);

            return Convert.ToBase64String(hash);

        }
        public string DecryptSym(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Cet objet est utilisé pour déchiffrer les données.
            // Il reçoit les données chiffrées sous la forme d'un tableau de bytes.
            // Les données déchiffrées sont également retournées sous la forme d'un tableau de bytes
            var decryptor = TDES.CreateDecryptor(key, iv);

            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }


        

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(db.ouvrirconection());
           
            cn.Open();
            string req = "select * from utilisateur where login ='" + txtLogin.Text + "' ";
            SqlCommand com = new SqlCommand(req, cn);
            SqlDataReader dr = com.ExecuteReader();
            bool passport = false;
            if (dr.Read())
                if (dr["Passworde"].ToString() == hash(txtPwd.Text))
                {
                    passport = true;
                }
            if (passport)
            {
               
                if (Convert.ToDateTime(dr["dateExipration"]) > DateTime.Now)
                {


                    role = dr["rolee"].ToString();
                   
                    menu m= new menu(role);
                    //MessageBox.Show(role);
                    this.Hide();
                
                    m.ShowDialog();
                    this.Show();
                    

                   
                   
             
                }
                else
                {
                    MessageBox.Show("date ete exipere ");

                }
            }
            else
            {
                MessageBox.Show("login ou mot de passe incorrect");

                
            }
        
          
            dr.Close();
            dr = null;
            com = null;
            cn.Close();
            cn = null;
         

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Bsala()
        {
           
                    return string.Format(role);
                

                
            }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
    
}
