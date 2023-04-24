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
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            SetCbb();
            LoadForm(null);
        }
        TrangChu tc= new TrangChu();
        private void LoadForm(string txt)
        {

        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.Add(new ViewCbb { IdDayTro = "0", TenDayTro = "All" });
            cbbTinhTrang.Items.Add(new ViewCbb { IdDayTro = "1", TenDayTro = "Đã xác thực" });
            cbbTinhTrang.Items.Add(new ViewCbb { IdDayTro = "2", TenDayTro = "Chưa xác thực" });
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new XuatHoaDon(), panel2);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemHoaDon(), panel2);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaHoaDon(), panel2);
        }

        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            cbbPhongTro.Items.Add(new ViewCbb { IdDayTro="0", TenDayTro="All" });
            string id = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
            if (id == "0")
            {

                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro = pt.MaPhongTro, TenDayTro = pt.TenPhongTro });
                }
            }
            else
            {
                foreach (ViewPhongTro pt in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro=pt.MaPhongTro, TenDayTro=pt.TenPhongTro });
                }
            }
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }
    }
}
