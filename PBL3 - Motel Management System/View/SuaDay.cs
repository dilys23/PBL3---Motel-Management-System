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
    public partial class SuaDay : Form
    {
        private string IdDay;
        private Loader Loader;


        public SuaDay(string idDay, Loader loader)
        {
            InitializeComponent();
            this.IdDay = idDay;
            this.Loader = loader;
            QLBLL qLBLL = new QLBLL();
            DayTro day = qLBLL.GetDayByIdDay(idDay);
            txtTenDay.Text = day.TenDayTro.ToString();  
            txtQuanHuyen.Text = day.TenHuyen.ToString();
            txtdiachi.Text = day.TenDuong.ToString();
            txtThanhpho.Text = day.TenThanhPho.ToString();
            //txtdiachi.Text = day.
        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtTenDay, "");
            errorProvider1.SetError(txtQuanHuyen, "");
            errorProvider1.SetError(txtdiachi, "");
            errorProvider1.SetError(txtThanhpho, "");
            if (txtTenDay.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenDay, "Vui lòng điền tên dãy");
            }
            if (txtQuanHuyen.Text == "")
            {
                i++;
                errorProvider1.SetError(txtQuanHuyen, "Vui lòng điền tên quận huyện");
            }
            if (txtdiachi.Text == "")
            {
                i++;
                errorProvider1.SetError(txtdiachi, "Vui lòng điền tên phường");
            }
            if (txtThanhpho.Text == "")
            {
                i++;
                errorProvider1.SetError(txtThanhpho, "Vui lòng điền tên Thành phố");
            }


            if (i == 0) return true;
            return false;


        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(checkHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                DayTro day = new DayTro();
                day.MaDayTro = IdDay;
                day.TenDayTro = txtTenDay.Text;
                day.TenHuyen = txtQuanHuyen.Text;
                day.TenDuong  = txtdiachi.Text;
                day.TenThanhPho = txtThanhpho.Text; 
                qLBLL.SuaDayBll(day);
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                Loader(null);
                this.Close();
            }    
        }
    }    
}
