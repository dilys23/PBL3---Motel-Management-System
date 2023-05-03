using System.Windows.Forms;

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
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
            this.btnSuaDichVu = new FontAwesome.Sharp.IconButton();
            this.btnThemDichVu = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 49);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // panelDV
            // 
            this.panelDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDV.Controls.Add(this.btnTimKiem);
            this.panelDV.Controls.Add(this.btnXoaPhong);
            this.panelDV.Controls.Add(this.btnSuaDichVu);
            this.panelDV.Controls.Add(this.btnThemDichVu);
            this.panelDV.Controls.Add(this.txtTimKiem);
            this.panelDV.Controls.Add(this.dgvDichVu);
            this.panelDV.Location = new System.Drawing.Point(5, 55);
            this.panelDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDV.Name = "panelDV";
            this.panelDV.Size = new System.Drawing.Size(901, 383);
            this.panelDV.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnTimKiem.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.Location = new System.Drawing.Point(81, 14);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(43, 42);
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
            this.btnXoaPhong.Location = new System.Drawing.Point(797, 14);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(93, 38);
            this.btnXoaPhong.TabIndex = 54;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaPhong.UseVisualStyleBackColor = false;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
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
            this.btnSuaDichVu.Location = new System.Drawing.Point(691, 15);
            this.btnSuaDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaDichVu.Name = "btnSuaDichVu";
            this.btnSuaDichVu.Size = new System.Drawing.Size(88, 39);
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
            this.btnThemDichVu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThemDichVu.Location = new System.Drawing.Point(584, 14);
            this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(100, 39);
            this.btnThemDichVu.TabIndex = 53;
            this.btnThemDichVu.Text = "Thêm ";
            this.btnThemDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemPhong_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(143, 21);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(180, 27);
            this.txtTimKiem.TabIndex = 51;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvDichVu.AllowUserToOrderColumns = true;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDichVu.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDichVu.Location = new System.Drawing.Point(16, 73);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(872, 297);
            this.dgvDichVu.TabIndex = 50;
            // 
            // Dichvu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(915, 438);
            this.Controls.Add(this.panelDV);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dichvu";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.Resize += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDV.ResumeLayout(false);
            this.panelDV.PerformLayout();
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
    }
}