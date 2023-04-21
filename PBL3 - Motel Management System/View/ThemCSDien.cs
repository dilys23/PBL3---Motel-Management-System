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
    public partial class ThemCSDien : Form
    {
        public ThemCSDien()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemCSDien_Load(object sender, EventArgs e)
        {
            
        }

        private void dtpThang_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            dtpThang.Text = dt.ToString("MMMM/yyyy");
        }
    }
}
