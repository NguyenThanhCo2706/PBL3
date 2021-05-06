using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.BLL;

namespace GUI
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllSach();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void ThemHoaDon_Click(object sender, EventArgs e)
        {
            ThemHoaDon f = new ThemHoaDon();
            f.Show();
        }

        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            ThemChiTiet f = new ThemChiTiet();
            f.Show();
        }
    }
}
