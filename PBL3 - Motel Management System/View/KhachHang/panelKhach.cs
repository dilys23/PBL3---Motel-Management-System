using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View.KhachHang
{
    public partial class panelKhach : Form
    {
        public panelKhach()
        {
            InitializeComponent();
            RoundPanel(panel1, 10);
           // RoundPanel(panel2, 10);
        }

        private void RoundPanel(Panel panel, int cornerRadius)
        {
            RectangleF rect = new RectangleF(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            panel.Region = new Region(path);
        }
    }
}
