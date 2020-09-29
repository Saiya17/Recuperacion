using System;
using System.Collections.Generic;
using System.Text;

namespace Recuperacion
{
    public class ClienteAlquiler //clase intermedia entre CLIENTE y ALQUILER
    {
        public ClienteAlquiler() //constructor vacío
        {
        }

        //constructor con los parámetros
        public ClienteAlquiler(string nombre, string apellido, int posicionAmarre)
        {
            Nombre = nombre;
            Apellido = apellido;
            PosicionAmarre = posicionAmarre;
        }

        //atributos de la clase intermedia
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PosicionAmarre { get; set; }
    }
}
