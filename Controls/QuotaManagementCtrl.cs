using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;
using System.Data;

namespace Controls
{
    public static class QuotaManagementCtrl
    {
        /// <summary>
        /// 查询指标库（Level1(一级标题), Level2（二级标题）, Quota1（优）, Quota2（良）, Quota3（中）, Quota4（差））。若指标库为空，返回false，否则返回true
        /// </summary>
        /// <param name="table"></param>
        /// <param name="exceptino"></param>
        /// <returns></returns>
        public static bool GetQuotaLib(ref DataTable table, ref string exceptino)
        {
            table.Columns.Add("Level1");
            table.Columns.Add("Level2");
            table.Columns.Add("Quota1");
            table.Columns.Add("Quota2");
            table.Columns.Add("Quota3");
            table.Columns.Add("Quota4");

            DataRow row1 = table.NewRow();
            row1["Level1"] = "工作态度指标";
            row1["Level2"] = "进取心";
            row1["Quota1"] = "有强烈的使命感和事业心，主动迎接工作挑战";
            row1["Quota2"] = "具备较强的事业心，坚持学习吸收新知识";
            row1["Quota3"] = "具有一定的事业心，能主动学习，注重自己能力提高";
            row1["Quota4"] = "满足现状，局限于完成现有工作";
            table.Rows.Add(row1);
            DataRow row2 = table.NewRow();
            row2["Level1"] = "工作态度指标";
            row2["Level2"] = "主动性及执行力";
            row2["Quota1"] = "能够认真主动地开展工作、执行领导的工作安排，积极解决问题，工作效果很好";
            row2["Quota2"] = "能够执行领导的工作安排，并能在规定的时间内完成，效果较好";
            row2["Quota3"] = "能够执行领导的工作安排，通常能在规定的时间内完成";
            row2["Quota4"] = "经常不接受领导安排的工作或越级汇报；阳奉阴违、影响部门工作开展；工作需经常督促才能勉强完成";
            table.Rows.Add(row2);
            DataRow row3 = table.NewRow();
            row3["Level1"] = "工作态度指标";
            row3["Level2"] = "进取心";
            row3["Quota1"] = "有强烈的使命感和事业心，主动迎接工作挑战";
            row3["Quota2"] = "具备较强的事业心，坚持学习吸收新知识";
            row3["Quota3"] = "具有一定的事业心，能主动学习，注重自己能力提高";
            row3["Quota4"] = "满足现状，局限于完成现有工作";
            table.Rows.Add(row3);
            DataRow row4 = table.NewRow();
            row4["Level1"] = "工作态度指标";
            row4["Level2"] = "主动性及执行力";
            row4["Quota1"] = "能够认真主动地开展工作、执行领导的工作安排，积极解决问题，工作效果很好";
            row4["Quota2"] = "能够执行领导的工作安排，并能在规定的时间内完成，效果较好";
            row4["Quota3"] = "能够执行领导的工作安排，通常能在规定的时间内完成";
            row4["Quota4"] = "经常不接受领导安排的工作或越级汇报；阳奉阴违、影响部门工作开展；工作需经常督促才能勉强完成";
            table.Rows.Add(row4);
            DataRow row5 = table.NewRow();
            row5["Level1"] = "工作态度指标";
            row5["Level2"] = "进取心";
            row5["Quota1"] = "有强烈的使命感和事业心，主动迎接工作挑战";
            row5["Quota2"] = "具备较强的事业心，坚持学习吸收新知识";
            row5["Quota3"] = "具有一定的事业心，能主动学习，注重自己能力提高";
            row5["Quota4"] = "满足现状，局限于完成现有工作";
            table.Rows.Add(row5);
            DataRow row6 = table.NewRow();
            row6["Level1"] = "工作态度指标";
            row6["Level2"] = "主动性及执行力";
            row6["Quota1"] = "能够认真主动地开展工作、执行领导的工作安排，积极解决问题，工作效果很好";
            row6["Quota2"] = "能够执行领导的工作安排，并能在规定的时间内完成，效果较好";
            row6["Quota3"] = "能够执行领导的工作安排，通常能在规定的时间内完成";
            row6["Quota4"] = "经常不接受领导安排的工作或越级汇报；阳奉阴违、影响部门工作开展；工作需经常督促才能勉强完成";
            table.Rows.Add(row6); 
            DataRow row7 = table.NewRow();
            row7["Level1"] = "工作态度指标";
            row7["Level2"] = "进取心";
            row7["Quota1"] = "有强烈的使命感和事业心，主动迎接工作挑战";
            row7["Quota2"] = "具备较强的事业心，坚持学习吸收新知识";
            row7["Quota3"] = "具有一定的事业心，能主动学习，注重自己能力提高";
            row7["Quota4"] = "满足现状，局限于完成现有工作";
            table.Rows.Add(row7);
            DataRow row8 = table.NewRow();
            row8["Level1"] = "工作态度指标";
            row8["Level2"] = "主动性及执行力";
            row8["Quota1"] = "能够认真主动地开展工作、执行领导的工作安排，积极解决问题，工作效果很好";
            row8["Quota2"] = "能够执行领导的工作安排，并能在规定的时间内完成，效果较好";
            row8["Quota3"] = "能够执行领导的工作安排，通常能在规定的时间内完成";
            row8["Quota4"] = "经常不接受领导安排的工作或越级汇报；阳奉阴违、影响部门工作开展；工作需经常督促才能勉强完成";
            table.Rows.Add(row8);
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
