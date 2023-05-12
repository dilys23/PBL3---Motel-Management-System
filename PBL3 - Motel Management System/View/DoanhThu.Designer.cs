namespace PBL3___Motel_Management_System
{
    partial class DoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChartDuong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.ChartCot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 49);
            this.panel1.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "DOANH THU ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.ChartCot);
            this.panel2.Controls.Add(this.ChartDuong);
            this.panel2.Controls.Add(this.dgvDoanhThu);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.dtpThang);
            this.panel2.Location = new System.Drawing.Point(12, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 451);
            this.panel2.TabIndex = 42;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // ChartDuong
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartDuong.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartDuong.Legends.Add(legend2);
            this.ChartDuong.Location = new System.Drawing.Point(523, 17);
            this.ChartDuong.Name = "ChartDuong";
            this.ChartDuong.Size = new System.Drawing.Size(408, 207);
            this.ChartDuong.TabIndex = 38;
            this.ChartDuong.Text = "chart1";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.Stt,
            this.DayTro,
            this.PhongTro,
            this.TongTien});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoanhThu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDoanhThu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDoanhThu.Location = new System.Drawing.Point(18, 230);
            this.dgvDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(487, 191);
            this.dgvDoanhThu.TabIndex = 37;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "MaHoaDon";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Visible = false;
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
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
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
            this.btnTim.Location = new System.Drawing.Point(32, 30);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(35, 34);
            this.btnTim.TabIndex = 33;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(106, 34);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(124, 22);
            this.dtpThang.TabIndex = 0;
            // 
            // ChartCot
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartCot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartCot.Legends.Add(legend1);
            this.ChartCot.Location = new System.Drawing.Point(523, 230);
            this.ChartCot.Name = "ChartCot";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Dãy trọ";
            this.ChartCot.Series.Add(series1);
            this.ChartCot.Size = new System.Drawing.Size(408, 191);
            this.ChartCot.TabIndex = 39;
            this.ChartCot.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(73, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(284, 126);
            this.dataGridView1.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "STT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dãy trọ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DoanhThu";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private FontAwesome.Sharp.IconButton btnTim;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDuong;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}