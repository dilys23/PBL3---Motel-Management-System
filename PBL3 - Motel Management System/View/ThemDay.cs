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
    public partial class ThemDay : Form
    {
       
        public ThemDay()
        {
            InitializeComponent();
           // this.paneDesktop = paneDesktop;
         
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            //paneDesktop.Controls.Add(this);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean kiemTraThemDay()
        {
            int i = 0;
            errorProvider1.SetError(txtTenHuyen, "");
            errorProvider1.SetError(txtTenDay, "");
            errorProvider1.SetError(txtTenDuong, "");
            errorProvider1.SetError(txtTenThanhPho, "");
            if(txtTenDay.Text == "")
            {
                errorProvider1.SetError(txtTenDay, "Vui lòng nhập tên dãy");
                i++;
                
            }
            if (txtTenHuyen.Text == "")
            {
                errorProvider1.SetError(txtTenHuyen, "Vui lòng nhập tên huyện");
                i++;

            }
            if (txtTenDuong.Text == "")
            {
                errorProvider1.SetError(txtTenDuong, "Vui lòng nhập tên đường");
                i++;

            }
            if (txtTenThanhPho.Text == "")
            {
                errorProvider1.SetError(txtTenThanhPho, "Vui lòng nhập tên thành phố");
                i++;

            }
            if (i==0) return true;
            else return false;

        }
        private void btnThemDay_Click(object sender, EventArgs e)
        {
            if(kiemTraThemDay())
            {
                
            }
        }
    }
}
