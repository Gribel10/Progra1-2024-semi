using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miprimerproyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Suma de dos numeros

            Console.Write("num1:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("num2:");
            double num2 = double.Parse(Console.ReadLine());

            double respuesta = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, respuesta);



            //Pausa
            Console.ReadLine();
        }
    }
}
