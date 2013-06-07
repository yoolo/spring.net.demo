#region Version Info
/* ======================================================================== 
    * 【系统管理员接口】 
    *  
    * 作者：yoolo       时间：2013/6/6 11:38:33 
    * 文件名：Spring.NET.Demo.BaseACK.AOP.SystemManager 
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

    public class SystemManager : IUserManager
    {
        #region IUserManager 成员

        public void Save()
        {
            ISecurity security = new SecurityLevel1();
            if (security.IsLogin(this.Name) && security.IsManager(this.Name))
                Console.WriteLine("{0} save message sucess", this.Name);
            else
                Console.WriteLine("{0} save message error, has not login or power ", this.Name);
        }


        public string Name
        {
            get;
            set;
        }

        #endregion

    }
}
