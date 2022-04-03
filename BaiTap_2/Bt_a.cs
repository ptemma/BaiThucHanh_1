using BaiTap_1;
using System.ComponentModel;

namespace BaiTap_2
{
    public partial class frmDSSV : Form
    {
        BindingSource dts = new BindingSource();
        List<SinhVien> lstSV;
        public frmDSSV()
        {
            InitializeComponent();
        }

        public void GanDuLieu()
        {
            if (lstSV.Count > 0)
            {
                txtMSSV.Text = dgvDSSV[0, dgvDSSV.CurrentRow.Index].Value.ToString();
                txtHo.Text = dgvDSSV[1, dgvDSSV.CurrentRow.Index].Value.ToString();
                txtTen.Text = dgvDSSV[2, dgvDSSV.CurrentRow.Index].Value.ToString();
                txtNgaySinh.Text = DateTime.Parse(dgvDSSV[3, dgvDSSV.CurrentRow.Index].Value.ToString()).ToString("dd/MM/yyyy");
                txtMaLop.Text = dgvDSSV[4, dgvDSSV.CurrentRow.Index].Value.ToString();
            }
            else
            {
                txtMSSV.Clear();
                txtHo.Clear();
                txtTen.Clear();
                txtNgaySinh.Clear();
                txtMaLop.Clear();
            }
        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            lstSV = new List<SinhVien>();
            dts.DataSource = lstSV;
            dts.ResetBindings(true);
            dgvDSSV.DataSource = dts;
            dgvDSSV.Width = 760;
            dgvDSSV.Columns[0].HeaderText = "MSSV";
            dgvDSSV.Columns[0].Width = 120;
            dgvDSSV.Columns[1].HeaderText = "Họ";
            dgvDSSV.Columns[1].Width = 150;
            dgvDSSV.Columns[2].HeaderText = "Tên";
            dgvDSSV.Columns[2].Width = 150;
            dgvDSSV.Columns[3].HeaderText = "Ngày sinh";
            dgvDSSV.Columns[3].Width = 140;
            dgvDSSV.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDSSV.Columns[4].HeaderText = "Mã lớp";
            dgvDSSV.Columns[4].Width = 140;

            dgvDSSV.AllowUserToAddRows = false;
            dgvDSSV.AllowUserToDeleteRows = false;
            dgvDSSV.EditMode = DataGridViewEditMode.EditProgrammatically;

            SinhVien sv1 = new SinhVien("SV001", "Lê", "Hà", new DateTime(2000, 01, 01), "L001");
            lstSV.Add(sv1);
            SinhVien sv2 = new SinhVien("SV002", "Nguyễn", "Long", new DateTime(2000, 12, 21), "L001");
            lstSV.Add(sv2);
            SinhVien sv3 = new SinhVien("SV003", "Trần", "Linh", new DateTime(1999, 07, 08), "L002");
            lstSV.Add(sv3);
            dts.ResetBindings(false);
            GanDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            if (txtMSSV.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtNgaySinh.Text == "" || txtMaLop.Text == "")
            {
                MessageBox.Show("Lỗi nhập dữ liệu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sv.Mssv = txtMSSV.Text;
                sv.Ho = txtHo.Text;
                sv.Ten = txtTen.Text;
                sv.Ngaysinh = DateTime.Parse(txtNgaySinh.Text);
                sv.Malop = txtMaLop.Text;
                lstSV.Add(sv);
                dts.ResetBindings(false);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            SinhVien temp;
            for (int i = 0; i < lstSV.Count; i++)
            {
                for (int j = i + 1; j < lstSV.Count; j++)
                {
                    if (lstSV[i].Ngaysinh > lstSV[j].Ngaysinh)
                    {
                        temp = lstSV[i];
                        lstSV[i] = lstSV[j];
                        lstSV[j] = temp;
                    }
                }
            }
            dts.ResetBindings(false);
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var itemToRemove = lstSV.Single(r => r.Mssv == txtMSSV.Text);
            if(itemToRemove != null)
            {
                lstSV.Remove(itemToRemove);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dts.ResetBindings(false);
        }
    }
}