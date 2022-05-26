using System;

namespace Empleados_Herencia
{
    class Principal
    {
        static void Main(string[] args)
        {
            EmpleadoHora unEmpleadoHora = new EmpleadoHora();
            unEmpleadoHora.setnombre("Hieko");
            unEmpleadoHora.setapellido("Vera Ponce");
            unEmpleadoHora.setedad(21);
            unEmpleadoHora.setdepart("Informatica");
            unEmpleadoHora.setprecioHora(5.0);

            EmpleadoFijo unEmpleadoFijo = new EmpleadoFijo();
            unEmpleadoFijo.setnombre("jacky");
            unEmpleadoFijo.setapellido("chan");
            unEmpleadoFijo.setedad(56);
            unEmpleadoFijo.setdepart("Matenimiento");
            unEmpleadoFijo.setsueldoBase(500);
            unEmpleadoFijo.setcomplemento(8.5);

            EmpleadoTemporal unEmpleadoTemporal = new EmpleadoTemporal();
            unEmpleadoTemporal.setnombre("Elena");
            unEmpleadoTemporal.setapellido("Muñoz");
            unEmpleadoTemporal.setedad(25);
            unEmpleadoTemporal.setdepart("Atecion al cliente");
            unEmpleadoTemporal.setsueldo(500);

            Console.WriteLine("┌─────────────────────────────────────────────┐"); 
            Console.WriteLine("|       Autor:Vera Ponce Hieko Marcelo        |");
            Console.WriteLine("|             Curso: 3er Nivel B              |");
            Console.WriteLine("|             Asiganatura: POO                |");
            Console.WriteLine("└─────────────────────────────────────────────┘\n\n");
            Console.WriteLine("    --------- Empleado por Horas ---------");
            Console.WriteLine("Nombre y apellido: " + unEmpleadoHora.getnombre() + " " + unEmpleadoHora.getapellido());
            Console.WriteLine("Edad Empleado: " + unEmpleadoHora.getedad());
            Console.WriteLine("Departamento del empleado: " + unEmpleadoHora.getdepart());
            Console.WriteLine("Ganancia Hora: " + unEmpleadoHora.getprecioHora());
            Console.WriteLine("Horas trabajadas este mes: ");
            Console.WriteLine("Sueldo mesual del empleado es: $ " + unEmpleadoHora.calcularSueldo()+ "\n\n");

            
            Console.WriteLine("    ------------ Empleado Fijo ------------");
            Console.WriteLine("Nombre y apellido: " + unEmpleadoFijo.getnombre() + " " + unEmpleadoFijo.getapellido());
            Console.WriteLine("Edad: " + unEmpleadoFijo.getedad());
            Console.WriteLine("Departamento: " + unEmpleadoFijo.getdepart());
            Console.WriteLine("Año de entrada en la empresa: ");
            Console.WriteLine("El sueldo mesual del empleado es: $ " + unEmpleadoFijo.calcularSueldo()+ "\n\n");
            
            
            Console.WriteLine("    ---------- Empleado Temporal ---------");
            Console.WriteLine("Nombre y apellido: " + unEmpleadoTemporal.getnombre() + " " + unEmpleadoTemporal.getapellido());
            Console.WriteLine("Edad: " + unEmpleadoTemporal.getedad());
            Console.WriteLine("Departamento: " + unEmpleadoTemporal.getdepart());
            unEmpleadoTemporal.ingresoSalida();
            Console.WriteLine("El sueldo mesual del empleado es: $ " + unEmpleadoTemporal.getsueldo()+ "\n\n");
            


        }
    }
}
