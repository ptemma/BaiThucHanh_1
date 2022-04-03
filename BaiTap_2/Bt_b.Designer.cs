namespace BaiTap_2
{
    partial class Bt_b
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lsbFileName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Các tập tin:";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(456, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(89, 27);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(114, 60);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(217, 92);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(328, 244);
            this.rtbText.TabIndex = 5;
            this.rtbText.Text = "";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(87, 12);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(351, 27);
            this.txtDir.TabIndex = 6;
            // 
            // lsbFileName
            // 
            this.lsbFileName.FormattingEnabled = true;
            this.lsbFileName.ItemHeight = 20;
            this.lsbFileName.Location = new System.Drawing.Point(12, 92);
            this.lsbFileName.Name = "lsbFileName";
            this.lsbFileName.Size = new System.Drawing.Size(186, 244);
            this.lsbFileName.TabIndex = 7;
            this.lsbFileName.Click += new System.EventHandler(this.lsbFileName_Click);
            // 
            // Bt_b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 350);
            this.Controls.Add(this.lsbFileName);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bt_b";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bt_b";
            this.Load += new System.EventHandler(this.Bt_b_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnOpen;
        private Button btnXoa;
        private RichTextBox rtbText;
        private TextBox txtDir;
        private ListBox lsbFileName;
    }
}