using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class EvaluateTable
    {
        #region Private Field
        string postName;                                    //岗位名称（岗位责任书）
        string laborDep;                                    //用工部门（岗位责任书）
        string laborUnit;                                   //用工单位（岗位责任书）
        string startTime;                                   //考核开始时间（被考评人信息）
        string stopTime;                                    //考核结束时间（被考评人信息）
        List<Dictionary<string, string>> keyDuty;           //关键岗位职责指标
        List<Dictionary<string, string[]>> keyQualify;      //关键岗位胜任能力指标
        List<Dictionary<string, string[]>> keyAttribute;    //关键工作态度指标
        List<Dictionary<string, string>> duty;              //岗位职责指标
        List<Dictionary<string, string[]>> qualify;         //岗位胜任能力指标
        List<Dictionary<string, string[]>> attribute;       //岗位工作态度指标
        List<Dictionary<string, string>> reject;            //否决指标
        #endregion

        #region Public Field

        public string PostName
        {
            get { return postName; }
            set { postName = value; }
        }

        public string LaborDep
        {
            get { return laborDep; }
            set { laborDep = value; }
        }

        public string LaborUnit
        {
            get { return laborUnit; }
            set { laborUnit = value; }
        }

        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public string StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }

        public List<Dictionary<string, string>> KeyDuty
        {
            get { return keyDuty; }
            set { keyDuty = value; }
        }

        private List<Dictionary<string, string[]>> KeyQualify
        {
            get { return keyQualify; }
            set { keyQualify = value; }
        }

        private List<Dictionary<string, string[]>> KeyAttribute
        {
            get { return keyAttribute; }
            set { keyAttribute = value; }
        }

        public List<Dictionary<string, string>> Duty
        {
            get { return duty; }
            set { duty = value; }
        }

        private List<Dictionary<string, string[]>> Qualify
        {
            get { return qualify; }
            set { qualify = value; }
        }

        private List<Dictionary<string, string[]>> Attribute
        {
            get { return attribute; }
            set { attribute = value; }
        }

        public List<Dictionary<string, string>> Reject
        {
            get { return reject; }
            set { reject = value; }
        }
        #endregion
    }
}
