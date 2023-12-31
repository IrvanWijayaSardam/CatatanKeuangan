USE [master]
GO
/****** Object:  Database [db_catatan_keuangan]    Script Date: 30/06/2023 22:31:22 ******/
CREATE DATABASE [db_catatan_keuangan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_catatan_keuangan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_catatan_keuangan.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_catatan_keuangan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_catatan_keuangan_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_catatan_keuangan] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_catatan_keuangan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_catatan_keuangan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_catatan_keuangan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_catatan_keuangan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_catatan_keuangan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_catatan_keuangan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_catatan_keuangan] SET  MULTI_USER 
GO
ALTER DATABASE [db_catatan_keuangan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_catatan_keuangan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_catatan_keuangan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_catatan_keuangan] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_catatan_keuangan] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_catatan_keuangan]
GO
/****** Object:  Table [dbo].[tb_trx]    Script Date: 30/06/2023 22:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_trx](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[tgl_trx] [varchar](100) NOT NULL,
	[jumlah_trx] [varchar](100) NOT NULL,
	[tipe_trx] [varchar](100) NOT NULL,
	[deskripsi] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_user]    Script Date: 30/06/2023 22:31:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[nama] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [db_catatan_keuangan] SET  READ_WRITE 
GO
