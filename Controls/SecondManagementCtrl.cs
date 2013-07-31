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
        /// 返回系级管理员信息（ID， Name, Depart）
        /// </summary>
        /// <param name="dt">包含系级管理员信息的datatable</param>
        /// <param name="exception">异常信息</param>
        /// <return>若dt为空，返回false；否则返回true</return></returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Depart");
            object[] values1 = new object[]{"13050", "刘瑾", "医学院"};
            object[] values2 = new object[] { "09004", "李芳", "外国语学院" };
            object[] values3 = new object[] { "11666559", "单洁敏", "人事处" };
            dt.Rows.Add(values1);
            dt.Rows.Add(values2);
            dt.Rows.Add(values3);
            return true;
        }

        /// <summary>
        /// 根据部门返回系级管理员信息（ID, Name, Depart）
        /// </summary>
        /// <param name="dt">包含系级管理员信息的datatable</param>
        /// <param name="depart">部门</param>
        /// <param name="exception">异常信息</param>
        /// <returns>若dt为空，返回false；否则返回true</returns>
        public static bool GetAllByDepart(ref DataTable dt, string depart, ref string exception)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Depart");
            object[] values1 = new object[] { "13050", "刘瑾", "人事处" };
            object[] values2 = new object[] { "09004", "李芳", "人事处" };
            object[] values3 = new object[] { "11666559", "单洁敏", "人事处" };
            dt.Rows.Add(values1);
            dt.Rows.Add(values2);
            dt.Rows.Add(values3);
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

        /// <summary>
        /// 按ID删除系级管理员
        /// </summary>
        /// <param name="ID">待删除的系级管理员</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool Delete(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除所有系级管理员
        /// </summary>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteAll(ref string exception)
        {
            return true;
        }
    }
}
