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
    public partial class ChitietPhongtro : Form
    {
        private ThuePhong tp;
        
        public ChitietPhongtro()
        {
            InitializeComponent();
            
        }
        
      
       
        
        TrangChu tc = new TrangChu();

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietHopDong(tp, null), panelchitietphong);
        }

    }
}
