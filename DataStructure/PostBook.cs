using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class PostBook
    {
        #region Private Field
        string evaluatedID;
        string employer;
        string laborUnit;
        string laborDepart;
        string postName;
        string postType;
        string eduBg;
        string certificate;
        string experience;
        string skill;
        string personality;
        string phyCond;
        string workOutline;
        List<string[]> workContentRequest;
        string power;
        string response;
        string directLeader;
        string subordinate;
        string colleague;
        string services;
        string relations;
        string workEnter;
        string postAssess;
        string others;
        string comment;
        DocStatus status;
        #endregion

        #region Public Field
        /// <summary>
        /// 审核意见
        /// </summary>
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        /// <summary>
        /// 被考评人ID
        /// </summary>
        public string EvaluatedID
        {
            get { return evaluatedID; }
            set { evaluatedID = value; }
        }

        /// <summary>
        /// 用人单位
        /// </summary>
        public string Employer
        {
            get { return employer; }
            set { employer = value; }
        }

        /// <summary>
        /// 用工单位
        /// </summary>
        public string LaborUnit
        {
            get { return laborUnit; }
            set { laborUnit = value; }
        }

        /// <summary>
        /// 用工部门
        /// </summary>
        public string LaborDepart
        {
            get { return laborDepart; }
            set { laborDepart = value; }
        }

        /// <summary>
        /// 岗位名称
        /// </summary>
        public string PostName
        {
            get { return postName; }
            set { postName = value; }
        }

        /// <summary>
        /// 岗位类别
        /// </summary>
        public string PostType
        {
            get { return postType; }
            set { postType = value; }
        }

        /// <summary>
        /// 教育背景
        /// </summary>
        public string EduBg
        {
            get { return eduBg; }
            set { eduBg = value; }
        }

        /// <summary>
        /// 培训及资历
        /// </summary>
        public string Certificate
        {
            get { return certificate; }
            set { certificate = value; }
        }

        /// <summary>
        /// 工作经验
        /// </summary>
        public string Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        /// <summary>
        /// 基本技能和素质
        /// </summary>
        public string Skill
        {
            get { return skill; }
            set { skill = value; }
        }

        /// <summary>
        /// 个性特征
        /// </summary>
        public string Personality
        {
            get { return personality; }
            set { personality = value; }
        }

        /// <summary>
        /// 体制条件
        /// </summary>
        public string PhyCond
        {
            get { return phyCond; }
            set { phyCond = value; }
        }

        /// <summary>
        /// 岗位概述
        /// </summary>
        public string WorkOutline
        {
            get { return workOutline; }
            set { workOutline = value; }
        }

        /// <summary>
        /// 工作内容和要求
        /// </summary>
        public List<string[]> WorkContentRequest
        {
            get { return workContentRequest; }
            set { workContentRequest = value; }
        }

        /// <summary>
        /// 权利
        /// </summary>
        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        /// <summary>
        /// 责任
        /// </summary>
        public string Response
        {
            get { return response; }
            set { response = value; }
        }

        /// <summary>
        /// 直接领导
        /// </summary>
        public string DirectLeader
        {
            get { return directLeader; }
            set { directLeader = value; }
        }

        /// <summary>
        /// 下属
        /// </summary>
        public string Subordinate
        {
            get { return subordinate; }
            set { subordinate = value; }
        }

        /// <summary>
        /// 同事
        /// </summary>
        public string Colleague
        {
            get { return colleague; }
            set { colleague = value; }
        }

        /// <summary>
        /// 服务对象
        /// </summary>
        public string Services
        {
            get { return services; }
            set { services = value; }
        }

        /// <summary>
        /// 外部关系
        /// </summary>
        public string Relations
        {
            get { return relations; }
            set { relations = value; }
        }

        /// <summary>
        /// 工作环境
        /// </summary>
        public string WorkEnter
        {
            get { return workEnter; }
            set { workEnter = value; }
        }

        /// <summary>
        /// 岗位考核
        /// </summary>
        public string PostAssess
        {
            get { return postAssess; }
            set { postAssess = value; }
        }

        /// <summary>
        /// 其他约定
        /// </summary>
        public string Others
        {
            get { return others; }
            set { others = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public DocStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        #region Constructor
        public PostBook()
        { }
        #endregion
    }
}
