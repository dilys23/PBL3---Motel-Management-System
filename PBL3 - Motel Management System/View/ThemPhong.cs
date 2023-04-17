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
    public partial class ThemPhong : Form
    {
        private string IdDay;
        public Loader Loader;
        public ThemPhong(string IdDay,Loader Loader)
        {
            InitializeComponent();
            this.IdDay = IdDay;
            this.Loader = Loader;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {

        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtDienTich, "");
            errorProvider1.SetError(txtGiaTien, "");
            errorProvider1.SetError(txtTenPhong, "");
            errorProvider1.SetError(txtToiDa, "");
            if(txtDienTich.Text == "")
            {
                i++;
                errorProvider1.SetError(txtDienTich, "Vui lòng nhập diện tích");
            }
            if (txtGiaTien.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGiaTien, "Vui lòng nhập giá tiền");
            }
            if (txtTenPhong.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenPhong, "Vui lòng nhập tên phòng");
            }
            if (txtToiDa.Text == "")
            {
                i++;
                errorProvider1.SetError(txtToiDa, "Vui lòng nhập số người tối đa");
            }
            if(txtGiaTien.Text != "")
            {
                if(!Int32.TryParse(txtGiaTien.Text, out int demo))
                {
                    i++;
                    errorProvider1.SetError(txtGiaTien, "Vui lòng nhập giá tiền bằng số");
                }
            }
            if (txtDienTich.Text != "")
            {
                if (!Int32.TryParse(txtDienTich.Text, out int demo))
                {
                    i++;
                    errorProvider1.SetError(txtDienTich, "Vui lòng nhập diện tích bằng số");
                }
            }
            if (txtToiDa.Text != "")
            {
                if (!Int32.TryParse(txtToiDa.Text, out int demo))
                {
                    i++;
                    errorProvider1.SetError(txtToiDa, "Vui lòng nhập bằng số");
                }
            }


            if (i==0) return true;
            else return false;




        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if(checkHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                PhongTro pt = new PhongTro();
                pt.MaPhongTro = qLBLL.TaoIdPhongTro();
                pt.TenPhongTro = txtTenPhong.Text;
                pt.GiaTien = Convert.ToDouble(txtGiaTien.Text);
                pt.DienTich = Convert.ToDouble(txtDienTich.Text);
                pt.TinhTrang = false;
                pt.ToiDa = Convert.ToInt32(txtToiDa.Text);          
                pt.MaDayTro = IdDay;
                qLBLL.AddPhongTroBll(pt);
                MessageBox.Show("Thêm phòng trọ vào dãy thành công", "Thông báo");
                Loader(null);
                this.Close();
            }

        }
    }
}
