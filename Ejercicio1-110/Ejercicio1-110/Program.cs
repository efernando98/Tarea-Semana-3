//Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.

using System;


namespace Ejercicio1110

{
	class Program
	{
		static void Main(string[] args)
		{
				
	            int numero = 0;
	            Console.Write("Ingrese un numero para determinar si es par o impar: ");
	            numero = Convert.ToInt32(Console.ReadLine());
	

	            if (numero % 2 == 0)
	            {
	                Console.WriteLine($"El numero {numero} es par ");
	            }
	            else
	            {
	                Console.WriteLine($"El numero {numero} es impar");
	            }
	        }
	    }
	}
