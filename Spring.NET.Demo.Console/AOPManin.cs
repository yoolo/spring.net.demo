#region Version Info
/* ======================================================================== 
    * 【AOP 例子的启动程序】 
    *  
    * 作者：yoolo       时间：2013/6/6 11:40:38 
    * 文件名：Spring.NET.Demo.Console.AOPManin 
    * 版本：V1.0.1 
    * 
    * 修改者：           时间：               
    * 修改说明： 
    * ======================================================================== 
    */
#endregion


namespace Spring.NET.Demo.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Spring.NET.Demo.BaseACK.AOP;
    using Spring.Aop.Framework;

    public class AOPManin
    {
        public static void ClientStart()
        {
            IUserManager systemUser = new SystemManager();
            systemUser.Name = "yoolo1";
            systemUser.Save();
        }

        public static void AOPClientStart()
        {
            //factory 代理目标对象
            ProxyFactory factory = new ProxyFactory(
                //joinpoint  连接点
                new SystemManager() { Name = "yoolo aop" }
                );
            //MethodInterceptorAdvise  通知 ，拦截到joinpoint 之后，做的通知
            factory.AddAdvice(new MethodInterceptorAdvise());
            IUserManager Iuser = factory.GetProxy() as IUserManager;

            Iuser.Save();


        }
    }
}
