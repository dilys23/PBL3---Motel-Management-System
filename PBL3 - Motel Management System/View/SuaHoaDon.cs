using PBL3___Motel_Management_System.BLL;
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

namespace PBL3___Motel_Management_System.View
{
    public partial class SuaHoaDon : Form
    {
        private Loader loader;
        private string Idhd;
        public SuaHoaDon(Loader loader, string Idhd)
        {
            
            InitializeComponent();
            this.loader=loader;
            this.Idhd=Idhd;
            LoadForm();
        }
        private void LoadForm()
        {
            QLBLL qLBLL = new QLBLL();
            HoaDon hd = qLBLL.GetHoaDonById(Idhd);
            
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
