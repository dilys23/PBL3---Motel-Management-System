using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class ThemHopDong : Form
    {
        public ThemHopDong()
        {
            InitializeComponent();
        }

        private void ThemHD_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        TrangChu tc = new TrangChu();
      

        private void btnThemKhach_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemKhach(), panelThemHD);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelThemHD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelThem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private bool CheckHopLe()
        {
            var dateStart = dtpBatDau.Value;
            var dateEnd = dtpKetThuc.Value;
            var distance = dateEnd - dateStart;
            
            if(distance.Days < 30)
            {
                return false;
            }
            return true;
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if(CheckHopLe())
            {

            tc.openChildForm1(new ChitietHopDong(),panelThemHD);
            }
            else
            {
                MessageBox.Show("Thời gian hợp đồng phải tối thiểu 1 tháng","Thông báo");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
