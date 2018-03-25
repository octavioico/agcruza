
/*
UNIVERSIDAD AUTONOMA DEL ESTADO DE MEXICO
CENTRO UNIVERSITARIO UAEM ZUMPANGO
INGENIERIA EN COMPUTACION
ALGORITMOS GENETICOS
ASDRUBAL LOPEZ CHAU
OCTAVIO HERNANDEZ HERNANDEZ
20/03/2018
Laboratorio Operador genético de cruza
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Individuo indp = new Individuo(6); //creacion individuo
            Individuo indm = new Individuo(6); //creacion individuo
            Individuo[] hijos = indp.Cross1P(indm);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Padre\n");
            Console.WriteLine(indp.ToString()); //mostrar individuo
            Console.WriteLine("Madre\n");
            Console.WriteLine(indm.ToString()); //mostrar individuo
            Console.WriteLine("Hijos\n");
            Console.WriteLine(hijos[0].ToString()); //mostrar individuo
            Console.WriteLine(hijos[1].ToString()); //mostrar individuo

            for (int i=0; true;) { }
        }
    }
}
