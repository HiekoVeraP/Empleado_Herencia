using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("El numero mayor es el segundo = "+num2);
            }
            if (num2 < num1)
            {
                Console.WriteLine("El numero mayor es el primero = " + num1);
            }
            Console.Read();
        }
    }
}
