CREATE PROCEDURE USP_Form1
  @TaiKhoan NVARCHAR(50),
   @MatKhau NVARCHAR(50)
AS
BEGIN
SELECT MaChucVu
    FROM TaiKhoan
   WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
END

CREATE TABLE NhaCungCap (
    MaNhaCungCap VARCHAR(5) PRIMARY KEY,
    TenNhaCungCap NVARCHAR(100),
    DiaChi NVARCHAR(100),
    Gmail NVARCHAR(100)
);

CREATE TABLE LoaiDia (
    MaLoaiDia VARCHAR(5) PRIMARY KEY,
    LoaiDia NVARCHAR(100)
);

CREATE TABLE TheLoai (
    MaTheLoai VARCHAR(5) PRIMARY KEY,
    TenTheLoai NVARCHAR(50)
);

CREATE TABLE TinhTrang (
    MaTinhTrang CHAR(1) PRIMARY KEY,
    TinhTrang NVARCHAR(20)
);

CREATE TABLE HangSanXuat (
    MaHang VARCHAR(5) PRIMARY KEY,
    Hang NVARCHAR(100)
);

CREATE TABLE ChucVu (
    MaChucVu INT PRIMARY KEY,
    TenChucVu NVARCHAR(50)
);

CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY,
    TenNhanVien NVARCHAR(255),
    ChucVu NVARCHAR(50),
    SDT NVARCHAR(20),
    DiaChi NVARCHAR(255),
    NgaySinh DATE
);

CREATE TABLE KhachHang (
    MaKhachHang VARCHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255),
    NgaySinh DATE
);

CREATE TABLE BangDia (
    MaBangDia VARCHAR(5) PRIMARY KEY,
    TenBangDia NVARCHAR(100),
    MaTheLoai VARCHAR(5),
    MaTinhTrang CHAR(1),
    MaHang VARCHAR(5),
    GhiChu NVARCHAR(255),
    GiaThue DECIMAL(10, 2),
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai),
    FOREIGN KEY (MaTinhTrang) REFERENCES TinhTrang(MaTinhTrang),
    FOREIGN KEY (MaHang) REFERENCES HangSanXuat(MaHang)
);

CREATE TABLE TaiKhoan (
    TaiKhoan NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50),
    MaChucVu INT,
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu)
);

CREATE TABLE PhieuNhap (
    MaPhieuNhap VARCHAR(5) PRIMARY KEY,
    MaNhaCungCap VARCHAR(5),
    NgayNhap DATE,
    Gia DECIMAL(10, 2),
    MaNhanVien INT,
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCap(MaNhaCungCap),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE ChiTietPhieuNhap (
    MaPhieuNhap VARCHAR(5),
    MaBangDia VARCHAR(5),
    HangSanXuat NVARCHAR(255),
    SoLuong INT,
    Gia DECIMAL(10, 2),
    GhiChu NVARCHAR(255),
    PRIMARY KEY (MaPhieuNhap, MaBangDia),
    FOREIGN KEY (MaPhieuNhap) REFERENCES PhieuNhap(MaPhieuNhap),
    FOREIGN KEY (MaBangDia) REFERENCES BangDia(MaBangDia)
);

CREATE TABLE TheThanhVien (
    MaTheThanhVien INT IDENTITY (1,1) PRIMARY KEY,
    MaKhachHang VARCHAR(5),
    NgayDangKy DATE,
    NgayHetHan DATE,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE PhieuThue (
    MaPhieuThue VARCHAR(20) PRIMARY KEY,
    MaKhachHang VARCHAR(5),
    NgayThue DATE,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);
CREATE TABLE ChiTietPhieuThue (
    MaPhieuThue VARCHAR(20),
    MaBangDia VARCHAR(5),
    TenBangDia NVARCHAR(100),
	GiaThue DECIMAL(10, 2),
	MaKhachHang VARCHAR(5),
    PRIMARY KEY (MaPhieuThue, MaBangDia),
	Hang NVARCHAR(100),
	HoTen NVARCHAR(255),
	NgayThue DATE,
    FOREIGN KEY (MaPhieuThue) REFERENCES PhieuThue(MaPhieuThue),
    FOREIGN KEY (MaBangDia) REFERENCES BangDia(MaBangDia),
	FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);
CREATE TABLE PhieuTra (
    MaPhieuTra VARCHAR(20) PRIMARY KEY,
    MaPhieuThue VARCHAR(20),
    MaKhachHang VARCHAR(5),
    NgayThue DATE,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhieuThue) REFERENCES PhieuThue(MaPhieuThue)
);

CREATE TABLE ChiTietPhieuTra (
    MaPhieuTra VARCHAR(20),
    MaBangDia VARCHAR(5),
    TenBangDia NVARCHAR(100),
    HoTen NVARCHAR(255),
    NgayThue DATE,
    TienPhat DECIMAL(10, 2),
    TinhTrang NVARCHAR(20),
    PRIMARY KEY (MaPhieuTra, MaBangDia),
    FOREIGN KEY (MaPhieuTra) REFERENCES PhieuTra(MaPhieuTra),
    FOREIGN KEY (MaBangDia) REFERENCES BangDia(MaBangDia)
);

CREATE TABLE BaoCao (
    MaBaoCao INT PRIMARY KEY,
    MaNhanVien INT,
    TenBaoCao NVARCHAR(100),
    NgayBaoCao DATE,
    NgayBatDau DATE,
    NgayKetThuc DATE,
    DoanhThu DECIMAL(10, 2),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE DoanhThu (
    MaBaoCao INT PRIMARY KEY,
    MaNhanVien INT,
    DoanhThu DECIMAL(10, 2),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
);

CREATE TABLE BienBan (
    MaKhachHang VARCHAR(5),
    MaBangDia VARCHAR(5),
    LyDo NVARCHAR(255),
    TienPhat DECIMAL(10, 2),
    PRIMARY KEY (MaKhachHang, MaBangDia),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaBangDia) REFERENCES BangDia(MaBangDia)
);

-- Insert data into NhaCungCap
INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, DiaChi, Gmail)
VALUES
(N'NCC01', N'Hồ Gươm Audio - Công Ty Cổ Phần Mỹ Thuật Và Vật Phẩm Văn Hóa', N'43 Tràng Tiền, P. Tràng Tiền, Q. Hoàn Kiếm, Hà Nội', N'hoguomav@gmail.com'),
(N'NCC02', N'Công Ty Cổ Phần Văn Hóa Tổng Hợp Bến Thành', N'142 Pasteur, P. Bến Nghé, Q. 1, Tp. Hồ Chí Minh (TPHCM)', N'benthanhgcc@hcm.fpt.vn'),
(N'NCC03', N'Những Gương Mặt Âm Nhạc - Công Ty Cổ Phần Sản Xuất Thương Mại Những Gương Mặt Âm Nhạc', N'90 Đề Thám, P. Cầu Ông Lãnh, Q. 1, Tp. Hồ Chí Minh (TPHCM)', N'mfaces@hcm.fpt.vn'),
(N'NCC04', N'Trí Việt - Công Ty Cổ Phần Truyền Thông Trí Việt', N'Tòa nhà Trí Việt, 6 Phạm Đình Toái, Phường 6, Quận 3, Tp. Hồ Chí Minh (TPHCM)', N'hr@tvmcorp.com'),
(N'NCC05', N'Tổng Công Ty Văn Hóa Sài Gòn', N'88 Trần Đình Xu, P. Cô Giang, Q. 1, Tp. Hồ Chí Minh (TPHCM)', N'scpc@scpc.com.vn');

-- Insert data into LoaiDia
INSERT INTO LoaiDia (MaLoaiDia, LoaiDia)
VALUES
(N'LD01', N'Băng cát-xét'),
(N'LD02', N'Băng video'),
(N'LD03', N'Đĩa CD'),
(N'LD04', N'Đĩa DVD'),
(N'LD05', N'Đĩa than');

-- Insert data into TheLoai
INSERT INTO TheLoai (MaTheLoai, TenTheLoai)
VALUES
(N'TL01', N'Hành động'),
(N'TL02', N'Hài kịch'),
(N'TL03', N'Âm nhạc'),
(N'TL04', N'Kinh dị'),
(N'TL05', N'Thần bí-Kỳ ảo'),
(N'TL06', N'Hoạt hình'),
(N'TL07', N'Khoa học viễn tưởng');

-- Insert data into TinhTrang
INSERT INTO TinhTrang (MaTinhTrang, TinhTrang)
VALUES
(N'A', N'Tốt'),
(N'B', N'Bị thiếu phụ kiện '),
(N'C', N'Hư hỏng'),
(N'D', N'Bị mất'),
(N'E', N'Trả trễ hẹn');

-- Insert data into HangSanXuat
INSERT INTO HangSanXuat (MaHang, Hang)
VALUES
(N'HSX01', N'Phương Nam Phim'),
(N'HSX02', N'Sài Gòn Audio'),
(N'HSX03', N'Bến Thành Audio'),
(N'HSX04', N'Học Viện Âm Nhạc Quốc Gia'),
(N'HSX05', N'Cánh Chim Việt Productions');

-- Insert data into ChucVu
INSERT INTO ChucVu (MaChucVu, TenChucVu)
VALUES
(1, N'Nhân viên'),
(2, N'Quản lý');

-- Insert data into NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, ChucVu, SDT, DiaChi, NgaySinh)
VALUES
(1, N'LƯƠNG TRÚC LY', 2, N'0912 345 678', N'123 Nguyễn Văn Linh, Quận 1, Thành phố Hồ Chí Minh', '1982-07-22'),
(2, N'NGUYỄN ĐĂNG', 2, N'0987 654 321', N'456 Lê Lợi, Quận 3, Thành phố Hà Nội', '1990-05-12'),
(3, N'BÙI NGỌC HIỂN',  1, N'0933 222 111', N'789 Điện Biên Phủ, Quận Bình Thạnh, Thành phố Đà Nẵng', '1980-05-17'),
(4, N'TRẦN THẾ DANH',  1, N'0977 888 999', N'234 Phạm Văn Đồng, Quận Tân Bình, Thành phố Cần Thơ', '1988-10-02'),
(5, N'NGUYỄN THỊ THU HÀ',  1, N'0966 111 222', N'567 Võ Thị Sáu, Quận Gò Vấp, Thành phố Hải Phòng', '1981-07-14');

-- Insert data into KhachHang
INSERT INTO KhachHang (MaKhachHang, HoTen, GioiTinh, DienThoai, DiaChi, NgaySinh)
VALUES
(N'KH01', N'LÊ NHƯ NGỌC', N'Nữ', N'0944 333 555', N'890 Trần Hưng Đạo, Quận 5, Thành phố Hồ Chí Minh', '1990-02-09'),
(N'KH02', N'VÕ PHAN BÌNH AN', N'Nữ', N'0911 777 888', N'234 Nguyễn Văn Cừ, Quận 10, Thành phố Hà Nội', '1982-11-06'),
(N'KH03', N'ĐĂNG TRẦN ANH THƯ', N'Nữ', N'0988 222 333', N'567 Lý Thường Kiệt, Quận Bình Thạnh, Thành phố Đà Nẵng', '1986-05-20'),
(N'KH04', N'VÕ TẤN LỘC', N'Nam', N'0979 444 555', N'789 Nguyễn Thị Minh Khai, Quận 3, Thành phố Cần Thơ', '1987-03-03'),
(N'KH05', N'TRẦN THỊ KIỂU TRINH', N'Nữ', N'0930 666 777', N'123 Lê Đại Hành, Quận Thanh Xuân, Thành phố Hải Phòng', '1988-09-04');


-- Insert data into BangDia
INSERT INTO BangDia (MaBangDia, TenBangDia, MaTheLoai, MaTinhTrang, MaHang, GhiChu, GiaThue)
VALUES
(N'BD01', N'Nobita Và Bản Giao Hưởng Địa Cầu', N'TL06', N'A', N'HSX01', N'Rất hay bổ ích', 100.00),
(N'BD02', N'Đội bóng Thiếu Lâm', N'TL02', N'B', N'HSX02', N'Có thông tin hữu ích', 200.00),
(N'BD03', N'Star War', N'TL07', N'C', N'HSX03', N'Trải nghiệm cảm giác phiêu lưu', 300.00),
(N'BD04', N'Tuyển tập nhạc Opera', N'TL03', N'D', N'HSX04', N'Thưởng thức âm nhạc du dương', 150.00),
(N'BD05', N'Spider-Man: No Way Home', N'TL01', N'D', N'HSX04', N'Hành động kịch tính', 200.00),
(N'BD06', N'Sự im lặng của bầy cừu', N'TL04', N'E', N'HSX05', N'Thử cảm giác rùng mình khi trải nghiệm', 250.00);

-- Insert data into TaiKhoan
INSERT INTO TaiKhoan (TaiKhoan, MatKhau, MaChucVu)
VALUES
(N'admin', N'admin', 2),
(N'qltrucly', N'lyquanly123', 2),
(N'nhanvien', N'nhanvien', 1),
(N'thedanhct', N'thedanhcantho', 1),
(N'thuhahp', N'thuhahaiphong', 1);

-- Insert data into PhieuNhap
INSERT INTO PhieuNhap (MaPhieuNhap, MaNhaCungCap, NgayNhap, Gia, MaNhanVien)
VALUES
(N'PN01', N'NCC01', '2024-01-01', 1000.00, 1),
(N'PN02', N'NCC02', '2024-02-01', 2000.00, 2),
(N'PN03', N'NCC03', '2024-03-01', 3000.00, 3),
(N'PN04', N'NCC04', '2024-04-01', 4000.00, 4),
(N'PN05', N'NCC05', '2024-05-01', 5000.00, 5);

-- Insert data into ChiTietPhieuNhap
INSERT INTO ChiTietPhieuNhap (MaPhieuNhap, MaBangDia, HangSanXuat, SoLuong, Gia, GhiChu)
VALUES
(N'PN01', N'BD01', N'HSX01', 10, 100.00, N'Đơn hàng được giao hàng thành công'),
(N'PN02', N'BD02', N'HSX02', 20, 200.00, N'Đơn hàng được giao hàng thành công'),
(N'PN03', N'BD03', N'HSX03', 30, 300.00, N'Đơn hàng được giao hàng thành công'),
(N'PN04', N'BD04', N'HSX04', 40, 400.00, N'Đơn hàng được giao hàng thành công'),
(N'PN05', N'BD05', N'HSX05', 50, 500.00, N'Đơn hàng được giao hàng thành công');

-- Insert data into TheThanhVien
INSERT INTO TheThanhVien (MaKhachHang, NgayDangKy, NgayHetHan)
VALUES
( N'KH01', '2024-01-01', '2027-01-01'),
( N'KH02', '2024-02-01', '2027-02-01'),
( N'KH03', '2024-03-01', '2027-03-01'),
( N'KH04', '2024-04-01', '2027-04-01'),
( N'KH05', '2024-05-01', '2027-05-01');

-- Insert data into PhieuThue
INSERT INTO PhieuThue (MaPhieuThue, MaKhachHang, NgayThue)
VALUES
(N'PT06', N'KH05', '2024-05-01'),
(N'PT01', N'KH01', '2024-01-01'),
(N'PT02', N'KH02', '2024-02-01'),
(N'PT03', N'KH03', '2024-03-01'),
(N'PT04', N'KH04', '2024-04-01'),
(N'PT05', N'KH05', '2024-05-01');


-- Insert data into ChiTietPhieuThue
INSERT INTO ChiTietPhieuThue (MaPhieuThue, MaBangDia, TenBangDia, GiaThue, MaKhachHang, Hang, HoTen, NgayThue)
VALUES
(N'PT01', N'BD01', N'Nobita Và Bản Giao Hưởng Địa Cầu', 100.00, N'KH01', N'Phương Nam Phim', N'LÊ NHƯ NGỌC', '2024-01-01'),
(N'PT02', N'BD02', N'Đội bóng Thiếu Lâm', 200.00, N'KH02', N'Sài Gòn Audio', N'VÕ PHAN BÌNH AN', '2024-02-01'),
(N'PT03', N'BD03', N'Star War', 300.00, N'KH03', N'Bến Thành Audio', N'ĐĂNG TRẦN ANH THƯ', '2024-03-01'),
(N'PT04', N'BD04', N'Tuyển tập nhạc Opera', 150.00, N'KH04', N'Cánh Chim Việt Productions', N'VÕ TẤN LỘC', '2024-04-01'),
(N'PT05', N'BD05', N'Spider-Man: No Way Home', 200.00, N'KH05', N'Học Viện Âm Nhạc Quốc Gia', N'TRẦN THỊ KIỂU TRINH', '2024-05-01');

-- Insert data into PhieuTra
INSERT INTO PhieuTra (MaPhieuTra, MaPhieuThue, MaKhachHang, NgayThue)
VALUES
(N'PTRA01', N'PT01', N'KH01', '2024-01-01'),
(N'PTRA02', N'PT02', N'KH02', '2024-02-01'),
(N'PTRA03', N'PT03', N'KH03', '2024-03-01'),
(N'PTRA04', N'PT04', N'KH04', '2024-04-01'),
(N'PTRA05', N'PT05', N'KH05', '2024-05-01');

-- Insert data into ChiTietPhieuTra
INSERT INTO ChiTietPhieuTra (MaPhieuTra, MaBangDia, TenBangDia, HoTen, NgayThue, TienPhat, TinhTrang)
VALUES
(N'PTRA01', N'BD01', N'Nobita Và Bản Giao Hưởng Địa Cầu', N'LÊ NHƯ NGỌC', '2024-01-01', 00.00, N'Tốt'),
(N'PTRA02', N'BD02', N'Đội bóng Thiếu Lâm', N'VÕ PHAN BÌNH AN', '2024-02-01', 00.00, N'Tốt'),
(N'PTRA03', N'BD03', N'Star War', N'ĐĂNG TRẦN ANH THƯ', '2024-03-01', 300.00, N'Bị mất'),
(N'PTRA04', N'BD04', N'Tuyển tập nhạc Opera', N'VÕ TẤN LỘC', '2024-04-01', 100.00, N' Trả trễ hẹn'),
(N'PTRA05', N'BD05', N'Spider-Man: No Way Home', N'TRẦN THỊ KIỂU TRINH', '2024-05-01', 00.00, N'Tốt');

-- Insert data into BaoCao
INSERT INTO BaoCao (MaBaoCao, MaNhanVien, TenBaoCao, NgayBaoCao, NgayBatDau, NgayKetThuc, DoanhThu)
VALUES
(1, 1, N'Bao Cao 1', '2024-01-01', '2024-01-01', '2024-01-31', 10000.00),
(2, 2, N'Bao Cao 2', '2024-02-01', '2024-02-01', '2024-02-28', 20000.00),
(3, 3, N'Bao Cao 3', '2024-03-01', '2024-03-01', '2024-03-31', 30000.00),
(4, 4, N'Bao Cao 4', '2024-04-01', '2024-04-01', '2024-04-30', 40000.00),
(5, 5, N'Bao Cao 5', '2024-05-01', '2024-05-01', '2024-05-31', 50000.00);

-- Insert data into DoanhThu
INSERT INTO DoanhThu (MaBaoCao, MaNhanVien, DoanhThu)
VALUES
(1, 1, 10000.00),
(2, 2, 20000.00),
(3, 3, 30000.00),
(4, 4, 40000.00),
(5, 5, 50000.00);

-- Insert data into BienBan
INSERT INTO BienBan (MaKhachHang, MaBangDia, LyDo, TienPhat)
VALUES
(N'KH03', N'BD03', N'Khách hàng bị lạc mất đĩa đã cho thuê', 300.00),
(N'KH04', N'BD04', N'Trả đĩa không đúng thời hạn', 100.00);
