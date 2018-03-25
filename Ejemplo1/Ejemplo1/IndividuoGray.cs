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
    class IndividuoGray
    {
        Cromosoma cromosoma;//declaracion cromosoma 
        public IndividuoGray(int num_bits)
        {
            cromosoma = new Cromosoma(num_bits); // creacion cromosoma
            cromosoma.inicializa(new Random(Guid.NewGuid().GetHashCode())); //inicializamos cromosoma
        }
        //------------------------
        public override string ToString()
        {
            return string.Format("[" + cromosoma.getGeneGray() + "]: " + cromosoma.GetValue()); //formato para mostrar cromosoma
        }
    }
}
