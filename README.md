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
| Trang Chủ - Web| ![Trang Chủ Web](https://scontent.fsgn5-12.fna.fbcdn.net/v/t39.30808-6/502675292_718646563883353_4111453863321333346_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeEcqX4-DKe5wEsyYWMTEWE6CXechDDB_VMJd5yEMMH9U4Cl19niQEu1qeaJBSYXzoft3ncXeBRD-OLN1vWdWGb5&_nc_ohc=pvQEWrJF-w0Q7kNvwH6Qz3M&_nc_oc=Adlw8E4FQnw-zwX55E3U3jRiPSRyrZ-ucD9HdFnOOPD8ZWYTEDz3znfqs_B8pC9DNQU5J20FTXxxCMiTVrveMREq&_nc_zt=23&_nc_ht=scontent.fsgn5-12.fna&_nc_gid=oTwSC2BYg927EAitUcvCtQ&oh=00_AfKQfuIxI4QZEbKIgrEa6ZPYzL2J_HOBL5nFwCho1vkhGw&oe=683E253C) | Giao diện chính của ứng dụng, hiển thị tổng quan về tình trạng phòng và đặt phòng |
| Trang Chủ - Desktop| ![Trang Chủ Desktop](https://scontent.fsgn5-3.fna.fbcdn.net/v/t39.30808-6/501989255_718646657216677_3362723747901903647_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeHws6pUlRJpxfxiEn_Qvka9TJ8HwuqaTupMnwfC6ppO6iNJjNhTL7c4HiEHYOVT0Emq-U2ysW5gULaDlidTuaXK&_nc_ohc=KvEpnhRU_pgQ7kNvwG12lay&_nc_oc=Adm19ASYoMl2f6iMfXqf14CSDud0it20rAu6WUX3Su_nshNAvzD5hIsH-5WaKga4GP2m1IBNL5BpcAi9sFKI6D8P&_nc_zt=23&_nc_ht=scontent.fsgn5-3.fna&_nc_gid=mE58s2VUMeJzuOrXmFRBEw&oh=00_AfLtwQzabYwVbOFNP945U-uCjoe7lZ7pi-UP8oFu4p-7zQ&oe=683E32C1) | Giao diện chính của ứng dụng, hiển thị tổng quan về tình trạng phòng và đặt phòng |
| Đặt Phòng | ![Đặt Phòng](https://scontent.fsgn5-15.fna.fbcdn.net/v/t39.30808-6/501918159_718646567216686_5154770191872209017_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeEaEHBFjMLfDMaYysLVd05MlTz_4bBjvSOVPP_hsGO9I1guO5fI-4YoQvrdEdVEW2ov9vG9bBxaM2a5QPNRtNE-&_nc_ohc=OVfBUpyRJGwQ7kNvwHMg_wq&_nc_oc=Adl1ZvTJZJLWTAtKyfBO1jHwv5KgkUl7wVF3MNFHyeBBeKb6Accp2sO85tg56iCIRtIG0DQKHb3RJzAbSmWM84_a&_nc_zt=23&_nc_ht=scontent.fsgn5-15.fna&_nc_gid=XRPt8DjIUMpmC-UElRdnAQ&oh=00_AfKaVXx0cm0cTm61IJaH1fBzUBk1VTKwthBGw2E9szzcJg&oe=683E2099) | Giao diện đặt phòng cho khách hàng với các tùy chọn loại phòng |
| Thanh Toán | ![Thanh Toán](https://scontent.fsgn5-12.fna.fbcdn.net/v/t39.30808-6/502052213_718646633883346_485141209175022536_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeFrOTP30kKfGSyTRmQQ8Panpb9bl9on9NWlv1uX2if01YyWlPdAfckWiWawV6A6XbqpWp6Gta0hbNqa2J_avFXj&_nc_ohc=qsOP2KHSkv8Q7kNvwE4bEJR&_nc_oc=AdmFNDSgZRCsJEoqefCc2u9-cphDsMVzdCk6KIcwZ8k1y_dfYOtcugcIRHYUAe7PykYjsoAnLIIi4RQdbnQ9bb40&_nc_zt=23&_nc_ht=scontent.fsgn5-12.fna&_nc_gid=aqVtMiJ5Pea8bBPz9H151Q&oh=00_AfKGjRAGB-R1sy-12PuiC18XR2q2dgJsN31LMochTJnauQ&oe=683E0028) | Giao diện thanh toán cho khách hàng với các tùy chọn loại phòng và dịch vụ |
| Quản Lý Phòng | ![Quản Lý Phòng](https://scontent.fsgn5-9.fna.fbcdn.net/v/t39.30808-6/502320405_718646660550010_7486211289857614973_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeGvzlcJnQpDVO2dLeg8a96w2hW8AzTke2naFbwDNOR7aXfUvLgWeHhOnDGo9MT7AAZc3Kwwsc3VQ4qphSqX5RWV&_nc_ohc=-8Rx-YuN0K4Q7kNvwEdhvU_&_nc_oc=AdlIUXRuvx1f0Ie61cDy1bz9sNDRCUJuckEGhMl13mm7Zjf6_kmue1ZF0AcO2X0EWQNCluMyGwTV-2bhb9Isn7Lt&_nc_zt=23&_nc_ht=scontent.fsgn5-9.fna&_nc_gid=3QQ4qhgcuJeoHzPg20joug&oh=00_AfJTKdr6gsUgsVNTq6msGzgPPa528W2MT-7sQ3BcZUWz4Q&oe=683E0456) | Màn hình quản lý thông tin phòng, tình trạng phòng và loại phòng |
| Quản Lý Đặt Phòng | ![Quản Lý Đặt Phòng](https://scontent.fsgn5-15.fna.fbcdn.net/v/t39.30808-6/502624743_718646703883339_3258563526631334810_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeFxw3KROHDZaoHU1D16tzqCooCX-2U2YHeigJf7ZTZgd2wxp5EIZYx1T88leLxGTe037LMUkz6Oj6Yc9cg4l5y9&_nc_ohc=SKFDg_20fF0Q7kNvwHR2hEh&_nc_oc=AdlhlN4Ch3lDsuN05UbElpGZecf8unZ_D2eQYBZLXosLBbHFjVRKYLZLHyM7xOOQXu7U_RpZd0NzylR_AX9PTXYt&_nc_zt=23&_nc_ht=scontent.fsgn5-15.fna&_nc_gid=OTzLdxSxHdqlbl87yi_GqQ&oh=00_AfKZmbITeCucJaRy77rud41t5Uy6nSGoh0Vr3JaYETIeRQ&oe=683E2377) | Giao diện quản lý đặt phòng cho khách hàng |
| ChatBot | ![ChatBot](https://scontent.fsgn5-9.fna.fbcdn.net/v/t39.30808-6/501841464_718646537216689_8033769303499181611_n.jpg?_nc_cat=105&ccb=1-7&_nc_sid=127cfc&_nc_eui2=AeGIeFJD2Mg4gncNLGBKSCPz3bykxLxHy-LdvKTEvEfL4vChEKzGBdGdRsumlUyEhFkKqnPjHwO-XkLFW7CK0CR0&_nc_ohc=6soBx5VeMEEQ7kNvwHQI34c&_nc_oc=AdkE2A_EUru1dZ0XmadyWs43Mto7RHDf5Y3d5kj9nvUV_Dje7UjoCXqBVgoKNMFjJKZ7lyo2gfRGy-O3W4xaSLA7&_nc_zt=23&_nc_ht=scontent.fsgn5-9.fna&_nc_gid=45J7exEwMIiUiAJnBSFiuQ&oh=00_AfKZ0CZTClN6W53dUGRjKrly9KCk-v_xZMuzHGWmO5TT4g&oe=683E0F45) | ChatBot hỗ trợ người dùng truy vấn database và truy xuất tài liệu bổ sung |

## Liên hệ

- **Email**: [hoangkhoi230@gmail.com]
