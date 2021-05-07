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
    public partial class ThemSach : Form
    {
        public ThemSach()
        {
            InitializeComponent();
            setcbbNXB();
            setcbbTL();
        }

        public void setcbbNXB()
        {
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaNXB())
            {
                cbbNXB.Items.Add(i);
            }
        }

        public void setcbbTL()
        {
            foreach (string i in BLL_QuanLy.Instance.Bll_GetAllMaLS())
            {
                cbbTL.Items.Add(i);
            }
        }

        private void ThemNXB_Click(object sender, EventArgs e)
        {
            ThemNXB f = new ThemNXB();
            f.Show();
        }

        private void ThemTheLoai_Click(object sender, EventArgs e)
        {
            ThemTLSach f = new ThemTLSach();
            f.Show();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            SACH a = new SACH();
            a.MaSach = MaSach.Text;
            a.TenSach = TenSach.Text;
            a.GiaBan = Convert.ToInt32(GiaBan.Text);
            a.SoLuong = 0;
            a.MaNXB = cbbNXB.SelectedItem.ToString();
            a.MaLoaiSach = cbbTL.SelectedItem.ToString();
            BLL_QuanLy.Instance.Bll_AddSach(a);
        }

    }
}
