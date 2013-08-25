using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controls
{
    public class DataBaseManagementCtrl
    {
        /// <summary>
        /// 获取所有的部门名称，不为空返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAllDepart(ref List<string> departList, ref string exception)
        {
            departList.Add("部门1");
            departList.Add("部门2");
            departList.Add("部门3");
            departList.Add("部门4");
            departList.Add("部门5");
            departList.Add("部门6");
            departList.Add("部门7");
            departList.Add("部门8");
            departList.Add("部门9");
            departList.Add("部门10");
            departList.Add("部门11");
            departList.Add("部门12");
            return true;
        }

        /// <summary>
        /// 新增部门，成功返回true，否则返回false
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool AddDepart(string depart, ref string exception)
        {
            return true;
        }
    }
}
