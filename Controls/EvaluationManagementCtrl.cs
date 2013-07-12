using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStructure;

namespace Controls
{
    public class EvaluationManagementCtrl
    {
        /// <summary>
        /// 查询被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Summary（考评完成/考评总数））。table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAll(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门查询被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Summary（考评完成/考评总数））。table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="depart">部门</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAllByDepart(ref DataTable table, string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 开始考评。设置成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool StartEvaluation(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 结束指定被考评人的考评，设置成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluated">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool StopEvaluation(string evaluated, ref string exception)
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
        /// 更新指定被考评人的分数，更新成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="scores">包含分数的数组</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateScore(string ID, string[] scores, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取所有考评人信息（ID, Name, Sex, Company, Telephone, Relation），table不为空，返回true，否则返回false
        /// </summary>
        /// <param name="table">考评人信息</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluator(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据指定部门获取所有考评人信息（ID, Name, Sex, Company, Telephone, Relation），table不为空，返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluatorByDepart(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 给所有考评人发送短信，发送成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessageToAll(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 分部门给考评人发送短信，发送成功返回true，否则返回false
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessageByDepart(string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 给指定的考评人发送短信，发送成功返回true，否则返回false
        /// </summary>
        /// <param name="IDs"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessage(List<string> IDs, ref string exception)
        {
            return true;
        }
    }
}
