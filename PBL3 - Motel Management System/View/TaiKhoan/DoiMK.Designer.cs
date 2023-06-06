namespace PBL3___Motel_Management_System.View
{
    partial class DoiMK
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrove = new FontAwesome.Sharp.IconButton();
            this.BtnHuy = new FontAwesome.Sharp.IconButton();
            this.btnXacThuc = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXacthucMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTrove);
            this.panel2.Controls.Add(this.BtnHuy);
            this.panel2.Controls.Add(this.btnXacThuc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtXacthucMK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMKmoi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtMKcu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(18, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 419);
            this.panel2.TabIndex = 56;
            // 
            // btnTrove
            // 
            this.btnTrove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrove.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTrove.IconColor = System.Drawing.Color.White;
            this.btnTrove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrove.IconSize = 30;
            this.btnTrove.Location = new System.Drawing.Point(602, 13);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(34, 37);
            this.btnTrove.TabIndex = 68;
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // BtnHuy
            // 
            this.BtnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnHuy.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnHuy.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.BtnHuy.IconColor = System.Drawing.Color.White;
            this.BtnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnHuy.IconSize = 25;
            this.BtnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHuy.Location = new System.Drawing.Point(337, 276);
            this.BtnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(58, 32);
            this.BtnHuy.TabIndex = 67;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHuy.UseVisualStyleBackColor = false;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXacThuc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXacThuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnXacThuc.IconColor = System.Drawing.Color.White;
            this.btnXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacThuc.IconSize = 25;
            this.btnXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacThuc.Location = new System.Drawing.Point(242, 276);
            this.btnXacThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(74, 32);
            this.btnXacThuc.TabIndex = 66;
            this.btnXacThuc.Text = "Xác Thực";
            this.btnXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacThuc.UseVisualStyleBackColor = false;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(248, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "ĐỔI MẬT KHẨU";
            // 
            // txtXacthucMK
            // 
            this.txtXacthucMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacthucMK.Location = new System.Drawing.Point(298, 194);
            this.txtXacthucMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtXacthucMK.Name = "txtXacthucMK";
            this.txtXacthucMK.Size = new System.Drawing.Size(182, 23);
            this.txtXacthucMK.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Xác thực mật khẩu *:";
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKmoi.Location = new System.Drawing.Point(298, 142);
            this.txtMKmoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(182, 23);
            this.txtMKmoi.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nhập mật khẩu mới:*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(146, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "(*) Thông tin bắt buộc";
            // 
            // txtMKcu
            // 
            this.txtMKcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKcu.Location = new System.Drawing.Point(298, 88);
            this.txtMKcu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.Size = new System.Drawing.Size(182, 23);
            this.txtMKcu.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nhập mật khẩu cũ:*";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DoiMK";
            this.Text = "DoiMK";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtXacthucMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BtnHuy;
        private FontAwesome.Sharp.IconButton btnXacThuc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnTrove;
    }
}