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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuaHD = new FontAwesome.Sharp.IconButton();
            this.btnThemHD = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChisoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChisoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbPhongTro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbbPhongTro);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSuaHD);
            this.panel2.Controls.Add(this.btnThemHD);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 444);
            this.panel2.TabIndex = 29;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaHD.IconChar = FontAwesome.Sharp.IconChar.ExternalLink;
            this.btnSuaHD.IconColor = System.Drawing.Color.White;
            this.btnSuaHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaHD.IconSize = 25;
            this.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.Location = new System.Drawing.Point(831, 39);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(74, 39);
            this.btnSuaHD.TabIndex = 53;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHD.UseVisualStyleBackColor = false;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemHD.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnThemHD.IconColor = System.Drawing.Color.White;
            this.btnThemHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemHD.IconSize = 25;
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(735, 39);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(79, 39);
            this.btnThemHD.TabIndex = 52;
            this.btnThemHD.Text = "Thêm ";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDay,
            this.TenPhongTro,
            this.ChisoCu,
            this.ChisoMoi,
            this.Sudung});
            this.dataGridView1.Location = new System.Drawing.Point(26, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 250);
            this.dataGridView1.TabIndex = 8;
            // 
            // TenDay
            // 
            this.TenDay.HeaderText = "Dãy";
            this.TenDay.MinimumWidth = 6;
            this.TenDay.Name = "TenDay";
            // 
            // TenPhongTro
            // 
            this.TenPhongTro.HeaderText = "Phòng";
            this.TenPhongTro.MinimumWidth = 6;
            this.TenPhongTro.Name = "TenPhongTro";
            // 
            // ChisoCu
            // 
            this.ChisoCu.HeaderText = "Chỉ số cũ";
            this.ChisoCu.MinimumWidth = 6;
            this.ChisoCu.Name = "ChisoCu";
            // 
            // ChisoMoi
            // 
            this.ChisoMoi.HeaderText = "Chỉ số mới";
            this.ChisoMoi.MinimumWidth = 6;
            this.ChisoMoi.Name = "ChisoMoi";
            // 
            // Sudung
            // 
            this.Sudung.HeaderText = "Sử dụng";
            this.Sudung.MinimumWidth = 6;
            this.Sudung.Name = "Sudung";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 27);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thời gian:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 28);
            this.comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Dãy:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 49);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "CHỈ SỐ NƯỚC";
            // 
            // cbbPhongTro
            // 
            this.cbbPhongTro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPhongTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongTro.FormattingEnabled = true;
            this.cbbPhongTro.Location = new System.Drawing.Point(411, 53);
            this.cbbPhongTro.Name = "cbbPhongTro";
            this.cbbPhongTro.Size = new System.Drawing.Size(128, 28);
            this.cbbPhongTro.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Phòng:";
            // 
            // ChisoNuoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(973, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChisoNuoc";
            this.Text = "WaterNum";
            this.Load += new System.EventHandler(this.ChisoNuoc_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChisoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChisoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sudung;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnSuaHD;
        private FontAwesome.Sharp.IconButton btnThemHD;
        private System.Windows.Forms.ComboBox cbbPhongTro;
        private System.Windows.Forms.Label label3;
    }
}