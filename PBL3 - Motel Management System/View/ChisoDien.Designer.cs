namespace PBL3___Motel_Management_System.View
{
    partial class ChisoDien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThangSuDung = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvChiSoDien = new System.Windows.Forms.DataGridView();
            this.MaChiTietSuDungDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelChisoDien = new System.Windows.Forms.Panel();
            this.btnHuyXacThuc = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.cbbPhongTro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacThuc = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuaHD = new FontAwesome.Sharp.IconButton();
            this.btnThemHD = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoDien)).BeginInit();
            this.panelChisoDien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(207, 40);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(123, 28);
            this.cbbDayTro.TabIndex = 31;
            this.cbbDayTro.SelectedIndexChanged += new System.EventHandler(this.cbbDayTro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Dãy:";
            // 
            // dtpThangSuDung
            // 
            this.dtpThangSuDung.CustomFormat = "MM/yyyy";
            this.dtpThangSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangSuDung.Location = new System.Drawing.Point(53, 41);
            this.dtpThangSuDung.Name = "dtpThangSuDung";
            this.dtpThangSuDung.ShowUpDown = true;
            this.dtpThangSuDung.Size = new System.Drawing.Size(125, 27);
            this.dtpThangSuDung.TabIndex = 29;
            this.dtpThangSuDung.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thời gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "CHỈ SỐ ĐIỆN";
            // 
            // dgvChiSoDien
            // 
            this.dgvChiSoDien.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvChiSoDien.AllowUserToAddRows = false;
            this.dgvChiSoDien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiSoDien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiSoDien.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiSoDien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiSoDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiSoDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietSuDungDichVu,
            this.Stt,
            this.DayTro,
            this.PhongTro,
            this.ChiSoCu,
            this.ChiSoMoi,
            this.DaDung,
            this.NgayLap,
            this.Thang,
            this.TinhTrang,
            this.btnSua,
            this.btnXoa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiSoDien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiSoDien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChiSoDien.GridColor = System.Drawing.Color.LightCyan;
            this.dgvChiSoDien.Location = new System.Drawing.Point(17, 99);
            this.dgvChiSoDien.Name = "dgvChiSoDien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiSoDien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiSoDien.RowHeadersWidth = 60;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiSoDien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiSoDien.RowTemplate.Height = 24;
            this.dgvChiSoDien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiSoDien.Size = new System.Drawing.Size(993, 288);
            this.dgvChiSoDien.TabIndex = 8;
            this.dgvChiSoDien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiSoDien_CellContentClick);
            // 
            // MaChiTietSuDungDichVu
            // 
            this.MaChiTietSuDungDichVu.HeaderText = "MaChiTietSuDungDichVu";
            this.MaChiTietSuDungDichVu.MinimumWidth = 6;
            this.MaChiTietSuDungDichVu.Name = "MaChiTietSuDungDichVu";
            this.MaChiTietSuDungDichVu.Visible = false;
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
            // ChiSoCu
            // 
            this.ChiSoCu.HeaderText = "Chỉ số cũ";
            this.ChiSoCu.MinimumWidth = 6;
            this.ChiSoCu.Name = "ChiSoCu";
            // 
            // ChiSoMoi
            // 
            this.ChiSoMoi.HeaderText = "Chỉ số mới";
            this.ChiSoMoi.MinimumWidth = 6;
            this.ChiSoMoi.Name = "ChiSoMoi";
            // 
            // DaDung
            // 
            this.DaDung.HeaderText = "Đã dùng";
            this.DaDung.MinimumWidth = 6;
            this.DaDung.Name = "DaDung";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // Thang
            // 
            this.Thang.HeaderText = "Tháng sử dung";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
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
            // panelChisoDien
            // 
            this.panelChisoDien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChisoDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelChisoDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChisoDien.Controls.Add(this.btnHuyXacThuc);
            this.panelChisoDien.Controls.Add(this.label5);
            this.panelChisoDien.Controls.Add(this.cbbTinhTrang);
            this.panelChisoDien.Controls.Add(this.btnTimKiem);
            this.panelChisoDien.Controls.Add(this.cbbPhongTro);
            this.panelChisoDien.Controls.Add(this.label3);
            this.panelChisoDien.Controls.Add(this.btnXacThuc);
            this.panelChisoDien.Controls.Add(this.iconButton2);
            this.panelChisoDien.Controls.Add(this.dgvChiSoDien);
            this.panelChisoDien.Controls.Add(this.dtpThangSuDung);
            this.panelChisoDien.Controls.Add(this.label1);
            this.panelChisoDien.Controls.Add(this.cbbDayTro);
            this.panelChisoDien.Controls.Add(this.label2);
            this.panelChisoDien.Location = new System.Drawing.Point(12, 75);
            this.panelChisoDien.Name = "panelChisoDien";
            this.panelChisoDien.Size = new System.Drawing.Size(1023, 456);
            this.panelChisoDien.TabIndex = 27;
            // 
            // btnHuyXacThuc
            // 
            this.btnHuyXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnHuyXacThuc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuyXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.btnHuyXacThuc.IconColor = System.Drawing.Color.White;
            this.btnHuyXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyXacThuc.IconSize = 25;
            this.btnHuyXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyXacThuc.Location = new System.Drawing.Point(556, 395);
            this.btnHuyXacThuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyXacThuc.Name = "btnHuyXacThuc";
            this.btnHuyXacThuc.Size = new System.Drawing.Size(63, 37);
            this.btnHuyXacThuc.TabIndex = 68;
            this.btnHuyXacThuc.Text = "Hủy";
            this.btnHuyXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyXacThuc.UseVisualStyleBackColor = false;
            this.btnHuyXacThuc.Click += new System.EventHandler(this.btnHuyXacThuc_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tình trạng";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(490, 40);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(129, 28);
            this.cbbTinhTrang.TabIndex = 59;
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
            this.btnTimKiem.Location = new System.Drawing.Point(3, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(35, 35);
            this.btnTimKiem.TabIndex = 58;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbPhongTro
            // 
            this.cbbPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongTro.FormattingEnabled = true;
            this.cbbPhongTro.Location = new System.Drawing.Point(353, 41);
            this.cbbPhongTro.Name = "cbbPhongTro";
            this.cbbPhongTro.Size = new System.Drawing.Size(118, 28);
            this.cbbPhongTro.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Phòng:";
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXacThuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnXacThuc.IconColor = System.Drawing.Color.White;
            this.btnXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacThuc.IconSize = 25;
            this.btnXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacThuc.Location = new System.Drawing.Point(453, 393);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(98, 39);
            this.btnXacThuc.TabIndex = 55;
            this.btnXacThuc.Text = "Xác Thực";
            this.btnXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacThuc.UseVisualStyleBackColor = false;
            this.btnXacThuc.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.DarkOrange;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(931, 29);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(79, 39);
            this.iconButton2.TabIndex = 54;
            this.iconButton2.Text = "Thêm ";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 49);
            this.panel1.TabIndex = 26;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaHD.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.btnSuaHD.IconColor = System.Drawing.Color.White;
            this.btnSuaHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaHD.IconSize = 25;
            this.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.Location = new System.Drawing.Point(822, 27);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(74, 39);
            this.btnSuaHD.TabIndex = 55;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHD.UseVisualStyleBackColor = false;
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemHD.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnThemHD.IconColor = System.Drawing.Color.White;
            this.btnThemHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHD.IconSize = 25;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(726, 27);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(79, 39);
            this.btnThemHD.TabIndex = 54;
            this.btnThemHD.Text = "Thêm ";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.UseVisualStyleBackColor = false;
            // 
            // ChisoDien
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 619);
            this.Controls.Add(this.panelChisoDien);
            this.Controls.Add(this.panel1);
            this.Name = "ChisoDien";
            this.Text = "ElecNum";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoDien)).EndInit();
            this.panelChisoDien.ResumeLayout(false);
            this.panelChisoDien.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbDayTro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThangSuDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvChiSoDien;
        private System.Windows.Forms.Panel panelChisoDien;
        private System.Windows.Forms.Panel panel1;
#pragma warning disable CS0169 // The field 'ChisoDien.iconButton3' is never used
        private FontAwesome.Sharp.IconButton iconButton3;
#pragma warning restore CS0169 // The field 'ChisoDien.iconButton3' is never used
        private FontAwesome.Sharp.IconButton btnSuaHD;
        private FontAwesome.Sharp.IconButton btnThemHD;
        private FontAwesome.Sharp.IconButton btnXacThuc;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox cbbPhongTro;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private FontAwesome.Sharp.IconButton btnHuyXacThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietSuDungDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}