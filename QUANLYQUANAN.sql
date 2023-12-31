USE [master]
GO
/****** Object:  Database [QUANLYQUANAN]    Script Date: 7/16/2023 2:41:38 PM ******/
CREATE DATABASE [QUANLYQUANAN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYQUANAN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.PHUC\MSSQL\DATA\QUANLYQUANAN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYQUANAN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.PHUC\MSSQL\DATA\QUANLYQUANAN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QUANLYQUANAN] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYQUANAN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYQUANAN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYQUANAN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYQUANAN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYQUANAN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYQUANAN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYQUANAN] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYQUANAN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYQUANAN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYQUANAN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYQUANAN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYQUANAN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYQUANAN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYQUANAN', N'ON'
GO
ALTER DATABASE [QUANLYQUANAN] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUANLYQUANAN] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUANLYQUANAN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](1000) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NULL,
	[status] [int] NOT NULL,
	[Total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfor]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[price] [float] NOT NULL,
	[idCategory] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'69') FOR [Password]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'Hello World!') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfor] ADD  DEFAULT ((1)) FOR [count]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[Food] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Chưa đặt tên') FOR [name]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfor]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfor]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_Checkout]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Checkout]
@idTable int
as
begin
	update dbo.TableFood set status = N'Trống' where id = @idTable
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBillByDatetime]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_GetBillByDatetime]
	@d1 datetime,@d2 datetime
	as
	begin
		select b.id as N'Id', b.DateCheckOut as N'Date check out', tf.name as N'Name table', b.Total as N'Total' 
		from dbo.Bill as b,dbo.TableFood as tf 
		where b.idTable = tf.id and b.DateCheckOut <= @d2 and b.DateCheckOut >= @d1
	end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBillInMonth]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_GetBillInMonth]
@month int,@year int
as
begin
	select distinct b.id as 'Id', tf.name as N'Name table', b.DateCheckOut as N'Date check out', b.Total from Bill as b, tablefood as tf where b.idTable = tf.id and MONTH(b.DateCheckOut) = @month and year(b.DateCheckOut) = @year
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_GetTableList]
as select * from dbo.TableFood
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_InsertBill]
@idTable int
as
begin
	insert dbo.Bill(idTable)
	values(@idTable)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfor]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_InsertBillInfor]
@idBill int,@idFood int,@count int
as
begin
	declare @isExitsBillInfo int
	declare @foodCount int =1

	select @isExitsBillInfo = id, @foodCount = count from dbo.BillInfor where idBill = @idBill and idFood = @idFood

	if(@isExitsBillInfo>0)
	begin
		declare @newCount int = @foodCount + @count
		if(@newCount>0)
			update dbo.BillInfor set count  = @foodCount + @count where idFood = @idFood
		Else
			delete dbo.BillInfor where idBill = @idBill and idFood = @idFood
	end
	else
	begin
		insert dbo.BillInfor
		(idBill,idFood,count)
		Values (@idBill,@idFood,@count)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]
@username nvarchar(100),@password nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @username and Password = @password
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ReportDemo]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_ReportDemo]
@thang int,@year int
as
begin
	declare @tongtien int
	select @tongtien = Sum( bi.count * f.price) from BillInfor as bi, Food as f ,Bill as b
	where MONTH(b.DateCheckIn) = @thang and bi.idFood = f.id and YEAR(b.DateCheckIn) = @year
	select b.id, b.idTable, @tongtien as TongTien, b.DateCheckIn from dbo.Bill as b
	where  MONTH(DateCheckIn) = @thang and YEAR(b.DateCheckIn) = @year
end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 7/16/2023 2:41:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_UpdateAccount]
@displayname nvarchar(50),@password nvarchar(50),@username nvarchar(50)
as
begin
	update Account set DisplayName = @displayname , Password = @password where UserName = @username
end
GO
USE [master]
GO
ALTER DATABASE [QUANLYQUANAN] SET  READ_WRITE 
GO
