using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TPV
{
    class claseAccesoBD
    {
        public List<claseFruta> listaFrutas = new List<claseFruta>();

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader datos;

        public claseAccesoBD ()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost;Database=dam2024;Uid=root;pwd='';old guids=true";
        }

        public List<claseFruta> listarFrutas()
        {
            conexion.Close();
            List<claseFruta> listFr = new List<claseFruta>();
            conexion.Open();
            String cadenasql = "SELECT * FROM frutas WHERE activo = 1";
            comando = new MySqlCommand(cadenasql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                claseFruta cf = new claseFruta();
                cf.Id = Convert.ToInt32(datos["id"]);
                cf.Imagen = (byte[])(datos["imagen"]);
                cf.Nombre = Convert.ToString(datos["nombre"]);
                cf.Precio = float.Parse(Convert.ToString(datos["precio"]));
                cf.Stock = Convert.ToDouble(datos["stock"]);
                listFr.Add(cf);
            }
            conexion.Close();
            return listFr;
        }

        internal void modificarStock(List<claseCesta> listaCesta, List<claseFruta> listaFrutas) //Cambiar stock al pagar
        {
            foreach (claseCesta c in listaCesta)
            {
                for (int i = 0; i < listaFrutas.Count; i++)
                {
                    if (c.Nombre == listaFrutas[i].Nombre)
                    {
                        conexion.Open();
                        String cadenasql = "UPDATE frutas SET stock = " + listaFrutas[i].Stock + " WHERE id = ?id";
                        comando = new MySqlCommand(cadenasql, conexion);
                        comando.Parameters.AddWithValue("?id", listaFrutas[i].Id);
                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
                listaFrutas.Clear();
                listaFrutas = listarFrutas();
            }

        }

        internal void insertarStock(double stock, int id) // Añadir stock a  la fruta
        {
            conexion.Open();
            String cadenasql = "UPDATE frutas SET stock = stock + ?stc WHERE id = ?id";
            comando = new MySqlCommand(cadenasql, conexion);
            comando.Parameters.AddWithValue("?stc", stock);
            comando.Parameters.AddWithValue("?id", id);
            comando.ExecuteNonQuery();
            listaFrutas.Clear();
            listaFrutas = listarFrutas();
            conexion.Close();
        }

        internal void insertarFruta(int id, string nombre, double precio, byte[] imagen)
        {
            conexion.Open();
            String cadenasql;
                cadenasql = "INSERT INTO frutas VALUES (?id, ?nom, ?pre, ?img, 1000, 1)";

            comando = new MySqlCommand(cadenasql, conexion);
            comando.Parameters.AddWithValue("?id", id);
            comando.Parameters.AddWithValue("?nom", nombre);
            comando.Parameters.AddWithValue("?pre", precio);
            comando.Parameters.AddWithValue("?img", imagen);
            comando.ExecuteNonQuery();
            listaFrutas.Clear();
            listaFrutas = listarFrutas();
            conexion.Close();
        }

        internal void eliminarFruta(int id)
        {
            conexion.Open();
            String cadenasql = "UPDATE frutas SET activo = 0 WHERE id = " + id;
            comando = new MySqlCommand(cadenasql, conexion);
            comando.ExecuteNonQuery();
            listaFrutas.Clear();
            listaFrutas = listarFrutas();
            conexion.Close();
        }

        internal void modificarFruta(string nombre, double precio, byte[] imagen, String procedencia)
        {
            conexion.Open();
            int idBus;
            String cadenasql2 = "SELECT id FROM frutas WHERE nombre = ?nom";
            comando = new MySqlCommand(cadenasql2, conexion);
            comando.Parameters.AddWithValue("?nom", nombre);
            datos = comando.ExecuteReader();
            datos.Read();
            idBus = datos.GetInt32(0);
            conexion.Close();
            conexion.Open();
            String cadenasql = "UPDATE frutas SET nombre = ?nom, precio = ?pre, imagen = ?img, activo = 1 WHERE nombre = ?nom";
            comando = new MySqlCommand(cadenasql, conexion);
            comando.Parameters.AddWithValue("?id", idBus);
            comando.Parameters.AddWithValue("?nom", nombre);
            comando.Parameters.AddWithValue("?pre", precio);
            comando.Parameters.AddWithValue("?img", imagen);
            comando.ExecuteNonQuery();
            listaFrutas.Clear();
            listaFrutas = listarFrutas();
            conexion.Close();
        }
    }
}
