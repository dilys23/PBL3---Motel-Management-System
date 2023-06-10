using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public ThemThietBi(string IdTb, Loader loader)
        {
            InitializeComponent();
            this.Loader = loader;
            this.IdTb = IdTb;
            if(IdTb != null )
            {
                ThietBi tb = QLBLLThietbi.Instance.GetTBByIdTB(IdTb);
                txtTenTB.Text = tb.TenThietBi;
                txtGia.Text = tb.GiaThietBi.ToString("#,##0") + "₫"; 
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
            string giaTienText = QLBLLChung.Instance.ChuyenDoiTienSangDouble(txtGia.Text).ToString();
            if (txtGia.Text != "")
            {
                if (!double.TryParse(giaTienText, out double giaTien))
                {
                    i++;
                    errorProvider1.SetError(txtGia, "Vui lòng nhập giá tiền hợp lệ");
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
                    ThietBi tb = QLBLLThietbi.Instance.GetTBByIdTB(IdTb);
                    tb.TenThietBi = txtTenTB.Text;
                    tb.GiaThietBi = (Convert.ToDouble(txtGia.Text.Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")));
                    QLBLLThietbi.Instance.SuaTBBll(tb);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                }
                else
                {
                    ThietBi tb = new ThietBi()
                    {
                        MaThietBi = QLBLLThietbi.Instance.TaoIdThietBi(),
                        TenThietBi = txtTenTB.Text,
                        GiaThietBi = (Convert.ToDouble(txtGia.Text.Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", ""))),
                        TonTai = true
                    };      
                    QLBLLThietbi.Instance.ThemTBBll(tb);
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");
                }
                Loader(null);
                this.Close();
            }
        }
    }
}
