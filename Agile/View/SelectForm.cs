using Agile.View;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void btnQLTV_Click(object sender, EventArgs e)
        {
            QLTV qltv = new QLTV();
            qltv.Show();
            this.Hide();

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            XemLH xem = new XemLH();
            xem.Show();
            this.Hide();
        }

        private void btnQLLH_Click(object sender, EventArgs e)
        {
            QLLH qllh = new QLLH();
            qllh.Show();
            this.Hide();
        }

        private void btnQLLop_Click(object sender, EventArgs e)
        {
            QLLop qllop     = new QLLop();
            qllop.Show();
            this.Hide();
        }
    }
}
