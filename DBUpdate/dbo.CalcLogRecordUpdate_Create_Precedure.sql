USE [CalculatorHistory]
GO

/****** Object: SqlProcedure [dbo].[CalcLogRecordUpdate] Script Date: 12.03.2019 9:50:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Изменение записи
CREATE PROCEDURE [dbo].[CalcLogRecordUpdate]
(
	@id INT,
	@condition	NVARCHAR(256),
	@result		FLOAT,
	@error		NVARCHAR(256),
	@date_time	DATETIME,
	@login		NVARCHAR(256),
	@host_name	NVARCHAR(256)
	)
AS

BEGIN TRANSACTION

	UPDATE [dbo].[CalcLog]
	SET
		condition	        = @condition,
		result	        	= @result,
		error		        = @error,
		time_calculation	= @date_time,
		login		        = @login,
		host_name       	= @host_name
	WHERE id = @id

  DELETE CalcTracing
  WHERE id_condition = @id

COMMIT
