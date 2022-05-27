using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Modificar el programa anterior para que en lugar de leer 8 números, se puedan leer tantos números como se quiera hasta que llegue un cero. El resultado es la suma de todos los números leídos.
namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, num, nummaximo;
            Console.WriteLine("Ingrese el numero maximo de veces que se quiera sumar ");
            nummaximo = int.Parse(Console.ReadLine());
            for (int i = 0; i < nummaximo; i++)
            {
                Console.WriteLine("Ingrese un numero ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero ingresado es = " + num + "\n");
                suma = num + suma;
            }
            Console.WriteLine("La suma total es de = " + suma);
        }
    }
}
