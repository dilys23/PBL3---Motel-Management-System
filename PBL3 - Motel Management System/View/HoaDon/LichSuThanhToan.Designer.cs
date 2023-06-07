namespace PBL3___Motel_Management_System
{
    partial class LichSuThanhToan
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
            this.dtpThangThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTroVe = new FontAwesome.Sharp.IconButton();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpThangThanhToan
            // 
            this.dtpThangThanhToan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangThanhToan.CustomFormat = "MM/yyyy";
            this.dtpThangThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangThanhToan.Location = new System.Drawing.Point(162, 156);
            this.dtpThangThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpThangThanhToan.Name = "dtpThangThanhToan";
            this.dtpThangThanhToan.ShowUpDown = true;
            this.dtpThangThanhToan.Size = new System.Drawing.Size(201, 27);
            this.dtpThangThanhToan.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 90;
            this.label8.Text = "Tháng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 88;
            this.label2.Text = "Tên Phòng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(702, 95);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(201, 27);
            this.txtTongTien.TabIndex = 87;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Enabled = false;
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.Location = new System.Drawing.Point(162, 98);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(201, 27);
            this.txtTenPhong.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(358, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "LỊCH SỬ THANH TOÁN";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTroVe.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTroVe.IconColor = System.Drawing.Color.White;
            this.btnTroVe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroVe.IconSize = 30;
            this.btnTroVe.Location = new System.Drawing.Point(973, 24);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(43, 37);
            this.btnTroVe.TabIndex = 92;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.NgayTao,
            this.DaThanhToan,
            this.ConNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichSu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichSu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLichSu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLichSu.Location = new System.Drawing.Point(80, 218);
            this.dgvLichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichSu.MultiSelect = false;
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(893, 258);
            this.dgvLichSu.TabIndex = 93;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // NgayTao
            // 
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.HeaderText = "Đã thanh toán";
            this.DaThanhToan.MinimumWidth = 6;
            this.DaThanhToan.Name = "DaThanhToan";
            this.DaThanhToan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ConNo
            // 
            this.ConNo.HeaderText = "Còn Nợ";
            this.ConNo.MinimumWidth = 6;
            this.ConNo.Name = "ConNo";
            // 
            // LichSuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1053, 571);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.dtpThangThanhToan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label1);
            this.Name = "LichSuThanhToan";
            this.Text = "LichSuThanhToan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpThangThanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnTroVe;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConNo;
    }
}