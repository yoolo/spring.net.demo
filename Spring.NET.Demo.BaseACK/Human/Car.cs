#region Version Info
/* ======================================================================== 
    * 【本类功能概述】 
    *  
    * 作者：yoolo       时间：2013/6/5 14:18:18 
    * 文件名：Spring.NET.Demo.BaseACK.Human.Car 
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

    class Car : ITools
    {
        #region ITools 成员

        public void Go()
        {
            Console.WriteLine("Travel by Car");
        }

        #endregion
    }
}
