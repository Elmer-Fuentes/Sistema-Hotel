-- Con objetivo de dar seguridad y practica de sql creare una vista y tener una mejor lectura de los campos.
-- como una practiva a colocar con inical mayuscula los campos, me puede pasar pero esto es por desapercibido.

alter view hotel as (
Select 
h.codigo_reservacion as 'Codigo Reservaciòn',
h.dias_hospedaje as 'Dias Hospedaje',
h.tamano_habitacion as 'Tamaño Habitaciòn',
h.tipo_habitacion as 'Tipo Habitaciòn',
h.Precio_dia as 'Precio Por Dìa',
h.precio_total_dia as 'Precio Total Por Dìa',
h.costo_tipo_habitacion as 'Costo Tipo de Habitaciòn',
h.total_a_facturar as 'Total a Facturar',
h.fecha,case when h.estado_codigo = 1 then 'Activo' else 'Inactivo' end as Estado_Registo,
h.fecha_update as 'Actualización de Registros'
 from tbl_hotel h
where h.estado_codigo = 1
)

--#############################
select * from hotel -- para cargar en el load de csharp
--#############################
--Select 
--h.codigo_reservacion,h.dias_hospedaje,h.tamano_habitacion,h.tipo_habitacion,h.Precio_dia,h.precio_total_dia,h.costo_tipo_habitacion,h.total_a_facturar,h.fecha,case when h.estado_codigo = 1 then 'Activo' else 'Inactivo' end as Estado_Registo,h.fecha_update
-- from tbl_hotel h
--where h.estado_codigo = 1