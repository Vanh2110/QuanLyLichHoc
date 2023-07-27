using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien
{
    public partial class FormGiangVien : Form
    {

        public FormGiangVien()
        {
            InitializeComponent();
            LoadGrid(null);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void LoadGrid(string input)
        {
            int stt = 1;
            dtgDSLichDay.ColumnCount = 5;
            dtgDSLichDay.Columns[0].Name = "STT";
            dtgDSLichDay.Columns[1].Name = "Lớp";
            dtgDSLichDay.Columns[2].Name = "Ngày";
            dtgDSLichDay.Columns[3].Name = "Ca học";
            dtgDSLichDay.Columns[4].Name = "Phòng";
            dtgDSLichDay.Rows.Clear();
            dtgDSLichDay.Rows.Add(stt++, "SD18301", "30/7/2023", "Ca 1", "D401");
        }

        private void dtgDSLichHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
