namespace PBL3___Motel_Management_System
{
    partial class SuaDichVu
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
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaDichVu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnLuu.IconColor = System.Drawing.Color.White;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 30;
            this.btnLuu.Location = new System.Drawing.Point(840, 35);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(45, 46);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(785, 37);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(45, 46);
            this.iconButton1.TabIndex = 43;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên dịch vụ *";
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtGiaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDichVu.Location = new System.Drawing.Point(310, 101);
            this.txtGiaDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.Size = new System.Drawing.Size(256, 27);
            this.txtGiaDichVu.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Giá *";
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTenDichVu);
            this.panel2.Controls.Add(this.txtGiaDichVu);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(24, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 253);
            this.panel2.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(147, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "(*) Thông tin bắt buộc";
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDichVu.Location = new System.Drawing.Point(310, 36);
            this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.Size = new System.Drawing.Size(256, 27);
            this.txtTenDichVu.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(23, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 58;
            this.label7.Text = "SỬA DỊCH VỤ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SuaDichVu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(915, 438);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SuaDichVu";
            this.Text = "SuaDichVu";
            this.Load += new System.EventHandler(this.SuaDichVu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}