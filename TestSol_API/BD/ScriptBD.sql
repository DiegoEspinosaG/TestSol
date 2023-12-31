USE [TestSol]
GO
/****** Object:  Table [dbo].[Areas]    Script Date: 23/11/2023 04:22:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Areas](
	[AreaID] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NULL,
 CONSTRAINT [PK_Areas] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 23/11/2023 04:22:44 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoID] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[ApellidoPaterno] [nvarchar](50) NULL,
	[ApellidoMaterno] [nvarchar](50) NULL,
	[AreaID] [nvarchar](50) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Sueldo] [float] NOT NULL,
	[CreadoPor] [nvarchar](50) NULL,
	[FechaAlta] [datetime] NULL,
	[ModificadoPor] [nvarchar](50) NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Areas] ([AreaID], [Area]) VALUES (N'abc', N'RH')
INSERT [dbo].[Areas] ([AreaID], [Area]) VALUES (N'def', N'Sistemas')
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [AreaID], [FechaNacimiento], [Sueldo], [CreadoPor], [FechaAlta], [ModificadoPor], [FechaModificacion]) VALUES (N'4f9e7f', N'ad', N'ad', N'ad', N'abc', CAST(N'2023-11-23T04:11:22.767' AS DateTime), 12, NULL, NULL, N'Sistemas', CAST(N'2023-11-23T04:11:38.483' AS DateTime))
INSERT [dbo].[Empleados] ([EmpleadoID], [Nombre], [ApellidoPaterno], [ApellidoMaterno], [AreaID], [FechaNacimiento], [Sueldo], [CreadoPor], [FechaAlta], [ModificadoPor], [FechaModificacion]) VALUES (N'abc', N'string', N'string', N'string', N'abc', CAST(N'2023-11-23T07:56:39.687' AS DateTime), 0, N'Sistemas', CAST(N'2023-11-23T01:56:49.863' AS DateTime), NULL, NULL)
GO
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [DF_Empleados_Sueldo]  DEFAULT ((0)) FOR [Sueldo]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Areas] FOREIGN KEY([AreaID])
REFERENCES [dbo].[Areas] ([AreaID])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Areas]
GO
