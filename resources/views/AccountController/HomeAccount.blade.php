@extends('Layout')
@section('body')
  <title>GTX - Tài khoản</title>
  <main id="main" class="main">

    <div class="pagetitle">
        <h1>Tài khoản</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">Home</a></li>
                <li class="breadcrumb-item">Tài khoản người dùng</li>
                <li class="breadcrumb-item active">Tài khoản</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->
    <section class="section profile">
        <div class="row">
            <div class="col-xl-4">

                <div class="card" style="border-radius:20px;" data-aos="zoom-in-right">
                    <div class="card-body profile-card pt-4 d-flex flex-column align-items-center" data-aos="fade-right" data-aos-delay="800">  
                        <img src="{{ $user->AVATAR }}" class="rounded-circle">
                        <h2>{{$user->HOTEN}}</h2>
                        <h3>{{$user->EMAIL}}</h3>
                        <div class="social-links mt-2">
                            <a href="#" class="twitter"><i class="bi bi-twitter"></i></a>
                            <a href="#" class="facebook"><i class="bi bi-facebook"></i></a>
                            <a href="#" class="instagram"><i class="bi bi-instagram"></i></a>
                            <a href="#" class="linkedin"><i class="bi bi-linkedin"></i></a>
                        </div>
                    </div>
                    <div class="card_accountkhoi" data-aos="fade-up" data-aos-delay="900">
                        <div class="header_account_khoi"></div>
                        <div class="info_account_khoi">
                          <p class="title_account_khoi">Bạn muốn tạo ảnh đại diện bằng AI?</p>
                          <p>Nếu bạn muốn tải ảnh đại diện nhưng không có ảnh để thực hiện điều đó thì chúng tôi cung cấp cho bạn một chức năng tạo ảnh đại diện bằng AI, chỉ cần nhấp vào nút bên dưới. </p>
                        </div>
                        <div class="footer_account_khoi">
                          <p class="tag_account_khoi">Tạo ảnh bằng AI </p>
                          <a href="{{ route("generateAvatarImg") }}" type="button" class="action_account_khoi">Bắt đầu ngay </a>
                        </div>
                    </div>
                </div>

            </div>
            <div class="col-xl-8">

                <div class="card" style="border-radius:20px;" data-aos="zoom-in-left">
                    <div class="card-body pt-3">
                        <!-- Bordered Tabs -->
                        <ul class="nav nav-tabs nav-tabs-bordered">
                            <li class="nav-item">
                                <button class="nav-link active" data-bs-toggle="tab" data-bs-target="#profile-overview">Tổng quan</button>
                            </li>
                        </ul>
                        <div class="tab-content pt-2">

                            <div class="tab-pane fade show active profile-overview" id="profile-overview">
                                <div data-aos="fade-up" data-aos-delay="500">
                                    <h5 class="card-title">Ghi chú</h5>
                                    <p class="small fst-italic">
                                        Ohh. Bạn chưa có ghi chú nào! :(
                                    </p>
                                </div>
                                <h5 class="card-title" data-aos="fade-up" data-aos-delay="600">Chi tiết tài khoản <i class="fa-solid fa-pen-to-square" style="color: #74C0FC;margin-left:20px"></i> <a href="{{ route("pageUpdateAccount") }}" style="font-size: 15px">Chỉnh sửa trang cá nhân</a></h5>
                                <div class="row" data-aos="fade-up" data-aos-delay="700">
                                    <div class="col-lg-3 col-md-4 label">Họ và tên:</div>
                                    <div class="col-lg-9 col-md-8">{{$user->HOTEN}}</div>
                                </div>

                                <div class="row" data-aos="fade-up" data-aos-delay="800">
                                    <div class="col-lg-3 col-md-4 label">Giới tính:</div>
                                    <div class="col-lg-9 col-md-8">{{$user->GIOITINH}}</div>
                                </div>

                                <div class="row" data-aos="fade-up" data-aos-delay="900">
                                    <div class="col-lg-3 col-md-4 label">Ngày sinh:</div>
                                    <div class="col-lg-9 col-md-8">{{$user->NGAYSINH}}</div>
                                </div>

                                <div class="row" data-aos="fade-up" data-aos-delay="1000">
                                    <div class="col-lg-3 col-md-4 label">Số điện thoại</div>
                                    <div class="col-lg-9 col-md-8">{{$user->SDT}}</div>
                                </div>

                                <div class="row" data-aos="fade-up" data-aos-delay="1100">
                                    <div class="col-lg-3 col-md-4 label">Căn cước công dân</div>
                                    <div class="col-lg-9 col-md-8">{{$user->CCCD}}</div>
                                </div>

                                <div class="row" data-aos="fade-up" data-aos-delay="1200">
                                    <div class="col-lg-3 col-md-4 label">Email:</div>
                                    <div class="col-lg-9 col-md-8">{{$user->EMAIL}}</div>
                                </div>

                                <div class="row" data-aos="fade-up" data-aos-delay="1300">
                                    <div class="col-lg-3 col-md-4 label">Điểm tín nhiệm:</div>
                                    <div class="col-lg-9 col-md-8" style="color: red;font-weight:bold">{{$user->DIEMTINNHIEM}}</div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    </main>
@endsection