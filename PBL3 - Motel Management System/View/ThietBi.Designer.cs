namespace PBL3___Motel_Management_System.View
{
    partial class Thietbi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTB = new System.Windows.Forms.Panel();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
            this.btnSuaDV = new FontAwesome.Sharp.IconButton();
            this.btnThemThietBi = new FontAwesome.Sharp.IconButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 49);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "DANH SÁCH THIẾT BỊ";
            // 
            // panelTB
            // 
            this.panelTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTB.Controls.Add(this.dgvThietBi);
            this.panelTB.Controls.Add(this.btnTim);
            this.panelTB.Controls.Add(this.btnXoaPhong);
            this.panelTB.Controls.Add(this.btnSuaDV);
            this.panelTB.Controls.Add(this.btnThemThietBi);
            this.panelTB.Controls.Add(this.txtTim);
            this.panelTB.Location = new System.Drawing.Point(5, 55);
            this.panelTB.Name = "panelTB";
            this.panelTB.Size = new System.Drawing.Size(902, 383);
            this.panelTB.TabIndex = 23;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThietBi.Location = new System.Drawing.Point(33, 100);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(815, 251);
            this.dgvThietBi.TabIndex = 56;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTim.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 25;
            this.btnTim.Location = new System.Drawing.Point(81, 13);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(42, 42);
            this.btnTim.TabIndex = 55;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaPhong.BackColor = System.Drawing.Color.Red;
            this.btnXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhong.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaPhong.IconColor = System.Drawing.Color.White;
            this.btnXoaPhong.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnXoaPhong.IconSize = 25;
            this.btnXoaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhong.Location = new System.Drawing.Point(798, 14);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(94, 38);
            this.btnXoaPhong.TabIndex = 54;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSuaDV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnSuaDV.IconColor = System.Drawing.Color.White;
            this.btnSuaDV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaDV.IconSize = 25;
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDV.Location = new System.Drawing.Point(690, 15);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(88, 39);
            this.btnSuaDV.TabIndex = 52;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnThemThietBi
            // 
            this.btnThemThietBi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemThietBi.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThietBi.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnThemThietBi.IconColor = System.Drawing.Color.White;
            this.btnThemThietBi.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnThemThietBi.IconSize = 25;
            this.btnThemThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThietBi.Location = new System.Drawing.Point(584, 14);
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.Size = new System.Drawing.Size(100, 40);
            this.btnThemThietBi.TabIndex = 53;
            this.btnThemThietBi.Text = "Thêm ";
            this.btnThemThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThietBi.UseVisualStyleBackColor = false;
            this.btnThemThietBi.Click += new System.EventHandler(this.btnThemThietBi_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(143, 21);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(180, 27);
            this.txtTim.TabIndex = 51;
            // 
            // Thietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTB);
            this.Name = "Thietbi";
            this.Text = "ThietBi";
            this.Load += new System.EventHandler(this.ThietBi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTB.ResumeLayout(false);
            this.panelTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTB;
        private FontAwesome.Sharp.IconButton btnTim;
        private FontAwesome.Sharp.IconButton btnXoaPhong;
        private FontAwesome.Sharp.IconButton btnSuaDV;
        private FontAwesome.Sharp.IconButton btnThemThietBi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvThietBi;
    }
}