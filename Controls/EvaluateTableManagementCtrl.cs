using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStructure;

namespace Controls
{
    public static class EvaluateTableManagementCtrl
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

        public static bool GetLevel1(ref List<string> level1s, ref string excception)
        {
            return true;
        }

        /// <summary>
        ///查询指标库，获取二级标题，若指定一级标题不存在或者指定一级标题下二级标题为空，返回false，否则返回true 
        /// </summary>
        /// <param name="level2s"></param>
        /// <param name="level1">一级标题</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetLevel2(ref List<string> level2s, string level1, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 查询指标库，获取优良中差指标。查询成功返回true，否则返回false。
        /// </summary>
        /// <param name="quota">优良中差指标或者否决指标（否决指标只有一个，没有优良中差四种）</param>
        /// <param name="level1"></param>
        /// <param name="level2"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetQuota(ref string[] quota, string level1, string level2, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID查询岗位责任书，获取工作内容和要求。查询成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="workContntRequest">工作内容和要求列表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetworkContntRequest(string ID, ref List<string[]> workContentRequest, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID查询考评表，查询成功（存在考核表）返回true，否则返回false；
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="evaluateTable">考核表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluateTable(string ID, ref EvaluateTable evaluateTable, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新考核表，更新成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="evaluateTable">考核表</param>
        /// <param name="status">考核表状态</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateEvaluateTable(string ID, EvaluateTable evaluateTable, DocStatus status, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新审核意见，更新成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="Comment">审核意见</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateComment(string ID, string Comment, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 设置审核通过，设置成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SetPass(string ID, ref string exception)
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
        /// 根据被考评人ID删除考评表，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool Delete(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除所有考评表，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteAll(ref string exception)
        {
            return false;
        }
    }
}
