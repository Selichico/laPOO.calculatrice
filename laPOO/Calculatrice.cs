using laPOO.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace laPOO
{
    public class Calculatrice 
    {
        //public int Addition(int a, int b)
        //{
        //    return a + b;

        //}
        //public int Soustraction(int a, int b)
        //{
        //    return a - b;

        //}
        //public int Multiplication(int a, int b)
        //{
        //    return a * b;

        //}
        //public int Division(int a, int b)
        //{
        //    try { 
        //    return a / b;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }


        //}
        //public int Modulo(int a, int b)
        //{
        //    int z = a % b;

        //    return z ;

        //}
        public Operation Operation { get; set; }
        public int Resultat => Operation.Resultat;

        public Calculatrice(Operation operation)
        {
            Operation = operation; 
        }
        public void Executer()
        {
            if(Operation is Addition addition ) 
            {
                addition.Excuter();
            }
            else if(Operation is Multiplication multiplication ) 
            {
            multiplication.Excuter();
            }
            else if ( Operation is Soustraction sestraction ) 
            {
                sestraction.Excuter();
            }
            else if (Operation is Devision devision)    
            {
                devision.Excuter();
            }
            else if (Operation is Modulo modulo ) 
            {
                modulo.Excuter();
            }
            else 
            {
                Console.WriteLine("Operation non reconue ");
            }

        }
    }
}

