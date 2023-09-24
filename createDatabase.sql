use master;
drop database if exists DAMau;

create database DAMau;

use DAMau;
create table NhanViens(
	ID int identity(1,1) not null,
	MaNV varchar(20) default '' primary key,
	Email varchar(50) unique not null,
	TenNV nvarchar(50) not null,
	DiaChi nvarchar(100) not null,
	VaiTro tinyint not null,
	TrangThai tinyint not null,
	MatKhau nvarchar(50) not null
);

create table SanPhams(
	MaHang int identity(1,1),
	TenHang nvarchar(50),
	SoLuong int not null,
	DongGiaBan float not null,
	DongGiaNhap float not null,
	HinhAnh varchar(400) not null,
	GhiChu nvarchar(20) not null,
	TrangThai tinyint not null,
	MaNV varchar(20) foreign key references NhanViens(MaNV),
	constraint PK_SanPham primary key (MaHang, TenHang)
);

create table KhachHangs(
	SoDienThoai varchar(15) primary key,
	TenKhach nvarchar(50) not null,
	DiaChi nvarchar(100) not null,
	GioiTinh tinyint not null,
	TrangThai tinyint not null,
	MaNV varchar(20) foreign key references NhanViens(MaNV)
);

--create sequence MaNV_seq
--start with 1
--increment by 1;

go
CREATE TRIGGER MaNV_trigger
ON NhanViens
FOR INSERT
AS
BEGIN
    UPDATE NhanViens
    SET MaNV =  'NV' + CAST(i.ID as varchar(20))
    FROM NhanViens nv
    INNER JOIN inserted i ON nv.ID = i.ID;
END;
