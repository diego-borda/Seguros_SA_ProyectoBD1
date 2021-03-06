
create procedure Mostrar_DetalleHospitalizacion
@idHospitalizacion int
as
SELECT TOP (1000) 
      IdDetalle,
      [IdHospitalizacion]
      ,g.Nombre as [Nombre Gasto]
	  ,dh.[Costo]
      ,[Descripcion]
      ,[Fecha]
      ,(select dbo.Cambiar_Estado_DetalleHosp(idDetalle,IdHospitalizacion)) as Estado
  FROM [Compañia_Seguros_v3].[dbo].[DetalleHospitalizacion]dh inner join Gastos g 
  on dh.IdGasto=g.IdGasto

  exec Mostrar_DetalleHospitalizacion 1

  Create function Cambiar_Estado_DetalleHosp(@iddetalle int,@idhosp int)
  returns varchar(30)
  as begin
  declare @estado varchar(30)
  if((select Estado from Hospitalizacion where IdHospitalizacion=@idhosp)='Deshabilitado' or (select Estado from Hospitalizacion where IdHospitalizacion=@idhosp)='Cancelado')
  set @estado='Deshabilitado'
  else
  if((select Estado from DetalleHospitalizacion where IdDetalle=@iddetalle)='Deshabilitado')
  select @estado='Deshabilitado'
  else
  set @estado='Habilitado'
  return @estado
  end


