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
        public DataTable MtdConsultarClientes()
        {
            Conexion cd_conexionDB = new Conexion(); //instancia de la clases cd_conexion_bdd
            string QuerySelect = "SELECT * FROM hotel";//almacenar en queryselect = la consulta de sql
            SqlDataAdapter adapter = new SqlDataAdapter(QuerySelect, cd_conexionDB.MtdAbrirConexion());//intermediario entre la base de datos y aplicación
            //llenar los datos resultantes en una estructura en memoria, como un DataTable
            DataTable dt_clientes = new DataTable();//estructura en memoria contiene el query
            adapter.Fill(dt_clientes);//ejecuta la consulta SQL definida en el SqlDataAdapter y llena el DataTable (dt_clientes) con los datos obtenidos de la base de datos. 
            cd_conexionDB.MtdCerrarConexion();//cierra la conexión
            return dt_clientes; //devuelve el dataTable.
        }
        #endregion

    }
}
