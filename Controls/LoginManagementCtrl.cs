using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace Controls
{
    public static class LoginManagementCtrl
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
            if (ID == "super")
            {
                userInfo.Id = ID;
                userInfo.Name = "超级管理员";
                userInfo.Depart = "";
                userInfo.AccessLevel = AccessLevel.superManager;
                exception = "不存在该用户";
            }
            else if (ID == "admin1")
            {
                userInfo.Id = ID;
                userInfo.Name = "人事处管理员";
                userInfo.Depart = "";
                userInfo.AccessLevel = AccessLevel.firstManager;
                exception = "不存在该用户";
            }
            else if(ID == "admin2")
            {
                userInfo.Id = ID;
                userInfo.Name = "系级管理员";
                userInfo.Depart = "电信学院";
                userInfo.AccessLevel = AccessLevel.secondManager;
                exception = "不存在该用户";
            }
            else if (ID == "evaluator")
            {
                userInfo.Id = ID;
                userInfo.Name = "考评人";
                userInfo.Depart = "电信学院";
                userInfo.AccessLevel = AccessLevel.evaluator;
                exception = "不存在该用户";
            }
            return true;
        }
    }
}
