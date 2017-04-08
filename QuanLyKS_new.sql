create database QuanLyKS
go 
use QuanLyKS
go 
-----
create table LoaiPhong(
	MaLP int IDENTITY primary key,
	TenLP nvarchar(50),
	GiaPhong float
)
----
create table Phong(
	MaPhong int IDENTITY  primary key,
	SoPhong nvarchar(20),
	MaLP int,
	Trangthai nchar(10),
	FOREIGN KEY (MaLP) references LoaiPhong(MaLP)
)
-----
-----
create table ThietBi(
	MaTB int IDENTITY primary key,
	TenTB nvarchar(50),
	Ghichu nvarchar(50)
)
----
create table DichVu(
	MaDV int IDENTITY primary key,
	TenDV nvarchar(50),
	giaDV float
)

----
create table ThietBi_SD(
	MaPhong int,
	MaTB  int,
	Soluong int,
	CONSTRAINT ma1 Primary key(MaPhong,MaTB),
	FOREIGN KEY (MaPhong) references Phong(MaPhong),
	FOREIGN KEY (MaTB) references ThietBi(MaTB)
)
------
create table DichVu_SD(
	MaPhong int,
	MaDV int IDENTITY,
	Soluong int,
	Tongtien float,
	CONSTRAINT ma2 Primary key(MaPhong,MaDV),
	FOREIGN KEY (MaPhong) references Phong(MaPhong),
	FOREIGN KEY (MaDV) references DichVu(MaDV)

)
---
create table KhachHang(
	MaKH int IDENTITY primary key,
	HotenKH nvarchar(60),
	CMND nchar(10),
	SDT nchar(20),
	Diachi nvarchar(50),
	Gioitinh nvarchar(10)
)
----
create table NhanVien(
	MaNV int IDENTITY primary key,
	HotenNV  nvarchar(60),
	password nvarchar(30), 
	CMND nchar(10),
	Ngaysinh date,
	Gioitinh nvarchar(10),
	SDT nchar(20),
	Diachi nvarchar(50),
	Chucvu nvarchar(30)
)
----
create table HoaDon(
	MaHD int IDENTITY primary key,
	MaKH int,
	MaNV int,
	Ngaylap date,
	Tongtien float,
	FOREIGN KEY (MaKH) references KhachHang(MaKH),
	FOREIGN KEY (MaNV) references NhanVien(MaNV)
)
create table ChitietHD(
	MaHD int,
	MaPhong int,
	Giamgia float,
	Ngaynhan date,
	Ngaytra date,
	Tongtien float,
	CONSTRAINT ma3 Primary key(MaPhong,MaHD),
	FOREIGN KEY (MaPhong) references Phong(MaPhong),
	FOREIGN KEY (MaHD) references HoaDon(MaHD)
)
-----
create table PhieuThuePhong(
	MaPhieu int IDENTITY primary key,
	MaKH int,
	MaPhong int,
	NgayNhan date,
	FOREIGN KEY (MaPhong) references Phong(MaPhong),
	FOREIGN KEY (MaKH) references KhachHang(MaKH)
)