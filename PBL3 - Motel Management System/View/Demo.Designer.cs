namespace PBL3___Motel_Management_System.View
{
    partial class Demo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTra = new FontAwesome.Sharp.IconButton();
            this.btnChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnChoThue = new FontAwesome.Sharp.IconButton();
            this.btnCoc = new FontAwesome.Sharp.IconButton();
            this.panelTenKhach = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTenPhongTro = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 320);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnTra);
            this.panel2.Controls.Add(this.btnChiTiet);
            this.panel2.Controls.Add(this.btnChoThue);
            this.panel2.Controls.Add(this.btnCoc);
            this.panel2.Controls.Add(this.panelTenKhach);
            this.panel2.Controls.Add(this.panelTenPhongTro);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 313);
            this.panel2.TabIndex = 0;
            // 
            // btnTra
            // 
            this.btnTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTra.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.btnTra.IconColor = System.Drawing.Color.White;
            this.btnTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTra.IconSize = 25;
            this.btnTra.Location = new System.Drawing.Point(216, 214);
            this.btnTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(47, 48);
            this.btnTra.TabIndex = 41;
            this.btnTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnTra, "Trả phòng");
            this.btnTra.UseVisualStyleBackColor = false;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChiTiet.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnChiTiet.IconColor = System.Drawing.Color.White;
            this.btnChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiTiet.IconSize = 25;
            this.btnChiTiet.Location = new System.Drawing.Point(145, 213);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(50, 47);
            this.btnChiTiet.TabIndex = 40;
            this.btnChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnChiTiet, "Chi tiết");
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnChoThue
            // 
            this.btnChoThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoThue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChoThue.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnChoThue.IconColor = System.Drawing.Color.White;
            this.btnChoThue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChoThue.IconSize = 30;
            this.btnChoThue.Location = new System.Drawing.Point(78, 214);
            this.btnChoThue.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoThue.Name = "btnChoThue";
            this.btnChoThue.Size = new System.Drawing.Size(49, 46);
            this.btnChoThue.TabIndex = 39;
            this.btnChoThue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnChoThue, "Cho thuê");
            this.btnChoThue.UseVisualStyleBackColor = false;
            // 
            // btnCoc
            // 
            this.btnCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoc.BackColor = System.Drawing.Color.Tomato;
            this.btnCoc.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            this.btnCoc.IconColor = System.Drawing.Color.White;
            this.btnCoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCoc.IconSize = 30;
            this.btnCoc.Location = new System.Drawing.Point(8, 212);
            this.btnCoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoc.Name = "btnCoc";
            this.btnCoc.Size = new System.Drawing.Size(53, 47);
            this.btnCoc.TabIndex = 38;
            this.btnCoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCoc, "Cọc Phòng");
            this.btnCoc.UseVisualStyleBackColor = false;
            this.btnCoc.Click += new System.EventHandler(this.btnCoc_Click);
            // 
            // panelTenKhach
            // 
            this.panelTenKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTenKhach.Location = new System.Drawing.Point(0, 41);
            this.panelTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.panelTenKhach.Name = "panelTenKhach";
            this.panelTenKhach.Size = new System.Drawing.Size(285, 139);
            this.panelTenKhach.TabIndex = 1;
            // 
            // panelTenPhongTro
            // 
            this.panelTenPhongTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTenPhongTro.Location = new System.Drawing.Point(0, 0);
            this.panelTenPhongTro.Margin = new System.Windows.Forms.Padding(4);
            this.panelTenPhongTro.Name = "panelTenPhongTro";
            this.panelTenPhongTro.Size = new System.Drawing.Size(285, 41);
            this.panelTenPhongTro.TabIndex = 0;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(293, 320);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Demo";
            this.Text = "Demo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelTenKhach;
        private System.Windows.Forms.Panel panelTenPhongTro;
        private FontAwesome.Sharp.IconButton btnCoc;
        private FontAwesome.Sharp.IconButton btnChoThue;
        private FontAwesome.Sharp.IconButton btnChiTiet;
        private FontAwesome.Sharp.IconButton btnTra;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}