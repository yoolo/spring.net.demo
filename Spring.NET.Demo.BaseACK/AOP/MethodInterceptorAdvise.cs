#region Version Info
/* ======================================================================== 
    * 【本类功能概述】 
    *  
    * 作者：yoolo       时间：2013/6/6 14:39:23 
    * 文件名：Spring.NET.Demo.BaseACK.AOP.MethodInterceptor 
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
    using AopAlliance.Intercept;

  public  class MethodInterceptorAdvise : IMethodInterceptor
    {

        #region MethodInterceptorAdvise 成员

        public object Invoke(IMethodInvocation invocation)
        {
            ISecurity sercurity = new SecurityLevel1();

            if (invocation.Method.Name == "Save")
            {
                IUserManager user = invocation.Target as IUserManager;

                if (sercurity.IsLogin(user.Name) && sercurity.IsManager(user.Name))
                    user.Save();
                return null;
            }
            else
            {
                return invocation.Proceed();
            }

        }

        #endregion
    }
}
