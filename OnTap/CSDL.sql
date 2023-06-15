create database OnTap
go
use OnTap
go
create table LoaiMatHang
(
	MaHang int identity(1,1) primary key,
	TenLoaiHang nvarchar(50)
)
go
create table MatHang
(
	MaMatHang int identity(1,1) primary key,
	TenMatHang nvarchar(50),
	LoaiMatHang int references LoaiMatHang(MaHang),
	SoLuongTon int,
	DonGia float
)
go

insert into LoaiMatHang values (N'Áo khoác')
insert into LoaiMatHang values (N'Quần Jean')
insert into LoaiMatHang values (N'Áo thun')
insert into LoaiMatHang values (N'Áo sơ mi')
insert into LoaiMatHang values (N'Váy')

select * from LoaiMatHang
create proc USP_ThemMatHang
	@TenMatHang nvarchar(50),
	@LoaiMatHang int,
	@SoLuongTon int,
	@DonGia float
as
begin
	insert into MatHang(TenMatHang, LoaiMatHang, SoLuongTon, DonGia)
	values (@TenMatHang, @LoaiMatHang, @SoLuongTon, @DonGia)
end
exec  USP_ThemMatHang N'Áo khoác gió nam', 1, 10, 300000
exec  USP_ThemMatHang N'Áo khoác gió nữ', 1, 15, 220000
exec  USP_ThemMatHang N'Quần jean nam', 2, 20, 350000
exec  USP_ThemMatHang N'Quần jean nữ', 2, 13, 350000
exec  USP_ThemMatHang N'Áo thun nam trắng', 3, 23, 120000
exec  USP_ThemMatHang N'Áo thun nữ', 3, 45, 100000
exec  USP_ThemMatHang N'Áo sơ mi nữ', 4, 35, 120000
exec  USP_ThemMatHang N'Váy ngắn', 5, 23, 110000
exec  USP_ThemMatHang N'Váy dài', 5, 30, 130000
exec  USP_ThemMatHang N'Set váy', 5, 40, 280000
select * from MatHang
create proc USP_CapNhatMatHang
	@MaMatHang int,
	@TenMatHang nvarchar(50),
	@LoaiMatHang int,
	@SoLuongTon int,
	@DonGia float
as
begin
	update MatHang
	set 
		TenMatHang = @TenMatHang,
		LoaiMatHang = @LoaiMatHang,
		SoLuongTon = @SoLuongTon,
		DonGia = @DonGia
	where MaMatHang=@MaMatHang
end	

-- hieern thij ten loai khi biet ma
create proc USP_HienThiTenTheoMa
	@MaHang int
as
begin
	select TenLoaiHang from LoaiMatHang
	where MaHang=@MaHang
end

exec USP_HienThiTenTheoMa 1

CREATE PROCEDURE USP_XemDanhSachMatHang
AS
BEGIN
    SELECT
        MH.MaMatHang,
        MH.TenMatHang,
        LH.TenLoaiHang,
        MH.SoLuongTon,
        MH.DonGia
    FROM
        MatHang MH
    JOIN
        LoaiMatHang LH ON MH.LoaiMatHang = LH.MaHang;
END

Exec USP_XemDanhSachMatHang

-- thủ tục thêm loại hàng
create proc USP_ThemLoaiHang
	@TenLoaiHang nvarchar(50)
as
begin
	insert into LoaiMatHang(TenLoaiHang)
	values (@TenLoaiHang)
end	