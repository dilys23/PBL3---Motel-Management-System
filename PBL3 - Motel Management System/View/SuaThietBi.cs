using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
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
    public partial class SuaThietBI : Form
    {
        private string IdTb;
        private Loader Loader;

        public SuaThietBI(string idTb, Loader loader)
        {
            InitializeComponent();
            this.IdTb = idTb;
            this.Loader = loader;
            ThietBi tb = QLBLL.Instance.GetTBByIdTB(idTb);
            txtTenTB.Text = tb.TenThietBi;
            txtGia.Text = tb.GiaThietBi.ToString();

        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtTenTB, "");
            errorProvider1.SetError(txtGia, "");
            if (txtTenTB.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenTB, "Vui lòng điền tên thiết bị");
            }
            if (txtGia.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGia, "Vui lòng điền giá Thiết bị");
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

        private void btnLuuTB_Click(object sender, EventArgs e)
        {
            if (checkHopLe())
            {
                ThietBi tb = QLBLL.Instance.GetTBByIdTB(IdTb);
                tb.MaThietBi = IdTb;
                tb.TenThietBi = txtTenTB.Text;
                tb.GiaThietBi = Convert.ToDouble(txtGia.Text);
                QLBLL.Instance.SuaTBBll(tb);
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                Loader(null);
                this.Close();
            }
        }
    }
}
