using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_Herencia
{
    class EmpleadoHora : Empleado
    {
        private double precioHora = 5.0;
        private int horasMensual;
        private double sueldo;

        public double getprecioHora()
        {return precioHora;}

        public void setprecioHora(double precioHora)
        {this.precioHora = precioHora;}

        public int gethorasMensuales()
        {return horasMensual;}

        public void sethorasMensuales(int horasMens)
        {horasMensual = horasMens;}

        public double calcularSueldo()
        {int horasMensuales = int.Parse(Console.ReadLine());
            sueldo = horasMensuales * precioHora;
            return sueldo;}
    }
}

