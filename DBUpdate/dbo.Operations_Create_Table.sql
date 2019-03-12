USE [CalculatorHistory]
GO

/****** Object: Table [dbo].[Operations] Script Date: 12.03.2019 9:48:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Operations] (
    [Id]         INT       IDENTITY (1, 1) NOT NULL,
    [operations] NCHAR (2) NOT NULL
);


