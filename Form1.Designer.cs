namespace BaiTap
{
    partial class Form1
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
            dgvDanhSach = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvDanhSach.Dock = DockStyle.Left;
            dgvDanhSach.Location = new Point(0, 0);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.Size = new Size(407, 450);
            dgvDanhSach.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "MSNV";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Ten NV";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "LuongCB";
            Column3.Name = "Column3";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(491, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(222, 63);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(491, 103);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(222, 63);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(491, 192);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(222, 63);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(491, 292);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(222, 63);
            btnDong.TabIndex = 4;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvDanhSach);
            Name = "Form1";
            Text = "ListView";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhSach;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDong;
    }
}
