﻿//Calcular la serie de un número

using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 0, a = 0, b = 1, auxiliar;
            Console.WriteLine("Ingrese un numero para calcular su serie: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                Console.WriteLine(b);
            }

        }
    }
}