namespace PBL3___Motel_Management_System.View
{
    partial class DemoPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoPhong));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenDay = new System.Windows.Forms.TextBox();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnThemday = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panelBtnDay = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSuaDay = new FontAwesome.Sharp.IconButton();
            this.btnXoaDay = new FontAwesome.Sharp.IconButton();
            this.btnThemPhong = new FontAwesome.Sharp.IconButton();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.panelChinh = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnSuaDay);
            this.panel3.Controls.Add(this.txtTenDay);
            this.panel3.Controls.Add(this.cbbTinhTrang);
            this.panel3.Controls.Add(this.btnThemday);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.cbbDayTro);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1409, 163);
            this.panel3.TabIndex = 0;
            // 
            // txtTenDay
            // 
            this.txtTenDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDay.Location = new System.Drawing.Point(399, 105);
            this.txtTenDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDay.Name = "txtTenDay";
            this.txtTenDay.Size = new System.Drawing.Size(145, 30);
            this.txtTenDay.TabIndex = 47;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.DisplayMember = "Tình trạng";
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(212, 105);
            this.cbbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(148, 33);
            this.cbbTinhTrang.TabIndex = 46;
            // 
            // btnThemday
            // 
            this.btnThemday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemday.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            this.btnThemday.IconColor = System.Drawing.Color.White;
            this.btnThemday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemday.IconSize = 30;
            this.btnThemday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemday.Location = new System.Drawing.Point(1153, 98);
            this.btnThemday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemday.Name = "btnThemday";
            this.btnThemday.Size = new System.Drawing.Size(105, 41);
            this.btnThemday.TabIndex = 45;
            this.btnThemday.Tag = "Thêm dãy";
            this.btnThemday.Text = "Thêm dãy";
            this.btnThemday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemday.UseVisualStyleBackColor = false;
            this.btnThemday.Click += new System.EventHandler(this.btnThemday_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.Location = new System.Drawing.Point(583, 105);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(35, 34);
            this.btnTimKiem.TabIndex = 44;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(25, 105);
            this.cbbDayTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(148, 33);
            this.cbbDayTro.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 63);
            this.panel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 28);
            this.label7.TabIndex = 36;
            this.label7.Text = "DACH SÁCH PHÒNG";
            // 
            // panelBtnDay
            // 
            this.panelBtnDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtnDay.Location = new System.Drawing.Point(20, 180);
            this.panelBtnDay.Margin = new System.Windows.Forms.Padding(4);
            this.panelBtnDay.Name = "panelBtnDay";
            this.panelBtnDay.Size = new System.Drawing.Size(1397, 69);
            this.panelBtnDay.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panelPhong);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(8, 258);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1409, 467);
            this.panel4.TabIndex = 2;
            // 
            // panelPhong
            // 
            this.panelPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPhong.Location = new System.Drawing.Point(13, 71);
            this.panelPhong.Margin = new System.Windows.Forms.Padding(4);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panelPhong.Size = new System.Drawing.Size(1378, 374);
            this.panelPhong.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnXoaDay);
            this.panel5.Controls.Add(this.btnThemPhong);
            this.panel5.Controls.Add(this.lblDiaChi);
            this.panel5.Location = new System.Drawing.Point(12, 7);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1378, 56);
            this.panel5.TabIndex = 0;
            // 
            // btnSuaDay
            // 
            this.btnSuaDay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSuaDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaDay.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.btnSuaDay.IconColor = System.Drawing.Color.White;
            this.btnSuaDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaDay.IconSize = 25;
            this.btnSuaDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDay.Location = new System.Drawing.Point(1276, 98);
            this.btnSuaDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDay.Name = "btnSuaDay";
            this.btnSuaDay.Size = new System.Drawing.Size(69, 39);
            this.btnSuaDay.TabIndex = 59;
            this.btnSuaDay.Text = "Sửa";
            this.btnSuaDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDay.UseVisualStyleBackColor = false;
            this.btnSuaDay.Click += new System.EventHandler(this.btnSuaDay_Click);
            // 
            // btnXoaDay
            // 
            this.btnXoaDay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoaDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaDay.BackColor = System.Drawing.Color.Red;
            this.btnXoaDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDay.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaDay.IconColor = System.Drawing.Color.White;
            this.btnXoaDay.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnXoaDay.IconSize = 25;
            this.btnXoaDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDay.Location = new System.Drawing.Point(1298, 3);
            this.btnXoaDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaDay.Name = "btnXoaDay";
            this.btnXoaDay.Size = new System.Drawing.Size(72, 38);
            this.btnXoaDay.TabIndex = 58;
            this.btnXoaDay.Text = "Xóa";
            this.btnXoaDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDay.UseVisualStyleBackColor = false;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemPhong.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemPhong.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            this.btnThemPhong.IconColor = System.Drawing.Color.White;
            this.btnThemPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemPhong.IconSize = 25;
            this.btnThemPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemPhong.Location = new System.Drawing.Point(1215, 3);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(77, 39);
            this.btnThemPhong.TabIndex = 57;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemPhong.UseVisualStyleBackColor = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click_1);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Image = ((System.Drawing.Image)(resources.GetObject("lblDiaChi.Image")));
            this.lblDiaChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiaChi.Location = new System.Drawing.Point(13, 18);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(78, 20);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "     label1";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiaChi.Click += new System.EventHandler(this.lblDiaChi_Click);
            // 
            // panelChinh
            // 
            this.panelChinh.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelChinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChinh.Controls.Add(this.panel4);
            this.panelChinh.Controls.Add(this.panelBtnDay);
            this.panelChinh.Controls.Add(this.panel3);
            this.panelChinh.Location = new System.Drawing.Point(13, 13);
            this.panelChinh.Margin = new System.Windows.Forms.Padding(4);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(1427, 736);
            this.panelChinh.TabIndex = 43;
            // 
            // DemoPhong
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 752);
            this.Controls.Add(this.panelChinh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DemoPhong";
            this.Text = "DemoPhong";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelChinh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel panelBtnDay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel panelPhong;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnSuaDay;
        private FontAwesome.Sharp.IconButton btnXoaDay;
        private FontAwesome.Sharp.IconButton btnThemPhong;
        private System.Windows.Forms.Label lblDiaChi;
        public System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.TextBox txtTenDay;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private FontAwesome.Sharp.IconButton btnThemday;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.ComboBox cbbDayTro;
    }
}