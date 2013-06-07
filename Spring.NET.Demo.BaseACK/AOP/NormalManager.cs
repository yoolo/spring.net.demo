#region Version Info
/* ======================================================================== 
    * 【一般管理员】 
    *  
    * 作者：yoolo       时间：2013/6/6 12:23:55 
    * 文件名：Spring.NET.Demo.BaseACK.AOP.NormalManager 
    * 版本：V1.0.1 
    * 
    * 修改者：           时间：               
    * 修改说明： 
    * ======================================================================== 
    */
#endregion


namespace Spring.NET.Demo.BaseACK.AOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NormalManager : IUserManager
    {
        #region IUserManager 成员

        public string Name
        {
            get;
            set;
        }

        public void Save()
        {
             Console.WriteLine("{0} normal save message sucess", this.Name);
        }

        #endregion
    }
}
