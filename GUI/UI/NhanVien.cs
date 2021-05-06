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
        //public string maNV { get; set; }
        public string maNV = "NV02";
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

        private void Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllSach();
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            txt1.Text = BLL_QuanLy.Instance.Bll_GetNameNVByMaNV(maNV);
            txt1.Enabled = false; 
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            string HoTen = hoTen.Text;
            string Sdt = sdt.Text;
            string MaSach = cbbMaSach.SelectedItem.ToString();
            int SoLuong = Convert.ToInt32(numericUpDown1.Value.ToString());
            //MessageBox.Show(list.Count.ToString());
            GioHang a = new GioHang()
            {
                STT = ++Stt,
                SoDT = Sdt,
                HoTen = HoTen,
                MaSach = MaSach,
                SoLuong = SoLuong,
                GiaTien = BLL_QuanLy.Instance.Bll_GetGiaTienByMaSach(MaSach) * SoLuong,
            };
            list.Add(a);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
        }

        private void ChinhSua_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(dataGridView2.CurrentRow.Cells["STT"].Value.ToString());
            foreach(GioHang a in list)
            {
                if(a.STT == stt)
                {
                    sdt.Text = a.SoDT;
                    hoTen.Text = a.HoTen;
                    cbbMaSach.SelectedItem = a.MaSach;
                    numericUpDown1.Value = a.SoLuong;
                }
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(dataGridView2.CurrentRow.Cells["STT"].Value.ToString());
            foreach (GioHang a in list)
            {
                if (a.STT == stt)
                {
                    list.Remove(a);
                    break;
                }
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
