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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
            this.btnSuaPhong = new FontAwesome.Sharp.IconButton();
            this.btnCoc = new FontAwesome.Sharp.IconButton();
            this.btnChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnTra = new FontAwesome.Sharp.IconButton();
            this.btnChoThue = new FontAwesome.Sharp.IconButton();
            this.panelTenKhach = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTenPhongTro = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnXoaPhong);
            this.panel2.Controls.Add(this.btnSuaPhong);
            this.panel2.Controls.Add(this.btnCoc);
            this.panel2.Controls.Add(this.btnChiTiet);
            this.panel2.Controls.Add(this.btnTra);
            this.panel2.Controls.Add(this.btnChoThue);
            this.panel2.Controls.Add(this.panelTenKhach);
            this.panel2.Controls.Add(this.panelTenPhongTro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 320);
            this.panel2.TabIndex = 1;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaPhong.BackColor = System.Drawing.Color.Red;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaPhong.IconColor = System.Drawing.Color.White;
            this.btnXoaPhong.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnXoaPhong.IconSize = 25;
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(103, 245);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(78, 38);
            this.btnXoaPhong.TabIndex = 56;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnXoaPhong, "Xóa Phòng");
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSuaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhong.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnSuaPhong.IconColor = System.Drawing.Color.White;
            this.btnSuaPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaPhong.IconSize = 25;
            this.btnSuaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaPhong.Location = new System.Drawing.Point(20, 245);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(77, 39);
            this.btnSuaPhong.TabIndex = 55;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSuaPhong, "Sửa Dịch Vụ");
            this.btnSuaPhong.UseVisualStyleBackColor = false;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnCoc
            // 
            this.btnCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoc.BackColor = System.Drawing.Color.Tomato;
            this.btnCoc.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            this.btnCoc.IconColor = System.Drawing.Color.White;
            this.btnCoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCoc.IconSize = 30;
            this.btnCoc.Location = new System.Drawing.Point(20, 173);
            this.btnCoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCoc.Name = "btnCoc";
            this.btnCoc.Size = new System.Drawing.Size(40, 40);
            this.btnCoc.TabIndex = 38;
            this.btnCoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCoc, "Cọc phòng");
            this.btnCoc.UseVisualStyleBackColor = false;
            this.btnCoc.Click += new System.EventHandler(this.btnCoc_Click_1);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChiTiet.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnChiTiet.IconColor = System.Drawing.Color.White;
            this.btnChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiTiet.IconSize = 25;
            this.btnChiTiet.Location = new System.Drawing.Point(116, 173);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(40, 40);
            this.btnChiTiet.TabIndex = 40;
            this.btnChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnChiTiet, "Chi tiết");
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click_1);
            // 
            // btnTra
            // 
            this.btnTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTra.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.btnTra.IconColor = System.Drawing.Color.White;
            this.btnTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTra.IconSize = 25;
            this.btnTra.Location = new System.Drawing.Point(164, 173);
            this.btnTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(40, 40);
            this.btnTra.TabIndex = 41;
            this.btnTra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnTra, "Trả Phòng");
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnChoThue
            // 
            this.btnChoThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoThue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnChoThue.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnChoThue.IconColor = System.Drawing.Color.White;
            this.btnChoThue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChoThue.IconSize = 30;
            this.btnChoThue.Location = new System.Drawing.Point(68, 173);
            this.btnChoThue.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoThue.Name = "btnChoThue";
            this.btnChoThue.Size = new System.Drawing.Size(40, 40);
            this.btnChoThue.TabIndex = 39;
            this.btnChoThue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnChoThue, "Cho Thuê");
            this.btnChoThue.UseVisualStyleBackColor = false;
            this.btnChoThue.Click += new System.EventHandler(this.btnChoThue_Click);
            // 
            // panelTenKhach
            // 
            this.panelTenKhach.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTenKhach.Location = new System.Drawing.Point(5, 60);
            this.panelTenKhach.Margin = new System.Windows.Forms.Padding(4);
            this.panelTenKhach.Name = "panelTenKhach";
            this.panelTenKhach.Size = new System.Drawing.Size(282, 109);
            this.panelTenKhach.TabIndex = 1;
            // 
            // panelTenPhongTro
            // 
            this.panelTenPhongTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTenPhongTro.Location = new System.Drawing.Point(0, 0);
            this.panelTenPhongTro.Margin = new System.Windows.Forms.Padding(4);
            this.panelTenPhongTro.Name = "panelTenPhongTro";
            this.panelTenPhongTro.Size = new System.Drawing.Size(293, 52);
            this.panelTenPhongTro.TabIndex = 0;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(293, 320);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Demo";
            this.Text = "Demo";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCoc;
        private FontAwesome.Sharp.IconButton btnChiTiet;
        private FontAwesome.Sharp.IconButton btnChoThue;
        private System.Windows.Forms.FlowLayoutPanel panelTenKhach;
        private System.Windows.Forms.Panel panelTenPhongTro;
        private FontAwesome.Sharp.IconButton btnXoaPhong;
        private FontAwesome.Sharp.IconButton btnSuaPhong;
        private System.Windows.Forms.ToolTip toolTip1;
        public FontAwesome.Sharp.IconButton btnTra;
    }
}