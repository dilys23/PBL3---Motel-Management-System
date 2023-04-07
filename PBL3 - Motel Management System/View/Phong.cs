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
    public partial class Phong : Form
    {
        
       
        public Phong()
        {
            InitializeComponent();
            //this.paneDesktop = paneDesktop;
         
        }

       

        

      

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
        }

        private void btnThemday_Click(object sender, EventArgs e)
        {
            ThemDay themDayForm = new ThemDay();
           
            themDayForm.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaphong_Click(object sender, EventArgs e)
        {
            SuaPhong themSuaph = new SuaPhong();
            themSuaph.ShowDialog();
        }

        //private void btThemDay_Click(object sender, EventArgs e)
        //{
        //  // openChildForm(new AddRoom());

        //}
        //private Menu1 activeForm = null;
        //private void openChildForm(Menu1 childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //  //  panelDesktop.Controls.Add(childForm);
        // //  panelDesktop.Tag = childForm;
        //    childForm.BringToFront();
        //    childForm.Show();

        //}

    }
}
