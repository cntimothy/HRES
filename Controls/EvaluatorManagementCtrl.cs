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
        /// 返回所有被考评人信息，包括审核意见和状态（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime, Status, Comment）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Name");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Depart");
            dt.Columns.Add("Job");
            dt.Columns.Add("IDNo");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Fund");
            dt.Columns.Add("Character");
            dt.Columns.Add("Company");
            dt.Columns.Add("StartTime");
            dt.Columns.Add("StopTime");
            dt.Columns.Add("Status");
            dt.Columns.Add("Comment");
            string[] values1 = new string[] { "1", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values2 = new string[] { "2", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "1300000002", "gao1@tongji.edu.cn", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values3 = new string[] { "3", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values4 = new string[] { "4", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values5 = new string[] { "5", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values6 = new string[] { "6", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "test for comment" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "test for comment" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values20 = new string[] { "123456", "2010-3-3", "高20", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values21 = new string[] { "123456", "2010-3-3", "高21", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values22 = new string[] { "123456", "2010-3-3", "高22", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "3", "" };
            string[] values23 = new string[] { "123456", "2010-3-3", "高23", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "3", "" };
            string[] values24 = new string[] { "123456", "2010-3-3", "高24", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "4", "" };
            string[] values25 = new string[] { "123456", "2010-3-3", "高25", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "4", "" };
            dt.Rows.Add(values1);
            dt.Rows.Add(values2);
            dt.Rows.Add(values3);
            dt.Rows.Add(values4);
            dt.Rows.Add(values5);
            dt.Rows.Add(values6);
            dt.Rows.Add(values7);
            dt.Rows.Add(values8);
            dt.Rows.Add(values9);
            dt.Rows.Add(values10);
            dt.Rows.Add(values11);
            dt.Rows.Add(values12);
            dt.Rows.Add(values13);
            dt.Rows.Add(values14);
            dt.Rows.Add(values15);
            dt.Rows.Add(values16);
            dt.Rows.Add(values17);
            dt.Rows.Add(values18);
            dt.Rows.Add(values19);
            dt.Rows.Add(values20);
            dt.Rows.Add(values21);
            dt.Rows.Add(values22);
            dt.Rows.Add(values23);
            dt.Rows.Add(values24);
            dt.Rows.Add(values25);
            return true;
        }

        /// <summary>
        /// 根据部门返回所有被考评人信息，包括审核意见和状态（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime, Status, Comment）
        /// </summary>
        /// <param name="dt">包含所需信息的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception"></param>
        /// <returns>dt不为空，返回true，否则返回false</returns>
        public static bool GetAllByDepart(ref DataTable dt, string depart, ref string exception)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Name");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Depart");
            dt.Columns.Add("Job");
            dt.Columns.Add("IDNo");
            dt.Columns.Add("Birthday");
            dt.Columns.Add("Fund");
            dt.Columns.Add("Character");
            dt.Columns.Add("Company");
            dt.Columns.Add("StartTime");
            dt.Columns.Add("StopTime");
            dt.Columns.Add("Status");
            dt.Columns.Add("Comment");
            string[] values1 = new string[] { "1", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values2 = new string[] { "2", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values3 = new string[] { "3", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values4 = new string[] { "4", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values5 = new string[] { "123456", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values6 = new string[] { "123456", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "test for comment" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "test for comment" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values20 = new string[] { "123456", "2010-3-3", "高20", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values21 = new string[] { "123456", "2010-3-3", "高21", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values22 = new string[] { "123456", "2010-3-3", "高22", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "3", "" };
            string[] values23 = new string[] { "123456", "2010-3-3", "高23", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "3", "" };
            string[] values24 = new string[] { "123456", "2010-3-3", "高24", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "4", "" };
            string[] values25 = new string[] { "123456", "2010-3-3", "高25", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "4", "" };
            dt.Rows.Add(values1);
            dt.Rows.Add(values2);
            dt.Rows.Add(values3);
            dt.Rows.Add(values4);
            dt.Rows.Add(values5);
            dt.Rows.Add(values6);
            dt.Rows.Add(values7);
            dt.Rows.Add(values8);
            dt.Rows.Add(values9);
            dt.Rows.Add(values10);
            dt.Rows.Add(values11);
            dt.Rows.Add(values12);
            dt.Rows.Add(values13);
            dt.Rows.Add(values14);
            dt.Rows.Add(values15);
            dt.Rows.Add(values16);
            dt.Rows.Add(values17);
            dt.Rows.Add(values18);
            dt.Rows.Add(values19);
            dt.Rows.Add(values20);
            dt.Rows.Add(values21);
            dt.Rows.Add(values22);
            dt.Rows.Add(values23);
            dt.Rows.Add(values24);
            dt.Rows.Add(values25);
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
        public static bool SetRejected(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID从备选考评人中删除考评人，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="IDs">被考评人ID列表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool Delete(List<string> IDs, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除备选考评人名单中所有考评人名单，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteAll(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 将path指定的Excel数据写入数据库(考评人的部门由depart指定)，写入成功返回true，否则返回false
        /// </summary>
        /// <param name="path">Excel的路径</param>
        /// <param name="depart">考评人部门，即上传文件的系级管理员的部门</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UploadSelectable(string path, string depart, ref string exception)
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
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Company");
            table.Columns.Add("Telephone");
            table.Columns.Add("Relation");
            string[] values1 = new string[] { "1", "高1", "男", "Intel", "12345", "领导" };
            string[] values2 = new string[] { "2", "高2", "女", "AMD", "2345", "同事" };
            string[] values3 = new string[] { "3", "高3", "男", "EMC", "1413235", "同事" };
            string[] values4 = new string[] { "4", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values5 = new string[] { "5", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values6 = new string[] { "6", "高6", "男", "IBM", "25132513", "下属" };
            string[] values7 = new string[] { "7", "高1", "男", "Intel", "12345", "领导" };
            string[] values8 = new string[] { "8", "高2", "女", "AMD", "2345", "同事" };
            string[] values9 = new string[] { "9", "高3", "男", "EMC", "1413235", "同事" };
            string[] values10 = new string[] { "0", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values11 = new string[] { "11", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values12 = new string[] { "22", "高6", "男", "IBM", "25132513", "下属" };
            string[] values13 = new string[] { "33", "高1", "男", "Intel", "12345", "领导" };
            string[] values14 = new string[] { "44", "高2", "女", "AMD", "2345", "同事" };
            string[] values15 = new string[] { "55", "高3", "男", "EMC", "1413235", "同事" };
            string[] values16 = new string[] { "66", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values17 = new string[] { "77", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values18 = new string[] { "88", "高6", "男", "IBM", "25132513", "下属" };
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
        /// 提交考评人名单（如果已存在则更新）。提交成功返回true，否则返回false
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
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Sex");
            table.Columns.Add("Company");
            table.Columns.Add("Telephone");
            table.Columns.Add("Relation");
            string[] values1 = new string[] { "1", "高1", "男", "Intel", "12345", "领导" };
            string[] values2 = new string[] { "2", "高2", "女", "AMD", "2345", "同事" };
            string[] values3 = new string[] { "3", "高3", "男", "EMC", "1413235", "同事" };
            string[] values4 = new string[] { "4", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values5 = new string[] { "5", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values6 = new string[] { "6", "高6", "男", "IBM", "25132513", "下属" };
            string[] values7 = new string[] { "11", "高1", "男", "Intel", "12345", "领导" };
            string[] values8 = new string[] { "22", "高2", "女", "AMD", "2345", "同事" };
            string[] values9 = new string[] { "33", "高3", "男", "EMC", "1413235", "同事" };
            string[] values10 = new string[] { "44", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values11 = new string[] { "55", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values12 = new string[] { "66", "高6", "男", "IBM", "25132513", "下属" };
            string[] values13 = new string[] { "111", "高1", "男", "Intel", "12345", "领导" };
            string[] values14 = new string[] { "222", "高2", "女", "AMD", "2345", "同事" };
            string[] values15 = new string[] { "333", "高3", "男", "EMC", "1413235", "同事" };
            string[] values16 = new string[] { "444", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values17 = new string[] { "555", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values18 = new string[] { "666", "高6", "男", "IBM", "25132513", "下属" };
            string[] values19 = new string[] { "1111", "高1", "男", "Intel", "12345", "领导" };
            string[] values20 = new string[] { "2222", "高2", "女", "AMD", "2345", "同事" };
            string[] values21 = new string[] { "3333", "高3", "男", "EMC", "1413235", "同事" };
            string[] values22 = new string[] { "4444", "高4", "男", "Lenovo", "543234", "下属" };
            string[] values23 = new string[] { "5555", "高5", "男", "Apple", "515321432", "服务对象" };
            string[] values24 = new string[] { "6666", "高6", "男", "IBM", "25132513", "下属" };
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
            return true;
        }

        /// <summary>
        /// 设置考评人名单（如果已存在，则更新），成功返回true，否则返回false
        /// </summary>
        /// <param name="evaluated">被考评人ID</param>
        /// <param name="evaluatorList">考评人ID列表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SetEvaluator(string evaluated, List<string> evaluatorList, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 获取指定被考评人的考评人名单审核意见，有审核意见返回true，否则返回false
        /// </summary>
        /// <param name="comment">审核意见</param>
        /// <param name="evaluatedID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetComment(ref string comment, string evaluatedID, ref string exception)
        {
            return true;
        }
    }
}
