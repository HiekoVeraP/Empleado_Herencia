using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_Herencia
{
    class EmpleadoTemporal : Empleado
    {
        private string fechaEntrada;
        private string fechaSalida;
        private double sueldo;
        public double getsueldo()
        {
            return sueldo;
        }
        public void setsueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }
        public void ingresoSalida()
        {
            Console.WriteLine("Fecha ingreso a la empresa (DD/MM/AA): ");
            fechaEntrada = Console.ReadLine();
            Console.WriteLine("Fecha salida de la empresa (DD/MM/AA): ");
            fechaSalida = Console.ReadLine();
        }
    }

}
