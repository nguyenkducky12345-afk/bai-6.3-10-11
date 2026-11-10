using System;

namespace ProjectManagement.DTO
{
    public class DuAnDTO
    {
        public int MaDuAn { get; set; }
        public string TenDuAn { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
    }

    public class ThanhVienDTO
    {
        public int MaThanhVien { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string ChuyenMon { get; set; }
    }

    public class CongViecDTO
    {
        public int MaTask { get; set; }
        public int MaDuAn { get; set; }
        public string TenTask { get; set; }
        public string MoTa { get; set; }
        public DateTime HanNop { get; set; }
        public string DoUuTien { get; set; }
        public string TrangThai { get; set; }
    }

    public class PhanCongDTO
    {
        public int MaTask { get; set; }
        public int MaThanhVien { get; set; }
        public DateTime NgayGiao { get; set; }
    }
}