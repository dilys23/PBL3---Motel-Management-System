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
    public partial class ChitietDay : Form
    {
        private string IdDay;
        public ChitietDay(string idDay)
        {
            InitializeComponent();
            this.IdDay = idDay;
        }
        TrangChu tc = new TrangChu();
        
        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemPhong(IdDay), panelChitietDay);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaPhong(), panelChitietDay);
        }
    }
}
