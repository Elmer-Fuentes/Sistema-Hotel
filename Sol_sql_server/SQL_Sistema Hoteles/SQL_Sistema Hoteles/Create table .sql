create table tbl_hotel (
codigo_reservacion int primary key identity (1,1),
dias_hospedaje decimal(4,2),
tamano_habitacion varchar (20),
tipo_habitacion varchar(20),
Precio_dia decimal (10,2),
precio_total_dia decimal (10,2),
costo_tipo_habitacion decimal (10,2),
total_a_facturar decimal(10,2),
fecha datetime,
estado_codigo bit, -- uso de bit como para tener false o true y no eliminar completamente el registro solo desactivarlo
fecha_update datetime2(7) default Getdate() -- para obtener la fecha y hora de cada acción con la data desde la base de datos tipo dato datatime2(7)
)

drop table tbl_hotel
