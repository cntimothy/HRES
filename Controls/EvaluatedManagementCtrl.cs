using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controls
{
    public static class EvaluatedManagementCtrl
    {   
        /// <summary>
        /// 返回所有被考评人信息（ID, Name, Sex, Department, Telephone, Email, Job, Fund, Character, Company, StartTime, StopTime）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
        public static bool GetAll(DataTable dt, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回被考评人信息（ID, Name, Sex, Department, Telephone, Email, Job, Fund, Character, Company, StartTime, StopTime）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
        public static bool GetAllByDepart(DataTable dt, string depart, ref string exception)
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
        /// 返回被考评人的部门列表
        /// </summary>
        /// <param name="departs">部门列表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>列表为空，返回false， 否则返回true</returns>
        public static bool GetDeparts(ref List<string> departs, ref string exception)
        {
            return true;
        }
    }
}
