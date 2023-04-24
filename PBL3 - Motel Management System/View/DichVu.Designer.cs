namespace PBL3___Motel_Management_System
{
    partial class Dichvu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDV = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
            this.btnSuaDichVu = new FontAwesome.Sharp.IconButton();
            this.btnThemDichVu = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 40);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // panelDV
            // 
            this.panelDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDV.Controls.Add(this.iconButton1);
            this.panelDV.Controls.Add(this.iconButton2);
            this.panelDV.Controls.Add(this.iconButton3);
            this.panelDV.Controls.Add(this.iconButton4);
            this.panelDV.Controls.Add(this.textBox1);
            this.panelDV.Controls.Add(this.dataGridView1);
            this.panelDV.Controls.Add(this.btnTimKiem);
            this.panelDV.Controls.Add(this.btnXoaPhong);
            this.panelDV.Controls.Add(this.btnSuaDichVu);
            this.panelDV.Controls.Add(this.btnThemDichVu);
            this.panelDV.Controls.Add(this.txtTimKiem);
            this.panelDV.Controls.Add(this.dgvDichVu);
            this.panelDV.Location = new System.Drawing.Point(4, 45);
            this.panelDV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDV.Name = "panelDV";
            this.panelDV.Size = new System.Drawing.Size(676, 311);
            this.panelDV.TabIndex = 21;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(37, 248);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 42);
            this.iconButton1.TabIndex = 61;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Red;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(754, 249);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(94, 38);
            this.iconButton2.TabIndex = 60;
            this.iconButton2.Text = "Xóa";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(646, 250);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(88, 39);
            this.iconButton3.TabIndex = 58;
            this.iconButton3.Text = "Sửa";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            this.iconButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 25;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(540, 249);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(100, 40);
            this.iconButton4.TabIndex = 59;
            this.iconButton4.Text = "Thêm ";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 27);
            this.textBox1.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(20, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(872, 173);
            this.dataGridView1.TabIndex = 56;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.Location = new System.Drawing.Point(61, 11);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(32, 34);
            this.btnTimKiem.TabIndex = 55;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnXoaPhong.Location = new System.Drawing.Point(598, 11);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(70, 31);
            this.btnXoaPhong.TabIndex = 54;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            // 
            // btnSuaDichVu
            // 
            this.btnSuaDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSuaDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaDichVu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDichVu.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnSuaDichVu.IconColor = System.Drawing.Color.White;
            this.btnSuaDichVu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaDichVu.IconSize = 25;
            this.btnSuaDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDichVu.Location = new System.Drawing.Point(518, 12);
            this.btnSuaDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaDichVu.Name = "btnSuaDichVu";
            this.btnSuaDichVu.Size = new System.Drawing.Size(66, 32);
            this.btnSuaDichVu.TabIndex = 52;
            this.btnSuaDichVu.Text = "Sửa";
            this.btnSuaDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDichVu.UseVisualStyleBackColor = false;
            this.btnSuaDichVu.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnThemDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemDichVu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnThemDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDichVu.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
            this.btnThemDichVu.IconColor = System.Drawing.Color.White;
            this.btnThemDichVu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnThemDichVu.IconSize = 25;
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(438, 11);
            this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(75, 32);
            this.btnThemDichVu.TabIndex = 53;
            this.btnThemDichVu.Text = "Thêm ";
            this.btnThemDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemPhong_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(107, 17);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(136, 23);
            this.txtTimKiem.TabIndex = 51;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDichVu.Location = new System.Drawing.Point(12, 59);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(654, 241);
            this.dgvDichVu.TabIndex = 50;
            // 
            // Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(686, 356);
            this.Controls.Add(this.panelDV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dichvu";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.Resize += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDV.ResumeLayout(false);
            this.panelDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelDV;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoaPhong;
        private FontAwesome.Sharp.IconButton btnSuaDichVu;
        private FontAwesome.Sharp.IconButton btnThemDichVu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}