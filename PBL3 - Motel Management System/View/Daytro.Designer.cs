namespace PBL3___Motel_Management_System.View
{
    partial class Daytro
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
            this.panelDay = new System.Windows.Forms.Panel();
            this.txtTenDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnThemday = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panPhong1 = new System.Windows.Forms.Panel();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.dtgDayTro = new System.Windows.Forms.DataGridView();
            this.cbbDayTro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelDay.SuspendLayout();
            this.panPhong1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDayTro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDay
            // 
            this.panelDay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panelDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDay.Controls.Add(this.txtTenDay);
            this.panelDay.Controls.Add(this.label4);
            this.panelDay.Controls.Add(this.cbbTinhTrang);
            this.panelDay.Controls.Add(this.btnThemday);
            this.panelDay.Controls.Add(this.btnTimKiem);
            this.panelDay.Controls.Add(this.label2);
            this.panelDay.Controls.Add(this.label1);
            this.panelDay.Controls.Add(this.panPhong1);
            this.panelDay.Controls.Add(this.cbbDayTro);
            this.panelDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDay.Location = new System.Drawing.Point(12, 69);
            this.panelDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(889, 354);
            this.panelDay.TabIndex = 3;
            // 
            // txtTenDay
            // 
            this.txtTenDay.Location = new System.Drawing.Point(549, 38);
            this.txtTenDay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDay.Name = "txtTenDay";
            this.txtTenDay.Size = new System.Drawing.Size(132, 22);
            this.txtTenDay.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 35;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.DisplayMember = "Tình trạng";
            this.cbbTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(320, 34);
            this.cbbTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(148, 28);
            this.cbbTinhTrang.TabIndex = 34;
            // 
            // btnThemday
            // 
            this.btnThemday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThemday.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            this.btnThemday.IconColor = System.Drawing.Color.White;
            this.btnThemday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemday.IconSize = 30;
            this.btnThemday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemday.Location = new System.Drawing.Point(828, 30);
            this.btnThemday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemday.Name = "btnThemday";
            this.btnThemday.Size = new System.Drawing.Size(38, 37);
            this.btnThemday.TabIndex = 33;
            this.btnThemday.Tag = "Thêm dãy";
            this.btnThemday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemday.UseVisualStyleBackColor = false;
            this.btnThemday.Click += new System.EventHandler(this.btnThemday_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(21, 30);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(35, 34);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 30;
            // 
            // panPhong1
            // 
            this.panPhong1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPhong1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panPhong1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPhong1.Controls.Add(this.btnThem);
            this.panPhong1.Controls.Add(this.btnSua);
            this.panPhong1.Controls.Add(this.btnXoa);
            this.panPhong1.Controls.Add(this.dtgDayTro);
            this.panPhong1.Location = new System.Drawing.Point(21, 103);
            this.panPhong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panPhong1.Name = "panPhong1";
            this.panPhong1.Size = new System.Drawing.Size(845, 212);
            this.panPhong1.TabIndex = 28;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 25;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(731, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 43);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Chi tiết";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 25;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(731, 84);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 39);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 25;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(731, 129);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 39);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dtgDayTro
            // 
            this.dtgDayTro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDayTro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDayTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDayTro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgDayTro.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDayTro.Location = new System.Drawing.Point(27, 12);
            this.dtgDayTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgDayTro.Name = "dtgDayTro";
            this.dtgDayTro.RowHeadersWidth = 51;
            this.dtgDayTro.RowTemplate.Height = 24;
            this.dtgDayTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDayTro.Size = new System.Drawing.Size(683, 187);
            this.dtgDayTro.TabIndex = 24;
            // 
            // cbbDayTro
            // 
            this.cbbDayTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDayTro.FormattingEnabled = true;
            this.cbbDayTro.Location = new System.Drawing.Point(65, 34);
            this.cbbDayTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDayTro.Name = "cbbDayTro";
            this.cbbDayTro.Size = new System.Drawing.Size(148, 28);
            this.cbbDayTro.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 49);
            this.panel1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Chocolate;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 28);
            this.label7.TabIndex = 36;
            this.label7.Text = "DACH SÁCH DÃY";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Daytro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Daytro";
            this.Text = "Day";
            this.Load += new System.EventHandler(this.Daytro_Load);
            this.MouseHover += new System.EventHandler(this.btnThemday_Click);
            this.panelDay.ResumeLayout(false);
            this.panelDay.PerformLayout();
            this.panPhong1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDayTro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private FontAwesome.Sharp.IconButton btnThemday;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panPhong1;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.DataGridView dtgDayTro;
        private System.Windows.Forms.ComboBox cbbDayTro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.TextBox txtTenDay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}