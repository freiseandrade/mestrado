/****** Object:  Table [dbo].[Company]    Script Date: 11/02/2018 18:19:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Company](
	[IdCompany] [int] NOT NULL,
	[Name] [varchar](200) NULL,
	[TradingName] [varchar](100) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Feed]    Script Date: 11/02/2018 18:19:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Feed](
	[Guid] [varchar](500) NOT NULL,
	[IdCompany] [int] NULL,
	[Title] [varchar](500) NULL,
	[Description] [varchar](1000) NULL,
	[TitleDescription] [varchar](1500) NULL,
	[Link] [varchar](500) NULL,
	[PubDate] [smalldatetime] NULL,
	[Status] [int] NULL,
	[ManualClassification] [int] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[FeedPos]    Script Date: 11/02/2018 18:20:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FeedPos](
	[IdFeedPos] [int] NOT NULL,
	[IdCompany] [int] NULL,
	[Title] [varchar](500) NULL,
	[Description] [varchar](1000) NULL,
	[TitleDescription] [varchar](1500) NULL,
	[ManualClassification] [int] NULL,
	[Link] [varchar](500) NULL,
	[PubDate] [smalldatetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_IdFeedPos] PRIMARY KEY CLUSTERED 
(
	[IdFeedPos] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[IdxGoogleCloudNaturalLanguageAPI]    Script Date: 11/02/2018 18:20:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[IdxGoogleCloudNaturalLanguageAPI](
	[IdFeedPos] [int] NOT NULL,
	[Score] [decimal](15, 2) NOT NULL,
	[Magnitude] [decimal](15, 2) NOT NULL,
 CONSTRAINT [PK_IdxGoogleCloudNaturalLanguageAPI] PRIMARY KEY CLUSTERED 
(
	[IdFeedPos] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[IdxIBMWatsonToneAnalyzer]    Script Date: 11/02/2018 18:20:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[IdxIBMWatsonToneAnalyzer](
	[IdFeedPos] [int] NOT NULL,
	[IdxAnger] [decimal](15, 2) NULL,
	[IdxDisgust] [decimal](15, 2) NULL,
	[IdxFear] [decimal](15, 2) NULL,
	[IdxJoy] [decimal](15, 2) NULL,
	[IdxSadness] [decimal](15, 2) NULL,
	[IdxAnalytical] [decimal](15, 2) NULL,
	[IdxConfident] [decimal](15, 2) NULL,
	[IdxTentative] [decimal](15, 2) NULL,
	[IdxOpenness] [decimal](15, 2) NULL,
	[IdxConscientiousness] [decimal](15, 2) NULL,
	[IdxExtraversion] [decimal](15, 2) NULL,
	[IdxAgreeableness] [decimal](15, 2) NULL,
	[IdxEmotionalRange] [decimal](15, 2) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Quotation]    Script Date: 11/02/2018 18:21:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Quotation](
	[CodCompany] [varchar](10) NOT NULL,
	[Date] [smalldatetime] NOT NULL,
	[Price] [decimal](15, 2) NULL,
	[Minimum] [decimal](15, 2) NULL,
	[Maximum] [decimal](15, 2) NULL,
	[Variation] [decimal](15, 2) NULL,
	[VariationP] [decimal](15, 2) NULL,
	[Volume] [int] NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[RssConfig]    Script Date: 11/02/2018 18:22:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RssConfig](
	[IdRssConfig] [int] NOT NULL,
	[Url] [varchar](300) NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[StopWords]    Script Date: 11/02/2018 18:22:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StopWords](
	[Word] [varchar](100) NOT NULL
) ON [PRIMARY]
GO



