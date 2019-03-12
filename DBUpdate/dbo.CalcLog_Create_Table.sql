USE [CalculatorHistory]
GO

/****** Object: Table [dbo].[CalcLog] Script Date: 12.03.2019 9:48:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CalcLog] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [condition]        NVARCHAR (256) NOT NULL,
    [result]           FLOAT (53)     NULL,
    [error]            NVARCHAR (256) NULL,
    [time_calculation] DATETIME       NOT NULL,
    [login]            NVARCHAR (256) NOT NULL,
    [host_name]        NVARCHAR (256) NOT NULL
);


