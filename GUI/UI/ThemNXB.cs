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
    public partial class ThemNXB : Form
    {
        public ThemNXB()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            NHA_XUAT_BAN nxb = new NHA_XUAT_BAN();
            nxb.MaNXB = MaNXB.Text;
            nxb.TenNXB = TenNXB.Text;
            BLL_QuanLy.Instance.Bll_AddNXB(nxb);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
