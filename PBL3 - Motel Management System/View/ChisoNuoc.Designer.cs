namespace PBL3___Motel_Management_System
{
    partial class ChisoNuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChisoNuoc = new System.Windows.Forms.Panel();
            this.btnHuyXacThuc = new FontAwesome.Sharp.IconButton();
            this.dgvChiSoNuoc = new System.Windows.Forms.DataGridView();
            this.MaChiTietSuDungDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXacThuc = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.cbbPhongTro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemChiSo = new FontAwesome.Sharp.IconButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelChisoNuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoNuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChisoNuoc
            // 
            this.panelChisoNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChisoNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelChisoNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChisoNuoc.Controls.Add(this.btnHuyXacThuc);
            this.panelChisoNuoc.Controls.Add(this.dgvChiSoNuoc);
            this.panelChisoNuoc.Controls.Add(this.btnXacThuc);
            this.panelChisoNuoc.Controls.Add(this.label5);
            this.panelChisoNuoc.Controls.Add(this.cbbTinhTrang);
            this.panelChisoNuoc.Controls.Add(this.btnTimKiem);
            this.panelChisoNuoc.Controls.Add(this.cbbPhongTro);
            this.panelChisoNuoc.Controls.Add(this.label3);
            this.panelChisoNuoc.Controls.Add(this.btnThemChiSo);
            this.panelChisoNuoc.Controls.Add(this.dtpThang);
            this.panelChisoNuoc.Controls.Add(this.label1);
            this.panelChisoNuoc.Controls.Add(this.cbbDayTro);
            this.panelChisoNuoc.Controls.Add(this.label2);
            this.panelChisoNuoc.Location = new System.Drawing.Point(12, 75);
            this.panelChisoNuoc.Name = "panelChisoNuoc";
            this.panelChisoNuoc.Size = new System.Drawing.Size(1023, 504);
            this.panelChisoNuoc.TabIndex = 29;
            // 
            // btnHuyXacThuc
            // 
            this.btnHuyXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnHuyXacThuc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuyXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            this.btnHuyXacThuc.IconColor = System.Drawing.Color.White;
            this.btnHuyXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuyXacThuc.IconSize = 25;
            this.btnHuyXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyXacThuc.Location = new System.Drawing.Point(520, 397);
            this.btnHuyXacThuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyXacThuc.Name = "btnHuyXacThuc";
            this.btnHuyXacThuc.Size = new System.Drawing.Size(86, 39);
            this.btnHuyXacThuc.TabIndex = 66;
            this.btnHuyXacThuc.Text = "Hủy";
            this.btnHuyXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyXacThuc.UseVisualStyleBackColor = false;
            this.btnHuyXacThuc.Click += new System.EventHandler(this.btnHuyXacThuc_Click);
            // 
            // dgvChiSoNuoc
            // 
            this.dgvChiSoNuoc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvChiSoNuoc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiSoNuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiSoNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiSoNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiSoNuoc.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiSoNuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiSoNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiSoNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChiTietSuDungDichVu,
            this.Stt,
            this.DayTro,
            this.PhongTro,
            this.ChiSoCu,
            this.ChiSoMoi,
            this.DaDung,
            this.NgayLap,
            this.Thang,
            this.TinhTrang});
            this.dgvChiSoNuoc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvChiSoNuoc.Location = new System.Drawing.Point(35, 107);
            this.dgvChiSoNuoc.Name = "dgvChiSoNuoc";
            this.dgvChiSoNuoc.RowHeadersWidth = 51;
            this.dgvChiSoNuoc.RowTemplate.Height = 24;
            this.dgvChiSoNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiSoNuoc.Size = new System.Drawing.Size(950, 273);
            this.dgvChiSoNuoc.TabIndex = 65;
            // 
            // MaChiTietSuDungDichVu
            // 
            this.MaChiTietSuDungDichVu.HeaderText = "MaChiTietSuDungDichVu";
            this.MaChiTietSuDungDichVu.MinimumWidth = 6;
            this.MaChiTietSuDungDichVu.Name = "MaChiTietSuDungDichVu";
            this.MaChiTietSuDungDichVu.Visible = false;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // DayTro
            // 
            this.DayTro.HeaderText = "Dãy trọ";
            this.DayTro.MinimumWidth = 6;
            this.DayTro.Name = "DayTro";
            // 
            // PhongTro
            // 
            this.PhongTro.HeaderText = "Phòng trọ";
            this.PhongTro.MinimumWidth = 6;
            this.PhongTro.Name = "PhongTro";
            // 
            // ChiSoCu
            // 
            this.ChiSoCu.HeaderText = "Chỉ số cũ";
            this.ChiSoCu.MinimumWidth = 6;
            this.ChiSoCu.Name = "ChiSoCu";
            // 
            // ChiSoMoi
            // 
            this.ChiSoMoi.HeaderText = "Chỉ số mới";
            this.ChiSoMoi.MinimumWidth = 6;
            this.ChiSoMoi.Name = "ChiSoMoi";
            // 
            // DaDung
            // 
            this.DaDung.HeaderText = "Đã dùng";
            this.DaDung.MinimumWidth = 6;
            this.DaDung.Name = "DaDung";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            // 
            // Thang
            // 
            this.Thang.HeaderText = "Tháng sử dung";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXacThuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacThuc.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.btnXacThuc.IconColor = System.Drawing.Color.White;
            this.btnXacThuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacThuc.IconSize = 25;
            this.btnXacThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacThuc.Location = new System.Drawing.Point(393, 397);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(98, 39);
            this.btnXacThuc.TabIndex = 63;
            this.btnXacThuc.Text = "Xác Thực";
            this.btnXacThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacThuc.UseVisualStyleBackColor = false;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "Tình trạng:";
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(405, 48);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(124, 25);
            this.cbbTinhTrang.TabIndex = 61;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.Location = new System.Drawing.Point(16, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(35, 35);
            this.btnTimKiem.TabIndex = 60;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cbbPhongTro
            // 
            this.cbbPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongTro.FormattingEnabled = true;
            this.cbbPhongTro.Location = new System.Drawing.Point(305, 47);
            this.cbbPhongTro.Name = "cbbPhongTro";
            this.cbbPhongTro.Size = new System.Drawing.Size(94, 25);
            this.cbbPhongTro.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Phòng:";
            // 
            // btnThemChiSo
            // 
            this.btnThemChiSo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemChiSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemChiSo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemChiSo.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnThemChiSo.IconColor = System.Drawing.Color.White;
            this.btnThemChiSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemChiSo.IconSize = 25;
            this.btnThemChiSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemChiSo.Location = new System.Drawing.Point(912, 40);
            this.btnThemChiSo.Name = "btnThemChiSo";
            this.btnThemChiSo.Size = new System.Drawing.Size(73, 36);
            this.btnThemChiSo.TabIndex = 52;
            this.btnThemChiSo.Text = "Thêm ";
            this.btnThemChiSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemChiSo.UseVisualStyleBackColor = false;
            this.btnThemChiSo.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(57, 48);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.ShowUpDown = true;
            this.dtpThang.Size = new System.Drawing.Size(117, 23);
            this.dtpThang.TabIndex = 29;
            this.dtpThang.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thời gian:";
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(180, 47);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(108, 25);
            this.cbbDayTro.TabIndex = 31;
            this.cbbDayTro.SelectedIndexChanged += new System.EventHandler(this.cbbDayTro_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Dãy:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 49);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "CHỈ SỐ NƯỚC";
            // 
            // ChisoNuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1047, 619);
            this.Controls.Add(this.panelChisoNuoc);
            this.Controls.Add(this.panel1);
            this.Name = "ChisoNuoc";
            this.Text = "WaterNum";
            this.Load += new System.EventHandler(this.ChisoNuoc_Load);
            this.panelChisoNuoc.ResumeLayout(false);
            this.panelChisoNuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoNuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelChisoNuoc;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDayTro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnThemChiSo;
        private System.Windows.Forms.ComboBox cbbPhongTro;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private FontAwesome.Sharp.IconButton btnXacThuc;
        private System.Windows.Forms.DataGridView dgvChiSoNuoc;
        private FontAwesome.Sharp.IconButton btnHuyXacThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiTietSuDungDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}