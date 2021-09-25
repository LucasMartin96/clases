using System;
using System.Collections.Generic;
using System.Linq;

namespace Projecto25
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaTiposPrimitivos = new ListaConTiposPrimitivos();
            //listaTiposPrimitivos.Run();

            var listaTiposComplejos = new ListaConTiposComplejos();
            listaTiposComplejos.Run();

        }
    }
}