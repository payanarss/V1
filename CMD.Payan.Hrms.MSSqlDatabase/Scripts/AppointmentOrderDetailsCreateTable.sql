USE [CMD.Payan]
GO

/****** Object:  Table [dbo].[AppointmentOrderDetails]    Script Date: 01/05/2014 20:55:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AppointmentOrderDetails](
	[UniqueIdentifier] [bigint] IDENTITY(1,1) NOT NULL,
		[Amount] [] ,	[AppointmentOrderNumber] [] ,	[Code] [] ,	[DispRpt] [] ,	[EleCode] [] ,	[EleName] [] ,	[Flag] [] ,	[MonDaily] [] ,	[MonNo] [] ,	[PMonth] [] ,	[PYear] [] ,	[SlNo] [] ,	[TotWork] [] ,	[Type] [] ,
 CONSTRAINT [PK_AppointmentOrderDetails] PRIMARY KEY CLUSTERED 
(
	[UniqueIdentifier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


GO