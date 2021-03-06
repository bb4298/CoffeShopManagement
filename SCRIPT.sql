
/****** Object:  Database [QuanLyCF]    Script Date: 11/02/2018 17:52:05 ******/
CREATE DATABASE [QuanLyCF]
GO
ALTER DATABASE [QuanLyCF] SET COMPATIBILITY_LEVEL = 100
GO
ALTER DATABASE [QuanLyCF] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyCF] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyCF] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyCF] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyCF] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyCF] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [QuanLyCF] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyCF] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyCF] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyCF] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyCF] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyCF] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyCF] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyCF] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyCF] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyCF] SET  DISABLE_BROKER
GO
ALTER DATABASE [QuanLyCF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyCF] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyCF] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyCF] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyCF] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyCF] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyCF] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyCF] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyCF] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLyCF] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyCF] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyCF] SET DB_CHAINING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/02/2018 17:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [nvarchar](50) NOT NULL,
	[tenNhanVien] [nvarchar](80) NULL,
	[ngaySinh] [datetime] NULL,
	[gioiTinh] [nvarchar](20) NULL,
	[diaChi] [nvarchar](max) NULL,
	[soDienThoai] [nvarchar](20) NULL,
	[loaiNhanVien] [nvarchar](50) NULL,
	[trangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThongTinNhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0001', N'Nguyễn Hồng Quang', CAST(0x00008BF400000000 AS DateTime), N'Nam ', N'Quận 12', N'0164606596', N'AD', N'L')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0002', N'Trần Trung Hào', CAST(0x00008C2D00000000 AS DateTime), N'Nam ', N'Long Xuyên', N'0165435987', N'TN', N'L')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0003', N'Huỳnh Anh Khang', CAST(0x00008BD200000000 AS DateTime), N'Nam', N'Quận Bình Thạnh', N'0165349856', N'PC', N'L')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0004', N'Vũ Tiến Thành', CAST(0x00008C8100000000 AS DateTime), N'Nam', N'Quận 12', N'0164256354', N'TN', N'N')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0005', N'Nguyễn Đình Nhật Tân', CAST(0x00008C3E00000000 AS DateTime), N'Nam', N'Quận Tân Bình', N'0163254985', N'PC', N'L')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0006', N'Huỳnh Phúc Huy', CAST(0x00008C6100000000 AS DateTime), N'Nam', N'Quận Tân Bình', N'0123465986', N'TN', N'N')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0007', N'Lê Thị Kim Ngọc', CAST(0x00008CC900000000 AS DateTime), N'Nữ', N'Quận 5', N'0132564556', N'TN', N'L')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0008', N'Lê Hồ Phương Uyên', CAST(0x00008CFB014B9E24 AS DateTime), N'Nữ', N'Quận6', N'0132564556', N'NV', N'L')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0009', N'Nguyễn Thị Kim Ân', CAST(0x00008CFB014D1074 AS DateTime), N'Nữ', N'Huyện Củ Chi', N'0164253629', N'PC', N'N')
INSERT [dbo].[NhanVien] ([maNhanVien], [tenNhanVien], [ngaySinh], [gioiTinh], [diaChi], [soDienThoai], [loaiNhanVien], [trangThai]) VALUES (N'NV0010', N'Nguyễn Thị Lan Anh', CAST(0x0000A984014E42BF AS DateTime), N'Nữ', N'Quận Gò Vấp', N'0126453965', N'NV', N'L')
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 11/02/2018 17:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[maLoaiThucDon] [nvarchar](50) NOT NULL,
	[tenLoaiThucDon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiThucDon] PRIMARY KEY CLUSTERED 
(
	[maLoaiThucDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiThucDon] ([maLoaiThucDon], [tenLoaiThucDon]) VALUES (N'L001', N'Cà phê')
INSERT [dbo].[LoaiThucDon] ([maLoaiThucDon], [tenLoaiThucDon]) VALUES (N'L002', N'Trà đặc biệt')
INSERT [dbo].[LoaiThucDon] ([maLoaiThucDon], [tenLoaiThucDon]) VALUES (N'L003', N'Nước trái cây')
INSERT [dbo].[LoaiThucDon] ([maLoaiThucDon], [tenLoaiThucDon]) VALUES (N'L004', N'Đồ ăn')
INSERT [dbo].[LoaiThucDon] ([maLoaiThucDon], [tenLoaiThucDon]) VALUES (N'L005', N'Thức Uống')
/****** Object:  Table [dbo].[Ban]    Script Date: 11/02/2018 17:52:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[maBan] [int] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
	[maHoaDon] [int] NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[maBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (1, N'Có Người', 13)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (2, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (3, N'Có Người', 18)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (4, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (5, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (6, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (7, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (8, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (9, N'Trống', NULL)
INSERT [dbo].[Ban] ([maBan], [trangThai], [maHoaDon]) VALUES (10, N'Trống', NULL)
/****** Object:  StoredProcedure [dbo].[usp_laydsban]    Script Date: 11/02/2018 17:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_laydsban]
as select * from dbo.Ban
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 11/02/2018 17:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[maThucDon] [nvarchar](50) NOT NULL,
	[tenThucDon] [nvarchar](50) NOT NULL,
	[donViTinh] [nvarchar](50) NOT NULL,
	[donGia] [decimal](20, 0) NULL,
	[maLoaiThucDon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ThucUong] PRIMARY KEY CLUSTERED 
(
	[maThucDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0001', N'AMERICANO', N'Ly', CAST(35000 AS Decimal(20, 0)), N'L001')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0002', N'CAPPUCCINO', N'Ly', CAST(45000 AS Decimal(20, 0)), N'L001')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0003', N'CARAMEL MACCHIATO', N'Ly', CAST(60000 AS Decimal(20, 0)), N'L001')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0004', N'ESPRSSO', N'Ly', CAST(35000 AS Decimal(20, 0)), N'L001')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0005', N'MOCHA', N'Ly', CAST(49000 AS Decimal(20, 0)), N'L001')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0006', N'BLACK TEA MACCHIATO', N'Ly', CAST(38000 AS Decimal(20, 0)), N'L002')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0007', N'FLAVOURED TEA', N'Ly', CAST(35000 AS Decimal(20, 0)), N'L002')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0008', N'HOT BACK TEA', N'Ly', CAST(35000 AS Decimal(20, 0)), N'L002')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0009', N'MATCHA ICE BLENDED', N'Ly', CAST(59000 AS Decimal(20, 0)), N'L002')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0010', N'MATCHA LATTE', N'Ly', CAST(55000 AS Decimal(20, 0)), N'L002')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0011', N'BLUBERRY SMOOTHIE', N'Ly', CAST(59000 AS Decimal(20, 0)), N'L003')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0012', N'BLUBERRY SODA', N'Ly', CAST(45000 AS Decimal(20, 0)), N'L003')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0013', N'GREEN APPLE', N'Ly', CAST(45000 AS Decimal(20, 0)), N'L003')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0014', N'MOJITO LEMON', N'Ly', CAST(45000 AS Decimal(20, 0)), N'L003')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0015', N'RASPBERRY SODA', N'Ly', CAST(50000 AS Decimal(20, 0)), N'L003')
INSERT [dbo].[ThucDon] ([maThucDon], [tenThucDon], [donViTinh], [donGia], [maLoaiThucDon]) VALUES (N'TD0017', N'CHANH MUỐI', N'Ly', CAST(20000 AS Decimal(20, 0)), N'L003')
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/02/2018 17:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[tenTaiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](50) NULL,
	[maNhanVien] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[tenTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'anh123', N'1D23CC91BFE43FC377BE08A2BF618D11', N'NV0010')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'hao123', N'C6764AFFC2325133A874BD0A67FE244B', N'NV0002')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'huy123', N'629050CFB284AA2C0832152E7E181639', N'NV0006')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'khang123', N'4DBE2A1FDA088E138D36BC4A3545CF1B', N'NV0003')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'kimAn123', N'45DC02C0328381979849BCD1E3BAA7EB', N'NV0009')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'ngoc123', N'161EB85732B6A29A6A22791257AB6B80', N'NV0007')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'quang123', N'9D89F8896F6FF08E86C4491515D5ED29', N'NV0001')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'tan123', N'6FB4CD822753F7827FAD201693AE3291', N'NV0005')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'thanh123', N'532A22F2BF9D599477E2ADAAAC4FC76D', N'NV0004')
INSERT [dbo].[TaiKhoan] ([tenTaiKhoan], [matKhau], [maNhanVien]) VALUES (N'uyen123', N'928263B5EC47804A86B4548979C4AFDC', N'NV0008')
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/02/2018 17:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHoaDon] [int] NOT NULL,
	[ngayThanhToan] [datetime]  NULL,
	[tongTienThanhToan] [decimal](20, 0) NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
	[maBan] [int] NULL,
	[maNhanVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (1, CAST(0x0000A8C000000000 AS DateTime), CAST(150000 AS Decimal(20, 0)), N'R', 1, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (2, CAST(0x0000A8D3001EC4F4 AS DateTime), CAST(90000 AS Decimal(20, 0)), N'R', 2, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (3, CAST(0x0000A8DE0143E0CA AS DateTime), CAST(218000 AS Decimal(20, 0)), N'R', 2, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (4, CAST(0x0000A8DF0163B150 AS DateTime), CAST(459000 AS Decimal(20, 0)), N'R', 2, N'NV0004')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (5, CAST(0x0000A8F201643B15 AS DateTime), CAST(168000 AS Decimal(20, 0)), N'R', 9, N'NV0006')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (6, CAST(0x0000A8F201643E98 AS DateTime), CAST(297000 AS Decimal(20, 0)), N'R', 5, N'NV0006')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (7, CAST(0x0000A8F30165D8C6 AS DateTime), CAST(94000 AS Decimal(20, 0)), N'R', 7, N'NV0004')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (8, CAST(0x0000A8F40165EF97 AS DateTime), CAST(49000 AS Decimal(20, 0)), N'R', 9, N'NV0004')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (9, CAST(0x0000A9130165FEAA AS DateTime), CAST(109000 AS Decimal(20, 0)), N'R', 6, N'NV0004')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (10, CAST(0x0000A98F016A9AC2 AS DateTime), CAST(465000 AS Decimal(20, 0)), N'R', 5, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (11, CAST(0x0000A990016A9CEC AS DateTime), CAST(375000 AS Decimal(20, 0)), N'R', 10, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (12, CAST(0x0000A990016AAA96 AS DateTime), CAST(180000 AS Decimal(20, 0)), N'R', 7, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (13, CAST(0x0000A98C0109B289 AS DateTime), CAST(70000 AS Decimal(20, 0)), N'C', 1, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (14, CAST(0x0000A98C0109EC5D AS DateTime), CAST(45000 AS Decimal(20, 0)), N'R', 2, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (15, CAST(0x0000A98C0109F750 AS DateTime), CAST(45000 AS Decimal(20, 0)), N'R', 3, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (16, CAST(0x0000A98C010A054C AS DateTime), CAST(49000 AS Decimal(20, 0)), N'R', 5, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (17, CAST(0x0000A98C010A5467 AS DateTime), CAST(60000 AS Decimal(20, 0)), N'R', 3, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (18, CAST(0x0000A98C010A6910 AS DateTime), CAST(95000 AS Decimal(20, 0)), N'C', 3, N'NV0002')
INSERT [dbo].[HoaDon] ([maHoaDon], [ngayThanhToan], [tongTienThanhToan], [trangThai], [maBan], [maNhanVien]) VALUES (19, CAST(0x0000A98C010A7AEE AS DateTime), CAST(45000 AS Decimal(20, 0)), N'R', 2, N'NV0002')
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/02/2018 17:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[maChiTietHoaDon] [int] NOT NULL,
	[maHoaDon] [int] NULL,
	[maThucDon] [nvarchar](50) NOT NULL,
	[soLuong] [int] NULL,
	[thanhTien] [decimal](18, 0) NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[maChiTietHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (1, 1, N'TD0001', 2, CAST(70000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (2, 1, N'TD0002', 1, CAST(45000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (3, 2, N'TD0002', 2, CAST(90000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (4, 3, N'TD0005', 2, CAST(98000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (5, 3, N'TD0003', 2, CAST(120000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (6, 1, N'TD0001', 1, CAST(35000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (7, 4, N'TD0003', 1, CAST(60000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (8, 4, N'TD0004', 3, CAST(105000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (9, 4, N'TD0005', 3, CAST(147000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (10, 4, N'TD0005', 3, CAST(147000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (11, 6, N'TD0005', 3, CAST(147000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (12, 6, N'TD0002', 2, CAST(90000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (13, 5, N'TD0005', 2, CAST(98000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (14, 5, N'TD0001', 2, CAST(70000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (15, 6, N'TD0003', 1, CAST(60000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (16, 7, N'TD0002', 1, CAST(45000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (17, 7, N'TD0005', 1, CAST(49000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (18, 8, N'TD0005', 1, CAST(49000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (19, 9, N'TD0005', 1, CAST(49000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (20, 9, N'TD0003', 1, CAST(60000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (21, 10, N'TD0002', 1, CAST(45000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (22, 10, N'TD0003', 3, CAST(180000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (23, 10, N'TD0004', 3, CAST(105000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (24, 10, N'TD0002', 3, CAST(135000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (25, 12, N'TD0003', 3, CAST(180000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (26, 11, N'TD0003', 3, CAST(180000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (27, 11, N'TD0002', 3, CAST(135000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (28, 11, N'TD0003', 1, CAST(60000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (29, 13, N'TD0001', 1, CAST(35000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (30, 13, N'TD0001', 1, CAST(35000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (31, 16, N'TD0005', 1, CAST(49000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (32, 15, N'TD0014', 1, CAST(45000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (33, 17, N'TD0003', 1, CAST(60000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (34, 18, N'TD0003', 1, CAST(60000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (35, 18, N'TD0004', 1, CAST(35000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (36, 19, N'TD0002', 1, CAST(45000 AS Decimal(18, 0)), N'R')
INSERT [dbo].[ChiTietHoaDon] ([maChiTietHoaDon], [maHoaDon], [maThucDon], [soLuong], [thanhTien], [trangThai]) VALUES (37, 14, N'TD0002', 1, CAST(45000 AS Decimal(18, 0)), N'R')
/****** Object:  ForeignKey [FK_ThucDon_LoaiThucDon]    Script Date: 11/02/2018 17:52:07 ******/
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [FK_ThucDon_LoaiThucDon] FOREIGN KEY([maLoaiThucDon])
REFERENCES [dbo].[LoaiThucDon] ([maLoaiThucDon])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [FK_ThucDon_LoaiThucDon]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_NhanVien]    Script Date: 11/02/2018 17:52:07 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
/****** Object:  ForeignKey [FK_HoaDon_Ban]    Script Date: 11/02/2018 17:52:07 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Ban] FOREIGN KEY([maBan])
REFERENCES [dbo].[Ban] ([maBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Ban]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien]    Script Date: 11/02/2018 17:52:07 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 11/02/2018 17:52:07 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HoaDon] ([maHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_ThucDon]    Script Date: 11/02/2018 17:52:07 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_ThucDon] FOREIGN KEY([maThucDon])
REFERENCES [dbo].[ThucDon] ([maThucDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_ThucDon]
GO
