namespace PBL3___Motel_Management_System
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMaximized = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.paneMenu = new System.Windows.Forms.Panel();
            this.btnThietbi = new FontAwesome.Sharp.IconButton();
            this.btnDay = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnDoanhTHu = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnHopDong = new FontAwesome.Sharp.IconButton();
            this.btnNuoc = new FontAwesome.Sharp.IconButton();
            this.btnTrangchu = new FontAwesome.Sharp.IconButton();
            this.btnDien = new FontAwesome.Sharp.IconButton();
            this.btnDichVu = new FontAwesome.Sharp.IconButton();
            this.btnPhong = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnTK = new FontAwesome.Sharp.IconButton();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.TenPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tendaytro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDichvu = new System.Windows.Forms.DataGridView();
            this.GiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.taiKhoan1 = new PBL3___Motel_Management_System.View.TaiKhoan();
            this.panelTitle.SuspendLayout();
            this.paneMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.panelTitle.Controls.Add(this.btnTK);
            this.panelTitle.Controls.Add(this.btnMinimized);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Controls.Add(this.btnMaximized);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1138, 83);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimized.IconColor = System.Drawing.Color.LightCyan;
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 30;
            this.btnMinimized.Location = new System.Drawing.Point(1032, 7);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 31);
            this.btnMinimized.TabIndex = 3;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1104, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnMaximized.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.IconSize = 30;
            this.btnMaximized.Location = new System.Drawing.Point(1068, 7);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(30, 31);
            this.btnMaximized.TabIndex = 1;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(139)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DREAM \r\nHOUSE";
            // 
            // paneMenu
            // 
            this.paneMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.paneMenu.Controls.Add(this.btnThietbi);
            this.paneMenu.Controls.Add(this.btnDay);
            this.paneMenu.Controls.Add(this.btnLogout);
            this.paneMenu.Controls.Add(this.btnDoanhTHu);
            this.paneMenu.Controls.Add(this.btnHoaDon);
            this.paneMenu.Controls.Add(this.btnHopDong);
            this.paneMenu.Controls.Add(this.btnNuoc);
            this.paneMenu.Controls.Add(this.btnTrangchu);
            this.paneMenu.Controls.Add(this.btnDien);
            this.paneMenu.Controls.Add(this.btnDichVu);
            this.paneMenu.Controls.Add(this.btnPhong);
            this.paneMenu.Controls.Add(this.panel1);
            this.paneMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneMenu.Location = new System.Drawing.Point(0, 0);
            this.paneMenu.Name = "paneMenu";
            this.paneMenu.Size = new System.Drawing.Size(200, 749);
            this.paneMenu.TabIndex = 3;
            this.paneMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.paneMenu_Paint);
            // 
            // btnThietbi
            // 
            this.btnThietbi.FlatAppearance.BorderSize = 0;
            this.btnThietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThietbi.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnThietbi.IconColor = System.Drawing.Color.SteelBlue;
            this.btnThietbi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThietbi.IconSize = 35;
            this.btnThietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThietbi.Location = new System.Drawing.Point(8, 408);
            this.btnThietbi.Name = "btnThietbi";
            this.btnThietbi.Size = new System.Drawing.Size(186, 41);
            this.btnThietbi.TabIndex = 19;
            this.btnThietbi.Tag = "Thiết bị ";
            this.btnThietbi.Text = "Thiết bị ";
            this.btnThietbi.UseVisualStyleBackColor = true;
            this.btnThietbi.Click += new System.EventHandler(this.btnThietbi_Click);
            // 
            // btnDay
            // 
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnDay.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDay.IconSize = 35;
            this.btnDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDay.Location = new System.Drawing.Point(8, 134);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(186, 41);
            this.btnDay.TabIndex = 18;
            this.btnDay.Tag = "Dãy";
            this.btnDay.Text = "Dãy";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            this.btnLogout.IconColor = System.Drawing.Color.CadetBlue;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(8, 692);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(45, 45);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDoanhTHu
            // 
            this.btnDoanhTHu.FlatAppearance.BorderSize = 0;
            this.btnDoanhTHu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhTHu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhTHu.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnDoanhTHu.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDoanhTHu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoanhTHu.IconSize = 35;
            this.btnDoanhTHu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhTHu.Location = new System.Drawing.Point(8, 583);
            this.btnDoanhTHu.Name = "btnDoanhTHu";
            this.btnDoanhTHu.Size = new System.Drawing.Size(186, 41);
            this.btnDoanhTHu.TabIndex = 13;
            this.btnDoanhTHu.Tag = "Doanh Thu";
            this.btnDoanhTHu.Text = "   Doanh thu";
            this.btnDoanhTHu.UseVisualStyleBackColor = true;
            this.btnDoanhTHu.Click += new System.EventHandler(this.btnDoanhTHu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnHoaDon.IconColor = System.Drawing.Color.SteelBlue;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.IconSize = 35;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(8, 530);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(186, 41);
            this.btnHoaDon.TabIndex = 12;
            this.btnHoaDon.Tag = "Hoá Đơn";
            this.btnHoaDon.Text = "   Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnHopDong
            // 
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnHopDong.IconColor = System.Drawing.Color.SteelBlue;
            this.btnHopDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHopDong.IconSize = 35;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.Location = new System.Drawing.Point(8, 465);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(186, 41);
            this.btnHopDong.TabIndex = 11;
            this.btnHopDong.Tag = "Hợp đồng";
            this.btnHopDong.Text = "   Hợp đồng";
            this.btnHopDong.UseVisualStyleBackColor = true;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // btnNuoc
            // 
            this.btnNuoc.FlatAppearance.BorderSize = 0;
            this.btnNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.IconChar = FontAwesome.Sharp.IconChar.Droplet;
            this.btnNuoc.IconColor = System.Drawing.Color.SteelBlue;
            this.btnNuoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuoc.IconSize = 35;
            this.btnNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuoc.Location = new System.Drawing.Point(8, 352);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(186, 41);
            this.btnNuoc.TabIndex = 10;
            this.btnNuoc.Tag = "Chỉ số nước";
            this.btnNuoc.Text = "  Chỉ số nước";
            this.btnNuoc.UseVisualStyleBackColor = true;
            this.btnNuoc.Click += new System.EventHandler(this.btnNuoc_Click);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.FlatAppearance.BorderSize = 0;
            this.btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangchu.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btnTrangchu.IconColor = System.Drawing.Color.SteelBlue;
            this.btnTrangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangchu.IconSize = 35;
            this.btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangchu.Location = new System.Drawing.Point(8, 90);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(186, 41);
            this.btnTrangchu.TabIndex = 7;
            this.btnTrangchu.Tag = "Trang Chủ ";
            this.btnTrangchu.Text = "Trang Chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // btnDien
            // 
            this.btnDien.FlatAppearance.BorderSize = 0;
            this.btnDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDien.IconChar = FontAwesome.Sharp.IconChar.Bolt;
            this.btnDien.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDien.IconSize = 35;
            this.btnDien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDien.Location = new System.Drawing.Point(8, 293);
            this.btnDien.Name = "btnDien";
            this.btnDien.Size = new System.Drawing.Size(182, 41);
            this.btnDien.TabIndex = 9;
            this.btnDien.Tag = "Chỉ số điện ";
            this.btnDien.Text = "  Chỉ số điện ";
            this.btnDien.UseVisualStyleBackColor = true;
            this.btnDien.Click += new System.EventHandler(this.btnDien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.IconChar = FontAwesome.Sharp.IconChar.Blog;
            this.btnDichVu.IconColor = System.Drawing.Color.SteelBlue;
            this.btnDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDichVu.IconSize = 35;
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.Location = new System.Drawing.Point(8, 233);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(186, 41);
            this.btnDichVu.TabIndex = 8;
            this.btnDichVu.Tag = "Dịch Vụ ";
            this.btnDichVu.Text = "Dịch Vụ ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnPhong.IconColor = System.Drawing.Color.SteelBlue;
            this.btnPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPhong.IconSize = 35;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(8, 181);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(186, 41);
            this.btnPhong.TabIndex = 6;
            this.btnPhong.Tag = "Phòng";
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.iconButton10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(229)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 86);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.btnMenu.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 40;
            this.btnMenu.Location = new System.Drawing.Point(124, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(72, 67);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTK
            // 
            this.btnTK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTK.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnTK.IconColor = System.Drawing.Color.DarkCyan;
            this.btnTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTK.IconSize = 25;
            this.btnTK.Location = new System.Drawing.Point(1081, 44);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(45, 39);
            this.btnTK.TabIndex = 4;
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tendaytro,
            this.TenPhongTro});
            this.dgvPhong.Location = new System.Drawing.Point(14, 254);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(402, 207);
            this.dgvPhong.TabIndex = 13;
            // 
            // TenPhongTro
            // 
            this.TenPhongTro.HeaderText = "Phòng";
            this.TenPhongTro.MinimumWidth = 6;
            this.TenPhongTro.Name = "TenPhongTro";
            // 
            // Tendaytro
            // 
            this.Tendaytro.HeaderText = "Tên dãy trọ";
            this.Tendaytro.MinimumWidth = 6;
            this.Tendaytro.Name = "Tendaytro";
            // 
            // dgvDichvu
            // 
            this.dgvDichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichvu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDichVu,
            this.GiaDichVu});
            this.dgvDichvu.Location = new System.Drawing.Point(443, 256);
            this.dgvDichvu.Name = "dgvDichvu";
            this.dgvDichvu.RowHeadersWidth = 51;
            this.dgvDichvu.RowTemplate.Height = 24;
            this.dgvDichvu.Size = new System.Drawing.Size(402, 207);
            this.dgvDichvu.TabIndex = 14;
            // 
            // GiaDichVu
            // 
            this.GiaDichVu.HeaderText = "Giá";
            this.GiaDichVu.MinimumWidth = 6;
            this.GiaDichVu.Name = "GiaDichVu";
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(11, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách phòng trống:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(440, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dịch vụ:";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelDesktop.Controls.Add(this.taiKhoan1);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.dgvDichvu);
            this.panelDesktop.Controls.Add(this.dgvPhong);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 83);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1138, 666);
            this.panelDesktop.TabIndex = 5;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // taiKhoan1
            // 
            this.taiKhoan1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taiKhoan1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.taiKhoan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taiKhoan1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.taiKhoan1.Location = new System.Drawing.Point(912, 6);
            this.taiKhoan1.Name = "taiKhoan1";
            this.taiKhoan1.Size = new System.Drawing.Size(214, 344);
            this.taiKhoan1.TabIndex = 5;
            this.taiKhoan1.Visible = false;
            // 
            // TrangChu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1338, 749);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.paneMenu);
            this.Name = "TrangChu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Menu1_Load);
            this.Resize += new System.EventHandler(this.Menu1_Resize);
            this.panelTitle.ResumeLayout(false);
            this.paneMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichvu)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel paneMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnHopDong;
        private FontAwesome.Sharp.IconButton btnNuoc;
        private FontAwesome.Sharp.IconButton btnTrangchu;
        private FontAwesome.Sharp.IconButton btnDien;
        private FontAwesome.Sharp.IconButton btnDichVu;
        private FontAwesome.Sharp.IconButton btnPhong;
        private FontAwesome.Sharp.IconButton btnDoanhTHu;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnDay;
        private FontAwesome.Sharp.IconButton btnThietbi;
        private FontAwesome.Sharp.IconButton btnTK;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tendaytro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongTro;
        private System.Windows.Forms.DataGridView dgvDichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDichVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDesktop;
        private View.TaiKhoan taiKhoan1;
    }
}