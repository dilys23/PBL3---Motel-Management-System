﻿namespace PBL3___Motel_Management_System.View
{
    partial class ThemHoaDon
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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lbl = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panelThem = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBoChon = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbbPhongTro = new System.Windows.Forms.ComboBox();
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.dtpThangThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.txtTienDichVu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton2
            // 
            this.iconButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(586, 11);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(32, 30);
            this.iconButton2.TabIndex = 52;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Chocolate;
            this.lbl.Location = new System.Drawing.Point(8, 17);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(143, 23);
            this.lbl.TabIndex = 51;
            this.lbl.Text = "THÊM HÓA ĐƠN";
            // 
            // iconButton4
            // 
            this.iconButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconButton4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(622, 11);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(39, 30);
            this.iconButton4.TabIndex = 53;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // panelThem
            // 
            this.panelThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelThem.Controls.Add(this.label11);
            this.panelThem.Controls.Add(this.btnBoChon);
            this.panelThem.Controls.Add(this.btnChon);
            this.panelThem.Controls.Add(this.dgvDichVu);
            this.panelThem.Controls.Add(this.dtpNgayLap);
            this.panelThem.Controls.Add(this.cbbPhongTro);
            this.panelThem.Controls.Add(this.cbbDayTro);
            this.panelThem.Controls.Add(this.dtpThangThanhToan);
            this.panelThem.Controls.Add(this.label10);
            this.panelThem.Controls.Add(this.label1);
            this.panelThem.Controls.Add(this.txtGiamGia);
            this.panelThem.Controls.Add(this.txtTienPhong);
            this.panelThem.Controls.Add(this.txtTienDichVu);
            this.panelThem.Controls.Add(this.label8);
            this.panelThem.Controls.Add(this.label2);
            this.panelThem.Controls.Add(this.label3);
            this.panelThem.Controls.Add(this.label6);
            this.panelThem.Location = new System.Drawing.Point(10, 48);
            this.panelThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(668, 505);
            this.panelThem.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(335, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 83;
            this.label11.Text = "Giảm giá (%):";
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(424, 213);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(75, 23);
            this.btnBoChon.TabIndex = 82;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.UseVisualStyleBackColor = true;
            this.btnBoChon.Click += new System.EventHandler(this.btnBoChon_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(328, 213);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 81;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.TenDichVu,
            this.GiaDichVu,
            this.ChiSoCu,
            this.ChiSoMoi,
            this.ThanhTien,
            this.TinhTrang});
            this.dgvDichVu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDichVu.Location = new System.Drawing.Point(22, 242);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(626, 150);
            this.dgvDichVu.TabIndex = 80;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            this.Stt.Width = 125;
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên dịch vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.Width = 125;
            // 
            // GiaDichVu
            // 
            this.GiaDichVu.HeaderText = "Giá dịch vụ";
            this.GiaDichVu.MinimumWidth = 6;
            this.GiaDichVu.Name = "GiaDichVu";
            this.GiaDichVu.Width = 125;
            // 
            // ChiSoCu
            // 
            this.ChiSoCu.HeaderText = "Chỉ số cũ";
            this.ChiSoCu.MinimumWidth = 6;
            this.ChiSoCu.Name = "ChiSoCu";
            this.ChiSoCu.Width = 125;
            // 
            // ChiSoMoi
            // 
            this.ChiSoMoi.HeaderText = "Chỉ số mới";
            this.ChiSoMoi.MinimumWidth = 6;
            this.ChiSoMoi.Name = "ChiSoMoi";
            this.ChiSoMoi.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 125;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(133, 187);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(170, 20);
            this.dtpNgayLap.TabIndex = 79;
            // 
            // cbbPhongTro
            // 
            this.cbbPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongTro.FormattingEnabled = true;
            this.cbbPhongTro.Location = new System.Drawing.Point(133, 81);
            this.cbbPhongTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhongTro.Name = "cbbPhongTro";
            this.cbbPhongTro.Size = new System.Drawing.Size(170, 25);
            this.cbbPhongTro.TabIndex = 78;
            this.cbbPhongTro.SelectedIndexChanged += new System.EventHandler(this.cbbPhongTro_SelectedIndexChanged);
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(133, 38);
            this.cbbDayTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(170, 25);
            this.cbbDayTro.TabIndex = 77;
            this.cbbDayTro.SelectedIndexChanged += new System.EventHandler(this.cbbDayTro_SelectedIndexChanged);
            // 
            // dtpThangThanhToan
            // 
            this.dtpThangThanhToan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangThanhToan.CustomFormat = "MM/yyyy";
            this.dtpThangThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangThanhToan.Location = new System.Drawing.Point(133, 131);
            this.dtpThangThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpThangThanhToan.Name = "dtpThangThanhToan";
            this.dtpThangThanhToan.ShowUpDown = true;
            this.dtpThangThanhToan.Size = new System.Drawing.Size(170, 23);
            this.dtpThangThanhToan.TabIndex = 73;
            this.dtpThangThanhToan.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "Ngày lập:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tiền dịch vụ:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(491, 132);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(158, 23);
            this.txtGiamGia.TabIndex = 66;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhong.Location = new System.Drawing.Point(491, 39);
            this.txtTienPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(158, 23);
            this.txtTienPhong.TabIndex = 64;
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDichVu.Location = new System.Drawing.Point(491, 83);
            this.txtTienDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.ReadOnly = true;
            this.txtTienDichVu.Size = new System.Drawing.Size(158, 23);
            this.txtTienDichVu.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Dãy:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Tiền phòng:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Phòng:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(686, 564);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.panelThem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThemHoaDon";
            this.Text = "ThemHoaDon";
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lbl;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.DateTimePicker dtpThangThanhToan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.TextBox txtTienDichVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbPhongTro;
        private System.Windows.Forms.ComboBox cbbDayTro;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBoChon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}