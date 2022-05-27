using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que lea exactamente 8 números y luego escriba la suma de todos ellos
namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma=0, num;
            for (int i = 0; i <8; i++) 
            {
                Console.WriteLine("Ingrese un numero ");
                num= int.Parse(Console.ReadLine());
                Console.WriteLine("El numero ingresado es = "+num+"\n");
                suma = num + suma;
            }
            Console.WriteLine("La suma total es de = "+suma);
        }
    }
}
