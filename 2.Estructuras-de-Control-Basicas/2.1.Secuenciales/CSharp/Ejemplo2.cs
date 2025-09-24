using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hallar el volumen del cilindro 
             */

            double Radio, Altura;
            double volumen, pi;


            //Inicio 

            Console.WriteLine("Ingrese el radio del cilindro: ");
            Radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro: ");
            Altura = double.Parse(Console.ReadLine());

            //Proceso 
            pi = 3.1415;
            volumen = Math.PI * (Radio * Radio) * (Altura);

            //Salida

            Console.WriteLine("El volumen del cilindro es de: " + volumen);


            Console.ReadKey();
        }
    }
}