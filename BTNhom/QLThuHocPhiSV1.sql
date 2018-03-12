create database QLThuHocPhiSV1
go

create table BienLaiTienHoc(
   SoBienLai varchar(10) primary key,
   NgayThu datetime,
   NguoiThu nvarchar(50),
   Tongtien int,
 MaSV varchar(10) references SinhVien (MaSV)
)

create table ChiTietBienLai(
 SoBienLai varchar(10) references BienLaiTienHoc(SoBienLai),
 MaMonHoc varchar(10) references MonHoc(MaMonHoc),
  primary key (SoBienLai,MaMonHoc)
)

create table DoiTuongMienGiam(
   MaDoiTuong varchar(10) primary key,
   TenDoiTuong nvarchar(50),
   MienGiam int,

)
create table Khoa(
   MaKhoa varchar(10) primary key,
   TenKhoa nvarchar(50),
   DiaChi nvarchar(250),
   SoDienThoai varchar(20)
)
create table Lop(
   MaLop varchar(10) primary key,
   TenLop nvarchar(50),
   SiSo int,
   MaKhoa varchar(10) references Khoa(MaKhoa),
)
create table MonHoc(
  MaMonHoc varchar(10) primary key,
  TenMonHoc nvarchar(50),
  SoTC int,
  MaLopMonHoc varchar(10) references LopMonHoc(MaLopMonHoc)
)


create table Mucthu(
 MaMucThu varchar(10),
 Tien1TinChi decimal(18,0),
 Ki Nvarchar(50),
 NamHoc Nvarchar(50),
 Sotien int,
 primary key(MaMucthu)
)
create table SinhVien(
 MaSV varchar(10) primary key,
 HoTen nvarchar(50),
 GioiTinh nvarchar(50),
 NgaySinh datetime,
 MaDoiTuong varchar(10) references DoiTuongMienGiam(MaDoiTuong),
 MaLop varchar(10) references Lop(MaLop) ,
)

create table LopMonHoc(
MaLopMonHoc varchar(10) primary key,
NamHoc nvarchar (50),
HocKi nvarchar(50),
Siso int,
MaMucThu varchar(10) references MucThu(MaMucThu),
MaLop varchar(10) references Lop(MaLop)
)



-----BIÊN LAI TIỀN HỌC---------------------------------------------------------------------
create PROC them_blth(@SoBL varchar(10) ,@Ngaythu datetime ,@Nguoithu nvarchar(50),@MaSv varchar(10))
as
begin
insert into BienLaiTienHoc(SoBienLai,NgayThu,NguoiThu,MaSV)
values (@SoBL,@Ngaythu,@Nguoithu,@MaSv)
end

CREATE PROC sua_blth(@SoBL varchar(10) ,@Ngaythu datetime ,@Nguoithu nvarchar(50),@MaSv varchar(10))
as
begin
update BienLaiTienHoc
set NgayThu=@Ngaythu , NguoiThu=@Nguoithu ,MaSV=@MaSv
where SoBienLai=@SoBL
end

CREATE PROC xoa_blth (@SoBL varchar(10))
as
begin
delete BienLaiTienHoc
where SoBienLai=@SoBL
end

them_blth 'BL001','01/08/2017', N'Đoàn Văn A','SV005'

xoa_blth 'BL001'
SELECT * FROM BienLaiTienHoc

CREATE PROC sear_ctbl (@MaBL varchar(10))
as
begin select * from ChiTietBienLai where SoBienLai=@MaBL 
end

Create proc sear_mh (@Mal varchar(10))
as
begin
 select * from MonHoc ,LopMonHoc,Lop where MonHoc.MaLopMonHoc = LopMonHoc.MaLopMonHoc and 
 LopMonHoc.MaLop =Lop.MaLop and Lop.MaLop=@Mal
 end

---------CHI TIẾT BIÊN LAI---------------------------------------------------------------
create PROC them_ctbl(@SoBL varchar(10),@MaMH varchar(10))
as
begin 
insert into ChiTietBienLai(SoBienLai,MaMonHoc)
values (@SoBL,@MaMH)
end

CREATE PROC sua_ctbl(@SoBL varchar(10),@MaMH varchar(10))
as
begin
update ChiTietBienLai
set MaMonHoc=@MaMH
where SoBienLai=@SoBL
end

CREATE PROC xoa_ctbl (@SoBL varchar(10))
as
begin 
delete ChiTietBienLai
where SoBienLai=@SoBL
end

select * from ChiTietBienLai 
them_ctbl 'BL001','MH001'
them_ctbl 'BL001','MH002'
them_ctbl 'BL001','MH003'
xoa_ctbl 'BL001'


  --sinh viên-----------------------------------------------------------------------------
create PROC them_sv (@MaSV varchar(10),@TenSV nvarchar(50),@Gioitinh nvarchar(50),@Ngaysinh datetime,@Madt varchar(10),@Mal varchar(10))
as
begin
insert into sinhvien(MaSV,HoTen,GioiTinh,NgaySinh,MaDoiTuong,MaLop)
values (@MaSV,@TenSV,@Gioitinh,@Ngaysinh,@Madt,@Mal)
end
select * from SinhVien
them_sv 'SV005',N'Bùi Tùng Lâm1',N'Nam','10/10/1997','DT000','Lop001'

CREATE PROC sua_sv (@MaSV varchar(10),@TenSV nvarchar(50),@Gioitinh nvarchar(50),@Ngaysinh date,@Madt varchar(10),@Mal varchar(10))
as
begin
update sinhvien
set HoTen= @TenSV,
GioiTinh= @Gioitinh ,
NgaySinh= @Ngaysinh,
MaDoiTuong= @Madt,
MaLop=  @Mal
where MaSV=@MaSV
end

create proc xoa_sv (@MaSV varchar(10))
as
begin 
delete SinhVien
where MaSV=@MaSV
end
select *from SinhVien
xoa_sv 'SV001'
---ĐỐI TƯỢNG MIỄN GIẢM--------------------------------------------------------------------------
CREATE PROC them_dtmg (@MaDT varchar(10),@TenDT nvarchar(50),@Miengiam int)
as 
begin
insert into DoiTuongMienGiam
values (@MaDT,@TenDT,@Miengiam)
end

CREATE PROC sua_dtmg (@MaDT varchar(10),@TenDT nvarchar(50),@Miengiam int)
as 
begin
update DoiTuongMienGiam
set TenDoiTuong=@TenDT,MienGiam=@Miengiam
where MaDoiTuong=@MaDT
end

CREATE PROC xoa_dtmg (@MaDT varchar(10))
as
begin
delete DoiTuongMienGiam
where MaDoiTuong=@MaDT
end

select * from DoiTuongMienGiam
-- Khoa------------------------------------------------------------------------------------------


create proc Khoa_themKhoa(@MaKhoa varchar(10), @TenKhoa nvarchar(50) , @DiaChi nvarchar(50) , @SoDienThoai varchar(20))
as
begin
INSERT INTO Khoa (MaKhoa, TenKhoa, DiaChi, SoDienThoai)
values (@MaKhoa, @TenKhoa, @DiaChi,@SoDienThoai)
end


create proc Khoa_suaKhoa(@MaKhoa varchar(10), @TenKhoa nvarchar(50) , @DiaChi nvarchar(50) , @SoDienThoai varchar(20))
as
begin
update  Khoa 
set TenKhoa=@TenKhoa, DiaChi=@DiaChi ,SoDienThoai=@SoDienThoai 
where MaKhoa=@MaKhoa
end

create proc Khoa_xoaKhoa(@MaKhoa varchar(10))
as
begin
delete Khoa
where MaKhoa=@MaKhoa
end
select * from Khoa
insert into Khoa
values ('k001',N'Công nghệ thông tin',N'Hoàng Quốc Việt','08323265')

Khoa_themkhoa 'k003','công ngh? thông tin','236 Hoàng Qu?c Vi?t','01235975694'
Khoa_themkhoa 'k004','công ngh? thông tin','236 Hoàng Qu?c Vi?t','01235975694'
Khoa_themkhoa 'k005','công ngh? thông tin','236 Hoàng Qu?c Vi?t','01235975694'
Khoa_themkhoa 'k006','công ngh? thông tin','236 Hoàng Qu?c Vi?t','01235975694'


-----------------------------------------------------------------------------------------
---Lop-------

select * from Lop
create proc Lop_themLop(@MaLop varchar(10),@TenLop nvarchar(50) , @SiSo int,@MaKhoa varchar(10))
as
begin
INSERT INTO Lop(MaLop, TenLop, SiSo, MaKhoa)
VALUES (@MaLop, @TenLop,@SiSo, @MaKhoa)
end

create proc Lop_suaLop (@MaLop varchar(10),@TenLop nvarchar(50) , @SiSo int,@MaKhoa varchar(10))
as
begin
update Lop 
set TenLop=@TenLop,SiSo=@SiSo,MaKhoa=@MaKhoa
where MaLop=@MaLop
end

create proc Lop_xoaLop (@MaLop varchar(10))
as
begin
delete Lop 
where MaLop=@MaLop
end

Lop_ThemLop 'Lop001' ,'ccdth17',40,'K001'
Lop_ThemLop 'Lop002' ,'ccdth18',42,'K001'
Lop_ThemLop 'Lop003' ,'dtvt17',39,'K001'
Lop_ThemLop 'Lop004' ,'dtvt18',45,'K001'
Lop_themLop 'Lop005','CDTH18',60,'k003'
Lop_themLop 'Lop006','CDTH18',60,'k004'

select * from Lop


---------Môn học-----------------------------------------------------------------------------
create proc them_MonHoc(@MaMH varchar(10),@TenMH nvarchar(50),@SoTC int,@MaLopMH varchar(10))
as
begin
insert into MonHoc(MaMonHoc,TenMonHoc,SoTC,MaLopMonHoc)
values (@MaMH,@TenMH,@SoTC,@MaLopMH)
end

create proc sua_Monhoc(@MaMH varchar(10),@TenMH nvarchar(50),@SoTC int,@MaLopMH varchar(10))
as
begin
update MonHoc
set TenMonHoc=@TenMH,SoTC=@SoTC,MaLopMonHoc=@MaLopMH
where MaMonHoc =@MaMH
end

create proc Xoa_Monhoc (@MaMonHoc varchar(10))
as
begin
delete MonHoc
where MaMonHoc=@MaMonHoc
end 

them_MonHoc 'MH001',N'Công nghệ thông tin',2,'MLMH001'
them_MonHoc 'MH002',N'Cơ sở toán trong tin học',3,'MLMH002'
them_MonHoc 'MH003',N'Điện tử số',2,'MLMH003'
them_MonHoc 'MH004',N'Thể dục thể thao 2',1,'MLMH001'

Xoa_Monhoc 'MH001'
select * from MonHoc




--------------------

select *  from Mucthu
-----------Mức thu-------------------------------------------------------------------------------
alter proc them_Mucthu(@MaMucthu varchar(10),@tien1TC int ,@Ki nvarchar(10),@NamHoc nvarchar(50))
as
begin
insert into Mucthu(MaMucThu,Tien1TinChi,Ki,NamHoc)
values (@MaMucthu,@tien1TC,@Ki,@NamHoc)
end

alter proc sua_Mucthu (@MaMucthu varchar(10),@tien1TC int ,@Ki nvarchar(10),@NamHoc nvarchar(50))
as
begin
update Mucthu
set Tien1TinChi=@tien1TC,Ki=@Ki ,NamHoc=@NamHoc
where MaMucthu=@MaMucThu
end

create proc xoa_Mucthu  (@MaMucthu varchar(10))
as
begin
delete Mucthu
where MaMucthu=@MaMucThu
end

INSERT INTO Mucthu(MaMucThu,Tien1TinChi)
values ('MMT001','250000')
INSERT INTO Mucthu(MaMucThu,Tien1TinChi)
values ('MMT002','250000')
INSERT INTO Mucthu(MaMucThu,Tien1TinChi)
values ('MMT003','250000')
select * from Mucthu




----------LỚP Mon Hoc--------------------------------------------------------------------
create proc Them_LopMH(@MaLMH varchar(10),@NamHoc nvarchar(50),@Hocki nvarchar(50),@Siso int,@MaLop varchar(10),@MaMucThu varchar(10))
as
begin
insert into LopMonHoc(MaLopMonHoc,NamHoc,HocKi,Siso,MaLop,MaMucThu)
values (@MaLMH,@NamHoc,@Hocki,@Siso,@MaLop,@MaMucThu)
end

create proc Sua_LopMH(@MaLMH varchar(10),@NamHoc nvarchar(50),@Hocki nvarchar(50),@Siso int,@MaLop varchar(10),@MaMucThu varchar(10))
as
begin
update LopMonHoc
set NamHoc=@NamHoc , HocKi=@Hocki , Siso=@Siso,MaLop=@MaLop,MaMucThu=@MaMucThu
where MaLopMonHoc=@MaLMH
end

create proc Xoa_LopMH (@MaLopMH varchar(10))
as 
begin
delete LopMonHoc
where MaLopMonHoc=@MaLopMH
end
select * from LopMonHoc
--------------
insert into LopMonHoc(MaLopMonHoc,MaMucThu)
values ('MLMH001','MMT001')
insert into LopMonHoc(MaLopMonHoc,MaMucThu,MaLop)
values ('MLMH002','MMT002','Lop001')
insert into LopMonHoc(MaLopMonHoc,MaMucThu,MaLop)
values ('MLMH003','MMT003','Lop001')
Xoa_LopMH 'MLMH002'








---------Trigger--------
create trigger TinhTienLopMH
on MonHoc
instead of insert
as
begin
declare @MaMH varchar(10)
declare @TenMH nvarchar(50)
declare @Sotc int
declare @MaLMH varchar(10)
declare @MaMT varchar(10)
declare @Tien1tc int


select @MaMH = Mamonhoc from inserted
select @TenMH = Tenmonhoc from inserted
select @MaLMH = Malopmonhoc from inserted
select @Sotc = Sotc from inserted
select @MaMT = MaMucThu from LopMonHoc where MaLopMonHoc=@MaLMH
select @Tien1tc = Tien1TinChi from MucThu where MaMucThu = @MaMT

begin
insert into MonHoc(MaMonHoc,TenMonHoc,SoTC,MaLopMonHoc)
values (@MaMH,@TenMH,@Sotc,@MaLMH)
update Mucthu
set Sotien=(@Sotc*@Tien1tc)
where MaMucThu=@MaMT
end
end



-------TINH TIEN CUA SV THEO LOP-----
DROP TRIGGER Tinhtientheolop
alter trigger Tinhtientheolop
on BienLaiTienHoc
instead of insert 
as
begin
--insert 
declare @Sobienlai varchar(10)
declare @Ngaythu datetime
declare @Nguoithu nvarchar(50)
--


declare @Masv varchar(10)
declare @Malop varchar(10)
declare @Mamt varchar(10)
declare @Tongtienlop int
declare @TongtienTMG int
declare @TongtienSMG int
declare @Sotien int
declare @Mucmg int 
declare @Madt varchar(10)
declare @Malopsv varchar(10)

------Insert 
select @Sobienlai = sobienlai from inserted
select @Ngaythu = ngaythu from inserted
select @Nguoithu = nguoithu from inserted
------Lay so tien theo lop


select @Malop = MaLop from Lop
select @Mamt = MaMucThu from LopMonHoc where MaLop = @Malop
select @Tongtienlop = sum(Sotien) from Mucthu where MaMucThu = @Mamt

-------lay so tien cua sinh vien trong lop do
select @Masv = MaSV FROM SinhVien WHERE MaLop = @Malop
select @TongtienTMG = @Tongtienlop FROM Lop WHERE MaLop = @Malop

-------lay muc mien giam cua sinh vien
select @Madt = MaDoiTuong from SinhVien where MaSV = @Masv
select @Mucmg = MienGiam from DoiTuongMienGiam where MaDoiTuong = @Madt

-------lay so tien sau khi mien giam
select @TongtienSMG = @TongtienTMG-((@TongtienTMG/100)*@Mucmg)

begin 
Insert into BienLaiTienHoc(SoBienLai,NgayThu,NguoiThu,MaSV)
values (@Sobienlai,@Ngaythu,@Nguoithu,@Masv)


end
end



--------TINH TIEN THEO BIEN LAI
alter trigger TinhTienBienLai
on BienLaiTienHoc
instead of update
as
begin
--
declare @Sotien varchar(10)
declare @Mamt varchar(10)
declare @Malop varchar(10)
declare @MaMH varchar(10)
declare @Sobl varchar(10)
declare @TongTien int 
declare @Malmh varchar(10)

select @Sobl =SoBienLai from BienLaiTienHoc
select @MaMH = MaMonHoc from ChiTietBienLai where SoBienLai =@Sobl
select @Malmh = MaLopMonHoc from MonHoc where MaMonHoc = @MaMH
select @Mamt = MaMucThu from LopMonHoc where MaLopMonHoc =@Malmh
select @TongTien = sum(Sotien) from Mucthu where MaMucThu =@Mamt

begin
insert into ChiTietBienLai
values (@Sobl,@MaMH)

update BienLaiTienHoc
set Tongtien = @TongTien
where SoBienLai = @Sobl
end 
end

















select tongtien = sum(Sotien) from Mucthu,LopMonHoc,MonHoc,ChiTietBienLai,BienLaiTienHoc
where Mucthu.MaMucThu=LopMonHoc.MaMucThu 
and LopMonHoc.MaLopMonHoc = MonHoc.MaLopMonHoc
and MonHoc.MaMonHoc=ChiTietBienLai.MaMonHoc
and ChiTietBienLai.SoBienLai=BienLaiTienHoc.SoBienLai
and  BienLaiTienHoc.SoBienLai ='BL001'




select Tongtien= sum(Sotien) from BienLaiTienHoc ,SinhVien ,Lop,LopMonHoc,Mucthu where 

BienLaiTienHoc.MaSV = SinhVien.MaSV
and SinhVien.MaLop = Lop.MaLop 
and Lop.MaLop = LopMonHoc.MaLop 
and LopMonHoc.MaMucThu = Mucthu.MaMucThu
and Sinhvien.MaSV='SV005'


select Tongtienlop = sum(Sotien) from Mucthu,LopMonHoc,Lop where
 Mucthu.MaMucThu = LopMonHoc.MaMucThu
 and LopMonHoc.MaLop = lop.MaLop
 and Lop.MaLop = 'Lop001'



---------Update siso theo thong tin sinh vien
create TRIGGER UPDATESISO
on SinhVien
for INSERT
 AS
 begin 
 declare @siso int
 declare @MaL varchar(10)
 declare @count int

 select @MaL = MaLop from inserted
 select @siso = count(*) from SinhVien
 select @count = count(*) from inserted
 if(@count > 0)

	begin
		 update Lop
		 set SiSo = @siso
		where MaLop=@MaL
	end
end


create TRIGGER UPDATESISO1
on SinhVien
for delete
 AS
 begin 
 declare @siso int
 declare @MaL varchar(10)
 declare @count int

 select @MaL = MaLop from deleted
 select @siso = count(*) from SinhVien
 select @count = count(*) from deleted
 if(@count > 0)

	begin
		 update Lop
		 set SiSo = @siso
		where MaLop=@MaL
	end
end
