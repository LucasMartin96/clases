using System;
using System.Collections.Generic;

namespace Projecto25
{
    public class ListaConTiposComplejos
    {
        public void Run()
        {
            var p1 = new Persona
            {
                Nombre = "Lucas",
                Apellido = "Martin",
                Edad = 25,
                Dni = "39622721"
            };
            var p2 = new Persona
            {
                Nombre = "Emanuel",
                Apellido = "Aguirre",
                Edad = 21,
                Dni = "40909000"
            };
            var p3 = new Persona
            {
                Nombre = "Gabriel",
                Apellido = "Romag",
                Edad = 30,
                Dni = "3122221"
            };
            var p4 = new Persona
            {
                Nombre = "Gaston",
                Apellido = "Brob",
                Edad = 25,
                Dni = "7888832"
            };
            var p5 = new Persona
            {
                Nombre = "Juan",
                Apellido = "Moyano",
                Edad = 19,
                Dni = "399772423"
            };
            var p6 = new Persona
            {
                Nombre = "Lucia",
                Apellido = "Guzman",
                Edad = 24,
                Dni = "39977222"
            };

            var personas = new List<Persona>();
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            personas.Add(p4);
            personas.Add(p5);
            personas.Add(p6);
            Console.WriteLine("----------------------------------------------------");
            foreach (var persona in personas)
            {
                Console.WriteLine(persona);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            foreach (var persona in personas)
            {
                Console.WriteLine(persona.CalcularAnioNacimiento());
                
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < personas.Count; i++)
            {
                Console.WriteLine(personas[i].CalcularAnioNacimiento());
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            // Buscador por anio de nacimiento

            var anioABuscar = 1996;
            foreach (var persona in personas)
            {
                if (persona.CalcularAnioNacimiento() == anioABuscar)
                {
                    Console.WriteLine(persona);
                }
            }
        }
    }
}