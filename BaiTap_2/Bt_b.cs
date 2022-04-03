using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_2
{
    public partial class Bt_b : Form
    {
        OpenFileDialog oFDL;
        //List<string> fileList;
        public Bt_b()
        {
            InitializeComponent();
        }

        private void Bt_b_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            oFDL = new OpenFileDialog();
            oFDL.Filter = "Text files (*.txt)|*.txt";
            oFDL.Title = "Open File";
            if (oFDL.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = oFDL.FileName;
                lsbFileName.Items.Add(oFDL.FileName);
                rtbText.Text = File.ReadAllText(oFDL.FileName, Encoding.UTF8);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsbFileName.Items.Count > 0 && lsbFileName.SelectedItems.Count > 0)
            {
                lsbFileName.Items.RemoveAt(lsbFileName.SelectedIndex);
                rtbText.Text = "";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tập tin để xóa!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsbFileName_Click(object sender, EventArgs e)
        {
            if(lsbFileName.Items.Count > 0)
            {
                rtbText.Text = File.ReadAllText(lsbFileName.SelectedItem.ToString(), Encoding.UTF8);
                txtDir.Text = lsbFileName.SelectedItem.ToString();
            }
            else
            {
                return;
            }
        }
    }
}
