USE [master]
GO
/****** Object:  Database [DB_proyect]    Script Date: 24/02/2024 02:18:14 p. m. ******/
CREATE DATABASE [DB_proyect]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_proyect', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_proyect.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_proyect_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DB_proyect_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_proyect] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_proyect].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_proyect] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_proyect] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_proyect] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_proyect] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_proyect] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_proyect] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_proyect] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_proyect] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_proyect] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_proyect] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_proyect] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_proyect] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_proyect] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_proyect] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_proyect] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_proyect] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_proyect] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_proyect] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_proyect] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_proyect] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_proyect] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_proyect] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_proyect] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_proyect] SET  MULTI_USER 
GO
ALTER DATABASE [DB_proyect] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_proyect] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_proyect] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_proyect] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_proyect] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_proyect] SET QUERY_STORE = OFF
GO
USE [DB_proyect]
GO
/****** Object:  User [userPT]    Script Date: 24/02/2024 02:18:16 p. m. ******/
CREATE USER [userPT] FOR LOGIN [userPT] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tb_Alumno]    Script Date: 24/02/2024 02:18:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Alumno](
	[pk_alumno] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ap_paterno] [varchar](50) NOT NULL,
	[ap_materno] [varchar](50) NOT NULL,
	[matricula_alumno] [varchar](50) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [DB_proyect_pk_alumno] PRIMARY KEY CLUSTERED 
(
	[pk_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_calificaciones]    Script Date: 24/02/2024 02:18:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_calificaciones](
	[pk_calificaciones] [int] IDENTITY(1,1) NOT NULL,
	[fk_maestro] [int] NULL,
	[fk_alumno] [int] NULL,
	[fk_materia] [int] NULL,
	[calificacion] [int] NULL,
	[observaciones] [varchar](150) NULL,
 CONSTRAINT [DB_proyect_pk_calificaciones] PRIMARY KEY CLUSTERED 
(
	[pk_calificaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Maestro]    Script Date: 24/02/2024 02:18:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Maestro](
	[pk_maestro] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[ap_paterno] [varchar](50) NOT NULL,
	[ap_materno] [varchar](50) NOT NULL,
	[matricula_empleado] [varchar](50) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [DB_proyect_Pk_maestro] PRIMARY KEY CLUSTERED 
(
	[pk_maestro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_materia]    Script Date: 24/02/2024 02:18:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_materia](
	[pk_materia] [int] IDENTITY(1,1) NOT NULL,
	[nombre_materia] [varchar](50) NOT NULL,
 CONSTRAINT [DB_proyect_pk_materia] PRIMARY KEY CLUSTERED 
(
	[pk_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_calificaciones]  WITH CHECK ADD  CONSTRAINT [FK_tb_calificaciones_tb_Alumno] FOREIGN KEY([fk_alumno])
REFERENCES [dbo].[tb_Alumno] ([pk_alumno])
GO
ALTER TABLE [dbo].[tb_calificaciones] CHECK CONSTRAINT [FK_tb_calificaciones_tb_Alumno]
GO
ALTER TABLE [dbo].[tb_calificaciones]  WITH CHECK ADD  CONSTRAINT [FK_tb_calificaciones_tb_Maestro] FOREIGN KEY([fk_maestro])
REFERENCES [dbo].[tb_Maestro] ([pk_maestro])
GO
ALTER TABLE [dbo].[tb_calificaciones] CHECK CONSTRAINT [FK_tb_calificaciones_tb_Maestro]
GO
ALTER TABLE [dbo].[tb_calificaciones]  WITH CHECK ADD  CONSTRAINT [FK_tb_calificaciones_tb_materia] FOREIGN KEY([fk_materia])
REFERENCES [dbo].[tb_materia] ([pk_materia])
GO
ALTER TABLE [dbo].[tb_calificaciones] CHECK CONSTRAINT [FK_tb_calificaciones_tb_materia]
GO
USE [master]
GO
ALTER DATABASE [DB_proyect] SET  READ_WRITE 
GO
