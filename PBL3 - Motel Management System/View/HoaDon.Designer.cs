﻿namespace PBL3___Motel_Management_System
{
    partial class Hoadon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPhongTro = new System.Windows.Forms.ComboBox();
            this.panelHD = new System.Windows.Forms.Panel();
            this.btnThanhToan = new FontAwesome.Sharp.IconButton();
            this.dtpThangSuDung = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnBoXacThuc = new FontAwesome.Sharp.IconButton();
            this.btnXacThuc = new FontAwesome.Sharp.IconButton();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThangChiTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.btnThemHoaDon = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 40);
            this.panel1.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "HÓA ĐƠN";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTim.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 25;
            this.btnTim.Location = new System.Drawing.Point(14, 34);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(26, 28);
            this.btnTim.TabIndex = 47;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Dãy";
            // 
            // cbbPhongTro
            // 
            this.cbbPhongTro.DisplayMember = "Tình trạng";
            this.cbbPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongTro.FormattingEnabled = true;
            this.cbbPhongTro.Location = new System.Drawing.Point(267, 35);
            this.cbbPhongTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbPhongTro.Name = "cbbPhongTro";
            this.cbbPhongTro.Size = new System.Drawing.Size(112, 25);
            this.cbbPhongTro.TabIndex = 44;
            // 
            // panelHD
            // 
            this.panelHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHD.Controls.Add(this.btnThanhToan);
            this.panelHD.Controls.Add(this.dtpThangSuDung);
            this.panelHD.Controls.Add(this.label5);
            this.panelHD.Controls.Add(this.label3);
            this.panelHD.Controls.Add(this.cbbTinhTrang);
            this.panelHD.Controls.Add(this.btnBoXacThuc);
            this.panelHD.Controls.Add(this.btnXacThuc);
            this.panelHD.Controls.Add(this.dgvHoaDon);
            this.panelHD.Controls.Add(this.btnTim);
            this.panelHD.Controls.Add(this.cbbDayTro);
            this.panelHD.Controls.Add(this.cbbPhongTro);
            this.panelHD.Controls.Add(this.label1);
            this.panelHD.Controls.Add(this.label2);
            this.panelHD.Controls.Add(this.btnThemHoaDon);
            this.panelHD.Location = new System.Drawing.Point(9, 53);
            this.panelHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHD.Name = "panelHD";
            this.panelHD.Size = new System.Drawing.Size(864, 448);
            this.panelHD.TabIndex = 43;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThanhToan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnThanhToan.IconColor = System.Drawing.Color.White;
            this.btnThanhToan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThanhToan.IconSize = 25;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(523, 30);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(84, 31);
            this.btnThanhToan.TabIndex = 70;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dtpThangSuDung
            // 
            this.dtpThangSuDung.CustomFormat = "MM/yyyy";
            this.dtpThangSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangSuDung.Location = new System.Drawing.Point(45, 36);
            this.dtpThangSuDung.Name = "dtpThangSuDung";
            this.dtpThangSuDung.ShowUpDown = true;
            this.dtpThangSuDung.Size = new System.Drawing.Size(101, 23);
            this.dtpThangSuDung.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Thời gian:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tình trạng";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.DisplayMember = "Tình trạng";
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(383, 35);
            this.cbbTinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(112, 25);
            this.cbbTinhTrang.TabIndex = 66;
            // 
            // btnBoXacThuc
            // 
            this.btnBoXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBoXacThuc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBoXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.btnBoXacThuc.IconColor = System.Drawing.Color.White;
            this.btnBoXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBoXacThuc.IconSize = 25;
            this.btnBoXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoXacThuc.Location = new System.Drawing.Point(698, 29);
            this.btnBoXacThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoXacThuc.Name = "btnBoXacThuc";
            this.btnBoXacThuc.Size = new System.Drawing.Size(85, 31);
            this.btnBoXacThuc.TabIndex = 65;
            this.btnBoXacThuc.Text = "Bỏ xác thực";
            this.btnBoXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoXacThuc.UseVisualStyleBackColor = false;
            this.btnBoXacThuc.Click += new System.EventHandler(this.btnBoXacThuc_Click);
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXacThuc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnXacThuc.IconColor = System.Drawing.Color.White;
            this.btnXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacThuc.IconSize = 25;
            this.btnXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacThuc.Location = new System.Drawing.Point(618, 29);
            this.btnXacThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(74, 31);
            this.btnXacThuc.TabIndex = 64;
            this.btnXacThuc.Text = "Xác Thực";
            this.btnXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacThuc.UseVisualStyleBackColor = false;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.Stt,
            this.DayTro,
            this.PhongTro,
            this.NgayTao,
            this.ThangChiTra,
            this.TongTien,
            this.TinhTrang,
            this.DaThanhToan,
            this.ConNo,
            this.btnSua,
            this.btnXoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHoaDon.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHoaDon.Location = new System.Drawing.Point(13, 88);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(838, 181);
            this.dgvHoaDon.TabIndex = 8;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick_1);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "MaHoaDon";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Visible = false;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // DayTro
            // 
            this.DayTro.HeaderText = "Dãy trọ";
            this.DayTro.MinimumWidth = 6;
            this.DayTro.Name = "DayTro";
            // 
            // PhongTro
            // 
            this.PhongTro.HeaderText = "Phòng trọ";
            this.PhongTro.MinimumWidth = 6;
            this.PhongTro.Name = "PhongTro";
            // 
            // NgayTao
            // 
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            // 
            // ThangChiTra
            // 
            this.ThangChiTra.HeaderText = "Tháng chi trả";
            this.ThangChiTra.MinimumWidth = 6;
            this.ThangChiTra.Name = "ThangChiTra";
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.HeaderText = "Đã thanh toán";
            this.DaThanhToan.MinimumWidth = 6;
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ConNo
            // 
            this.ConNo.HeaderText = "Còn Nợ";
            this.ConNo.MinimumWidth = 6;
            this.ConNo.Name = "ConNo";
            // 
            // btnSua
            // 
            this.btnSua.HeaderText = "";
            this.btnSua.MinimumWidth = 6;
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(151, 34);
            this.cbbDayTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(112, 25);
            this.cbbDayTro.TabIndex = 42;
            this.cbbDayTro.SelectedIndexChanged += new System.EventHandler(this.cbbDayTro_SelectedIndexChanged);
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHoaDon.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHoaDon.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnThemHoaDon.IconColor = System.Drawing.Color.White;
            this.btnThemHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHoaDon.IconSize = 25;
            this.btnThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHoaDon.Location = new System.Drawing.Point(791, 29);
            this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(69, 31);
            this.btnThemHoaDon.TabIndex = 21;
            this.btnThemHoaDon.Text = "Thêm ";
            this.btnThemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHoaDon.UseVisualStyleBackColor = false;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 520);
            this.Controls.Add(this.panelHD);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Hoadon";
            this.Text = "Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelHD.ResumeLayout(false);
            this.panelHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPhongTro;
        private System.Windows.Forms.Panel panelHD;
        private FontAwesome.Sharp.IconButton btnThemHoaDon;
        private System.Windows.Forms.ComboBox cbbDayTro;
        private FontAwesome.Sharp.IconButton btnBoXacThuc;
        private FontAwesome.Sharp.IconButton btnXacThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.DateTimePicker dtpThangSuDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private FontAwesome.Sharp.IconButton btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThangChiTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConNo;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}