


create function [dbo].[Reporte_Hospitalizacion](@idhospitalizacion int)
returns float
as
begin
declare @costo float= (select ROUND(sum(Costo),2) from DetalleHospitalizacion where IdHospitalizacion=@idhospitalizacion)
return @costo
end


create function [dbo].[Cambiar_Estado_Hospitalizacion](@idcontrato int,@idhospitalizacion int,@fechaI date, @fechaF date)
returns varchar(30)
as
begin
declare @estado varchar(50)
if((select cp.estado from ContratoPoliza cp inner join Hospitalizacion h on cp.IdContrato = h.IdContrato 
where cp.idContrato = @idcontrato and h.Estado='Proximamente')='Deshabilitado')
set @estado='Deshabilitado'
else
if((select cp.estado from ContratoPoliza cp inner join Hospitalizacion h on cp.IdContrato = h.IdContrato  
where cp.idContrato = @idcontrato and h.IdHospitalizacion=@idhospitalizacion and h.Estado='Proximamente')='Cancelado')
set @estado='Deshabilitado'
else
if((select cp.estado from ContratoPoliza cp inner join Hospitalizacion h on cp.IdContrato = h.IdContrato 
where cp.idContrato = @idcontrato and h.IdHospitalizacion=@idhospitalizacion and h.Estado='Proximamente')='Finalizado')
set @estado='Deshabilitado'
else
if((select cp.estado from ContratoPoliza cp inner join Hospitalizacion h on cp.IdContrato = h.IdContrato
where cp.idContrato = @idcontrato and h.IdHospitalizacion=@idhospitalizacion and h.Estado='En proceso')='Deshabilitado')
set @estado='Deshabilitado'
else if((select cp.estado from ContratoPoliza cp inner join Hospitalizacion h on cp.IdContrato = h.IdContrato
where cp.idContrato = @idcontrato and h.IdHospitalizacion=@idhospitalizacion and h.Estado='En proceso')='Cancelado')
set @estado='Deshabilitado'
else if((select cp.estado from ContratoPoliza cp inner join Hospitalizacion h on cp.IdContrato = h.IdContrato 
where cp.idContrato = @idcontrato and h.IdHospitalizacion=@idhospitalizacion and h.Estado='En proceso')='Finalizado')
set @estado='Deshabilitado'
else if((select Estado from Hospitalizacion where IdHospitalizacion=@idhospitalizacion)='Deshabilitado')
set @estado='Deshabilitado'
else if((select Estado from Hospitalizacion where IdHospitalizacion=@idhospitalizacion)='Cancelado')
set @estado='Cancelado'
else
begin
if ((GETDATE() between @fechaI and @fechaF))
set @estado='En proceso'
else if((datepart(YYYY,GETDATE())= datepart(YYYY,@fechaF) and datepart(MM,GETDATE()) = datepart(MM,@fechaF) and datepart(DD,GETDATE()) = datepart(DD,@fechaF)) 
or (datepart(YYYY,GETDATE()))= datepart(YYYY,@fechaI) and datepart(MM,GETDATE()) = datepart(MM,@fechaI) and datepart(DD,GETDATE()) = datepart(DD,@fechaI)) 
set @estado='En proceso'
else if(@fechaI<GETDATE() and @fechaF<GETDATE())
set @estado='Finalizado'
else if(@fechaI>GETDATE() and @fechaF>GETDATE())
set @estado='Proximamente'
end
return @estado
end


create procedure [dbo].[Recaudacion_por_Hospitalizacion]
as
SELECT TOP (1000) h.[IdHospitalizacion]
      ,hosp.Nombre as [Nombre Hospital]
	  ,m.PrimerNombre+' '+m.PrimerApellido as [Nombre Medico]
      ,a.PrimerNombre+' '+a.PrimerApellido as [Nombre Asegurado]
	  ,h.[FechaInicio]
      ,h.[FechaFin]
	  ,(select dbo.Reporte_Hospitalizacion(IdHospitalizacion)) as [Gasto Total]
	  ,(select dbo.Cambiar_Estado_Hospitalizacion(h.IdContrato,h.IdHospitalizacion,h.FechaInicio,h.FechaFin))as Estado
 from Hospitalizacion h inner join Hospital hosp on h.IdHospital= hosp.IdHospital
 inner join Medico m on h.IdMedico=m.IdMedico
 inner join ContratoPoliza cp on h.IdContrato=cp.IdContrato inner join Asegurado a on cp.IdAsegurado=a.IDAsegurado


--exec Mostrar_Hospitalizacion
--select * from DetalleHospitalizacion

alter table Consultas add Estado varchar(50)
Update Consultas set Estado ='Habilitado'

