using System;
using System.Collections.Generic;
using System.Text;

namespace Recuperacion
{
    public class ALQUILER
    {
        public ALQUILER() //constructor vacío
        {
        }

        //constructor con los parámetros
        public ALQUILER(string fechaInicial, string fechaFinal, int posicionAmarre, string barco)
        {
            FechaInicial = fechaInicial;
            FechaFinal = fechaFinal;
            PosicionAmarre = posicionAmarre;
            Barco = barco;
        }

        //atributos de la clase ALQUILER
        public string FechaInicial { get; set; }
        public string FechaFinal { get; set; }
        public int PosicionAmarre { get; set; }
        public string Barco { get; set; }
    }
}
