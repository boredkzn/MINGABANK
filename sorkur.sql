USE [D:\BDLR6\BANKDB.MDF]
GO
/****** Object:  Table [dbo].[BalanceSet]    Script Date: 07.06.2022 3:16:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BalanceSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Summa] [nvarchar](max) NOT NULL,
	[UserData_Id] [int] NULL,
	[NumberCard] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BalanceSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDataSet]    Script Date: 07.06.2022 3:16:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDataSet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](max) NOT NULL,
	[Mail] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_UserDataSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BalanceSet] ON 
GO
INSERT [dbo].[BalanceSet] ([Id], [Summa], [UserData_Id], [NumberCard]) VALUES (7, N'0', 9, N'412009037')
GO
INSERT [dbo].[BalanceSet] ([Id], [Summa], [UserData_Id], [NumberCard]) VALUES (8, N'5000', 10, N'780334883')
GO
SET IDENTITY_INSERT [dbo].[BalanceSet] OFF
GO
SET IDENTITY_INSERT [dbo].[UserDataSet] ON 
GO
INSERT [dbo].[UserDataSet] ([Id], [Name], [Surname], [Login], [Password], [Role], [Mail]) VALUES (9, N'Дамир', N'Латыпов', N'latyp', N'cdb3ed3adef3c0d1e7407d36843f3712', N'User', N'lasdolsd@mail.ru')
GO
INSERT [dbo].[UserDataSet] ([Id], [Name], [Surname], [Login], [Password], [Role], [Mail]) VALUES (10, N'Ксения', N'Суханова', N'ksu', N'952ec2d8ee6fc3ee8df6b8ca76359ea0', N'User', N'olidd@mail.ru')
GO
SET IDENTITY_INSERT [dbo].[UserDataSet] OFF
GO
ALTER TABLE [dbo].[BalanceSet]  WITH CHECK ADD  CONSTRAINT [FK_UserDataBalance] FOREIGN KEY([UserData_Id])
REFERENCES [dbo].[UserDataSet] ([Id])
GO
ALTER TABLE [dbo].[BalanceSet] CHECK CONSTRAINT [FK_UserDataBalance]
GO
