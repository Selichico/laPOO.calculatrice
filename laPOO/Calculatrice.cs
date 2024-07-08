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
        public Operation Operation { get; set; }
        public int Resultat => Operation.Resultat;

        public Calculatrice(Operation operation)
        {
            Operation = operation;
        }
        public void Executer()
        {
            Operation.Executer();

        }
    }
}



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
