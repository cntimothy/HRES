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
        /// 查询被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime, Summary（考评完成/考评总数））。table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAll(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Date");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Depart");
            table.Columns.Add("Job");
            table.Columns.Add("IDNo");
            table.Columns.Add("Birthday");
            table.Columns.Add("Fund");
            table.Columns.Add("Character");
            table.Columns.Add("Company");
            table.Columns.Add("StartTime");
            table.Columns.Add("StopTime");
            table.Columns.Add("Summary");
            string[] values1 = new string[] { "1", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values2 = new string[] { "2", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values3 = new string[] { "3", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values4 = new string[] { "4", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values5 = new string[] { "5", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values6 = new string[] { "6", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "15/19" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "6/19" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "3/19" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values20 = new string[] { "123456", "2010-3-3", "高20", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values21 = new string[] { "123456", "2010-3-3", "高21", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values22 = new string[] { "123456", "2010-3-3", "高22", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values23 = new string[] { "123456", "2010-3-3", "高23", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values24 = new string[] { "123456", "2010-3-3", "高24", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values25 = new string[] { "123456", "2010-3-3", "高25", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            table.Rows.Add(values1);
            table.Rows.Add(values2);
            table.Rows.Add(values3);
            table.Rows.Add(values4);
            table.Rows.Add(values5);
            table.Rows.Add(values6);
            table.Rows.Add(values7);
            table.Rows.Add(values8);
            table.Rows.Add(values9);
            table.Rows.Add(values10);
            table.Rows.Add(values11);
            table.Rows.Add(values12);
            table.Rows.Add(values13);
            table.Rows.Add(values14);
            table.Rows.Add(values15);
            table.Rows.Add(values16);
            table.Rows.Add(values17);
            table.Rows.Add(values18);
            table.Rows.Add(values19);
            table.Rows.Add(values20);
            table.Rows.Add(values21);
            table.Rows.Add(values22);
            table.Rows.Add(values23);
            table.Rows.Add(values24);
            table.Rows.Add(values25);
            return true;
        }

        /// <summary>
        /// 根据部门查询被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime, Summary（考评完成/考评总数））。table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="depart">部门</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAllByDepart(ref DataTable table, string depart, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Date");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Depart");
            table.Columns.Add("Job");
            table.Columns.Add("IDNo");
            table.Columns.Add("Birthday");
            table.Columns.Add("Fund");
            table.Columns.Add("Character");
            table.Columns.Add("Company");
            table.Columns.Add("StartTime");
            table.Columns.Add("StopTime");
            table.Columns.Add("Summary");
            string[] values1 = new string[] { "1", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values2 = new string[] { "2", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values3 = new string[] { "3", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values4 = new string[] { "4", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values5 = new string[] { "5", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values6 = new string[] { "6", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "15/19" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "6/19" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "3/19" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values20 = new string[] { "123456", "2010-3-3", "高20", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values21 = new string[] { "123456", "2010-3-3", "高21", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values22 = new string[] { "123456", "2010-3-3", "高22", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values23 = new string[] { "123456", "2010-3-3", "高23", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values24 = new string[] { "123456", "2010-3-3", "高24", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            string[] values25 = new string[] { "123456", "2010-3-3", "高25", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "14/19" };
            table.Rows.Add(values1);
            table.Rows.Add(values2);
            table.Rows.Add(values3);
            table.Rows.Add(values4);
            table.Rows.Add(values5);
            table.Rows.Add(values6);
            table.Rows.Add(values7);
            table.Rows.Add(values8);
            table.Rows.Add(values9);
            table.Rows.Add(values10);
            table.Rows.Add(values11);
            table.Rows.Add(values12);
            table.Rows.Add(values13);
            table.Rows.Add(values14);
            table.Rows.Add(values15);
            table.Rows.Add(values16);
            table.Rows.Add(values17);
            table.Rows.Add(values18);
            table.Rows.Add(values19);
            table.Rows.Add(values20);
            table.Rows.Add(values21);
            table.Rows.Add(values22);
            table.Rows.Add(values23);
            table.Rows.Add(values24);
            table.Rows.Add(values25);
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
        /// <param name="evaluatedID">被考评人ID</param>
        /// <param name="evaluatorID">考评人ID</param>
        /// <param name="scores"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateScore(string evaluatedID, string evaluatorID, string[] scores, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 给所有考评人发送短信，发送成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessageToAll(string message, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 分部门给考评人发送短信，发送成功返回true，否则返回false
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessageByDepart(string message, string depart, ref string exception)
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
        /// 返回今年的被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime)table不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">被考评人信息</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluatedThisYear(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 返回所有年份被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime)table不为空返回true，否则返回false
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

        /// <summary>
        /// 查询考评是否开始，已开始则返回true，否则返回false
        /// </summary>
        /// <returns></returns>
        public static bool IsEvaluationStarted()
        {
            return true;
        }

        /// <summary>
        /// 查询所有考评人信息（ID, Name, Sex, Depart(部门), Company(单位), Telephone），非空返回true，否则返回false。
        /// </summary>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluators(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Depart");
            table.Columns.Add("Company");
            table.Columns.Add("Telephone");
            string[] values1 = new string[] { "1", "高1", "男", "Intel", "医学院", "12345" };
            string[] values2 = new string[] { "2", "高2", "女", "AMD", "医学院", "2345" };
            string[] values3 = new string[] { "3", "高3", "男", "EMC", "医学院", "1413235" };
            string[] values4 = new string[] { "4", "高4", "男", "Lenovo", "医学院", "543234" };
            string[] values5 = new string[] { "5", "高5", "男", "Apple", "医学院", "515321432" };
            string[] values6 = new string[] { "6", "高6", "男", "IBM", "医学院", "25132513" };
            string[] values7 = new string[] { "7", "高1", "男", "Intel", "医学院", "12345" };
            string[] values8 = new string[] { "8", "高2", "女", "AMD", "医学院", "2345" };
            string[] values9 = new string[] { "9", "高3", "男", "EMC", "医学院", "1413235" };
            string[] values10 = new string[] { "0", "高4", "男", "Lenovo", "外国语学院", "543234" };
            string[] values11 = new string[] { "11", "高5", "男", "Apple", "外国语学院", "515321432" };
            string[] values12 = new string[] { "22", "高6", "男", "IBM", "外国语学院", "25132513" };
            string[] values13 = new string[] { "33", "高1", "男", "Intel", "外国语学院", "12345" };
            string[] values14 = new string[] { "44", "高2", "女", "AMD", "外国语学院", "2345" };
            string[] values15 = new string[] { "55", "高3", "男", "EMC", "医学院", "1413235" };
            string[] values16 = new string[] { "66", "高4", "男", "Lenovo", "医学院", "543234" };
            string[] values17 = new string[] { "77", "高5", "男", "Apple", "医学院", "515321432" };
            string[] values18 = new string[] { "88", "高6", "男", "IBM", "医学院", "25132513" };
            table.Rows.Add(values1);
            table.Rows.Add(values2);
            table.Rows.Add(values3);
            table.Rows.Add(values4);
            table.Rows.Add(values5);
            table.Rows.Add(values6);
            table.Rows.Add(values7);
            table.Rows.Add(values8);
            table.Rows.Add(values9);
            table.Rows.Add(values10);
            table.Rows.Add(values11);
            table.Rows.Add(values12);
            table.Rows.Add(values13);
            table.Rows.Add(values14);
            table.Rows.Add(values15);
            table.Rows.Add(values16);
            table.Rows.Add(values17);
            table.Rows.Add(values18);
            return true;
        }

        /// <summary>
        /// 根据部门查询所有考评人信息（ID, Name, Sex, Depart(部门), Company(单位), Telephone），非空返回true，否则返回false。
        /// </summary>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetEvaluatorsByDepart(ref DataTable table, string depart, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Depart");
            table.Columns.Add("Company");
            table.Columns.Add("Telephone");
            string[] values1 = new string[] { "1", "高1", "男", "Intel", "医学院", "12345" };
            string[] values2 = new string[] { "2", "高2", "女", "AMD", "医学院", "2345" };
            string[] values3 = new string[] { "3", "高3", "男", "EMC", "医学院", "1413235" };
            string[] values4 = new string[] { "4", "高4", "男", "Lenovo", "医学院", "543234" };
            string[] values5 = new string[] { "5", "高5", "男", "Apple", "医学院", "515321432" };
            string[] values6 = new string[] { "6", "高6", "男", "IBM", "医学院", "25132513" };
            string[] values7 = new string[] { "7", "高1", "男", "Intel", "医学院", "12345" };
            string[] values8 = new string[] { "8", "高2", "女", "AMD", "医学院", "2345" };
            string[] values9 = new string[] { "9", "高3", "男", "EMC", "医学院", "1413235" };
            string[] values10 = new string[] { "0", "高4", "男", "Lenovo", "医学院", "543234" };
            string[] values11 = new string[] { "11", "高5", "男", "Apple", "医学院", "515321432" };
            string[] values12 = new string[] { "22", "高6", "男", "IBM", "医学院", "25132513" };
            string[] values13 = new string[] { "33", "高1", "男", "Intel", "医学院", "12345" };
            string[] values14 = new string[] { "44", "高2", "女", "AMD", "医学院", "2345" };
            string[] values15 = new string[] { "55", "高3", "男", "EMC", "医学院", "1413235" };
            string[] values16 = new string[] { "66", "高4", "男", "Lenovo", "医学院", "543234" };
            string[] values17 = new string[] { "77", "高5", "男", "Apple", "医学院", "515321432" };
            string[] values18 = new string[] { "88", "高6", "男", "IBM", "医学院", "25132513" };
            table.Rows.Add(values1);
            table.Rows.Add(values2);
            table.Rows.Add(values3);
            table.Rows.Add(values4);
            table.Rows.Add(values5);
            table.Rows.Add(values6);
            table.Rows.Add(values7);
            table.Rows.Add(values8);
            table.Rows.Add(values9);
            table.Rows.Add(values10);
            table.Rows.Add(values11);
            table.Rows.Add(values12);
            table.Rows.Add(values13);
            table.Rows.Add(values14);
            table.Rows.Add(values15);
            table.Rows.Add(values16);
            table.Rows.Add(values17);
            table.Rows.Add(values18);
            return true;
        }
    }
}
