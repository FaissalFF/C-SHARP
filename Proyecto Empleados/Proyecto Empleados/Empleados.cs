using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Empleados
{
    class Empleados
    {
        String dni;
        String contra;
        int nivel;
        String imagen;

        public Empleados()
        {

        }

        public Empleados(string dni, string contra, int nivel, string imagen)
        {
            this.Dni = dni;
            this.Contra = contra;
            this.Nivel = nivel;
            this.Imagen = imagen;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
