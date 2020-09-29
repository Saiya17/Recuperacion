using System;
using System.Collections.Generic;
using System.Text;

namespace Recuperacion
{
    public class BarcoVelero: BARCO //hereda los atributos de la clase BARCO
    {
        //atributo propio de la clase BarcoVelero
        public int Mastiles { get; set; }

        //se sobreescribe el método de la clase BARCO
        public override void PrecioAlquiler()
        {
            double modulo, precio, diasOcupacion;
            Console.WriteLine("Ingrese el largo del barco velero: ");
            LargoMetro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mastiles: ");
            Mastiles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese los días que será ocupado el velero: ");
            diasOcupacion = Convert.ToInt32(Console.ReadLine());

            //se realiza la operación para saber el precio de alquiler del barco
            modulo = (0.3 * LargoMetro * Mastiles);
            precio = ((diasOcupacion - 2) * modulo * 0.8);
            Console.WriteLine("El precio del barco velero es: " + precio);
        }
    }
}
