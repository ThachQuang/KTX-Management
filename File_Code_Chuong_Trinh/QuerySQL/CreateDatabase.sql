CREATE DATABASE [KTX]
GO
USE [KTX]
GO
CREATE TABLE [dbo].[DICHVUCHUNG](
	[id_phong] [int] NOT NULL,
	[thang] [tinyint] NULL,
	[dich_vu_1] [tinyint] NULL,
	[dich_vu_2] [tinyint] NULL,
	[thanh_tien] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DICHVURIENG]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVURIENG](
	[id_sinhvien] [int] NOT NULL,
	[thang] [tinyint] NULL,
	[dich_vu_1] [tinyint] NULL,
	[dich_vu_2] [tinyint] NULL,
	[dich_vu_3] [tinyint] NULL,
	[thanh_tien] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DIEN]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEN](
	[id_phong] [int] NOT NULL,
	[thang] [tinyint] NULL,
	[so_dau] [int] NULL,
	[so_cuoi] [int] NULL,
	[thanh_tien] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIADICHVU]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIADICHVU](
	[id_dichvu] [int] IDENTITY(1,1) NOT NULL,
	[ten_dichvu] [nvarchar](50) NULL,
	[gia_dichvu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NOITHAT]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOITHAT](
	[id_phong] [int] NOT NULL,
	[ten_noi_that] [nvarchar](50) NULL,
	[so_luong] [tinyint] NULL,
	[tinh_trang] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NUOC]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NUOC](
	[id_phong] [int] NOT NULL,
	[thang] [tinyint] NULL,
	[so_dau] [int] NULL,
	[so_cuoi] [int] NULL,
	[thanh_tien] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG](
	[id_phong] [int] IDENTITY(1,1) NOT NULL,
	[ten_phong] [varchar](10) NULL,
	[khu] [varchar](10) NULL,
	[tang] [tinyint] NULL,
	[suc_chua] [tinyint] NULL,
	[so_nguoi] [tinyint] NULL,
	[dien_tich] [float] NULL,
	[gia_thue] [int] NULL,
	[phi_thu_thang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_phong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHUHUYNH]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHUHUYNH](
	[id_phuhuynh] [int] IDENTITY(1,1) NOT NULL,
	[id_sinhvien] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
	[ngay_sinh] [date] NULL,
	[gioi_tinh] [bit] NULL,
	[que_quan] [nvarchar](30) NULL,
	[nghe_nghiep] [nvarchar](30) NULL,
	[sdt] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_phuhuynh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 27/11/2021 4:13:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[id_sinhvien] [int] IDENTITY(1,1) NOT NULL,
	[id_phong] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
	[ngay_sinh] [date] NULL,
	[gioi_tinh] [bit] NULL,
	[que_quan] [nvarchar](30) NULL,
	[nghe_nghiep] [nvarchar](30) NULL,
	[sdt] [varchar](15) NULL,
	[cmnd] [varchar](20) NULL,
	[bhyt] [varchar](20) NULL,
	[noi_lam_viec] [nvarchar](256) NULL,
	[ho_khau] [nvarchar](256) NULL,
	[sv_nam] [tinyint] NULL,
	[hop_dong_start] [date] NULL,
	[hop_dong_end] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[DICHVUCHUNG]  WITH CHECK ADD FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
GO
ALTER TABLE [dbo].[DICHVURIENG]  WITH CHECK ADD FOREIGN KEY([id_sinhvien])
REFERENCES [dbo].[SINHVIEN] ([id_sinhvien])
GO
ALTER TABLE [dbo].[DIEN]  WITH CHECK ADD FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
GO
ALTER TABLE [dbo].[NOITHAT]  WITH CHECK ADD FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
GO
ALTER TABLE [dbo].[NUOC]  WITH CHECK ADD FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
GO
ALTER TABLE [dbo].[PHUHUYNH]  WITH CHECK ADD FOREIGN KEY([id_sinhvien])
REFERENCES [dbo].[SINHVIEN] ([id_sinhvien])
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD FOREIGN KEY([id_phong])
REFERENCES [dbo].[PHONG] ([id_phong])
