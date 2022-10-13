using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 2, -5));

            Coche miCoche = new Coche();
            miCoche.Add();
            Console.WriteLine(miCoche.puertas);

            Console.ReadLine();
        }

        static int Sum (int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class Coche
    {
        public int puertas = 3;

        public void Add ()
        {
            puertas++;
        }
    }
}




//Crear una función con tres parámetros que sean números que se suman entre sí.

//Llamar a la función en el main y darle valores.