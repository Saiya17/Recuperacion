using System;
using System.Collections.Generic;
using System.Linq;


namespace Recuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alquiler para el amarre de diferentes tipos de barcos");
            Console.WriteLine();

            //lista de CLIENTE
            List<CLIENTE> cliente = new List<CLIENTE>
            { 
                new CLIENTE {Nombre= "Sergio", Apellido= "Vélez", Cedula= 1315859403, Identificador= 1, DiaRegistro="Lunes"},
                new CLIENTE {Nombre= "Nayeli", Apellido= "Alvarez", Cedula= 0927384922, Identificador= 2, DiaRegistro="Sábado"},
                new CLIENTE {Nombre= "Alfredo", Apellido= "Andrade", Cedula= 1315666278, Identificador= 3, DiaRegistro="Martes"},
                new CLIENTE {Nombre= "Carlos", Apellido= "Moreno", Cedula= 0803746574, Identificador= 4, DiaRegistro="Lunes"},
                new CLIENTE {Nombre= "Andrea", Apellido= "Valdez", Cedula= 1315833356, Identificador= 5, DiaRegistro="Domingo"},
                new CLIENTE {Nombre= "Mario", Apellido= "Gavilanez", Cedula= 1315226756, Identificador= 6, DiaRegistro="Jueves"},
                new CLIENTE {Nombre= "Felipe", Apellido= "Hurtado", Cedula= 131595846, Identificador= 7, DiaRegistro="Lunes"},
                new CLIENTE {Nombre= "Antonia", Apellido= "Dominguez", Cedula= 1315835893, Identificador= 8, DiaRegistro="Viernes"},
            };

            //lista de ALQUILER
            List<ALQUILER> alquiler = new List<ALQUILER>
            { 
                new ALQUILER {FechaInicial="24 de junio", FechaFinal= "30 de junio", PosicionAmarre=0, Barco="Velero", },
                new ALQUILER {FechaInicial="12 de agosto", FechaFinal= "18 de agosto", PosicionAmarre=1, Barco="Deportivo"},
                new ALQUILER {FechaInicial="14 de septiembre", FechaFinal= "25 de septiembre", PosicionAmarre=2, Barco="Deportivo"},
                new ALQUILER {FechaInicial="1 de julio", FechaFinal= "9 de julio", PosicionAmarre=1, Barco="Yate"},
                new ALQUILER {FechaInicial="4 de enero", FechaFinal= "16 de enero", PosicionAmarre=0, Barco="Yate"},
                new ALQUILER {FechaInicial="10 de mayo", FechaFinal= "14 de mayo", PosicionAmarre=5, Barco="Velero"},
                new ALQUILER {FechaInicial="28 de septiembre", FechaFinal= "5 de octubre", PosicionAmarre=3, Barco="Yate"},
                new ALQUILER {FechaInicial="31 de octubre", FechaFinal= "9 de noviembre", PosicionAmarre=9, Barco="Deportivo"},
            };

            //lista de ClienteAlquiler
            List<ClienteAlquiler> clienteAlquiler = new List<ClienteAlquiler>
            {
                new ClienteAlquiler {Nombre= "Sergio", Apellido= "Vélez", PosicionAmarre=0 },
                new ClienteAlquiler {Nombre= "Nayeli", Apellido= "Alvarez", PosicionAmarre=1 },
                new ClienteAlquiler {Nombre= "Alfredo", Apellido= "Andrade", PosicionAmarre=2 },
                new ClienteAlquiler {Nombre= "Carlos", Apellido= "Moreno", PosicionAmarre=1 },
                new ClienteAlquiler {Nombre= "Andrea", Apellido= "Valdez", PosicionAmarre=0 },
                new ClienteAlquiler {Nombre= "Mario", Apellido= "Gavilanez", PosicionAmarre=5 },
                new ClienteAlquiler {Nombre= "Felipe", Apellido= "Hurtado", PosicionAmarre=3 },
                new ClienteAlquiler {Nombre= "Antonia", Apellido= "Dominguez", PosicionAmarre=9 },
            };

            BarcoDeportivo barco = new BarcoDeportivo();
            barco.PrecioAlquiler();

            BarcoVelero barcoVelero = new BarcoVelero();
            barcoVelero.PrecioAlquiler();

            Yates yates = new Yates();
            yates.PrecioAlquiler();

            Console.WriteLine();
            //primer consulta
            IEnumerable<string> consulta = cliente.Where(p => p.Identificador == 1).Select(p => p.Nombre);
            foreach (string item in consulta)
            {
                Console.WriteLine("El cliente con identificación 1 es: " + item);
            }

            Console.WriteLine();
            //segunda consulta
            IEnumerable<string> registro = cliente.Where(p => p.DiaRegistro == "Lunes").Select(p => p.Nombre);
            foreach (string item in registro)
            {
                Console.WriteLine("Los clientes registrados el día lunes son: " + item);
            }

            Console.WriteLine();
            //tercera consulta
            var amarre = clienteAlquiler.Where(p => p.PosicionAmarre >= 1).Select(p => new { nombre = p.Nombre, posicion = p.PosicionAmarre });
            foreach (var item in amarre)
            {
               Console.WriteLine("Los clientes: " + item.nombre + " tienen la cantidad de: " +item.posicion + " alquileres de amarre");
            }

            Console.Read();
        }
    }
}
