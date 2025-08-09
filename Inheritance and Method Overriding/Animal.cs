using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Method_Overriding
{
    public class Animal
    {
        public virtual void Makesound()
        {
            Console.WriteLine("Some generic sound");
        }
    }
}
