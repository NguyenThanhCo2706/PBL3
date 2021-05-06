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
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        private void Xem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllNhanVien();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemNhanViens f = new ThemNhanViens();
            f.maNV = null;
            f.Show();
        }

        private void ChinhSua_Click(object sender, EventArgs e)
        {

            ThemNhanViens f = new ThemNhanViens();
            //MessageBox.Show(dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString());
            f.maNV = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            f.Show();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Chon Row can xoa");
                return;
            }
            foreach (DataGridViewRow i in r)
            {
                string manv = i.Cells["MaNhanVien"].Value.ToString();
                BLL_QuanLy.Instance.Bll_DeleteNVByMaNV(manv);
                //MessageBox.Show("Da xoa");
            }
            
        }

        private void SapXep_Click(object sender, EventArgs e)
        {

        }
    }
}
