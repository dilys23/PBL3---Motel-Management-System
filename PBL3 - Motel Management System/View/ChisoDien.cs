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

namespace PBL3___Motel_Management_System.View
{

    public partial class ChisoDien : Form
    {
        public ChisoDien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSuaDien_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btSearchDien_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        TrangChu tc = new TrangChu();

        private void ChisoDien_Load(object sender, EventArgs e)
        {

        }

        

        private void iconButton2_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemCSDien(), panel2);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaCSDien(), panel2);
        }
    }
}
