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
    public partial class ThemNhanViens : Form
    {
        public string maNV { get; set; }
        public ThemNhanViens()
        {
            InitializeComponent();
        }

        private void ThemNhanViens_Load(object sender, EventArgs e)
        {
            maNV = "NV01";
            NHAN_VIEN nv = BLL_QuanLy.Instance.Bll_GetNVByMaNV(maNV);
            MaNV.Text = nv.MaNhanVien;
            HoTen.Text = nv.HoTen;
            if (nv.GioiTinh == "Nam") Nam.Checked = true;
            else Nu.Checked = true;
            DanToc.Text = nv.DanToc;
            CMND.Text = nv.CMND;
            Sdt.Text = nv.SoDienThoai;
            QueQuan.Text = nv.QueQuan;
            dateTimePicker1.Value = nv.NgaySinh;
        }

        

        private void LamMoi_Click(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Add()
        {
            NHAN_VIEN nv = new NHAN_VIEN();            
            nv.MaNhanVien = MaNV.Text;
            nv.HoTen = HoTen.Text;
            if (Nam.Checked == true) nv.GioiTinh = "Nam";
            else nv.GioiTinh = "Nu";
            nv.DanToc = DanToc.Text;
            nv.CMND = CMND.Text;
            nv.SoDienThoai = Sdt.Text;
            nv.QueQuan = QueQuan.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            BLL_QuanLy.Instance.Bll_AddNhanVien(nv);
            TK_NHANVIEN tk = new TK_NHANVIEN();
            tk.TKNV = MaNV.Text;
            tk.Pass = MatKhau.Text;
            BLL_QuanLy.Instance.Bll_AddTKNhanVien(tk);
        }

        private void Edit(string maNV)
        {
            NHAN_VIEN nv = new NHAN_VIEN(); 
            MaNV.Text = "NV03";
            MaNV.Enabled = false;
            nv.MaNhanVien = MaNV.Text;
            nv.HoTen = HoTen.Text;
            if (Nam.Checked == true) nv.GioiTinh = "Nam";
            else nv.GioiTinh = "Nu";
            nv.DanToc = DanToc.Text;
            nv.CMND = CMND.Text;
            nv.SoDienThoai = Sdt.Text;
            nv.QueQuan = QueQuan.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            BLL_QuanLy.Instance.Bll_EditNhanVien(nv);
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            Edit("NV03");
        }
    }
}
