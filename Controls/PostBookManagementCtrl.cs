using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStructure;

namespace Controls
{
    public static class PostBookManagementCtrl
    {
        /// <summary>
        /// 返回所有被考评人信息，包括审核意见和状态（ID, Name, Sex, Department, Telephone, Email, Job, Fund, Character, Company, StartTime, StopTime, Comment, Status）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAll(DataTable dt, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回所有被考评人信息，包括审核意见和状态（ID, Name, Sex, Department, Telephone, Email, Job, Fund, Character, Company, StartTime, StopTime, Comment, Status）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAllByDepart(DataTable dt, string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新岗位责任书，置状态位和意见
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="pb">岗位责任书</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true,否则返回false</returns>
        public static bool UpdatePostBook(string ID, PostBook pb, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 保存岗位责任书,置状态位为1
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="pb"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SavePostBook(string ID, PostBook pb, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 提交岗位责任书，置状态位和意见
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="pb"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SubmitPostBook(string ID, PostBook pb, ref string exception)
        {
            return true;
        }
    }
}
