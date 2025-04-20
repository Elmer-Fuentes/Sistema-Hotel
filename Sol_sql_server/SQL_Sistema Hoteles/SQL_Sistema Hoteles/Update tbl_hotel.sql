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
					