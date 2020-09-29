using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Recuperacion
{
    public class BarcoDeportivo : BARCO //hereda atributos de la clase BARCO
    {
        //atributo propio de la clase BarcoDeportivo
        public int Potencia { get; set; }

        //se sobreescribe el método de la clase BARCO
        public override void PrecioAlquiler()
        {
            double modulo, precio, diasOcupacion;
            Console.WriteLine("Ingrese el largo del barco deportivo: ");
            LargoMetro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de potencia: ");
            Potencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los días que será ocupado el barco deportivo: ");
            diasOcupacion = Convert.ToInt32(Console.ReadLine());

            //se realiza la operación para saber el precio de alquiler del barco
            modulo = (0.3 * LargoMetro * Potencia);
            precio = ((diasOcupacion - 2) * modulo * 0.8);
            Console.WriteLine("El precio del barco deportivo es: " + precio);
        }
    }
}
