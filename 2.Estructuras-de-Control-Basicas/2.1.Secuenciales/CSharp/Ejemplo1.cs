using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*Hallar el costo total a pagar por estacionamiento si el monto por hora cuesta S/. 2.5. , según la horas ingresadas
        por teclado*/

        int hora; 
        double total, costo; 
        
        //Inicio 

            Console.WriteLine("Ingrese la cantidad de horas en el estacionamientro: ");
            hora = int.Parse(Console.ReadLine());

            //Proceso 

            costo = (hora * 2.5);
            total = costo;

            //Salida 


            Console.WriteLine("El costo total es de: " + total);

            Console.ReadKey(); 
            
        }
    }    
}    