using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DTO;
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
    public partial class Hopdong : Form
    {
        public Hopdong()
        {
            InitializeComponent();
            LoadForm(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        TrangChu tc = new TrangChu();
        private void LoadForm(string txt)
        {
            QLBLL qLBLL = new QLBLL();
            foreach(DgvHopDong hd in qLBLL.DgvHopDong())
            {
                dgvHopDong.Rows.Add(hd.MaHopDong,hd.Stt,hd.TenKhachHang,hd.TenPhongTro,hd.TenDayTro,hd.NgayBatDau,hd.NgayKetThuc,hd.TienCoc);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}
