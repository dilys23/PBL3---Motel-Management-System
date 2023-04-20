namespace PBL3___Motel_Management_System.View
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
            this.components = new System.ComponentModel.Container();
            this.panelThemHD = new System.Windows.Forms.Panel();
            this.btnTrove = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.panelThem = new System.Windows.Forms.Panel();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dangdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvTBThem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTB = new FontAwesome.Sharp.IconButton();
            this.btnXoaTB = new FontAwesome.Sharp.IconButton();
            this.panelThemHD.SuspendLayout();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTBThem)).BeginInit();
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
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panelThem
            // 
            this.panelThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelThem.Controls.Add(this.btnXoaTB);
            this.panelThem.Controls.Add(this.btnThemTB);
            this.panelThem.Controls.Add(this.dgvTBThem);
            this.panelThem.Controls.Add(this.dgvThietBi);
            this.panelThem.Location = new System.Drawing.Point(17, 67);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(890, 354);
            this.panelThem.TabIndex = 46;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.LoaiDV,
            this.Dongia,
            this.Dangdung});
            this.dgvThietBi.Location = new System.Drawing.Point(130, 26);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.Size = new System.Drawing.Size(752, 141);
            this.dgvThietBi.TabIndex = 51;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvTBThem
            // 
            this.dgvTBThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvTBThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTBThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTBThem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTBThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTBThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvTBThem.Location = new System.Drawing.Point(130, 189);
            this.dgvTBThem.Name = "dgvTBThem";
            this.dgvTBThem.RowHeadersWidth = 51;
            this.dgvTBThem.RowTemplate.Height = 24;
            this.dgvTBThem.Size = new System.Drawing.Size(752, 132);
            this.dgvTBThem.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Dịch Vụ ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Loại Dịch Vụ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn Giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Đang Dùng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnThemTB
            // 
            this.btnThemTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemTB.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnThemTB.IconColor = System.Drawing.Color.White;
            this.btnThemTB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemTB.IconSize = 25;
            this.btnThemTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTB.Location = new System.Drawing.Point(22, 26);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(83, 42);
            this.btnThemTB.TabIndex = 55;
            this.btnThemTB.Text = "Thêm ";
            this.btnThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTB.UseVisualStyleBackColor = false;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // btnXoaTB
            // 
            this.btnXoaTB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoaTB.BackColor = System.Drawing.Color.Red;
            this.btnXoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTB.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaTB.IconColor = System.Drawing.Color.White;
            this.btnXoaTB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaTB.IconSize = 25;
            this.btnXoaTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTB.Location = new System.Drawing.Point(22, 189);
            this.btnXoaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(77, 38);
            this.btnXoaTB.TabIndex = 56;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTB.UseVisualStyleBackColor = false;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTBThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemHD;
        private FontAwesome.Sharp.IconButton btnTrove;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dangdung;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvTBThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private FontAwesome.Sharp.IconButton btnThemTB;
        private FontAwesome.Sharp.IconButton btnXoaTB;
    }
}