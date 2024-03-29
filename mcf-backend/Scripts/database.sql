USE [mcf_backend]
GO
/****** Object:  Table [dbo].[BPKBs]    Script Date: 1/11/2023 7:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BPKBs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[agreement_number] [nvarchar](max) NULL,
	[bpkb_no] [nvarchar](max) NULL,
	[branch_id] [nvarchar](max) NULL,
	[bpkb_date] [datetime2](7) NULL,
	[faktur_no] [nvarchar](max) NULL,
	[faktur_date] [datetime2](7) NULL,
	[location_id] [nvarchar](max) NULL,
	[police_no] [nvarchar](max) NULL,
	[bpkb_date_in] [datetime2](7) NULL,
 CONSTRAINT [PK_BPKBs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StorageLocations]    Script Date: 1/11/2023 7:22:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StorageLocations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[location_id] [nvarchar](max) NULL,
	[location_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_StorageLocations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
