
--select * from DetalleHospitalizacion
--select * from Hospitalizacion

drop table DetalleHospitalizacion

create table DetalleHospitalizacion(
idDetalle int primary key identity(1,1),
idHospitalizacion int,
idGasto int,
Costo float,
Descripcion varchar(300),
Fecha date,
Estado varchar(60)
constraint fk_Hospit foreign key(idHospitalizacion) references Hospitalizacion(idHospitalizacion),
constraint fk_Gasto foreign key(idGasto) references Gastos(idGasto)
)

insert into DetalleHospitalizacion values(1,1,700,'Para ver si tenia Covid','2021/10/15','Habilitado')
insert into DetalleHospitalizacion values(1,2,900,'Si tenia Covid :(','2021/10/17','Habilitado')
insert into DetalleHospitalizacion values(1,3,1500,'Para ver como tenia los pulmones','2021-11-20','Habilitado')
insert into DetalleHospitalizacion values(2,1,700,'Para ver si tenia Covid','2021-10-17','Habilitado')
insert into DetalleHospitalizacion values(2,2,900,'No tenia Covid :)','2021-10-17','Habilitado')
insert into DetalleHospitalizacion values(3,4,800,'Fracturas en la pierna','2021-11-13','Habilitado')