# 🚀 QuanLyDuAn - Hệ Thống Quản Lý Dự Án

Ứng dụng Windows Forms toàn diện để quản lý dự án, nhân viên và phòng ban với tích hợp cơ sở dữ liệu SQL Server.

## 📋 Mục Lục
- [Tính năng](#-tính-năng)
- [Công nghệ sử dụng](#-công-nghệ-sử-dụng)
- [Cấu trúc cơ sở dữ liệu](#-cấu-trúc-cơ-sở-dữ-liệu)
- [Cài đặt](#-cài-đặt)
- [Hướng dẫn sử dụng](#-hướng-dẫn-sử-dụng)
- [Hình ảnh minh họa](#-hình-ảnh-minh-họa)
- [Thao tác cơ sở dữ liệu](#-thao-tác-cơ-sở-dữ-liệu)
- [Tài liệu API](#-tài-liệu-api)
- [Đóng góp](#-đóng-góp)
- [Tác giả](#-tác-giả)

## ✨ Tính năng

### Chức năng chính
- **Quản lý dự án**: Tạo, đọc, cập nhật và xóa dự án
- **Phân công nhân viên**: Gán nhân viên phụ trách cho từng dự án
- **Tìm kiếm & Lọc**: Chức năng tìm kiếm nâng cao trên toàn bộ dự án
- **Kiểm tra dữ liệu**: Xác thực đầu vào toàn diện và xử lý lỗi
- **Cập nhật thời gian thực**: Làm mới dữ liệu trực tiếp và đồng bộ hóa

### Giao diện người dùng
- **Thiết kế trực quan**: Giao diện Windows Forms sạch sẽ và thân thiện
- **Xác thực đầu vào**: Kiểm tra trường dữ liệu thời gian thực với thông báo lỗi
- **Lưới dữ liệu**: Bảng dữ liệu tương tác để hiển thị dự án
- **Điều khiển tìm kiếm**: Tìm kiếm có checkbox với chức năng reset

## 🛠 Công nghệ sử dụng

| Thành phần | Công nghệ |
|-----------|-----------|
| **Frontend** | Windows Forms (.NET Framework 4.7.2) |
| **Backend** | C# |
| **Cơ sở dữ liệu** | SQL Server |
| **ORM** | ADO.NET |
| **IDE** | Visual Studio 2022 |

## 🗃 Cấu trúc cơ sở dữ liệu

### Cấu trúc bảng

#### PhongBan (Phòng ban)
```sql
MaPhongBan NVARCHAR(3) PRIMARY KEY
TenPhongBan NVARCHAR(30) NOT NULL UNIQUE
NgayThanhLap DATETIME NOT NULL
PhuCap FLOAT NOT NULL CHECK(PhuCap > 0)
```

#### NhanVien (Nhân viên)
```sql
MaNhanVien NVARCHAR(5) PRIMARY KEY
HoTen NVARCHAR(30) NOT NULL
MaPhongBan NVARCHAR(3) FOREIGN KEY
NgayVaoLam DATE NOT NULL
MucLuong FLOAT NOT NULL CHECK(MucLuong > 0)
```

#### DuAn (Dự án)
```sql
MaDuAn NVARCHAR(3) PRIMARY KEY
TenDuAn NVARCHAR(30) NOT NULL UNIQUE
TongKinhPhi DECIMAL(18, 2) NOT NULL CHECK(TongKinhPhi > 0)
MaNhanVienPhuTrach NVARCHAR(5) FOREIGN KEY
```

### Mối quan hệ thực thể
```
PhongBan (1) -----> (*) NhanVien (1) -----> (*) DuAn
```

## 🚀 Cài đặt

### Yêu cầu hệ thống
- Windows OS (khuyên dùng Windows 10/11)
- SQL Server (Express/Standard/Developer)
- .NET Framework 4.7.2 trở lên
- Visual Studio 2019/2022 (để phát triển)

### Các bước cài đặt

1. **Clone Repository**
   ```bash
   git clone https://github.com/quangcaptain26-3/QuanLyDuAn.git
   cd QuanLyDuAn
   ```

2. **Thiết lập cơ sở dữ liệu**
   ```sql
   -- Chạy script SQL để tạo database
   sqlcmd -S tên_server_của_bạn -i QuanLyDuAn1.sql
   ```

3. **Cấu hình Connection String**
   ```csharp
   // Cập nhật trong file Database.cs
   private static string sqlConnection = 
       @"Data Source=TÊN_SERVER_CỦA_BẠN;Initial Catalog=QuanLyDuAn;Integrated Security=True;TrustServerCertificate=True";
   ```

4. **Build và chạy**
   ```bash
   # Mở trong Visual Studio
   # Build Solution (Ctrl+Shift+B)
   # Start Debugging (F5)
   ```

## 💡 Hướng dẫn sử dụng

### Bố cục giao diện chính

Ứng dụng bao gồm bốn phần chính:

#### 1. 🔍 Panel Tìm kiếm (Tim Kiem)
- **Checkbox**: Bật/tắt chức năng tìm kiếm
- **Ô nhập liệu**: Nhập từ khóa tìm kiếm
- **Nút Tìm kiếm**: Thực hiện truy vấn tìm kiếm
- **Nút Reset**: Xóa tìm kiếm và tải lại toàn bộ dữ liệu
- **Nút Exit**: Đóng ứng dụng

#### 2. 📝 Thông tin dự án (Thong Tin Du An)
- **Mã dự án** (MaDuAn): Mã định danh duy nhất 3 ký tự
- **Tên dự án** (TenDuAn): Tên mô tả dự án
- **Tổng kinh phí** (TongKinhPhi): Ngân sách dự án định dạng thập phân
- **Nhân viên phụ trách** (MaNhanVienPhuTrach): Lựa chọn dropdown

#### 3. ⚡ Panel chức năng (Chuc Nang)
- **Thêm (Them)**: Tạo dự án mới
- **Sửa (Sua)**: Chỉnh sửa dự án hiện tại
- **Xóa (Xoa)**: Xóa dự án với xác nhận

#### 4. 📊 Lưới dữ liệu (Du Lieu)
- **Lưới tương tác**: Hiển thị tất cả dự án
- **Chọn hàng**: Click để điền thông tin vào form
- **Tự động resize**: Cột tự điều chỉnh theo nội dung

### Các thao tác từng bước

#### Thêm dự án mới
1. Điền đầy đủ các trường bắt buộc trong panel thông tin
2. Chọn nhân viên phụ trách từ dropdown
3. Nhấn nút **"Them"** (Thêm)
4. Hệ thống xác thực đầu vào và tạo dự án
5. Lưới dữ liệu tự động làm mới

#### Chỉnh sửa dự án
1. Click vào một hàng trong lưới dữ liệu để chọn
2. Các trường form tự động điền thông tin đã chọn
3. Chỉnh sửa các trường mong muốn
4. Nhấn nút **"Sua"** (Sửa)
5. Xác nhận thay đổi

#### Xóa dự án
1. Chọn dự án từ lưới dữ liệu
2. Nhấn nút **"Xoa"** (Xóa)
3. Xác nhận xóa trong hộp thoại popup
4. Dự án được xóa khỏi cơ sở dữ liệu

#### Tìm kiếm dự án
1. Tích vào checkbox tìm kiếm
2. Nhập từ khóa vào ô text
3. Nhấn nút **"Tim Kiem"** (Tìm kiếm)
4. Kết quả lọc theo thời gian thực

### Quy tắc xác thực đầu vào

| Trường | Quy tắc |
|--------|---------|
| **Mã dự án** | Tối đa 3 ký tự, chữ và số |
| **Tên dự án** | Chỉ chữ cái và dấu cách |
| **Kinh phí** | Chỉ số, phải dương |
| **Nhân viên** | Phải tồn tại trong hệ thống |

## 📸 Hình ảnh minh họa

*Giao diện ứng dụng hiển thị bốn panel chính với dữ liệu mẫu*

## 🔧 Thao tác cơ sở dữ liệu

### Stored Procedures

#### Quản lý dự án
```sql
-- Thêm dự án mới
EXEC ThemDuAn @MaDuAn, @TenDuAn, @TongKinhPhi, @MaNhanVienPhuTrach

-- Cập nhật dự án
EXEC SuaDuAn @MaDuAn, @TenDuAn, @TongKinhPhi, @MaNhanVienPhuTrach

-- Xóa dự án
EXEC XoaDuAn @MaDuAn
```

#### Functions tìm kiếm
```sql
-- Tìm kiếm dự án
SELECT * FROM TimKiemDuAn(@TuKhoa)

-- Tìm kiếm nhân viên
SELECT * FROM TimKiemNhanVien(@TuKhoa)
```

### Xử lý lỗi
- **Ngăn chặn trùng lặp**: Kiểm tra ID và tên đã tồn tại
- **Xác thực khóa ngoại**: Đảm bảo nhân viên tồn tại
- **Quy tắc nghiệp vụ**: Xác thực ràng buộc ngân sách
- **Phản hồi người dùng**: Thông báo lỗi có ý nghĩa

## 📚 Tài liệu API

### Phương thức của class Database

#### Thao tác truy vấn
```csharp
// Thực hiện câu lệnh SELECT
public static DataTable Query(string sql)
public static DataTable Query(string sql, Dictionary<string, object> parameters)

// Thực hiện INSERT/UPDATE/DELETE
public static void Execute(string sql)
public static void Execute(string sql, Dictionary<string, object> parameters)
```

#### Ví dụ sử dụng
```csharp
// Tải tất cả dự án
DataTable projects = Database.Query("SELECT * FROM DuAn");

// Tìm kiếm với tham số
Dictionary<string, object> parameters = new Dictionary<string, object>();
parameters.Add("@TuKhoa", searchTerm);
DataTable results = Database.Query("SELECT * FROM TimKiemDuAn(@TuKhoa)", parameters);
```

## 🤝 Đóng góp

Chúng tôi hoan nghênh các đóng góp! Vui lòng tuân theo các hướng dẫn sau:

1. **Fork** repository
2. **Tạo** nhánh tính năng (`git checkout -b feature/TinhNangTuyetVoi`)
3. **Commit** các thay đổi (`git commit -m 'Thêm tính năng tuyệt vời'`)
4. **Push** lên nhánh (`git push origin feature/TinhNangTuyetVoi`)
5. **Mở** Pull Request

### Hướng dẫn phát triển
- Tuân theo quy ước coding C#
- Thêm tài liệu XML cho các phương thức public
- Bao gồm unit test cho tính năng mới
- Cập nhật README cho những thay đổi quan trọng

### Báo cáo lỗi
Vui lòng sử dụng issue tracker để báo cáo lỗi:
- Bao gồm các bước chi tiết để tái hiện
- Cung cấp thông tin hệ thống
- Đính kèm ảnh chụp màn hình nếu có

## 👨‍💻 Tác giả

**Minh Quang**

- 🐙 **GitHub**: [@quangcaptain26-3](https://github.com/quangcaptain26-3)
- 💼 **LinkedIn**: [minhquang2604](https://linkedin.com/in/minhquang2604)
- 📧 **Email**: Liên hệ qua GitHub hoặc LinkedIn

---

## 📄 Giấy phép

Dự án này được cấp phép theo giấy phép MIT - xem file [LICENSE](LICENSE) để biết chi tiết.

---

<div align="center">
  <p><strong>Được tạo với ❤️ bởi Minh Quang</strong></p>
  <p>Nếu dự án này hữu ích cho bạn, hãy cho một ⭐ nhé!</p>
</div>
