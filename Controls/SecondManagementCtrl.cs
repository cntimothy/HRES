using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controls
{
    public static class SecondManagementCtrl
    {
        /// <summary>
        /// 返回系级管理员信息（ID, PassWord， Department）
        /// </summary>
        /// <param name="dt">包含系级管理员信息的datatable</param>
        /// <param name="exception">异常信息</param>
        /// <return>若dt为空，返回false；否则返回true</return></returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回系级管理员信息（ID, PassWord， Department）
        /// </summary>
        /// <param name="dt">包含系级管理员信息的datatable</param>
        /// <param name="depart">部门</param>
        /// <param name="exception">异常信息</param>
        /// <returns>若dt为空，返回false；否则返回true</returns>
        public static bool GetAllByDepart(ref DataTable dt, string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 返回系级管理员的部门列表
        /// </summary>
        /// <param name="departs">部门列表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>列表为空，返回false， 否则返回true</returns>
        public static bool GetDeparts(ref List<string> departs, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 将path所指定的Excel的内容导入数据库
        /// </summary>
        /// <param name="path">Excel的路径</param>
        /// <param name="exception"></param>
        /// <returns>新增数据成功返回true，否则返回false</returns>
        public static bool AddNewByExl(string path, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 重置系级管理员ID的密码
        /// </summary>
        /// <param name="ID">需要重置密码的系级管理员的ID</param>
        /// <param name="exception">异常信息</param>
        /// <returns>重置成功返回true，否则返回false</returns>
        public static bool ResetPassword(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 重置所有系级管理员的密码
        /// </summary>
        /// <param name="exception">异常信息</param>
        /// <returns>重置成功返回true， 否则返回false</returns>
        public static bool ResetAllPassword(ref string exception)
        {
            return true;
        }
    }
}
