using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class EvaluationResult
    {
        #region Constructor
        public EvaluationResult(bool is360)
        {
            this.is360 = is360;
            if (is360 == true)
            {
                this.keyScore = new string[5];
                this.responseScore = new string[5];
                this.qualifyScore = new string[5];
                this.attitudeScore = new string[5];
                this.rejectScore = new string[5];
                this.resultScore = new string[5];
                this.evaluatorNum = new int[5];
            }
            else
            {
                this.keyScore = new string[4];
                this.responseScore = new string[4];
                this.qualifyScore = new string[4];
                this.attitudeScore = new string[4];
                this.rejectScore = new string[4];
                this.resultScore = new string[4];
                this.evaluatorNum = new int[4];
            }
        }
        #endregion

        #region Private Field
        private bool is360;
        private string postName;
        private string laborDep;
        private string laborUnit;
        private string startTime;
        private string stopTime;
        private string[] keyScore;
        private string[] responseScore;
        private string[] qualifyScore;
        private string[] attitudeScore;
        private string[] rejectScore;
        private string[] resultScore;
        private int[] evaluatorNum;
        private DepartEvaluationLevel evaluationLevel;
        #endregion

        #region Public Field
        /// <summary>
        /// 是360考核还是270考核
        /// </summary>
        public bool Is360
        {
            get { return is360; }
            set { is360 = value; }
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
        /// 用工部门
        /// </summary>
        public string LaborDep
        {
            get { return laborDep; }
            set { laborDep = value; }
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
        /// 考核开始时间
        /// </summary>
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        /// <summary>
        /// 考核结束时间
        /// </summary>
        public string StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }
        /// <summary>
        /// 关键绩效指标
        /// </summary>
        public string[] KeyScore
        {
            get { return keyScore; }
            set { keyScore = value; }
        }

        /// <summary>
        /// 岗位职责指标
        /// </summary>
        public string[] ResponseScore
        {
            get { return responseScore; }
            set { responseScore = value; }
        }

        /// <summary>
        /// 岗位胜任能力指标
        /// </summary>
        public string[] QualifyScore
        {
            get { return qualifyScore; }
            set { qualifyScore = value; }
        }

        /// <summary>
        /// 工作态度指标
        /// </summary>
        public string[] AttitudeScore
        {
            get { return attitudeScore; }
            set { attitudeScore = value; }
        }

        /// <summary>
        /// 否决指标
        /// </summary>
        public string[] RejectScore
        {
            get { return rejectScore; }
            set { rejectScore = value; }
        }

        /// <summary>
        /// 小计
        /// </summary>
        public string[] ResultScore
        {
            get { return resultScore; }
            set { resultScore = value; }
        }

        /// <summary>
        /// 考评者数量
        /// </summary>
        public int[] EvaluatorNum
        {
            get { return evaluatorNum; }
            set { evaluatorNum = value; }
        }

        /// <summary>
        /// 用工单位考核结果
        /// </summary>
        public DepartEvaluationLevel EvaluationLevel
        {
            get { return evaluationLevel; }
            set { evaluationLevel = value; }
        }
        #endregion
    }
}
