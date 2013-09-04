using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controls
{
    public class MessagePlatformManagementCtrl
    {
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

        /// <summary>
        /// 查询所有系级管理员信息（ID, Depart, Telephone）,非空返回true，否则返回false
        /// </summary>
        /// <param name="table"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetSeconds(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Depart");
            table.Columns.Add("Telephone");
            table.Rows.Add("11", "电信学院", "12349821345");
            table.Rows.Add("12", "电信学院", "12349821345");
            table.Rows.Add("13", "电信学院", "12349821345");
            table.Rows.Add("14", "电信学院", "12349821345");
            table.Rows.Add("15", "电信学院", "12349821345");
            table.Rows.Add("16", "电信学院", "12349821345");
            table.Rows.Add("17", "电信学院", "12349821345");
            table.Rows.Add("18", "电信学院", "12349821345");
            table.Rows.Add("19", "电信学院", "12349821345");
            table.Rows.Add("20", "电信学院", "12349821345");
            table.Rows.Add("21", "电信学院", "12349821345");
            table.Rows.Add("22", "电信学院", "12349821345");
            table.Rows.Add("23", "电信学院", "12349821345");
            table.Rows.Add("24", "电信学院", "12349821345");
            table.Rows.Add("25", "电信学院", "12349821345");
            table.Rows.Add("26", "电信学院", "12349821345");
            table.Rows.Add("27", "电信学院", "12349821345");
            table.Rows.Add("28", "电信学院", "12349821345");
            table.Rows.Add("29", "电信学院", "12349821345");
            table.Rows.Add("30", "电信学院", "12349821345");
            table.Rows.Add("31", "电信学院", "12349821345");
            table.Rows.Add("32", "电信学院", "12349821345");
            table.Rows.Add("33", "电信学院", "12349821345");
            table.Rows.Add("34", "电信学院", "12349821345");
            table.Rows.Add("35", "电信学院", "12349821345");
            table.Rows.Add("36", "电信学院", "12349821345");
            table.Rows.Add("37", "电信学院", "12349821345");
            table.Rows.Add("38", "电信学院", "12349821345");
            table.Rows.Add("39", "电信学院", "12349821345");
            table.Rows.Add("40", "电信学院", "12349821345");
            return true;
        }

        /// <summary>
        /// 给指定的考评人发送短信，发送成功返回true，否则返回false
        /// </summary>
        /// <param name="IDs"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessageToEvaluators(List<string> IDs, string message, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 给指定的系级管理员发送短信
        /// </summary>
        /// <param name="IDs"></param>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SendMessageToSeconds(List<string> IDs, string message, ref string exception)
        {
            return true;
        }
    }
}
