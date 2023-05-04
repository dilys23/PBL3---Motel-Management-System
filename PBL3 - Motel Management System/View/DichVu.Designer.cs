using System.Drawing;
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
            this.btnThemDichVu = new FontAwesome.Sharp.IconButton();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoaPhong = new FontAwesome.Sharp.IconButton();
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
            this.panelDV.Controls.Add(this.txtTim);
            this.panelDV.Controls.Add(this.btnTimKiem);
            this.panelDV.Controls.Add(this.btnXoaPhong);
            this.panelDV.Controls.Add(this.btnThemDichVu);
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
            this.btnTimKiem.Location = new System.Drawing.Point(47, 13);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(43, 42);
            this.btnTimKiem.TabIndex = 55;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnThemDichVu.Location = new System.Drawing.Point(788, 16);
            this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(100, 39);
            this.btnThemDichVu.TabIndex = 53;
            this.btnThemDichVu.Text = "Thêm ";
            this.btnThemDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemPhong_Click_1);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToOrderColumns = true;
            this.dgvDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDichVu.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDichVu.Location = new System.Drawing.Point(16, 73);
            this.dgvDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 70;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(872, 297);
            this.dgvDichVu.TabIndex = 50;
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(109, 22);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(177, 30);
            this.txtTim.TabIndex = 56;
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
            this.btnXoaPhong.Location = new System.Drawing.Point(689, 14);
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
        private FontAwesome.Sharp.IconButton btnThemDichVu;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private TextBox txtTim;
        private FontAwesome.Sharp.IconButton btnXoaPhong;
    }
}