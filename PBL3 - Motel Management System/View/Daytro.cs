using PBL3___Motel_Management_System.BLL;
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
    public partial class Daytro : Form
    {
        public Daytro()
        {
            InitializeComponent();
            SetCbbDayTro();
        }
        TrangChu tc = new TrangChu();   
        public void SetCbbDayTro()
        {
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.Add("All");
            cbbTinhTrang.Items.Add("Đã cho thuê");
            cbbTinhTrang.Items.Add("Trống");
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemPhong(), panelDay);
        }

        private void btnThemday_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemDay(), panelDay);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaPhong(), panelDay);
        }

        private void Daytro_Load(object sender, EventArgs e)
        {

        }
    }
}
