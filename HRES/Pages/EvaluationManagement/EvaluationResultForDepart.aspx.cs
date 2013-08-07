using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controls;
using FineUI;
using DataStructure;
using System.Data;

namespace HRES.Pages.EvaluationManagement
{
    public partial class EvaluationResultForDepart : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindDepartsToDropDownList();
                bindYearsToDropDownList();
            }
        }

        #region Event
        protected void Button_Search_Click(object sender, EventArgs e)
        {
            if (DropDownList_Depart.SelectedValue == "-1")
            {
                Alert.ShowInTop("请选择部门！", MessageBoxIcon.Error);
                return;
            }
            if (DropDownList_Year.SelectedValue == "-1")
            {
                Alert.ShowInTop("请选择年份！", MessageBoxIcon.Error);
                return;
            }

            string exception = "";
            string depart = DropDownList_Depart.SelectedValue;
            string year = DropDownList_Year.SelectedValue;
            DataTable table = new DataTable();
            string startTime = "", stopTime = "", evaluationDate = "";
            if (EvaluationManagementCtrl.GetEvaluationResultByDepartAndYear(ref table, depart, year, ref startTime, ref stopTime, ref evaluationDate, ref exception))
            {
                Grid1.DataSource = table;
                Grid1.DataBind();
                Label_Period.Text = startTime + " ~ " + stopTime;
                Grid1.Title = depart + "（单位)派遣员工考核汇总表"; 
            }
        }
        #endregion

        #region Private Method
        private void bindYearsToDropDownList()
        {
            int year = DateTime.Now.Year;
            for (int i = 2013; i <= year; i++)
            {
                DropDownList_Year.Items.Add(Convert.ToString(i), Convert.ToString(i));
            }
        }

        private void bindDepartsToDropDownList()
        {
            string exception = "";
            List<string> departs = new List<string>();
            if (CommonCtrl.GetDeparts(ref departs, ref exception))
            {
                foreach (string depart in departs)
                {
                    DropDownList_Depart.Items.Add(depart, depart);
                }
            }
            else
            {
                Alert.ShowInTop("获取部门信息失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}