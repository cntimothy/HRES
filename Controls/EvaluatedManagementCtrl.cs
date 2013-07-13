using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Controls
{
    public static class EvaluatedManagementCtrl
    {   
        /// <summary>
        /// 返回所有被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
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
            string[] values1 = new string[] { "123456", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values2 = new string[] { "123456", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values3 = new string[] { "123456", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values4 = new string[] { "123456", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values5 = new string[] { "123456", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values6 = new string[] { "123456", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2",  "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values20 = new string[] { "123456", "2010-3-3", "高20", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values21 = new string[] { "123456", "2010-3-3", "高21", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values22 = new string[] { "123456", "2010-3-3", "高22", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values23 = new string[] { "123456", "2010-3-3", "高23", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values24 = new string[] { "123456", "2010-3-3", "高24", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values25 = new string[] { "123456", "2010-3-3", "高25", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
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
        /// 根据部门返回被考评人信息（ID, Date, Name, Sex, Depart, Job, IDNo, Birthday, Fund, Character, Company, StartTime, StopTime）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
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
            string[] values1 = new string[] { "123456", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values2 = new string[] { "123456", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "1300000002", "gao1@tongji.edu.cn", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values3 = new string[] { "123456", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values4 = new string[] { "123456", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values5 = new string[] { "123456", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values6 = new string[] { "123456", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values20 = new string[] { "123456", "2010-3-3", "高20", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values21 = new string[] { "123456", "2010-3-3", "高21", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values22 = new string[] { "123456", "2010-3-3", "高22", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values23 = new string[] { "123456", "2010-3-3", "高23", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values24 = new string[] { "123456", "2010-3-3", "高24", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
            string[] values25 = new string[] { "123456", "2010-3-3", "高25", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10" };
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
        /// 将path所指定的Excel的内容导入数据库
        /// </summary>
        /// <param name="path">Excel的路径</param>
        /// <param name="exception"></param>
        /// <returns>新增数据成功返回true，否则返回false</returns>
        public static bool AddNewByExl(string path, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 返回被考评人的部门列表
        /// </summary>
        /// <param name="departs">部门列表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>列表为空，返回false， 否则返回true</returns>
        public static bool GetDeparts(ref List<string> departs, ref string exception)
        {
            departs.Add("医学院");
            departs.Add("外国语学院");
            departs.Add("人事处");
            return true;
        }

        /// <summary>
        /// 从本年的被考评人名单中删除所指定的被考评人
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool Delete(List<string> IDs, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 从本年度的被考评人名单中删除所有被考评人
        /// </summary>
        /// <param name="exception"></param>
        /// <returns>删除成功返回true，否则返回false</returns>
        public static bool DeleteAll(ref string exception)
        {
            return true;
        }
    }
}
