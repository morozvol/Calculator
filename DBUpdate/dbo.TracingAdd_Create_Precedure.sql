USE [CalculatorHistory]
GO

/****** Object: SqlProcedure [dbo].[TracingAdd] Script Date: 12.03.2019 9:50:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TracingAdd]
(
    @tracing    TracingType READONLY,
	@condition	NVARCHAR(256),
	@result		FLOAT,
	@error		NVARCHAR(256),
	@date_time	DATETIME,
	@login		NVARCHAR(256),
	@host_name	NVARCHAR(256)
) AS

BEGIN

    BEGIN TRANSACTION

    INSERT INTO [dbo].[CalcLog]
    (
        condition,
        result,
        error,
        time_calculation,
        [login],
        [host_name]
    ) 
    VALUES
	(
        @condition,
        @result,
        @error,
        @date_time,
        @login,
        @host_name
    )
   
   DECLARE @id_new INT = @@IDENTITY

    INSERT INTO [dbo].[CalcTracing] 
    (
        id_condition,
        operand_1,
        operand_2,
        id_operations,
        result,
        error
    )
	SELECT
	@id_new,
	trc.operand_1,
	trc.operand_2,
	(SELECT id FROM Operations WHERE operations = trc.operations),
	trc.result,
	trc.error
	FROM @tracing trc
    COMMIT
END
