namespace BaiTap
{
    partial class frmNhanVien
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
            lblMSNV = new Label();
            lblTenNV = new Label();
            lblLuongCB = new Label();
            txtMSNV = new TextBox();
            txtTenNV = new TextBox();
            txtLuongCB = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lblMSNV
            // 
            lblMSNV.AutoSize = true;
            lblMSNV.Location = new Point(119, 79);
            lblMSNV.Name = "lblMSNV";
            lblMSNV.Size = new Size(40, 15);
            lblMSNV.TabIndex = 0;
            lblMSNV.Text = "MSNV";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(103, 133);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(81, 15);
            lblTenNV.TabIndex = 1;
            lblTenNV.Text = "Tên nhân viên";
            // 
            // lblLuongCB
            // 
            lblLuongCB.AutoSize = true;
            lblLuongCB.Location = new Point(103, 188);
            lblLuongCB.Name = "lblLuongCB";
            lblLuongCB.Size = new Size(86, 15);
            lblLuongCB.TabIndex = 2;
            lblLuongCB.Text = "Lương căn bản";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(203, 76);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(284, 23);
            txtMSNV.TabIndex = 3;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(203, 125);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(284, 23);
            txtTenNV.TabIndex = 4;
            // 
            // txtLuongCB
            // 
            txtLuongCB.Location = new Point(203, 185);
            txtLuongCB.Name = "txtLuongCB";
            txtLuongCB.Size = new Size(284, 23);
            txtLuongCB.TabIndex = 5;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(181, 282);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(136, 65);
            btnDongY.TabIndex = 6;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click_1;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(405, 282);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(136, 65);
            btnBoQua.TabIndex = 7;
            btnBoQua.Text = "Bỏ Quả";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtLuongCB);
            Controls.Add(txtTenNV);
            Controls.Add(txtMSNV);
            Controls.Add(lblLuongCB);
            Controls.Add(lblTenNV);
            Controls.Add(lblMSNV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSNV;
        private Label lblTenNV;
        private Label lblLuongCB;
        private TextBox txtMSNV;
        private TextBox txtTenNV;
        private TextBox txtLuongCB;
        private Button btnDongY;
        private Button btnBoQua;
    }
}