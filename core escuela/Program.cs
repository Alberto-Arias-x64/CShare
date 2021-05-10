using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("escuela de nepes", 1990);
            escuela.pais = "locombia";
            escuela.ciudad = "zipaquistan";
            escuela.tipoescuela = Tipos_De_Escuela.primaria;
            Console.WriteLine(escuela);
            var curos1 = new Curso()
            {
                nombre = "101"
            };
            var curos2 = new Curso(){nombre = "102"};
            var curos3 = new Curso(){nombre = "103"};
            System.Console.WriteLine("====================");
            Console.WriteLine(curos1.UniqueID);
            Console.WriteLine(curos2.UniqueID);
            Console.WriteLine(curos3.UniqueID);
        }
    }
}
