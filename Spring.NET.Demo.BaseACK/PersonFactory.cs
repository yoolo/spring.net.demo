#region Version Info
/* ======================================================================== 
    * 【说明描述】 
    *  
    * 作者：yoolo        时间：2013/6/3 23:50:01 
    * 文件名：Spring.NET.Demo.BaseACK.PersonFactory
    * 版本：V1.0.1 
    * 
    * 修改者：           时间：               
    * 修改说明： 
    * ======================================================================== 
  */
#endregion

namespace Spring.NET.Demo.BaseACK
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PersonFactory
    {
        public static IPerson MakePerson()
        {
            return new Man();
        }
    }
}
