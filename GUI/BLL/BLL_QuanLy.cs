using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.BLL
{
    class BLL_QuanLy
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_QuanLy _Instance;
        public static BLL_QuanLy Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QuanLy();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_QuanLy() { }

        public bool Bll_CheckTKMK(string tk, string mk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            var list = db.TK_NHANVIEN.ToList();
            List<TK_NHANVIEN> tk_NhanVien = list;
            foreach (TK_NHANVIEN i in tk_NhanVien)
            {
                if (tk == i.TKNV && mk == i.Pass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Bll_CheckAdmin(string tk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            bool a = db.NHAN_VIEN.Find(tk).isAdmin;
            return a;
        }

        public List<SACH> Bll_GetAllSach()
        {
            //QuanLyEntities db = new QuanLyEntities();
            var list = db.SACHes.ToList();
            List<SACH> lSach = list;
            return lSach;
        }
        public List<CHI_TIET_HOA_DON_NHAP> Bll_GetAllChiTietHoaDonNhap()
        {
            List<CHI_TIET_HOA_DON_NHAP> l = db.CHI_TIET_HOA_DON_NHAP.ToList();
            return l;
        }
        public List<string> Bll_GetAllMaSach()
        {
            List<String> list = new List<string>();
            list = db.SACHes.Select(p => p.MaSach).ToList();
            return list;
        }

        public List<string> Bll_GetAllMaDonNhap()
        {
            List<String> list = new List<string>();
            list = db.HOA_DON_NHAP.Select(p => p.MaDonNhap).ToList();
            return list;
        }

        public List<string> Bll_GetAllMaNXB()
        {
            List<string> list = new List<string>();
            list = db.NHA_XUAT_BAN.Select(p => p.MaNXB).ToList();
            return list;
        }
        public List<string> Bll_GetAllMaLS()
        {
            List<string> list = new List<string>();
            list = db.LOAI_SACH.Select(p => p.MaLoaiSach).ToList();
            return list;
        }

        public string Bll_GetNameNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv).HoTen.ToString();
        }

        public NHAN_VIEN Bll_GetNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv);
        }

        public int Bll_GetGiaTienByMaSach(string masach)
        {
            return db.SACHes.Find(masach).GiaBan;
        }

        public List<NHAN_VIEN> Bll_GetAllNhanVien()
        {
            List<NHAN_VIEN> list = new List<NHAN_VIEN>();
            list = db.NHAN_VIEN.ToList();
            return list;
        }

        public void Bll_AddNhanVien(NHAN_VIEN nv)
        {
            db.NHAN_VIEN.Add(nv);
            db.SaveChanges();
        }

        public void Bll_AddTKNhanVien(TK_NHANVIEN tk)
        {
            db.TK_NHANVIEN.Add(tk);
            db.SaveChanges();
        }
        public void Bll_AddSach(SACH a)
        {
            db.SACHes.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddKhachHang(KHACH_HANG a)
        {
            db.KHACH_HANG.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddHoaDonBan(HOA_DON_BAN a)
        {
            db.HOA_DON_BAN.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddChiTietHoaDonBan(CHI_TIET_HOA_DON_BAN a)
        {
            db.CHI_TIET_HOA_DON_BAN.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddChiTietHoaDonNhap(CHI_TIET_HOA_DON_NHAP a)
        {
            db.CHI_TIET_HOA_DON_NHAP.Add(a);
            db.SaveChanges();
        }
        public void Bll_EditNhanVien(NHAN_VIEN nv)
        {
            var tmp = db.NHAN_VIEN.Find(nv.MaNhanVien);
            tmp.HoTen = nv.HoTen;
            tmp.DanToc = nv.DanToc;
            tmp.GioiTinh = nv.GioiTinh;
            tmp.CMND = nv.CMND;
            tmp.SoDienThoai = nv.SoDienThoai;
            tmp.QueQuan = nv.QueQuan;
            tmp.NgaySinh = nv.NgaySinh;
            tmp.TrangThai = nv.TrangThai;
            tmp.isAdmin = nv.isAdmin;
            db.SaveChanges();
        }

        public void Bll_DeleteNVByMaNV(string manv)
        {
            db.NHAN_VIEN.Remove(Bll_GetNVByMaNV(manv));
            db.SaveChanges();
        }

        public void Bll_AddLoaiSach(LOAI_SACH ls)
        {
            db.LOAI_SACH.Add(ls);
            db.SaveChanges();
        }

        public void Bll_AddNXB(NHA_XUAT_BAN nxb)
        {
            db.NHA_XUAT_BAN.Add(nxb);
            db.SaveChanges();
        }

        public void Bll_AddHoaDonNhap(HOA_DON_NHAP hdn)
        {
            db.HOA_DON_NHAP.Add(hdn);
            db.SaveChanges();
        }

        
    }
}
