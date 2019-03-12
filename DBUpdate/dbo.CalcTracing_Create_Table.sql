USE [CalculatorHistory]
GO

/****** Object: Table [dbo].[CalcTracing] Script Date: 12.03.2019 9:48:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CalcTracing] (
    [id]            INT         IDENTITY (1, 1) NOT NULL,
    [id_condition]  INT         NOT NULL,
    [operand_1]     FLOAT (53)  NOT NULL,
    [operand_2]     FLOAT (53)  NOT NULL,
    [id_operations] INT         NOT NULL,
    [result]        FLOAT (53)  NULL,
    [error]         NCHAR (256) NULL
);


