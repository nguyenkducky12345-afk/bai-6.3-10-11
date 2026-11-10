namespace ProjectManagement
{
    partial class Form1
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
            this.gbBoLoc = new System.Windows.Forms.GroupBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.lblDuAn = new System.Windows.Forms.Label();
            this.cboDuAn = new System.Windows.Forms.ComboBox();
            this.gbThongTinTask = new System.Windows.Forms.GroupBox();
            this.btnThemTask = new System.Windows.Forms.Button();
            this.cboThanhVien = new System.Windows.Forms.ComboBox();
            this.lblThanhVien = new System.Windows.Forms.Label();
            this.cboDoUuTien = new System.Windows.Forms.ComboBox();
            this.lblDoUuTien = new System.Windows.Forms.Label();
            this.dtpHanNop = new System.Windows.Forms.DateTimePicker();
            this.lblHanNop = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtTenTask = new System.Windows.Forms.TextBox();
            this.lblTenTask = new System.Windows.Forms.Label();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.gbTacVu = new System.Windows.Forms.GroupBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnTreHan = new System.Windows.Forms.Button();
            this.btnCapNhatStatus = new System.Windows.Forms.Button();
            this.cboChuyenTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThaiMoi = new System.Windows.Forms.Label();
            this.gbBoLoc.SuspendLayout();
            this.gbThongTinTask.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.gbTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBoLoc
            // 
            this.gbBoLoc.Controls.Add(this.lblLocTrangThai);
            this.gbBoLoc.Controls.Add(this.cboLocTrangThai);
            this.gbBoLoc.Controls.Add(this.lblDuAn);
            this.gbBoLoc.Controls.Add(this.cboDuAn);
            this.gbBoLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBoLoc.Location = new System.Drawing.Point(12, 12);
            this.gbBoLoc.Name = "gbBoLoc";
            this.gbBoLoc.Size = new System.Drawing.Size(960, 65);
            this.gbBoLoc.TabIndex = 0;
            this.gbBoLoc.TabStop = false;
            this.gbBoLoc.Text = "Bộ lọc và Tìm kiếm";
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Location = new System.Drawing.Point(450, 28);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(89, 15);
            this.lblLocTrangThai.TabIndex = 3;
            this.lblLocTrangThai.Text = "Lọc Trạng thái:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(545, 25);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(180, 23);
            this.cboLocTrangThai.TabIndex = 2;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboLocTrangThai_SelectedIndexChanged);
            // 
            // lblDuAn
            // 
            this.lblDuAn.AutoSize = true;
            this.lblDuAn.Location = new System.Drawing.Point(20, 28);
            this.lblDuAn.Name = "lblDuAn";
            this.lblDuAn.Size = new System.Drawing.Size(76, 15);
            this.lblDuAn.TabIndex = 1;
            this.lblDuAn.Text = "Chọn Dự án:";
            // 
            // cboDuAn
            // 
            this.cboDuAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDuAn.FormattingEnabled = true;
            this.cboDuAn.Location = new System.Drawing.Point(102, 25);
            this.cboDuAn.Name = "cboDuAn";
            this.cboDuAn.Size = new System.Drawing.Size(300, 23);
            this.cboDuAn.TabIndex = 0;
            this.cboDuAn.SelectedIndexChanged += new System.EventHandler(this.cboDuAn_SelectedIndexChanged);
            // 
            // gbThongTinTask
            // 
            this.gbThongTinTask.Controls.Add(this.btnThemTask);
            this.gbThongTinTask.Controls.Add(this.cboThanhVien);
            this.gbThongTinTask.Controls.Add(this.lblThanhVien);
            this.gbThongTinTask.Controls.Add(this.cboDoUuTien);
            this.gbThongTinTask.Controls.Add(this.lblDoUuTien);
            this.gbThongTinTask.Controls.Add(this.dtpHanNop);
            this.gbThongTinTask.Controls.Add(this.lblHanNop);
            this.gbThongTinTask.Controls.Add(this.txtMoTa);
            this.gbThongTinTask.Controls.Add(this.lblMoTa);
            this.gbThongTinTask.Controls.Add(this.txtTenTask);
            this.gbThongTinTask.Controls.Add(this.lblTenTask);
            this.gbThongTinTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinTask.Location = new System.Drawing.Point(12, 83);
            this.gbThongTinTask.Name = "gbThongTinTask";
            this.gbThongTinTask.Size = new System.Drawing.Size(330, 485);
            this.gbThongTinTask.TabIndex = 1;
            this.gbThongTinTask.TabStop = false;
            this.gbThongTinTask.Text = "Tạo Task & Phân công";
            // 
            // btnThemTask
            // 
            this.btnThemTask.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTask.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTask.ForeColor = System.Drawing.Color.White;
            this.btnThemTask.Location = new System.Drawing.Point(19, 410);
            this.btnThemTask.Name = "btnThemTask";
            this.btnThemTask.Size = new System.Drawing.Size(288, 40);
            this.btnThemTask.TabIndex = 10;
            this.btnThemTask.Text = "➕ Thêm Task && Phân Công";
            this.btnThemTask.UseVisualStyleBackColor = false;
            this.btnThemTask.Click += new System.EventHandler(this.btnThemTask_Click);
            // 
            // cboThanhVien
            // 
            this.cboThanhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThanhVien.FormattingEnabled = true;
            this.cboThanhVien.Location = new System.Drawing.Point(19, 360);
            this.cboThanhVien.Name = "cboThanhVien";
            this.cboThanhVien.Size = new System.Drawing.Size(288, 23);
            this.cboThanhVien.TabIndex = 9;
            // 
            // lblThanhVien
            // 
            this.lblThanhVien.AutoSize = true;
            this.lblThanhVien.Location = new System.Drawing.Point(16, 340);
            this.lblThanhVien.Name = "lblThanhVien";
            this.lblThanhVien.Size = new System.Drawing.Size(126, 15);
            this.lblThanhVien.TabIndex = 8;
            this.lblThanhVien.Text = "Phân công thành viên:";
            // 
            // cboDoUuTien
            // 
            this.cboDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoUuTien.FormattingEnabled = true;
            this.cboDoUuTien.Location = new System.Drawing.Point(19, 300);
            this.cboDoUuTien.Name = "cboDoUuTien";
            this.cboDoUuTien.Size = new System.Drawing.Size(288, 23);
            this.cboDoUuTien.TabIndex = 7;
            // 
            // lblDoUuTien
            // 
            this.lblDoUuTien.AutoSize = true;
            this.lblDoUuTien.Location = new System.Drawing.Point(16, 280);
            this.lblDoUuTien.Name = "lblDoUuTien";
            this.lblDoUuTien.Size = new System.Drawing.Size(65, 15);
            this.lblDoUuTien.TabIndex = 6;
            this.lblDoUuTien.Text = "Độ ưu tiên:";
            // 
            // dtpHanNop
            // 
            this.dtpHanNop.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpHanNop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanNop.Location = new System.Drawing.Point(19, 240);
            this.dtpHanNop.Name = "dtpHanNop";
            this.dtpHanNop.Size = new System.Drawing.Size(288, 23);
            this.dtpHanNop.TabIndex = 5;
            // 
            // lblHanNop
            // 
            this.lblHanNop.AutoSize = true;
            this.lblHanNop.Location = new System.Drawing.Point(16, 220);
            this.lblHanNop.Name = "lblHanNop";
            this.lblHanNop.Size = new System.Drawing.Size(56, 15);
            this.lblHanNop.TabIndex = 4;
            this.lblHanNop.Text = "Hạn nộp:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(19, 110);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(288, 95);
            this.txtMoTa.TabIndex = 3;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(16, 90);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(70, 15);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả Task:";
            // 
            // txtTenTask
            // 
            this.txtTenTask.Location = new System.Drawing.Point(19, 50);
            this.txtTenTask.Name = "txtTenTask";
            this.txtTenTask.Size = new System.Drawing.Size(288, 23);
            this.txtTenTask.TabIndex = 1;
            // 
            // lblTenTask
            // 
            this.lblTenTask.AutoSize = true;
            this.lblTenTask.Location = new System.Drawing.Point(16, 30);
            this.lblTenTask.Name = "lblTenTask";
            this.lblTenTask.Size = new System.Drawing.Size(55, 15);
            this.lblTenTask.TabIndex = 0;
            this.lblTenTask.Text = "Tên Task:";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Controls.Add(this.dgvTasks);
            this.gbDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDanhSach.Location = new System.Drawing.Point(358, 83);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(614, 385);
            this.gbDanhSach.TabIndex = 2;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "Danh sách Công việc";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.Location = new System.Drawing.Point(3, 19);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(608, 363);
            this.dgvTasks.TabIndex = 0;
            // 
            // gbTacVu
            // 
            this.gbTacVu.Controls.Add(this.btnBaoCao);
            this.gbTacVu.Controls.Add(this.btnTreHan);
            this.gbTacVu.Controls.Add(this.btnCapNhatStatus);
            this.gbTacVu.Controls.Add(this.cboChuyenTrangThai);
            this.gbTacVu.Controls.Add(this.lblTrangThaiMoi);
            this.gbTacVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTacVu.Location = new System.Drawing.Point(358, 474);
            this.gbTacVu.Name = "gbTacVu";
            this.gbTacVu.Size = new System.Drawing.Size(614, 94);
            this.gbTacVu.TabIndex = 3;
            this.gbTacVu.TabStop = false;
            this.gbTacVu.Text = "Tác vụ & Báo cáo";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(470, 35);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(130, 35);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "📊 Báo cáo % Done";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnTreHan
            // 
            this.btnTreHan.BackColor = System.Drawing.Color.IndianRed;
            this.btnTreHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreHan.ForeColor = System.Drawing.Color.White;
            this.btnTreHan.Location = new System.Drawing.Point(325, 35);
            this.btnTreHan.Name = "btnTreHan";
            this.btnTreHan.Size = new System.Drawing.Size(135, 35);
            this.btnTreHan.TabIndex = 3;
            this.btnTreHan.Text = "⚠️ Cảnh báo Trễ hạn";
            this.btnTreHan.UseVisualStyleBackColor = false;
            this.btnTreHan.Click += new System.EventHandler(this.btnTreHan_Click);
            // 
            // btnCapNhatStatus
            // 
            this.btnCapNhatStatus.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCapNhatStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatStatus.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatStatus.Location = new System.Drawing.Point(195, 35);
            this.btnCapNhatStatus.Name = "btnCapNhatStatus";
            this.btnCapNhatStatus.Size = new System.Drawing.Size(120, 35);
            this.btnCapNhatStatus.TabIndex = 2;
            this.btnCapNhatStatus.Text = "🔄 Chuyển Trạng thái";
            this.btnCapNhatStatus.UseVisualStyleBackColor = false;
            this.btnCapNhatStatus.Click += new System.EventHandler(this.btnCapNhatStatus_Click);
            // 
            // cboChuyenTrangThai
            // 
            this.cboChuyenTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenTrangThai.FormattingEnabled = true;
            this.cboChuyenTrangThai.Location = new System.Drawing.Point(15, 42);
            this.cboChuyenTrangThai.Name = "cboChuyenTrangThai";
            this.cboChuyenTrangThai.Size = new System.Drawing.Size(170, 23);
            this.cboChuyenTrangThai.TabIndex = 1;
            // 
            // lblTrangThaiMoi
            // 
            this.lblTrangThaiMoi.AutoSize = true;
            this.lblTrangThaiMoi.Location = new System.Drawing.Point(12, 23);
            this.lblTrangThaiMoi.Name = "lblTrangThaiMoi";
            this.lblTrangThaiMoi.Size = new System.Drawing.Size(92, 15);
            this.lblTrangThaiMoi.TabIndex = 0;
            this.lblTrangThaiMoi.Text = "Trạng thái mới:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.gbTacVu);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTinTask);
            this.Controls.Add(this.gbBoLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Công Việc & Tiến Độ Dự Án (3-Tier)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbBoLoc.ResumeLayout(false);
            this.gbBoLoc.PerformLayout();
            this.gbThongTinTask.ResumeLayout(false);
            this.gbThongTinTask.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.gbTacVu.ResumeLayout(false);
            this.gbTacVu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBoLoc;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label lblDuAn;
        private System.Windows.Forms.ComboBox cboDuAn;
        private System.Windows.Forms.GroupBox gbThongTinTask;
        private System.Windows.Forms.Button btnThemTask;
        private System.Windows.Forms.ComboBox cboThanhVien;
        private System.Windows.Forms.Label lblThanhVien;
        private System.Windows.Forms.ComboBox cboDoUuTien;
        private System.Windows.Forms.Label lblDoUuTien;
        private System.Windows.Forms.DateTimePicker dtpHanNop;
        private System.Windows.Forms.Label lblHanNop;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtTenTask;
        private System.Windows.Forms.Label lblTenTask;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.GroupBox gbTacVu;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnTreHan;
        private System.Windows.Forms.Button btnCapNhatStatus;
        private System.Windows.Forms.ComboBox cboChuyenTrangThai;
        private System.Windows.Forms.Label lblTrangThaiMoi;
    }
}