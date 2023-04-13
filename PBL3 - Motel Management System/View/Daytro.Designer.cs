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
            this.panelDay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnThemday = new FontAwesome.Sharp.IconButton();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panPhong1 = new System.Windows.Forms.Panel();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.dtgPhong = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSuaday = new FontAwesome.Sharp.IconButton();
            this.panelDay.SuspendLayout();
            this.panPhong1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panelDay.Controls.Add(this.btnSuaday);
            this.panelDay.Controls.Add(this.label4);
            this.panelDay.Controls.Add(this.comboBox4);
            this.panelDay.Controls.Add(this.btnThemday);
            this.panelDay.Controls.Add(this.btnTim);
            this.panelDay.Controls.Add(this.label2);
            this.panelDay.Controls.Add(this.label1);
            this.panelDay.Controls.Add(this.comboBox2);
            this.panelDay.Controls.Add(this.panPhong1);
            this.panelDay.Controls.Add(this.comboBox1);
            this.panelDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDay.Location = new System.Drawing.Point(12, 69);
            this.panelDay.Name = "panelDay";
            this.panelDay.Size = new System.Drawing.Size(890, 354);
            this.panelDay.TabIndex = 3;
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
            // comboBox4
            // 
            this.comboBox4.DisplayMember = "Tình trạng";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(241, 37);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(148, 28);
            this.comboBox4.TabIndex = 34;
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
            this.btnThemday.Location = new System.Drawing.Point(638, 35);
            this.btnThemday.Name = "btnThemday";
            this.btnThemday.Size = new System.Drawing.Size(111, 43);
            this.btnThemday.TabIndex = 33;
            this.btnThemday.Text = "Thêm dãy";
            this.btnThemday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemday.UseVisualStyleBackColor = false;
            this.btnThemday.Click += new System.EventHandler(this.btnThemday_Click);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTim.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.IconSize = 25;
            this.btnTim.Location = new System.Drawing.Point(21, 30);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(35, 35);
            this.btnTim.TabIndex = 32;
            this.btnTim.UseVisualStyleBackColor = false;
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
            this.label1.Location = new System.Drawing.Point(62, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Tình trạng";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(419, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 28);
            this.comboBox2.TabIndex = 29;
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
            this.panPhong1.Controls.Add(this.dtgPhong);
            this.panPhong1.Location = new System.Drawing.Point(21, 104);
            this.panPhong1.Name = "panPhong1";
            this.panPhong1.Size = new System.Drawing.Size(845, 213);
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
            this.btnThem.Location = new System.Drawing.Point(731, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 43);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm ";
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
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 39);
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
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 39);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // dtgPhong
            // 
            this.dtgPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhong.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPhong.Location = new System.Drawing.Point(26, 12);
            this.dtgPhong.Name = "dtgPhong";
            this.dtgPhong.RowHeadersWidth = 51;
            this.dtgPhong.RowTemplate.Height = 24;
            this.dtgPhong.Size = new System.Drawing.Size(683, 187);
            this.dtgPhong.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 49);
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
            // btnSuaday
            // 
            this.btnSuaday.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSuaday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaday.BackColor = System.Drawing.Color.Orange;
            this.btnSuaday.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSuaday.IconColor = System.Drawing.Color.White;
            this.btnSuaday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaday.IconSize = 30;
            this.btnSuaday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaday.Location = new System.Drawing.Point(755, 37);
            this.btnSuaday.Name = "btnSuaday";
            this.btnSuaday.Size = new System.Drawing.Size(111, 43);
            this.btnSuaday.TabIndex = 36;
            this.btnSuaday.Text = "Sửa dãy";
            this.btnSuaday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaday.UseVisualStyleBackColor = false;
            this.btnSuaday.Click += new System.EventHandler(this.btnSuaday_Click);
            // 
            // Daytro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDay);
            this.Name = "Daytro";
            this.Text = "Day";
            this.panelDay.ResumeLayout(false);
            this.panelDay.PerformLayout();
            this.panPhong1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private FontAwesome.Sharp.IconButton btnThemday;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panPhong1;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.DataGridView dtgPhong;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnSuaday;
    }
}