using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_4
{
    public partial class frmMain : Form
    {
        OpenFileDialog oFDL;
        string fileNameOpened;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtPath.ReadOnly = true;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            oFDL = new OpenFileDialog();
            oFDL.Filter = "Text files (*.txt)|*.txt";
            oFDL.Title = "Open File";
            if (oFDL.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = oFDL.FileName;
                fileNameOpened = oFDL.FileName;
                rtbNoiDung.Text = File.ReadAllText(oFDL.FileName, Encoding.UTF8);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileNameOpened, rtbNoiDung.Text);
            MessageBox.Show("Lưu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
