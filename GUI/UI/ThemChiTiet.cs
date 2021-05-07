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
    public partial class ThemChiTiet : Form
    {
        public ThemChiTiet()
        {
            InitializeComponent();
            setcbbMaSach();
            setcbbMaDonNhap();
        }

        public void setcbbMaDonNhap()
        {
            foreach (string i in BLL_QuanLy.Instance.Bll_GetAllMaDonNhap())
            {
                cbbMaDonNhap.Items.Add(i);
            }
        }
        public void setcbbMaSach()
        {
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaSach())
            {
                cbbMaSach.Items.Add(i);
            }
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            ThemSach f = new ThemSach();
            f.Show();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            CHI_TIET_HOA_DON_NHAP ct = new CHI_TIET_HOA_DON_NHAP()
            {
                MaDonNhap = cbbMaDonNhap.SelectedItem.ToString(),
                MaSach = cbbMaSach.SelectedItem.ToString(),
                GiaNhap = Convert.ToInt32(GiaNhap.Text),
                SoLuong = Convert.ToInt32(SoLuong.Text),
                ThanhTien = 10,
            };
            BLL_QuanLy.Instance.Bll_AddChiTietHoaDonNhap(ct);     
        }

        private void ThemHoaDon_Click(object sender, EventArgs e)
        {
            ThemHoaDon f = new ThemHoaDon();
            f.Show();
        }
    }
}
