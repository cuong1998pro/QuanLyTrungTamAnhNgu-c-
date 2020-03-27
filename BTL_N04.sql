--Phần mềm quản lý trung tâm ngoại ngữ
create database BTL_N04
go
use BTL_N04
go
--Tạo bảng
create table taikhoan
(
	 tendangnhap nvarchar(100)not null primary key,
	 matkhau nvarchar(100)not null default 1,
	 hoten nvarchar(100)not null default N'Chưa đặt tên',
	 gioitinh nvarchar(3)not null default N'Nam',
	 quyen nvarchar(100) not null default N'Nhân viên',
)
create table lich
(
	id int identity primary key,
	thu nvarchar(50) not null default N'Thứ 2, 4, 6',
	ca int not null default 1, --1,2,3:sáng chiều tối
)

--KHOAHOC (MaSoKH, TênKH )
create table khoa
(
	id  int identity primary key,
	ten nvarchar(100)not null default N'Chưa có tên',
	hocphi int not null default 0,
	ngaybatdau date not null default getdate(),
	ngayketthuc date
)
--GIAOVIEN( MaSoGV, HoTenGV, NgaySinhGV ,SđtGV , ĐiaChiGV .)
create table giaovien
(
	id  int identity primary key,
	hoten nvarchar(100) not null default N'Chưa có tên',
	ngaysinh date not null default '01/01/1990',
	phanloai nvarchar(100) not null default N'Cơ hữu',
	sodienthoai char(11)not null default '' ,
	diachi nvarchar(100) not null default N'',
)
--LOPHOC (MaSoLop, MaSoKH,MaSoNH,TenLop, Phong, NgayBD,NgayKT) 
create table lophoc
(
	id  int identity primary key,
	ten nvarchar(100) not null default N'Chưa có tên',
	phong char(11)not null default '' ,
	idlich int not null,	
	idkhoa int not null,
	idgiaovien int not null,
	constraint lophoc_lich foreign key (idlich) references lich(id),
	constraint lophoc_khoa foreign key (idkhoa)references khoa(id),
	constraint lophoc_giaovien foreign key (idgiaovien) references giaovien(id)
)--ok
--HOCVIEN(MaSoHV,HoTenHV,NgaySinhHV,ĐiaChiHV,SđtHV,GioiTinh,MaSoBL,MaSoLH )
create table hocvien
(
	id int identity primary key,
	hoten nvarchar(100) not null default N'Chưa có tên',
	gioitinh nvarchar(3)not null default N'Nam',
	ngaysinh date not null default '01/01/1990',
	diachi nvarchar(100) not null default N'',
	sodienthoai char(11)not null default '' ,
	email nvarchar(100)not null default '',
	loaihocvien int not null default 0, --1:chinhthuc
)--ok
--dang ky hoc (MaHv,MaLop,ThoiGian)
create table tinhtranghoctap
(
	idhocvien int not null,
	idlop int not null,
	thoigiandangky date not null default getdate(),
	diemtongket float not null default 0,
	xeploai nvarchar(100)not null default N'Chưa xếp loại',
	ghichu nvarchar(100)not null default N'',
	constraint pk_1 primary key(idhocvien,idlop),
	constraint dangkyhoc_hocvien foreign key(idhocvien) references hocvien(id),
	constraint dangkyhoc_lop foreign key(idlop) references lophoc(id),
)--ok
create table thanhtoan(
	id int identity,
	idhocvien int not null,
	ngaythanhtoan date not null default getdate(),
	tienthanhtoan int not null default 0,
	constraint thanhtoan_hocvien foreign key(idhocvien) references hocvien(id)
)--ok
-- DOTTHI ( MaDotThi , MaKhoaHoc , NgayThi , GioThi)
create table dotthi
(
	id int identity primary key,
	idkhoa int not null,
	ngaythi date not null default getdate(),
	giothi int not null default 8,
	constraint dotthi_khoa foreign key (idkhoa) references khoa(id)
)--ok

create table diemthi
(
	idhocvien int not null ,
	iddotthi int not null,
	idlop int not null,
	diemnghe float not null default 0,
	diemnoi float not null default 0,
	diemdoc float not null default 0,
	diemviet float not null default 0,
	constraint pk_diem primary key(idhocvien,iddotthi,idlop),
	constraint diem_hocvien foreign key(idhocvien) references hocvien(id),
	constraint diem_dotthi foreign key(iddotthi) references dotthi(id),
	constraint diem_lophoc foreign key(idlop) references lophoc(id)
)
go
create trigger diemthi_trigger on diemthi
for insert,update
as
begin
	declare @idhocvien int,@idlop int
	declare @diemtb float
	select @idhocvien=idhocvien from inserted
	select @idlop=idlop from inserted

	select @diemtb=((AVG(diemnghe)+avg(diemnoi)+avg(diemdoc)+avg(diemviet))/4) from diemthi where idhocvien=@idhocvien and idlop =@idlop

	update tinhtranghoctap set diemtongket=@diemtb where idhocvien=@idhocvien and idlop=@idlop 
end
go
create trigger xoadiem on diemthi for delete
as begin
	declare @count int,@idhocvien int,@idlop int,@dtb float

	select @idhocvien=idhocvien, @idlop=idlop from deleted

	select @count=count(*) from diemthi where idhocvien=@idhocvien and idlop=@idlop
	if(@count>0)
	begin
	select @dtb=((AVG(diemnghe)+avg(diemnoi)+avg(diemdoc)+avg(diemviet))/4) from diemthi where idhocvien=@idhocvien and idlop =@idlop
	update tinhtranghoctap set diemtongket=@dtb where idhocvien=@idhocvien and idlop=@idlop
	end
	else 
	update tinhtranghoctap set diemtongket=0 where idhocvien=@idhocvien and idlop=@idlop

end
go
insert into taikhoan(tendangnhap,matkhau) values(N'cuong','1')


