using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laPOO.Operations
{
    internal class Modulo : Operation
    {
        public Modulo(int a, int b) : base(a, b)
        {
        }
        public void Excuter()
        {
            Resultat = A % B;
        }
    }
}
