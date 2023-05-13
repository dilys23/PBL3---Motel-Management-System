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
        private string IdTb;
        private Loader Loader;
        
        public ThemThietBi(string IdTb, Loader loader)
        {
            InitializeComponent();
            this.Loader = loader;
            this.IdTb = IdTb;
            if(IdTb != null )
            {
                ThietBi tb = QLBLL.Instance.GetTBByIdTB(IdTb);
                txtTenTB.Text = tb.TenThietBi;
                txtGia.Text = tb.GiaThietBi.ToString();
            }
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
                if (IdTb != null)
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
                else
                {
                    ThietBi tb = new ThietBi();
                    tb.MaThietBi = QLBLL.Instance.TaoIdThietBi();
                    tb.TenThietBi = txtTenTB.Text;
                    tb.GiaThietBi = Convert.ToDouble(txtGia.Text);        
                    tb.TonTai = true;
                    QLBLL.Instance.ThemTBBll(tb);
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");
                    Loader(null);
                    this.Close();
                }
               
            }
        }
    }
}
