using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laPOO.Operations
{
    public abstract class Operation
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Resultat { get; set; }

        public Operation(int a, int b)
        {
            A = a;
            B = b;
        }

        public abstract void Executer();

        
        
    }
}
