namespace BaiTap_2
{
    partial class frmDSSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnXoa = new Button();
            btnSapXep = new Button();
            btnThem = new Button();
            txtTen = new TextBox();
            label5 = new Label();
            txtMaLop = new TextBox();
            label4 = new Label();
            txtHo = new TextBox();
            label3 = new Label();
            txtNgaySinh = new TextBox();
            label2 = new Label();
            txtMSSV = new TextBox();
            label1 = new Label();
            dgvDSSV = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSapXep);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtHo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNgaySinh);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMSSV);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgvDSSV);
            groupBox1.Location = new Point(9, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(787, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh vien Lớp lập trình ứng dụng mạng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(691, 346);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 37);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSapXep
            // 
            btnSapXep.Location = new Point(600, 346);
            btnSapXep.Name = "btnSapXep";
            btnSapXep.Size = new Size(85, 37);
            btnSapXep.TabIndex = 12;
            btnSapXep.Text = "Sắp xếp";
            btnSapXep.UseVisualStyleBackColor = true;
            btnSapXep.Click += btnSapXep_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(509, 346);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 37);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(550, 313);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(226, 27);
            txtTen.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(509, 316);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 9;
            label5.Text = "Tên:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(344, 351);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(159, 27);
            txtMaLop.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 354);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Mã lớp";
            // 
            // txtHo
            // 
            txtHo.Location = new Point(320, 313);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(183, 27);
            txtHo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 316);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 5;
            label3.Text = "Họ:";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(97, 351);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(179, 27);
            txtNgaySinh.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 354);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Ngày sinh:";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(70, 313);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(206, 27);
            txtMSSV.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 316);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "MSSV:";
            // 
            // dgvDSSV
            // 
            dgvDSSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDSSV.Location = new Point(14, 26);
            dgvDSSV.Name = "dgvDSSV";
            dgvDSSV.RowHeadersWidth = 51;
            dgvDSSV.RowTemplate.Height = 29;
            dgvDSSV.Size = new Size(762, 281);
            dgvDSSV.TabIndex = 0;
            dgvDSSV.CellClick += dgvDSSV_CellClick;
            // 
            // frmDSSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 407);
            Controls.Add(groupBox1);
            Name = "frmDSSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách sinh viên";
            Load += frmDSSV_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDSSV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvDSSV;
        private Button btnXoa;
        private Button btnSapXep;
        private Button btnThem;
        private TextBox txtTen;
        private Label label5;
        private TextBox txtMaLop;
        private Label label4;
        private TextBox txtHo;
        private Label label3;
        private TextBox txtNgaySinh;
        private Label label2;
        private TextBox txtMSSV;
        private Label label1;
    }
}