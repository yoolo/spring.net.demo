#region Version Info
/* ======================================================================== 
    * 【根据配置文件创建对象】 
    *  
    * 作者：yoolo       时间：2013/6/5 15:30:04 
    * 文件名：Spring.NET.Demo.BaseACK.AutoIOC.MakeInstance 
    * 版本：V1.0.1 
    * 
    * 修改者：           时间：               
    * 修改说明： 
    * ======================================================================== 
    */
#endregion


namespace Spring.NET.Demo.BaseACK.AutoIOC
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Human;

    public class MakeInstance
    {
        public static void ActivatorInstance()
        {
            Type type = Type.GetType("Spring.NET.Demo.BaseACK.Human.Man");
            IPerson person = Activator.CreateInstance(type) as IPerson;
            person.Name = "yoolo of autoioc";
            person.Speak();
        }   
    }
}
