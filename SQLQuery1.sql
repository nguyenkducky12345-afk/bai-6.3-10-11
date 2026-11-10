-- 1. Bảng DuAn
CREATE TABLE DuAn (
    MaDuAn INT IDENTITY(1,1) PRIMARY KEY,
    TenDuAn NVARCHAR(150) NOT NULL,
    NgayBatDau DATETIME,
    NgayKetThuc DATETIME,
    TrangThai NVARCHAR(50)
);

-- 2. Bảng ThanhVien
CREATE TABLE ThanhVien (
    MaThanhVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    ChuyenMon NVARCHAR(100)
);

-- 3. Bảng CongViec (Task)
CREATE TABLE CongViec (
    MaTask INT IDENTITY(1,1) PRIMARY KEY,
    MaDuAn INT FOREIGN KEY REFERENCES DuAn(MaDuAn) ON DELETE CASCADE,
    TenTask NVARCHAR(200) NOT NULL,
    MoTa NVARCHAR(MAX),
    HanNop DATETIME,
    DoUuTien NVARCHAR(20),
    TrangThai NVARCHAR(50) -- 'To Do', 'In Progress', 'Review', 'Done'
);

-- 4. Bảng PhanCong
CREATE TABLE PhanCong (
    MaTask INT FOREIGN KEY REFERENCES CongViec(MaTask) ON DELETE CASCADE,
    MaThanhVien INT FOREIGN KEY REFERENCES ThanhVien(MaThanhVien) ON DELETE CASCADE,
    NgayGiao DATETIME DEFAULT GETDATE(),
    PRIMARY KEY (MaTask, MaThanhVien)
);

-- THÊM DỮ LIỆU MẪU ĐỂ TEST
INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) 
VALUES (N'Dự án ERP Doanh nghiệp', GETDATE(), DATEADD(month, 3, GETDATE()), N'Đang chạy');

INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) 
VALUES (N'Nguyễn Văn A', 'a.nguyen@gmail.com', 'Backend'),
       (N'Trần Thị B', 'b.tran@gmail.com', 'Frontend');

INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai)
VALUES (1, N'Thiết kế CSDL', N'Tạo bảng và quan hệ', DATEADD(day, -2, GETDATE()), N'Cao', N'In Progress'), -- Quá hạn
       (1, N'Code giao diện Form1', N'Dựng UI Winform', DATEADD(day, 2, GETDATE()), N'Trung bình', N'To Do');

INSERT INTO PhanCong (MaTask, MaThanhVien) VALUES (1, 1), (2, 2);