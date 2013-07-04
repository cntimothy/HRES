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
        string laborDep;
        string postName;
        string postType;
        string eduBg;
        string certificate;
        string experience;
        string skill;
        string personality;
        string phyCond;
        string workOutline;
        List<string[]> workContntRequest;
        string power;
        string response;
        string directLeader;
        string subordinate;
        string colleague;
        string services;
        string releations;
        string workEnter;
        string postAssess;
        string others;
        string comment;
        DocStatus status;
        #endregion

        #region Public Field
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string EvaluatedID
        {
            get { return evaluatedID; }
            set { evaluatedID = value; }
        }

        public string Employer
        {
            get { return employer; }
            set { employer = value; }
        }

        public string LaborUnit
        {
            get { return laborUnit; }
            set { laborUnit = value; }
        }

        public string LaborDep
        {
            get { return laborDep; }
            set { laborDep = value; }
        }

        public string PostName
        {
            get { return postName; }
            set { postName = value; }
        }

        public string PostType
        {
            get { return postType; }
            set { postType = value; }
        }

        public string EduBg
        {
            get { return eduBg; }
            set { eduBg = value; }
        }

        public string Certificate
        {
            get { return certificate; }
            set { certificate = value; }
        }

        public string Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public string Skill
        {
            get { return skill; }
            set { skill = value; }
        }

        public string Personality
        {
            get { return personality; }
            set { personality = value; }
        }

        public string PhyCond
        {
            get { return phyCond; }
            set { phyCond = value; }
        }

        public string WorkOutline
        {
            get { return workOutline; }
            set { workOutline = value; }
        }

        public List<string[]> WorkContntRequest
        {
            get { return workContntRequest; }
            set { workContntRequest = value; }
        }

        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Response
        {
            get { return response; }
            set { response = value; }
        }

        public string DirectLeader
        {
            get { return directLeader; }
            set { directLeader = value; }
        }

        public string Subordinate
        {
            get { return subordinate; }
            set { subordinate = value; }
        }

        public string Colleague
        {
            get { return colleague; }
            set { colleague = value; }
        }

        public string Services
        {
            get { return services; }
            set { services = value; }
        }

        public string Releations
        {
            get { return releations; }
            set { releations = value; }
        }

        public string WorkEnter
        {
            get { return workEnter; }
            set { workEnter = value; }
        }

        public string PostAssess
        {
            get { return postAssess; }
            set { postAssess = value; }
        }

        public string Others
        {
            get { return others; }
            set { others = value; }
        }

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
