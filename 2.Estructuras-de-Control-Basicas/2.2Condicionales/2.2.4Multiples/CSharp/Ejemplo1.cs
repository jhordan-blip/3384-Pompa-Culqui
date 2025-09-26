using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int calificacion;
            Console.WriteLine("Introduce tu calificación (A, B, C): ");
            calificacion = int.Parse(Console.ReadLine());

            switch (calificacion)
            {
                case 'A': Console.WriteLine("Excelente"); break;
                case 'B': Console.WriteLine("Bueno"); break;
                case 'C': Console.WriteLine("Regular"); break;
                default: Console.WriteLine("Calificación no válida"); break;
            }

            Console.ReadKey();
        }
    }
}