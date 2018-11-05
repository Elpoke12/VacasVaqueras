using System;
using System.Collections;
using System.Collections.Generic;

namespace VacasVaqueras
{
	class Program
	{
		public static int Sumas(IEnumerable VacasLecheras)
		{
			int suma = 0;
            foreach (Object obj in VacasLecheras)
			{
				suma = suma + int.Parse(string.Format("{0}", obj));
			}
			return suma;
		}
		static void Main(string[] args)
		{
			Stack<int> VacasVaqueras = new Stack<int>();
			Console.WriteLine(" Mazie= 2 minutos ");
			Console.WriteLine(" Daisy= 4 minutos ");
			Console.WriteLine(" Crazy= 10 minutos ");
			Console.WriteLine(" Lazy= 20 minutos ");
			Console.WriteLine(" Bob= 2 minutos");
			VacasVaqueras.Push(2);
			VacasVaqueras.Push(2);
			VacasVaqueras.Push(4);
			VacasVaqueras.Push(2);
			VacasVaqueras.Push(20);
			Console.WriteLine(" La suma de los minutos es de: " + Sumas(VacasVaqueras));
			Console.ReadKey();
		}
	}
}
