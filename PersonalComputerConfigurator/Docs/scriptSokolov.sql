USE [master]
GO
/****** Object:  Database [personalComputerConfiguratorDatabase]    Script Date: 20.02.2025 10:30:06 ******/
CREATE DATABASE [personalComputerConfiguratorDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'personalComputerConfiguratorDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MYSERVER\MSSQL\DATA\personalComputerConfiguratorDatabase.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'personalComputerConfiguratorDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MYSERVER\MSSQL\DATA\personalComputerConfiguratorDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [personalComputerConfiguratorDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [personalComputerConfiguratorDatabase]
GO
/****** Object:  Table [dbo].[Case]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Case](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](255) NULL,
	[FormFaktor] [varchar](50) NULL,
	[Size] [varchar](255) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_cases] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Configuration]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuration](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CaseID] [int] NULL,
	[CoolerID] [int] NULL,
	[GpuID] [int] NULL,
	[HddID] [int] NULL,
	[MotherboardID] [int] NULL,
	[ProcessorID] [int] NULL,
	[PsuID] [int] NULL,
	[SsdID] [int] NULL,
	[RamID] [int] NULL,
	[UserID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
	[ConfigPrice] [int] NULL,
 CONSTRAINT [PK_configurations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfigurationWarning]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfigurationWarning](
	[WarningID] [int] IDENTITY(1,1) NOT NULL,
	[ConfigID] [int] NOT NULL,
	[WarningText] [nvarchar](255) NULL,
 CONSTRAINT [PK_ConfigurationWarning] PRIMARY KEY CLUSTERED 
(
	[WarningID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cooler]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cooler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[Socket] [varchar](255) NULL,
	[Power] [varchar](255) NULL,
	[Type] [varchar](255) NULL,
	[Material] [varchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_coolers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DDRType]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DDRType](
	[DdrID] [int] NOT NULL,
	[DdrTypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_DDRType] PRIMARY KEY CLUSTERED 
(
	[DdrID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GPU]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GPU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
	[GpuFrequency] [varchar](50) NULL,
	[GpuBoost] [varchar](50) NULL,
	[MemorySize] [varchar](50) NULL,
	[MemoryType] [varchar](50) NULL,
	[Price] [int] NULL,
	[Tdp] [varchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
 CONSTRAINT [PK_gpu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDD]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](255) NULL,
	[Capacity] [int] NULL,
	[Speed] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_hdd] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Motherboard]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Motherboard](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Socket] [nvarchar](255) NULL,
	[RamType] [int] NOT NULL,
	[Chipset] [nvarchar](50) NULL,
	[FormFactor] [nvarchar](255) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_motherboards] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Processor]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Processor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Socket] [nvarchar](255) NULL,
	[Tdp] [nvarchar](50) NULL,
	[Frequency] [nvarchar](50) NULL,
	[Boost] [nvarchar](50) NULL,
	[Cores] [nvarchar](50) NULL,
	[Threads] [nvarchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_processors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PSU]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PSU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[PowerSupply] [varchar](50) NULL,
	[FormFactor] [varchar](50) NULL,
	[Certificate] [varchar](50) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_psu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RAM]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RAM](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[Description] [nvarchar](255) NULL,
	[Type] [int] NULL,
	[FormFactor] [nvarchar](255) NULL,
	[Capacity] [nvarchar](255) NULL,
	[Frequency] [nvarchar](255) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_ram] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SSD]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SSD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](255) NULL,
	[Capacity] [nchar](10) NULL,
	[Reading] [int] NULL,
	[Writing] [int] NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_ssd] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Password] [varchar](max) NULL,
	[Role] [int] NULL,
	[Email] [varchar](50) NULL,
	[Login] [varchar](50) NULL,
	[IsBlocked] [int] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 20.02.2025 10:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[ID] [int] NOT NULL,
	[RoleName] [varchar](50) NULL,
 CONSTRAINT [PK_userRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Case] ON 

INSERT [dbo].[Case] ([ID], [Name], [Description], [FormFaktor], [Size], [Price]) VALUES (1, N'ardor', N'ardor', N'ATX', N'120x120x120', 1000000)
SET IDENTITY_INSERT [dbo].[Case] OFF
GO
SET IDENTITY_INSERT [dbo].[Configuration] ON 

INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (2, NULL, 1, 1, 0, 2, 1, 4, 2, 1, 2, 35, NULL, NULL, 26963093)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (3, N'qwertyuio', 1, 1, 0, 3, 2, 6, 2, 1, 3, 41, NULL, CAST(N'2025-02-09T13:41:02.097' AS DateTime), 26071876)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (4, N'test', 1, 1, 0, 3, 5, 1, 1, 1, 3, 41, NULL, CAST(N'2025-02-09T13:29:29.010' AS DateTime), 24700305)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (5, N'dfcgt', 1, 1, 0, 1, 1, 4, 1, 1, 2, 41, NULL, NULL, 26963093)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (6, N'sdfgg', 1, 1, 0, 2, 2, 4, 1, 1, 3, 41, CAST(N'2025-02-07T21:36:07.220' AS DateTime), NULL, 26963093)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (7, N'', 1, 1, 0, 3, 2, 4, 1, 1, 3, 41, CAST(N'2025-02-07T21:48:07.217' AS DateTime), NULL, 26962993)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (11, N'test2', 1, 1, 0, 1, 2, 4, 1, 1, 3, 38, CAST(N'2025-02-09T21:00:44.720' AS DateTime), CAST(N'2025-02-09T21:21:20.653' AS DateTime), 27086380)
INSERT [dbo].[Configuration] ([ID], [Name], [CaseID], [CoolerID], [GpuID], [HddID], [MotherboardID], [ProcessorID], [PsuID], [SsdID], [RamID], [UserID], [CreatedAt], [UpdatedAt], [ConfigPrice]) VALUES (12, N'сборка 1', 1, 1, 0, 2, 2, 5, 2, 1, 3, 41, CAST(N'2025-02-13T22:15:02.837' AS DateTime), NULL, 28111976)
SET IDENTITY_INSERT [dbo].[Configuration] OFF
GO
SET IDENTITY_INSERT [dbo].[ConfigurationWarning] ON 

INSERT [dbo].[ConfigurationWarning] ([WarningID], [ConfigID], [WarningText]) VALUES (1, 11, N'ОЗУ (1) несовместимо с материнской платой (2)!')
SET IDENTITY_INSERT [dbo].[ConfigurationWarning] OFF
GO
SET IDENTITY_INSERT [dbo].[Cooler] ON 

INSERT [dbo].[Cooler] ([ID], [Name], [Description], [Socket], [Power], [Type], [Material], [Price]) VALUES (1, N'12334', N'sdfd', N'sdfd', N'sdfd', N'sdfd', N'sdfd', 123450)
SET IDENTITY_INSERT [dbo].[Cooler] OFF
GO
INSERT [dbo].[DDRType] ([DdrID], [DdrTypeName]) VALUES (1, N'DDR3')
INSERT [dbo].[DDRType] ([DdrID], [DdrTypeName]) VALUES (2, N'DDR4')
INSERT [dbo].[DDRType] ([DdrID], [DdrTypeName]) VALUES (3, N'DDR5')
GO
SET IDENTITY_INSERT [dbo].[GPU] ON 

INSERT [dbo].[GPU] ([ID], [Name], [Description], [GpuFrequency], [GpuBoost], [MemorySize], [MemoryType], [Price], [Tdp], [CreatedAt], [UpdatedAt]) VALUES (0, N'a', N'a', N'a', N'a', N'a', N'a', 1234, N'a', NULL, NULL)
SET IDENTITY_INSERT [dbo].[GPU] OFF
GO
SET IDENTITY_INSERT [dbo].[HDD] ON 

INSERT [dbo].[HDD] ([ID], [Name], [Description], [Capacity], [Speed], [Price]) VALUES (1, N'a', N'adf', 12, 123, 123410)
INSERT [dbo].[HDD] ([ID], [Name], [Description], [Capacity], [Speed], [Price]) VALUES (2, N'123', N'123', 123, 123, 123)
INSERT [dbo].[HDD] ([ID], [Name], [Description], [Capacity], [Speed], [Price]) VALUES (3, N'123', N'ыа', 123, 123, 23)
INSERT [dbo].[HDD] ([ID], [Name], [Description], [Capacity], [Speed], [Price]) VALUES (4, N'asdf', N'sdf', NULL, NULL, 123)
INSERT [dbo].[HDD] ([ID], [Name], [Description], [Capacity], [Speed], [Price]) VALUES (5, N'asdf', N'sdf', NULL, NULL, 123)
SET IDENTITY_INSERT [dbo].[HDD] OFF
GO
SET IDENTITY_INSERT [dbo].[Motherboard] ON 

INSERT [dbo].[Motherboard] ([ID], [Name], [Description], [Socket], [RamType], [Chipset], [FormFactor], [Price]) VALUES (1, N'ASROCK B550m2', N'ASROCK B550m', N'AM5', 2, N'B', N'', 1000000)
INSERT [dbo].[Motherboard] ([ID], [Name], [Description], [Socket], [RamType], [Chipset], [FormFactor], [Price]) VALUES (2, N'ARDOR B750M', N'test', N'test', 2, N'test', NULL, 123)
INSERT [dbo].[Motherboard] ([ID], [Name], [Description], [Socket], [RamType], [Chipset], [FormFactor], [Price]) VALUES (5, N'тест', N'тест', N'тест', 3, N'тест', N'тест', 12345)
INSERT [dbo].[Motherboard] ([ID], [Name], [Description], [Socket], [RamType], [Chipset], [FormFactor], [Price]) VALUES (6, N'еу', N'еу', N'еу', 1, N'еу', N'еу', 2345)
SET IDENTITY_INSERT [dbo].[Motherboard] OFF
GO
SET IDENTITY_INSERT [dbo].[Processor] ON 

INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (1, N'AMD Ryzen 5 5600ффф', N'AMD Ryzen 5 5600', N'AM4', N'65', N'3.5', N'4.4', N'6', N'12', 104990)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (4, N'AMD Ryzen 7 5800', N'AMD Ryzen 7 5800', N'AM4', N'105', N'3.4', N'4.6', N'8', N'16', 2379900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (5, N'AMD Ryzen 9 5900', N'AMD Ryzen 9 5900', N'AM4', N'105', N'3', N'4.7', N'12', N'24', 3529900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (6, N'AMD Ryzen 5 5600G', N'AMD Ryzen 5 5600G', N'AM4', N'65', N'3.9', N'4.4', N'6', N'12', 1489900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (7, N'AMD Ryzen 7 5700X3D ', N'AMD Ryzen 7 5700X3D ', N'AM4', N'105', N'3', N'4.1', N'8', N'16', 2199900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (8, N'AMD Ryzen 7 5800X3D', N'AMD Ryzen 7 5800X3D', N'AM4', N'105', N'3.4', N'4.5', N'8', N'16', 4699900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (9, N'AMD Ryzen 9 5950X ', N'AMD Ryzen 9 5950X ', N'AM4', N'105', N'3.4', N'4.9', N'16', N'32', 4829900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (10, N'AMD Ryzen 5 7500F', N'AMD Ryzen 5 7500F', N'AM5', N'65', N'3.7', N'5', N'6', N'12', 1799900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (11, N'AMD Ryzen 5 7600', N'AMD Ryzen 5 7600', N'AM5', N'65', N'3.8', N'5.1', N'6', N'12', 2099900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (12, N'AMD Ryzen 5 7600X', N'AMD Ryzen 5 7600X', N'AM5', N'105', N'4.7', N'5.3', N'6', N'12', 2479900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (13, N'AMD Ryzen 7 7700', N'AMD Ryzen 7 7700', N'AM5', N'65', N'3.8', N'5.3', N'8', N'16', 2849900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (14, N'AMD Ryzen 7 7700X', N'AMD Ryzen 7 7700X', N'AM5', N'105', N'4.5', N'5.4', N'8', N'16', 4049900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (15, N'AMD Ryzen 7 7800X3D', N'AMD Ryzen 7 7800X3D', N'AM5', N'120', N'4.2', N'5', N'8', N'16', 6099900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (16, N'AMD Ryzen 9 7900X ', N'AMD Ryzen 9 7900X ', N'AM5', N'170', N'4.7', N'5.6', N'12', N'24', 4799900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (17, N'AMD Ryzen 9 7900', N'AMD Ryzen 9 7900', N'AM5', N'65', N'3.7', N'5.4', N'12', N'24', 5099900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (18, N'AMD Ryzen 9 9950X', N'AMD Ryzen 9 9950X', N'AM5', N'170', N'4.3', N'5.7', N'16', N'32', 9249900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (19, N'AMD Ryzen 5 3600', N'AMD Ryzen 5 3600', N'AM4', N'65', N'3.6', N'4.2', N'6', N'12', 869900)
INSERT [dbo].[Processor] ([ID], [Name], [Description], [Socket], [Tdp], [Frequency], [Boost], [Cores], [Threads], [Price]) VALUES (25, N'text', N'text', N'am4', N'65', N'3.3', N'3.3', N'6', N'6', 89000)
SET IDENTITY_INSERT [dbo].[Processor] OFF
GO
SET IDENTITY_INSERT [dbo].[PSU] ON 

INSERT [dbo].[PSU] ([ID], [Name], [Description], [PowerSupply], [FormFactor], [Certificate], [Price]) VALUES (1, N'a', N'a', N'122', N'sd', N'asd', 1240)
INSERT [dbo].[PSU] ([ID], [Name], [Description], [PowerSupply], [FormFactor], [Certificate], [Price]) VALUES (2, N'a', N'a', N'122', N'sd', N'asd', 123)
SET IDENTITY_INSERT [dbo].[PSU] OFF
GO
SET IDENTITY_INSERT [dbo].[RAM] ON 

INSERT [dbo].[RAM] ([ID], [Name], [Description], [Type], [FormFactor], [Capacity], [Frequency], [Price]) VALUES (2, N'Patriot Viper Elite II', N'test', 1, N'test', N'12gb', N'5600', 1200000)
INSERT [dbo].[RAM] ([ID], [Name], [Description], [Type], [FormFactor], [Capacity], [Frequency], [Price]) VALUES (3, N'test2', N'test2', 2, N'test2', N'test2', N'24', 23456789)
INSERT [dbo].[RAM] ([ID], [Name], [Description], [Type], [FormFactor], [Capacity], [Frequency], [Price]) VALUES (4, N'Patriot Viper Elite II', N'Patriot Viper Elite 3', 2, N'UDIMM', N'8gb', N'2666', 109900)
INSERT [dbo].[RAM] ([ID], [Name], [Description], [Type], [FormFactor], [Capacity], [Frequency], [Price]) VALUES (5, N'test', N'test', 1, N'test', N'12', N'2666', 109900)
SET IDENTITY_INSERT [dbo].[RAM] OFF
GO
SET IDENTITY_INSERT [dbo].[SSD] ON 

INSERT [dbo].[SSD] ([ID], [Name], [Description], [Capacity], [Reading], [Writing], [Price]) VALUES (1, N'asfs', N'sdf', N'123       ', 123, 123, 234)
SET IDENTITY_INSERT [dbo].[SSD] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (1, N'Сергей', N'Петрович', N'Столбовa', N'96cae35ce8a9b0244178bf28e4966c2ce1b8385723a96a6b838858cdd6ca0a1e', 2, N'asd@mail.ru', N'asd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (4, N'', N'', N'', N'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855', NULL, N'', N'', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (5, N'Серг', N'ФЫа', N'Сомов', N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6', NULL, N'asdf@mail.ru', N'adfl', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (6, N'лупа', N'лупович', N'пупа', N'9834876dcfb05cb167a5c24953eba58c4ac89b1adf57f28f2f9d09af107ee8f0', NULL, N'ass@ass.ru', N'aaa', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (7, N'Сергей', N'Петрович', N'Cthutwff', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, N'asd@asd.ru', N'123', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (8, N'Александр', N'Сильвестрович', N'Сергеев', N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6', NULL, N'asd@asd.com', N'asd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (14, N'f', N'f', N'a', N'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', 1, N'a@la.ry', N'fa', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (16, N'asd', N'asd', N'asd', N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6', 1, N'asd', N'asd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (18, N'df', N'dd', N'df', N'9b7ecc6eeb83abf9ade10fe38865df4499be3568dcc507ae2ec3b44989cb0093', 1, N'dd@dd.ru', N'dd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (19, N'ф', N'ф', N'ф', N'70ba33708cbfb103f1a8e34afef333ba7dc021022b2d9aaa583aabb8058d8d67', 1, N'ad@ad.ru', N' ad', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (20, N'Сергей', N'Сергеевич', N'Сергеев', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, N'asda@mail.com', N'asda', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (21, N'вым', N'ваы', N'ваы', N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6', 1, N'asd@ad.ry', N'asd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (22, N'awsd', N'asdd', N'adf', N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6', 2, N'assd@ma.ry', N'asd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (23, N'asdd', N'adfd', N'asdd', N'688787d8ff144c502c7f5cffaafe2cc588d86079f9de88304c26b0cb99ce91c6', 1, N'asdf@mail.ry', N'asdd', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (28, N'Сева', N'Севавич', N'Сиванлов', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1, N'asda@as.ry', N'user', NULL)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (29, N'aa', N'aa', N'aa', N'961b6dd3ede3cb8ecbaacbd68de040cd78eb2ed5889130cceb4c49268ea4d506', 1, N'aa@aa.ru', N'aa', NULL)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (30, N'а', N'а', N'а', N'823c4eb3e895adc925a755d89cea1c6c46954c999d23604e0091788b75496159', 1, N'а', N'а', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (31, N'ф', N'ф', N'ф', N'754309a41e0df98ae2d0a8c29921e8469ee39364b67c27b317f7f56e95dbc861', 1, N'ф', N'ф', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (33, N'aff', N'aff', N'aff', N'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', 1, N'aff', N'afff', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (34, N'user', N'user', N'user', N'04f8996da763b7a969b1028ee3007569eaf3a635486ddab211d512c85b9df8fb', 2, N'user', N'user', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (35, N'u', N'u', N'u', N'0bfe935e70c321c7ca3afc75ce0d0ca2f98b5422e008bb31c00c6d7f1f1c0ad6', 2, N'u', N'u', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (36, N'CJF', N'Cjf', N'CJr', N'e98ff8ef26b24392f668896dc49ed6d78d4cdb574cab8ee2ac84af63e37a26f9', 2, N'a123@da.da', N'u', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (37, N'asa', N'as', N'as', N'1e2b0504f615b8257e831dc1146ca679292cb2f0bd2401c26bc01a9f13337786', 2, N's', N'asdf', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (38, N' Админ', N' Админ', N' Админ', N'oST6QF/GqjY/8JYeJmkT+w==:4doa0+QcdMOf2V7im2mK7KQ6OxxvIs4zd/o8LyF9XMGepnLwpf+Dr7jKtZA/EqFBeZ9dQoJ18cwgZqHWoDv6pg==', 1, N'admin@admin.ru', N'admin', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (39, N'a', N'a', N'a', N'YfLg0VtUjwyjagy8wVWmgA==:iBmhRNh/rRz+ELJ22eMC1JUjW+6cheiihOjbhLsz/PeEV0vjQRxkMJdkvKoupGEhA42TwGm9l6R9nvaXz3Lg5g==', 1, N'as@as.ry', N'asdfsdfghjhgfds', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (40, N'a', N'a', N'a', N'/yty9csDb+hoNgMUzZWhpQ==:VuZgcVMIHrCW+kvKWNrlpq5se6lydk4WKp54LJUY5Y9roy7/gukyZuSzos2DfRH2MrKgUT3ZDS28jfPVDicEow==', 1, N'A@a.rttyhuji', N'sdfghjkjhgfds', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (41, N'ЮЗЕРОВ', N'ЮЗЕРОВИЧ', N'ЮЗЕР2', N'zxEytX0kZPueRdwpDPN+pQ==:nImk4bhLEsyOHL2y8UHiXNWMH+KdFb3+uzHw62VOSAfjwNGQkQI8j4wHWF/CbZrakyygrjPB8Tf4bDk3KJKnrw==', 2, N'user@user.ru', N'user2', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (42, N'Стан', N'Станович', N'Планов', N'2t0U1o7kVucLNpuCGUf4LA==:RsoYt8DPTY3beymF5ziaJeVxTfU/oIOS6tEwAAaC1Dl6fxyt2zwNpB0rgEui00N6D32rvX7iqwdwzytvrxlmdg==', 2, N'a', N'uuuuuu', 0)
INSERT [dbo].[User] ([ID], [Name], [MiddleName], [LastName], [Password], [Role], [Email], [Login], [IsBlocked]) VALUES (43, N'd', N'd', N'd', N'YEfBMJzCgzdTBLF1zTX3qA==:f1S38pawd7I2HEY6UQknpIa6yRUyj4Vgcf5BLkANkMHvGkj2y3BK21NOEpf5v04enricLUmwyLak7go0uVmGvw==', 2, N'sad@sad', N'dddd', 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
INSERT [dbo].[UserRole] ([ID], [RoleName]) VALUES (1, N'АДМИН')
INSERT [dbo].[UserRole] ([ID], [RoleName]) VALUES (2, N'ПОЛЬЗОВАТЕЛЬ')
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_Configuration_SSD] FOREIGN KEY([SsdID])
REFERENCES [dbo].[SSD] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_Configuration_SSD]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_cases] FOREIGN KEY([CaseID])
REFERENCES [dbo].[Case] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_cases]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_coolers] FOREIGN KEY([CoolerID])
REFERENCES [dbo].[Cooler] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_coolers]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_gpu] FOREIGN KEY([GpuID])
REFERENCES [dbo].[GPU] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_gpu]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_hdd] FOREIGN KEY([HddID])
REFERENCES [dbo].[HDD] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_hdd]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_motherboards] FOREIGN KEY([MotherboardID])
REFERENCES [dbo].[Motherboard] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_motherboards]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_processors] FOREIGN KEY([ProcessorID])
REFERENCES [dbo].[Processor] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_processors]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_psu] FOREIGN KEY([PsuID])
REFERENCES [dbo].[PSU] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_psu]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_ram] FOREIGN KEY([RamID])
REFERENCES [dbo].[RAM] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_ram]
GO
ALTER TABLE [dbo].[Configuration]  WITH CHECK ADD  CONSTRAINT [FK_configurations_user] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Configuration] CHECK CONSTRAINT [FK_configurations_user]
GO
ALTER TABLE [dbo].[ConfigurationWarning]  WITH CHECK ADD  CONSTRAINT [FK_ConfigurationWarning_Configuration] FOREIGN KEY([ConfigID])
REFERENCES [dbo].[Configuration] ([ID])
GO
ALTER TABLE [dbo].[ConfigurationWarning] CHECK CONSTRAINT [FK_ConfigurationWarning_Configuration]
GO
ALTER TABLE [dbo].[Motherboard]  WITH CHECK ADD  CONSTRAINT [FK_Motherboard_DDRType] FOREIGN KEY([RamType])
REFERENCES [dbo].[DDRType] ([DdrID])
GO
ALTER TABLE [dbo].[Motherboard] CHECK CONSTRAINT [FK_Motherboard_DDRType]
GO
ALTER TABLE [dbo].[RAM]  WITH CHECK ADD  CONSTRAINT [FK_RAM_DDRType] FOREIGN KEY([Type])
REFERENCES [dbo].[DDRType] ([DdrID])
GO
ALTER TABLE [dbo].[RAM] CHECK CONSTRAINT [FK_RAM_DDRType]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_user_userRole] FOREIGN KEY([Role])
REFERENCES [dbo].[UserRole] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_user_userRole]
GO
USE [master]
GO
ALTER DATABASE [personalComputerConfiguratorDatabase] SET  READ_WRITE 
GO
