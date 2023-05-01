using PBL3___Motel_Management_System.DTO;
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
    public partial class ChitietPT : Form
    {

        public ChitietPT()
        {
            InitializeComponent();
         

        }
        TrangChu tc= new TrangChu();

      
        /*
        public void ThemTab(Form form)
        {
         
            int index = check(tabform, form);
            if (index >= 0)
            {
                tabform.TabIndex = index;
            }
            else
            {
                TabPage tabpage = new TabPage();
                tabpage.BorderStyle = BorderStyle.Fixed3D;
                tabform.TabPages.Add(tabpage);
                form.TopLevel = false;
                form.Parent = tabpage;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }

      */
        public int check(TabControl tabform, Form form)
        {
            for (int i = 0; i < tabform.TabPages.Count; i++)
            {
                if (tabform.TabPages[i].Text.Trim() == form.Text.Trim())
                    return i;
            }
            return -1;
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //ChitietDichVu dv= new ChitietDichVu();
            //ThemTab(dv);
            tc.openChildForm1(new ChitietDichVu(), panelPhong); 
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            //ChitietThanhvien ct = new ChitietThanhvien();
            //ThemTab(ct);
            tc.openChildForm1(new ChitietThanhvien(),panelPhong);
        }

        private void btnHopDong_Click_1(object sender, EventArgs e)
        {
            ChitietHopDong ct = new ChitietHopDong(null,null);
            ct.panelct.Visible = false;
            tc.openChildForm1(ct, panelPhong);
            ct.btnXacNhan.Visible = false;
        }

        private void btnThanhVien_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietThanhvien(), panelPhong);
        }

        private void btnDichVu_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietDichVu(), panelPhong);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void ChitietPT_Load(object sender, EventArgs e)
        {
            ChitietHopDong ct = new ChitietHopDong(null, null);
            ct.panelct.Visible = false;
            tc.openChildForm1(ct, panelPhong);
            ct.btnXacNhan.Visible = false;
        }
    }
}
