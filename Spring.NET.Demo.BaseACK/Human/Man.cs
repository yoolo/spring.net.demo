#region Version Info
/* ======================================================================== 
    * 【本类功能概述】 
    *  
    * 作者：yoolo       时间：2013/6/5 14:09:44 
    * 文件名：Spring.NET.Demo.BaseACK.Human.Man 
    * 版本：V1.0.1 
    * 
    * 修改者：           时间：               
    * 修改说明： 
    * ======================================================================== 
    */
#endregion

namespace Spring.NET.Demo.BaseACK.Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Spring.NET.Demo.BaseACK.Human;

    public class Man : IPerson
    {
        public Man()
        {

        }
        public Man(string Name)
        {
            this.Name = Name;
        }



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

        /// <summary>
        /// 脱离作用域后，对象会被容器销毁
        /// </summary>
        /// 
        ~Man()
        {
            Console.WriteLine("man is destoried");
        }

        public void Travel()
        {
            Console.WriteLine("Normal Travel");
        }

        #endregion
    }
}
