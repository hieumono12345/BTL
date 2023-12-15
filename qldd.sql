USE [QuanlyDaiDoi3]
GO
/****** Object:  Table [dbo].[ChiTietDanhSachCongViec]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[ChiTietDanhSachGac]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[DanhSach]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[DonVi]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[Nganh]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[NoiDungCongViec]    Script Date: 12/15/2023 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiDungCongViec](
	[MaCongViec] [int] IDENTITY(1,1) NOT NULL,
	[NoiDung] [nvarchar](100) NULL,
	[DiaDiem] [nvarchar](100) NULL,
	[Ngay] [date] NULL,
	[TGDuKien] [nvarchar](10) NULL,
	[SoLuong] [int] NULL,
	[STTDS] [int] NULL,
	[STTCV] [int] NULL,
	[GhiChu] [nvarchar](300) NULL,
	[TGBD] [nvarchar](10) NULL,
	[TGKT] [nvarchar](10) NULL,
	[DacDiem] [nvarchar](50) NULL,
	[MaDV] [int] NULL,
 CONSTRAINT [PK_NoiDungCongViec] PRIMARY KEY CLUSTERED 
(
	[MaCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NoiDungGac]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[QuanNhan]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[Quyen]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/15/2023 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[MaQN] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiGianGac]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  Table [dbo].[TK_Quyen]    Script Date: 12/15/2023 2:28:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TK_Quyen](
	[MaTK] [int] NULL,
	[MaQuyen] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UuTien]    Script Date: 12/15/2023 2:28:58 PM ******/
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
', 1, 3, 2, NULL, 0)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (8, N'Bùi Quốc Khánh
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (9, N'Nguyễn Hoàng Nam
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (10, N'Nguyễn Khôi Nguyên
', 1, 3, 2, NULL, 1)
INSERT [dbo].[QuanNhan] ([MaQN], [TenQN], [MaNganh], [MaChucVu], [MaDV], [SDT], [GioiTinh]) VALUES (11, N'Nguyễn Thị Hà Phương
', 1, 3, 2, NULL, 0)
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
/****** Object:  StoredProcedure [dbo].[usp_SuaPhanCongCV]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[USP_ThemLichGac]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_ThemPhanCongCV]    Script Date: 12/15/2023 2:28:58 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_XoaPhanCongCV]    Script Date: 12/15/2023 2:28:58 PM ******/
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
