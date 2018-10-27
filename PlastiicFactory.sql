USE [PlasticFactory]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/7/2018 8:48:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[MSNV] [char](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[SDT] [nchar](15) NULL,
	[CMND] [nchar](15) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[MSNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Timekeeping]    Script Date: 10/7/2018 8:48:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Timekeeping](
	[MSNV] [char](10) NOT NULL,
	[Date] [date] NULL,
	[TimeStart] [char](10) NULL,
	[TimeEnd] [char](10) NULL,
	[Time] [float] NULL,
	[Weight] [int] NULL,
	[Type] [int] NULL,
	[TotalWeight] [nchar](10) NULL,
	[AdvancePayment] [int] NULL,
	[Note] [nvarchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[AutoIdEmployee]    Script Date: 10/7/2018 8:48:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AutoIdEmployee]
AS
DECLARE @TEMP INT=1
DECLARE @MSNV NCHAR(5)='NV'+FORMAT(@TEMP,'d3');
DECLARE @CHECK INT=0;
WHILE(@CHECK!=1)
BEGIN
IF EXISTS(SELECT*FROM Employee e WHERE E.MSNV=@MSNV)
BEGIN 
SET @TEMP=@TEMP+1;
SET @MSNV='NV'+FORMAT(@TEMP,'d3');
END
ELSE
BEGIN
SELECT 'AutoMSNV'=@MSNV
BREAK;
END
END
GO
