using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class menu : Form
    {
        public string role;
        public menu(string Role)
        {
            this.role = Role;
            InitializeComponent();
        }
        public menu()
        {
            InitializeComponent();
        }

        private void bntmisajour_Click(object sender, EventArgs e)
        {



            misajour m = new misajour(role);
            m.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(role);
        }

        private void btnrecheche_Click(object sender, EventArgs e)
        {
            recherche r = new recherche();
            r.ShowDialog();
        }
    }
}
