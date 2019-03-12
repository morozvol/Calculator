USE [CalculatorHistory]
GO

/****** Object: Table [dbo].[Users] Script Date: 12.03.2019 9:49:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]    INT            NOT NULL,
    [Login] NVARCHAR (256) NOT NULL
);


