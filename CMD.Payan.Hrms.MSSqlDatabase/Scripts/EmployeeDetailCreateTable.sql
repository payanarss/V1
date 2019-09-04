USE [CMD.Payan]
GO

/****** Object:  Table [dbo].[EmployeeDetail]    Script Date: 01/05/2014 20:55:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[EmployeeDetail](
	[UniqueIdentifier] [bigint] IDENTITY(1,1) NOT NULL,
		[Aadhar] [] ,	[ABonus] [] ,	[Address1] [] ,	[Address2] [] ,	[BankName] [] ,	[BankNumber] [] ,	[Basic] [] ,	[CcGroupCode] [] ,	[City] [] ,	[Cl] [] ,	[Classi] [] ,	[Degree] [] ,	[Deptcode] [] ,	[Deptname] [] ,	[Designation] [] ,	[Designdesc] [] ,	[DevCode] [] ,	[DevName] [] ,	[Dispensary] [] ,	[Dob] [] ,	[Doc] [] ,	[Doj] [] ,	[Dor] [] ,	[DoubleOTType] [] ,	[Email] [] ,	[Empcode] [] ,	[Empimage] [] ,	[Empname] [] ,	[Empno] [] ,	[EsiLocation] [] ,	[ESIno] [] ,	[FatherName] [] ,	[FBonus] [] ,	[FClassi] [] ,	[FDESIGN] [] ,	[IFSCCODE] [] ,	[IncrMonth] [] ,	[InsNo] [] ,	[InsPremium] [] ,	[JoinDate] [] ,	[OT] [] ,	[OTType] [] ,	[PanNo] [] ,	[PayMode] [] ,	[Pensionpf] [] ,	[PFMargin] [] ,	[PFno] [] ,	[Phone] [] ,	[Pincode] [] ,	[Policy1] [] ,	[Policy2] [] ,	[Policy3] [] ,	[PrdEnt] [] ,	[RelDate] [] ,	[ResigReason] [] ,	[Revdate] [] ,	[Revno] [] ,	[SerialNo] [] ,	[Sex] [] ,	[Shft] [] ,	[Shft1] [] ,	[SrName] [] ,	[Status] [] ,	[Subgroup] [] ,	[Sunded] [] ,	[Swapcardno] [] ,
 CONSTRAINT [PK_EmployeeDetail] PRIMARY KEY CLUSTERED 
(
	[UniqueIdentifier] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


GO