using System;
using System.Collections.Generic;

namespace Projecto25
{
    public class ListaConTiposPrimitivos
    {
        public void Run()
        {
                        var list = new List<string>();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list);
            Console.WriteLine("----------------------------------------------------");
            // Add: Agrega un item a la fila
            list.Add("Lucas");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list[0]);
            Console.WriteLine("----------------------------------------------------");
            list.Add("Emma");
            list.Add("Brenda");
            list.Add("Lucia");
            list.Add("Gabriel");
            list.Add("Emma");
            list.Add("Gaston");
            list.Add("Juan");
            list.Add("Julieta");
            list.Add("Emma");
            // Nos devuelve la cantidad de elementos en la fila
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.Count);
            Console.WriteLine("----------------------------------------------------");
            // Nos devuelve la primera posicion en la lista(indice) del item buscado 
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.IndexOf("Emma"));
            Console.WriteLine("----------------------------------------------------");
            // Nos devuelve la primera posicion en la lista(indice) del item buscado y un indice a apartir del cual
            // buscar
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.IndexOf("Emma",2));
            Console.WriteLine("----------------------------------------------------");
            
            // List = Lucas, Emma, Brenda, Lucia, Gabriel, Emma
            // Lim inferior = 2 (brenda) - Lim Superior = 4 (Gabriel)
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.IndexOf("Emma",2,2));
            Console.WriteLine("----------------------------------------------------");
            
            // Permite eliminar un item de la lista
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.Remove("Emma1"));
            Console.WriteLine(list.Count);
            Console.WriteLine("----------------------------------------------------");
            
            // Permite obtener el ultimo indice del objeto buscado.
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.LastIndexOf("Emma"));
            Console.WriteLine("----------------------------------------------------");
            
            
            // Permite convertir el objeto de List<String> -> String[]
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(list.ToArray());
            Console.WriteLine("----------------------------------------------------");
            
            
            // Recorrer lista
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("----------------------------------------------------");
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("------------------------" + i +"----------------------------");
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");
            
            var posicionesList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "Emma")
                {
                    posicionesList.Add(i);
                }
            }
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Lista de posiciones");
            foreach (var pos in posicionesList)
            {
                
                Console.WriteLine(pos);
            }
        }
    }
}