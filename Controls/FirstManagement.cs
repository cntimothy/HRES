using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controls
{
    public static class FirstManagement
    {
        /// <summary>
        /// 查询人事处管理员ID，不为空返回true，否则返回false
        /// </summary>
        /// <param name="IDs"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAll(ref List<string> IDs, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 重置制定ID人事处管理员的密码，重置成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">指定的ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ResetPassword(string ID, ref string exception)
        {
            return true;
        }
    }
}
