namespace PBL3___Motel_Management_System.View
{
    partial class TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThongtin = new FontAwesome.Sharp.IconButton();
            this.btnDoiMK = new FontAwesome.Sharp.IconButton();
            this.btnDangxuat = new FontAwesome.Sharp.IconButton();
            this.ptcAnh = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptcAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(25, 166);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(156, 22);
            this.txtTen.TabIndex = 1;
            // 
            // btnThongtin
            // 
            this.btnThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongtin.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnThongtin.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            this.btnThongtin.IconColor = System.Drawing.Color.DarkCyan;
            this.btnThongtin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongtin.IconSize = 30;
            this.btnThongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongtin.Location = new System.Drawing.Point(25, 204);
            this.btnThongtin.Name = "btnThongtin";
            this.btnThongtin.Size = new System.Drawing.Size(156, 32);
            this.btnThongtin.TabIndex = 2;
            this.btnThongtin.Text = "   Thông tin";
            this.btnThongtin.UseVisualStyleBackColor = true;
            this.btnThongtin.Click += new System.EventHandler(this.btnThongtin_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDoiMK.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnDoiMK.IconColor = System.Drawing.Color.DarkCyan;
            this.btnDoiMK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoiMK.IconSize = 30;
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(25, 246);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(156, 32);
            this.btnDoiMK.TabIndex = 3;
            this.btnDoiMK.Text = "     Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDangxuat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnDangxuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDangxuat.IconColor = System.Drawing.Color.DarkCyan;
            this.btnDangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangxuat.IconSize = 30;
            this.btnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Location = new System.Drawing.Point(25, 288);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(156, 32);
            this.btnDangxuat.TabIndex = 4;
            this.btnDangxuat.Text = "   Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // ptcAnh
            // 
            this.ptcAnh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptcAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptcAnh.Image = ((System.Drawing.Image)(resources.GetObject("ptcAnh.Image")));
            this.ptcAnh.Location = new System.Drawing.Point(57, 32);
            this.ptcAnh.Name = "ptcAnh";
            this.ptcAnh.Size = new System.Drawing.Size(94, 115);
            this.ptcAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcAnh.TabIndex = 6;
            this.ptcAnh.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 103);
            this.panel1.TabIndex = 7;
            // 
            // TaiKhoan
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptcAnh);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnThongtin);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.panel1);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(212, 344);
            ((System.ComponentModel.ISupportInitialize)(this.ptcAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen;
        private FontAwesome.Sharp.IconButton btnThongtin;
        private FontAwesome.Sharp.IconButton btnDoiMK;
        private FontAwesome.Sharp.IconButton btnDangxuat;
        private System.Windows.Forms.PictureBox ptcAnh;
        private System.Windows.Forms.Panel panel1;
    }
}
