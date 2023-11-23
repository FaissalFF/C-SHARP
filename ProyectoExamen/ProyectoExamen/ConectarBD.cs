using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoExamen
{
    class ConectarBD
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlCommand comando2;
        MySqlDataReader datos;
        MySqlDataReader datos2;

        public ConectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=db4free.net; database = chatfaimus; user= faimus; pwd= faimus1234; old guids = true";
        }

        internal void insertarMensaje(string mensaje)
        {
            int cont;
            int mensajeactual;
            conexion.Open();
            String cadenasql2 = "SELECT MAX(MensajeN) FROM chat WHERE id = 1";
            comando2 = new MySqlCommand(cadenasql2, conexion);
            datos2 = comando2.ExecuteReader();
            datos2.Read();
            cont = Convert.ToInt32(datos2.GetString(0));
            mensajeactual = cont + 1;
            conexion.Close();
            conexion.Open();
            String cadenasql = "INSERT INTO chat values (1, ?men, ?con)";
            comando = new MySqlCommand(cadenasql,conexion);
            comando.Parameters.AddWithValue("?men", mensaje);
            comando.Parameters.AddWithValue("?con", mensajeactual);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public String mostrarMensaje()
        {
            String mensaje;
            conexion.Open();
            String cadenasql = "SELECT mensaje FROM chat WHERE id = 2 AND MensajeN = (SELECT MAX(MensajeN) FROM chat WHERE id = 2)";
            comando = new MySqlCommand(cadenasql, conexion);
            datos = comando.ExecuteReader();
            datos.Read();
            mensaje = Convert.ToString(datos["mensaje"]);
            conexion.Close();
            return mensaje;
        }

        public chat retornarObjeto()
        {
            chat ch = new chat();
            conexion.Open();
            String cadenasql = "SELECT * from chat WHERE id = 2 AND mensajeN = (SELECT MAX(mensajeN) FROM chat WHERE id = 2)";
            comando = new MySqlCommand(cadenasql, conexion);
            datos = comando.ExecuteReader();
            datos.Read();
            ch.Id = 1;
            ch.Mensaje = datos.GetString(1);
            ch.Nmensaje = Convert.ToInt32(datos.GetString(2));
            conexion.Close();
            return ch;
        }
    }
}
