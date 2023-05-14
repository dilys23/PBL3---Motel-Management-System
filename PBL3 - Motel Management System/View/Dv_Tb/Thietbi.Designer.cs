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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTB = new System.Windows.Forms.Panel();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 49);
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
            this.panelTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelTB.Controls.Add(this.dgvThietBi);
            this.panelTB.Controls.Add(this.btnTim);
            this.panelTB.Controls.Add(this.btnXoaPhong);
            this.panelTB.Controls.Add(this.btnThemThietBi);
            this.panelTB.Controls.Add(this.txtTim);
            this.panelTB.Location = new System.Drawing.Point(5, 55);
            this.panelTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTB.Name = "panelTB";
            this.panelTB.Size = new System.Drawing.Size(901, 383);
            this.panelTB.TabIndex = 23;
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.STT,
            this.TenThietBi,
            this.GiaThietBi,
            this.btnSua,
            this.btnXoa});
            this.dgvThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThietBi.Location = new System.Drawing.Point(29, 100);
            this.dgvThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThietBi.MultiSelect = false;
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.RowHeadersWidth = 60;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(847, 251);
            this.dgvThietBi.TabIndex = 56;
            this.dgvThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietBi_CellContentClick);
            // 
            // MaThietBi
            // 
            this.MaThietBi.HeaderText = "MaThietBi";
            this.MaThietBi.MinimumWidth = 6;
            this.MaThietBi.Name = "MaThietBi";
            this.MaThietBi.Visible = false;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
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
            // btnSua
            // 
            this.btnSua.HeaderText = "";
            this.btnSua.MinimumWidth = 6;
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTim.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 25;
            this.btnTim.Location = new System.Drawing.Point(81, 14);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(43, 42);
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
            this.btnXoaPhong.Location = new System.Drawing.Point(551, 15);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(93, 38);
            this.btnXoaPhong.TabIndex = 54;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Visible = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
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
            this.btnThemThietBi.Location = new System.Drawing.Point(661, 16);
            this.btnThemThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.Size = new System.Drawing.Size(100, 39);
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
            this.txtTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(180, 27);
            this.txtTim.TabIndex = 51;
            // 
            // Thietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTB);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Thietbi";
            this.Text = "ThietBi";
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
        private FontAwesome.Sharp.IconButton btnThemThietBi;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThietBi;
        private System.Windows.Forms.DataGridViewButtonColumn btnSua;
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}