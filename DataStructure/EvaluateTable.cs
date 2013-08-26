using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Quota
    {
        #region Private Field
        string title;
        string[] content;
        //string score;
        #endregion

        #region Public Field
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string[] Content
        {
            get { return content; }
            set { content = value; }
        }

        //public string Score
        //{
        //    get { return score; }
        //    set { score = value; }
        //}
        #endregion

        #region Constructor
        /// <summary>
        /// 如果content的数量不为1或者4，抛出Exception
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">指标内容</param>
        /// <param name="score">分数</param>
        public Quota(string title, string[] content)
        {
            if (content.Length == 1)
            {
                this.title = title;
                this.content = new string[1];
                this.content[0] = content[0];
                //this.score = score;
            }
            else if (content.Length == 4)
            {
                this.title = title;
                this.content = new string[4];
                for (int i = 0; i < 4; i++)
                {
                    this.content[i] = content[i];
                }
                //this.score = score;
            }
            else 
            {
                Exception e = new Exception("指标数目错误");
                throw e;
            }
        }
        #endregion

    }

    public class EvaluateTable
    {
        #region Private Field
        string evaluatedName;
        string postName;                //岗位名称（岗位责任书）
        string laborDep;                //用工部门（岗位责任书）
        string laborUnit;               //用工单位（岗位责任书）
        string startTime;               //考评开始时间（被考评人信息）
        string stopTime;                //考评结束事件（被考评人信息）
        List<Quota> keyResponse;
        List<Quota> keyQualify;
        List<Quota> keyAttitude;
        List<Quota> response;
        List<Quota> qualify;
        List<Quota> attitude;
        List<Quota> reject;
        string keyWeight;
        string responseWeight;
        string qualifyWeitht;
        string attitudeWeight;
        string rejectWeight;
        DocStatus status;
        string comment;
        #endregion

        #region Public Field
        /// <summary>
        /// 配考评人姓名
        /// </summary>
        public string EvaluatedName
        {
            get { return evaluatedName; }
            set { evaluatedName = value; }
        }

        /// <summary>
        /// 岗位名称（岗位责任书）
        /// </summary>
        public string PostName
        {
            get { return postName; }
            set { postName = value; }
        }

        /// <summary>
        /// 用工部门（岗位责任书）
        /// </summary>
        public string LaborDep
        {
            get { return laborDep; }
            set { laborDep = value; }
        }

        /// <summary>
        /// 用工单位（岗位责任书）
        /// </summary>
        public string LaborUnit
        {
            get { return laborUnit; }
            set { laborUnit = value; }
        }

        /// <summary>
        /// 考评开始时间（被考评人信息）
        /// </summary>
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        /// <summary>
        /// 考评结束时间（被考评人信息）
        /// </summary>
        public string StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }

        /// <summary>
        /// 关键岗位职责指标
        /// </summary>
        public List<Quota> KeyResponse
        {
            get { return keyResponse; }
            set { keyResponse = value; }
        }

        /// <summary>
        /// 关键岗位胜任能力指标
        /// </summary>
        public List<Quota> KeyQualify
        {
            get { return keyQualify; }
            set { keyQualify = value; }
        }

        /// <summary>
        /// 关键工作态度指标
        /// </summary>
        public List<Quota> KeyAttitude
        {
            get { return keyAttitude; }
            set { keyAttitude = value; }
        }

        /// <summary>
        /// 岗位职责指标
        /// </summary>
        public List<Quota> Response
        {
            get { return response; }
            set { response = value; }
        }

        /// <summary>
        /// 岗位胜任能力指标
        /// </summary>
        public List<Quota> Qualify
        {
            get { return qualify; }
            set { qualify = value; }
        }

        /// <summary>
        /// 工作态度指标
        /// </summary>
        public List<Quota> Attitude
        {
            get { return attitude; }
            set { attitude = value; }
        }

        /// <summary>
        /// 否决指标
        /// </summary>
        public List<Quota> Reject
        {
            get { return reject; }
            set { reject = value; }
        }

        /// <summary>
        /// 关键绩效指标权重
        /// </summary>
        public string KeyWeight
        {
            get { return keyWeight; }
            set { keyWeight = value; }
        }

        /// <summary>
        /// 岗位职责指标权重
        /// </summary>
        public string ResponseWeight
        {
            get { return responseWeight; }
            set { responseWeight = value; }
        }

        /// <summary>
        /// 岗位胜任能力指标权重
        /// </summary>
        public string QualifyWeitht
        {
            get { return qualifyWeitht; }
            set { qualifyWeitht = value; }
        }

        /// <summary>
        /// 工作态度指标权重
        /// </summary>
        public string AttitudeWeight
        {
            get { return attitudeWeight; }
            set { attitudeWeight = value; }
        }

        /// <summary>
        /// 否决指标权重
        /// </summary>
        public string RejectWeight
        {
            get { return rejectWeight; }
            set { rejectWeight = value; }
        }

        /// <summary>
        /// 状态
        /// </summary>
        public DocStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// 审核意见
        /// </summary>
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        #endregion

        #region Constructor
        public EvaluateTable()
        { 
            keyResponse = new List<Quota>();
            keyQualify = new List<Quota>();
            keyAttitude = new List<Quota>();
            response = new List<Quota>();
            qualify = new List<Quota>();
            attitude = new List<Quota>();
            reject = new List<Quota>();
            keyWeight = "50";
            responseWeight = "20";
            qualifyWeitht = "15";
            attitudeWeight = "15";
            rejectWeight = "100";
            comment = "";
        }
        #endregion


    }
}
