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
        /// 开始考评（考评人可以登录系统）。设置成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool StartEvaluation(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 结束指定被考评人的考评并计算其得分，设置成功返回true，否则返回false
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
        /// 根据考评人查询被考评人信息（ID, Name, Sex, Depart, Relation, Status），结果不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="evaluator">考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluatedByEvaluator(ref DataTable table, string evaluator, ref string exception)
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

        /// <summary>
        /// 返回今年的被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime)table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluatedThisYear(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 返回所有年份被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime)table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluatedAll(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 查询被考评人有考评结果的年份的列表，查询成功返回true，否则返回false
        /// </summary>
        /// <param name="years">年份列表</param>
        /// <param name="evaluatedID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluationResultYears(ref List<string> years, string evaluatedID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID和年份查询考评结果，查询成功返回true，否则返回false
        /// </summary>
        /// <param name="result">考评结果</param>
        /// <param name="evaluatedID">被考评人ID</param>
        /// <param name="year">年份</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluationResultByEvaluatedAndYear(ref EvaluationResult result, string evaluatedID, string year, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据部门返回单位考核汇总表（Name, Score, Result, EvaluatorNum, Comment）,查询成功返回true，否则返回false
        /// </summary>
        /// <param name="table">单位考核汇总表</param>
        /// <param name="depart">部门</param>
        /// <param name="evaluationStartTime">考核开始时间</param>
        /// <param name="evaluationStopTime">考核结束事件</param>
        /// <param name="evaluationDate">考核日期</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluationResultByDepart(ref DataTable table, string depart, ref string evaluationStartTime, ref string evaluationStopTime, ref string evaluationDate, ref string exception)
        {
            return true;
        }
    }
}
