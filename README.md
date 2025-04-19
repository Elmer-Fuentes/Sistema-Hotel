# Sistema de Gestión de Reservaciones de Habitaciones
Este proyecto es un sistema de gestión de reservaciones de habitaciones desarrollado en C# con SQL Server como base de datos. El sistema permite a los usuarios realizar, editar y eliminar reservaciones, así como calcular costos y generar facturas. A continuación, se detallan las funcionalidades y métodos implementados:

##Tecnologias Utilizadas
Sharp en visual studio 2022.
SQL Server 2022.

## Funcionalidades Principales de 
  1. Fecha Actual: Recupera la fecha del día mediante el método MtdFechaHoy.
  2. Días a Hospedarse: Permite al usuario ingresar el número de días a hospedarse.
  3. Tamaño de Habitación: Muestra opciones en un combobox (Individual, Compartida, Suite, Presidencial).
  4. Tipo de Habitación: Muestra opciones en un combobox (Bronce, Oro, Diamante, Exclusiva).
  5. Precio por Día: Recupera el precio por día según el tipo de habitación seleccionado mediante el método MtdPrecioPorDia.
  6. Precio Total Días: Calcula el precio total de los días de hospedaje mediante el método MtdPrecioTotalDias.
  7. Costo Tipo Habitación: Recupera el costo adicional según el tipo de habitación mediante el método MtdCostoTipoHabitación.
  8. Total a Facturar: Calcula el total a facturar mediante el método MtdTotalFacturar.
  9. DataGridView: Muestra los detalles de la reservación (Código de Reservación, Días a Hospedarse, Tamaño de Habitación, Tipo de Habitación, Precio por Día, Precio Total Días, Costo Tipo Habitación, Total a Facturar, Fecha).

## Base de Datos SQL Server
  1. Creación de la Base de Datos: Implementada en SQL Server.
  2. Tabla de Gestión de Datos: Creación de la tabla para almacenar los datos de las reservaciones.
  3. Métodos Implementados
  4. Scripts SQL: Incluye todos los scripts creados para la base de datos y la tabla de gestión de datos.

## Botones
1. Agregar: Permite agregar registros en la base de datos. No se permiten valores nulos, blancos o vacíos. Implementa try-catch para mensajes de confirmación y error.
2. Editar: Permite actualizar registros seleccionados en la base de datos. No se permiten valores nulos, blancos o vacíos. Implementa try-catch para mensajes de confirmación y error.
4. Eliminar: Permite eliminar registros seleccionados en la base de datos. Muestra error si no hay fila seleccionada. Implementa try-catch para mensajes de confirmación y error.
5. Cancelar: Limpia todos los campos del formulario.
6. Salir: Permite salir del sistema.

## Extras
1. se estara implementando la parte de reporteria para extraer la información en formatos de .xlsx, .doc, .pdf desde la interfaz 
