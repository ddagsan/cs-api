USE [CaseStudy]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/6/2022 9:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 6/6/2022 9:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 6/6/2022 9:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 6/6/2022 9:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/6/2022 9:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[DiscountRatio] [float] NOT NULL,
	[ColorId] [int] NOT NULL,
	[BrandId] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/6/2022 9:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220605195105_First', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220605205142_UserSeedData', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Brand] ON 

INSERT [dbo].[Brand] ([Id], [Name]) VALUES (1, N'Samsung')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (2, N'Nokia')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (3, N'Apple')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (4, N'LG')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (5, N'Huawei')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (6, N'Xiaomi')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (7, N'General Mobile')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (8, N'Oppo')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (9, N'Vivo')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (10, N'HTC')
INSERT [dbo].[Brand] ([Id], [Name]) VALUES (11, N'Unknown')
SET IDENTITY_INSERT [dbo].[Brand] OFF
GO
SET IDENTITY_INSERT [dbo].[Cart] ON 

INSERT [dbo].[Cart] ([Id], [DateCreated], [UserId], [ProductId]) VALUES (4, CAST(N'2024-01-01T00:00:00.0000000' AS DateTime2), 1, 4)
INSERT [dbo].[Cart] ([Id], [DateCreated], [UserId], [ProductId]) VALUES (5, CAST(N'2026-01-01T00:00:00.0000000' AS DateTime2), 1, 5)
SET IDENTITY_INSERT [dbo].[Cart] OFF
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([Id], [Name]) VALUES (1, N'Lacivert')
INSERT [dbo].[Color] ([Id], [Name]) VALUES (2, N'Sarı')
INSERT [dbo].[Color] ([Id], [Name]) VALUES (3, N'Siyah')
INSERT [dbo].[Color] ([Id], [Name]) VALUES (4, N'Beyaz')
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (1, N'Apple iPhone 11 Pro Maxi Phone 11 Pro Max iPhone 11 (Max 2 Line)', 1000, 1, 4, 3)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (2, N'Apple iPhone 11', 1000, 1, 2, 3)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (3, N'iPhone 11 Kırmızı Kılıf', 1000, 1, 2, 3)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (4, N'Samsung Telefon', 1000, 1, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (5, N'Samsung Telefon 1', 1000, 1, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (6, N'Huawei Telefon', 1000, 1, 2, 5)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (7, N'Xiaomi Redmi Note 10S 128 GB 6 GB Ram', 1000, 1, 3, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (8, N'Oppo Reno Telefon', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (9, N'Xiomi Telefon', 1000, 1, 2, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (10, N'Oppo Reno 5 Lite 128 GB', 1000, 1, 3, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (11, N'Huawei Telefon', 1000, 1, 4, 5)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (12, N'Apple Telefon', 1000, 1, 1, 3)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (13, N'Huawei Telefon', 1000, 1, 2, 5)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (14, N'Huawei Telefon', 1000, 1, 3, 5)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (15, N'HTC Desire 20 Pro', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (16, N'Huawei Telefon', 1000, 1, 2, 5)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (17, N'Apple Telefon', 1000, 1, 3, 3)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (18, N'HTC Telefon', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (19, N'Oppo Reno Telefon', 1000, 1, 1, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (20, N'LG Telefon', 1000, 1, 2, 4)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (21, N'Sonny Telefon', 1000, 1, 3, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (22, N'General Mobile', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (23, N'Tecno Spark Telefon', 1000, 1, 1, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (24, N'Samsung Telefon', 1000, 1, 2, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (25, N'Xiaomı Telefon', 1000, 1, 3, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (26, N'ViVo Telefon', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (27, N'Huawei Telefon', 1000, 1, 1, 5)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (28, N'Apple Telefon', 1000, 1, 2, 3)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (29, N'Samsung Telefon', 1000, 1, 3, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (30, N'LG Telefon', 1000, 1, 4, 4)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (31, N'Oppo Reno Telefon', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (32, N'Samsung Telefon', 1000, 1, 4, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (33, N'HTC Telefon', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (34, N'HTC Telefon 2', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (35, N'HTC Phone 4', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (36, N'HTC teleFON 9', 1000, 1, 2, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (37, N'Samsung Telefon', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (38, N'HTC Telefon 50', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (39, N'HTC Telefon 98', 1000, 1, 4, 11)
INSERT [dbo].[Product] ([Id], [Name], [Price], [DiscountRatio], [ColorId], [BrandId]) VALUES (40, N'HTC Telefon 100', 1000, 1, 4, 11)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [Username]) VALUES (1, N'CsUser')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Product_ProductId]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_User_UserId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Brand_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brand] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Brand_BrandId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Color_ColorId] FOREIGN KEY([ColorId])
REFERENCES [dbo].[Color] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Color_ColorId]
GO
