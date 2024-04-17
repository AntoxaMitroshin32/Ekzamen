USE [BD_apteki]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 17.04.2024 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] NOT NULL,
	[Фамилия] [varchar](50) NULL,
	[Номер заказа] [varchar](50) NULL,
	[Дата заказа] [date] NULL,
	[Адрес проживания] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Corzina]    Script Date: 17.04.2024 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corzina](
	[ID] [nchar](10) NULL,
	[Номер заказа] [nchar](10) NULL,
	[Название товара] [nchar](10) NULL,
	[Цена] [nchar](10) NULL,
	[Тип заказа] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sotrudniki]    Script Date: 17.04.2024 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sotrudniki](
	[ID] [int] NOT NULL,
	[Фамилия] [varchar](50) NULL,
	[Имя] [varchar](50) NULL,
	[Отчество] [varchar](50) NULL,
	[Адрес проживания] [varchar](max) NULL,
	[Должность] [varchar](50) NULL,
 CONSTRAINT [PK_Sotrudniki] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tovar]    Script Date: 17.04.2024 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tovar](
	[ID] [int] NOT NULL,
	[Наименование товара] [varchar](50) NULL,
	[Описание товара] [varchar](max) NULL,
	[Цена] [money] NULL,
	[Производитель] [varchar](50) NULL,
	[Количество на складе] [varchar](max) NULL,
 CONSTRAINT [PK_Tovar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zakaz]    Script Date: 17.04.2024 15:23:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zakaz](
	[ID] [int] NOT NULL,
	[Номер заказа] [varchar](50) NULL,
	[Дата заказа] [date] NULL,
	[Состав заказа] [varchar](50) NULL,
	[Итоговая сумма] [money] NULL,
	[Пункт выдачи] [varchar](max) NULL,
 CONSTRAINT [PK_Zakaz] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Sotrudniki] FOREIGN KEY([ID])
REFERENCES [dbo].[Sotrudniki] ([ID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Sotrudniki]
GO
ALTER TABLE [dbo].[Zakaz]  WITH CHECK ADD  CONSTRAINT [FK_Zakaz_Client] FOREIGN KEY([ID])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Zakaz] CHECK CONSTRAINT [FK_Zakaz_Client]
GO
