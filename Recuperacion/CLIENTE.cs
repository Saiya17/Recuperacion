using System;
using System.Collections.Generic;
using System.Text;

namespace Recuperacion
{
    public class CLIENTE
    {
        public CLIENTE() //constructor vacío
        {
        }

        //constructor con los parámetros
        public CLIENTE(string nombre, string apellido, int cedula, int identificador, string diaRegistro)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Identificador = identificador;
            DiaRegistro = diaRegistro;
        }

        //atributos de la clase CLIENTE
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public int Identificador { get; set; }
        public string DiaRegistro { get; set; }
    }
}
