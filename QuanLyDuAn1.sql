create database QuanLyDuAn
use QuanLyDuAn

CREATE TABLE PhongBan (
    MaPhongBan NVARCHAR(3) PRIMARY KEY,
    TenPhongBan NVARCHAR(30) NOT NULL UNIQUE,
    NgayThanhLap DATETIME NOT NULL,
    PhuCap FLOAT NOT NULL CHECK(PhuCap > 0)
);

CREATE TABLE NhanVien (
    MaNhanVien NVARCHAR(5) PRIMARY KEY,
    HoTen NVARCHAR(30) NOT NULL,
    MaPhongBan NVARCHAR(3),
    NgayVaoLam DATE NOT NULL,
    MucLuong FLOAT NOT NULL CHECK(MucLuong > 0),
    FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

CREATE TABLE DuAn (
    MaDuAn NVARCHAR(3) PRIMARY KEY,
    TenDuAn NVARCHAR(30) NOT NULL UNIQUE,
    TongKinhPhi DECIMAL(18, 2) NOT NULL CHECK(TongKinhPhi > 0), 
    MaNhanVienPhuTrach NVARCHAR(5),
    FOREIGN KEY (MaNhanVienPhuTrach) REFERENCES NhanVien(MaNhanVien)
);

select * from DuAn
--Cau 1
create procedure XoaPhongBan
	@MaPhongBan nvarchar(3)
as begin
	declare @Dem int
	declare @Loi nvarchar(300)
	set @Loi = ' '

	set @Dem = (select count(*) from PhongBan where MaPhongBan = @MaPhongBan)
	if @Dem = 0
		set @Loi = N'Ma phong ban khong ton tai'

	set @Dem = (select count(*) from NhanVien where MaPhongBan = @MaPhongBan)
	if @Dem > 0
		set @Loi = N'Khong the xoa do da ton tai o NhanVien'

	if @Loi = ' '
		delete from PhongBan
		where MaPhongBan = @MaPhongBan
	else
		raiserror(@Loi, 16, 1)
end

exec XoaPhongBan @MaPhongBan = N'PE1';

--Cau 2
create function TimKiemNhanVien(@TuKhoa nvarchar(50))
returns table
as return(
	select 
		nv.MaNhanVien,
		nv.HoTen,
		pb.TenPhongBan,
		nv.NgayVaoLam, 
		nv.MucLuong
	from
		NhanVien nv
	inner join
		PhongBan pb on nv.MaPhongBan = pb.MaPhongBan
	where 
		nv.MaNhanVien like '%' + @TuKhoa + '%' OR
		nv.HoTen like '%' + @TuKhoa + '%' OR
		pb.TenPhongBan like '%' + @TuKhoa + '%'
);

SELECT * FROM TimKiemNhanVien(N'John');

--Cau 3
create procedure ThemDuAn
	@MaDuAn nvarchar(3),
	@TenDuAn nvarchar(30),
	@TongKinhPhi float,
	@MaNhanVienPhuTrach nvarchar(5)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from DuAn where MaDuAn = @MaDuAn);
	if @Dem > 0
		set @Loi = N'Ma du an da ton tai';

	set @Dem = (select count(*) from DuAn where TenDuAn = @TenDuAn);
	if @Dem > 0
		set @Loi = N'Ten du an da ton tai';

	set @Dem = (select count(*) from NhanVien where MaNhanVien = @MaNhanVienPhuTrach);
	if @Dem = 0
		set @Loi = N'Ma nhan vien phu trach khong ton tai';

	if @TongKinhPhi <= 0
		set @Loi = N'Tong kinh phi khong hop le';

	if @Loi = ' '
		insert into DuAn (MaDuAn, TenDuAn, TongKinhPhi, MaNhanVienPhuTrach)
		values (@MaDuAn, @TenDuAn, @TongKinhPhi, @MaNhanVienPhuTrach);
	else
		raiserror(@Loi, 16, 1);
end

create procedure SuaDuAn
	@MaDuAn nvarchar(3),
	@TenDuAn nvarchar(30),
	@TongKinhPhi float,
	@MaNhanVienPhuTrach nvarchar(5)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from DuAn where MaDuAn = @MaDuAn);
	if @Dem = 0
		set @Loi = N'Ma du an khong ton tai';

	set @Dem = (select count(*) from NhanVien where MaNhanVien = @MaNhanVienPhuTrach);
	if @Dem = 0
		set @Loi = N'Ma nhan vien phu trach khong ton tai';

	if @TongKinhPhi <= 0
		set @Loi = N'Tong kinh phi khong hop le';
	
	if @Loi = ' '
		update DuAn
		set TenDuAn = @TenDuAn, TongKinhPhi = @TongKinhPhi, MaNhanVienPhuTrach = @MaNhanVienPhuTrach
		where MaDuAn = @MaDuAn;
	else
		raiserror(@Loi, 16, 1);
end

create procedure XoaDuAn
	@MaDuAn nvarchar(3)
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from DuAn where MaDuAn = @MaDuAn);
	if @Dem = 0
		set @Loi = N'Ma du an khong ton tai';

	if @Loi = ' '
		delete from DuAn where MaDuAn = @MaDuAn;
	else
		raiserror(@Loi, 16, 1);
end

create function TimKiemDuAn(@TuKhoa nvarchar(50))
returns table
as return
(
    select 
        da.MaDuAn,
        da.TenDuAn,
        da.TongKinhPhi,
        da.MaNhanVienPhuTrach
    from 
        DuAn da
    inner join
        NhanVien nv on da.MaNhanVienPhuTrach = nv.MaNhanVien
    where 
        da.MaDuAn like '%' + @TuKhoa + '%' or
        da.TenDuAn like '%' + @TuKhoa + '%' or
        da.MaNhanVienPhuTrach like '%' + @TuKhoa + '%'
);

-- Tìm kiếm dự án với từ khóa 'Dự án'
SELECT * FROM TimKiemDuAn(N'Gamma');

drop function TimKiemDuAn