select * from tbl_hotel

update tbl_hotel set dias_hospedaje = 1,
					tamano_habitacion = 'Mlllediana',
					tipo_habitacion = 'Platino',
					Precio_dia = 10,
					precio_total_dia= 1,
					costo_tipo_habitacion = 22,
					total_a_facturar = 33, 
					fecha = '20250319',
					estado_codigo = '1'
					where codigo_reservacion = 3
					




/*##########################################
query para actualizar registro desde csharp
###########################################*/

update tbl_hotel set dias_hospedaje = @dias_hospedaje,tamano_habitacion = @tamano_habitacion ,tipo_habitacion = @tipo_habitacion ,Precio_dia = @Precio_dia ,precio_total_dia= @precio_total_dia,costo_tipo_habitacion = @costo_tipo_habitacion ,total_a_facturar = @total_a_facturar ,fecha = @fecha,estado_codigo = @estado_codigo where codigo_reservacion = @codigo_reservacion
					

