using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora V.1");

            //Aca definimos las variables 
            int numero1 = 20;
            int numero2 = 30;

            Console.WriteLine("El primer numero es: " + numero1);
            Console.WriteLine("El segundo numero es: " + numero2);

            int suma = numero1 + numero2;

            Console.WriteLine("La suma es: " + suma);

            int resta = numero1 - numero2;

            Console.WriteLine("La resta es: " + resta);


            Console.Read();
        }
    }
}
