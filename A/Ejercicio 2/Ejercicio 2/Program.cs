using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese dos numeros");
            num = int.Parse(Console.ReadLine());
            
            if (num %2 == 0)
            {
                Console.WriteLine("El numero " + num + " es par");
            }
            else
            {
                Console.WriteLine("El numero " + num + " no es par");
            }
        }
    }
}
