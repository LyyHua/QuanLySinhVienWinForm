namespace QuanLySinhVien
{
    partial class AddStudentForm
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
            lblMaSo = new Label();
            lblTen = new Label();
            lblKhoa = new Label();
            lblDiemTB = new Label();
            txtMaSo = new TextBox();
            txtTen = new TextBox();
            txtDiemTB = new TextBox();
            cmbKhoa = new ComboBox();
            btnThemMoi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblMaSo
            // 
            lblMaSo.AutoSize = true;
            lblMaSo.Location = new Point(30, 24);
            lblMaSo.Name = "lblMaSo";
            lblMaSo.Size = new Size(110, 20);
            lblMaSo.TabIndex = 0;
            lblMaSo.Text = "Mã số sinh viên";
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(30, 65);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(93, 20);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên sinh viên";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(30, 113);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(43, 20);
            lblKhoa.TabIndex = 2;
            lblKhoa.Text = "Khoa";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Location = new Point(30, 162);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(66, 20);
            lblDiemTB.TabIndex = 3;
            lblDiemTB.Text = "Điểm TB";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(170, 21);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(197, 27);
            txtMaSo.TabIndex = 4;
            txtMaSo.TextChanged += txtMaSo_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(170, 62);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(197, 27);
            txtTen.TabIndex = 5;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(170, 159);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(197, 27);
            txtDiemTB.TabIndex = 6;
            txtDiemTB.TextChanged += txtDiemTB_TextChanged;
            // 
            // cmbKhoa
            // 
            cmbKhoa.FormattingEnabled = true;
            cmbKhoa.Items.AddRange(new object[] { "Công nghệ thông tin", "Khoa học máy tính", "Kỹ thuật phần mềm", "Kỹ thuật máy tính" });
            cmbKhoa.Location = new Point(170, 110);
            cmbKhoa.Name = "cmbKhoa";
            cmbKhoa.Size = new Size(197, 28);
            cmbKhoa.TabIndex = 7;
            cmbKhoa.SelectedIndexChanged += cmbKhoa_SelectedIndexChanged;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(30, 208);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(94, 29);
            btnThemMoi.TabIndex = 8;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(170, 208);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(cmbKhoa);
            Controls.Add(txtDiemTB);
            Controls.Add(txtTen);
            Controls.Add(txtMaSo);
            Controls.Add(lblDiemTB);
            Controls.Add(lblKhoa);
            Controls.Add(lblTen);
            Controls.Add(lblMaSo);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSo;
        private Label lblTen;
        private Label lblKhoa;
        private Label lblDiemTB;
        private TextBox txtMaSo;
        private TextBox txtTen;
        private TextBox txtDiemTB;
        private ComboBox cmbKhoa;
        private Button btnThemMoi;
        private Button btnThoat;
    }
}