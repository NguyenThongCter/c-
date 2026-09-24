namespace BaiTap
{
    public partial class Form1 : Form
    {
        List<NhanVien> danhSachNV = new List<NhanVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            danhSachNV.Add(new NhanVien("NV001", "Nguyen Thi Thu Hien", 8500000));
            HienThiDanhSach();
        }
        private void HienThiDanhSach()
        {
            dgvDanhSach.Rows.Clear();
            foreach (NhanVien nv in danhSachNV)
            {
                dgvDanhSach.Rows.Add(nv.MSNV, nv.TenNV, nv.LuongCB);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm2 = new frmNhanVien();

            if (frm2.ShowDialog() == DialogResult.OK)
            {
                string msnv = frm2.MSNV;
                string tenNV = frm2.TenNV;
                double luongCB = double.Parse(frm2.LuongCB);

                danhSachNV.Add(new NhanVien(msnv, tenNV, luongCB));
                HienThiDanhSach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong de sua!");
                return;
            }

            int viTri = dgvDanhSach.SelectedRows[0].Index;
            NhanVien nvDangSua = danhSachNV[viTri];

            frmNhanVien frm2 = new frmNhanVien();
            frm2.MSNV = nvDangSua.MSNV;
            frm2.TenNV = nvDangSua.TenNV;
            frm2.LuongCB = nvDangSua.LuongCB.ToString();

            if (frm2.ShowDialog() == DialogResult.OK)
            {
                nvDangSua.MSNV = frm2.MSNV;
                nvDangSua.TenNV = frm2.TenNV;
                nvDangSua.LuongCB = double.Parse(frm2.LuongCB);

                HienThiDanhSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui long chon 1 dong de xoa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show("Ban co chac muon xoa?", "Xac nhan", MessageBoxButtons.YesNo);
            if (ketQua == DialogResult.Yes)
            {
                int viTri = dgvDanhSach.SelectedRows[0].Index;
                danhSachNV.RemoveAt(viTri);
                HienThiDanhSach();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
