USE [Compañia_Seguros_v3]
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Consultas]    Script Date: 28/11/2021 11:56:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[GastosAdic](@IdContrato int,@gastosAdic float)
returns float
as
begin
declare @faltante float
declare @f float
if((25+@gastosAdic)>(select cp.ValorCobertura from ContratoPoliza cp where cp.IdContrato= @IdContrato))
begin
set @faltante = (25+@gastosAdic)-(select cp.ValorCobertura from ContratoPoliza cp where cp.IdContrato= @IdContrato)
set @f=@gastosAdic-@faltante
end
else
begin
set @f=@gastosAdic
end
return @f
end


create FUNCTION [dbo].[Cambiar_Estado_Consulta](@idcontrato int,@idconsulta int, @fecha date)
RETURNS varchar(60)
WITH EXECUTE AS CALLER
AS
BEGIN
declare @diferencia int
declare @estado varchar(50)
if((select cp.estado from ContratoPoliza cp inner join Consultas c on cp.IdContrato = c.IdContrato 
where cp.idContrato = @idcontrato and c.IdConsulta=@idconsulta and c.Estado='Proximamente')='Deshabilitado')
set @estado='Deshabilitado'
else
if((select cp.estado from ContratoPoliza cp inner join Consultas c on cp.IdContrato = c.IdContrato 
where cp.idContrato = @idcontrato and c.IdConsulta=@idconsulta and c.Estado='Proximamente')='Cancelado')
set @estado='Deshabilitado'
else
if((select cp.estado from ContratoPoliza cp inner join Consultas c on cp.IdContrato = c.IdContrato 
where cp.idContrato = @idcontrato and c.IdConsulta=@idconsulta and c.Estado='Proximamente')='Finalizado')
set @estado='Deshabilitado'
else
if((select cp.estado from ContratoPoliza cp inner join Consultas c on cp.IdContrato = c.IdContrato 
where cp.idContrato = @idcontrato and c.IdConsulta=@idconsulta and c.Estado='Es Hoy')='Deshabilitado')
set @estado='Deshabilitado'
else if((select cp.estado from ContratoPoliza cp inner join Consultas c on cp.IdContrato = c.IdContrato 
where cp.idContrato = @idcontrato and c.IdConsulta=@idconsulta and c.Estado='Es Hoy')='Cancelado')
set @estado='Deshabilitado'
else if((select cp.estado from ContratoPoliza cp inner join Consultas c on cp.IdContrato = c.IdContrato 
where cp.idContrato = @idcontrato and c.IdConsulta=@idconsulta and c.Estado='Es Hoy')='Finalizado')
set @estado='Deshabilitado'
else if((select Estado from Consultas where IdConsulta=@idconsulta)='Deshabilitado')
set @estado='Deshabilitado'
else if((select Estado from Consultas where IdConsulta=@idconsulta)='Cancelado')
set @estado='Cancelado'
else
begin
if(datepart(YYYY,GETDATE())= datepart(YYYY,@fecha) and datepart(MM,GETDATE()) = datepart(MM,@fecha) and datepart(DD,GETDATE()) = datepart(DD,@fecha))
set @estado='Es Hoy'
else if(@fecha<GETDATE())
set @estado='Finalizado'
else if(@fecha>GETDATE())
set @estado='Proximamente'
end
return @estado
END


create procedure [dbo].[Reporte_por_Consultas]
as
SELECT TOP (50) c.[IdConsulta] as IdConsulta,
       h.[Nombre] as [Nombre Hospital]
      ,m.[PrimerNombre]+' '+m.PrimerApellido as [Nombre Medico]
      ,a.[PrimerNombre]+' '+a.PrimerApellido as [Nombre Asegurado]
	  ,[Fecha]
      ,c.[Especialidad]
      ,[GastoFijo] as [Gasto Fijo]
	  ,c.TotalGastosAdicionales as [Gastos Adicionales]
	  ,(select round(sum(GastoFijo+TotalGastosAdicionales),2) from Consultas where IdConsulta= c.IdConsulta) as [Total Gasto]
      ,(select dbo.Cambiar_Estado_Consulta(cp.IdContrato,c.IdConsulta,c.Fecha)) as Estado
  FROM [Compañia_Seguros_v3].[dbo].[Consultas]c inner join Hospital h on c.IdHospital= h.IdHospital
  inner join Medico m on c.IdMedico=m.IdMedico inner join ContratoPoliza cp on c.IdContrato= cp.IdContrato 
  inner join Asegurado a on cp.IdAsegurado= a.IDAsegurado where (select dbo.Cambiar_Estado_Consulta(cp.IdContrato,c.IdConsulta,c.Fecha))='Finalizado'


