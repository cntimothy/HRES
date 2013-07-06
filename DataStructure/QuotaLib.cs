using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class QuotaLib
    {
        #region Private Field
        private Dictionary<string, Dictionary<string, string[]>> lib;
        #endregion

        #region Constructor
        public QuotaLib()
        {
            lib = new Dictionary<string, Dictionary<string, string[]>>();
        }
        #endregion

        #region Public Field
        /// <summary>
        /// 添加指标。如果quotas的长度不为1或者4，产生异常
        /// </summary>
        /// <param name="level1">一级标题</param>
        /// <param name="level2">耳机标题</param>
        /// <param name="quotas">优良中差</param>
        /// <param name="exception">异常信息</param>
        public void Add(string level1, string level2, string[] quotas, ref string exception)
        { 
            if(quotas.Length != 1 || quotas.Length != 4)
            {
                exception += "指标数量不对";
                return;
            }
            if(lib.Keys.Contains(level1))
            {
                if(lib[level1].Keys.Contains(level2))
                {
                    exception = "该指标已存在";
                    return;
                }
                else
                {
                    lib[level1].Add(level2, quotas);
                }
            }
            else
            {
                Dictionary<string, string[]> tempdic = new Dictionary<string, string[]>();
                tempdic.Add(level2, quotas);
                lib.Add(level1, tempdic);
            }
        }

        /// <summary>
        /// 返回一级指标。若不存在一级指标，返回Null并填写异常信息
        /// </summary>
        /// <param name="exception">异常信息</param>
        /// <returns>返回一级指标的列表</returns>
        public List<string> GetLevel1(ref string exception)
        {
            if (lib.Keys.Count == 0)
            {
                exception += "指标库为空";
                return null;
            }
            List<string> level1s = new List<string>();
            foreach (string key in lib.Keys)
            {
                level1s.Add(key);
            }
            return level1s;
        }

        /// <summary>
        /// 返回指定一级指标下二级指标的列表。若不存在指定的一级指标或者指定的一级指标下二级指标为空，返回null，并填写异常信息
        /// </summary>
        /// <param name="level1">指定的一级指标</param>
        /// <param name="exception">异常信息</param>
        /// <returns>二级指标的列表。若不存在指定的一级指标或者指定的一级指标下二级指标为空，返回null，并填写异常信息</returns>
        public List<string> GetLevel2(string level1, ref string exception)
        {
            if (!lib.Keys.Contains(level1))
            {
                exception += "指标库不含该一级指标";
                return null;
            }
            if (lib[level1].Keys.Count == 0)
            {
                exception += "指标库中该一级指标下二级指标数量为0";
                return null;
            }
            List<string> level2s = new List<string>();
            foreach (string key in lib[level1].Keys)
            {
                level2s.Add(key);
            }
            return level2s;
        }

        /// <summary>
        /// 返回指标的优良中差内容。若不包含指定的一级指标或者二级指标，返回null，并填写异常信息
        /// </summary>
        /// <param name="level1">一级指标</param>
        /// <param name="level2">二级指标</param>
        /// <param name="exception">异常信息</param>
        /// <returns>返回优良中差</returns>
        public string[] GetQuotas(string level1, string level2, ref string exception)
        {
            if (!lib.Keys.Contains(level1))
            {
                exception += "指标库不含该一级指标";
                return null;
            }
            if (!lib[level1].Keys.Contains(level2))
            {
                exception += "指标库不含该二级指标";
                return null;
            }
            return lib[level1][level2];
        }
        #endregion
    }
}
