﻿CREATE DATABASE QL_GVHS
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
SODIENTHOAI VARCHAR(20),
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
 
 delete from HOSOHOCSINH where MAHS = 'HS0011'
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
 THEMTK 'admin','123456'
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
END

 INSERT INTO dbo.MONHOC
         ( MAMON, TENMON, GHICHU )
 VALUES  ( '', N'',N'')
-- thêm sửa xóa môn học và lớp học
go
CREATE PROC ThemMH(@MAMON char(10),@TENMON nvarchar(40),@GHICHU nvarchar(100)) AS
BEGIN
	 INSERT INTO dbo.MONHOC
         ( MAMON, TENMON, GHICHU )
	VALUES  ( @MAMON,@TENMON,@GHICHU)
END
go

CREATE PROC SuaMH (@MAMON char(10),@TENMON nvarchar(40),@GHICHU nvarchar(100)) AS
BEGIN
	UPDATE dbo.MONHOC SET 
	TENMON = @TENMON,GHICHU = @GHICHU WHERE MAMON = @MAMON
END
go
CREATE PROC THEMHS (@MAHS char(10),@TENHS NVARCHAR(40),@GIOITINH CHAR(3),@NGAYSINH DATE,@DIACHI NVARCHAR(100),@LOPHOC VARCHAR(10),@SODIENTHOAI VARCHAR(20))
	AS
	BEGIN 
		INSERT INTO  dbo.HOSOHOCSINH (MAHS,TENHS,GIOITINH,NGAYSINH,DIACHI,LOPHOC,SODIENTHOAI)
		VALUES  ( @MAHS,@TENHS,@GIOITINH,@NGAYSINH,@DIACHI,@LOPHOC,@SODIENTHOAI )
	END
go
CREATE PROC SUAHS (@MAHS char(10),@TENHS NVARCHAR(40),@GIOITINH CHAR(3),@NGAYSINH DATE,@DIACHI NVARCHAR(100),@LOPHOC VARCHAR(10),@SODIENTHOAI VARCHAR(20))
	AS
	BEGIN 
		UPDATE dbo.HOSOHOCSINH
		SET TENHS = @TENHS,GIOITINH = @GIOITINH,NGAYSINH = @NGAYSINH, DIACHI = @DIACHI, LOPHOC = @LOPHOC, SODIENTHOAI = @SODIENTHOAI Where MAHS = @MAHS
	END
go
 CREATE PROC XoaMH(@MAMON char(10)) AS
 BEGIN
		DELETE FROM dbo.MONHOC WHERE MAMON = @MAMON
 END
 GO
-- Lớp Học 
 
CREATE PROC ThemLH(@MALOP VARCHAR(10),@TENLOP VARCHAR(15)) AS
BEGIN
	 INSERT INTO dbo.LOP
	         ( MALOP, TENLOP )
	 VALUES  (@MALOP,@TENLOP ) 
END
go

CREATE PROC SuaLH (@MALOP VARCHAR(10),@TENLOP VARCHAR(15)) AS
BEGIN
	UPDATE dbo.LOP SET 
	TENLOP = @TENLOP WHERE MALOP = @MALOP
END
go
  