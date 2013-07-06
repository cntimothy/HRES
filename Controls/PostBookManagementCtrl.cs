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
        /// 返回所有被考评人信息，包括审核意见和状态（ID, Date, Name, Sex, Department, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Comment, Status）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回所有被考评人信息，包括审核意见和状态（ID, Date, Name, Sex, Department, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Comment, Status）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAllByDepart(ref DataTable dt, string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新岗位责任书
        /// </summary>
        /// <param name="pb">岗位责任书</param>
        /// <param name="status">岗位责任书状态</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdatePostBook(PostBook pb, DocStatus status, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新审核意见
        /// </summary>
        /// <param name="comment">审核意见</param>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateComment(string comment, string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新审核状态（通过或退回）
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="status">状态</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdateStatus(string ID, DocStatus status, ref string exception)
        {
            return true;
        }
    }
}
