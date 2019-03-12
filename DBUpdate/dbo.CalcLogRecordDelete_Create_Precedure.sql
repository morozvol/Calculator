USE [CalculatorHistory]
GO

/****** Object: SqlProcedure [dbo].[CalcLogRecordDelete] Script Date: 12.03.2019 9:45:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Удаление записи из базы данных
CREATE PROCEDURE [dbo].[CalcLogRecordDelete]
	@id INT
AS
BEGIN TRANSACTION

	DELETE FROM CalcLog
    WHERE id = @id

    DELETE FROM CalcTracing
    WHERE id_condition = @id

COMMIT
