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
            this.panelAnh = new System.Windows.Forms.Panel();
            this.btnThemAnh = new FontAwesome.Sharp.IconButton();
            this.btnXoaAnh = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelAnh
            // 
            this.panelAnh.Location = new System.Drawing.Point(3, 0);
            this.panelAnh.Name = "panelAnh";
            this.panelAnh.Size = new System.Drawing.Size(1071, 464);
            this.panelAnh.TabIndex = 0;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThemAnh.IconChar = FontAwesome.Sharp.IconChar.PhotoFilm;
            this.btnThemAnh.IconColor = System.Drawing.Color.DarkCyan;
            this.btnThemAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemAnh.IconSize = 20;
            this.btnThemAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemAnh.Location = new System.Drawing.Point(378, 487);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(104, 34);
            this.btnThemAnh.TabIndex = 1;
            this.btnThemAnh.Text = "Thêm Ảnh ";
            this.btnThemAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemAnh.UseVisualStyleBackColor = false;
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXoaAnh.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaAnh.IconColor = System.Drawing.Color.Honeydew;
            this.btnXoaAnh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaAnh.IconSize = 20;
            this.btnXoaAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaAnh.Location = new System.Drawing.Point(513, 487);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(95, 34);
            this.btnXoaAnh.TabIndex = 2;
            this.btnXoaAnh.Text = "Xóa Ảnh";
            this.btnXoaAnh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaAnh.UseVisualStyleBackColor = false;
            // 
            // AnhPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1075, 561);
            this.Controls.Add(this.btnXoaAnh);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.panelAnh);
            this.Name = "AnhPhong";
            this.Text = "AnhPhong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnh;
        private FontAwesome.Sharp.IconButton btnThemAnh;
        private FontAwesome.Sharp.IconButton btnXoaAnh;
    }
}