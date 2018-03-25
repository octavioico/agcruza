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
    class Cromosoma
    {
        private int BITS_PER_GENE; //variable para saber cuantos bits constara nuestro gen
        private int[] gene; //declaracion gen
        //-------------------------
        //creamo el gene a partir de los bits obtenidos por el paso del parametro en el constructor
        public Cromosoma(int bits)
        {
            BITS_PER_GENE = bits;
            gene = new int[BITS_PER_GENE];
        }
        //-------------------------
        //algoritmo para obtencion del valor decimal (genotipo)
        public double GetValue()
        {
            double value = 0;
            for (int j = 0; j < BITS_PER_GENE-1; j++)
            {
                value += gene[BITS_PER_GENE - j - 1] * Math.Pow(2.0, j);
            }
            if (gene[0] == 1)
            {
                value = -value;
            }
            return value;
        }
        //----------------
        //inicializacion aleatoria del cromosoma
        public void inicializa(Random rnd)
        {
            for (int i = 0; i < BITS_PER_GENE; i++)
            {
                if (rnd.Next(0, 2) == 1)
                {
                    gene[i] = 1;
                }
            }
        }
        //----------------------------
        //algoritmo para mostrar el fenotipo
        public string getGene() {
            string g="";
            for (int i = 0; i < BITS_PER_GENE; i++)
            {
                g += gene[i].ToString();
            }
            return g;
        }
        //-------------------------------
        //algoritmo para mostrar fenotipo en gray
        public string getGeneGray(){
            string g = "";
            g = gene[0].ToString();
            g += gene[1].ToString();
            for (int i = 1; i < BITS_PER_GENE-1; i++)
            {
                if (gene[i] != gene[i + 1])
                    g += 1;
                else
                    g +=0;
            }
            return g;
        }
        public int getBitsPG()
        {
            return BITS_PER_GENE;
        }
        public void setGene(int[] gen)
        {
            gene = gen;
        }

    }
}
