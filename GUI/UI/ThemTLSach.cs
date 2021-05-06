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
    public partial class ThemTLSach : Form
    {
        public ThemTLSach()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            LOAI_SACH ls = new LOAI_SACH();
            ls.MaLoaiSach = MaLS.Text;
            ls.TenLoaiSach = TenLS.Text;
            BLL_QuanLy.Instance.Bll_AddLoaiSach(ls);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
