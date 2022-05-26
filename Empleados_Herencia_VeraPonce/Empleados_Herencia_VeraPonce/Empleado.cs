using System;
using System.Collections.Generic;
using System.Text;

namespace Empleados_Herencia
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string depart;

        public string getnombre()
        {return nombre;}

        public void setnombre(string nombre)
        {this.nombre = nombre;}

        public string getapellido()
        {return apellido;}

        public void setapellido(string apellido)
        {this.apellido = apellido;}

        public int getedad()
        {return edad;}

        public void setedad(int edad)
        {this.edad = edad;}

        public string getdepart()
        {return depart;}

        public void setdepart(string depart)
        {this.depart = depart;}}
}