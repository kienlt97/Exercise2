CREATE DATABASE QL_GVHS
go
USE QL_GVHS
go
CREATE TABLE LOP(
MALOP VARCHAR(10) PRIMARY KEY,
TENLOP VARCHAR(15)
)
go
CREATE TABLE GIAO_VIEN(
MAGV CHAR(10) PRIMARY KEY,
TENGV NVARCHAR(40),
THONGTIN NVARCHAR(100),
CNLOP VARCHAR(10),
GDAY  VARCHAR(10) REFERENCES LOP(MALOP)
)
go
CREATE TABLE HOSOHOCSINH(
MAHS CHAR(10) PRIMARY KEY,
TENHS NVARCHAR(40),
GIOITINH CHAR(3) CHECK (GIOITINH IN ('NAM','NU')),
NGAYSINH DATE,
DIACHI NVARCHAR(100),
SODIENTHOAI INT,
HOTENBO NVARCHAR(40),
HOTENME NVARCHAR(40),
LOPHOC VARCHAR(10) REFERENCES LOP(MALOP)
)
go
CREATE TABLE MONHOC(
MAMON CHAR(10) PRIMARY KEY,
TENMON NVARCHAR(50),
GHICHU NVARCHAR(100)
)
go
CREATE TABLE BANGDIEM(
MAHS CHAR(10) REFERENCES HOSOHOCSINH(MAHS),
MAMON CHAR(10) REFERENCES MONHOC(MAMON),
HOCKY CHAR(10),
DIEMMIENG FLOAT,
DIEM15P FLOAT,
DIEM1TIET FLOAT,
DIEMHOCKY FLOAT,
PRIMARY KEY(MAHS,MAMON)
)
go
CREATE TABLE Login(
Username VARCHAR(50) PRIMARY KEY,
Pass VARCHAR(50),
)
go
INSERT INTO Login VALUES('admin','123456')
go
INSERT INTO dbo.LOP
        ( MALOP, TENLOP )
VALUES  ( '01', -- MALOP - varchar(10)
          'A1'  -- TENLOP - varchar(15)
          )
		  INSERT INTO dbo.LOP
        ( MALOP, TENLOP )
VALUES  ( '02', -- MALOP - varchar(10)
          'A2'  -- TENLOP - varchar(15)
          )
		  INSERT INTO dbo.LOP
        ( MALOP, TENLOP )
VALUES  ( '03', -- MALOP - varchar(10)
          'A3'  -- TENLOP - varchar(15)
          )
		  INSERT INTO dbo.LOP
        ( MALOP, TENLOP )
VALUES  ( '04', -- MALOP - varchar(10)
          'A4'  -- TENLOP - varchar(15)
          )
		  INSERT INTO dbo.LOP
        ( MALOP, TENLOP )
VALUES  ( '05', -- MALOP - varchar(10)
          'A5'  -- TENLOP - varchar(15)
          )
		  INSERT INTO dbo.LOP
        ( MALOP, TENLOP )
VALUES  ( '07', -- MALOP - varchar(10)
          'A7'  -- TENLOP - varchar(15)
          )
 go
  INSERT INTO HOSOHOCSINH VALUES('HS001',N'Tạ Hữu Kiên',N'NAM','03/06/2000',N'Hoàng Quốc Việt - Cầu Giấy - Hà Nội','0905111123',N'Nguyễn Đức Tuyến',N'Đinh Thị Tâm','01')
  INSERT INTO HOSOHOCSINH VALUES('HS002',N'Chử Thị Bích Ngọc',N'NU','09/08/2000',N'Hoàng Quốc Việt - Cầu Giấy - Hà Nội','0905111124',N'Nguyễn Anh Sơn',N'Trần Thụ Ngọc','02')
  INSERT INTO HOSOHOCSINH VALUES('HS003',N'Phạm Thị Thu Phương',N'NAM','11/08/2000',N'Hoàng Quốc Việt - Cầu Giấy - Hà Nội','0905111125',N'Đặng Minh Được',N'Vũ Như Quỳnh','03')
  INSERT INTO HOSOHOCSINH VALUES('HS004',N'Nguyễn Hồng Quang',N'NAM','02/03/2000',N'Hoàng Quốc Việt - Cầu Giấy - Hà Nội','0905111126',N'Tô Xuân Lợi',N'Vy Như Ngọc','05')
  INSERT INTO HOSOHOCSINH VALUES('HS005',N'Nguyễn Thị Loan',N'NU','05/11/2000',N'Hoàng Quốc Việt - Cầu Giấy - Hà Nội','0905111126',N'Nguyễn Đức Anh',N'Nguyễn AB','04')
  INSERT INTO HOSOHOCSINH VALUES('HS006',N'Nguyễn Ngọc Thúy',N'NAM','06/04/2000',N'Hoàng Quốc Việt - Cầu Giấy - Hà Nội','0905111127',N'Nguyễn Bình Chiến',N'Tạ Thị Thương','07')
go
  INSERT INTO GIAO_VIEN VALUES('GV001',N'Trần Đồng Trực',N'Điện Biên Phủ, Hà Nội','A2','01')
  INSERT INTO GIAO_VIEN VALUES('GV002',N'Trần Phương Lan',N'Cầu Giấy – Hà Nội','A5','02')
  INSERT INTO GIAO_VIEN VALUES('GV003',N'Diệp Thị Ngọc Thủy',N'P. Điện Biên Phủ, Ba Đình, HN','A7','03')
  INSERT INTO GIAO_VIEN VALUES('GV004',N'Nguyễn Thanh Thúy',N'La Khê – Hà Đông','A1','04')
go
CREATE PROC ThemGV(@MAGV char(10),@TENGV  nvarchar(40),@THONGTIN nvarchar(100),@CNLOP  varchar(10),@GDAY  VARCHAR(10)) AS
BEGIN
	INSERT INTO dbo.GIAO_VIEN
        ( MAGV, TENGV, THONGTIN, CNLOP, GDAY)
VALUES  ( @MAGV,@TENGV,@THONGTIN,@CNLOP,@GDAY)
END
go
ThemGV 'GV01',N'Chu Văn Thịnh',N'Ba Vì','','07'
go
CREATE PROC SuaGV (@MAGV char(10),@TENGV  nvarchar(40),@THONGTIN nvarchar(100),@CNLOP  varchar(10),@GDAY  VARCHAR(10)) AS
BEGIN
	UPDATE dbo.GIAO_VIEN SET 
	TENGV = @TENGV,THONGTIN = @THONGTIN,CNLOP = @CNLOP,GDAY =@GDAY WHERE MAGV = @MAGV
END
go
 CREATE PROC XoaGV(@MAGV char(10)) AS
 BEGIN
		DELETE FROM dbo.GIAO_VIEN WHERE MAGV = @MAGV
 END
 go
 CREATE PROC dbo.KiemTraDN(@Username VARCHAR(50),@Pass varchar(50)) AS 
 BEGIN
	SELECT * FROM dbo.Login WHERE Username = @Username AND Pass = @Pass
 END
 go
CREATE PROC ThemTK(@Username VARCHAR(50),@Pass varchar(50)) AS 
 BEGIN
	INSERT INTO dbo.Login
	        ( Username, Pass )
	VALUES  ( @Username,@Pass )
 END
 go

 CREATE PROC XOAHS (@MAHS char(10))
	AS
	BEGIN 
				DELETE FROM dbo.HOSOHOCSINH
				WHERE MAHS=@MAHS
	END
	--exec XOAHS 'HS01'
go
create proc TimKiemHSTheoMAHS (@MAHS char(10)) as
begin
	select * from HOSOHOCSINH
	where MAHS=@MAHS
end
go
--execute TimKiemHSTheoMAHS 'HS002'
create proc TimKiemHSTheoTen (@TENHS nvarchar(40)) as
begin
	select * from HOSOHOCSINH
	where TENHS like '%'+N'@TENHS'+'%'
end
go
create proc TimKiemGiangDay (@GDAY varchar(10)) as
begin
	select * from GIAO_VIEN
	where GDAY=@GDAY
end