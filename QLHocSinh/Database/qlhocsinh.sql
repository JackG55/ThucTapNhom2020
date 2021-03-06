USE [TTNhom_QLHS]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[funcSDT]
(
@SoDT nvarchar(Max)
)
returns bit
as
begin
Declare @KQ bit;
Set @KQ=0;
Declare @So tinyint;
Set @So=0;
Declare @i tinyint;
Set @i=0;
While (@i<=len(@SoDT))
begin
if (charindex(substring(@SoDT,@i,1),'0123456789')!=0)
Set @So=@So+1;
Set @i=@i+1;
end
if (@SoDT='' or @So=10 or @So=11)--Điều kiện kiểm tra số đt ở đây
Set @KQ=1;
return @KQ;
end

GO
/****** Object:  Table [dbo].[DayHoc]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DayHoc](
	[MaGiaoVien] [char](10) NOT NULL,
	[MaMonHoc] [char](10) NOT NULL,
	[MaLop] [char](10) NOT NULL,
 CONSTRAINT [PK_Day] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC,
	[MaMonHoc] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaChi]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaChi](
	[TenTinh_ThanhPho] [nvarchar](50) NULL,
	[TenHuyen_Quan] [nvarchar](50) NULL,
	[TenXa_Phuong] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaHocSinh] [int] NOT NULL,
	[MaMonHoc] [char](10) NOT NULL,
	[DiemMieng] [float] NULL,
	[Diem15Phut] [float] NULL,
	[Diem1Tiet] [float] NULL,
	[DiemHocKi] [float] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC,
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGiaoVien] [char](10) NOT NULL,
	[HoTenGV] [nvarchar](70) NULL,
	[GioiTinh] [char](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Luong] [int] NULL,
	[NgayVaoLam] [date] NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHocSinh] [int] NOT NULL,
	[MaLop] [char](10) NULL,
	[HoTenHS] [nvarchar](70) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[GioiTinh] [char](3) NULL,
	[DanToc] [nvarchar](20) NULL,
	[HoTenPhuHuynh] [nvarchar](70) NULL,
	[SDTPhuHuynh] [char](10) NULL,
	[NamNhapHoc] [int] NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHocSinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [char](10) NOT NULL,
	[TenLop] [varchar](10) NULL,
	[MaGVCN] [char](10) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [char](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[tendangnhap] [varchar](50) NOT NULL,
	[matkhau] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DayHoc]  WITH CHECK ADD  CONSTRAINT [FKGiaoVien_Day] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[DayHoc] CHECK CONSTRAINT [FKGiaoVien_Day]
GO
ALTER TABLE [dbo].[DayHoc]  WITH CHECK ADD  CONSTRAINT [FKLop_Day] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[DayHoc] CHECK CONSTRAINT [FKLop_Day]
GO
ALTER TABLE [dbo].[DayHoc]  WITH CHECK ADD  CONSTRAINT [FKMonHoc_Day] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DayHoc] CHECK CONSTRAINT [FKMonHoc_Day]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_HS] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[HocSinh] ([MaHocSinh])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_HS]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FKMonHoc_Diem] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FKMonHoc_Diem]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_Lop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_GV_ChuNhiem] FOREIGN KEY([MaGVCN])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_GV_ChuNhiem]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [CheckGioiTinh_GiaoVien] CHECK  (([GioiTinh]='Nu' OR [GioiTinh]='Nam'))
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [CheckGioiTinh_GiaoVien]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [CheckGioiTinh_HS] CHECK  (([GioiTinh]='Nu' OR [GioiTinh]='Nam'))
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [CheckGioiTinh_HS]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [CheckSDTPH_HocSinh] CHECK  (([dbo].[funcSDT]([SDTPhuHuynh])=(1)))
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [CheckSDTPH_HocSinh]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachDiem]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DanhSachDiem](@malop CHAR(10),@mamonhoc CHAR(10))
AS
BEGIN
	SELECT Diem.MaHocSinh,HoTenHS,NgaySinh,GioiTinh,DiemMieng,Diem15Phut,Diem1Tiet,DiemHocKi,
		CAST(ROUND((DiemMieng + Diem15Phut+ Diem1Tiet * 2 + DiemHocKi * 3),2)/7  AS DECIMAL(10,2)) AS DiemTrungBinhMon 
	FROM dbo.Lop JOIN dbo.HocSinh ON HocSinh.MaLop = Lop.MaLop 
		JOIN dbo.Diem ON Diem.MaHocSinh = HocSinh.MaHocSinh
	WHERE dbo.Lop.MaLop = @malop AND MaMonHoc = @mamonhoc
END
GO
/****** Object:  StoredProcedure [dbo].[DoiMK]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DoiMK](@tendangnhap VARCHAR(50),@matkhau VARCHAR(100))
AS
BEGIN
	IF EXISTS (SELECT tendangnhap FROM dbo.NguoiDung WHERE tendangnhap = @tendangnhap)
		BEGIN
			UPDATE dbo.NguoiDung SET matkhau = @matkhau WHERE tendangnhap = @tendangnhap
		END
END
GO
/****** Object:  StoredProcedure [dbo].[DSGiangDay]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSGiangDay]
AS
BEGIN
	SELECT GiaoVien.MaGiaoVien,HoTenGV,DayHoc.MaLop,TenLop,DayHoc.MaMonHoc,TenMonHoc,SoTiet
	FROM dbo.DayHoc JOIN dbo.GiaoVien ON GiaoVien.MaGiaoVien = DayHoc.MaGiaoVien
		JOIN dbo.MonHoc ON MonHoc.MaMonHoc = DayHoc.MaMonHoc
		JOIN dbo.Lop ON Lop.MaLop = DayHoc.MaLop
END
GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachGiaoVien]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LayDanhSachGiaoVien]
AS
BEGIN
	SELECT * FROM dbo.GiaoVien
END
GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachHocSinh]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDanhSachHocSinh]
as
begin
	select * from HocSinh
end
GO
/****** Object:  StoredProcedure [dbo].[LayDanhSachLop]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayDanhSachLop]
AS
BEGIN
	SELECT Lop.MaLop,TenLop,MaGiaoVien,HoTenGV,COUNT(dbo.HocSinh.MaLop) AS SiSo
	FROM dbo.Lop  LEFT JOIN dbo.GiaoVien ON GiaoVien.MaGiaoVien = Lop.MaGVCN LEFT JOIN dbo.HocSinh ON HocSinh.MaLop = Lop.MaLop
	GROUP BY Lop.MaLop,TenLop,MaGiaoVien,HoTenGV
END
GO
/****** Object:  StoredProcedure [dbo].[LayDSHuyen]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDSHuyen](@tentinh nvarchar(50))
as
begin
	select distinct TenHuyen_Quan from DiaChi where TenTinh_ThanhPho like @tentinh
end
GO
/****** Object:  StoredProcedure [dbo].[LayDSXa]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LayDSXa](@tentinh nvarchar(50),@tenhuyen nvarchar(50))
as
begin
	select distinct TenXa_Phuong from DiaChi where TenTinh_ThanhPho like @tentinh and TenHuyen_Quan like @tenhuyen
end

GO
/****** Object:  StoredProcedure [dbo].[LayThongTinNguoiDung]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LayThongTinNguoiDung] 
AS
BEGIN
	SELECT * FROM dbo.NguoiDung
END
GO
/****** Object:  StoredProcedure [dbo].[NhapDiem]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[NhapDiem](@mahs int,@mamonhoc CHAR(10), @diemmieng FLOAT,@diem15phut FLOAT,@diem1tiet FLOAT,@diemhocki FLOAT)
AS
BEGIN
	IF NOT EXISTS (SELECT MaHocSinh,MaMonHoc FROM dbo.Diem WHERE MaHocSinh = @mahs AND MaMonHoc = @mamonhoc)
	BEGIN 
		INSERT INTO dbo.Diem
		(
		    MaHocSinh,
		    MaMonHoc,
		    DiemMieng,
		    Diem15Phut,
		    Diem1Tiet,
		    DiemHocKi
		)
		VALUES
		(@mahs,@mamonhoc,@diemmieng,@diem15phut,@diem1tiet,@diemhocki)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaDiem]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDiem](@mahs int,@mamonhoc CHAR(10), @diemmieng FLOAT,@diem15phut FLOAT,@diem1tiet FLOAT,@diemhocki FLOAT)
AS
BEGIN
	IF EXISTS (SELECT MaHocSinh,MaMonHoc FROM dbo.Diem WHERE MaHocSinh = @mahs AND MaMonHoc = @mamonhoc)
	BEGIN 
		UPDATE dbo.Diem
		SET DiemMieng = @diemmieng,Diem15Phut = @diem15phut,Diem1Tiet = @diem1tiet, DiemHocKi = @diemhocki
		WHERE MaHocSinh = @mahs AND MaMonHoc = @mamonhoc
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaGiangDay]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaGiangDay](@magv CHAR(10),@malop CHAR(10),@mamonhoc CHAR(10),@magvcu CHAR(10),@malopcu CHAR(10),@mamonhoccu CHAR(10))
AS
BEGIN
	IF EXISTS (SELECT MaGiaoVien,MaLop,MaMonHoc FROM dbo.DayHoc WHERE MaGiaoVien = @magvcu AND MaLop = @malopcu AND MaMonHoc = @mamonhoccu)
		BEGIN
			UPDATE dbo.DayHoc 
			SET MaGiaoVien = @magv,MaMonHoc = @mamonhoc , MaLop = @malop
			WHERE MaGiaoVien = @magvcu AND MaLop = @malopcu AND MaMonHoc = @mamonhoccu
        END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaGiaoVien]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaGiaoVien](@magv CHAR(10),@hotengv nvarchar(70),@ngaysinh date,
	@diachi nvarchar(200),@gioitinh char(3),@luong int, @ngayvaolam date,@chucvu nvarchar(50))
AS
BEGIN
	IF EXISTS (SELECT  MaGiaoVien FROM dbo.GiaoVien WHERE MaGiaoVien = @magv)
	BEGIN
		UPDATE dbo.GiaoVien
		SET HoTenGV = @hotengv,
			NgaySinh = @ngaysinh,
			DiaChi = @diachi,
			GioiTinh = @gioitinh,
			Luong = @luong,
			NgayVaoLam = @ngayvaolam,
			ChucVu = @chucvu
		WHERE MaGiaoVien = @magv
    END
END
GO
/****** Object:  StoredProcedure [dbo].[SuaHocSinh]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[SuaHocSinh] (@mahs int, @malop char(10), @hotenhs nvarchar(70),@ngaysinh date,
	@diachi nvarchar(200),@gioitinh char(3),@dantoc nvarchar(20),@hotenphuhuynh nvarchar(70),
	@sdtphuhuynh char(10),@namnhaphoc int)
as
begin
	if EXISTS ( select MaHocSinh from HocSinh where MaHocSinh = @mahs)
		begin
			update HocSinh
			set MaLop = @malop,
				HoTenHS = @hotenhs,
				NgaySinh = @ngaysinh,
				DiaChi = @diachi,
				GioiTinh = @gioitinh,
				DanToc = @dantoc,
				HoTenPhuHuynh = @hotenphuhuynh,
				SDTPhuHuynh = @sdtphuhuynh,
				NamNhapHoc = @namnhaphoc
			where MaHocSinh = @mahs
			Print(N'1')
		end
	else
		Print(N'0')
end
GO
/****** Object:  StoredProcedure [dbo].[SuaLop]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaLop](@malop CHAR(10),@tenlop VARCHAR(10),@magvcn CHAR(10))
AS
BEGIN
	IF EXISTS (SELECT MaLop FROM dbo.Lop WHERE MaLop = @malop)
	BEGIN
		UPDATE lop 
		SET TenLop = @tenlop,MaGVCN = @magvcn WHERE MaLop = @malop
	END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemGiangDay]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemGiangDay](@magv CHAR(10),@malop CHAR(10),@mamonhoc CHAR(10))
AS
BEGIN
	IF NOT EXISTS (SELECT MaGiaoVien,MaLop,MaMonHoc FROM dbo.DayHoc WHERE MaGiaoVien = @magv AND MaLop = @malop AND MaMonHoc = @mamonhoc)
		BEGIN
			INSERT INTO dbo.DayHoc
			(
			    MaGiaoVien,
			    MaMonHoc,
			    MaLop
			)
			VALUES
			( @magv,@mamonhoc,@malop)
		END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemGiaoVien]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[ThemGiaoVien] (@magv CHAR(10),@hotengv nvarchar(70),@ngaysinh date,
	@diachi nvarchar(200),@gioitinh char(3),@luong int, @ngayvaolam date,@chucvu nvarchar(50))
AS
begin
	if NOT EXISTS ( select MaGiaoVien FROM dbo.GiaoVien WHERE MaGiaoVien = @magv)
		begin
			insert into dbo.GiaoVien
			(
			    MaGiaoVien,
			    HoTenGV,
			    GioiTinh,
			    NgaySinh,
			    DiaChi,
			    Luong,
				NgayVaoLam,
				ChucVu
			)
			VALUES
			(@magv,@hotengv,@gioitinh,@ngaysinh,@diachi,@luong,@ngayvaolam,@chucvu)	
		end
END
GO
/****** Object:  StoredProcedure [dbo].[ThemHocSinh]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Proc [dbo].[ThemHocSinh] (@mahs int, @malop char(10), @hotenhs nvarchar(70),@ngaysinh date,
	@diachi nvarchar(200),@gioitinh char(3),@dantoc nvarchar(20),@hotenphuhuynh nvarchar(70),
	@sdtphuhuynh char(10),@namnhaphoc int)
as
begin
	if NOT EXISTS ( select MaHocSinh from HocSinh where MaHocSinh = @mahs)
		begin
			insert HocSinh
			( MaHocSinh,MaLop, HoTenHS, NgaySinh, DiaChi, GioiTinh, DanToc, HoTenPhuHuynh, SDTPhuHuynh, NamNhapHoc)
			values ( @mahs,@malop,@hotenhs,@ngaysinh,@diachi,@gioitinh,@dantoc,@hotenphuhuynh,@sdtphuhuynh,@namnhaphoc)
			Print(N'1')
		end
	else
		Print(N'0')
end
GO
/****** Object:  StoredProcedure [dbo].[ThemLop]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLop](@malop CHAR(10),@tenlop VARCHAR(10),@magvcn CHAR(10))
AS
BEGIN
	IF NOT EXISTS (SELECT MaLop FROM dbo.Lop WHERE MaLop = @malop)
	BEGIN
		INSERT INTO dbo.Lop
		(
		    MaLop,
		    TenLop,
		    MaGVCN
		)
		VALUES
		(@malop,@tenlop,@magvcn)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[XoaGiangDay]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaGiangDay](@magv CHAR(10),@malop CHAR(10),@mamonhoc CHAR(10))
AS
BEGIN
	IF EXISTS (SELECT MaGiaoVien,MaLop,MaMonHoc FROM dbo.DayHoc WHERE MaGiaoVien = @magv AND MaLop = @malop AND MaMonHoc = @mamonhoc)
	BEGIN
		DELETE dbo.DayHoc
	WHERE MaGiaoVien = @magv AND MaLop = @malop AND MaMonHoc = @mamonhoc
	END
	
END
GO
/****** Object:  StoredProcedure [dbo].[XoaGiaoVien]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaGiaoVien](@magv CHAR(10))
AS
BEGIN
	IF EXISTS (SELECT  MaGiaoVien FROM dbo.GiaoVien WHERE MaGiaoVien = @magv)
		BEGIN
			UPDATE dbo.Lop
			SET MaGVCN = NULL 
			WHERE MaGVCN = @magv
			DELETE DayHoc
			WHERE MaGiaoVien = @magv
			DELETE dbo.GiaoVien
			WHERE MaGiaoVien = @magv
        END
		
END
GO
/****** Object:  StoredProcedure [dbo].[XoaHocSinh]    Script Date: 12/19/2020 10:05:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Proc [dbo].[XoaHocSinh](@mahs int)
as
begin
	if exists (select MaHocSinh from HocSinh where MaHocSinh = @mahs)
	begin
		delete HocSinh where MaHocSinh = @mahs
	end
end
GO
