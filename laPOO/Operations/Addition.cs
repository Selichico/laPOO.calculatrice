using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laPOO.Operations
{
    public  class Addition : Operation
    {
        public Addition(int a, int b ) :base( a, b)
        {

        }
        public void Excuter()
        {
            Resultat = A + B;
        }
    }
}
