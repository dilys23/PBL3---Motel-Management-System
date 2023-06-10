namespace PBL3___Motel_Management_System.View.Phong
{
    partial class ThemAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemAnh));
            this.pctAnh = new System.Windows.Forms.PictureBox();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAnh
            // 
            this.pctAnh.Image = ((System.Drawing.Image)(resources.GetObject("pctAnh.Image")));
            this.pctAnh.Location = new System.Drawing.Point(160, 30);
            this.pctAnh.Name = "pctAnh";
            this.pctAnh.Size = new System.Drawing.Size(461, 338);
            this.pctAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAnh.TabIndex = 0;
            this.pctAnh.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PhotoFilm;
            this.btnThem.IconColor = System.Drawing.Color.DarkCyan;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 20;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(263, 390);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Ảnh ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnLuuAnh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Tomato;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.MintCream;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.IconSize = 20;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(386, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 34);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu Ảnh";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ThemAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pctAnh);
            this.Name = "ThemAnh";
            this.Text = "ThemAnh";
            ((System.ComponentModel.ISupportInitialize)(this.pctAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAnh;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnLuu;
    }
}