using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Method_Overriding
{
    public class Dog:Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Bark");
        }
    }
}
