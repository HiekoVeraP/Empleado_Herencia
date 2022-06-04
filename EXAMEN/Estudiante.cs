using System;
namespace EXAMEN
{

public class datos : Program {
        protected string nombres;
         string apellidos;
        protected string instituto;
        protected int cedula;

        public string Nombres1 
        { get => nombres; set => nombres = value; }
        
        public int Cedula1 
        { get => cedula; set => cedula = value; }
        public string Instituto1 
        { get => instituto; set => instituto = value; }
        public string Apellidos1 
        { get => this.apellidos; set => this.apellidos = value; }

        public void nombre()
        {
            Console.WriteLine(Nombres1);

        }
        public void apellidos1()
        {
            Console.WriteLine(Apellidos1);
        }
    
    

        public void Instituto()
        {
        Console.WriteLine( Instituto1);
        }   


        public void Cedula()
        {
            Console.WriteLine(Cedula1);
        }




        


}


}