
create function [dbo].[Reporte_Contratos](@costo float,@cobertura float,@fechaI date,@fechaF date)
returns float
as
begin
declare @recaudacion float
declare @fechas int = datediff(DAY,@fechaI,@fechaF)
declare @var float = @cobertura/30
set @recaudacion = @costo+(@var*@fechas)
return round(@recaudacion,2)
end


create function Cambiar_Estado_ContratoPoliza(@idcontrato int,@idasegurado int,@fechaI date, @fechaF date)
returns varchar(60)
as
begin
declare @estado varchar(50)
if((select Estado from Asegurado where IDAsegurado=@idasegurado)='Deshabilitado')
set @estado='Deshabilitado'
if(select cp.Estado from ContratoPoliza cp where cp.IdContrato=@idcontrato)='Deshabilitado'
  set @estado='Deshabilitado'
  else
  if(select cp.Estado from ContratoPoliza cp where cp.IdContrato=@idcontrato)='Cancelado'
  set @estado='Cancelado'
else
begin
if ((GETDATE() between @fechaI and @fechaF))
set @estado='Habilitado'
else if((datepart(YYYY,GETDATE())= datepart(YYYY,@fechaF) and datepart(MM,GETDATE()) = datepart(MM,@fechaF) and datepart(DD,GETDATE()) = datepart(DD,@fechaF)) 
or (datepart(YYYY,GETDATE()))= datepart(YYYY,@fechaI) and datepart(MM,GETDATE()) = datepart(MM,@fechaI) and datepart(DD,GETDATE()) = datepart(DD,@fechaI)) 
set @estado='Habilitado'
else if(@fechaI<GETDATE() and @fechaF<GETDATE())
set @estado='Finalizado'
else if(@fechaI>GETDATE() and @fechaF>GETDATE())
set @estado='Proximamente'
end
return @estado
end



create procedure [dbo].[Reporte_por_Contrato]
as
select 
cp.IdContrato,
ps.Tipo as [Tipo Poliza],
a.PrimerApellido +' '+a.SegundoNombre as Nombres,
a.PrimerApellido+' '+a.SegundoApellido as Apellidos,
a.Celular,
cp.FechaInicio as [Fecha Inicio],
cp.FechaFin as [Fecha Fin],
cp.Costo,
cp.ValorCobertura,
(select dbo.Reporte_Contratos(cp.Costo,cp.ValorCobertura,FechaInicio,FechaFin)) as [Total Recaudacion]
from ContratoPoliza cp inner join Asegurado a 
on cp.IdAsegurado=a.IDAsegurado inner join PolizaSeguro ps 
on cp.IdPoliza=ps.IdPoliza
where (select(dbo.Cambiar_Estado_ContratoPoliza(cp.IdContrato,cp.IdAsegurado,cp.FechaInicio,cp.FechaFin)))='Finalizado'