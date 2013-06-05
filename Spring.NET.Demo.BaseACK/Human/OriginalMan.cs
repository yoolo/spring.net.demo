#region Version Info
/* ======================================================================== 
    * 【本类功能概述】 
    *  
    * 作者：yoolo       时间：2013/6/5 14:22:53 
    * 文件名：Spring.NET.Demo.BaseACK.Human.OriginalMan 
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

    class OriginalMan : IPerson
    {
        #region IPerson 成员

        public string Name
        {
            get;
            set;
        }

        public void Speak()
        {
            Console.WriteLine("{0} say: I want food to eat !", this.Name);
        }

        public void Travel()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
