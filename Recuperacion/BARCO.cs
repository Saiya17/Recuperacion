using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Recuperacion
{
    public abstract class BARCO
    {
        public BARCO()//constructor vacío
        {
        }

        //constructor con los parámetros
        protected BARCO(string matricula, int largoMetro, string añoFabricacion, double precio, int diasOcupacion, double modulo)
        {
            Matricula = matricula;
            LargoMetro = largoMetro;
            AñoFabricacion = añoFabricacion;
           // Precio = precio;
           // DiasOcupacion = diasOcupacion;
           // Modulo = modulo;
        }

        //atributos de la clase BARCO
        public string Matricula { get; set; }
        public int LargoMetro { get; set; }
        public string AñoFabricacion { get; set; }
        
        //método abstracto 
        public abstract void PrecioAlquiler();
    }
}
