using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controls
{
    public class CommonCtrl
    {
        /// <summary>
        /// 返回被考评人的部门列表
        /// </summary>
        /// <param name="departs">部门列表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>列表为空，返回false， 否则返回true</returns>
        public static bool GetDeparts(ref List<string> departs, ref string exception)
        {
            departs.Add("医学院");
            departs.Add("外国语学院");
            departs.Add("人事处");
            return true;
        }
    }
}
