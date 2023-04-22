namespace PBL3___Motel_Management_System.View
{
    partial class CocPhong
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayCoc = new System.Windows.Forms.DateTimePicker();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.panelKhach = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayNhanPhong = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCccd = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnTrove = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelKhach.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.label8.Location = new System.Drawing.Point(8, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "CỌC PHÒNG";
            // 
            // dtpNgayCoc
            // 
            this.dtpNgayCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayCoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCoc.Location = new System.Drawing.Point(147, 97);
            this.dtpNgayCoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayCoc.Name = "dtpNgayCoc";
            this.dtpNgayCoc.Size = new System.Drawing.Size(158, 23);
            this.dtpNgayCoc.TabIndex = 27;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(453, 102);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(170, 23);
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
            this.panelKhach.Controls.Add(this.btnTrove);
            this.panelKhach.Location = new System.Drawing.Point(7, 2);
            this.panelKhach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelKhach.Name = "panelKhach";
            this.panelKhach.Size = new System.Drawing.Size(690, 369);
            this.panelKhach.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.txtTienCoc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpNgayNhanPhong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpNgayCoc);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCccd);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Location = new System.Drawing.Point(11, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 287);
            this.panel1.TabIndex = 46;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Red;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXacNhan.IconColor = System.Drawing.Color.Black;
            this.btnXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacNhan.Location = new System.Drawing.Point(272, 210);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 26);
            this.btnXacNhan.TabIndex = 48;
            this.btnXacNhan.Text = "Xác nhận ";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Location = new System.Drawing.Point(453, 150);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(170, 23);
            this.txtTienCoc.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tiền cọc ";
            // 
            // dtpNgayNhanPhong
            // 
            this.dtpNgayNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhanPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhanPhong.Location = new System.Drawing.Point(147, 141);
            this.dtpNgayNhanPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayNhanPhong.Name = "dtpNgayNhanPhong";
            this.dtpNgayNhanPhong.Size = new System.Drawing.Size(158, 23);
            this.dtpNgayNhanPhong.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày nhận phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày cọc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số điện thoại ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "CCCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Họ và Tên ";
            // 
            // txtCccd
            // 
            this.txtCccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCccd.Location = new System.Drawing.Point(453, 55);
            this.txtCccd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCccd.Name = "txtCccd";
            this.txtCccd.Size = new System.Drawing.Size(170, 23);
            this.txtCccd.TabIndex = 16;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(147, 49);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(158, 23);
            this.txtTen.TabIndex = 15;
            // 
            // btnTrove
            // 
            this.btnTrove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrove.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTrove.IconColor = System.Drawing.Color.White;
            this.btnTrove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrove.IconSize = 30;
            this.btnTrove.Location = new System.Drawing.Point(636, 5);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(34, 37);
            this.btnTrove.TabIndex = 44;
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // CocPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 373);
            this.Controls.Add(this.panelKhach);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CocPhong";
            this.Text = "CocPhong";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelKhach.ResumeLayout(false);
            this.panelKhach.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelKhach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayNhanPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayCoc;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnTrove;
        private FontAwesome.Sharp.IconButton btnXacNhan;
    }
}