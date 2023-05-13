namespace PBL3___Motel_Management_System.View
{
    partial class ThemDVphong
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
            this.panelThemDV = new System.Windows.Forms.Panel();
            this.btnTroVe = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.panelThem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDVcodinh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaDichVu = new FontAwesome.Sharp.IconButton();
            this.btnThemDichVu = new FontAwesome.Sharp.IconButton();
            this.dgvXoaDichVu = new System.Windows.Forms.DataGridView();
            this.dgvThemDichVu = new System.Windows.Forms.DataGridView();
            this.MaDichVu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDichVu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThemDV.SuspendLayout();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVcodinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThemDV
            // 
            this.panelThemDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThemDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelThemDV.Controls.Add(this.btnTroVe);
            this.panelThemDV.Controls.Add(this.label7);
            this.panelThemDV.Controls.Add(this.btnLuu);
            this.panelThemDV.Controls.Add(this.panelThem);
            this.panelThemDV.Location = new System.Drawing.Point(-2, 1);
            this.panelThemDV.Margin = new System.Windows.Forms.Padding(2);
            this.panelThemDV.Name = "panelThemDV";
            this.panelThemDV.Size = new System.Drawing.Size(789, 508);
            this.panelThemDV.TabIndex = 1;
            this.panelThemDV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelThemHD_Paint);
            // 
            // btnTroVe
            // 
            this.btnTroVe.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTroVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTroVe.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.btnTroVe.IconColor = System.Drawing.Color.White;
            this.btnTroVe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTroVe.IconSize = 30;
            this.btnTroVe.Location = new System.Drawing.Point(701, 3);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(2);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(32, 30);
            this.btnTroVe.TabIndex = 48;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(11, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "CHỌN DỊCH VỤ";
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
            this.btnLuu.Location = new System.Drawing.Point(738, 2);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(39, 30);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // panelThem
            // 
            this.panelThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelThem.Controls.Add(this.label1);
            this.panelThem.Controls.Add(this.dgvDVcodinh);
            this.panelThem.Controls.Add(this.btnXoaDichVu);
            this.panelThem.Controls.Add(this.btnThemDichVu);
            this.panelThem.Controls.Add(this.dgvXoaDichVu);
            this.panelThem.Controls.Add(this.dgvThemDichVu);
            this.panelThem.Location = new System.Drawing.Point(13, 38);
            this.panelThem.Margin = new System.Windows.Forms.Padding(2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(767, 455);
            this.panelThem.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(75, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Dịch vụ cố định";
            // 
            // dgvDVcodinh
            // 
            this.dgvDVcodinh.AllowUserToAddRows = false;
            this.dgvDVcodinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDVcodinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDVcodinh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDVcodinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVcodinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvDVcodinh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDVcodinh.Location = new System.Drawing.Point(78, 307);
            this.dgvDVcodinh.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDVcodinh.Name = "dgvDVcodinh";
            this.dgvDVcodinh.RowHeadersWidth = 51;
            this.dgvDVcodinh.RowTemplate.Height = 24;
            this.dgvDVcodinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDVcodinh.Size = new System.Drawing.Size(661, 116);
            this.dgvDVcodinh.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã dịch vụ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "STT";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên dịch vụ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá dịch vụ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoaDichVu.BackColor = System.Drawing.Color.Red;
            this.btnXoaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDichVu.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoaDichVu.IconColor = System.Drawing.Color.White;
            this.btnXoaDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaDichVu.IconSize = 25;
            this.btnXoaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDichVu.Location = new System.Drawing.Point(6, 159);
            this.btnXoaDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(58, 31);
            this.btnXoaDichVu.TabIndex = 53;
            this.btnXoaDichVu.Text = "Xóa";
            this.btnXoaDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDichVu.UseVisualStyleBackColor = false;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemDichVu.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVu.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnThemDichVu.IconColor = System.Drawing.Color.White;
            this.btnThemDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemDichVu.IconSize = 25;
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(6, 10);
            this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(62, 34);
            this.btnThemDichVu.TabIndex = 54;
            this.btnThemDichVu.Text = "Thêm ";
            this.btnThemDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // dgvXoaDichVu
            // 
            this.dgvXoaDichVu.AllowUserToAddRows = false;
            this.dgvXoaDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvXoaDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXoaDichVu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvXoaDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXoaDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.Stt,
            this.TenDichVu,
            this.GiaDichVu});
            this.dgvXoaDichVu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvXoaDichVu.Location = new System.Drawing.Point(78, 159);
            this.dgvXoaDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvXoaDichVu.Name = "dgvXoaDichVu";
            this.dgvXoaDichVu.RowHeadersWidth = 51;
            this.dgvXoaDichVu.RowTemplate.Height = 24;
            this.dgvXoaDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXoaDichVu.Size = new System.Drawing.Size(661, 110);
            this.dgvXoaDichVu.TabIndex = 52;
            // 
            // dgvThemDichVu
            // 
            this.dgvThemDichVu.AllowUserToAddRows = false;
            this.dgvThemDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThemDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThemDichVu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThemDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu1,
            this.STT1,
            this.TenDichVu1,
            this.GiaDichVu1});
            this.dgvThemDichVu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThemDichVu.Location = new System.Drawing.Point(78, 10);
            this.dgvThemDichVu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThemDichVu.Name = "dgvThemDichVu";
            this.dgvThemDichVu.RowHeadersWidth = 51;
            this.dgvThemDichVu.RowTemplate.Height = 24;
            this.dgvThemDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThemDichVu.Size = new System.Drawing.Size(661, 124);
            this.dgvThemDichVu.TabIndex = 51;
            // 
            // MaDichVu1
            // 
            this.MaDichVu1.HeaderText = "Mã dịch vụ";
            this.MaDichVu1.MinimumWidth = 6;
            this.MaDichVu1.Name = "MaDichVu1";
            this.MaDichVu1.Visible = false;
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.MinimumWidth = 6;
            this.STT1.Name = "STT1";
            // 
            // TenDichVu1
            // 
            this.TenDichVu1.HeaderText = "Tên dịch vụ";
            this.TenDichVu1.MinimumWidth = 6;
            this.TenDichVu1.Name = "TenDichVu1";
            // 
            // GiaDichVu1
            // 
            this.GiaDichVu1.HeaderText = "Giá dịch vụ";
            this.GiaDichVu1.MinimumWidth = 6;
            this.GiaDichVu1.Name = "GiaDichVu1";
            // 
            // MaDichVu
            // 
            this.MaDichVu.HeaderText = "Mã dịch vụ";
            this.MaDichVu.MinimumWidth = 6;
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.Visible = false;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên dịch vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            // 
            // GiaDichVu
            // 
            this.GiaDichVu.HeaderText = "Giá dịch vụ";
            this.GiaDichVu.MinimumWidth = 6;
            this.GiaDichVu.Name = "GiaDichVu";
            // 
            // ThemDVphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 503);
            this.Controls.Add(this.panelThemDV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemDVphong";
            this.Text = "ThemDVphong";
            this.panelThemDV.ResumeLayout(false);
            this.panelThemDV.PerformLayout();
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVcodinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemDV;
        private FontAwesome.Sharp.IconButton btnTroVe;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.DataGridView dgvThemDichVu;
        private System.Windows.Forms.DataGridView dgvXoaDichVu;
        private FontAwesome.Sharp.IconButton btnXoaDichVu;
        private FontAwesome.Sharp.IconButton btnThemDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDVcodinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaDichVu1;
    }
}