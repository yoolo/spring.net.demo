#region Version Info
/* ======================================================================== 
    * 【管理员用户接口】 
    *  
    * 作者：yoolo       时间：2013/6/6 11:13:24 
    * 文件名：Spring.NET.Demo.BaseACK.AOP.IUserManager 
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

 public   interface IUserManager
    {
        string Name
        {
            get;
            set;
        }
    
        void Save();
    }
}
