namespace BaiTap_4
{
    partial class frmMain
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
            txtPath = new TextBox();
            btnDoc = new Button();
            btnLuu = new Button();
            rtbNoiDung = new RichTextBox();
            SuspendLayout();
            // 
            // txtPath
            // 
            txtPath.Location = new Point(10, 9);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(444, 27);
            txtPath.TabIndex = 0;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(470, 9);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(143, 27);
            btnDoc.TabIndex = 1;
            btnDoc.Text = "Chọn tập tin đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(619, 9);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(143, 27);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu sửa đổi";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Location = new Point(13, 47);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(750, 389);
            rtbNoiDung.TabIndex = 3;
            rtbNoiDung.Text = "";
            rtbNoiDung.TextChanged += rtbNoiDung_TextChanged;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnLuu);
            Controls.Add(btnDoc);
            Controls.Add(txtPath);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPath;
        private Button btnDoc;
        private Button btnLuu;
        private RichTextBox rtbNoiDung;
    }
}