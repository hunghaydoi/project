USE [master]
GO
/****** Object:  Database [qlns]    Script Date: 4/22/2024 12:03:04 PM ******/
CREATE DATABASE [qlns]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlns', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\qlns.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlns_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\qlns_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [qlns] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlns].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlns] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlns] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlns] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlns] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlns] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlns] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qlns] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlns] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlns] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlns] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlns] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlns] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlns] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlns] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlns] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qlns] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlns] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlns] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlns] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlns] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlns] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlns] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlns] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [qlns] SET  MULTI_USER 
GO
ALTER DATABASE [qlns] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlns] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlns] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlns] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlns] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlns] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [qlns] SET QUERY_STORE = ON
GO
ALTER DATABASE [qlns] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [qlns]
GO
/****** Object:  Table [dbo].[TM_Account]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TM_Account](
	[employeeID] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[permission] [varchar](50) NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TM_Departments]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TM_Departments](
	[DepartmentID] [varchar](50) NOT NULL,
	[DepartmentName] [nvarchar](max) NULL,
 CONSTRAINT [PK_TM_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TM_EmployeeHistory]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TM_EmployeeHistory](
	[HistoryID] [varchar](50) NOT NULL,
	[EmployeeID] [varchar](50) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[DepartmentID] [varchar](50) NULL,
	[PositionID] [varchar](50) NULL,
 CONSTRAINT [PK_TM_EmployeeHistory] PRIMARY KEY CLUSTERED 
(
	[HistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TM_Employees]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TM_Employees](
	[EmployeeID] [varchar](50) NOT NULL,
	[FullName] [nvarchar](300) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[Email] [nvarchar](max) NULL,
	[DepartmentID] [varchar](100) NOT NULL,
	[PositionID] [varchar](100) NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_TM_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TM_Positions]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TM_Positions](
	[PositionID] [varchar](50) NOT NULL,
	[PositionName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[TM_Account] ([employeeID], [password], [permission]) VALUES (N'F1', N'123', N'admin')
INSERT [dbo].[TM_Account] ([employeeID], [password], [permission]) VALUES (N'F2', N'123', N'user')
GO
INSERT [dbo].[TM_Departments] ([DepartmentID], [DepartmentName]) VALUES (N'1', N'RD-IT')
INSERT [dbo].[TM_Departments] ([DepartmentID], [DepartmentName]) VALUES (N'2', N'GA')
INSERT [dbo].[TM_Departments] ([DepartmentID], [DepartmentName]) VALUES (N'3', N'PE')
INSERT [dbo].[TM_Departments] ([DepartmentID], [DepartmentName]) VALUES (N'4', N'CHO')
INSERT [dbo].[TM_Departments] ([DepartmentID], [DepartmentName]) VALUES (N'5', N'DO')
INSERT [dbo].[TM_Departments] ([DepartmentID], [DepartmentName]) VALUES (N'6', N'DOA')
GO
INSERT [dbo].[TM_EmployeeHistory] ([HistoryID], [EmployeeID], [StartDate], [EndDate], [DepartmentID], [PositionID]) VALUES (N'1', N'F1', CAST(N'2024-03-03T00:00:00.000' AS DateTime), CAST(N'2024-04-20T00:00:00.000' AS DateTime), N'1', N'1')
GO
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F1', N'Nguyễn Thị Kiều Oanh', CAST(N'2001-09-17T13:26:14.000' AS DateTime), N'Nữ', N'Thanh Xuân - Thanh Hà', N'0349623019', N'hung14dk10cntt@gmail.com', N'RD-IT', N'Staff', CAST(N'2024-04-21T13:26:14.000' AS DateTime), NULL)
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F15', N'Nguyễn Văn Hưng', CAST(N'2001-09-09T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111111', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F16', N'Nguyễn Văn Hưng', CAST(N'2001-09-10T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111112', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F17', N'Nguyễn Văn Hưng', CAST(N'2001-09-11T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111113', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F18', N'Nguyễn Văn Hưng', CAST(N'2001-09-12T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111114', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F19', N'Nguyễn Văn Hưng', CAST(N'2001-09-13T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111115', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F20', N'Nguyễn Văn Hưng', CAST(N'2001-09-14T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111116', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F21', N'Nguyễn Văn Hưng', CAST(N'2001-09-15T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111117', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F22', N'Nguyễn Văn Hưng', CAST(N'2001-09-16T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111118', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F23', N'Nguyễn Văn Hưng', CAST(N'2001-09-17T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111119', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F24', N'Nguyễn Văn Hưng', CAST(N'2001-09-18T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111120', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), CAST(N'2001-03-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TM_Employees] ([EmployeeID], [FullName], [DateOfBirth], [Gender], [Address], [PhoneNumber], [Email], [DepartmentID], [PositionID], [StartDate], [EndDate]) VALUES (N'F25', N'Nguyễn Văn Hưng', CAST(N'2001-09-19T00:00:00.000' AS DateTime), N'Nam', N'Thanh Xuân-Thanh Hà', N'1111111121', N'hung@gmail.co', N'RD-IT', N'Leader, Oparator', CAST(N'2001-02-02T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[TM_Positions] ([PositionID], [PositionName]) VALUES (N'1', N'Leader')
INSERT [dbo].[TM_Positions] ([PositionID], [PositionName]) VALUES (N'2', N'Oparator')
INSERT [dbo].[TM_Positions] ([PositionID], [PositionName]) VALUES (N'3', N'Staff')
INSERT [dbo].[TM_Positions] ([PositionID], [PositionName]) VALUES (N'4', N'Technicians')
INSERT [dbo].[TM_Positions] ([PositionID], [PositionName]) VALUES (N'5', N'Sersor')
GO
/****** Object:  StoredProcedure [dbo].[TM_Account_Check_ID]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Account_Check_ID]
		@employeeID	varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select * from TM_Account where employeeID= @employeeID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Account_Delete]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Account_Delete]
	@employeeID	varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete TM_Account where employeeID= @employeeID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Account_GetAll]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Account_GetAll]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select *from TM_Account
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Account_Insert]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Account_Insert]
	@employeeID	varchar(50)
	,@password	varchar(50)
	,@permission	varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into TM_Account values(@employeeID, @password, @permission)
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Account_Login]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Account_Login]
	@employeeID	varchar(50)
	,@password	varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from TM_Account where employeeID=@employeeID and password= @password
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Account_Update]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Account_Update]
	@employeeID	varchar(50)
	,@password	varchar(50)
	,@permission	varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update TM_Account set password= @password, permission= @permission where employeeID=@employeeID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Deparment_Update]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TM_Deparment_Update]
	@DepartmentID varchar(50)
	,@DepartmentName nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update TM_Departments set DepartmentName= @DepartmentName where DepartmentID=@DepartmentID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Department_Check_ID]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Department_Check_ID]
	@departmentID varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from TM_Departments where DepartmentID = @departmentID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Department_Delete]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TM_Department_Delete]
	@DepartmentID varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statement for procedure here
	DELETE FROM TM_Departments WHERE DepartmentID = @DepartmentID;
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Departments_GetAllData]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Departments_GetAllData]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from TM_Departments
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Departments_Insert]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Departments_Insert]
	@DepartmentID varchar(50)
	,@DepartmentName nvarchar(max)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into TM_Departments(DepartmentID,DepartmentName) values(@DepartmentID, @DepartmentName)
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Check_Employee]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Employees_Check_Employee]
	-- Add the parameters for the stored procedure here
	@EmployeeID varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmployeeID from TM_Employees where EmployeeID =@EmployeeID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Delete]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Employees_Delete]
    @EmployeeID varchar(50)
AS
BEGIN
    -- Thân của stored procedure ở đây
    DELETE FROM TM_Employees
    WHERE EmployeeID = @EmployeeID;
END

GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Insert]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: <Author,,Name>
-- Create date: <Create Date,,>
-- Description: <Description,,>
-- =============================================
create PROCEDURE [dbo].[TM_Employees_Insert]
    @EmployeeID varchar(50),
    @FullName nvarchar(300),
    @DateOfBirth datetime,
    @Gender nvarchar(50),
    @Address nvarchar(MAX),
    @PhoneNumber varchar(10),
    @Email nvarchar(MAX),
    @DepartmentID varchar(100),
    @PositionID varchar(100),
    @StartDate datetime,
    @EndDate datetime
AS
BEGIN
    -- Thân của stored procedure ở đây
    INSERT INTO TM_Employees (EmployeeID, FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, DepartmentID, PositionID, StartDate, EndDate)
    VALUES (@EmployeeID, @FullName, @DateOfBirth, @Gender, @Address, @PhoneNumber, @Email, @DepartmentID, @PositionID, @StartDate, @EndDate);
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Search_Employee]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[TM_Employees_Search_Employee]
	@EmployeeID varchar(50)
	--,
 --   --@FullName nvarchar(300),
 --   --@Gender nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
	SELECT * FROM TM_Employees WHERE EmployeeID LIKE '%' + @EmployeeID + '%';
	--SELECT * FROM TM_Employees WHERE FullName LIKE '%' + @FullName + '%';
	--SELECT * FROM TM_Employees WHERE Gender LIKE '%' + @Gender + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Search_FullName]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[TM_Employees_Search_FullName]
	
    @FullName nvarchar(300)
	--,
 --   @Gender nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
	SELECT * FROM TM_Employees WHERE FullName LIKE '%' + @FullName + '%';
	--SELECT * FROM TM_Employees WHERE Gender LIKE '%' + @Gender + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Search_Gender]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[TM_Employees_Search_Gender]
	
   
    @Gender nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
	SELECT * FROM TM_Employees WHERE Gender LIKE '%' + @Gender + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Employees_Update]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Employees_Update]
    @EmployeeID varchar(50),
    @FullName nvarchar(300),
    @DateOfBirth datetime,
    @Gender nvarchar(50),
    @Address nvarchar(MAX),
    @PhoneNumber varchar(10),
    @Email nvarchar(MAX),
    @DepartmentID varchar(100),
    @PositionID varchar(100),
    @StartDate datetime,
    @EndDate datetime
AS
BEGIN
    -- Thân của stored procedure ở đây
    UPDATE TM_Employees
    SET FullName = @FullName,
        DateOfBirth = @DateOfBirth,
        Gender = @Gender,
        Address = @Address,
        PhoneNumber = @PhoneNumber,
        Email = @Email,
        DepartmentID = @DepartmentID,
        PositionID = @PositionID,
        StartDate = @StartDate,
        EndDate = @EndDate
    WHERE EmployeeID = @EmployeeID;
END

GO
/****** Object:  StoredProcedure [dbo].[TM_Emplyees_GetAllData]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Emplyees_GetAllData]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from TM_Employees
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Positions_Check_ID]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Positions_Check_ID]
	@positionID varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from TM_Positions where PositionID= @positionID
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Positions_Delete]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TM_Positions_Delete]
	@PositionID varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Delete statement for procedure here
	DELETE FROM TM_Positions WHERE PositionID = @PositionID;
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Positions_getAllData]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Positions_getAllData]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *from TM_Positions 
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Positions_Insert]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TM_Positions_Insert]
	@PositionID	varchar(50)
	,@PositionName	nvarchar(MAX)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into TM_Positions values(@PositionID,@PositionName)
END
GO
/****** Object:  StoredProcedure [dbo].[TM_Positions_Update]    Script Date: 4/22/2024 12:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TM_Positions_Update]
	@PositionID varchar(50)
	,@PositionName nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Update statement for procedure here
	UPDATE TM_Positions SET PositionName = @PositionName WHERE PositionID = @PositionID;
END
GO
USE [master]
GO
ALTER DATABASE [qlns] SET  READ_WRITE 
GO
