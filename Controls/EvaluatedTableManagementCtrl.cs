using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controls
{
    public static class EvaluatedTableManagementCtrl
    {
        /// <summary>
        /// 返回所有被考评人信息（ID, Date, Name, Sex, Department, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Comment, Status）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回被考评人信息（ID, Date, Name, Sex, Department, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Comment, Status）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
        public static bool GetAllByDepart(ref DataTable dt, string depart, ref string exception)
        {
            return true;
        }


    }
}
