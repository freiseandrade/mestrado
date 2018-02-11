/****** Object:  View [dbo].[V_Google_CloudNaturalLanguageAPI]    Script Date: 11/02/2018 18:23:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_Google_CloudNaturalLanguageAPI]
AS
SELECT        FP.IdFeedPos, FP.TitleDescription, FP.PubDate, Q.VariationP, I.Score, I.Magnitude
FROM            dbo.FeedPos AS FP INNER JOIN
                         dbo.Quotation AS Q ON FORMAT(FP.PubDate, 'dd-MM-yyyy') = FORMAT(Q.Date, 'dd-MM-yyyy') INNER JOIN
                         dbo.IdxGoogleCloudNaturalLanguageAPI AS I ON FP.IdFeedPos = I.IdFeedPos
GO

/****** Object:  View [dbo].[V_IBM_WatsonToneAnalyzer]    Script Date: 11/02/2018 18:24:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_IBM_WatsonToneAnalyzer]
AS
SELECT        FP.IdFeedPos, FP.TitleDescription, FP.PubDate, Q.VariationP, I.IdxAnger, I.IdxDisgust, I.IdxFear, I.IdxJoy, I.IdxSadness, I.IdxAnalytical, I.IdxConfident, I.IdxTentative, I.IdxOpenness, I.IdxConscientiousness, I.IdxExtraversion, 
                         I.IdxAgreeableness, I.IdxEmotionalRange
FROM            dbo.FeedPos AS FP INNER JOIN
                         dbo.Quotation AS Q ON FORMAT(FP.PubDate, 'dd-MM-yyyy') = FORMAT(Q.Date, 'dd-MM-yyyy') INNER JOIN
                         dbo.IdxIBMWatsonToneAnalyzer AS I ON FP.IdFeedPos = I.IdFeedPos
GO

