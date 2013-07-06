using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class QuotaDic
    {
        #region Private Field
        private Dictionary<string, string[]> dic;
        #endregion

        #region Public Field
        
        #endregion

        #region Constructor
        public QuotaDic()
        {
            dic = new Dictionary<string, string[]>();
        }
        #endregion

        #region Public Method
        /// <summary>
        /// 增加一个指标
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="level1">优</param>
        /// <param name="level2">良</param>
        /// <param name="level3">中</param>
        /// <param name="level4">差</param>
        public void Add(string title, string level1, string level2, string level3, string level4)
        {
            string[] levels = new string[] { level1, level2, level3, level4 };
            this.dic.Add(title, levels);
        }

        /// <summary>
        /// 获取优的内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <returns></returns>
        public string GetLevel1(string title)
        {
            return dic[title][0];
        }

        /// <summary>
        /// 获取良的内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <returns></returns>
        public string GetLevel2(string title)
        {
            return dic[title][1];
        }

        /// <summary>
        /// 获取中的内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <returns></returns>
        public string GetLevel3(string title)
        {
            return dic[title][2];
        }

        /// <summary>
        /// 获取差的内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <returns></returns>
        public string GetLevel4(string title)
        {
            return dic[title][3];
        }
        #endregion
    }

    public class QuotaLib
    {

    }
}
