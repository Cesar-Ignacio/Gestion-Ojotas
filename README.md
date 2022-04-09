# Gestion-Ojotas
Aplicaión de escritorio para realizar consultas y recibir informacion sobre los productos.

## Vistas
[![Chancletas-Microsoft-Visual-Studio-09-04-2022-0-15-43.png](https://i.postimg.cc/yNfPQSrk/Chancletas-Microsoft-Visual-Studio-09-04-2022-0-15-43.png)](https://postimg.cc/PLwYNNHj)
[![Chancletas-Microsoft-Visual-Studio-09-04-2022-0-15-55.png](https://i.postimg.cc/MKyYkLFk/Chancletas-Microsoft-Visual-Studio-09-04-2022-0-15-55.png)](https://postimg.cc/XpY5dsWx)
[![Chancletas-Microsoft-Visual-Studio-09-04-2022-0-16-02.png](https://i.postimg.cc/VNHqBPdt/Chancletas-Microsoft-Visual-Studio-09-04-2022-0-16-02.png)](https://postimg.cc/t1WnpfdR)
[![Chancletas-Microsoft-Visual-Studio-09-04-2022-0-16-11.png](https://i.postimg.cc/Wb60YkdT/Chancletas-Microsoft-Visual-Studio-09-04-2022-0-16-11.png)](https://postimg.cc/fJy3Jk7r)
[![Chancletas-Microsoft-Visual-Studio-09-04-2022-0-16-16.png](https://i.postimg.cc/xd7mNG4y/Chancletas-Microsoft-Visual-Studio-09-04-2022-0-16-16.png)](https://postimg.cc/v1rTpnMc)

## Base de Datos
La aplicación esta relacionada con una base de datos.

### DER

[![Untitled-Diagram-drawio-1.png](https://i.postimg.cc/bvksBXvW/Untitled-Diagram-drawio-1.png)](https://postimg.cc/qtBJN5yx)

### Script de la base de datos utilizada
```sql
USE [master]
GO
/****** Object:  Database [Chanclas]    Script Date: 09/04/2022 1:13:00 ******/
CREATE DATABASE [Chanclas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Chanclas', FILENAME = N'C:\DRIVERS\Chanclas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Chanclas_log', FILENAME = N'C:\DRIVERS\Chanclas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Chanclas] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Chanclas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Chanclas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Chanclas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Chanclas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Chanclas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Chanclas] SET ARITHABORT OFF 
GO
ALTER DATABASE [Chanclas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Chanclas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Chanclas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Chanclas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Chanclas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Chanclas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Chanclas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Chanclas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Chanclas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Chanclas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Chanclas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Chanclas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Chanclas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Chanclas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Chanclas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Chanclas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Chanclas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Chanclas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Chanclas] SET  MULTI_USER 
GO
ALTER DATABASE [Chanclas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Chanclas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Chanclas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Chanclas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Chanclas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Chanclas] SET QUERY_STORE = OFF
GO
USE [Chanclas]
GO
/****** Object:  Table [dbo].[Chancletas]    Script Date: 09/04/2022 1:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chancletas](
	[IdColor] [varchar](10) NOT NULL,
	[Talle] [nchar](10) NOT NULL,
	[CodMarca] [varchar](10) NOT NULL,
	[CantidadPares] [int] NULL,
 CONSTRAINT [PK_Chancletas] PRIMARY KEY CLUSTERED 
(
	[IdColor] ASC,
	[Talle] ASC,
	[CodMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 09/04/2022 1:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colores](
	[IdColor] [varchar](10) NOT NULL,
	[NombreColor] [varchar](20) NULL,
 CONSTRAINT [PK_Colores] PRIMARY KEY CLUSTERED 
(
	[IdColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 09/04/2022 1:13:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[CodMarca] [varchar](10) NOT NULL,
	[NombreMarca] [varchar](20) NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[CodMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chancletas] ([IdColor], [Talle], [CodMarca], [CantidadPares]) VALUES (N'col01', N'31        ', N'mar02', 2)
INSERT [dbo].[Chancletas] ([IdColor], [Talle], [CodMarca], [CantidadPares]) VALUES (N'col01', N'34        ', N'mar02', 4)
INSERT [dbo].[Chancletas] ([IdColor], [Talle], [CodMarca], [CantidadPares]) VALUES (N'col02', N'25        ', N'mar01', 6)
INSERT [dbo].[Chancletas] ([IdColor], [Talle], [CodMarca], [CantidadPares]) VALUES (N'col03', N'30        ', N'mar02', 5)
INSERT [dbo].[Chancletas] ([IdColor], [Talle], [CodMarca], [CantidadPares]) VALUES (N'col04', N'30        ', N'mar02', 5)
INSERT [dbo].[Chancletas] ([IdColor], [Talle], [CodMarca], [CantidadPares]) VALUES (N'col04', N'41        ', N'mar01', 7)
GO
INSERT [dbo].[Colores] ([IdColor], [NombreColor]) VALUES (N'col01', N'Rojo')
INSERT [dbo].[Colores] ([IdColor], [NombreColor]) VALUES (N'col02', N'Negro')
INSERT [dbo].[Colores] ([IdColor], [NombreColor]) VALUES (N'col03', N'Blanco')
INSERT [dbo].[Colores] ([IdColor], [NombreColor]) VALUES (N'col04', N'Rosa')
GO
INSERT [dbo].[Marcas] ([CodMarca], [NombreMarca]) VALUES (N'mar01', N'NIKE')
INSERT [dbo].[Marcas] ([CodMarca], [NombreMarca]) VALUES (N'mar02', N'NEW BALANCE')
GO
ALTER TABLE [dbo].[Chancletas]  WITH CHECK ADD  CONSTRAINT [FK_Chancletas_Colores] FOREIGN KEY([IdColor])
REFERENCES [dbo].[Colores] ([IdColor])
GO
ALTER TABLE [dbo].[Chancletas] CHECK CONSTRAINT [FK_Chancletas_Colores]
GO
ALTER TABLE [dbo].[Chancletas]  WITH CHECK ADD  CONSTRAINT [FK_Chancletas_Marcas] FOREIGN KEY([CodMarca])
REFERENCES [dbo].[Marcas] ([CodMarca])
GO
ALTER TABLE [dbo].[Chancletas] CHECK CONSTRAINT [FK_Chancletas_Marcas]
GO
USE [master]
GO
ALTER DATABASE [Chanclas] SET  READ_WRITE 
GO

```
