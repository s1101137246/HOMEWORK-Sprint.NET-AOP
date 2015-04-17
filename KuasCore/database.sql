
CREATE DATABASE [KUAS]
GO

USE [KUAS]
GO

CREATE TABLE [dbo].[Employee](
	[id]   [nvarchar](50) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[age]  [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[Employee] ([id], [name], [age]) VALUES (N'dennis_yen'  , N'嚴志和', 35);
INSERT [dbo].[Employee] ([id], [name], [age]) VALUES (N'james_ch_lee', N'李建祥', 40);
INSERT [dbo].[Employee] ([id], [name], [age]) VALUES (N'sean_huang'  , N'黃以新', 28);
GO
