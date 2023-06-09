namespace PBL3___Motel_Management_System
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.panelLogin = new System.Windows.Forms.Panel();
           this.btnChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMaximized = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXemMK = new FontAwesome.Sharp.IconButton();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.btnXemMK);
            this.panelLogin.Controls.Add(this.btnChiTiet);
            this.panelLogin.Controls.Add(this.btnDangNhap);
            this.panelLogin.Controls.Add(this.txtMatKhau);
            this.panelLogin.Controls.Add(this.txtTaiKhoan);
            this.panelLogin.Controls.Add(this.btnMinimized);
            this.panelLogin.Controls.Add(this.btnExit);
            this.panelLogin.Controls.Add(this.btnMaximized);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Location = new System.Drawing.Point(3, 1);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1231, 775);
            this.panelLogin.TabIndex = 0;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiTiet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnChiTiet.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnChiTiet.IconColor = System.Drawing.Color.Teal;
            this.btnChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiTiet.IconSize = 25;
            this.btnChiTiet.Location = new System.Drawing.Point(378, 477);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(33, 34);
            this.btnChiTiet.TabIndex = 45;
            this.btnChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click_1);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightBlue;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDangNhap.Location = new System.Drawing.Point(104, 552);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(254, 42);
            this.btnDangNhap.TabIndex = 45;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(104, 477);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(254, 31);
            this.txtMatKhau.TabIndex = 7;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(104, 360);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(254, 31);
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackColor = System.Drawing.Color.White;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimized.IconColor = System.Drawing.Color.DarkCyan;
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 30;
            this.btnMinimized.Location = new System.Drawing.Point(1126, -1);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 31);
            this.btnMinimized.TabIndex = 47;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.Location = new System.Drawing.Point(1198, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 31);
            this.btnExit.TabIndex = 46;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackColor = System.Drawing.Color.White;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnMaximized.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.IconSize = 30;
            this.btnMaximized.Location = new System.Drawing.Point(1162, 0);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(30, 31);
            this.btnMaximized.TabIndex = 45;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1231, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnXemMK
            // 
            this.btnXemMK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemMK.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnXemMK.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnXemMK.IconColor = System.Drawing.Color.DarkCyan;
            this.btnXemMK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemMK.IconSize = 25;
            this.btnXemMK.Location = new System.Drawing.Point(378, 473);
            this.btnXemMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemMK.Name = "btnXemMK";
            this.btnXemMK.Size = new System.Drawing.Size(33, 35);
            this.btnXemMK.TabIndex = 48;
            this.btnXemMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemMK.UseVisualStyleBackColor = false;
            this.btnXemMK.Click += new System.EventHandler(this.btnXemMK_Click);
            // 
            // Dangnhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 776);
            this.ControlBox = false;
            this.Controls.Add(this.panelLogin);
            this.Name = "Dangnhap";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private FontAwesome.Sharp.IconButton btnChiTiet;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private FontAwesome.Sharp.IconButton btnXemMK;
    }
}

