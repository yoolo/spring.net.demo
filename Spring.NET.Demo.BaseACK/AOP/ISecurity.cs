#region Version Info
/* ======================================================================== 
    * 【权限认证接口】 
    *  
    * 作者：yoolo       时间：2013/6/6 11:39:09 
    * 文件名：Spring.NET.Demo.BaseACK.AOP.ISecurity 
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

    interface ISecurity
    {
        bool IsLogin(string username);

        bool IsManager(string username);
    }
}
