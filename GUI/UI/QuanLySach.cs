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
        List<CHI_TIET_HOA_DON_NHAP> list = new List<CHI_TIET_HOA_DON_NHAP>();
        public QuanLySach()
        {
            InitializeComponent();
            setData();
        }
        public void setData()
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllSach();
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetAllChiTietHoaDonNhap();
        }  

        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            ThemChiTiet f = new ThemChiTiet();
            f.Show();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            foreach(CHI_TIET_HOA_DON_NHAP i in list)
            {
                BLL_QuanLy.Instance.Bll_AddChiTietHoaDonNhap(i);
            }
        }
    }
}
