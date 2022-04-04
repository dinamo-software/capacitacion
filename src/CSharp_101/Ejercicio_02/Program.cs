using System;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string espacio = " ";
            string hola = "HOLA";
            string mundo = "MUNDO";
            string saludo = hola + espacio + mundo;

            char[] a1 = new char[2];


            char[] array = mundo.ToCharArray();
            Console.WriteLine(mundo.Length);

            //int indice = 0;
            //do
            //{
            //    Console.Write(array[indice]);
            //    indice = indice + 1;
            //} while (indice < 5);


            //int i = 0;
            //while (i < mundo.Length)
            //{
            //    Console.Write(array[i]);
            //    i++;
            //}

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[i]);
            }

            // if .. else 


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // hacer manipulacion de arreglos de enteros => int[] = new int[10];

        }
    }
}
