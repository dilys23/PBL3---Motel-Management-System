using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class ThemDV : Form
    {
        private Loader Loader;
        public ThemDV(Loader loader)
        {
            InitializeComponent();
            this.Loader = loader;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtGiaDichVu, "");
            errorProvider1.SetError(txtTenDichVu, "");
            if(txtTenDichVu.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenDichVu, "Vui lòng nhập tên dịch vụ");
            }
            if (txtGiaDichVu.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGiaDichVu, "Vui lòng nhập giá dịch vụ");
            }
            if(txtGiaDichVu.Text != "")
            {
                if(!double.TryParse(txtGiaDichVu.Text,out double d))
                {
                    i++;
                    errorProvider1.SetError(txtGiaDichVu, "Giá dịch vụ phải bằng số");
                }
            }
            if (i==0) return true;
            return false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(checkHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                DichVu dv = new DichVu();
                dv.TenDichVu = txtTenDichVu.Text;
                dv.GiaDichVu = Convert.ToDouble(txtGiaDichVu.Text);
                dv.MaDichVu = qLBLL.TaoIdDichVu();
                qLBLL.ThemDVBll(dv);
                MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");
                Loader(null);
                this.Close();
            }

        }
    }
}
