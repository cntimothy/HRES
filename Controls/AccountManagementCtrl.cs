using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace Controls
{
    public class AccountManagementCtrl
    {
        /// <summary>
        /// 修改密码。修改成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">指定的ID</param>
        /// <param name="type">用户类型（管理员或考评人）</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ChangePassword(string ID, LoginType type, string newPassword, string oldPassword, ref string exception)
        {
            return true;
        }
    }
}
