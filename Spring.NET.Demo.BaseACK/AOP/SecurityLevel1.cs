#region Version Info
/* ======================================================================== 
    * 【安全认证等级一】 
    *  
    * 作者：yoolo       时间：2013/6/6 11:43:32 
    * 文件名：Spring.NET.Demo.BaseACK.AOP.SecurityLevel1 
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

    public class SecurityLevel1 : ISecurity
    {

        #region ISecurity 成员

        public bool IsLogin(string username)
        {
            return "yoolo".Equals(username);

        }

        public bool IsManager(string username)
        {
            return "yoolo".Equals(username);
        }

        #endregion
    }
}
