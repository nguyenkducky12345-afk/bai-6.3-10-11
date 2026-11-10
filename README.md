# BÁO CÁO BÀI TẬP / ĐỒ ÁN

## THÔNG TIN SINH VIÊN
- **Họ và tên:** Nguyễn Khánh Đức
- **Mã số sinh viên:** 24810320072
- **Lớp:** D19QTANM1
- **Tên môn học:** Lập trình C# / Windows Forms
- **Tên bài tập:** BÀI 6.3: HỆ THỐNG QUẢN LÝ CÔNG VIỆC & TIẾN ĐỘ DỰ ÁN
(PROJECT & TASK MANAGEMENT)

---

## KẾT QUẢ THỰC HÀNH

- Giao diện chính
<img width="1442" height="878" alt="Screenshot 2026-11-10 185708" src="https://github.com/user-attachments/assets/ca5f2827-0970-41af-a3ac-3b8101f12dee" />

-Giao diện thêm task thành công
<img width="1436" height="869" alt="Screenshot 2026-11-10 185730" src="https://github.com/user-attachments/assets/7158fd13-796c-43ea-9d65-c2199e98a9ee" />

## HƯỚNG DẪN CÀI ĐẶT VÀ CHẠY DỰ ÁN:
1. **Khởi tạo CSDL**:
   - Mở file `Database.sql` có sẵn trong thư mục dự án bằng SQL Server Management Studio (SSMS) hoặc Visual Studio.
   - Chạy toàn bộ script (Execute) để tự động tạo CSDL `ProjectTaskDB` cùng các bảng và dữ liệu mẫu.

2. **Cấu hình chuỗi kết nối**:
   - Mở file `Dbhelper.cs`.
   - Kiểm tra và đổi lại `Data Source` cho khớp với tên SQL Server trên máy chấm (Mặc định đang để kết nối tới `(localdb)\MSSQLLocalDB`).

3. **Chạy chương trình**:
   - Nhấn **F5** (hoặc nút Start) trên Visual Studio để chạy hệ thống.
