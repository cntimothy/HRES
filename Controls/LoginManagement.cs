using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace Controls
{
    public static class LoginManagement
    {
        /// <summary>
        /// 登录，登录成功返回true，否则返回false
        /// </summary>
        /// <param name="userInfo">需填写的用户信息</param>
        /// <param name="ID">用户名</param>
        /// <param name="passWord">密码</param>
        /// <param name="loginType">登录类型</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool LoginIn(ref UserInfo userInfo, string ID, string passWord, LoginType loginType, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 注销。注销成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool LoginOut(ref string exception)
        {
            return true;
        }
    }
}
