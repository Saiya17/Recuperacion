using System;
using System.Collections.Generic;
using System.Text;

namespace Recuperacion
{
    public class Yates : BARCO//hereda atributos de la clase BARCO
    {
        //atributos propios de la clase Yates
        public int Potencia { get; set; }
        public int Camarotes { get; set; }

        //se sobreescribe el método de la clase BARCO
        public override void PrecioAlquiler()
        {
            double  modulo, precio, diasOcupacion;
            Console.WriteLine("Ingrese el largo del yate: ");
            LargoMetro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de potencia: ");
            Potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de camarotes: ");
            Camarotes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los días que será ocupado el yate: ");
            diasOcupacion = Convert.ToInt32(Console.ReadLine());

            //se realiza la operación para saber el precio de alquiler del barco
            modulo = (0.3 * LargoMetro * Potencia * Camarotes);
            precio = ((diasOcupacion-2) * modulo * 0.8);
            Console.WriteLine("El precio del yate es: " + precio);
        }
    }
}
