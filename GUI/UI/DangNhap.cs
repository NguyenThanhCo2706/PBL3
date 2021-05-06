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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string tk = textBox1.Text;
            string mk = textBox2.Text;
            bool checktkmk = BLL_QuanLy.Instance.Bll_CheckTKMK(tk, mk);
            if(checktkmk == true)
            {
                if (BLL_QuanLy.Instance.Bll_CheckAdmin(tk) == false)
                {
                    NhanVien f = new NhanVien();
                    
                    f.maNV = tk;                   
                    f.Show();
                }
                else
                {
                    QuanLy f = new QuanLy();
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
