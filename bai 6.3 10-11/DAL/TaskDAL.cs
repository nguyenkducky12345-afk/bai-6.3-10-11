using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ProjectManagement.DTO;

namespace ProjectManagement.DAL
{
    public class TaskDAL : DatabaseAccess
    {
        // Lấy danh sách dự án
        public DataTable GetAllDuAn()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaDuAn, TenDuAn FROM DuAn", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Lấy danh sách thành viên
        public DataTable GetAllThanhVien()
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaThanhVien, HoTen FROM ThanhVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Lọc Task theo Dự Án và Trạng Thái
        public DataTable GetTasks(int maDuAn, string trangThai)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT * FROM CongViec WHERE MaDuAn = @MaDuAn";
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    sql += " AND TrangThai = @TrangThai";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                {
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Thêm mới Task và Phân công (Transaction)
        public bool InsertTask(CongViecDTO task, int maThanhVien)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string insertTaskQuery = @"INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai)
                                               OUTPUT INSERTED.MaTask
                                               VALUES (@MaDuAn, @TenTask, @MoTa, @HanNop, @DoUuTien, @TrangThai)";
                    SqlCommand cmdTask = new SqlCommand(insertTaskQuery, conn, trans);
                    cmdTask.Parameters.AddWithValue("@MaDuAn", task.MaDuAn);
                    cmdTask.Parameters.AddWithValue("@TenTask", task.TenTask);
                    cmdTask.Parameters.AddWithValue("@MoTa", task.MoTa ?? (object)DBNull.Value);
                    cmdTask.Parameters.AddWithValue("@HanNop", task.HanNop);
                    cmdTask.Parameters.AddWithValue("@DoUuTien", task.DoUuTien);
                    cmdTask.Parameters.AddWithValue("@TrangThai", task.TrangThai);

                    int newTaskId = (int)cmdTask.ExecuteScalar();

                    // Phân công thành viên
                    string insertPhanCong = "INSERT INTO PhanCong (MaTask, MaThanhVien) VALUES (@MaTask, @MaThanhVien)";
                    SqlCommand cmdPC = new SqlCommand(insertPhanCong, conn, trans);
                    cmdPC.Parameters.AddWithValue("@MaTask", newTaskId);
                    cmdPC.Parameters.AddWithValue("@MaThanhVien", maThanhVien);
                    cmdPC.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        // Cập nhật trạng thái Task (Parameterized SQL Update)
        public bool UpdateTaskStatus(int maTask, string trangThaiMoi)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = "UPDATE CongViec SET TrangThai = @TrangThai WHERE MaTask = @MaTask";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TrangThai", trangThaiMoi);
                cmd.Parameters.AddWithValue("@MaTask", maTask);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Yêu cầu 3.1: Dùng SqlDataReader cảnh báo Task trễ hạn (HanNop < GetDate() & TrangThai != 'Done')
        public List<string> GetOverdueTasks()
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = GetConnection())
            {
                string sql = "SELECT TenTask, HanNop, TrangThai FROM CongViec WHERE HanNop < GETDATE() AND TrangThai != 'Done'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string info = $"Task: {reader["TenTask"]} | Hạn: {Convert.ToDateTime(reader["HanNop"]).ToString("dd/MM/yyyy")} | Trạng thái: {reader["TrangThai"]}";
                        list.Add(info);
                    }
                }
            }
            return list;
        }

        // Yêu cầu 3.2: Báo cáo tỷ lệ % hoàn thành theo từng thành viên
        public DataTable GetMemberCompletionStats(int maDuAn)
        {
            using (SqlConnection conn = GetConnection())
            {
                string sql = @"
                    SELECT 
                        tv.HoTen,
                        COUNT(cv.MaTask) AS TongTask,
                        SUM(CASE WHEN cv.TrangThai = 'Done' THEN 1 ELSE 0 END) AS TaskHoanThanh,
                        CAST(
                            (SUM(CASE WHEN cv.TrangThai = 'Done' THEN 1.0 ELSE 0.0 END) / COUNT(cv.MaTask)) * 100 
                            AS DECIMAL(5,2)
                        ) AS TyLeHoanThanh
                    FROM ThanhVien tv
                    JOIN PhanCong pc ON tv.MaThanhVien = pc.MaThanhVien
                    JOIN CongViec cv ON pc.MaTask = cv.MaTask
                    WHERE cv.MaDuAn = @MaDuAn
                    GROUP BY tv.HoTen";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaDuAn", maDuAn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}