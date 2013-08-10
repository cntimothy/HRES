using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataStructure;

namespace Controls
{
    public static class PostBookManagementCtrl
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
            string[] values1 = new string[] { "1", "2010-3-3", "高1", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values2 = new string[] { "2", "2010-3-3", "高2", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values3 = new string[] { "3", "2010-3-3", "高3", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values4 = new string[] { "4", "2010-3-3", "高4", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "1", "" };
            string[] values5 = new string[] { "5", "2010-3-3", "高5", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values6 = new string[] { "6", "2010-3-3", "高6", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values7 = new string[] { "123456", "2010-3-3", "高7", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values8 = new string[] { "123456", "2010-3-3", "高8", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values9 = new string[] { "123456", "2010-3-3", "高9", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values10 = new string[] { "123456", "2010-3-3", "高10", "男", "医学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "test for comment" };
            string[] values11 = new string[] { "123456", "2010-3-3", "高11", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values12 = new string[] { "123456", "2010-3-3", "高12", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values13 = new string[] { "123456", "2010-3-3", "高13", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values14 = new string[] { "123456", "2010-3-3", "高14", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "test for comment" };
            string[] values15 = new string[] { "123456", "2010-3-3", "高15", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values16 = new string[] { "123456", "2010-3-3", "高16", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values17 = new string[] { "123456", "2010-3-3", "高17", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values18 = new string[] { "123456", "2010-3-3", "高18", "男", "外国语学院", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
            string[] values19 = new string[] { "123456", "2010-3-3", "高19", "男", "人事处", "饲养员", "1234556789012", "1989-1-2", "学校", "劳务", "东林", "2013-7-10", "2013-8-10", "2", "" };
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
        /// 根据被考评人ID查询岗位责任书，查询成功返回true，否则返回false
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="evaluatedID"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetPostBook(ref PostBook pb, string evaluatedID, ref string exception)
        {
            pb.EvaluatedID = evaluatedID;
            pb.Employer = "上海市东凌国际人才有限公司";
            pb.LaborUnit = "同济大学高等研究院";
            pb.LaborDepart = "高等研究院办公室";
            pb.PostName = "人事助理";
            pb.PostType = "管理";
            pb.EduBg = "人力资源、行政管理或相关专业本科以上学历。";
            pb.Certificate = "接受过现代人力资源管理技术、劳动法规、企业管理、领导艺术、心理学、财务知识等方面的培训。";
            pb.Experience = "在大中型企事业单位从事人力资源管理工作4年以上。";
            pb.Skill = "（1）具备先进的人力资源管理理念和方法；\n（2）掌握国家、上海各项劳动法律法规，并能熟练运用；\n（3）具备较强的管理能力和服务意识，善于沟通，具备出色的组织协调能力及分析判断能力，富有亲和力，有较强的说服能力；\n（4）具备较强的观察能力和应变能力；\n（5）具备较强的计划能力、控制能力；\n（6）具备较强的语言表达能力、文字功底；\n（7）熟练操作办公自动化相关软件，具有较强的英语听、说、读、写能力。";
            pb.Personality = "（1）性格温和，有耐心；\n（2）主动积极，乐观，乐于助人，诚实守信；\n（3）工作严谨、敬业、责任心强；\n（4）具有团队合作精神。";
            pb.PhyCond = "身体健康，能承受一定的工作压力和强度。";
            pb.WorkOutline = "本岗位主要承担高等研究院的人事政策咨询，进人、离职报告的初审，人员入职、离职手续的办理，招聘信息的发布，薪酬发放，高等研究院的人事信息维护，数据统计，合同管理，材料归档，考勤请假以及按照计划组织实施培训、考核等工作。";
            pb.WorkContentRequest = new List<string[]>();
            string[] values1 = new string[] { "做好各专业高等研究院的人事政策咨询、来访接待工作。", "对各专业高等研究院的人事管理工作提供服务和指导；\n接受各专业高等研究院对学校人事政策、劳动法律法规的咨询；\n指导各专业高等研究院对人事、劳动争议的处理，避免劳动纠纷的发生。", "接待来访老师应热情亲切，微笑服务，暂时不能解决的问题应及时记录，待请示领导或咨询相关部门后及时（1个工作日内）回馈提问者。来电应在铃响4声内接听，如遇忙时应委婉的告知对方，请对方稍等或者稍后回复对方。", "服务态度满意度；问题回馈的及时性；政策解答的准确性。" };
            string[] values2 = new string[] { "做好各专业高等研究院的招聘工作。", "对各专业高等研究院的招聘需求进行审核、上报，经主管领导批准后，发布招聘信息，收集求职简历，配合专业高等研究院做好招聘工作。", "　　　在收到招聘需求后的一天内将审核意见回馈给用人部门，招聘需求符合规定（后）的应在当天及时上报主管领导；主管领导批准后的两天内，应按要求通过至少两种渠道发布招聘信息；在招聘截止后的两天内将所有有效简历汇总后移交用工部门。", "　　　操作流程规范性；每一步骤的及时性。" };
            string[] values3 = new string[] { "做好各专业高等研究院新聘人员的入职工作。", "对各专业高等研究院的聘人报告进行初审、上报，经主管领导批准后，按规定组织新聘人员签订合同及办理相关入职手续。协助新聘人员办理申请落沪、申办上海市居住证、组织关系转移、档案转移、申请加入工会、申请宿舍、子女入托等工作。", "　　　在收到聘人报告后的一个工作日内将初审意见反馈给用人部门，聘人材料符合规定（后）的应在当天及时上报；主管领导批准后的一个工作日内应及时通知用工部门及新聘人员在规定的时间内前来报到；服务应热情周到，耐心解答新聘员工的问题，尽力满足新聘人员的合理要求。", "操作流程规范性；每一步骤的及时性；服务态度满意度。" };
            string[] values4 = new string[] { "做好各专业高等研究院在聘人员的离职工作。", "对各专业高等研究院的人员离职报告进行初审、上报，经主管领导批准后，按规定为离职人员办理相关离职手续。协调、配合专业高等研究院及派遣公司处理人事、劳动纠纷。", "对离职工作的要求同入职工作；遇到发生人事、劳动纠纷，应在一个工作日内向当事人及其领导部门了解情况，并向领导汇报，同时告知员工所在部门按程序办理相关手续。具备较好的处理劳动纠纷的相关法律知识和技巧。", "操作流程规范性；每一步骤的及时性；专业知识；应变能力。" };
            string[] values5 = new string[] { "辅助做好高等研究院的培训工作。", "平时注意收集各高等研究院的各项培训需求，并及时向领导汇报，根据领导的要求拟定培训通知，组织实施培训活动。", "能够根据工作中存在的问题、考核结果收集、总结培训需求工领导参考，能够比较规范、准确的拟定培训通知，并按培训计划的时间和要求组织实施培训活动。", "分析判断能力、行文能力、组织协调能力。" };
            string[] values6 = new string[] { "做好高等研究院的薪酬发放工作。", "做好高等研究院工资、奖金、年终奖的发放工作。", "按照借用人员的薪酬标准每月30日前将做好的薪酬支付明细及结算凭证发给借用公司，保证借用人员的工资于次月的发工资日能按时进工资卡。", "工资、奖金、年终奖发放的及时性和准确性。" };
            pb.WorkContentRequest.Add(values1);
            pb.WorkContentRequest.Add(values2);
            pb.WorkContentRequest.Add(values3);
            pb.WorkContentRequest.Add(values4);
            pb.WorkContentRequest.Add(values5);
            pb.WorkContentRequest.Add(values6);
            pb.Power = "（1）对高等研究院人力资源规划有建议权。（2）对违反人力资源管理制度的单位和个人，有处罚建议权。（3）要求相关人员配合工作的权力。";
            pb.Response = "（1）对本职工作质量负责。（2）如因工作失职，给学校造成损失，应负相应的经济责任和行政责任。";
            pb.DirectLeader = "高等研究院人事主管。";
            pb.Subordinate = "无。";
            pb.Colleague = "人事处、相关职能部处、各专业高等研究院等。";
            pb.Services = "各专业高等研究院人事工作人员。";
            pb.Relations = "派遣公司、劳动、保险、就业、职介、人才中心等与人事相关的社会公共关系。";
            pb.WorkEnter = "办公室内，环境舒适，无职业病危害。";
            pb.PostAssess = "按同济大学派遣员工考核文件的规定执行。";
            pb.Others = "本岗位责任书自双方签字盖章且经人才中心审核盖章后生效，与劳动合同具有相同效力，双方均应遵照执行。\n自本岗位责任书生效之日起，双方之前就受聘人员岗位达成的约定、协议或岗位责任书与本岗位责任书不一致的，以本岗位责任书为准。\n本岗位责任书一式四份，人才中心持两份，个人及个人所在部门各持一份。";
            pb.Comment = "很不好";
            pb.Status = DocStatus.saved;
            return true;
        }

        /// <summary>
        /// 更新岗位责任书
        /// </summary>
        /// <param name="pb">岗位责任书</param>
        /// <param name="exception"></param>
        /// <returns>更新成功返回true，否则返回false</returns>
        public static bool UpdatePostBook(PostBook pb, ref string exception)
        {
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
        /// <param name="IDs">被考评人ID</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool Delete(List<string> IDs, ref string exception)
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
        /// 根据被考评人ID查询岗位责任书，查询成功返回true，否则返回false
        /// </summary>
        /// <param name="ID">被考评人ID</param>
        /// <param name="postBook">岗位责任书</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetPostBook(string ID, ref PostBook postBook, ref string exception)
        {
            return true;
        }
    }
}
