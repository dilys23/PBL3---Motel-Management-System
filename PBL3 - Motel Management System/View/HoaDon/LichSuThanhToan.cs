using PBL3___Motel_Management_System.BLL;
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
    public partial class LichSuThanhToan : Form
    {
        private Loader loader;
        private string IdHd;


        public LichSuThanhToan(Loader loader, string idHd)
        {
            InitializeComponent();
            QLBLL.Instance.customDGV(dgvLichSu);
            this.loader = loader;
            this.IdHd =idHd;
            if(this.IdHd != null)
            {
                Hoadon hd = QLBLL.Instance.GetHoaDonById(this.IdHd); 


            }  
                
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
