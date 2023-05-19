namespace PBL3___Motel_Management_System.View
{
    partial class ChitietTB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelThem = new System.Windows.Forms.Panel();
            this.btnThemThietbi = new FontAwesome.Sharp.IconButton();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThem
            // 
            this.panelThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelThem.Controls.Add(this.btnThemThietbi);
            this.panelThem.Controls.Add(this.dgvThietBi);
            this.panelThem.Location = new System.Drawing.Point(20, 27);
            this.panelThem.Margin = new System.Windows.Forms.Padding(2);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(652, 401);
            this.panelThem.TabIndex = 50;
            // 
            // btnThemThietbi
            // 
            this.btnThemThietbi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemThietbi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemThietbi.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThemThietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThietbi.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnThemThietbi.IconColor = System.Drawing.Color.White;
            this.btnThemThietbi.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnThemThietbi.IconSize = 25;
            this.btnThemThietbi.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThemThietbi.Location = new System.Drawing.Point(523, 9);
            this.btnThemThietbi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemThietbi.Name = "btnThemThietbi";
            this.btnThemThietbi.Size = new System.Drawing.Size(109, 32);
            this.btnThemThietbi.TabIndex = 54;
            this.btnThemThietbi.Text = "Thêm thiết bị";
            this.btnThemThietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThietbi.UseVisualStyleBackColor = false;
            this.btnThemThietbi.Click += new System.EventHandler(this.btnThemThietbi_Click);
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.STT,
            this.TenThietBi,
            this.GiaThietBi,
            this.SoLuong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThietBi.GridColor = System.Drawing.Color.LightCyan;
            this.dgvThietBi.Location = new System.Drawing.Point(13, 82);
            this.dgvThietBi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThietBi.MultiSelect = false;
            this.dgvThietBi.Name = "dgvThietBi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThietBi.RowHeadersWidth = 60;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(619, 298);
            this.dgvThietBi.TabIndex = 9;
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
            this.GiaThietBi.HeaderText = "Giá";
            this.GiaThietBi.MinimumWidth = 6;
            this.GiaThietBi.Name = "GiaThietBi";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // ChitietTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.panelThem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChitietTB";
            this.Text = "ChitietTB";
            this.panelThem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThem;
        private FontAwesome.Sharp.IconButton btnThemThietbi;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}