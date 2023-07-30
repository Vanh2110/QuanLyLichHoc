using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectForm s = new SelectForm();
            if (txtTK.Text == "admin" && txtMK.Text == "admin")
            {
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("!!!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
