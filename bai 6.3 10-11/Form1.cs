using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ProjectManagement.BUS;
using ProjectManagement.DTO;

namespace ProjectManagement
{
    public partial class Form1 : Form
    {
        private TaskBUS bus = new TaskBUS();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadTasks();
        }

        private void LoadComboBoxes()
        {
            // Load ComboBox Dự án
            cboDuAn.DataSource = bus.LayDanhSachDuAn();
            cboDuAn.DisplayMember = "TenDuAn";
            cboDuAn.ValueMember = "MaDuAn";

            // Load ComboBox Thành viên
            cboThanhVien.DataSource = bus.LayDanhSachThanhVien();
            cboThanhVien.DisplayMember = "HoTen";
            cboThanhVien.ValueMember = "MaThanhVien";

            // Cấu hình ComboBox Bộ lọc
            cboLocTrangThai.Items.AddRange(new string[] { "Tất cả", "To Do", "In Progress", "Review", "Done" });
            cboLocTrangThai.SelectedIndex = 0;

            // Cấu hình Độ ưu tiên
            cboDoUuTien.Items.AddRange(new string[] { "Cao", "Trung bình", "Thấp" });
            cboDoUuTien.SelectedIndex = 1;

            // ComboBox Chuyển trạng thái
            cboChuyenTrangThai.Items.AddRange(new string[] { "To Do", "In Progress", "Review", "Done" });
            cboChuyenTrangThai.SelectedIndex = 0;
        }

        private void LoadTasks()
        {
            if (cboDuAn.SelectedValue != null && int.TryParse(cboDuAn.SelectedValue.ToString(), out int maDuAn))
            {
                string trangThai = cboLocTrangThai.SelectedItem?.ToString() ?? "Tất cả";
                dgvTasks.DataSource = bus.LayDanhSachTask(maDuAn, trangThai);
            }
        }

        private void cboDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

        // Chức năng 1: Thêm mới Task
        private void btnThemTask_Click(object sender, EventArgs e)
        {
            if (cboDuAn.SelectedValue == null || cboThanhVien.SelectedValue == null) return;

            CongViecDTO task = new CongViecDTO
            {
                MaDuAn = Convert.ToInt32(cboDuAn.SelectedValue),
                TenTask = txtTenTask.Text.Trim(),
                MoTa = txtMoTa.Text.Trim(),
                HanNop = dtpHanNop.Value,
                DoUuTien = cboDoUuTien.SelectedItem.ToString(),
                TrangThai = "To Do"
            };

            int maThanhVien = Convert.ToInt32(cboThanhVien.SelectedValue);

            if (bus.ThemTask(task, maThanhVien, out string err))
            {
                MessageBox.Show("Thêm và phân công Task thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTasks();
                txtTenTask.Clear();
                txtMoTa.Clear();
            }
            else
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chức năng 2: Cập nhật Trạng thái Task
        private void btnCapNhatStatus_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 Task trên bảng để cập nhật!", "Thông báo");
                return;
            }

            int maTask = Convert.ToInt32(dgvTasks.CurrentRow.Cells["MaTask"].Value);
            string trangThaiMoi = cboChuyenTrangThai.SelectedItem.ToString();

            if (bus.CapNhatTrangThai(maTask, trangThaiMoi))
            {
                MessageBox.Show("Chuyển trạng thái thành công!", "Thông báo");
                LoadTasks();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi");
            }
        }

        // Chức năng 3: Cảnh báo trễ hạn (SqlDataReader)
        private void btnTreHan_Click(object sender, EventArgs e)
        {
            List<string> treHan = bus.KiemTraTreHan();
            if (treHan.Count == 0)
            {
                MessageBox.Show("Không có Task nào bị trễ hạn!", "Tuyệt vời", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = "DANH SÁCH CÔNG VIỆC TRỄ HẠN:\n\n" + string.Join("\n", treHan);
                MessageBox.Show(msg, "CẢNH BÁO QUÁ HẠN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chức năng 4: Thống kê tỷ lệ % hoàn thành
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cboDuAn.SelectedValue == null) return;
            int maDuAn = Convert.ToInt32(cboDuAn.SelectedValue);

            DataTable dtStats = bus.ThongKeTienDo(maDuAn);

            // Hiển thị trực tiếp kết quả thống kê lên DataGridView
            dgvTasks.DataSource = dtStats;
        }
    }
}