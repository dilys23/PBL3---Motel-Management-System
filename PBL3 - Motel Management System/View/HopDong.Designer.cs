namespace PBL3___Motel_Management_System
{
    partial class Hopdong
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
            this.cbbDay = new System.Windows.Forms.ComboBox();
            this.panelHopDong = new System.Windows.Forms.Panel();
            this.btnChiTiet = new FontAwesome.Sharp.IconButton();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbPhong = new System.Windows.Forms.ComboBox();
            this.panelHopDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbDay
            // 
            this.cbbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDay.FormattingEnabled = true;
            this.cbbDay.Location = new System.Drawing.Point(485, 32);
            this.cbbDay.Name = "cbbDay";
            this.cbbDay.Size = new System.Drawing.Size(110, 28);
            this.cbbDay.TabIndex = 43;
            // 
            // panelHopDong
            // 
            this.panelHopDong.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelHopDong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHopDong.Controls.Add(this.cbbPhong);
            this.panelHopDong.Controls.Add(this.btnChiTiet);
            this.panelHopDong.Controls.Add(this.dgvHopDong);
            this.panelHopDong.Controls.Add(this.label1);
            this.panelHopDong.Controls.Add(this.label2);
            this.panelHopDong.Controls.Add(this.cbbDay);
            this.panelHopDong.Location = new System.Drawing.Point(0, 51);
            this.panelHopDong.Name = "panelHopDong";
            this.panelHopDong.Size = new System.Drawing.Size(914, 385);
            this.panelHopDong.TabIndex = 41;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChiTiet.IconChar = FontAwesome.Sharp.IconChar.PeopleRoof;
            this.btnChiTiet.IconColor = System.Drawing.Color.White;
            this.btnChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChiTiet.IconSize = 25;
            this.btnChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTiet.Location = new System.Drawing.Point(11, 25);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(90, 43);
            this.btnChiTiet.TabIndex = 51;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHopDong,
            this.Stt,
            this.TenNguoi,
            this.TenPhongTro,
            this.TenDayTro,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TienCoc});
            this.dgvHopDong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvHopDong.Location = new System.Drawing.Point(11, 94);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 24;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(888, 173);
            this.dgvHopDong.TabIndex = 8;
            this.dgvHopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(643, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Dãy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 49);
            this.panel1.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // MaHopDong
            // 
            this.MaHopDong.HeaderText = "Mã Hợp Đồng";
            this.MaHopDong.MinimumWidth = 6;
            this.MaHopDong.Name = "MaHopDong";
            this.MaHopDong.Visible = false;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // TenNguoi
            // 
            this.TenNguoi.HeaderText = "Tên Khách Hàng";
            this.TenNguoi.MinimumWidth = 6;
            this.TenNguoi.Name = "TenNguoi";
            // 
            // TenPhongTro
            // 
            this.TenPhongTro.HeaderText = "Tên phòng trọ";
            this.TenPhongTro.MinimumWidth = 6;
            this.TenPhongTro.Name = "TenPhongTro";
            // 
            // TenDayTro
            // 
            this.TenDayTro.HeaderText = "Tên dãy trọ";
            this.TenDayTro.MinimumWidth = 6;
            this.TenDayTro.Name = "TenDayTro";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // TienCoc
            // 
            this.TienCoc.HeaderText = "Tiền cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            // 
            // cbbPhong
            // 
            this.cbbPhong.FormattingEnabled = true;
            this.cbbPhong.Location = new System.Drawing.Point(717, 35);
            this.cbbPhong.Name = "cbbPhong";
            this.cbbPhong.Size = new System.Drawing.Size(146, 24);
            this.cbbPhong.TabIndex = 52;
            // 
            // Hopdong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 438);
            this.Controls.Add(this.panelHopDong);
            this.Controls.Add(this.panel1);
            this.Name = "Hopdong";
            this.Text = "Contract";
            this.panelHopDong.ResumeLayout(false);
            this.panelHopDong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDay;
        private System.Windows.Forms.Panel panelHopDong;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.ComboBox cbbPhong;
    }
}