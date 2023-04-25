namespace PBL3___Motel_Management_System.View
{
    partial class SuaHoaDon
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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
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
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.dtpThangChiTra = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.txtTienDichVu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhongTro = new System.Windows.Forms.TextBox();
            this.txtTienPhongTro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
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
            this.iconButton2.TabIndex = 56;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(8, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 55;
            this.label7.Text = "SỬA HÓA ĐƠN";
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
            this.iconButton4.TabIndex = 57;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // panelThem
            // 
            this.panelThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelThem.Controls.Add(this.txtTienPhongTro);
            this.panelThem.Controls.Add(this.label4);
            this.panelThem.Controls.Add(this.txtPhongTro);
            this.panelThem.Controls.Add(this.label11);
            this.panelThem.Controls.Add(this.btnBoChon);
            this.panelThem.Controls.Add(this.btnChon);
            this.panelThem.Controls.Add(this.dgvDichVu);
            this.panelThem.Controls.Add(this.dtpNgayLap);
            this.panelThem.Controls.Add(this.cbbDayTro);
            this.panelThem.Controls.Add(this.dtpThangChiTra);
            this.panelThem.Controls.Add(this.label10);
            this.panelThem.Controls.Add(this.label1);
            this.panelThem.Controls.Add(this.txtGiamGia);
            this.panelThem.Controls.Add(this.txtTienPhong);
            this.panelThem.Controls.Add(this.txtTienDichVu);
            this.panelThem.Controls.Add(this.label8);
            this.panelThem.Controls.Add(this.label2);
            this.panelThem.Controls.Add(this.label3);
            this.panelThem.Controls.Add(this.label6);
            this.panelThem.Location = new System.Drawing.Point(10, 64);
            this.panelThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(668, 421);
            this.panelThem.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(336, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 100;
            this.label11.Text = "Giảm giá (%):";
            // 
            // btnBoChon
            // 
            this.btnBoChon.Location = new System.Drawing.Point(426, 157);
            this.btnBoChon.Name = "btnBoChon";
            this.btnBoChon.Size = new System.Drawing.Size(75, 23);
            this.btnBoChon.TabIndex = 99;
            this.btnBoChon.Text = "Bỏ chọn";
            this.btnBoChon.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(330, 157);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 98;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
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
            this.dgvDichVu.Location = new System.Drawing.Point(24, 186);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(626, 150);
            this.dgvDichVu.TabIndex = 97;
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
            this.dtpNgayLap.Location = new System.Drawing.Point(135, 131);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(170, 20);
            this.dtpNgayLap.TabIndex = 96;
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(133, -28);
            this.cbbDayTro.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(170, 25);
            this.cbbDayTro.TabIndex = 94;
            // 
            // dtpThangChiTra
            // 
            this.dtpThangChiTra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangChiTra.CustomFormat = "MM/yyyy";
            this.dtpThangChiTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangChiTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangChiTra.Location = new System.Drawing.Point(135, 75);
            this.dtpThangChiTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtpThangChiTra.Name = "dtpThangChiTra";
            this.dtpThangChiTra.ShowUpDown = true;
            this.dtpThangChiTra.Size = new System.Drawing.Size(170, 23);
            this.dtpThangChiTra.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 131);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 92;
            this.label10.Text = "Ngày lập:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Tiền dịch vụ:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(492, 125);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(158, 23);
            this.txtGiamGia.TabIndex = 90;
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhong.Location = new System.Drawing.Point(491, -27);
            this.txtTienPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.ReadOnly = true;
            this.txtTienPhong.Size = new System.Drawing.Size(158, 23);
            this.txtTienPhong.TabIndex = 89;
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDichVu.Location = new System.Drawing.Point(492, 76);
            this.txtTienDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.ReadOnly = true;
            this.txtTienDichVu.Size = new System.Drawing.Size(158, 23);
            this.txtTienDichVu.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 87;
            this.label8.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, -25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "Dãy:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, -25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Tiền phòng:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Phòng:";
            // 
            // txtPhongTro
            // 
            this.txtPhongTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongTro.Location = new System.Drawing.Point(135, 24);
            this.txtPhongTro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhongTro.Name = "txtPhongTro";
            this.txtPhongTro.ReadOnly = true;
            this.txtPhongTro.Size = new System.Drawing.Size(170, 23);
            this.txtPhongTro.TabIndex = 101;
            // 
            // txtTienPhongTro
            // 
            this.txtTienPhongTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhongTro.Location = new System.Drawing.Point(492, 25);
            this.txtTienPhongTro.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienPhongTro.Name = "txtTienPhongTro";
            this.txtTienPhongTro.ReadOnly = true;
            this.txtTienPhongTro.Size = new System.Drawing.Size(158, 23);
            this.txtTienPhongTro.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tiền phòng:";
            // 
            // SuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(686, 559);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.panelThem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SuaHoaDon";
            this.Text = "SuaHoaDon";
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panelThem;
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
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cbbDayTro;
        private System.Windows.Forms.DateTimePicker dtpThangChiTra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.TextBox txtTienDichVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhongTro;
        private System.Windows.Forms.TextBox txtTienPhongTro;
        private System.Windows.Forms.Label label4;
    }
}