using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laPOO.Operations
{
    public class Chien : Animal
    {
        public Chien(int b) : base(b)
        {

        }
        public void Aboyer()
        {
            Console.WriteLine("Hello");
        }
    }
}
