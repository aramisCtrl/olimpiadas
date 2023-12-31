USE [codigo_azul]
GO
/****** Object:  Table [dbo].[alarmas]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alarmas](
	[alar_id] [int] IDENTITY(1,1) NOT NULL,
	[alar_area_id] [int] NULL,
	[alar_suce_id] [int] NULL,
	[alar_fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[alar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[area]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[area](
	[area_id] [int] IDENTITY(1,1) NOT NULL,
	[area_descripcion] [varchar](255) NULL,
	[area_alarma_sala_id] [int] NULL,
	[area_alarma_texto] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[area_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ciudad]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ciudad](
	[ciud_id] [int] IDENTITY(1,1) NOT NULL,
	[ciud_descripcion] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[obra_social]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[obra_social](
	[obso_id] [int] IDENTITY(1,1) NOT NULL,
	[obso_descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[obso_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paciente]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paciente](
	[paci_id] [int] IDENTITY(1,1) NOT NULL,
	[paci_nombre] [varchar](255) NULL,
	[paci_apellido] [varchar](255) NULL,
	[paci_dni] [int] NULL,
	[paci_grupo_sanguineo] [varchar](10) NULL,
	[paci_obso_id] [int] NULL,
	[paci_ciud_id] [int] NULL,
	[paci_prov_id] [int] NULL,
	[paci_telefono] [varchar](255) NULL,
	[paci_email] [varchar](255) NULL,
	[paci_direccion] [varchar](255) NULL,
	[paci_habilitado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[paci_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[provincia]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[provincia](
	[prov_id] [int] IDENTITY(1,1) NOT NULL,
	[prov_descripcion] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[rol_id] [int] NOT NULL,
	[rol_nombre] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sala]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sala](
	[sala_id] [int] IDENTITY(1,1) NOT NULL,
	[sala_descripcion] [varchar](255) NULL,
	[sala_area_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suceso]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suceso](
	[suce_id] [int] IDENTITY(1,1) NOT NULL,
	[suce_area_id] [int] NULL,
	[suce_suti_id] [int] NULL,
	[suce_sues_id] [int] NULL,
	[suce_paci_id] [int] NULL,
	[suce_usua_id] [int] NULL,
	[suce_suor_id] [int] NULL,
	[suce_descripcion] [varchar](max) NULL,
	[suce_fecha_ini] [datetime] NULL,
	[suce_fecha_fin] [datetime] NULL,
	[suce_fecha_atendido] [datetime] NULL,
	[suce_resultado_descripcion] [varchar](max) NULL,
	[suce_paci_sala_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[suce_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suceso_estado]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suceso_estado](
	[sues_id] [int] IDENTITY(1,1) NOT NULL,
	[sues_descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[sues_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suceso_origen]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suceso_origen](
	[suor_id] [int] IDENTITY(1,1) NOT NULL,
	[suor_descripcion] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[suor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suceso_tipo]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suceso_tipo](
	[suti_id] [int] IDENTITY(1,1) NOT NULL,
	[suti_descripcion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[suti_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usua_id] [int] IDENTITY(1,1) NOT NULL,
	[usua_nombre] [nvarchar](255) NULL,
	[usua_apellido] [nvarchar](255) NULL,
	[usua_usuario] [nvarchar](100) NULL,
	[usua_contraseña] [nvarchar](100) NULL,
	[usua_rol] [int] NOT NULL,
	[usua_habilitado] [bit] NOT NULL,
	[usua_area_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[usua_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[alarmas] ON 

INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (1, 1, 1, CAST(N'2023-09-11T20:05:10.830' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (2, 2, 2, CAST(N'2023-09-11T20:05:10.830' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (3, 1, 6, CAST(N'2023-09-14T15:31:07.123' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (4, 1, 7, CAST(N'2023-09-14T15:31:21.550' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (5, 1, 8, CAST(N'2023-09-14T15:33:31.290' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (6, 2, 9, CAST(N'2023-09-14T15:40:35.843' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (7, 2, 10, CAST(N'2023-09-14T15:42:46.313' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (8, 1, 11, CAST(N'2023-09-14T15:43:00.000' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (9, 1, 12, CAST(N'2023-09-14T15:58:58.157' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (10, 1, 13, CAST(N'2023-09-14T16:12:46.933' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (11, 1, 14, CAST(N'2023-09-14T16:33:36.093' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (12, 1, 15, CAST(N'2023-09-14T17:01:01.523' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (13, 1, 16, CAST(N'2023-09-14T17:10:57.527' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (14, 1, 17, CAST(N'2023-09-14T17:48:53.943' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (15, 1, 18, CAST(N'2023-09-14T18:04:41.837' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (16, 1, 19, CAST(N'2023-09-14T18:49:42.097' AS DateTime))
INSERT [dbo].[alarmas] ([alar_id], [alar_area_id], [alar_suce_id], [alar_fecha]) VALUES (17, 1, 20, CAST(N'2023-09-14T19:46:56.233' AS DateTime))
SET IDENTITY_INSERT [dbo].[alarmas] OFF
GO
SET IDENTITY_INSERT [dbo].[area] ON 

INSERT [dbo].[area] ([area_id], [area_descripcion], [area_alarma_sala_id], [area_alarma_texto]) VALUES (1, N'Área 1', 11, N'Atencion.Codigo Azul ')
INSERT [dbo].[area] ([area_id], [area_descripcion], [area_alarma_sala_id], [area_alarma_texto]) VALUES (2, N'Área 2', 14, N'Atencion.Codigo Azul ')
INSERT [dbo].[area] ([area_id], [area_descripcion], [area_alarma_sala_id], [area_alarma_texto]) VALUES (3, N'Área 3', 17, N'Atencion.Codigo Azul ')
SET IDENTITY_INSERT [dbo].[area] OFF
GO
SET IDENTITY_INSERT [dbo].[ciudad] ON 

INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (1, N'Gualeguaychu')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (2, N'La Plata')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (3, N'San Fernando del Valle de Catamarca')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (4, N'Resistencia')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (5, N'Rawson')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (6, N'Córdoba')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (7, N'Corrientes')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (8, N'Paraná')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (9, N'Formosa')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (10, N'San Salvador de Jujuy')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (11, N'Santa Rosa')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (12, N'La Rioja')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (13, N'Mendoza')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (14, N'Posadas')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (15, N'Neuquén')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (16, N'Viedma')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (17, N'Salta')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (18, N'San Juan')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (19, N'San Luis')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (20, N'Río Gallegos')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (21, N'Santa Fe')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (22, N'Santiago del Estero')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (23, N'Ushuaia')
INSERT [dbo].[ciudad] ([ciud_id], [ciud_descripcion]) VALUES (24, N'San Miguel de Tucumán')
SET IDENTITY_INSERT [dbo].[ciudad] OFF
GO
SET IDENTITY_INSERT [dbo].[obra_social] ON 

INSERT [dbo].[obra_social] ([obso_id], [obso_descripcion]) VALUES (1, N'OSDE')
INSERT [dbo].[obra_social] ([obso_id], [obso_descripcion]) VALUES (2, N'OSECAC')
SET IDENTITY_INSERT [dbo].[obra_social] OFF
GO
SET IDENTITY_INSERT [dbo].[paciente] ON 

INSERT [dbo].[paciente] ([paci_id], [paci_nombre], [paci_apellido], [paci_dni], [paci_grupo_sanguineo], [paci_obso_id], [paci_ciud_id], [paci_prov_id], [paci_telefono], [paci_email], [paci_direccion], [paci_habilitado]) VALUES (1, N'Juan', N'Pérez', 12345678, N'A+', 1, 1, 7, N'123-456-7890', N'juan@example.com', N'Calle 123', 1)
INSERT [dbo].[paciente] ([paci_id], [paci_nombre], [paci_apellido], [paci_dni], [paci_grupo_sanguineo], [paci_obso_id], [paci_ciud_id], [paci_prov_id], [paci_telefono], [paci_email], [paci_direccion], [paci_habilitado]) VALUES (2, N'Mariana', N'Gómez', 23456789, N'B-', 1, 0, 1, N'987-654-3210', N'maria@example.com', N'Avenida 456', 1)
INSERT [dbo].[paciente] ([paci_id], [paci_nombre], [paci_apellido], [paci_dni], [paci_grupo_sanguineo], [paci_obso_id], [paci_ciud_id], [paci_prov_id], [paci_telefono], [paci_email], [paci_direccion], [paci_habilitado]) VALUES (3, N'Carlos', N'Rodríguez', 34567890, N'O+', 1, 1, 7, N'555-555-5555', N'carlos@example.com', N'Plaza Principal', 1)
INSERT [dbo].[paciente] ([paci_id], [paci_nombre], [paci_apellido], [paci_dni], [paci_grupo_sanguineo], [paci_obso_id], [paci_ciud_id], [paci_prov_id], [paci_telefono], [paci_email], [paci_direccion], [paci_habilitado]) VALUES (4, N'Laura', N'López', 45678901, N'AB+', 2, 6, 5, N'777-777-7777', N'laura@example.com', N'Calle Secundaria', 1)
INSERT [dbo].[paciente] ([paci_id], [paci_nombre], [paci_apellido], [paci_dni], [paci_grupo_sanguineo], [paci_obso_id], [paci_ciud_id], [paci_prov_id], [paci_telefono], [paci_email], [paci_direccion], [paci_habilitado]) VALUES (5, N'Patroclo', N'Martínez', 56789012, N'A-', 1, 6, 5, N'999-999-9999', N'pedro@example.com', N'Avenida Central', 1)
SET IDENTITY_INSERT [dbo].[paciente] OFF
GO
SET IDENTITY_INSERT [dbo].[provincia] ON 

INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (1, N'Buenos Aires')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (2, N'Catamarca')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (3, N'Chaco')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (4, N'Chubut')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (5, N'Córdoba')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (6, N'Corrientes')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (7, N'Entre Ríos')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (8, N'Formosa')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (9, N'Jujuy')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (10, N'La Pampa')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (11, N'La Rioja')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (12, N'Mendoza')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (13, N'Misiones')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (14, N'Neuquén')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (15, N'Río Negro')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (16, N'Salta')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (17, N'San Juan')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (18, N'San Luis')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (19, N'Santa Cruz')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (20, N'Santa Fe')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (21, N'Santiago del Estero')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (22, N'Tierra del Fuego')
INSERT [dbo].[provincia] ([prov_id], [prov_descripcion]) VALUES (23, N'Tucumán')
SET IDENTITY_INSERT [dbo].[provincia] OFF
GO
INSERT [dbo].[rol] ([rol_id], [rol_nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[rol] ([rol_id], [rol_nombre]) VALUES (2, N'Enfermero')
GO
SET IDENTITY_INSERT [dbo].[sala] ON 

INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (1, N'habitacion 1', 1)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (2, N'habitacion 2', 1)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (3, N'habitacion 3', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (4, N'habitacion 4', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (5, N'habitacion 5', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (6, N'habitacion 6', 3)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (7, N'habitacion 7', 3)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (8, N'habitacion 8', 3)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (9, N'habitacion 9', 1)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (10, N'habitacion 10', 1)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (11, N'quirofano 1', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (12, N'quirofano 2', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (13, N'quirofano 3', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (14, N'quirofano 4', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (15, N'quirofano 5', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (16, N'quirofano 6', 3)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (17, N'quirofano 7', 3)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (18, N'quirofano 8', 3)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (19, N'quirofano 9', 2)
INSERT [dbo].[sala] ([sala_id], [sala_descripcion], [sala_area_id]) VALUES (20, N'quirofano 10', 2)
SET IDENTITY_INSERT [dbo].[sala] OFF
GO
SET IDENTITY_INSERT [dbo].[suceso] ON 

INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (1, 1, 1, 1, 1, 1, 1, N'Suceso 1', CAST(N'2023-09-11T20:05:10.827' AS DateTime), NULL, CAST(N'2023-09-11T20:06:10.827' AS DateTime), N'Resultado del suceso 1', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (2, 2, 1, 2, 2, 1, 2, N'Suceso 2', CAST(N'2023-09-11T20:05:10.827' AS DateTime), NULL, CAST(N'2023-09-11T20:06:10.827' AS DateTime), N'Resultado del suceso 2', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (3, 1, 2, 1, 3, 1, 1, N'Suceso 3', CAST(N'2023-09-11T20:05:10.827' AS DateTime), NULL, CAST(N'2023-09-11T20:06:10.827' AS DateTime), N'Resultado del suceso 3', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (4, 3, 2, 2, 4, 2, 2, N'Suceso 4', CAST(N'2023-09-11T20:05:10.827' AS DateTime), NULL, CAST(N'2023-09-11T20:07:10.827' AS DateTime), N'Resultado del suceso 4', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (5, 2, 1, 3, 5, 2, 1, N'Suceso 5', CAST(N'2023-09-11T20:05:10.827' AS DateTime), NULL, CAST(N'2023-09-11T20:07:10.827' AS DateTime), N'Resultado del suceso 5', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (6, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:31:07.120' AS DateTime), NULL, CAST(N'2023-09-14T15:33:07.120' AS DateTime), N'', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (7, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:31:21.477' AS DateTime), NULL, CAST(N'2023-09-14T15:33:21.477' AS DateTime), N'', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (8, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:33:31.237' AS DateTime), NULL, NULL, N'', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (9, 2, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:40:35.840' AS DateTime), NULL, NULL, N'', NULL)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (10, 2, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:42:46.217' AS DateTime), NULL, NULL, N'', 14)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (11, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:43:00.000' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (12, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T15:58:58.147' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (13, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T16:12:46.930' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (14, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T16:33:36.090' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (15, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T17:01:01.520' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (16, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T17:10:57.453' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (17, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T17:48:53.940' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (18, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T18:04:41.833' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (19, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T18:49:42.087' AS DateTime), NULL, NULL, N'', 11)
INSERT [dbo].[suceso] ([suce_id], [suce_area_id], [suce_suti_id], [suce_sues_id], [suce_paci_id], [suce_usua_id], [suce_suor_id], [suce_descripcion], [suce_fecha_ini], [suce_fecha_fin], [suce_fecha_atendido], [suce_resultado_descripcion], [suce_paci_sala_id]) VALUES (20, 1, 2, 1, NULL, NULL, 1, N'Alarma de codigo azul generada de forma automatica por el sistema', CAST(N'2023-09-14T19:46:56.230' AS DateTime), NULL, NULL, N'', 11)
SET IDENTITY_INSERT [dbo].[suceso] OFF
GO
SET IDENTITY_INSERT [dbo].[suceso_estado] ON 

INSERT [dbo].[suceso_estado] ([sues_id], [sues_descripcion]) VALUES (1, N'Pendiente')
INSERT [dbo].[suceso_estado] ([sues_id], [sues_descripcion]) VALUES (2, N'Atendido')
INSERT [dbo].[suceso_estado] ([sues_id], [sues_descripcion]) VALUES (3, N'Finalizado')
SET IDENTITY_INSERT [dbo].[suceso_estado] OFF
GO
SET IDENTITY_INSERT [dbo].[suceso_origen] ON 

INSERT [dbo].[suceso_origen] ([suor_id], [suor_descripcion]) VALUES (1, N'Alarma Código Azul')
INSERT [dbo].[suceso_origen] ([suor_id], [suor_descripcion]) VALUES (2, N'Manual')
INSERT [dbo].[suceso_origen] ([suor_id], [suor_descripcion]) VALUES (3, N'Cama')
INSERT [dbo].[suceso_origen] ([suor_id], [suor_descripcion]) VALUES (4, N'Baño')
SET IDENTITY_INSERT [dbo].[suceso_origen] OFF
GO
SET IDENTITY_INSERT [dbo].[suceso_tipo] ON 

INSERT [dbo].[suceso_tipo] ([suti_id], [suti_descripcion]) VALUES (1, N'Normal')
INSERT [dbo].[suceso_tipo] ([suti_id], [suti_descripcion]) VALUES (2, N'Emergencia')
SET IDENTITY_INSERT [dbo].[suceso_tipo] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([usua_id], [usua_nombre], [usua_apellido], [usua_usuario], [usua_contraseña], [usua_rol], [usua_habilitado], [usua_area_id]) VALUES (1, N'Administrador', N'Administrador', N'admin', N'admin', 1, 1, 0)
INSERT [dbo].[usuarios] ([usua_id], [usua_nombre], [usua_apellido], [usua_usuario], [usua_contraseña], [usua_rol], [usua_habilitado], [usua_area_id]) VALUES (2, N'Enfermero1', N'Enfermero1', N'enfermero1', N'enfermero1', 2, 1, 1)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
ALTER TABLE [dbo].[alarmas] ADD  DEFAULT (getdate()) FOR [alar_fecha]
GO
ALTER TABLE [dbo].[paciente] ADD  CONSTRAINT [DF_paciente_paci_habilitado]  DEFAULT ((1)) FOR [paci_habilitado]
GO
ALTER TABLE [dbo].[suceso] ADD  DEFAULT (getdate()) FOR [suce_fecha_ini]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ((1)) FOR [usua_rol]
GO
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ((1)) FOR [usua_habilitado]
GO
/****** Object:  StoredProcedure [dbo].[GetPromedioRespuesta]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[GetPromedioRespuesta]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @PromedioRespuesta FLOAT;

SELECT @PromedioRespuesta = ROUND(AVG(CAST(DATEDIFF(SECOND, [suce_fecha_ini], [suce_fecha_atendido]) AS FLOAT) / 60.0),2)
    FROM [dbo].[suceso]
    WHERE [suce_fecha_ini] IS NOT NULL AND [suce_fecha_atendido] IS NOT NULL;

	    SELECT @PromedioRespuesta AS PromedioRespuestaMinutos;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetSucesosUltimas24Horas]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSucesosUltimas24Horas]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FechaActual DATETIME;
    SET @FechaActual = GETDATE();
    DECLARE @FechaInicio DATETIME;
    SET @FechaInicio = DATEADD(HOUR, -24, @FechaActual);

    SELECT se.[sues_descripcion], COUNT(s.[suce_id]) AS Cantidad
    FROM [dbo].[suceso] AS s
    INNER JOIN [dbo].[suceso_estado] AS se ON s.[suce_sues_id] = se.[sues_id]
    WHERE s.[suce_fecha_ini] >= @FechaInicio
    GROUP BY se.[sues_descripcion]
    ORDER BY se.[sues_descripcion];
END;
GO
/****** Object:  StoredProcedure [dbo].[GetSucesosUltimos7DiasPorArea]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetSucesosUltimos7DiasPorArea]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FechaHace7Dias DATETIME;
    SET @FechaHace7Dias = DATEADD(DAY, -7, GETDATE());

    SELECT a.[area_descripcion], COUNT(s.[suce_id]) AS CantidadSucesos
    FROM [dbo].[suceso] AS s
    INNER JOIN [dbo].[area] AS a ON s.[suce_area_id] = a.[area_id]
    WHERE s.[suce_fecha_ini] >= @FechaHace7Dias
    GROUP BY a.[area_descripcion]
    ORDER BY a.[area_descripcion];
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarPaciente]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarPaciente]
    @paci_id INT,
    @paci_nombre VARCHAR(255),
    @paci_apellido VARCHAR(255),
    @paci_dni VARCHAR(15),
    @paci_grupo_sanguineo VARCHAR(10),
    @paci_obso_id INT,
    @paci_ciud_id INT,
    @paci_prov_id INT,
    @paci_telefono VARCHAR(20),
    @paci_email VARCHAR(255),
    @paci_direccion VARCHAR(255),
    @paci_habilitado BIT = 1
AS
BEGIN
    UPDATE paciente
    SET
        paci_nombre = @paci_nombre,
        paci_apellido = @paci_apellido,
        paci_dni = @paci_dni,
        paci_grupo_sanguineo = @paci_grupo_sanguineo,
        paci_obso_id = @paci_obso_id,
        paci_ciud_id = @paci_ciud_id,
        paci_prov_id = @paci_prov_id,
        paci_telefono = @paci_telefono,
        paci_email = @paci_email,
        paci_direccion = @paci_direccion,
        paci_habilitado = @paci_habilitado
    WHERE
        paci_id = @paci_id;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarPaciente]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarPaciente]
    @paci_nombre VARCHAR(255),
    @paci_apellido VARCHAR(255),
    @paci_dni VARCHAR(15),
    @paci_grupo_sanguineo VARCHAR(10),
    @paci_obso_id INT,
    @paci_ciud_id INT,
    @paci_prov_id INT,
    @paci_telefono VARCHAR(20),
    @paci_email VARCHAR(255),
    @paci_direccion VARCHAR(255),
    @paci_habilitado BIT = 1
AS
BEGIN
    INSERT INTO paciente (paci_nombre, paci_apellido, paci_dni, paci_grupo_sanguineo, paci_obso_id, paci_ciud_id, paci_prov_id, paci_telefono, paci_email, paci_direccion, paci_habilitado)
    VALUES (@paci_nombre, @paci_apellido, @paci_dni, @paci_grupo_sanguineo, @paci_obso_id, @paci_ciud_id, @paci_prov_id, @paci_telefono, @paci_email, @paci_direccion, @paci_habilitado);
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertarSucesoAlarmaCodigoAzul]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertarSucesoAlarmaCodigoAzul](
	@area_id int
)
AS
BEGIN
    SET NOCOUNT ON;
	DECLARE @suti_id int = 2 --emergencia
	DECLARE @sues_id int = 1--pendiente
	DECLARE @suor_id int = 1--alarma codigo azul
	DECLARE @InsertedIDs TABLE (suce_id INT) --tabla para guarda el suce_id insertado
	DECLARE @suce_id int
	DECLARE @sala_id int

	BEGIN TRY
		select top 1 @sala_id = area_alarma_sala_id from area where area_id = @area_id 
		
		--se inserta el suceso
		INSERT INTO [dbo].[suceso]
				   ([suce_area_id]
				   ,[suce_suti_id]
				   ,[suce_sues_id]
				   ,[suce_paci_id]
				   ,[suce_usua_id]
				   ,[suce_suor_id]
				   ,[suce_descripcion]
				   ,[suce_fecha_ini]
				   ,[suce_fecha_fin]
				   ,[suce_fecha_atendido]
				   ,[suce_resultado_descripcion]
				   ,[suce_paci_sala_id])
			 OUTPUT INSERTED.suce_id INTO @InsertedIDs  --obtiene el suce_id insertado
			 VALUES
				   (@area_id
				   ,@suti_id
				   ,@sues_id
				   ,null--<suce_paci_id, int,>
				   ,null--<suce_usua_id, int,>
				   ,@suor_id
				   ,'Alarma de codigo azul generada de forma automatica por el sistema'
				   ,GETDATE()
				   ,null
				   ,null
				   ,''
				   ,@sala_id)
		select top 1 @suce_id = suce_id from @InsertedIDs

		--inserta el registro en alarmas para que lo tomen los monitores de esa area
		INSERT INTO [dbo].[alarmas]
					([alar_area_id]
					,[alar_suce_id]
					,[alar_fecha])
			VALUES
					(@area_id
					,@suce_id
					,GETDATE())

			select @suce_id as ID_INSERTADO
	END TRY
	BEGIN CATCH
		select -1 as ID_INSERTADO 
	END CATCH

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerAlarmasArea]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerAlarmasArea]
    @area_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @fecha_actual DATETIME
    SET @fecha_actual = GETDATE()

    SELECT TOP 1
        area_alarma_texto +''+ sala_descripcion as TextoAlarma
    FROM alarmas
	INNER JOIN area on area_id = alar_area_id
	INNER JOIN sala on sala_id = area_alarma_sala_id
    WHERE
        alar_area_id = @area_id
        AND alar_fecha >= DATEADD(MINUTE, -5, @fecha_actual)
    ORDER BY
        alar_fecha DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerAreas]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerAreas]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT area_id, area_descripcion FROM area
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerPacientesGrilla]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerPacientesGrilla]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT paci_nombre, paci_apellido, paci_direccion,paci_dni,paci_email,paci_grupo_sanguineo,paci_id,paci_obso_id,paci_prov_id,paci_telefono, obso_descripcion,prov_descripcion, ciud_descripcion,paci_ciud_id
	FROM paciente
	LEFT JOIN provincia on prov_id = paci_prov_id
	LEFT JOIN ciudad on ciud_id = paci_ciud_id
	LEFT JOIN obra_social on obso_id = paci_obso_id
	WHERE paci_habilitado = 1
	ORDER BY paci_apellido,paci_nombre
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerSucesosGrilla]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerSucesosGrilla]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT suce_id, sues_descripcion, suce_fecha_ini, suce_descripcion, paci_nombre, paci_apellido, paci_dni, paci_grupo_sanguineo, obso_descripcion, sala_descripcion, suti_descripcion FROM suceso
	LEFT JOIN suceso_estado on sues_id = suce_sues_id
	LEFT JOIN paciente on paci_id = suce_paci_id
	LEFT JOIN area on area_id = suce_area_id
	LEFT JOIN sala on sala_area_id = area_id
	LEFT JOIN suceso_tipo on suti_id = suce_suti_id
	LEFT JOIN obra_social on obso_id = paci_obso_id
	WHERE sues_descripcion = 'atendido' or sues_descripcion = 'pendiente'
	ORDER BY sues_descripcion, suce_fecha_ini
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerSucesosUsuario]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerSucesosUsuario]
    @usua_id INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @usua_area_id INT;

    -- Obtener el usua_area_id del usuario
    SELECT @usua_area_id = usua_area_id FROM [codigo_azul].[dbo].[usuarios] WHERE usua_id = @usua_id;

    IF @usua_area_id IS NULL
    BEGIN
        THROW 51000, 'El usuario especificado no existe.', 1;
        RETURN;
    END

    IF @usua_area_id = 0
    BEGIN
        -- Si el usuario tiene usua_area_id = 0, seleccionar todos los sucesos pendientes de todas las áreas
        SELECT  top 5 'Suceso N°: ' + CAST(suce_id AS VARCHAR(10))  AS Suceso,
 			   area_descripcion as Area,
               coalesce(paci_id,-1) AS PacienteID,
			   coalesce(sala_descripcion,'') AS Ubicacion,
               coalesce(paci_nombre + ' ' + paci_apellido,'') AS PacienteNombre,
               suce_descripcion AS Descripcion,
			   suor_descripcion AS Origen,
			   suce_fecha_ini as Fecha,
			   sues_descripcion as Estado,
			   suti_descripcion as Tipo,
			   coalesce(usua_nombre + ' ' + usua_apellido, '')  as Asignado
        FROM Suceso 
        LEFT JOIN paciente  ON suce_paci_id = paci_id
		LEFT JOIN area ON area_id = suce_area_id
		LEFT JOIN suceso_estado ON sues_id = suce_sues_id
		LEFT JOIN suceso_tipo ON suti_id = suce_suti_id
		LEFT JOIN suceso_origen ON suor_id = suce_suor_id
		LEFT JOIN usuarios ON usua_id = suce_usua_id
		LEFT JOIN sala ON sala_id = suce_paci_sala_id
        WHERE  (suce_sues_id = 1 OR suce_sues_id = 2); -- Pendiente o Atendido
    END
    ELSE
    BEGIN
        -- Si el usuario tiene usua_area_id diferente de 0, seleccionar sucesos pendientes del área del usuario
        SELECT top 5 'Suceso N°: ' + CAST(suce_id AS VARCHAR(10))  AS Suceso,
			   area_descripcion as Area,
               coalesce(paci_id,-1) AS PacienteID,
			   coalesce(sala_descripcion,'') AS Ubicacion,
               coalesce(paci_nombre + ' ' + paci_apellido,'') AS PacienteNombre,
               suce_descripcion AS Descripcion,
			   suor_descripcion AS Origen,
			   suce_fecha_ini as Fecha,
			   sues_descripcion as Estado,
			   suti_descripcion as Tipo,
			   coalesce(usua_nombre + ' ' + usua_apellido, '')  as Asignado
        FROM Suceso 
        LEFT JOIN paciente  ON suce_paci_id = paci_id
		LEFT JOIN area ON area_id = suce_area_id
		LEFT JOIN suceso_estado ON sues_id = suce_sues_id
		LEFT JOIN suceso_tipo ON suti_id = suce_suti_id
		LEFT JOIN suceso_origen ON suor_id = suce_suor_id
		LEFT JOIN usuarios ON usua_id = suce_usua_id
		LEFT JOIN sala ON sala_id = suce_paci_sala_id
        WHERE 
			(suce_sues_id = 1 OR suce_sues_id = 2) and
			(suce_usua_id = @usua_id or (suce_area_id = @usua_area_id))
     
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidarUsuario]    Script Date: 17/9/2023 21:24:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Crear el procedimiento almacenado
CREATE PROCEDURE [dbo].[sp_ValidarUsuario]
    @NombreUsuario NVARCHAR(100),
    @Contraseña NVARCHAR(100)
AS
BEGIN
    -- Declarar una variable para almacenar el ID de rol del usuario
    DECLARE @usua_id INT;

    -- Intentar encontrar un usuario con el nombre y contraseña proporcionados
    SELECT @usua_id = usua_id
    FROM usuarios
    WHERE usua_usuario = @NombreUsuario
      AND usua_contraseña = @Contraseña;

    -- Comprobar si se encontró un usuario válido
    IF @usua_id IS NOT NULL
    BEGIN
        -- Retornar el ID de rol del usuario
        SELECT @usua_id AS usua_id;
    END
    ELSE
    BEGIN
        -- No se encontró un usuario válido, retornar 0
        SELECT 0 AS usua_id;
    END
END;
GO
