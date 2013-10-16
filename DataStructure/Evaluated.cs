using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class Evaluated
    {
        #region Private Field
        private string id;
        private string name;
        private string sex;
        private string company;
        private string depart;
        private string laborDepart;
        private string postName;
        private string postType;
        private string fund;
        private string character;
        private string startTime;
        private string stopTime;
        #endregion

        #region Public Field
        /// <summary>
        /// ID
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        /// <summary>
        /// 派遣公司、用人单位
        /// </summary>
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        /// <summary>
        /// 用工单位
        /// </summary>
        public string Depart
        {
            get { return depart; }
            set { depart = value; }
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
        /// 经费来源
        /// </summary>
        public string Fund
        {
            get { return fund; }
            set { fund = value; }
        }

        /// <summary>
        /// 派遣性质
        /// </summary>
        public string Character
        {
            get { return character; }
            set { character = value; }
        }

        /// <summary>
        /// 考评开始时间
        /// </summary>
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        /// <summary>
        /// 考评结束时间
        /// </summary>
        public string StopTime
        {
            get { return stopTime; }
            set { stopTime = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public Evaluated()
        { }

        /// <summary>
        /// 被考评人信息
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="company">派遣公司/用人单位</param>
        /// <param name="depart">用工单位</param>
        /// <param name="laborDepart">用工部门</param>
        /// <param name="postName">岗位名称</param>
        /// <param name="postType">岗位类别</param>
        /// <param name="fund">经费来源</param>
        /// <param name="character">派遣性质</param>
        /// <param name="startTime">考评开始时间</param>
        /// <param name="stopTime">考评结束时间</param>
        public Evaluated(string id, string name, string sex, string company, string depart, string laborDepart, string postName, string postType, string fund, string character, string startTime, string stopTime)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Company = company;
            this.Depart = depart;
            this.LaborDepart = laborDepart;
            this.PostName = postName;
            this.PostType = postType;
            this.Fund = fund;
            this.Character = character;
            this.StartTime = startTime;
            this.StopTime = stopTime;
        }
        #endregion
    }
}
