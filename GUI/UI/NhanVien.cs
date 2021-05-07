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
using GUI.DTO;

namespace GUI
{
    public partial class NhanVien : Form
    {
        List<GioHang> list = new List<GioHang>();
        public string maNV { get; set; }
        public int Stt = 0;
        public NhanVien()
        {
            InitializeComponent();
            setCbbMaSach();
        }


        public void setCbbMaSach()
        {
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaSach())
            {
                cbbMaSach.Items.Add(i);
            }
            cbbMaSach.SelectedIndex = 0;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            txt1.Text = BLL_QuanLy.Instance.Bll_GetNameNVByMaNV(maNV);
            txt1.Enabled = false; 
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if(MaDonBan.Text == "")
            {
                MessageBox.Show("Vui long nhap ma don ban");
                return;
            }
            GioHang a = new GioHang();
            a.MaDonBan = MaDonBan.Text;
            a.SoDT = SDT.Text;
            a.HoTen = HoTen.Text;
            a.MaSach = cbbMaSach.SelectedItem.ToString();
            a.SoLuong = Convert.ToInt32(numericUpDown1.Value.ToString());
            a.GiaTien = BLL_QuanLy.Instance.Bll_GetGiaTienByMaSach(a.MaSach) * a.SoLuong;
            list.Add(a);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
            HoTen.Enabled = false;
            SDT.Enabled = false;
        }

        private void ChinhSua_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(dataGridView2.CurrentRow.Cells["STT"].Value.ToString());
            foreach(GioHang a in list)
            {
                //if(a.STT == stt)
                //{
                //    sdt.Text = a.SoDT;
                //    hoTen.Text = a.HoTen;
                //    cbbMaSach.SelectedItem = a.MaSach;
                //    numericUpDown1.Value = a.SoLuong;
                //}
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(dataGridView2.CurrentRow.Cells["STT"].Value.ToString());
            foreach (GioHang a in list)
            {
                //if (a.STT == stt)
                //{
                //    list.Remove(a);
                //    break;
                //}
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            KHACH_HANG kh = new KHACH_HANG();
            kh.SDT = SDT.Text;
            kh.HoTen = HoTen.Text;
            BLL_QuanLy.Instance.Bll_AddKhachHang(kh);
            HOA_DON_BAN hdb = new HOA_DON_BAN()
            {
                MaDonBan = MaDonBan.Text,
                SDT_KH = SDT.Text,
                MaNhanVien = maNV,
                NgayBan = DateTime.Now,
            };
            BLL_QuanLy.Instance.Bll_AddHoaDonBan(hdb);
            foreach(GioHang a in list)
            {
                CHI_TIET_HOA_DON_BAN ct = new CHI_TIET_HOA_DON_BAN()
                {
                    MaDonBan = a.MaDonBan,
                    MaSach = a.MaSach,
                    SoLuong = a.SoLuong,
                    DonGia = a.GiaTien,
                    ThanhTien = a.SoLuong * a.GiaTien,
                };
                BLL_QuanLy.Instance.Bll_AddChiTietHoaDonBan(ct);
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllSach();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
