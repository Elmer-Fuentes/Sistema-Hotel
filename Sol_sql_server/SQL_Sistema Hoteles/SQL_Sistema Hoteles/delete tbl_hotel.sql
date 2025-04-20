select * from tbl_hotel where estado_codigo = 1
-- tengo la opción principal de utilizar delete dentro del frm de sharp ok
-- sin embargo he decidido optar por algo más practico con el objetivo de mantener la integridad de datos y evitar la perdida de la misma
-- en la creación de tbl_hotel deje un campo bit el cual es un valor boleano ok  utilizare update para pasar a false o 0 y aplicar where para 
-- que cuando se cargue la interfaz desde el load en C# solo filtre la data con valor TRUE O 1
--COMO PARTE DEL PROYECTO DEJARE EL SCRIP DE DELETE 
/**************************************************

	delete from tbl_hotel where codigo_reservacion = 4

*************************************************** */
-- Mi objetivo es mantener la data si fuera un sistema empresarial optaria por este query.
update tbl_hotel set estado_codigo = '0' where codigo_reservacion = 3
/*
query para desactivar registros en la base de datos, con el objetivo no perder historial Ok. */
update tbl_hotel set estado_codigo = @estado_codigo where codigo_reservacion = @codigo_reservacion
