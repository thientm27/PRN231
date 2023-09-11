USE [master]
GO
/****** Object:  Database [FUCarRentingManagement]    Script Date: 9/4/2023 10:40:16 PM ******/
CREATE DATABASE [FUCarRentingManagement]
GO
USE [FUCarRentingManagement]
GO

/****** Object:  Table [dbo].[CarInformation]    Script Date: 9/4/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarInformation](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[CarName] [nvarchar](50) NOT NULL,
	[CarDescription] [nvarchar](220) NULL,
	[NumberOfDoors] [int] NULL,
	[SeatingCapacity] [int] NULL,
	[FuelType] [nvarchar](20) NULL,
	[Year] [int] NULL,
	[ManufacturerID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[CarStatus] [tinyint] NULL,
	[CarRentingPricePerDay] [money] NULL,
 CONSTRAINT [PK_CarInformation] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 9/4/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(3,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[Telephone] [nvarchar](12) NULL,
	[Email] [nvarchar](50) NOT NULL Unique,
	[CustomerBirthday] [date] NULL,
	[CustomerStatus] [tinyint] NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 9/4/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerID] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[ManufacturerCountry] [nchar](10) NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[ManufacturerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentingDetail]    Script Date: 9/4/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentingDetail](
	[RentingTransactionID] [int] NOT NULL,
	[CarID] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_RentingDetail] PRIMARY KEY CLUSTERED 
(
	[RentingTransactionID] ASC,
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentingTransaction]    Script Date: 9/4/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentingTransaction](
	[RentingTransationID] [int] NOT NULL,
	[RentingDate] [date] NULL,
	[TotalPrice] [money] NULL,
	[CustomerID] [int] NOT NULL,
	[RentingStatus] [tinyint] NULL,
 CONSTRAINT [PK_RentingTransaction] PRIMARY KEY CLUSTERED 
(
	[RentingTransationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 9/4/2023 10:40:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](50) NOT NULL,
	[SupplierDescription] [nvarchar](250) NULL,
	[SupplierAddress] [nvarchar](80) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CarInformation] ON 
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (1, N'Toyota Camry', N'The Toyota Camry is a popular mid-size sedan known for its reliability, comfort.', 4, 5, N'Gasoline ', 2021, 1, 3, 1, 200000.0000)
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (2, N'Toyota Prius', N'The Toyota Prius is a popular hybrid electric vehicle.', 4, 5, N'Electricity', 2022, 1, 3, 1, 300000.0000)
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (3, N'Volkswagen Golf', N'Compact hatchback known for its versatility, performance, high-quality interior.', 4, 7, N'Electricity', 2022, 4, 4, 1, 400000.0000)
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (4, N'Volkswagen ID.4', N'An all-electric compact SUV designed for modern urban life. ', 2, 4, N'Electricity', 2023, 4, 4, 1, 400000.0000)
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (5, N'Volkswagen Touareg', N'A full-size luxury SUV with sophisticated styling, advanced technology.', 4, 5, N'Gasoline ', 2022, 4, 4, 1, 500000.0000)
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (6, N'BMW M Series', N'Exceptional performance, precise handling, and aggressive styling', 4, 7, N'Electricity', 2022, 2, 4, 1, 300000.0000)
GO
INSERT [dbo].[CarInformation] ([CarID], [CarName], [CarDescription], [NumberOfDoors], [SeatingCapacity], [FuelType], [Year], [ManufacturerID], [SupplierID], [CarStatus], [CarRentingPricePerDay]) VALUES (9, N'BMW X7', N'It provides a premium driving experience and can accommodate up to 7.', 4, 7, N'Gasoline ', 2022, 2, 4, 1, 400000.0000)
GO
SET IDENTITY_INSERT [dbo].[CarInformation] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Telephone], [Email], [CustomerBirthday], [CustomerStatus], [Password]) VALUES (3, N'Emily Johnson', N'0903996676', N'EmilyJohnson@FUCarRenting.org', CAST(N'1990-12-12' AS Date), 1, N'@1')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Telephone], [Email], [CustomerBirthday], [CustomerStatus], [Password]) VALUES (4, N'Alexander Williams', N'0907638446', N'AlexanderWilliams@FUCarRenting.org', CAST(N'1991-11-01' AS Date), 1, N'@1')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Telephone], [Email], [CustomerBirthday], [CustomerStatus], [Password]) VALUES (5, N'Sophia Davis', N'0903334522', N'SophiaDavis@FUCarRenting.org', CAST(N'1992-09-13' AS Date), 1, N'@1')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Telephone], [Email], [CustomerBirthday], [CustomerStatus], [Password]) VALUES (6, N'Benjamin Thompson', N'0903987645', N'BenjaminThompson@FUCarRenting.org', CAST(N'1993-10-24' AS Date), 1, N'@1')
GO
INSERT [dbo].[Customer] ([CustomerID], [CustomerName], [Telephone], [Email], [CustomerBirthday], [CustomerStatus], [Password]) VALUES (7, N'Charlotte Evans', N'0903998933', N'CharlotteEvansCharlotteEvans@FUCarRenting.org', CAST(N'1994-06-09' AS Date), 0, N'@1')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 
GO
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName], [Description], [ManufacturerCountry]) VALUES (1, N'Toyota', N'Toyota is a renowned Japanese automotive manufacturer that has established itself as one of the world''s largest automakers. With a history spanning over 80 years, Toyota is recognized for its commitment to quality, reliability, and innovation.', N'Japan     ')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName], [Description], [ManufacturerCountry]) VALUES (2, N'BMW', N'BMW, short for Bayerische Motoren Werke, is a prestigious German automotive manufacturer renowned for its luxury vehicles and high-performance automobiles.', N'German    ')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName], [Description], [ManufacturerCountry]) VALUES (3, N'Ford', N'Ford is an American automotive manufacturer known for its long-standing history and contribution to the automobile industry. Founded by Henry Ford in 1903, the company has played a pivotal role in making cars accessible to the masses.', N'American  ')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName], [Description], [ManufacturerCountry]) VALUES (4, N'Volkswagen', N'Volkswagen, often referred to as VW, is a prominent German automobile manufacturer known for its wide range of vehicles, quality craftsmanship, and innovative engineering. Founded in 1937, Volkswagen has become one of the largest brands globally.', N'German    ')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName], [Description], [ManufacturerCountry]) VALUES (5, N'Honda', N'Honda is a renowned Japanese automotive manufacturer known for its commitment to quality, reliability, and innovative engineering. Founded in 1948, Honda has established itself as a global leader in producing a wide range of vehicles.', N'Japan     ')
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
INSERT [dbo].[RentingDetail] ([RentingTransactionID], [CarID], [StartDate], [EndDate], [Price]) VALUES (1, 4, CAST(N'2023-09-10' AS Date), CAST(N'2023-09-13' AS Date), 400000.0000)
GO
INSERT [dbo].[RentingDetail] ([RentingTransactionID], [CarID], [StartDate], [EndDate], [Price]) VALUES (1, 5, CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), 500000.0000)
GO
INSERT [dbo].[RentingDetail] ([RentingTransactionID], [CarID], [StartDate], [EndDate], [Price]) VALUES (2, 2, CAST(N'2023-09-15' AS Date), CAST(N'2023-09-16' AS Date), 300000.0000)
GO
INSERT [dbo].[RentingDetail] ([RentingTransactionID], [CarID], [StartDate], [EndDate], [Price]) VALUES (2, 5, CAST(N'2023-09-20' AS Date), CAST(N'2023-09-20' AS Date), 500000.0000)
GO
INSERT [dbo].[RentingTransaction] ([RentingTransationID], [RentingDate], [TotalPrice], [CustomerID], [RentingStatus]) VALUES (1, CAST(N'2023-09-01' AS Date), 1900000.0000, 4, 1)
GO
INSERT [dbo].[RentingTransaction] ([RentingTransationID], [RentingDate], [TotalPrice], [CustomerID], [RentingStatus]) VALUES (2, CAST(N'2023-09-01' AS Date), 1100000.0000, 4, 1)
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (1, N'Aisin Asia Pacific Co., Ltd.', N'Specializes in manufacturing automotive interior components such as seats, door trims, and carpeting.', N'Ho Chi Minh City, Viet Nam')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (2, N'Denso Vietnam Co., Ltd.', N'Supplies a wide range of electrical and electronic automotive components to Toyota, including engine control units, sensors, and air conditioning systems', N'Da Nang, Viet Nam')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (3, N'Toyota Tsusho Vietnam Co., Ltd.', N'Provides a range of services including trading, logistics, and distribution of automotive parts and components for Toyota in Vietnam', N'Ho Chi Minh City, Viet Nam')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (4, N'Bosch Vietnam Co., Ltd.', N'Bosch is a global supplier of automotive parts and technology. They provide components such as fuel injection systems, braking systems, and electrical components for vehicles.', N'Hanoi, Viet Nam')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (5, N'Lear Corporation Vietnam Co., Ltd.', N'Lear specializes in manufacturing automotive seating systems and electronic components. ', N'Quy Nhon, Viet Nam')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (6, N'VinFast', N'VinFast is an automotive manufacturer based in Vietnam. BMW and VinFast have collaborated on joint projects, and VinFast may supply certain components for BMW vehicles produced in Vietnam.', N'Ho Chi Minh City, Viet Nam')
GO
INSERT [dbo].[Supplier] ([SupplierID], [SupplierName], [SupplierDescription], [SupplierAddress]) VALUES (7, N'Schaeffler (Vietnam) Co., Ltd.', N'Schaeffler is a supplier of precision-engineered products, particularly in the areas of automotive drivetrain and engine components. ', N'Ho Chi Minh City, Viet Nam')
GO
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
ALTER TABLE [dbo].[CarInformation]  WITH CHECK ADD  CONSTRAINT [FK_CarInformation_Manufacturer] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[Manufacturer] ([ManufacturerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarInformation] CHECK CONSTRAINT [FK_CarInformation_Manufacturer]
GO
ALTER TABLE [dbo].[CarInformation]  WITH CHECK ADD  CONSTRAINT [FK_CarInformation_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Supplier] ([SupplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarInformation] CHECK CONSTRAINT [FK_CarInformation_Supplier]
GO
ALTER TABLE [dbo].[RentingDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentingDetail_CarInformation] FOREIGN KEY([CarID])
REFERENCES [dbo].[CarInformation] ([CarID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentingDetail] CHECK CONSTRAINT [FK_RentingDetail_CarInformation]
GO
ALTER TABLE [dbo].[RentingDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentingDetail_RentingTransaction] FOREIGN KEY([RentingTransactionID])
REFERENCES [dbo].[RentingTransaction] ([RentingTransationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentingDetail] CHECK CONSTRAINT [FK_RentingDetail_RentingTransaction]
GO
ALTER TABLE [dbo].[RentingTransaction]  WITH CHECK ADD  CONSTRAINT [FK_RentingTransaction_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentingTransaction] CHECK CONSTRAINT [FK_RentingTransaction_Customer]
GO
USE [master]
GO
ALTER DATABASE [FUCarRentingManagement] SET  READ_WRITE 
GO
