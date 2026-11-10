using System;
using System.Collections.Generic;
using System.Data;
using ProjectManagement.DAL;
using ProjectManagement.DTO;

namespace ProjectManagement.BUS
{
    public class TaskBUS
    {
        private TaskDAL dal = new TaskDAL();

        public DataTable LayDanhSachDuAn() => dal.GetAllDuAn();
        public DataTable LayDanhSachThanhVien() => dal.GetAllThanhVien();
        public DataTable LayDanhSachTask(int maDuAn, string trangThai) => dal.GetTasks(maDuAn, trangThai);

        public bool ThemTask(CongViecDTO task, int maThanhVien, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(task.TenTask))
            {
                error = "Tên Task không được để trống!";
                return false;
            }
            return dal.InsertTask(task, maThanhVien);
        }

        public bool CapNhatTrangThai(int maTask, string trangThaiMoi)
        {
            return dal.UpdateTaskStatus(maTask, trangThaiMoi);
        }

        public List<string> KiemTraTreHan() => dal.GetOverdueTasks();

        public DataTable ThongKeTienDo(int maDuAn) => dal.GetMemberCompletionStats(maDuAn);
    }
}