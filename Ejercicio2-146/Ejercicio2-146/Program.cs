//Hacer un programa que calcule el resultado de un número elevado a cualquier potencia. 

using System;


namespace Ejercicio2146
{
	class Program
	{
		static void Main(string[] args)
		{
			
			int numero, elevacion, resultado = 1;


			Console.Write("Ingrese numero: ");
			numero = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese la elevacion: ");
			elevacion = Convert.ToInt32(Console.ReadLine());


			for (int i = 1; i <= elevacion; i++)
			{
				resultado *= numero;
			}
			Console.WriteLine($"El resultado es {resultado}");
		}
	}
}
