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

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemThietBi : Form
    {
        private Loader Loader;
        
        public ThemThietBi(Loader loader)
        {
            InitializeComponent();
            this.Loader = loader;
        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtTenTB, "");
            errorProvider1.SetError(txtGia, "");
            if (txtTenTB.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenTB, "Vui lòng nhập tên thiết bị");
            }
            if (txtGia.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGia, "Vui lòng nhập giá thiết bị");
            }
            if (txtGia.Text != "")
            {
                if (!double.TryParse(txtGia.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtGia, "Giá thiết bị phải bằng số");
                }
            }
            if (i == 0) return true;
            return false;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (checkHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                ThietBi tb = new ThietBi();
                tb.TenThietBi = txtTenTB.Text;
                tb.GiaThietBi = Convert.ToDouble(txtGia.Text);
                tb.MaThietBi = qLBLL.TaoIdThietBi();
                tb.TonTai = true;
                qLBLL.ThemTBBll(tb);
                MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");
                Loader(null);
                this.Close();
            }
        }
    }
}
