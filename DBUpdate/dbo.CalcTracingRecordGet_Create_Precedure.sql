USE [CalculatorHistory]
GO

/****** Object: SqlProcedure [dbo].[CalcTracingRecordGet] Script Date: 12.03.2019 11:46:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CalcTracingRecordGet]
	@id int=0
AS
BEGIN
   SELECT 
       operand_1, 
       operand_2, 
       (
           SELECT operations 
           FROM Operations 
           WHERE Id = ctg.id_operations
       ),
       result
   FROM dbo.CalcTracing ctg
   WHERE id_condition = @id
END
