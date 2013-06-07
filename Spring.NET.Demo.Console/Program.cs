using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Context;
using Spring.Context.Support;
using Spring.NET.Demo.BaseACK.Human;
using Spring.NET.Demo.BaseACK;
using Spring.NET.Demo.BaseACK.AutoIOC;

namespace Spring.NET.Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //base-ioc invoke 
            ObjectCreateToInvoke();

            //default make a singleton object
            IocSingleton();

            //DI
            DIOjbectInvoke();

            //reflection
            MakeInstance.ActivatorInstance();

            //normal object invoke
            AOPManin.ClientStart();

            //AOP base invoke
            AOPManin.AOPClientStart();

        }

        /// <summary>
        /// normal object create
        /// </summary>
        static void ObjectCreate()
        {
            //normal invoke
            IPerson man = new Man();
            man.Name = "yoolo";
            man.Speak();

            System.Console.WriteLine("***********************");

            //base-objectFactory invoke
            IPerson man2 = PersonFactory.MakePerson();
            man2.Name = "Demi";
            man2.Speak();
        }

        /// <summary>
        /// spring.NET Object invoke
        /// </summary>
        static void ObjectCreateToInvoke()
        {
            IApplicationContext appContext = ContextRegistry.GetContext();
            //IPerson man = appContext.GetObject("ManInstance") as IPerson;
            IPerson man = appContext.GetObject("ManConstructor") as IPerson;
            if (man == null) System.Console.WriteLine("Init Object fail ");
            // man.Name = "yoolo 1";
            man.Speak();
        }

        /// <summary>
        /// spring.net singleton object
        /// </summary>
        static void IocSingleton()
        {
            IApplicationContext appContext = ContextRegistry.GetContext();
            IPerson man = appContext.GetObject("ManInstance") as IPerson;
            IPerson man1 = appContext.GetObject("ManInstance") as IPerson;

            if (man == man1)
                System.Console.WriteLine("Ico Object is Equals");
            else
                System.Console.WriteLine("Ico Object is not Equals");
        }

        static void DIOjbectInvoke()
        {
            IApplicationContext context = ContextRegistry.GetContext();
            IPerson modernPerson = context.GetObject("ModernManInstance") as IPerson;
            modernPerson.Travel();
        }
    }
}
