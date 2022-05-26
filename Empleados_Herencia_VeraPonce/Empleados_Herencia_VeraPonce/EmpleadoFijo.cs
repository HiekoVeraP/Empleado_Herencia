using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_Herencia
{
    class EmpleadoFijo : Empleado
    {
        private int anual;
        private double sueldo;
        private double sueldoBase;
        private double complemento;
        private int Trabajoanual;


        public double getsueldo()
        {return sueldo;}

        public void setsueldo(double sueldo)
        {this.sueldo = sueldo;}

        public int getanual()
        {anual = int.Parse(Console.ReadLine());
         return anual;}

        public void setanual(int anual)
        {this.anual = anual;}

        public double getsueldoBase()
        {return sueldoBase;}

        public void setsueldoBase(double sueldoBase)
        {this.sueldoBase = 450;}

        public double getcomplemento()
        {return complemento;}

        public void setcomplemento(double complemento)
        {this.complemento = 8.5;}

        public double calcularSueldo()
        {   int anual = int.Parse(Console.ReadLine());
            this.anual = anual;
            this.sueldo = ((2022 - anual) * this.complemento) + this.sueldoBase;
            return this.sueldo;}

    }
}
