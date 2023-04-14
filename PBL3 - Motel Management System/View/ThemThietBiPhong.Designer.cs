﻿namespace PBL3___Motel_Management_System.View
{
    partial class ThemThietBiPhong
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
            this.panelThemHD = new System.Windows.Forms.Panel();
            this.btnTrove = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.panelThem = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dangdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThemHD.SuspendLayout();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThemHD
            // 
            this.panelThemHD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThemHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThemHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelThemHD.Controls.Add(this.btnTrove);
            this.panelThemHD.Controls.Add(this.label7);
            this.panelThemHD.Controls.Add(this.btnLuu);
            this.panelThemHD.Controls.Add(this.panelThem);
            this.panelThemHD.Location = new System.Drawing.Point(-3, 5);
            this.panelThemHD.Name = "panelThemHD";
            this.panelThemHD.Size = new System.Drawing.Size(920, 444);
            this.panelThemHD.TabIndex = 2;
            // 
            // btnTrove
            // 
            this.btnTrove.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTrove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTrove.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTrove.IconColor = System.Drawing.Color.White;
            this.btnTrove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrove.IconSize = 30;
            this.btnTrove.Location = new System.Drawing.Point(784, 22);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(43, 37);
            this.btnTrove.TabIndex = 48;
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(13, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 28);
            this.label7.TabIndex = 47;
            this.label7.Text = "CHỌN THIẾT BỊ ";
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
            this.btnLuu.Location = new System.Drawing.Point(833, 21);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(52, 37);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // panelThem
            // 
            this.panelThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelThem.Controls.Add(this.dataGridView1);
            this.panelThem.Location = new System.Drawing.Point(17, 67);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(890, 257);
            this.panelThem.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.LoaiDV,
            this.Dongia,
            this.Dangdung});
            this.dataGridView1.Location = new System.Drawing.Point(10, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(872, 152);
            this.dataGridView1.TabIndex = 51;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // TenDV
            // 
            this.TenDV.HeaderText = "Tên Dịch Vụ ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            // 
            // LoaiDV
            // 
            this.LoaiDV.HeaderText = "Loại Dịch Vụ";
            this.LoaiDV.MinimumWidth = 6;
            this.LoaiDV.Name = "LoaiDV";
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Đơn Giá";
            this.Dongia.MinimumWidth = 6;
            this.Dongia.Name = "Dongia";
            // 
            // Dangdung
            // 
            this.Dangdung.HeaderText = "Đang Dùng";
            this.Dangdung.MinimumWidth = 6;
            this.Dangdung.Name = "Dangdung";
            // 
            // ThemThietBiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 455);
            this.Controls.Add(this.panelThemHD);
            this.Name = "ThemThietBiPhong";
            this.Text = "ThemThietBiPhong";
            this.panelThemHD.ResumeLayout(false);
            this.panelThemHD.PerformLayout();
            this.panelThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemHD;
        private FontAwesome.Sharp.IconButton btnTrove;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dangdung;
    }
}