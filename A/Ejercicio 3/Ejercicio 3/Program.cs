using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Leer tres números y escribir el mayor de los tres
namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Ingrese tres numeros");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                if (num2 < num3)
                {
                    Console.WriteLine("El numero mayor es el numero 3 = " + num3);
                }
                else { Console.WriteLine("El numero mayor es el numero 2 = " + num2); }
            }
            else
            {
                if (num1 < num3)
                {
                    Console.WriteLine("El numero mayor es el numero 3 = " + num3);
                }
                else { Console.WriteLine("El numero mayor es el numero 1 = " + num1); }
                
            } Console.Read();
        }
    }
}
