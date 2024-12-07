@extends('Layout')
@section('body')
<link rel='stylesheet' href='https://cdn-uicons.flaticon.com/2.3.0/uicons-regular-rounded/css/uicons-regular-rounded.css'>

  <title>GTX - Đánh giá</title>
  <main id="main" class="main">

    <div class="pagetitle">
        <h1>Đánh giá</h1>
        <nav>
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="{{ route("Home") }}">Home</a></li>
                <li class="breadcrumb-item">Đánh giá</li>
                <li class="breadcrumb-item active">Đánh giá và lịch sử đánh giá</li>
            </ol>
        </nav>
    </div><!-- End Page Title -->
    <section class="section profile">
        <div class="row">
            <div class="col-xl-8" style="width:100%">

                <div class="card" style="border-radius:20px;">
                    <div class="card-body pt-3">
                        <!-- Bordered Tabs -->
                        <ul class="nav nav-tabs nav-tabs-bordered">
                            <li class="nav-item">
                                <button class="nav-link active" data-bs-toggle="tab" data-bs-target="#danhSachPhong">Danh sách cần bạn đánh giá</button>
                            </li>
                            <li class="nav-item">
                                <button class="nav-link" data-bs-toggle="tab" data-bs-target="#lichSuDatPhong">Lịch sử đánh giá</button>
                            </li>
                        </ul>
                                <div class="tab-content pt-2">

                          <div class="tab-pane fade active show profile-overview" id="danhSachPhong">
                             <h5 class="card-title" style="font-family: 'Montserrat', sans-serif;
                             font-optical-sizing: auto;
                             font-weight: 400;
                             font-style: normal;" data-aos="fade-up" data-aos-delay="500">Danh sách đánh giá của bạn</h5>

                            @if (count($listNeedReview) == 0)
                            <div class="card_dp_khoi" data-aos="fade-down" data-aos-delay="200">
                                <div class="header_dp_khoi">
                                  <span class="icon_dp_khoi" data-aos="fade-up" data-aos-delay="600">
                                    <svg fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                                      <path clip-rule="evenodd" d="M18 3a1 1 0 00-1.447-.894L8.763 6H5a3 3 0 000 6h.28l1.771 5.316A1 1 0 008 18h1a1 1 0 001-1v-4.382l6.553 3.276A1 1 0 0018 15V3z" fill-rule="evenodd"></path>
                                    </svg>
                                  </span>
                                  <p class="alert_dp_khoi" data-aos="fade-up" data-aos-delay="600">Thông báo!</p>
                                </div>
                                <img src="assets/img/gold-star.png" alt="" style="max-width:168px" data-aos="fade-up" data-aos-delay="700">

                                <p class="message_dp_khoi">
                                  <h1 data-aos="fade-up" data-aos-delay="800">Opps :( </h1>
                                  <div data-aos="fade-up" data-aos-delay="850">
                                    <span style="font-size:20px">Bạn chưa tạo danh sách đánh giá nào, hãy lựa các loại phòng bạn thích và đặt ngay cho chuyến du lịch của bạn và trải nghiệm đánh giá.</span>
                                  </div>
                                </p>
                              
                                <div class="actions_dp_khoi">
                                  <a class="read_dp_khoi" href="{{ route("AllCategoryRoom") }}" data-aos="fade-up" data-aos-delay="900">
                                    Xem các loại phòng
                                  </a>
                              
                                  <a class="mark-as-read_dp_khoi" href="{{ route("Home") }}" data-aos="fade-up" data-aos-delay="1000">
                                    Quay lại trang chủ
                                  </a>
                                </div>
                              </div>     
                            @else
                            <table class="table table-borderless datatable" id = "adminTable">
                              <thead>
                                  <tr>
                                    <th scope="col">Tên loại phòng</th>
                                    <th scope="col">Tên phòng</th>
                                    <th scope="col">Mã phiếu</th>
                                    <th scope="col">Ngày đặt</th>
                                    <th scope="col">Ngày trả</th>
                                    <th scope="col">Đánh giá</th>
                                  </tr>
                              </thead>
                              <!--<tbody>
                                @foreach ($listNeedReview as $item)
                                  <tr>
                                    <td>{{ $item->TENLOAIPHONG }}</td>
                                    <td><a href="#" class="text-primary">{{ $item->TENPHONG }}</a></td>
                                    <td>{{ $item->MAPHIEU }}</td>
                                    <td>{{ $item->NGAYDAT }}</td>
                                    <td>{{ $item->TRAPHONG }}</td>
                                    <td><a href="{{ route("pushComment",["idkh" => $item->MAKH,"idphong" => $item->MAPHONG,"idphieu" => $item->MAPHIEU]) }}" type="button" class="btn btn-info" style="border-radius:20%;margin-right:20px;color:white;box-shadow: rgba(0, 0, 0, 0.24) 0px 3px 8px;background-color:#74C0FC"><i class="fi fi-rr-file-edit"></i></a></td>
                                  </tr>
                                @endforeach
                              </tbody> -->
                            </table>                                                           
                            @endif
                          </div>
                        <div class="tab-content pt-2">

                            <div class="tab-pane fade show profile-overview" id="lichSuDatPhong">
                                <h5 class="card-title" style="margin-top:-10px; font-family: 'Montserrat', sans-serif;
                                font-optical-sizing: auto;
                                font-weight: 400;
                                font-style: normal;">Lịch sử đánh giá của bạn</h5>
                                
                                @if (count($listReview) == 0)
                                <div class="card_dp_khoi">
                                    <div class="header_dp_khoi">
                                      <span class="icon_dp_khoi">
                                        <svg fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
                                          <path clip-rule="evenodd" d="M18 3a1 1 0 00-1.447-.894L8.763 6H5a3 3 0 000 6h.28l1.771 5.316A1 1 0 008 18h1a1 1 0 001-1v-4.382l6.553 3.276A1 1 0 0018 15V3z" fill-rule="evenodd"></path>
                                        </svg>
                                      </span>
                                      <p class="alert_dp_khoi">Thông báo!</p>
                                    </div>
                                    <img src="assets/img/comment.png" alt="" style="max-width:168px">

                                    <p class="message_dp_khoi">
                                       <h1>Opps :( </h1>
                                       <span style="font-size:20px">Không tìm thấy danh sách lịch sử đánh giá của bạn! Nếu bạn chưa đặt phòng hãy chọn loại phòng bạn thích và đặt ngay và tạo những bài đánh giá hữu ích.</span>
                                    </p>
                                  
                                    <div class="actions_dp_khoi">
                                      <a class="read_dp_khoi" href="{{ route("AllCategoryRoom") }}">
                                        Xem các loại phòng
                                      </a>
                                  
                                      <a class="mark-as-read_dp_khoi" href="{{ route("Home") }}">
                                        Quay lại trang chủ
                                      </a>
                                    </div>
                                  </div>                                  
                                @else
                                <table class="table table-borderless datatable" id = "adminTable">
                                  <thead>
                                      <tr>
                                        <th scope="col">Tên loại</th>
                                        <th scope="col">Tên phòng</th>
                                        <th scope="col">Ngày đặt</th>
                                        <th scope="col">Ngày trả</th>
                                        <th scope="col">Số sao</th>
                                        <th scope="col">Đánh giá</th>
                                        <th scope="col">Tình trạng</th>
                                      </tr>
                                  </thead>
                                  <tbody>
                                    <!-- @foreach ($checkUser as $item)
                                      <tr>
                                        <td>{{ $item->TENLOAIPHONG }}</td>
                                        <td><a href="#" class="text-primary">{{ $item->TENPHONG }}</a></td>
                                        <td>{{ $item->NGAYDAT }}</td>
                                        <td>{{ $item->TRAPHONG }}</td>
                                        <td><a href="#" class="text-primary">{{ $item->SOSAO }}</a></td>
                                        <td>{{ $item->BINHLUAN }}</td>
                                        @foreach ($check as $item2)
                                          @if ($item2->MADG == $item->MADG)
                                              @if ($item2->ISDELETE === 0)
                                                  <td><span class="badge bg-success">Đã duyệt</span></td>
                                              @elseif ($item2->ISDELETE === 1)
                                                  <td><span class="badge bg-warning">Đợi duyệt</span></td>
                                              @else
                                                  <td><span class="badge bg-danger">Từ chối</span></td>
                                              @endif
                                          @endif
                                        @endforeach
                                      </tr>
                                    @endforeach
                                  </tbody> -->
                                </table>                                                           
                                @endif
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