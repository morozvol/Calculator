USE [CalculatorHistory]
GO

/****** Object: SqlProcedure [dbo].[CalcLogRecordDelete] Script Date: 13.03.2019 8:59:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Удаление записи из таблици CalcLog
CREATE PROCEDURE [dbo].[CalcLogRecordDelete]
	@id INT
AS
BEGIN
    BEGIN TRANSACTION

        DELETE FROM CalcTracing
        WHERE id_condition = @id
        
        DELETE FROM [dbo].[CalcLog]
        WHERE id = @id

    COMMIT
END
