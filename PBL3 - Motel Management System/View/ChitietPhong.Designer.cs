namespace PBL3___Motel_Management_System.View
{
    partial class ChitietPhong
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
            this.panelChiTiet = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChisoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChisoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dangdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panPhong1 = new System.Windows.Forms.Panel();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.panelChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panPhong1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChiTiet
            // 
            this.panelChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChiTiet.Controls.Add(this.label10);
            this.panelChiTiet.Controls.Add(this.dataGridView1);
            this.panelChiTiet.Controls.Add(this.panPhong1);
            this.panelChiTiet.Location = new System.Drawing.Point(1, 0);
            this.panelChiTiet.Name = "panelChiTiet";
            this.panelChiTiet.Size = new System.Drawing.Size(970, 556);
            this.panelChiTiet.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDay,
            this.TenPhongTro,
            this.ChisoCu,
            this.ChisoMoi,
            this.Sudung,
            this.Gia});
            this.dataGridView1.Location = new System.Drawing.Point(53, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(853, 158);
            this.dataGridView1.TabIndex = 8;
            // 
            // TenDay
            // 
            this.TenDay.HeaderText = "Dãy";
            this.TenDay.MinimumWidth = 6;
            this.TenDay.Name = "TenDay";
            // 
            // TenPhongTro
            // 
            this.TenPhongTro.HeaderText = "Phòng";
            this.TenPhongTro.MinimumWidth = 6;
            this.TenPhongTro.Name = "TenPhongTro";
            // 
            // ChisoCu
            // 
            this.ChisoCu.HeaderText = "Chỉ số cũ";
            this.ChisoCu.MinimumWidth = 6;
            this.ChisoCu.Name = "ChisoCu";
            // 
            // ChisoMoi
            // 
            this.ChisoMoi.HeaderText = "Chỉ số mới";
            this.ChisoMoi.MinimumWidth = 6;
            this.ChisoMoi.Name = "ChisoMoi";
            // 
            // Sudung
            // 
            this.Sudung.HeaderText = "Sử dụng";
            this.Sudung.MinimumWidth = 6;
            this.Sudung.Name = "Sudung";
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.LoaiDV,
            this.Dongia,
            this.Dangdung});
            this.dataGridView2.Location = new System.Drawing.Point(29, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(853, 157);
            this.dataGridView2.TabIndex = 52;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Chocolate;
            this.label10.Location = new System.Drawing.Point(18, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 28);
            this.label10.TabIndex = 53;
            this.label10.Text = "CHI TIẾT PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 54;
            this.label1.Text = "Thành viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Dịch vụ ";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(602, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 43);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panPhong1
            // 
            this.panPhong1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPhong1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panPhong1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPhong1.Controls.Add(this.btnXoa);
            this.panPhong1.Controls.Add(this.btnSua);
            this.panPhong1.Controls.Add(this.btnThem);
            this.panPhong1.Controls.Add(this.dataGridView2);
            this.panPhong1.Controls.Add(this.label1);
            this.panPhong1.Controls.Add(this.label2);
            this.panPhong1.Location = new System.Drawing.Point(23, 54);
            this.panPhong1.Name = "panPhong1";
            this.panPhong1.Size = new System.Drawing.Size(919, 478);
            this.panPhong1.TabIndex = 57;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(698, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 41);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(794, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 41);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // ChitietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 559);
            this.Controls.Add(this.panelChiTiet);
            this.Name = "ChitietPhong";
            this.Text = "ChitietPhong";
            this.panelChiTiet.ResumeLayout(false);
            this.panelChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panPhong1.ResumeLayout(false);
            this.panPhong1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChiTiet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChisoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChisoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dangdung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.Panel panPhong1;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
    }
}