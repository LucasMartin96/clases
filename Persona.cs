using System;

namespace Projecto25
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Dni { get; set; }


        public int CalcularAnioNacimiento()
        {
            var anioActual = DateTime.Now.Year;

            return anioActual - Edad;
        }

        public override string ToString()
        {
            return $"{nameof(Nombre)}: {Nombre}, {nameof(Apellido)}: {Apellido}, {nameof(Edad)}: {Edad}, {nameof(Dni)}: {Dni}";
        }
    }
}