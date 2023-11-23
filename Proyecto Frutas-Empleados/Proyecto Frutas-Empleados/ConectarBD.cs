using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_Frutas_Empleados
{
    class ConectarBD
    {
        MySqlCommand comando;
        MySqlConnection conexion;
        MySqlDataReader datos;

        public ConectarBD()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; Database=dam2024; user=root; pwd=''; old guids = true";
        }

        public List<Empleados> listarEmpleados()
        {
            List<Empleados> listaEM = new List<Empleados>();
            conexion.Open();
            String cadenasql = "SELECT * FROM empleados";
            comando = new MySqlCommand(cadenasql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Empleados em = new Empleados();
                em.Dni = datos.GetString(0);
                em.Nombre = datos.GetString(1);
                em.Nivel = Convert.ToInt32(datos.GetString(2));
                em.Imagen = datos.GetString(3);
                listaEM.Add(em);
            }
            conexion.Close();
            return listaEM;
        }

        public List<Frutas> listarFrutas()
        {
            List<Frutas> listaFr = new List<Frutas>();
            conexion.Open();
            String cadenasql = "SELECT * FROM frutas";
            comando = new MySqlCommand(cadenasql, conexion);
            datos = comando.ExecuteReader();
            while (datos.Read())
            {
                Frutas fr = new Frutas();
                fr.Id = Convert.ToInt32(datos["id"]);
                fr.Nombre = Convert.ToString(datos["nombre"]);
                fr.Precio = Convert.ToDouble(datos["precio"]);
                fr.Imagen = (byte[])datos["imagen"];
                listaFr.Add(fr);
            }
            conexion.Close();
            return listaFr;
        }

        internal void InsertarFruta(string nombre, double precio, byte[] bloque)
        {
            conexion.Open();
            String cadenasql = "INSERT INTO frutas (id, nombre, precio, imagen) values(1, ?nom, ?pre, ?img)";
            comando = new MySqlCommand(cadenasql, conexion);
            comando.Parameters.AddWithValue("?nom", nombre);
            comando.Parameters.AddWithValue("?pre", precio);
            comando.Parameters.AddWithValue("?img", bloque);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
