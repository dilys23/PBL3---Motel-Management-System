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
            this.btnXoaTB = new FontAwesome.Sharp.IconButton();
            this.btnThemTB = new FontAwesome.Sharp.IconButton();
            this.dgvTBThem = new System.Windows.Forms.DataGridView();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.MaThietBi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelThemHD.SuspendLayout();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTBThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.panelThemHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThemHD.Name = "panelThemHD";
            this.panelThemHD.Size = new System.Drawing.Size(971, 444);
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
            this.btnTrove.Location = new System.Drawing.Point(835, 22);
            this.btnTrove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label7.Location = new System.Drawing.Point(13, 30);
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
            this.btnLuu.Location = new System.Drawing.Point(884, 21);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panelThem.Location = new System.Drawing.Point(17, 66);
            this.panelThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(942, 354);
            this.panelThem.TabIndex = 46;
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
            this.btnXoaTB.Location = new System.Drawing.Point(21, 190);
            this.btnXoaTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTB.Name = "btnXoaTB";
            this.btnXoaTB.Size = new System.Drawing.Size(77, 38);
            this.btnXoaTB.TabIndex = 56;
            this.btnXoaTB.Text = "Xóa";
            this.btnXoaTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTB.UseVisualStyleBackColor = false;
            this.btnXoaTB.Click += new System.EventHandler(this.btnXoaTB_Click);
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
            this.btnThemTB.Location = new System.Drawing.Point(21, 26);
            this.btnThemTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(83, 42);
            this.btnThemTB.TabIndex = 55;
            this.btnThemTB.Text = "Thêm ";
            this.btnThemTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTB.UseVisualStyleBackColor = false;
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // dgvTBThem
            // 
            this.dgvTBThem.AllowUserToAddRows = false;
            this.dgvTBThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTBThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTBThem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTBThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTBThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.dataGridViewTextBoxColumn1,
            this.TenThietBi,
            this.GiaThietBi,
            this.SoLuong});
            this.dgvTBThem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTBThem.Location = new System.Drawing.Point(131, 190);
            this.dgvTBThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTBThem.MultiSelect = false;
            this.dgvTBThem.Name = "dgvTBThem";
            this.dgvTBThem.RowHeadersWidth = 51;
            this.dgvTBThem.RowTemplate.Height = 24;
            this.dgvTBThem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTBThem.Size = new System.Drawing.Size(803, 132);
            this.dgvTBThem.TabIndex = 52;
            // 
            // MaThietBi
            // 
            this.MaThietBi.HeaderText = "MaThietBi";
            this.MaThietBi.MinimumWidth = 6;
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TenThietBi
            // 
            this.TenThietBi.HeaderText = "Tên thiết bị";
            this.TenThietBi.MinimumWidth = 6;
            this.TenThietBi.Name = "TenThietBi";
            // 
            // GiaThietBi
            // 
            this.GiaThietBi.HeaderText = "Giá thiết bị";
            this.GiaThietBi.MinimumWidth = 6;
            this.GiaThietBi.Name = "GiaThietBi";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi1,
            this.Stt,
            this.TenThietBi1,
            this.gia});
            this.dgvThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThietBi.Location = new System.Drawing.Point(131, 26);
            this.dgvThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThietBi.MultiSelect = false;
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 51;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(803, 142);
            this.dgvThietBi.TabIndex = 51;
            // 
            // MaThietBi1
            // 
            this.MaThietBi1.HeaderText = "MaThietBi1";
            this.MaThietBi1.MinimumWidth = 6;
            this.MaThietBi1.Name = "MaThietBi1";
            this.MaThietBi1.Visible = false;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "STT";
            this.Stt.MinimumWidth = 6;
            this.Stt.Name = "Stt";
            // 
            // TenThietBi1
            // 
            this.TenThietBi1.HeaderText = "Tên thiết bị";
            this.TenThietBi1.MinimumWidth = 6;
            this.TenThietBi1.Name = "TenThietBi1";
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá thiết bị";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThemThietBiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 455);
            this.Controls.Add(this.panelThemHD);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThemThietBiPhong";
            this.Text = "ThemThietBiPhong";
            this.panelThemHD.ResumeLayout(false);
            this.panelThemHD.PerformLayout();
            this.panelThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTBThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThemHD;
        private FontAwesome.Sharp.IconButton btnTrove;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvTBThem;
        private FontAwesome.Sharp.IconButton btnThemTB;
        private FontAwesome.Sharp.IconButton btnXoaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
    }
}