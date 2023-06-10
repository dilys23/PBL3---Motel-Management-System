namespace PBL3___Motel_Management_System.View.Phong
{
    partial class AnhPhong
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
            this.btnThemAnh = new FontAwesome.Sharp.IconButton();
            this.btnXoaAnh = new FontAwesome.Sharp.IconButton();
            this.panelAnh = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemAnh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemAnh.IconChar = FontAwesome.Sharp.IconChar.PhotoFilm;
            this.btnThemAnh.IconColor = System.Drawing.Color.DarkCyan;
            this.btnThemAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemAnh.IconSize = 20;
            this.btnThemAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemAnh.Location = new System.Drawing.Point(927, 13);
            this.btnThemAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(104, 34);
            this.btnThemAnh.TabIndex = 1;
            this.btnThemAnh.Text = "Thêm Ảnh ";
            this.btnThemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemAnh.UseVisualStyleBackColor = false;
            this.btnThemAnh.Click += new System.EventHandler(this.btnThemAnh_Click);
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaAnh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoaAnh.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaAnh.IconColor = System.Drawing.Color.Honeydew;
            this.btnXoaAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaAnh.IconSize = 20;
            this.btnXoaAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaAnh.Location = new System.Drawing.Point(1039, 13);
            this.btnXoaAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(95, 34);
            this.btnXoaAnh.TabIndex = 2;
            this.btnXoaAnh.Text = "Xóa Ảnh";
            this.btnXoaAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaAnh.UseVisualStyleBackColor = false;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // panelAnh
            // 
            this.panelAnh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelAnh.Location = new System.Drawing.Point(16, 60);
            this.panelAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(1234, 661);
            this.panelAnh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "ẢNH PHÒNG";
            // 
            // AnhPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1266, 734);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.btnXoaAnh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelAnh);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnhPhong";
            this.Text = "AnhPhong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelAnh;
        public FontAwesome.Sharp.IconButton btnThemAnh;
        public FontAwesome.Sharp.IconButton btnXoaAnh;
        private System.Windows.Forms.Label label4;
    }
}