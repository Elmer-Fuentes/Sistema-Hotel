using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cd_hotel
    {

        #region= "Paso1 comunicaciòn con vista hoteles"
        //todos los form empiezan con este paso despues de la conexión. Ok, super.
        public DataTable MtdConsultarHotel()
        {
            Conexion cd_conexionDB = new Conexion(); //instancia de la clases Conexion
            string QuerySelect = "SELECT * FROM hotel";//almacenar en queryselect = la consulta de sql
            SqlDataAdapter adapter = new SqlDataAdapter(QuerySelect, cd_conexionDB.MtdAbrirConexion());//intermediario entre la base de datos y aplicación
            //llenar los datos resultantes en una estructura en memoria, como un DataTable
            DataTable dt_hotel = new DataTable();//estructura en memoria contiene el query
            adapter.Fill(dt_hotel);//ejecuta la consulta SQL definida en el SqlDataAdapter y llena el DataTable (dt_clientes) con los datos obtenidos de la base de datos. 
            cd_conexionDB.MtdCerrarConexion();//cierra la conexión
            return dt_hotel; //devuelve el dataTable.
        }
        #endregion

        #region = "Agregar data a Hotel"
        public void MtdAgregarData_Hotel(double dias_hospedaje, string tamano_habitacion, string tipo_habitacion, double precio_dia, double precio_total_dia, double costo_tipo_habitacion,double total_factura,DateTime Fecha_factura, Boolean estado_codigo)
        {
            Conexion cd_conexionDB = new Conexion(); //instancia de la clases Conexion
            string query = "insert into tbl_hotel (dias_hospedaje, tamano_habitacion, tipo_habitacion, Precio_dia, precio_total_dia, costo_tipo_habitacion, total_a_facturar, fecha,estado_codigo) values (@dias_hospedaje, @tamano_habitacion, @tipo_habitacion, @Precio_dia, @precio_total_dia, @costo_tipo_habitacion, @total_a_facturar, @fecha,@estado_codigo)";
            SqlCommand cmd = new SqlCommand(query, cd_conexionDB.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@dias_hospedaje", dias_hospedaje);
            cmd.Parameters.AddWithValue("@tamano_habitacion", tamano_habitacion);
            cmd.Parameters.AddWithValue("@tipo_habitacion", tipo_habitacion);
            cmd.Parameters.AddWithValue("@Precio_dia", precio_dia);
            cmd.Parameters.AddWithValue("@precio_total_dia", precio_total_dia);
            cmd.Parameters.AddWithValue("@costo_tipo_habitacion", costo_tipo_habitacion);
            cmd.Parameters.AddWithValue("@total_a_facturar", total_factura);
            cmd.Parameters.AddWithValue("@fecha", Fecha_factura);
            cmd.Parameters.AddWithValue("@estado_codigo",estado_codigo);
            cmd.ExecuteNonQuery();
            cd_conexionDB.MtdCerrarConexion();
        }
        #endregion


        #region = "Actualizar data a Hotel"
        public void MtdActualizar_Data_Hotel(int codigo_reservacion,double dias_hospedaje, string tamano_habitacion, string tipo_habitacion, double precio_dia, double precio_total_dia, double costo_tipo_habitacion, double total_factura, DateTime Fecha_factura, Boolean estado_codigo)
        {
            Conexion cd_conexionDB = new Conexion(); //instancia de la clases Conexion
            string query = "update tbl_hotel set dias_hospedaje = @dias_hospedaje,tamano_habitacion = @tamano_habitacion ,tipo_habitacion = @tipo_habitacion ,Precio_dia = @Precio_dia ,precio_total_dia= @precio_total_dia,costo_tipo_habitacion = @costo_tipo_habitacion ,total_a_facturar = @total_a_facturar ,fecha = @fecha,estado_codigo = @estado_codigo where codigo_reservacion = @codigo_reservacion";
            SqlCommand cmd = new SqlCommand(query, cd_conexionDB.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@dias_hospedaje", dias_hospedaje);
            cmd.Parameters.AddWithValue("@tamano_habitacion", tamano_habitacion);
            cmd.Parameters.AddWithValue("@tipo_habitacion", tipo_habitacion);
            cmd.Parameters.AddWithValue("@Precio_dia", precio_dia);
            cmd.Parameters.AddWithValue("@precio_total_dia", precio_total_dia);
            cmd.Parameters.AddWithValue("@costo_tipo_habitacion", costo_tipo_habitacion);
            cmd.Parameters.AddWithValue("@total_a_facturar", total_factura);
            cmd.Parameters.AddWithValue("@fecha", Fecha_factura);
            cmd.Parameters.AddWithValue("@estado_codigo", estado_codigo);
            cmd.Parameters.AddWithValue("@codigo_reservacion", codigo_reservacion);
            cmd.ExecuteNonQuery();
            cd_conexionDB.MtdCerrarConexion();
        }
        #endregion

        #region = "Borrar (desactivar) data a Hotel"
        public void MtdDelete_Data_Hotel(int codigo_reservacion,Boolean estado_codigo)
        {
            Conexion cd_conexionDB = new Conexion(); //instancia de la clases Conexion
            string query = "update tbl_hotel set estado_codigo = @estado_codigo where codigo_reservacion = @codigo_reservacion";//opte desactivar los registros para mantener su integridad comentarios en query de sql
            SqlCommand cmd = new SqlCommand(query, cd_conexionDB.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@estado_codigo", estado_codigo);
            cmd.Parameters.AddWithValue("@codigo_reservacion", codigo_reservacion);
            cmd.ExecuteNonQuery();
            cd_conexionDB.MtdCerrarConexion();
        }
        #endregion














    }
}
