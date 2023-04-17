using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.View;

namespace PBL3___Motel_Management_System.View
{

    public partial class ChisoDien : Form
    {
        public ChisoDien()
        {
            InitializeComponent();
            Setcbb();
        }

        TrangChu tc = new TrangChu();

        private void ChisoDien_Load(object sender, EventArgs e)
        {

        }

        public void Setcbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemCSDien(), panel2);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaCSDien(), panel2);
        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            Daytro dt= cbbDayTro.SelectedItem as Daytro;
            if(dt !=null)
            {
                //List<PhongTro> list = qLBLL.GetAllPhongTroByIdDay(dt.MaDayTro);
            }


        }
    }
}
