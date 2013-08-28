using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStructure;

namespace Controls
{
    public static class EvaluateTableManagementCtrl
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
            string[] values2 = new string[] { "2", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "0", "" };
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
        /// 查询指标库，返回一级指标，查询结果不为空返回true，否则返回false
        /// </summary>
        /// <param name="level1s"></param>
        /// <param name="excception"></param>
        /// <returns></returns>
        public static bool GetLevel1(ref List<string> level1s, ref string excception)
        {
            level1s.Add("工作态度指标");
            level1s.Add("人际交往能力");
            level1s.Add("团队影响能力");
            level1s.Add("沟通能力");
            level1s.Add("判断和决策能力");
            level1s.Add("计划和执行能力");
            level1s.Add("否决指标");
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
            level2s.Add("进取心");
            level2s.Add("主动性及执行力");
            level2s.Add("团队协作");
            level2s.Add("纪律性");
            level2s.Add("解决问题能力");
            level2s.Add("分析判断能力");
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
        public static bool GetQuota(ref List<string> quota, string level1, string level2, ref string exception)
        {
            quota.Add("容易取得他人信任，建立起长期的牢固的合作关系，并占据主导地位");
            quota.Add("容易与他人建立可信赖的积极发展的长期关系");
            quota.Add("能够与他人建立可信赖的长期关系");
            quota.Add("能够与他人建立一定的合作关系，较为自我");
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
            evaluateTable.EvaluatedName = "张三";
            evaluateTable.PostName = "岗位名称";
            evaluateTable.LaborDep = "用工部门";
            evaluateTable.LaborUnit = "用工单位";
            evaluateTable.StartTime = "考评开始时间";
            evaluateTable.StopTime = "考评结束时间";
            Quota quota1 = new Quota("发展团队1", new string[] { "在团队中是自然的核心人物，任何情况下都能够激励团队，带领团队达成目标", "易于与他人沟通，积极促进团队协作，并能引导团队达到组织目标", "能够根据要求努力促进团队的协作和沟通，使工作顺利开展", "能够与他人合作，努力协调，不会影响工作" });
            Quota quota2 = new Quota("发展团队2", new string[] { "在团队中是自然的核心人物，任何情况下都能够激励团队，带领团队达成目标", "易于与他人沟通，积极促进团队协作，并能引导团队达到组织目标", "能够根据要求努力促进团队的协作和沟通，使工作顺利开展", "能够与他人合作，努力协调，不会影响工作" });
            Quota quota3 = new Quota("发展团队3", new string[] { "在团队中是自然的核心人物，任何情况下都能够激励团队，带领团队达成目标", "易于与他人沟通，积极促进团队协作，并能引导团队达到组织目标", "能够根据要求努力促进团队的协作和沟通，使工作顺利开展", "能够与他人合作，努力协调，不会影响工作" });
            Quota quota4 = new Quota("发展团队4", new string[] { "在团队中是自然的核心人物，任何情况下都能够激励团队，带领团队达成目标", "易于与他人沟通，积极促进团队协作，并能引导团队达到组织目标", "能够根据要求努力促进团队的协作和沟通，使工作顺利开展", "能够与他人合作，努力协调，不会影响工作" });
            evaluateTable.KeyResponse.Add(quota1);
            evaluateTable.KeyResponse.Add(quota2);
            evaluateTable.KeyResponse.Add(quota3);
            evaluateTable.KeyResponse.Add(quota4);
            evaluateTable.KeyQualify.Add(quota1);
            evaluateTable.KeyQualify.Add(quota2);
            evaluateTable.KeyQualify.Add(quota3);
            evaluateTable.KeyQualify.Add(quota4);
            evaluateTable.KeyAttitude.Add(quota1);
            evaluateTable.KeyAttitude.Add(quota2);
            evaluateTable.KeyAttitude.Add(quota3);
            evaluateTable.KeyAttitude.Add(quota4);
            evaluateTable.Response.Add(quota1);
            evaluateTable.Response.Add(quota2);
            evaluateTable.Response.Add(quota3);
            evaluateTable.Response.Add(quota4);
            evaluateTable.Qualify.Add(quota1);
            evaluateTable.Qualify.Add(quota2);
            evaluateTable.Qualify.Add(quota3);
            evaluateTable.Qualify.Add(quota4);
            evaluateTable.Attitude.Add(quota1);
            evaluateTable.Attitude.Add(quota2);
            evaluateTable.Attitude.Add(quota3);
            evaluateTable.Attitude.Add(quota4);
            Quota reject1 = new Quota("其他", new string[] { "" });
            evaluateTable.Status = DocStatus.submitted;
            evaluateTable.Comment = "很不好";
            evaluateTable.Reject.Add(reject1);
            return true;
        }

        /// <summary>
        /// 根据被考评人id查询其岗位责任书是否已通过，已制定返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人id</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool IsExist(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 根据被考评人ID查询岗位责任书，获取工作内容和要求。查询成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="workContntRequest">工作内容和要求列表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetworkContntRequest(string ID, ref List<string[]> workContentRequest, ref string exception)
        {
            workContentRequest.Add(new string[] { "1做好高等研究院的人事信息维护、数据统计、合同管理、材料归档以及会议材料准备工作。", "确保人事信息系统中的信息准确、完备，每月错误处不得超过3处，对人事信息负有保密义务；每月5日前将上月的人事数据统计报表交领导参阅，确保数据准确无误；合同应在到期前做好续签、终止工作，确保劳动合同、聘人报告等材料保存完备、有序，能够及时满足查阅需要；每月10日前将上月各专业高等研究院的考勤表汇总好，按照考勤请假制度的规定，对请假申请单及证明材料进行初审、报批；根据领导的要求将会议材料及时准备好。考核要点：人事信息的准确性、完成工作的及时性、操作流程规范性。" });
            workContentRequest.Add(new string[] { "2做好高等研究院的人事信息维护、数据统计、合同管理、材料归档以及会议材料准备工作。", "确保人事信息系统中的信息准确、完备，每月错误处不得超过3处，对人事信息负有保密义务；每月5日前将上月的人事数据统计报表交领导参阅，确保数据准确无误；合同应在到期前做好续签、终止工作，确保劳动合同、聘人报告等材料保存完备、有序，能够及时满足查阅需要；每月10日前将上月各专业高等研究院的考勤表汇总好，按照考勤请假制度的规定，对请假申请单及证明材料进行初审、报批；根据领导的要求将会议材料及时准备好。考核要点：人事信息的准确性、完成工作的及时性、操作流程规范性。" });
            workContentRequest.Add(new string[] { "3做好高等研究院的人事信息维护、数据统计、合同管理、材料归档以及会议材料准备工作。", "确保人事信息系统中的信息准确、完备，每月错误处不得超过3处，对人事信息负有保密义务；每月5日前将上月的人事数据统计报表交领导参阅，确保数据准确无误；合同应在到期前做好续签、终止工作，确保劳动合同、聘人报告等材料保存完备、有序，能够及时满足查阅需要；每月10日前将上月各专业高等研究院的考勤表汇总好，按照考勤请假制度的规定，对请假申请单及证明材料进行初审、报批；根据领导的要求将会议材料及时准备好。考核要点：人事信息的准确性、完成工作的及时性、操作流程规范性。" });
            workContentRequest.Add(new string[] { "4做好高等研究院的人事信息维护、数据统计、合同管理、材料归档以及会议材料准备工作。", "确保人事信息系统中的信息准确、完备，每月错误处不得超过3处，对人事信息负有保密义务；每月5日前将上月的人事数据统计报表交领导参阅，确保数据准确无误；合同应在到期前做好续签、终止工作，确保劳动合同、聘人报告等材料保存完备、有序，能够及时满足查阅需要；每月10日前将上月各专业高等研究院的考勤表汇总好，按照考勤请假制度的规定，对请假申请单及证明材料进行初审、报批；根据领导的要求将会议材料及时准备好。考核要点：人事信息的准确性、完成工作的及时性、操作流程规范性。" });
            return true;
        }

        /// <summary>
        /// 更新考核表，更新成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="evaluateTable">考核表</param>
        /// <param name="status">考核表状态</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateEvaluateTable(string ID, EvaluateTable evaluateTable, DocStatus status, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 更新审核意见，更新成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="Comment">审核意见</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool UpdateComment(string ID, string Comment, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 设置审核通过，设置成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool SetPass(string ID, ref string exception)
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
        /// 根据被考评人ID删除考评表，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool Delete(string ID, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除所有考评表，删除成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool DeleteAll(ref string exception)
        {
            return false;
        }

        /// <summary>
        /// 获取已提交考核表的被考评人的姓名id字典，不为空返回true，否则返回false
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetSubmittedNameIdDic(ref Dictionary<string, string> dic, ref string exception)
        {
            dic.Add("高1", "1");
            dic.Add("高2", "12345");
            dic.Add("高3", "3");
            return true;
        }
    }
}
