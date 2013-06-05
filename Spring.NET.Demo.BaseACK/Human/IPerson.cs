using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring.NET.Demo.BaseACK.Human
{
    public interface IPerson
    {
        string Name { get; set; }
        void Speak();
        void Travel();
    }
}
