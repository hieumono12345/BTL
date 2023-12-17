USE [QuanlyDaiDoi3]
GO
/****** Object:  UserDefinedFunction [dbo].[tongqn]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[tongqn]()
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(MaQN)
    FROM dbo.QuanNhan;
    RETURN @Count;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[tongqnnam]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[tongqnnam]()
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(qn.MaQN)
    FROM dbo.QuanNhan qn WHERE qn.GioiTinh=1
    RETURN @Count;
END;
GO
/****** Object:  UserDefinedFunction [dbo].[tongqnnu]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[tongqnnu]()
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(qn.MaQN)
    FROM dbo.QuanNhan qn WHERE qn.GioiTinh=0
    RETURN @Count;
END;
GO
/****** Object:  Table [dbo].[ChiTietDanhSachCongViec]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDanhSachCongViec](
	[MaCTDSCV] [int] IDENTITY(1,1) NOT NULL,
	[MaDS] [int] NULL,
	[MaQN] [int] NULL,
	[MaCongViec] [int] NULL,
 CONSTRAINT [PK_ChiTietDanhSachCongViec] PRIMARY KEY CLUSTERED 
(
	[MaCTDSCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDanhSachGac]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDanhSachGac](
	[MaCTDSG] [int] IDENTITY(1,1) NOT NULL,
	[MaDS] [int] NULL,
	[MaTG] [int] NULL,
	[MaQN] [int] NULL,
	[MaGac] [int] NULL,
 CONSTRAINT [PK_ChiTietDanhSachGac] PRIMARY KEY CLUSTERED 
(
	[MaCTDSG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucvu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSach]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSach](
	[MaDS] [int] IDENTITY(1,1) NOT NULL,
	[TenDS] [nvarchar](50) NULL,
 CONSTRAINT [PK_DanhSach] PRIMARY KEY CLUSTERED 
(
	[MaDS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonVi](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [varchar](50) NULL,
 CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nganh]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganh](
	[MaNganh] [int] IDENTITY(1,1) NOT NULL,
	[TenNganh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoiDungCongViec]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiDungCongViec](
	[MaCongViec] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](100) NULL,
	[DiaDiem] [nvarchar](100) NULL,
	[Ngay] [date] NULL,
	[SoLuong] [int] NULL,
	[STTDS] [bit] NULL,
	[MaTT] [int] NULL,
	[GhiChu] [nvarchar](300) NULL,
	[TGBD] [time](7) NULL,
	[TGKT] [time](7) NULL,
	[MaTC] [int] NULL,
	[MaDV] [int] NULL,
 CONSTRAINT [PK_NoiDungCongViec] PRIMARY KEY CLUSTERED 
(
	[MaCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoiDungGac]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiDungGac](
	[MaGac] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [date] NULL,
	[Hoi] [nvarchar](50) NULL,
	[Dap] [nvarchar](50) NULL,
	[NhacNho] [nvarchar](300) NULL,
	[MaDV] [int] NULL,
 CONSTRAINT [PK_NoiDungGac] PRIMARY KEY CLUSTERED 
(
	[MaGac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanNhan]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanNhan](
	[MaQN] [int] IDENTITY(1,1) NOT NULL,
	[TenQN] [nvarchar](50) NULL,
	[MaNganh] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaDV] [int] NULL,
	[SDT] [varchar](50) NULL,
	[GioiTinh] [int] NULL,
 CONSTRAINT [PK_QuanNhan] PRIMARY KEY CLUSTERED 
(
	[MaQN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[MaQN] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiGianGac]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiGianGac](
	[MaTG] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [varchar](50) NULL,
 CONSTRAINT [PK_ThoiGianGac] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhChatCongViec]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhChatCongViec](
	[MaTC] [int] IDENTITY(1,1) NOT NULL,
	[DacTaTC] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](300) NULL,
 CONSTRAINT [PK_TinhChatCongViec] PRIMARY KEY CLUSTERED 
(
	[MaTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TK_Quyen]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TK_Quyen](
	[MaTK] [int] NULL,
	[MaQuyen] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiCongViec]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiCongViec](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrangThaiCongViec] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UuTien]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UuTien](
	[MaUuTien] [int] IDENTITY(1,1) NOT NULL,
	[MaQN] [int] NULL,
	[NoiDungUuTien] [nvarchar](50) NULL,
 CONSTRAINT [PK_QN_UuTien] PRIMARY KEY CLUSTERED 
(
	[MaUuTien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietDanhSachGac] ON 

INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (1, 1, 1, 20, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (2, 1, 1, 87, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (3, 1, 1, 15, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (4, 1, 1, 54, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (5, 1, 2, 69, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (6, 1, 2, 18, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (7, 1, 2, 51, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (8, 1, 2, 84, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (9, 1, 3, 48, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (10, 1, 3, 59, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (11, 1, 3, 62, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (12, 1, 3, 47, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (13, 1, 5, 81, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (14, 1, 5, 61, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (15, 1, 5, 36, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (16, 1, 5, 89, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (17, 1, 5, 9, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (18, 1, 6, 37, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (19, 1, 6, 40, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (20, 1, 6, 56, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (21, 1, 6, 11, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (22, 1, 6, 41, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (23, 1, 7, 3, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (24, 1, 7, 12, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (25, 1, 7, 63, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (26, 1, 7, 44, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (27, 1, 7, 5, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (28, 1, 8, 72, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (29, 1, 8, 66, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (30, 1, 8, 78, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (31, 1, 8, 35, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (32, 1, 8, 21, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (33, 1, 9, 7, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (34, 1, 9, 23, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (35, 1, 9, 52, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (36, 1, 9, 88, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (37, 1, 9, 30, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (38, 1, 10, 33, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (39, 1, 10, 46, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (40, 1, 10, 45, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (41, 1, 10, 57, 1)
INSERT [dbo].[ChiTietDanhSachGac] ([MaCTDSG], [MaDS], [MaTG], [MaQN], [MaGac]) VALUES (42, 1, 10, 86, 1)
SET IDENTITY_INSERT [dbo].[ChiTietDanhSachGac] OFF
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (1, N'Đại đội trưởng')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (2, N'Lớp trưởng')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (3, N'Học viên')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (4, N'Chính trị viên đại đội')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (5, N'Phó đại đội trưởng')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (6, N'Chính trị viên phó đại đội')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (7, N'Lớp phó')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (8, N'Tiểu đoàn trưởng')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (9, N'Phó tiểu đoàn trưởng')
INSERT [dbo].[ChucVu] ([MaChucvu], [TenChucVu]) VALUES (10, N'Chính trị viên tiểu đoàn')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhSach] ON 

INSERT [dbo].[DanhSach] ([MaDS], [TenDS]) VALUES (1, N'Danh Sách Gác')
INSERT [dbo].[DanhSach] ([MaDS], [TenDS]) VALUES (2, N'Danh Sách Cắt Cử Công Việc')
SET IDENTITY_INSERT [dbo].[DanhSach] OFF
GO
SET IDENTITY_INSERT [dbo].[DonVi] ON 

INSERT [dbo].[DonVi] ([MaDV], [TenDV]) VALUES (1, N'C155')
INSERT [dbo].[DonVi] ([MaDV], [TenDV]) VALUES (2, N'C156')
INSERT [dbo].[DonVi] ([MaDV], [TenDV]) VALUES (3, N'C157')
INSERT [dbo].[DonVi] ([MaDV], [TenDV]) VALUES (4, N'C158')
INSERT [dbo].[DonVi] ([MaDV], [TenDV]) VALUES (5, N'C159')
SET IDENTITY_INSERT [dbo].[DonVi] OFF
GO
SET IDENTITY_INSERT [dbo].[Nganh] ON 

INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (1, N'CNTT')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (2, N'BDATTT')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (3, N'ANHTTT')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (4, N'PTDL')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (5, N'KTPM')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (6, N'HTTT')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (7, N'MMT')
INSERT [dbo].[Nganh] ([MaNganh], [TenNganh]) VALUES (8, N'Chỉ huy')
SET IDENTITY_INSERT [dbo].[Nganh] OFF
GO
SET IDENTITY_INSERT [dbo].[NoiDungGac] ON 

INSERT [dbo].[NoiDungGac] ([MaGac], [Ngay], [Hoi], [Dap], [NhacNho], [MaDV]) VALUES (1, CAST(N'2023-12-16' AS Date), N'Hưng Yên ', N'Hà Nội ', N'Mùa Đông Lạnh Nhớ Mặc Áo Ấm', 2)
SET IDENTITY_INSERT [dbo].[NoiDungGac] OFF
GO
SET IDENTITY_INSERT [dbo].[QuanNhan] ON 

INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (2, N'Nguyễn Hữu Đức An
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (3, N'Nguyễn Đức Cường
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (4, N'Phạm Ngọc Anh Dũng
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (5, N'Bùi Minh Đức
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (6, N'Nguyễn Lê Trung Hiếu
', 1, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (7, N'Trần Thị Ngọc Khánh
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (8, N'Bùi Quốc Khánh
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (9, N'Nguyễn Hoàng Nam
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (10, N'Nguyễn Khôi Nguyên
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (11, N'Nguyễn Thị Hà Phương
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (12, N'Nguyễn Tấn Quý
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (13, N'Trịnh Viết Tài
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (14, N'Nghiêm Văn Tiến
', 1, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (15, N'Mai Thị Hạnh Trang
', 1, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (16, N'Phạm Thanh Tùng
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (17, N'Nguyễn Thị Hải Vân
', 1, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (18, N'Lê Thị Mỹ Duyên
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (19, N'Trần Minh Đức
', 2, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (20, N'Nguyễn Thị Phượng Hằng
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (21, N'Lê Hữu Hiển
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (22, N'Nguyễn Gia Hiếu
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (23, N'Nguyễn Đức Hiếu
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (24, N'Nguyễn Ngọc Hiếu
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (25, N'Hà Huy Hoàng
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (26, N'Hà Thùy Linh
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (27, N'Dương Quang Minh 
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (28, N'Phạm Đức Minh
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (29, N'Nguyễn Anh Nam
', 2, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (30, N'Dương Thành Nam
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (31, N'Nguyễn Văn Nghĩa
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (32, N'Lê Thị Nhi
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (33, N'Nguyễn Quang Phong 
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (34, N'Bùi Bích Phương 
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (35, N'Nguyễn Duy Phương
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (36, N'Đỗ Nguyên Phương
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (37, N'Quách Việt Tùng
', 2, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (38, N'Sùng Thị Út
', 2, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (39, N'Trần Quốc Bảo
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (40, N'Nguyễn Minh Dương
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (41, N'Nguyễn Phúc Đẳng
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (42, N'Nguyễn Minh Đức
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (43, N'Nguyễn Minh Hiếu
', 3, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (44, N'Nguyễn Sỹ Huy Hoàng
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (45, N'Trần Quốc Huy
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (46, N'Nguyễn Văn Hưng
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (47, N'Nguyễn Thị Thu Huyền
', 3, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (48, N'Vũ Lê Huyền
', 3, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (49, N'Trang Đăng Khoa
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (50, N'Dương Đình Nhật Linh
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (51, N'Hoàng Mỹ Linh
', 3, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (52, N'Lê Đức Mạnh
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (53, N'Nguyễn Đức Minh
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (54, N'Lý Bích Ngọc
', 3, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (55, N'Hà Đức Ngọc
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (56, N'Phạm Công Nguyên
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (57, N'Nguyễn Thiện Nhân
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (58, N'Đinh Đoàn Xuân Phương
', 3, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (59, N'Nguyễn Thu Phương
', 3, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (60, N'Đoàn Mạnh Tân
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (61, N'Phạm Ng. Tất Thắng
', 3, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (62, N'Đào Thị Kim Yến
', 3, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (63, N'Bùi Ngọc An
', 4, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (64, N'Đỗ Phan Nhật Anh
', 4, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (65, N'Chu Mạnh Hùng
', 4, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (66, N'Nguyễn Bá Nam
', 4, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (67, N'Hoàng Trung Nguyên
', 4, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (68, N'Hà Thị Ngọc Phương
', 4, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (69, N'Phan Thị Hồng Thắm
', 4, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (70, N'Vũ Duy Anh
', 5, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (71, N'Nguyễn Thảo Anh
', 5, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (72, N'Vũ Văn Biển
', 5, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (73, N'Nguyễn Quang Cường
', 5, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (74, N'Trần Nhật Hiếu
', 5, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (75, N'Trần Thị Thanh Thoại
', 5, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (76, N'Ngô Anh Vũ
', 5, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (77, N'Nguyễn Thế Anh
', 6, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (78, N'Nguyễn Thanh Hiếu
', 6, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (79, N'Võ Quốc Huy
', 6, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (80, N'Phan Đinh Minh Ngọc
', 6, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (81, N'Tạ Văn Nhật
', 6, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (82, N'Nguyễn Hồng Quân
', 6, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (83, N'Nguyễn Thúy Quỳnh
', 6, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (84, N'Nguyễn Đặng Diệp Anh
', 7, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (85, N'Trần Quốc Dũng
', 7, 7, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (86, N'Nguyễn Mạnh Dũng
', 7, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (87, N'Đàm Thị Thu Mai
', 7, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (88, N'Nguyễn Bảo Ngọc
', 7, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (89, N'Đỗ Đức Phúc
', 7, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (90, N'Đặng Hoàng Việt
', 7, 2, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (91, N'Bùi Xuân Long', 8, 1, 2, N'0984733625', 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (92, N'Lê Phi Hùng', 8, 5, 2, N'09484722633', 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (93, N'Phùng Quang Toàn', 8, 4, 2, N'098744323', 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (94, N'Nguyễn Trường Giang', 8, 5, 2, N'09857336254', 1)
SET IDENTITY_INSERT [dbo].[QuanNhan] OFF
GO
SET IDENTITY_INSERT [dbo].[Quyen] ON 

INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (1, N'admin')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (2, N'daidoi')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (3, N'tieudoan')
SET IDENTITY_INSERT [dbo].[Quyen] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [MaQN]) VALUES (1, N'Long156', N'123', 91)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[ThoiGianGac] ON 

INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (1, N'18h30-20h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (2, N'20h-21h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (3, N'21h-22h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (4, N'22h-23h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (5, N'23h-0h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (6, N'0h-1h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (7, N'1h-2h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (8, N'2h-3h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (9, N'3h-4h')
INSERT [dbo].[ThoiGianGac] ([MaTG], [ThoiGian]) VALUES (10, N'4h-5h30')
SET IDENTITY_INSERT [dbo].[ThoiGianGac] OFF
GO
SET IDENTITY_INSERT [dbo].[TinhChatCongViec] ON 

INSERT [dbo].[TinhChatCongViec] ([MaTC], [DacTaTC], [GhiChu]) VALUES (1, N'Cắt Chỉ Nam', N'Công Việc Nặng Chỉ Có Quân Nhân Nam Mới Làm Được')
INSERT [dbo].[TinhChatCongViec] ([MaTC], [DacTaTC], [GhiChu]) VALUES (2, N'Cắt Cả Nam Và Nữ', N'Công Việc Bình Thường Hàng Ngày Cả Nam Và Nữ Đều Đi Làm Được')
INSERT [dbo].[TinhChatCongViec] ([MaTC], [DacTaTC], [GhiChu]) VALUES (3, N'Cắt Chỉ Nữ', N'Công Việc Đặc Biệt Chỉ Có Quân Nhân Nữ Đi Làm Được')
SET IDENTITY_INSERT [dbo].[TinhChatCongViec] OFF
GO
INSERT [dbo].[TK_Quyen] ([MaTK], [MaQuyen]) VALUES (1, 2)
GO
SET IDENTITY_INSERT [dbo].[TrangThaiCongViec] ON 

INSERT [dbo].[TrangThaiCongViec] ([MaTT], [TrangThai]) VALUES (1, N'Chưa Thực Hiện')
INSERT [dbo].[TrangThaiCongViec] ([MaTT], [TrangThai]) VALUES (2, N'Đang Thực Hiện')
INSERT [dbo].[TrangThaiCongViec] ([MaTT], [TrangThai]) VALUES (3, N'Hoàn Thành')
SET IDENTITY_INSERT [dbo].[TrangThaiCongViec] OFF
GO
ALTER TABLE [dbo].[ChiTietDanhSachCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachCongViec_DanhSach] FOREIGN KEY([MaDS])
REFERENCES [dbo].[DanhSach] ([MaDS])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachCongViec] CHECK CONSTRAINT [FK_ChiTietDanhSachCongViec_DanhSach]
GO
ALTER TABLE [dbo].[ChiTietDanhSachCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachCongViec_NoiDungCongViec] FOREIGN KEY([MaCongViec])
REFERENCES [dbo].[NoiDungCongViec] ([MaCongViec])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachCongViec] CHECK CONSTRAINT [FK_ChiTietDanhSachCongViec_NoiDungCongViec]
GO
ALTER TABLE [dbo].[ChiTietDanhSachCongViec]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachCongViec_QuanNhan] FOREIGN KEY([MaQN])
REFERENCES [dbo].[QuanNhan] ([MaQN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachCongViec] CHECK CONSTRAINT [FK_ChiTietDanhSachCongViec_QuanNhan]
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachGac_DanhSach] FOREIGN KEY([MaDS])
REFERENCES [dbo].[DanhSach] ([MaDS])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac] CHECK CONSTRAINT [FK_ChiTietDanhSachGac_DanhSach]
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachGac_NoiDungGac] FOREIGN KEY([MaGac])
REFERENCES [dbo].[NoiDungGac] ([MaGac])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac] CHECK CONSTRAINT [FK_ChiTietDanhSachGac_NoiDungGac]
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachGac_QuanNhan] FOREIGN KEY([MaQN])
REFERENCES [dbo].[QuanNhan] ([MaQN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac] CHECK CONSTRAINT [FK_ChiTietDanhSachGac_QuanNhan]
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDanhSachGac_ThoiGianGac] FOREIGN KEY([MaTG])
REFERENCES [dbo].[ThoiGianGac] ([MaTG])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDanhSachGac] CHECK CONSTRAINT [FK_ChiTietDanhSachGac_ThoiGianGac]
GO
ALTER TABLE [dbo].[NoiDungCongViec]  WITH CHECK ADD  CONSTRAINT [FK_NoiDungCongViec_TinhChatCongViec] FOREIGN KEY([MaTC])
REFERENCES [dbo].[TinhChatCongViec] ([MaTC])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NoiDungCongViec] CHECK CONSTRAINT [FK_NoiDungCongViec_TinhChatCongViec]
GO
ALTER TABLE [dbo].[NoiDungCongViec]  WITH CHECK ADD  CONSTRAINT [FK_NoiDungCongViec_TrangThaiCongViec] FOREIGN KEY([MaTT])
REFERENCES [dbo].[TrangThaiCongViec] ([MaTT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NoiDungCongViec] CHECK CONSTRAINT [FK_NoiDungCongViec_TrangThaiCongViec]
GO
ALTER TABLE [dbo].[QuanNhan]  WITH CHECK ADD  CONSTRAINT [FK_QuanNhan_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucvu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanNhan] CHECK CONSTRAINT [FK_QuanNhan_ChucVu]
GO
ALTER TABLE [dbo].[QuanNhan]  WITH CHECK ADD  CONSTRAINT [FK_QuanNhan_DonVi] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DonVi] ([MaDV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanNhan] CHECK CONSTRAINT [FK_QuanNhan_DonVi]
GO
ALTER TABLE [dbo].[QuanNhan]  WITH CHECK ADD  CONSTRAINT [FK_QuanNhan_Nganh] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[Nganh] ([MaNganh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanNhan] CHECK CONSTRAINT [FK_QuanNhan_Nganh]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_QuanNhan] FOREIGN KEY([MaQN])
REFERENCES [dbo].[QuanNhan] ([MaQN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_QuanNhan]
GO
ALTER TABLE [dbo].[TK_Quyen]  WITH CHECK ADD  CONSTRAINT [FK_TK_Quyen_Quyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TK_Quyen] CHECK CONSTRAINT [FK_TK_Quyen_Quyen]
GO
ALTER TABLE [dbo].[TK_Quyen]  WITH CHECK ADD  CONSTRAINT [FK_TK_Quyen_TaiKhoan] FOREIGN KEY([MaTK])
REFERENCES [dbo].[TaiKhoan] ([MaTK])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TK_Quyen] CHECK CONSTRAINT [FK_TK_Quyen_TaiKhoan]
GO
ALTER TABLE [dbo].[UuTien]  WITH CHECK ADD  CONSTRAINT [FK_QN_UuTien_QuanNhan] FOREIGN KEY([MaQN])
REFERENCES [dbo].[QuanNhan] ([MaQN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UuTien] CHECK CONSTRAINT [FK_QN_UuTien_QuanNhan]
GO
/****** Object:  StoredProcedure [dbo].[usp_CatCongViecDaiDoi]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CatCongViecDaiDoi]
    @Noidung NVARCHAR(300),
    @DiaDiem NVARCHAR(50),
    @Ngay DATE,
    @soluong INT,
    @ThoiGianBatDauCongViec2 TIME,
    @MaTC INT,
    @MaDV INT
AS
BEGIN
    INSERT INTO dbo.NoiDungCongViec
    (
        NoiDung,
        DiaDiem,
        Ngay,
        SoLuong,
        STTDS,
        STTCV,
        GhiChu,
        TGBD,
        TGKT,
        MaTC,
        MaDV
    )
    VALUES
    (
        @Noidung,
        @DiaDiem,
        @Ngay,
        @soluong,
        1,
        0,
        NULL,
        @ThoiGianBatDauCongViec2,
        NULL,
        @MaTC,
        @MaDV
    );
    DECLARE @macv INT;
    SELECT @macv = nd.MaCongViec
    FROM dbo.NoiDungCongViec nd
    WHERE nd.NoiDung = @Noidung AND nd.DiaDiem = @DiaDiem AND nd.TGBD = @ThoiGianBatDauCongViec2 AND nd.MaTC = @MaTC AND nd.MaDV = @MaDV;

    DECLARE @SoLuongDaCat INT;
    SELECT @SoLuongDaCat = COUNT(*)
    FROM ChiTietDanhSachCongViec
    WHERE MaCongViec = @macv;

    IF @SoLuongDaCat < @soluong
    BEGIN
        INSERT INTO dbo.ChiTietDanhSachCongViec
        (
            MaDS,
            MaQN,
            MaCongViec
        )
        SELECT 2 AS MaDS,
            RandomMaQN.MaQN,
            @macv AS MaCongViec
        FROM (
            SELECT TOP (@soluong)
                MaQN
            FROM QuanNhan
            WHERE
                (@MaTC = 1 AND GioiTinh = 1)
                OR
                (@MaTC = 2)
                OR
                (@MaTC = 3 AND GioiTinh = 0)
                AND MaQN NOT IN (
                    SELECT a.MaQN
                    FROM dbo.ChiTietDanhSachCongViec a
                    WHERE a.MaCongViec IN (
                        SELECT ndcv.MaCongViec
                        FROM dbo.NoiDungCongViec ndcv
                        WHERE ndcv.TGBD < @ThoiGianBatDauCongViec2 AND @ThoiGianBatDauCongViec2 < ndcv.TGKT
                    )
                )
            ORDER BY NEWID()
        ) AS RandomMaQN;
    END
    ELSE
    BEGIN
        PRINT 'Da du so luong can cat.';
    END

    EXEC dbo.usp_HienThiDanhSachLamViec @MaCongViec = @macv -- int
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CatCongViecTuDong]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CatCongViecTuDong]
	@MaCV INT,
    @Noidung NVARCHAR(300),
    @DiaDiem NVARCHAR(50),
    @Ngay DATE,
    @soluong INT,
    @ThoiGianBatDauCongViec2 TIME,
    @MaTC INT,
    @MaDV INT
AS
BEGIN
    -- Đặt giá trị mới cho cột cần cập nhật
UPDATE NoiDungCongViec
SET
    NoiDung = @Noidung,
    DiaDiem = @DiaDiem,
    Ngay = @Ngay,
    SoLuong = @soluong,
    TGBD = @ThoiGianBatDauCongViec2,
    TGKT = NULL,
    MaTC = @MaTC,
    MaDV = @MaDV
WHERE
    MaCongViec = @MaCV; -- Thay MaCV bằng giá trị cụ thể bạn muốn cập nhật

    DECLARE @SoLuongDaCat INT;
    SELECT @SoLuongDaCat = COUNT(*)
    FROM ChiTietDanhSachCongViec
    WHERE MaCongViec = @macv;

    IF @SoLuongDaCat < @soluong
    BEGIN
        INSERT INTO dbo.ChiTietDanhSachCongViec
        (
            MaDS,
            MaQN,
            MaCongViec
        )
        SELECT 2 AS MaDS,
            RandomMaQN.MaQN,
            @macv AS MaCongViec
        FROM (
            SELECT TOP (@soluong)
                MaQN
            FROM QuanNhan
            WHERE
                (@MaTC = 1 AND GioiTinh = 1)
                OR
                (@MaTC = 2)
                OR
                (@MaTC = 3 AND GioiTinh = 0)
                AND MaQN NOT IN (
                    SELECT a.MaQN
                    FROM dbo.ChiTietDanhSachCongViec a
                    WHERE a.MaCongViec IN (
                        SELECT ndcv.MaCongViec
                        FROM dbo.NoiDungCongViec ndcv
                        WHERE ndcv.TGBD < @ThoiGianBatDauCongViec2 AND @ThoiGianBatDauCongViec2 < ndcv.TGKT
                    )
                )
            ORDER BY NEWID()
        ) AS RandomMaQN;
    END
    ELSE
    BEGIN
        PRINT 'Da du so luong can cat.';
    END

    EXEC dbo.usp_HienThiDanhSachLamViec @MaCongViec = @macv -- int
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CatGacTuDong]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_CatGacTuDong]
    @MaGac INT
AS
BEGIN
    -- Tạo bảng tạm để lưu trạng thái của các mã đã được chọn
    CREATE TABLE #SelectedMaQN (MaQN INT);

    -- Kiểm tra xem MaGac đã tồn tại trong ChiTietDanhSachGac chưa
    IF NOT EXISTS (SELECT 1 FROM ChiTietDanhSachGac WHERE MaGac = @MaGac)
    BEGIN
        -- Tạo bảng MaTG tạm để lưu trạng thái của các MaTG
        CREATE TABLE #SelectedMaTG (MaTG INT);

        -- Thêm dữ liệu vào bảng MaTG
        INSERT INTO #SelectedMaTG (MaTG) VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10);

        -- Thêm dữ liệu vào bảng ChiTietDanhSachGac cho MaTG = 1, 2, 3
        DECLARE @MaTG INT;
        SET @MaTG = 1;

        WHILE @MaTG <= 3
        BEGIN
            INSERT INTO ChiTietDanhSachGac (MaTG, MaDS, MaQN, MaGac)
            SELECT TOP 4
                @MaTG AS MaTG,
                1 AS MaDS,
                RandomMaQN.MaQN,
                @MaGac AS MaGac
            FROM (
                SELECT
                    MaQN,
                    ROW_NUMBER() OVER (ORDER BY NEWID()) AS RandomNumber
                FROM QuanNhan
                WHERE GioiTinh = 0 AND MaDV = (SELECT MaDV FROM NoiDungGac WHERE MaGac = @MaGac)
                    AND MaChucVu = 3 
                    AND MaQN NOT IN (SELECT MaQN FROM ChiTietDanhSachGac WHERE MaGac = @MaGac)
            ) AS RandomMaQN
            WHERE RandomMaQN.RandomNumber IS NOT NULL -- Đảm bảo không có dữ liệu NULL
            ORDER BY RandomMaQN.RandomNumber;

            SET @MaTG = @MaTG + 1;
        END

        -- Lấy 5 MaQN nam cho MaTG = 5, 6, 7, 8, 9, 10
        SET @MaTG = 5;

        WHILE @MaTG <= 10
        BEGIN
            INSERT INTO ChiTietDanhSachGac (MaTG, MaDS, MaQN, MaGac)
            SELECT TOP 5
                @MaTG AS MaTG,
                1 AS MaDS,
                RandomMaQN.MaQN,
                @MaGac AS MaGac
            FROM (
                SELECT
                    MaQN,
                    ROW_NUMBER() OVER (ORDER BY NEWID()) AS RandomNumber
                FROM QuanNhan
                WHERE GioiTinh = 1 AND MaDV = (SELECT MaDV FROM NoiDungGac WHERE MaGac = @MaGac)
                    AND MaChucVu = 3 
                    AND MaQN NOT IN (SELECT MaQN FROM ChiTietDanhSachGac WHERE MaGac = @MaGac)
            ) AS RandomMaQN
            WHERE RandomMaQN.RandomNumber IS NOT NULL
            ORDER BY RandomMaQN.RandomNumber;

            SET @MaTG = @MaTG + 1;
        END

        -- Hiển thị thông tin hoặc thực hiện các thao tác khác tùy thuộc vào nhu cầu của bạn
        SELECT * FROM ChiTietDanhSachGac WHERE MaGac = @MaGac;

        -- Xóa bảng tạm MaTG
        DROP TABLE IF EXISTS #SelectedMaTG;
    END
    ELSE
    BEGIN
        PRINT 'MaGac already exists in ChiTietDanhSachGac.';
    END

    -- Xóa bảng tạm MaQN
    DROP TABLE IF EXISTS #SelectedMaQN;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CatViecTuDong]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CatViecTuDong]
    @MaCongViec INT
AS
BEGIN
    -- Tạo bảng tạm để lưu trạng thái của các mã đã được chọn
    CREATE TABLE #SelectedMaQN (MaQN INT);

    -- Lấy thông tin MaTC từ bảng NoiDungCongViec
    DECLARE @MaTC INT;
    SELECT @MaTC = MaTC FROM NoiDungCongViec WHERE MaCongViec = @MaCongViec;

    -- Lấy thông tin SoLuong từ bảng NoiDungCongViec
    DECLARE @SoLuong INT;
    SELECT @SoLuong = SoLuong FROM NoiDungCongViec WHERE MaCongViec = @MaCongViec;

    -- Lấy số lượng đã cắt trong bảng ChiTietDanhSachCongViec
    DECLARE @SoLuongDaCat INT;
    SELECT @SoLuongDaCat = COUNT(*) FROM ChiTietDanhSachCongViec WHERE MaCongViec = @MaCongViec;

    -- Kiểm tra xem đã cắt đủ người chưa
    IF @SoLuongDaCat < @SoLuong
    BEGIN
        -- Thêm dữ liệu vào bảng ChiTietDanhSachCongViec
        INSERT INTO ChiTietDanhSachCongViec (MaDS, MaQN, MaCongViec)
        SELECT 
            2 AS MaDS,
            RandomMaQN.MaQN,
            @MaCongViec AS MaCongViec
        FROM (
            SELECT TOP (@SoLuong - @SoLuongDaCat)
                MaQN
            FROM QuanNhan
            WHERE 
                (@MaTC = 1 AND GioiTinh = 1) OR  -- Chọn Nam nếu MaTC=1
                (@MaTC = 2) OR                    -- Chọn bất kỳ nếu MaTC=2
                (@MaTC = 3 AND GioiTinh = 0)      -- Chọn Nữ nếu MaTC=3
            ORDER BY NEWID()
        ) AS RandomMaQN;

        -- Hiển thị thông tin hoặc thực hiện các thao tác khác tùy thuộc vào nhu cầu của bạn
        SELECT * FROM ChiTietDanhSachCongViec WHERE MaCongViec = @MaCongViec;
    END
    ELSE
    BEGIN
        PRINT 'Da du so luong can cat.';
    END

    -- Xóa bảng tạm
    DROP TABLE IF EXISTS #SelectedMaQN;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Dangnhap]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_Dangnhap]
@TenTk VARCHAR(50),@Matkhau VARCHAR(50)
AS
BEGIN
	DECLARE @matk INT
	SELECT @matk=tk.MaTK FROM dbo.TaiKhoan tk WHERE tk.TenTK=@TenTk AND tk.MatKhau=@Matkhau
    SELECT  dv.MaDV,qn.MaQN,tk_quyen.MaQuyen
	FROM dbo.TK_Quyen tk_quyen INNER JOIN dbo.TaiKhoan tk ON tk.MaTK = tk_quyen.MaTK
	INNER JOIN dbo.QuanNhan qn ON qn.MaQN = tk.MaQN
	INNER JOIN dbo.DonVi dv ON dv.MaDV = qn.MaDV
	WHERE tk.TenTK=@TenTk AND tk.MatKhau=@Matkhau AND tk_quyen.MaTK=@matk
END
GO
/****** Object:  StoredProcedure [dbo].[usp_DanhSachNgayGac]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DanhSachNgayGac]
AS
BEGIN
    SELECT * FROM dbo.NoiDungGac 
END
GO
/****** Object:  StoredProcedure [dbo].[usp_HienThiDanhSachLamViec]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_HienThiDanhSachLamViec]
@MaCongViec int
AS
BEGIN
    SELECT
    ROW_NUMBER() OVER (ORDER BY ng.TenNganh) AS STT,
    qn.TenQN,
    ng.TenNganh
FROM
    dbo.Nganh ng
    INNER JOIN dbo.QuanNhan qn ON qn.MaNganh = ng.MaNganh
    INNER JOIN dbo.ChiTietDanhSachCongViec ctdscv ON ctdscv.MaQN = qn.MaQN 
	WHERE ctdscv.MaCongViec=@MaCongViec
END
GO
/****** Object:  StoredProcedure [dbo].[usp_HienTHiGac]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[usp_HienTHiGac]
@magac INT
AS
BEGIN
WITH PivotedData AS (
    SELECT
        ThoiGian,
        MAX(CASE WHEN Rownum = 1 THEN TenQN END) AS HV1,
        MAX(CASE WHEN Rownum = 2 THEN TenQN END) AS HV2,
        MAX(CASE WHEN Rownum = 3 THEN TenQN END) AS HV3,
        MAX(CASE WHEN Rownum = 4 THEN TenQN END) AS HV4,
        MAX(CASE WHEN Rownum = 5 THEN TenQN END) AS [DocGac]
    FROM (
        SELECT
            tgg.ThoiGian,
            qn.TenQN,
            ROW_NUMBER() OVER (PARTITION BY tgg.ThoiGian ORDER BY tgg.MaTG DESC) AS Rownum
        FROM
            dbo.QuanNhan qn
            INNER JOIN dbo.ChiTietDanhSachGac ctg ON ctg.MaQN = qn.MaQN
            INNER JOIN dbo.ThoiGianGac tgg ON tgg.MaTG = ctg.MaTG
        WHERE ctg.MaGac = @magac
    ) AS SourceTable
    GROUP BY ThoiGian
)
SELECT 
	tg.MaTG,
    pv.ThoiGian,
    ISNULL(pv.HV1, N'Trực Ban') AS HV1,
    ISNULL(pv.HV2, N'Trực Ban') AS HV2,
    ISNULL(pv.HV3, N'Trực Ban') AS HV3,
    ISNULL(pv.HV4, N'Trực Ban') AS HV4,
    ISNULL(pv.[DocGac], N'Trực Ban') AS [DocGac]
FROM PivotedData pv
INNER JOIN dbo.ThoiGianGac tg ON pv.ThoiGian = tg.ThoiGian
ORDER BY tg.MaTG
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_HienThiQuanNhan]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Usp_HienThiQuanNhan]
@thoigian VARCHAR(50),@ngaygac DATE
AS
BEGIN
	DECLARE @gioitinh int
	DECLARE @matg INT
	SELECT @matg=tg.MaTG FROM dbo.ThoiGianGac tg WHERE tg.ThoiGian=@thoigian
    SET @gioitinh = 
    CASE 
        WHEN @matg IN (1, 2, 3) THEN 0
        ELSE 1
    END
	DECLARE @magac int
	SELECT @magac=ndg.MaGac FROM dbo.NoiDungGac ndg WHERE ndg.Ngay=@ngaygac
    SELECT qn.TenQN FROM dbo.QuanNhan qn,dbo.ChiTietDanhSachGac ctg  WHERE qn.GioiTinh=@gioitinh AND ctg.MaGac=@magac AND NOT EXISTS(
	SELECT 1
    FROM dbo.ChiTietDanhSachGac ctg
    WHERE ctg.MaTG = @matg
    AND ctg.MaQN = qn.MaQN 
	) 
	GROUP BY qn.TenQN
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_HienThoiGian]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Usp_HienThoiGian]
AS
BEGIN
    SELECT tg.ThoiGian FROM dbo.ThoiGianGac tg
END
GO
/****** Object:  StoredProcedure [dbo].[usp_SuaPhanCongCV]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SuaPhanCongCV]
@NoidungCV NVARCHAR(100),@ngaythuchien VARCHAR(50),@TGThucHien NVARCHAR(10),@DiaDiem NVARCHAR(50),@soluong INT,@nhacnho NVARCHAR(300),@MaDV int
AS
BEGIN
    UPDATE dbo.NoiDungCongViec SET NoiDung=@NoidungCV,Ngay=@ngaythuchien,TGDuKien=@TGThucHien,DiaDiem=@DiaDiem,SoLuong=@soluong,GhiChu=@nhacnho WHERE MaDV=@MaDV
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemLichGac]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_ThemLichGac]
@ngay VARCHAR(50), @hoi VARCHAR(50),@dap VARCHAR(50),@MaDV INT,@NhacNho VARCHAR(200)
AS 
BEGIN
	INSERT INTO NoiDungGac (Ngay, Hoi, Dap, MaDV, NhacNho)
	VALUES (@ngay, @hoi, @dap, @MaDV, @NhacNho);

END
GO
/****** Object:  StoredProcedure [dbo].[usp_ThemPhanCongCV]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ThemPhanCongCV]
@NoidungCV NVARCHAR(100),@ngaythuchien VARCHAR(50),@TGThucHien NVARCHAR(10),@DiaDiem NVARCHAR(50),@soluong INT,@nhacnho NVARCHAR(300),@MaDV int
AS
BEGIN
    INSERT INTO dbo.NoiDungCongViec
    (
        NoiDung,
        DiaDiem,
        Ngay,
        TGDuKien,
        SoLuong,
        STTDS,
        STTCV,
        GhiChu,
        TGBD,
        TGKT,
        DacDiem,
		MaDV
    )
    VALUES
    (   @NoidungCV, -- NoiDung - nvarchar(100)
        @DiaDiem, -- DiaDiem - nvarchar(100)
        @ngaythuchien, -- Ngay - date
        @TGThucHien, -- TGDuKien - nvarchar(10)
        @soluong, -- SoLuong - int
        0, -- STTDS - nvarchar(10)
        0, -- STTCV - nvarchar(10)
        @nhacnho, -- GhiChu - nvarchar(300)
        NULL, -- TGBD - nvarchar(10)
        NULL, -- TGKT - nvarchar(10)
        NULL,  -- DacDiem - int
		@MaDV
        )
END
GO
/****** Object:  StoredProcedure [dbo].[usp_themtaikhoan]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_themtaikhoan]
@TenTK VARCHAR(50),@Matkhau VARCHAR(50),@MaQN INT,@Maquyen int
AS
BEGIN
    INSERT INTO dbo.TaiKhoan
    (
        TenTK,
        MatKhau,
        MaQN
    )
    VALUES
    (   @TenTK, -- TenTK - nvarchar(50)
        @Matkhau, -- MatKhau - nvarchar(50)
        @MaQN  -- MaQN - int
        )
	DECLARE @matk INT
	SELECT @matk=tk.MaTK FROM dbo.TaiKhoan tk WHERE tk.TenTK=@TenTK AND tk.MatKhau=@Matkhau AND tk.MaQN=@MaQN 
	INSERT INTO dbo.TK_Quyen
	(
	    MaTK,
	    MaQuyen
	)
	VALUES
	(   @matk, -- MaTK - int
	    @Maquyen  -- MaQuyen - int
	    )
END
GO
/****** Object:  StoredProcedure [dbo].[usp_XoaPhanCongCV]    Script Date: 12/17/2023 10:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_XoaPhanCongCV]
@MaDV int
AS
BEGIN
	DELETE dbo.NoiDungCongViec WHERE MaDV=@MaDV
END
GO
