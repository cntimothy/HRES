using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStructure;

namespace Controls
{
    public class EvaluatorManagementCtrl
    {
        /// <summary>
        /// 返回所有被考评人信息，包括审核意见和状态（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Status, Comment）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回所有被考评人信息，包括审核意见和状态（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Status, Comment）
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
        /// 设置审核退回，设置成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SetReturned(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID删除考评人名单，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool Delete(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除所有考评人名单，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteAll(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 将path指定的Excel数据写入数据库，写入成功返回true，否则返回false
        /// </summary>
        /// <param name="path">Excel的路径</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UploadSelectable(string path, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门查询备选考评人名单（ID, Name, Sex, Company(单位), Telephone, Relation），Table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">备选考评人名单</param>
        /// <param name="depart">部门</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetSelectableEvaluatorByDepart(ref DataTable table, string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 提交考评人名单。提交成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluated">被考评人ID</param>
        /// <param name="evaluatorRelationDic">考评人的ID和关系字典</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SubmitEvaluator(string evaluated, Dictionary<string, string> evaluatorRelationDic, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID查询系级管理员提交的考评人名单（ID, Name, Sex, Company(单位), Telephone, Relation）
        /// </summary>
        /// <param name="table"></param>
        /// <param name="evaluated"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluator(ref DataTable table, string evaluated, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 设置考评人名单，成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluated">被考评人ID</param>
        /// <param name="evaluatorList">考评人ID列表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SetEvaluaror(string evaluated, List<string> evaluatorList, ref string exception)
        {
            return true;
        }
    }
}
