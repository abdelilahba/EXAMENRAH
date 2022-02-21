using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
using System.IO;


namespace examen
{
   static class db
    {
        private static byte[] cle = System.Convert.FromBase64String("12UCgcnHy8LHoN/VodosrUVgv+r+kQ5e");
        private static byte[] iv = System.Convert.FromBase64String("AsJNO9N/4dM=");
        public static string cs = ConfigurationManager.ConnectionStrings["examen.Properties.Settings.serieconnecterConnectionString"].ConnectionString;
        public static string[] t;
        public static string pass;
        public static string pasword;
        public static string password;
        public static string ouvrirconection()
        {
            t = cs.Split(';');
           pass = t[3];
            pasword = pass.Substring(9);
            password = "Password=" + DecryptSym(System.Convert.FromBase64String(pasword), cle, iv);
            return string.Format(t[0] + ";" + t[1] + ";" + t[2] + ";" + password);

        }
        static public string DecryptSym(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
            var decryptor = TDES.CreateDecryptor(key, iv);
            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }
    }
}

