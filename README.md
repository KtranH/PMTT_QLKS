# Hệ Thống Quản Lý Khách Sạn (QLKS)

## Giới Thiệu

Hệ thống Quản Lý Khách Sạn (QLKS) là giải pháp toàn diện kết hợp nền tảng web (Laravel) và ứng dụng desktop (Winform) giúp quản lý hiệu quả mọi hoạt động của khách sạn. Phần mềm được thiết kế với giao diện thân thiện, dễ sử dụng, đảm bảo trải nghiệm tốt nhất cho người dùng.

## Chức Năng Chính

- **Quản lý phòng**: Thêm, sửa, xóa, tra cứu thông tin phòng và loại phòng
- **Quản lý đặt phòng**: Xử lý quy trình đặt phòng, nhận phòng và trả phòng
- **Quản lý khách hàng**: Lưu trữ và quản lý thông tin khách hàng
- **Quản lý nhân viên**: Phân quyền và quản lý thông tin nhân viên
- **Quản lý dịch vụ**: Thêm, sửa, xóa các dịch vụ của khách sạn
- **Quản lý hóa đơn**: Tạo và quản lý hóa đơn thanh toán
- **Thống kê báo cáo**: Tạo báo cáo về tình hình kinh doanh
- **Đánh giá**: Hệ thống đánh giá và phản hồi của khách hàng

## Mô Tả Sản Phẩm

Hệ thống QLKS được xây dựng theo mô hình kết hợp giữa web và desktop application:

- **Phần Web (Laravel)**: Cung cấp giao diện đặt phòng trực tuyến cho khách hàng, quản lý đánh giá và tương tác trực tuyến.
- **Phần Desktop (Winform)**: Phục vụ nhân viên khách sạn trong việc quản lý nội bộ, tiếp nhận khách, thanh toán và quản lý hệ thống.

Kiến trúc hệ thống được thiết kế theo mô hình 3 lớp:
- **DTO (Data Transfer Object)**: Chứa các đối tượng dữ liệu
- **DAL (Data Access Layer)**: Xử lý truy xuất và thao tác dữ liệu
- **BLL (Business Logic Layer)**: Xử lý logic nghiệp vụ
- **GUI (Graphical User Interface)**: Giao diện người dùng

## Công Nghệ Sử Dụng

### Backend
- **Laravel 11**: Framework PHP mạnh mẽ cho phát triển web
- **C# .NET**: Phát triển ứng dụng desktop
- **Entity Framework**: ORM cho tương tác với database
- **SQL Server**: Hệ quản trị cơ sở dữ liệu

### Frontend
- **Vue.js 3**: Framework JavaScript cho tương tác người dùng (phần web)
- **Winform**: Xây dựng giao diện desktop
- **TailwindCSS**: Framework CSS cho thiết kế responsive
- **PrimeVue**: Thư viện UI component cho Vue.js

## Hướng Dẫn Cài Đặt

### Yêu Cầu Hệ Thống
- PHP 8.2+
- Composer
- .NET Framework 4.7.2+
- SQL Server 2019+
- Node.js và npm

### Cài Đặt Phần Web (Laravel)
1. Clone repository:
   ```bash
   git clone [đường-dẫn-repository]
   ```

2. Cài đặt dependencies:
   ```bash
   composer install
   npm install
   ```

3. Tạo file .env:
   ```bash
   cp .env.example .env
   ```

4. Cấu hình database trong file .env

5. Chạy migration và seeder:
   ```bash
   php artisan migrate --seed
   ```

6. Khởi động server:
   ```bash
   php artisan serve
   npm run dev
   ```

### Cài Đặt Phần Desktop (Winform)
1. Mở solution file (.sln) trong Visual Studio
2. Cấu hình connection string trong App.config
3. Build và chạy ứng dụng

## Demo Sản Phẩm

| Tên | Hình Ảnh | Mô Tả |
|-----|----------|-------|
| Trang Chủ - Web| ![Trang Chủ Web](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/Screenshot%202025-05-29%20182214.png) | Giao diện chính của ứng dụng, hiển thị tổng quan về tình trạng phòng và đặt phòng |
| Trang Chủ - Desktop| ![Trang Chủ Desktop](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/Screenshot%202025-05-29%20183111.png) | Giao diện chính của ứng dụng, hiển thị tổng quan về tình trạng phòng và đặt phòng |
| Đặt Phòng | ![Đặt Phòng](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/Screenshot%202025-05-29%20182937.png) | Giao diện đặt phòng cho khách hàng với các tùy chọn loại phòng |
| Thanh Toán | ![Thanh Toán](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/Screenshot%202025-05-29%20183040.png) | Giao diện thanh toán cho khách hàng với các tùy chọn loại phòng và dịch vụ |
| Quản Lý Phòng | ![Quản Lý Phòng](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/Screenshot%202025-05-29%20183157.png) | Màn hình quản lý thông tin phòng, tình trạng phòng và loại phòng |
| Quản Lý Đặt Phòng | ![Quản Lý Đặt Phòng](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/Screenshot%202025-05-29%20183257.png) | Giao diện quản lý đặt phòng cho khách hàng |
| ChatBot | ![ChatBot](https://pub-0ec2d0f968bd484492ed9495327a3698.r2.dev/GTX/5d59445e-5188-4cd6-92a4-8dab8715f721.jpg) | ChatBot hỗ trợ người dùng truy vấn database và truy xuất tài liệu bổ sung |

## Liên hệ

- **Email**: [hoangkhoi230@gmail.com]
