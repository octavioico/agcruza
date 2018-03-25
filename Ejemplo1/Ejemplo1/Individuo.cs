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
    class Individuo
    {
        
        Cromosoma cromosoma; //declarar cromosoma 
        public Individuo(int num_bits)
        {
            cromosoma = new Cromosoma(num_bits); // crear cromosoma
            cromosoma.inicializa(new Random(Guid.NewGuid().GetHashCode())); // inicializar cromosoma
        }
        //------------------------
        public override string ToString()
        {
            return string.Format("["+ cromosoma.getGene()  + "]: "+ cromosoma.GetValue()+"\n"); //formato muestreo cromosoma
        }
        public Individuo[] Cross1P(Individuo madre)
        {
            Individuo[] hijos = new Individuo[2];//Arreglo cromosomas hijos
            hijos[0] = new Individuo(madre.cromosoma.getBitsPG());//Creamos cromosoma hijo 0
            int[] gen = new int[madre.cromosoma.getBitsPG()]; ; //declaracion gen auxiliar hijo 0
            hijos[1] = new Individuo(madre.cromosoma.getBitsPG());//Crear cromosoma hijo 1
            int[] gen2 = new int[madre.cromosoma.getBitsPG()]; ; //declaracion gen auxiliar hijo 1
            int crosspoint = new Random(Guid.NewGuid().GetHashCode()).Next(3, 5);//generamos punto aleatorio para cruza
            Console.WriteLine("\nPunto de Cruza: " + crosspoint + "\n");//Mostramospunto cruza
            //Algoritmo que junta partes de cada padre en cada hijo
            for (int i = 0; i < madre.cromosoma.getBitsPG(); i++)
            {
                //Si i es menor al punto de cruza metemos la primer parte del padre en hijo 0 y primer parte madre hijo 1
                if (i <= crosspoint) {
                    gen[i] = Int32.Parse(this.cromosoma.getGene().ElementAt(i).ToString());
                    gen2[i] = Int32.Parse(madre.cromosoma.getGene().ElementAt(i).ToString());
                }
                //Si i es mayor al punto de cruza metemos la segunda parte del padre en hijo 1 y segunda parte madre hijo 0
                else
                {
                    gen[i] = Int32.Parse(madre.cromosoma.getGene().ElementAt(i).ToString());
                    gen2[i] = Int32.Parse(this.cromosoma.getGene().ElementAt(i).ToString());
                }
            }
            //Ingresamos el gen mezclado en cada hijo
            hijos[0].cromosoma.setGene(gen);
            hijos[1].cromosoma.setGene(gen2);
            //retornamos los hijos creados
            return hijos;
        }
    }
}
