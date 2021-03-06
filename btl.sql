﻿USE [master]
GO
/****** Object:  Database [BTL_N04]    Script Date: 18/05/2019 9:38:21 SA ******/
CREATE DATABASE [BTL_N04]
 CONTAINMENT = NONE
 ON  PRIMARY 
GO
ALTER DATABASE [BTL_N04] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BTL_N04].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BTL_N04] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BTL_N04] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BTL_N04] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BTL_N04] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BTL_N04] SET ARITHABORT OFF 
GO
ALTER DATABASE [BTL_N04] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BTL_N04] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BTL_N04] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BTL_N04] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BTL_N04] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BTL_N04] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BTL_N04] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BTL_N04] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BTL_N04] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BTL_N04] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BTL_N04] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BTL_N04] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BTL_N04] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BTL_N04] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BTL_N04] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BTL_N04] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BTL_N04] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BTL_N04] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BTL_N04] SET  MULTI_USER 
GO
ALTER DATABASE [BTL_N04] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BTL_N04] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BTL_N04] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BTL_N04] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BTL_N04] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BTL_N04] SET QUERY_STORE = OFF
GO
USE [BTL_N04]
GO
/****** Object:  Table [dbo].[cauhinhdiem]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cauhinhdiem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idlop] [int] NOT NULL,
	[Nghe] [int] NULL,
	[hesoNghe] [int] NULL,
	[Nói] [int] NULL,
	[hesoNói] [int] NULL,
	[Đọc] [int] NULL,
	[hesoĐọc] [int] NULL,
	[Viết] [int] NULL,
	[hesoViết] [int] NULL,
 CONSTRAINT [PK__cauhinhd__3213E83FE951F6F1] PRIMARY KEY CLUSTERED 
(
	[idlop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diemthi]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diemthi](
	[idhocvien] [int] NOT NULL,
	[iddotthi] [int] NOT NULL,
	[idlop] [int] NOT NULL,
	[diemtrungbinh] [float] NULL,
	[Nghe] [float] NULL,
	[Nói] [float] NULL,
	[Đọc] [float] NULL,
	[Viết] [float] NULL,
 CONSTRAINT [pk_diem] PRIMARY KEY CLUSTERED 
(
	[idhocvien] ASC,
	[iddotthi] ASC,
	[idlop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dotthi]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dotthi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idkhoa] [int] NOT NULL,
	[ngaythi] [date] NOT NULL,
	[giothi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giaovien]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giaovien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](100) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[phanloai] [nvarchar](100) NOT NULL,
	[sodienthoai] [char](12) NULL,
	[diachi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocvien]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocvien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](100) NOT NULL,
	[gioitinh] [nvarchar](3) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[diachi] [nvarchar](100) NOT NULL,
	[sodienthoai] [char](12) NULL,
	[conno] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khoa]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khoa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[hocphi] [int] NOT NULL,
	[ngaybatdau] [date] NOT NULL,
	[ngayketthuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lich]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lich](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[thu] [nvarchar](50) NOT NULL,
	[ca] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaidiem]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaidiem](
	[ten] [nvarchar](100) NOT NULL,
	[thangdiem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lophoc]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lophoc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[phong] [varchar](5) NULL,
	[idlich] [int] NOT NULL,
	[idkhoa] [int] NOT NULL,
	[idgiaovien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tendangnhap] [nvarchar](100) NOT NULL,
	[matkhau] [nvarchar](100) NOT NULL,
	[hoten] [nvarchar](100) NOT NULL,
	[gioitinh] [nvarchar](3) NOT NULL,
	[quyen] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[a] [int] NULL,
	[b] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thanhtoan]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thanhtoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idhocvien] [int] NOT NULL,
	[ngaythanhtoan] [date] NOT NULL,
	[tienthanhtoan] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tinhtranghoctap]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinhtranghoctap](
	[idhocvien] [int] NOT NULL,
	[idlop] [int] NOT NULL,
	[thoigiandangky] [date] NOT NULL,
	[diemtongket] [float] NULL,
	[xeploai] [nvarchar](100) NOT NULL,
	[ghichu] [nvarchar](100) NOT NULL,
 CONSTRAINT [pk_1] PRIMARY KEY CLUSTERED 
(
	[idhocvien] ASC,
	[idlop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cauhinhdiem] ON 

INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (5, 2, 1, 1, 0, 0, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (6, 3, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (7, 4, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (10, 6, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (11, 7, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (12, 8, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (13, 9, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (14, 10, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (15, 11, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (16, 12, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (17, 13, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (18, 14, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (19, 15, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[cauhinhdiem] ([id], [idlop], [Nghe], [hesoNghe], [Nói], [hesoNói], [Đọc], [hesoĐọc], [Viết], [hesoViết]) VALUES (3, 16, 1, 1, 1, 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[cauhinhdiem] OFF
INSERT [dbo].[diemthi] ([idhocvien], [iddotthi], [idlop], [diemtrungbinh], [Nghe], [Nói], [Đọc], [Viết]) VALUES (7, 7, 1, 2.5, 2, 3, 1, 4)
INSERT [dbo].[diemthi] ([idhocvien], [iddotthi], [idlop], [diemtrungbinh], [Nghe], [Nói], [Đọc], [Viết]) VALUES (7, 10, 1, 2.75, 2, 3, 1, 5)
INSERT [dbo].[diemthi] ([idhocvien], [iddotthi], [idlop], [diemtrungbinh], [Nghe], [Nói], [Đọc], [Viết]) VALUES (8, 7, 2, 1.33333333333333, 1, 0, 1, 2)
INSERT [dbo].[diemthi] ([idhocvien], [iddotthi], [idlop], [diemtrungbinh], [Nghe], [Nói], [Đọc], [Viết]) VALUES (8, 9, 2, 4.33333333333333, 10, 0, 1, 2)
SET IDENTITY_INSERT [dbo].[dotthi] ON 

INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (3, 3, CAST(N'2019-05-02' AS Date), 13)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (4, 4, CAST(N'2019-05-03' AS Date), 14)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (5, 5, CAST(N'2019-05-04' AS Date), 15)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (6, 6, CAST(N'2019-05-05' AS Date), 16)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (7, 2, CAST(N'2019-05-02' AS Date), 12)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (8, 11, CAST(N'2020-05-02' AS Date), 8)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (9, 3, CAST(N'2019-05-16' AS Date), 13)
INSERT [dbo].[dotthi] ([id], [idkhoa], [ngaythi], [giothi]) VALUES (10, 2, CAST(N'2019-05-17' AS Date), 13)
SET IDENTITY_INSERT [dbo].[dotthi] OFF
SET IDENTITY_INSERT [dbo].[giaovien] ON 

INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (17, N'Đặng Tùng', CAST(N'1986-02-11' AS Date), N'Dạy IELTS', N'0232 435 465', N'Hà Nội')
INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (18, N'David Mars', CAST(N'1999-12-07' AS Date), N'Dạy TOEIC', N'0232 435 465', N'Hawaii')
INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (19, N'Khánh Linh', CAST(N'1999-12-07' AS Date), N'Dạy TOEFL', N'0232 435 465', N'Hải Phòng')
INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (21, N'Adam Levin', CAST(N'1999-12-07' AS Date), N'Dạy B1', N'0662 435 465', N'US')
INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (22, N'Phương Hoa', CAST(N'1999-12-07' AS Date), N'Dạy B2', N'1232 435 465', N'Hồ Chí Minh')
INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (23, N'Đặng Mai', CAST(N'1986-02-11' AS Date), N'Dạy IELTS', N'0232 435 465', N'Hà Nội')
INSERT [dbo].[giaovien] ([id], [hoten], [ngaysinh], [phanloai], [sodienthoai], [diachi]) VALUES (24, N'Simson Vu', CAST(N'1986-02-11' AS Date), N'Dạy Cambridge', N'0232 435 465', N'Hà Nội 2')
SET IDENTITY_INSERT [dbo].[giaovien] OFF
SET IDENTITY_INSERT [dbo].[hocvien] ON 

INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (7, N'Dư Đình Dương', N'Nam', CAST(N'1999-12-15' AS Date), N'Kiến An', N'0231 231 231', 0)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (8, N'Phạm Quang Cường', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0231 231 123', 500000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (10, N'Lê Phương Hoa', N'Nữ', CAST(N'1999-12-15' AS Date), N'Đồng Bún', N'0233 342 354', 5500000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (11, N'Nguyễn Khánh Linh', N'Nữ', CAST(N'1999-12-15' AS Date), N'Thủy Nguyên', N'0031 231 123', 5000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (12, N'Phan Xuân Nam', N'Nam', CAST(N'1999-12-15' AS Date), N'Hà Nội', N'0931 231 123', 6500000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (13, N'Phạm Minh Hiếu', N'Nam', CAST(N'1999-12-15' AS Date), N'Kiến An', N'0831 231 123', 6500000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (14, N'Phan Xuân Sơn', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0931 231 123', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (15, N'Phạm Quang Ninh', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0231 231 123', 0)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (16, N'Nguyễn Khánh Vi', N'Nữ', CAST(N'1999-12-15' AS Date), N'Thủy Nguyên', N'0031 231 123', 0)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (17, N'Phan Xuân Hinh', N'Nữ', CAST(N'1999-12-15' AS Date), N'Thanh Hóa', N'0931 231 123', 0)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (18, N'Nguyễn Khánh Hà', N'Nữ', CAST(N'1999-12-15' AS Date), N'Thủy Nguyên', N'0031 231 123', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (19, N'Nguyễn Khánh Minh', N'Nữ', CAST(N'1999-12-15' AS Date), N'Thủy Nguyên', N'0031 231 123', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (20, N'Dư Đình Dương 1', N'Nam', CAST(N'1998-01-01' AS Date), N'Kiến An', N'0231 231 231', 2000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (21, N'Dư Đình Dương 2', N'Nam', CAST(N'1998-01-01' AS Date), N'Kiến An', N'0231 231 231', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (22, N'Dư Đình Dương 3', N'Nam', CAST(N'1998-01-01' AS Date), N'Kiến An', N'0231 231 231', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (23, N'Dư Đình Dương 4', N'Nam', CAST(N'1998-01-01' AS Date), N'Kiến An', N'0231 231 231', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (24, N'Phạm Quang Cường 1', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0231 231 123', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (25, N'Phạm Quang Cường 2', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0231 231 123', 3000000)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (26, N'Phạm Quang Cường 3', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0231 231 123', 0)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (27, N'Phạm Quang Cường 4', N'Nam', CAST(N'1999-12-15' AS Date), N'Hải Phòng', N'0231 231 123', 0)
INSERT [dbo].[hocvien] ([id], [hoten], [gioitinh], [ngaysinh], [diachi], [sodienthoai], [conno]) VALUES (28, N'Lê Phương Hoa 1', N'Nữ', CAST(N'1999-12-15' AS Date), N'Đồng Bún', N'0233 342 354', 0)
SET IDENTITY_INSERT [dbo].[hocvien] OFF
SET IDENTITY_INSERT [dbo].[khoa] ON 

INSERT [dbo].[khoa] ([id], [ten], [hocphi], [ngaybatdau], [ngayketthuc]) VALUES (2, N'IELTS', 6500000, CAST(N'2019-05-01' AS Date), CAST(N'2019-05-10' AS Date))
INSERT [dbo].[khoa] ([id], [ten], [hocphi], [ngaybatdau], [ngayketthuc]) VALUES (3, N'TOEIC', 3000000, CAST(N'2019-05-01' AS Date), CAST(N'2020-05-10' AS Date))
INSERT [dbo].[khoa] ([id], [ten], [hocphi], [ngaybatdau], [ngayketthuc]) VALUES (4, N'B1', 4500000, CAST(N'2019-01-01' AS Date), CAST(N'2019-05-10' AS Date))
INSERT [dbo].[khoa] ([id], [ten], [hocphi], [ngaybatdau], [ngayketthuc]) VALUES (5, N'B2', 4000000, CAST(N'2019-05-01' AS Date), CAST(N'2019-05-10' AS Date))
INSERT [dbo].[khoa] ([id], [ten], [hocphi], [ngaybatdau], [ngayketthuc]) VALUES (6, N'TOEFL', 5000000, CAST(N'2019-05-01' AS Date), CAST(N'2019-05-10' AS Date))
INSERT [dbo].[khoa] ([id], [ten], [hocphi], [ngaybatdau], [ngayketthuc]) VALUES (11, N'Cambridge', 10500000, CAST(N'2019-05-01' AS Date), CAST(N'2019-10-10' AS Date))
SET IDENTITY_INSERT [dbo].[khoa] OFF
SET IDENTITY_INSERT [dbo].[lich] ON 

INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (1, N'Thứ 2', 1)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (2, N'Thứ 2', 2)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (3, N'Thứ 2', 3)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (4, N'Thứ 2', 4)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (5, N'Thứ 4', 1)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (6, N'Thứ 4', 2)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (7, N'Thứ 4', 3)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (8, N'Thứ 4', 4)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (9, N'Thứ 6', 1)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (10, N'Thứ 6', 2)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (11, N'Thứ 6', 3)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (12, N'Thứ 6', 4)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (13, N'Chủ nhật', 1)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (14, N'Chủ nhật', 2)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (15, N'Chủ nhật', 3)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (17, N'Chủ nhật', 4)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (18, N'Thứ 7', 1)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (19, N'Thứ 7', 2)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (20, N'Thứ 7', 3)
INSERT [dbo].[lich] ([id], [thu], [ca]) VALUES (21, N'Thứ 7', 4)
SET IDENTITY_INSERT [dbo].[lich] OFF
INSERT [dbo].[loaidiem] ([ten], [thangdiem]) VALUES (N'Đọc', 10)
INSERT [dbo].[loaidiem] ([ten], [thangdiem]) VALUES (N'Nghe', 10)
INSERT [dbo].[loaidiem] ([ten], [thangdiem]) VALUES (N'Nói', 10)
INSERT [dbo].[loaidiem] ([ten], [thangdiem]) VALUES (N'Viết', 10)
SET IDENTITY_INSERT [dbo].[lophoc] ON 

INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (1, N'IELTS Listening', N'315  ', 1, 2, 21)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (2, N'TOEIC Listening', N'415  ', 5, 3, 21)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (3, N'B1 Class', N'210  ', 11, 4, 21)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (4, N'B2 Class', N'123  ', 14, 5, 22)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (6, N'TOEFL', N'901  ', 6, 6, 19)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (7, N'Cambridge Class', N'315  ', 14, 11, 24)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (8, N'IELTS Writting', N'315  ', 3, 2, 17)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (9, N'IELTS Reading', N'315  ', 2, 2, 17)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (10, N'IELTS Speaking', N'315  ', 4, 2, 23)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (11, N'TOEIC Writting', N'415  ', 6, 3, 18)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (12, N'TOEIC Reading', N'415  ', 7, 3, 18)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (13, N'TOEIC Speaking', N'415  ', 8, 3, 18)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (14, N'IELTS Listening', N'316', 1, 2, 21)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (15, N'Lop trung bay', N'312', 5, 2, 21)
INSERT [dbo].[lophoc] ([id], [ten], [phong], [idlich], [idkhoa], [idgiaovien]) VALUES (16, N'lop lam canh', N'313  ', 2, 2, 21)
SET IDENTITY_INSERT [dbo].[lophoc] OFF
INSERT [dbo].[taikhoan] ([tendangnhap], [matkhau], [hoten], [gioitinh], [quyen]) VALUES (N'admin', N'1', N'Admin', N'Nam', N'Admin')
INSERT [dbo].[taikhoan] ([tendangnhap], [matkhau], [hoten], [gioitinh], [quyen]) VALUES (N'admin1', N'1', N'Admin1', N'Nam', N'Admin')
INSERT [dbo].[taikhoan] ([tendangnhap], [matkhau], [hoten], [gioitinh], [quyen]) VALUES (N'admin3', N'1', N'Admin3', N'Nữ', N'Admin')
INSERT [dbo].[taikhoan] ([tendangnhap], [matkhau], [hoten], [gioitinh], [quyen]) VALUES (N'cuong', N'1', N'Phạm Cường', N'Nam', N'Nhân viên')
INSERT [dbo].[taikhoan] ([tendangnhap], [matkhau], [hoten], [gioitinh], [quyen]) VALUES (N'duong', N'1', N'Dương Đình', N'Nam', N'Nhân viên')
INSERT [dbo].[test] ([a], [b]) VALUES (2, 3)
INSERT [dbo].[test] ([a], [b]) VALUES (3, 5)
SET IDENTITY_INSERT [dbo].[thanhtoan] ON 

INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (10, 7, CAST(N'2019-05-10' AS Date), 6000000)
INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (11, 7, CAST(N'2019-05-10' AS Date), 500000)
INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (12, 8, CAST(N'2019-05-10' AS Date), 1000000)
INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (13, 8, CAST(N'2019-05-10' AS Date), 1000000)
INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (14, 10, CAST(N'2019-05-10' AS Date), 1000000)
INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (15, 20, CAST(N'2019-05-11' AS Date), 1000000)
INSERT [dbo].[thanhtoan] ([id], [idhocvien], [ngaythanhtoan], [tienthanhtoan]) VALUES (16, 8, CAST(N'2019-05-14' AS Date), 500000)
SET IDENTITY_INSERT [dbo].[thanhtoan] OFF
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (7, 1, CAST(N'2019-05-08' AS Date), 2.625, N'Trung bình', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (8, 2, CAST(N'2019-05-08' AS Date), 2.8333333333333304, N'Trung bình', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (10, 1, CAST(N'2019-05-08' AS Date), 2, N'Trung bình', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (11, 6, CAST(N'2019-05-08' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (12, 1, CAST(N'2019-05-10' AS Date), 10, N'Xuất sắc', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (13, 1, CAST(N'2019-05-10' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (14, 2, CAST(N'2019-05-10' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (18, 2, CAST(N'2019-05-11' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (19, 2, CAST(N'2019-05-11' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (20, 2, CAST(N'2019-05-11' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (21, 2, CAST(N'2019-05-14' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (22, 2, CAST(N'2019-05-14' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (23, 2, CAST(N'2019-05-14' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (24, 2, CAST(N'2019-05-14' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (25, 2, CAST(N'2019-05-14' AS Date), 0, N'Chưa xếp loại', N'')
INSERT [dbo].[tinhtranghoctap] ([idhocvien], [idlop], [thoigiandangky], [diemtongket], [xeploai], [ghichu]) VALUES (28, 1, CAST(N'2019-05-14' AS Date), 0, N'Chưa xếp loại', N'')
ALTER TABLE [dbo].[diemthi] ADD  DEFAULT ((0)) FOR [Nghe]
GO
ALTER TABLE [dbo].[diemthi] ADD  DEFAULT ((0)) FOR [Nói]
GO
ALTER TABLE [dbo].[diemthi] ADD  DEFAULT ((0)) FOR [Đọc]
GO
ALTER TABLE [dbo].[diemthi] ADD  DEFAULT ((0)) FOR [Viết]
GO
ALTER TABLE [dbo].[dotthi] ADD  DEFAULT (getdate()) FOR [ngaythi]
GO
ALTER TABLE [dbo].[dotthi] ADD  DEFAULT ((8)) FOR [giothi]
GO
ALTER TABLE [dbo].[giaovien] ADD  DEFAULT (N'Chưa có tên') FOR [hoten]
GO
ALTER TABLE [dbo].[giaovien] ADD  DEFAULT ('01/01/1990') FOR [ngaysinh]
GO
ALTER TABLE [dbo].[giaovien] ADD  DEFAULT (N'Cơ hữu') FOR [phanloai]
GO
ALTER TABLE [dbo].[giaovien] ADD  DEFAULT ('') FOR [sodienthoai]
GO
ALTER TABLE [dbo].[giaovien] ADD  DEFAULT (N'') FOR [diachi]
GO
ALTER TABLE [dbo].[hocvien] ADD  DEFAULT (N'Chưa có tên') FOR [hoten]
GO
ALTER TABLE [dbo].[hocvien] ADD  DEFAULT (N'Nam') FOR [gioitinh]
GO
ALTER TABLE [dbo].[hocvien] ADD  DEFAULT ('01/01/1990') FOR [ngaysinh]
GO
ALTER TABLE [dbo].[hocvien] ADD  DEFAULT (N'') FOR [diachi]
GO
ALTER TABLE [dbo].[hocvien] ADD  DEFAULT ('') FOR [sodienthoai]
GO
ALTER TABLE [dbo].[hocvien] ADD  DEFAULT ((0)) FOR [conno]
GO
ALTER TABLE [dbo].[khoa] ADD  DEFAULT (N'Chưa có tên') FOR [ten]
GO
ALTER TABLE [dbo].[khoa] ADD  DEFAULT ((0)) FOR [hocphi]
GO
ALTER TABLE [dbo].[khoa] ADD  DEFAULT (getdate()) FOR [ngaybatdau]
GO
ALTER TABLE [dbo].[lich] ADD  DEFAULT (N'Thứ 2, 4, 6') FOR [thu]
GO
ALTER TABLE [dbo].[lich] ADD  DEFAULT ((1)) FOR [ca]
GO
ALTER TABLE [dbo].[lophoc] ADD  DEFAULT (N'Chưa có tên') FOR [ten]
GO
ALTER TABLE [dbo].[taikhoan] ADD  DEFAULT ((1)) FOR [matkhau]
GO
ALTER TABLE [dbo].[taikhoan] ADD  DEFAULT (N'Chưa đặt tên') FOR [hoten]
GO
ALTER TABLE [dbo].[taikhoan] ADD  DEFAULT (N'Nam') FOR [gioitinh]
GO
ALTER TABLE [dbo].[taikhoan] ADD  DEFAULT (N'Nhân viên') FOR [quyen]
GO
ALTER TABLE [dbo].[thanhtoan] ADD  DEFAULT (getdate()) FOR [ngaythanhtoan]
GO
ALTER TABLE [dbo].[thanhtoan] ADD  DEFAULT ((0)) FOR [tienthanhtoan]
GO
ALTER TABLE [dbo].[tinhtranghoctap] ADD  DEFAULT (getdate()) FOR [thoigiandangky]
GO
ALTER TABLE [dbo].[tinhtranghoctap] ADD  DEFAULT ((0)) FOR [diemtongket]
GO
ALTER TABLE [dbo].[tinhtranghoctap] ADD  DEFAULT (N'Chưa xếp loại') FOR [xeploai]
GO
ALTER TABLE [dbo].[tinhtranghoctap] ADD  DEFAULT (N'') FOR [ghichu]
GO
ALTER TABLE [dbo].[cauhinhdiem]  WITH CHECK ADD  CONSTRAINT [fk_cauhinhdiem_lop] FOREIGN KEY([idlop])
REFERENCES [dbo].[lophoc] ([id])
GO
ALTER TABLE [dbo].[cauhinhdiem] CHECK CONSTRAINT [fk_cauhinhdiem_lop]
GO
ALTER TABLE [dbo].[diemthi]  WITH CHECK ADD  CONSTRAINT [diem_dotthi] FOREIGN KEY([iddotthi])
REFERENCES [dbo].[dotthi] ([id])
GO
ALTER TABLE [dbo].[diemthi] CHECK CONSTRAINT [diem_dotthi]
GO
ALTER TABLE [dbo].[diemthi]  WITH CHECK ADD  CONSTRAINT [diem_hocvien] FOREIGN KEY([idhocvien])
REFERENCES [dbo].[hocvien] ([id])
GO
ALTER TABLE [dbo].[diemthi] CHECK CONSTRAINT [diem_hocvien]
GO
ALTER TABLE [dbo].[diemthi]  WITH CHECK ADD  CONSTRAINT [diem_lophoc] FOREIGN KEY([idlop])
REFERENCES [dbo].[lophoc] ([id])
GO
ALTER TABLE [dbo].[diemthi] CHECK CONSTRAINT [diem_lophoc]
GO
ALTER TABLE [dbo].[dotthi]  WITH CHECK ADD  CONSTRAINT [dotthi_khoa] FOREIGN KEY([idkhoa])
REFERENCES [dbo].[khoa] ([id])
GO
ALTER TABLE [dbo].[dotthi] CHECK CONSTRAINT [dotthi_khoa]
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD  CONSTRAINT [lophoc_giaovien] FOREIGN KEY([idgiaovien])
REFERENCES [dbo].[giaovien] ([id])
GO
ALTER TABLE [dbo].[lophoc] CHECK CONSTRAINT [lophoc_giaovien]
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD  CONSTRAINT [lophoc_khoa] FOREIGN KEY([idkhoa])
REFERENCES [dbo].[khoa] ([id])
GO
ALTER TABLE [dbo].[lophoc] CHECK CONSTRAINT [lophoc_khoa]
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD  CONSTRAINT [lophoc_lich] FOREIGN KEY([idlich])
REFERENCES [dbo].[lich] ([id])
GO
ALTER TABLE [dbo].[lophoc] CHECK CONSTRAINT [lophoc_lich]
GO
ALTER TABLE [dbo].[thanhtoan]  WITH CHECK ADD  CONSTRAINT [thanhtoan_hocvien] FOREIGN KEY([idhocvien])
REFERENCES [dbo].[hocvien] ([id])
GO
ALTER TABLE [dbo].[thanhtoan] CHECK CONSTRAINT [thanhtoan_hocvien]
GO
ALTER TABLE [dbo].[tinhtranghoctap]  WITH CHECK ADD  CONSTRAINT [dangkyhoc_hocvien] FOREIGN KEY([idhocvien])
REFERENCES [dbo].[hocvien] ([id])
GO
ALTER TABLE [dbo].[tinhtranghoctap] CHECK CONSTRAINT [dangkyhoc_hocvien]
GO
ALTER TABLE [dbo].[tinhtranghoctap]  WITH CHECK ADD  CONSTRAINT [dangkyhoc_lop] FOREIGN KEY([idlop])
REFERENCES [dbo].[lophoc] ([id])
GO
ALTER TABLE [dbo].[tinhtranghoctap] CHECK CONSTRAINT [dangkyhoc_lop]
GO
/****** Object:  StoredProcedure [dbo].[NhacNhoDongTien]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NhacNhoDongTien]
@gioihan1 int, @gioihan2 int

as
begin
	select hocvien.id, hocvien.hoten,tinhtranghoctap.thoigiandangky, hocvien.ngaysinh, hocvien.diachi, hocvien.sodienthoai, hocvien.conno, 
	DATEDIFF(DAY, tinhtranghoctap.thoigiandangky, GETDATE()) AS songaydahoc, 
	nhacnhodongtien = CASE

	when DATEDIFF(DAY, tinhtranghoctap.thoigiandangky, GETDATE()) < 31 then N'Lần 1'
	when DATEDIFF(DAY, tinhtranghoctap.thoigiandangky, GETDATE()) > 31
	and DATEDIFF(DAY, tinhtranghoctap.thoigiandangky, GETDATE()) < 62 then N'Lần 2'
	else N'Lần 3'
	end

	from hocvien inner join tinhtranghoctap
	on hocvien.id = tinhtranghoctap.idhocvien
	where conno <> 0 
	and @gioihan1 < DATEDIFF(DAY, tinhtranghoctap.thoigiandangky, GETDATE())
	and DATEDIFF(DAY, tinhtranghoctap.thoigiandangky, GETDATE()) < @gioihan2
end
GO
/****** Object:  StoredProcedure [dbo].[SoLuongHocVienTrongLop]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SoLuongHocVienTrongLop]
@idlop int
as
begin
	select count(tinhtranghoctap.idhocvien) as soluonghocvien
	from tinhtranghoctap
	where idlop = @idlop
	group by idlop
end
GO
/****** Object:  StoredProcedure [dbo].[thongkediem]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongkediem] @idlop int ,@iddotthi int
as begin
	select hocvien.id,hoten,lophoc.ten, diemnghe,diemnoi,diemdoc,diemviet from diemthi inner join hocvien on diemthi.idhocvien=hocvien.id inner join lophoc on lophoc.id=diemthi.idlop
	where idlop like (N'%'+cast(@idlop as nvarchar)+'%') and  iddotthi like(N'%'+cast(@iddotthi as nvarchar)+'%')
	order by hoten
end
GO
/****** Object:  StoredProcedure [dbo].[thongkehocphi]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongkehocphi]
@idlop int
as
begin
	select id,hoten,ngaysinh,sodienthoai,conno as sotienconno from hocvien	where conno<>0 order by hoten
end
GO
/****** Object:  StoredProcedure [dbo].[thongkesinhvien]    Script Date: 18/05/2019 9:38:21 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongkesinhvien] @idlop int
as begin
	select hocvien.id,hocvien.hoten,hocvien.ngaysinh,hocvien.diachi,hocvien.sodienthoai,tinhtranghoctap.thoigiandangky, diemtongket,xeploai from hocvien inner join tinhtranghoctap on hocvien.id=tinhtranghoctap.idhocvien where idlop=@idlop order by hoten
end
GO
USE [master]
GO
ALTER DATABASE [BTL_N04] SET  READ_WRITE 
GO
