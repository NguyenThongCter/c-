using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string MSNV
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string TenNV
        {
            get { return txtTenNV.Text; }
            set { txtTenNV.Text = value; }
        }

        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public string LuongCB
        {
            get { return txtLuongCB.Text; }
            set { txtLuongCB.Text = value; }
        }
        private void btnDongY_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}