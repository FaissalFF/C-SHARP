using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExamen
{
    class chat
    {
        int id;
        String mensaje;
        int nmensaje;

        public chat()
        {

        }
        public chat(int id, string mensaje, int nmensaje)
        {
            this.Id = id;
            this.Mensaje = mensaje;
            this.Nmensaje = nmensaje;
        }

        public int Id { get => id; set => id = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public int Nmensaje { get => nmensaje; set => nmensaje = value; }
    }
}
