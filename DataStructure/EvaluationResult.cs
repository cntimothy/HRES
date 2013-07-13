using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class EvaluationResult
    {
        #region Private Field
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
