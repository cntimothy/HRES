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
        /// 返回所有被考评人信息（ID, Name, Sex, Company(派遣公司、用人单位), Depart(用工单位), LaborDepart(用工部门), PostName(岗位名称), PostType(岗位类别), Fund(经费来源), Character(派遣性质), StartTime, StopTime）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
        public static bool GetAll(ref DataTable dt, ref string exception)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Company");
            dt.Columns.Add("Depart");
            dt.Columns.Add("LaborDepart");
            dt.Columns.Add("PostName");
            dt.Columns.Add("PostType");
            dt.Columns.Add("Fund");
            dt.Columns.Add("Character");
            dt.Columns.Add("StartTime");
            dt.Columns.Add("StopTime");
            string[] values1 = new string[] { "11", "高1", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values2 = new string[] { "12", "高2", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values3 = new string[] { "13", "高3", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values4 = new string[] { "14", "高4", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values5 = new string[] { "15", "高5", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values6 = new string[] { "16", "高6", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values7 = new string[] { "17", "高7", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values8 = new string[] { "18", "高8", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values9 = new string[] { "19", "高9", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values10 = new string[] { "20", "高10", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values11 = new string[] { "21", "高11", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values12 = new string[] { "22", "高12", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values13 = new string[] { "23", "高13", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values14 = new string[] { "24", "高14", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values15 = new string[] { "25", "高15", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values16 = new string[] { "26", "高16", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values17 = new string[] { "27", "高17", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values18 = new string[] { "28", "高18", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values19 = new string[] { "29", "高19", "男", "上海黄渡同济人力资源有限公司", "电信学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values20 = new string[] { "30", "高20", "男", "上海市东凌国际人才有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values21 = new string[] { "31", "高21", "男", "上海市东凌国际人才有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values22 = new string[] { "32", "高22", "男", "上海市东凌国际人才有限公司", "电信学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values23 = new string[] { "33", "高23", "男", "上海市东凌国际人才有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values24 = new string[] { "34", "高24", "男", "上海市东凌国际人才有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values25 = new string[] { "35", "高25", "男", "上海市东凌国际人才有限公司", "电信学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
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
        /// 根据部门返回被考评人信息（ID, Name, Sex, Company(派遣公司、用人单位), Depart(用工单位), LaborDepart(用工部门), PostName(岗位名称), PostType(岗位类别), Fund(经费来源), Character(派遣性质), StartTime, StopTime）
        /// </summary>
        ///  <param name="dt">包含被考评人的表</param>
        /// <param name="depart">部门</param>
        /// <param name="exception">异常信息</param>
        /// <returns>dt非空，返回true， 否则返回false</returns>
        public static bool GetAllByDepart(ref DataTable dt, string depart, ref string exception)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Company");
            dt.Columns.Add("Depart");
            dt.Columns.Add("LaborDepart");
            dt.Columns.Add("PostName");
            dt.Columns.Add("PostType");
            dt.Columns.Add("Fund");
            dt.Columns.Add("Character");
            dt.Columns.Add("StartTime");
            dt.Columns.Add("StopTime");
            string[] values1 = new string[] { "11", "高1", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values2 = new string[] { "12", "高2", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values3 = new string[] { "13", "高3", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values4 = new string[] { "14", "高4", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values5 = new string[] { "15", "高5", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values6 = new string[] { "16", "高6", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values7 = new string[] { "17", "高7", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values8 = new string[] { "18", "高8", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values9 = new string[] { "19", "高9", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values10 = new string[] { "20", "高10", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values11 = new string[] { "21", "高11", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values12 = new string[] { "22", "高12", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values13 = new string[] { "23", "高13", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values14 = new string[] { "24", "高14", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values15 = new string[] { "25", "高15", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values16 = new string[] { "26", "高16", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values17 = new string[] { "27", "高17", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values18 = new string[] { "28", "高18", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values19 = new string[] { "29", "高19", "男", "上海黄渡同济人力资源有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values20 = new string[] { "30", "高20", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values21 = new string[] { "31", "高21", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values22 = new string[] { "32", "高22", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "教辅", "学校", "人才", "2013-9", "2013-11" };
            string[] values23 = new string[] { "33", "高23", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values24 = new string[] { "34", "高24", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
            string[] values25 = new string[] { "35", "高25", "男", "上海市东凌国际人才有限公司", "材料学院", "教务处", "人事助理", "管理", "学校", "人才", "2013-9", "2013-11" };
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
