using System;
using System.Drawing;

namespace PBL3___Motel_Management_System.View
{
    partial class ChuTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuTro));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemAnh = new FontAwesome.Sharp.IconButton();
            this.rdbtnNu = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdbtnNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.panelKhach = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ptAnh = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelKhach.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 28);
            this.label8.TabIndex = 47;
            this.label8.Text = "THÔNG TIN CHỦ TRỌ ";
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemAnh.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnThemAnh.IconColor = System.Drawing.Color.Bisque;
            this.btnThemAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemAnh.IconSize = 25;
            this.btnThemAnh.Location = new System.Drawing.Point(244, 299);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(35, 35);
            this.btnThemAnh.TabIndex = 30;
            this.btnThemAnh.UseVisualStyleBackColor = false;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // rdbtnNu
            // 
            this.rdbtnNu.AutoSize = true;
            this.rdbtnNu.Enabled = false;
            this.rdbtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNu.Location = new System.Drawing.Point(368, 337);
            this.rdbtnNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnNu.Name = "rdbtnNu";
            this.rdbtnNu.Size = new System.Drawing.Size(51, 24);
            this.rdbtnNu.TabIndex = 28;
            this.rdbtnNu.TabStop = true;
            this.rdbtnNu.Text = "Nữ";
            this.rdbtnNu.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(252, 105);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(206, 27);
            this.dtpNgaySinh.TabIndex = 27;
            // 
            // rdbtnNam
            // 
            this.rdbtnNam.AutoSize = true;
            this.rdbtnNam.Enabled = false;
            this.rdbtnNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNam.Location = new System.Drawing.Point(280, 337);
            this.rdbtnNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnNam.Name = "rdbtnNam";
            this.rdbtnNam.Size = new System.Drawing.Size(64, 24);
            this.rdbtnNam.TabIndex = 26;
            this.rdbtnNam.TabStop = true;
            this.rdbtnNam.Text = "Nam";
            this.rdbtnNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(252, 270);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(206, 27);
            this.txtDiaChi.TabIndex = 25;
            // 
            // txtSdt
            // 
            this.txtSdt.Enabled = false;
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(252, 215);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(206, 27);
            this.txtSdt.TabIndex = 24;
            // 
            // panelKhach
            // 
            this.panelKhach.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKhach.Controls.Add(this.panel1);
            this.panelKhach.Controls.Add(this.label8);
            this.panelKhach.Location = new System.Drawing.Point(9, 2);
            this.panelKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKhach.Name = "panelKhach";
            this.panelKhach.Size = new System.Drawing.Size(1153, 611);
            this.panelKhach.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnThemAnh);
            this.panel1.Controls.Add(this.ptAnh);
            this.panel1.Location = new System.Drawing.Point(15, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 531);
            this.panel1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(56, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.txtTen);
            this.panel2.Controls.Add(this.txtCccd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rdbtnNu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpNgaySinh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rdbtnNam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSdt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(361, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 444);
            this.panel2.TabIndex = 32;
            // 
            // btnSua
            // 
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnSua.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.Location = new System.Drawing.Point(548, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(35, 35);
            this.btnSua.TabIndex = 35;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(252, 50);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(206, 27);
            this.txtTen.TabIndex = 15;
            // 
            // txtCccd
            // 
            this.txtCccd.Enabled = false;
            this.txtCccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCccd.Location = new System.Drawing.Point(252, 160);
            this.txtCccd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(206, 27);
            this.txtCccd.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Họ và Tên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số điện thoại ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Giới tính";
            // 
            // ptAnh
            // 
            this.ptAnh.Image = ((System.Drawing.Image)(resources.GetObject("ptAnh.Image")));
            this.ptAnh.Location = new System.Drawing.Point(34, 71);
            this.ptAnh.Name = "ptAnh";
            this.ptAnh.Size = new System.Drawing.Size(245, 240);
            this.ptAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptAnh.TabIndex = 31;
            this.ptAnh.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(57, 348);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 33;
            this.Username.Text = "Username";
            // 
            // ChuTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 616);
            this.Controls.Add(this.panelKhach);
            this.Name = "ChuTro";
            this.Text = "ChuTro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelKhach.ResumeLayout(false);
            this.panelKhach.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelKhach;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnThemAnh;
        private System.Windows.Forms.RadioButton rdbtnNu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdbtnNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptAnh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnSua;
        private System.Windows.Forms.Label Username;
    }
}