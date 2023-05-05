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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelThem = new System.Windows.Forms.Panel();
            this.btnThemThietbi = new FontAwesome.Sharp.IconButton();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panelThem.Location = new System.Drawing.Point(27, 33);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(869, 493);
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
            this.btnThemThietbi.Location = new System.Drawing.Point(697, 11);
            this.btnThemThietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThietbi.Name = "btnThemThietbi";
            this.btnThemThietbi.Size = new System.Drawing.Size(145, 39);
            this.btnThemThietbi.TabIndex = 54;
            this.btnThemThietbi.Text = "Thêm thiết bị";
            this.btnThemThietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThietbi.UseVisualStyleBackColor = false;
            this.btnThemThietbi.Click += new System.EventHandler(this.btnThemThietbi_Click);
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThietBi.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThietBi,
            this.STT,
            this.TenThietBi,
            this.GiaThietBi,
            this.btnXoa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvThietBi.GridColor = System.Drawing.Color.LightCyan;
            this.dgvThietBi.Location = new System.Drawing.Point(17, 101);
            this.dgvThietBi.Name = "dgvThietBi";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvThietBi.RowHeadersWidth = 60;
            this.dgvThietBi.RowTemplate.Height = 24;
            this.dgvThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThietBi.Size = new System.Drawing.Size(825, 367);
            this.dgvThietBi.TabIndex = 9;
            this.dgvThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietBi_CellContentClick);
            this.dgvThietBi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvThietBi_CellFormatting);
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
            // btnXoa
            // 
            this.btnXoa.HeaderText = "";
            this.btnXoa.MinimumWidth = 6;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnXoa.Text = "";
            this.btnXoa.UseColumnTextForButtonValue = true;
            // 
            // ChitietTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(922, 558);
            this.Controls.Add(this.panelThem);
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
        private System.Windows.Forms.DataGridViewButtonColumn btnXoa;
    }
}