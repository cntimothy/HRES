using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace Controls
{
    public class DataBaseManagementCtrl
    {
        /// <summary>
        /// 获取所有的部门名称table(ID, Name)，不为空返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAllDepart(ref DataTable table, ref string exception)
        {
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Rows.Add("13", "电信学院");
            table.Rows.Add("14", "医学院");
            table.Rows.Add("15", "汽车学院");
            table.Rows.Add("16", "材料学院");
            return true;
        }

        /// <summary>
        /// 新增部门，成功返回true，否则返回false
        /// </summary>
        /// <param name="depart"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool AddDepart(string depart, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除指定的部门，成功返回true，否则返回false
        /// </summary>
        /// <param name="departID"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteDepart(string departID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 清空除指标库之外的所有数据，成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ClearDataBase(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 清空指标库，成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ClearQuotaLib(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除所有临时文件，成功返回true，否则返回false。（这个我来实现）
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ClearTempFiles(ref string exception)
        {
            DirectoryInfo folder = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\");
            FileInfo[] files = folder.GetFiles();
            try
            {
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
            }
            catch (Exception e)
            {
                exception = e.Message;
                return false;
            }
            return true;
        }
    }
}
