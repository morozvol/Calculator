USE [CalculatorHistory]
GO

/****** Object: SqlProcedure [dbo].[CalcLogRecordGet] Script Date: 12.03.2019 9:49:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- получить запись по id
CREATE PROCEDURE [dbo].[CalcLogRecordGet]
	@id INT
AS
BEGIN
    SELECT
        id,
        condition,
        result,
        error,
        time_calculation,
        [login],
        [host_name] 
	FROM [dbo].[CalcLog] 
	WHERE id = @id
END
