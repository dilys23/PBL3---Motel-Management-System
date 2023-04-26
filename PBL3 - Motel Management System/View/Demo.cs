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
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            
        }
        public void SetPanelKhach(Label lbl)
        {
            panelTenKhach.Controls.Add(lbl);
            

        }
        public void SetPanelTenPhongTro(Label lbl)
        {
            panelTenPhongTro.Controls.Add(lbl);
        }
    }
}
