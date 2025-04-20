using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        #region = "P.NO. 1 Creación conexión y validación de Status";
        //cadena de conexión
        private SqlConnection db_conexion = new SqlConnection("Data Source=Fuentes-Elmer;Initial Catalog=Sistema_Hotel;Integrated Security=True;Encrypt=False");

        public SqlConnection MtdAbrirConexion() //abrir conexión
        {
            if (db_conexion.State == ConnectionState.Closed) //Verifica si la conexión es cerrada
                db_conexion.Open(); //devuelve la conexión abierta
            return db_conexion; //retornar conexión OK
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Open) //verifica si la conezión es abierta
                db_conexion.Close(); // cierra la conexión
            return db_conexion; //retorna la conexión cerrada
        }
        #endregion;

    }
}
