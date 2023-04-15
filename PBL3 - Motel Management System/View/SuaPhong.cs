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

namespace PBL3___Motel_Management_System
{
    public partial class SuaPhong : Form
    {
        private string IdPhong;
        public SuaPhong(string IdPhong)
        {
            InitializeComponent();        
            this.IdPhong = IdPhong;
        }
        public void FormLoad(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            PhongTro phongTro= qLDAL.GetPhongTroByIdPhong(IdPhong);
            if(IdPhong != null)
            {

            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
               this.Close();
        }
    }
}
