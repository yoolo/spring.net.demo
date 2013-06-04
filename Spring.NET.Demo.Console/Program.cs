using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.NET.Demo.BaseACK;

namespace Spring.NET.Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson man = new Man();
            man.Name = "yoolo";
            man.Speak();

            System.Console.WriteLine("***********************");

            IPerson man2 = PersonFactory.MakePerson();
            man2.Name = "Demi";
            man2.Speak();
        }
    }
}
