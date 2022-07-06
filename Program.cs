using System;

namespace ConsoleApp3Ejercicio2deCastagnerisSebastian
{
	class Ejercicio2decastagnerissebasitan
	{

		static double perimetro(double a, double b, double c)
		{
			double resultado;
	
			if (a + b > c && a + c > b && b + c > a)
			{
				resultado = a + b + c;

			}
			return resultado;



		}

		static double superficie(double a, double b, double c)
		{
			double p;
			double resultado;
			p = a + b + c / 2;
			if (a + b > c && a + c > b && b + c > a)
			{
				resultado = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			}
			return resultado;

		}

		static void Main(string[] args)
		{
			double ladoA, ladoB, ladoC;
			
		
			Console.Write("Ingrese el valor del Lado A: ");
			ladoA = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor del Lado B: ");
			ladoB = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese el valor del Lado C: ");
			ladoC = Double.Parse(Console.ReadLine());
			if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA && (ladoA) + (ladoB) + (ladoC) >= 0)
			{
				if (Math.Pow(ladoA, 2) == Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
				{
					Console.WriteLine($"Los valores ingresados equivalen a un Triangulo Rectangulo.");
					Console.WriteLine($"El perimetro del triangulo es " + perimetro(ladoA, ladoB, ladoC));
					Console.WriteLine($"La superificie del triangulo es " + superficie(ladoA, ladoB, ladoC));
				}
				else
				{
					if (Math.Pow(ladoA, 2) < Math.Pow(ladoB, 2) + Math.Pow(ladoC, 2))
					{
						Console.WriteLine($"Los valores ingresados equivalen a un Triangulo Acutangulo.");
						Console.WriteLine($"El perimetro del triangulo es " + perimetro(ladoA, ladoB, ladoC));
						Console.WriteLine($"La superificie del triangulo es " + superficie(ladoA, ladoB, ladoC));
					}
					else
					{
						Console.WriteLine($"Los valores ingresados equivalen a un Triangulo Obtusangulo.");
						Console.WriteLine($"El perimetro del triangulo es " + perimetro(ladoA, ladoB, ladoC));
						Console.WriteLine($"La superificie del triangulo es " + superficie(ladoA, ladoB, ladoC));
					}
				}
			}
			else
			{
				Console.WriteLine($"Los valores ingresados no se encuentran dentro de los parametros establecidos.");
			}

			Console.ReadLine();
		}

	}

}


