using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;

namespace Controls
{
    public static class QuotaManagementCtrl
    {
        /// <summary>
        /// 查询指标库。若指标库为空，返回false，否则返回true
        /// </summary>
        /// <param name="quotaLib">指标库</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetQuotaLib(ref QuotaLib quotaLib, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 查询指标库，获取一级标题。若指标库为空，返回false，否则返回true
        /// </summary>
        /// <param name="level1s"></param>
        /// <param name="excception"></param>
        /// <returns></returns>
        public static bool GetLevel1(ref List<string> level1s, ref string excception)
        {
            return true;
        }

        /// <summary>
        ///查询指标库，获取二级标题，若指定一级标题不存在或者指定一级标题下二级标题为空，返回false，否则返回true 
        /// </summary>
        /// <param name="level2s"></param>
        /// <param name="level1">一级标题</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetLevel2(ref List<string> level2s, string level1, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 查询指标库，获取优良中差指标。查询成功返回true，否则返回false。
        /// </summary>
        /// <param name="quota">优良中差指标或者否决指标（否决指标只有一个，没有优良中差四种）</param>
        /// <param name="level1"></param>
        /// <param name="level2"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetQuota(ref string[] quota, string level1, string level2, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 插入新指标，更新成功返回true，否则返回false（需检测重复）
        /// </summary>
        /// <param name="level1">一级标题</param>
        /// <param name="level2">二级标题</param>
        /// <param name="quotas">优良中差指标</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool AddQuota(string level1, string level2, string[] quotas, ref string exception)
        {
            return true;
        }
        
        /// <summary>
        /// 删除指定的指标。成功返回true，否则返回false
        /// </summary>
        /// <param name="level1">指定的一级标题</param>
        /// <param name="level2">指定的二级标题</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteQuota(string level1, string level2, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 清空指标库，成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ClearLib(ref string exception)
        {
            return true;
        }
    }
}
