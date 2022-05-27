using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que lea números enteros indefinidamente hasta que llegue el número 0
namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int valor=1;
            while (valor != 0) 
            {
                Console.WriteLine("Ingrese un numero");
                valor=int.Parse(Console.ReadLine());
                Console.WriteLine("El valor ingresado es "+valor+ "\n");
            }
            
                
        }
    }
}
