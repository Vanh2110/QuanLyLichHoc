using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile.View
{
    public partial class XemLH : Form
    {
        public XemLH()
        {
            InitializeComponent();
            LoadGrid(null);
        }
        public void LoadGrid(string input)
        {
            dtgXemLH.ColumnCount = 4;
            dtgXemLH.Columns[0].Name = "Lớp";
            dtgXemLH.Columns[1].Name = "Ngày";
            dtgXemLH.Columns[2].Name = "Ca học";
            dtgXemLH.Columns[3].Name = "Phòng học";
            dtgXemLH.Rows.Clear();
            dtgXemLH.Rows.Add("SD18301","27/7/2023",1,"D401");
            dtgXemLH.Rows.Add("SD18303","28/7/2023",2,"P408");
            dtgXemLH.Rows.Add("SD18301","29/7/2023",3,"F201");
            dtgXemLH.Rows.Add("SD18303","30/7/2023",1,"D401");
            dtgXemLH.Rows.Add("SD18301","31/7/2023",2,"P408");
            dtgXemLH.Rows.Add("SD18303","1/8/2023",3,"F201");
            dtgXemLH.Rows.Add("FE101","2/8/2023",1,"F101");
        }

        private void dtgXemLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
