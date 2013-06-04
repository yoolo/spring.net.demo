using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring.NET.Demo.BaseACK
{
    public interface IPerson
    {
        string Name { get; set; }
        void Speak();
    }

    public class Man : IPerson
    {

        #region IPerson 成员

        public string Name
        {
            get;
            set;
        }

        public void Speak()
        {
            Console.WriteLine("{0} say: {1}", this.Name, "Hello World!");
        }

        #endregion
    }
}
