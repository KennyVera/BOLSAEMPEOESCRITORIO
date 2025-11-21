using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REDEMPLEO
{
    public class ConexionBD
    {
        private SqlConnection conexion;

        // Cambia los valores según tu servidor y base de datos
        // private string cadena = @"Server=DESKTOP-I8UU101\SQLEXPRESS;Database=BOLSAEMPLEO;User Id=KENNYDY;Password=123456;";
        private string cadena = @"Server=HP\SQLEXPRESS;Database=BOLSAEMPLEO;User Id=Heiner;Password=12345;";

        public SqlConnection AbrirConexion()
        {
            if (conexion == null)
                conexion = new SqlConnection(cadena);

            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
        public bool ProbarConexion()
        {
            try
            {
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable MostrarRegistros(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, AbrirConexion()); // Crea un comando SQL con la consulta proporcionada.
            SqlDataAdapter datos = new SqlDataAdapter(comando);       // Usa SqlDataAdapter para llenar el DataTable con los resultados de la consulta.
            DataTable tabla = new DataTable();                        // Crea un nuevo DataTable para almacenar los resultados.
            datos.Fill(tabla);                                        // Llena el DataTable con los datos obtenidos.
            return tabla;                                             // Retorna el DataTable lleno.
        }
    }
}
