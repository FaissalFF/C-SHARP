using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Empleados
{
    class ConectarBD
    {
        MySqlDataReader datos;
        MySqlCommand comando;
        MySqlConnection conexion;

        public ConectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server= db4free.net; Database = dam2024; user= vituki;pwd= pilukina2024; old guids = true";
        }

        public List<Empleados> ListarEmpleados()
        {
            conexion.Open();
            List<Empleados> listaEm = new List<Empleados>();
            String cadenasql = "SELECT * FROM empleados";
            comando = new MySqlCommand(cadenasql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Empleados em = new Empleados();
                em.Dni = Convert.ToString(datos["dni"]);
                em.Contra = Convert.ToString(datos.GetString(1));
                em.Nivel = Convert.ToInt32(datos["nivel"]);
                em.Imagen = Convert.ToString(datos["imagen"]);
            }
            conexion.Close();
            return listaEm;
        }

        internal void InsertarEmpleado(string dni, string contrasena, int nivel, string imagen)
        {
            conexion.Open();
            String cadenasql = "INSERT INTO empleados VALUES(?Dni, ?contra, ?niv, ?img)";
            comando = new MySqlCommand(cadenasql, conexion);
            comando.Parameters.AddWithValue("?Dni", dni);
            comando.Parameters.AddWithValue("?contra", contrasena);
            comando.Parameters.AddWithValue("?niv", nivel);
            comando.Parameters.AddWithValue("?img", imagen);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
