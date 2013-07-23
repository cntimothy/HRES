﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FineUI;
using DataStructure;
using Controls;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using AspNet = System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace HRES.Pages.EvaluatorManagement
{
    public partial class iframe_MakeEvaluator : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button_Close.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();
                Panel1.Title = Request.QueryString["name"] + "的考评人名单";
                bindEvaluatorToGrid();
                SetSubmitted();
                DocStatus status = (DocStatus)Enum.Parse(typeof(DocStatus), Request.QueryString["status"]);
                if (status == DocStatus.submitted || status == DocStatus.passed)
                {
                    Button_Submit.Enabled = false;
                    Button_Clear.Enabled = false;
                }
            }
        }

        #region Event
        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            SyncSelectedRowIndexArrayToHiddenField();

            Grid1.PageIndex = e.NewPageIndex;

            UpdateSelectedRowIndexArray();

        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            SyncSelectedRowIndexArrayToHiddenField();
            string exception = "";
            string evaluatedID = Request.QueryString["id"];
            if (hfSelectedIDS.Text == "{}")
            {
                Alert.ShowInTop("请至少选择一项！", MessageBoxIcon.Warning);
                return;
            }
            Dictionary<string, string> dic = (new JavaScriptSerializer()).Deserialize<Dictionary<string, string>>(hfSelectedIDS.Text.Trim());
            if(EvaluatorManagementCtrl.SubmitEvaluator(evaluatedID, dic, ref exception))
            {
                Alert.ShowInTop("提交成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("提交失败！\n原因："+exception, MessageBoxIcon.Error);
                return;
            }
            bindEvaluatorToGrid();
        }

        protected void Button_Clear_Click(object sender, EventArgs e)
        {
            bindEvaluatorToGrid();
        }
        #endregion

        #region Private Method
        private void bindEvaluatorToGrid()
        {
            DataTable table = new DataTable();
            string exception = "";
            string depart = Session["Depart"].ToString();
            if (EvaluatorManagementCtrl.GetSelectableEvaluatorByDepart(ref table, depart, ref exception))
            {
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }

        private void SetSubmitted()
        {
            string evaluated = Request.QueryString["id"];
            string exception = "";
            DataTable table = new DataTable();
            if (EvaluatorManagementCtrl.GetEvaluator(ref table, evaluated, ref exception))
            {
                foreach (DataRow row in table.Rows)
                {
                    Label_Submitted.Text += (row["Name"].ToString() + "，");
                }
            }
        }

        //private List<string> GetSelectedRowIndexArrayFromHiddenField()
        //{
        //    JArray idsArray = new JArray();

        //    string currentIDS = hfSelectedIDS.Text.Trim();
        //    if (!String.IsNullOrEmpty(currentIDS))
        //    {
        //        idsArray = JArray.Parse(currentIDS);
        //    }
        //    else
        //    {
        //        idsArray = new JArray();
        //    }

        //    return new List<string>(idsArray.ToObject<string[]>());
        //}

        private Dictionary<string, string> GetSelectedRowIndexArrayFromHiddenField()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string currentStr = hfSelectedIDS.Text.Trim();
            if (!String.IsNullOrEmpty(currentStr))
            {
                try
                {
                    dic = (new JavaScriptSerializer()).Deserialize<Dictionary<string, string>>(currentStr);
                }
                catch (Exception)
                {
                    Alert.ShowInTop("内部错误！\n错误原因：Json反序列化错误", MessageBoxIcon.Error);
                    return null;
                }
            }

            return dic;
        }

        //private void SyncSelectedRowIndexArrayToHiddenField()
        //{
        //    List<string> ids = GetSelectedRowIndexArrayFromHiddenField();

        //    List<int> selectedRows = new List<int>();
        //    if (Grid1.SelectedRowIndexArray != null && Grid1.SelectedRowIndexArray.Length > 0)
        //    {
        //        selectedRows = new List<int>(Grid1.SelectedRowIndexArray);
        //    }

        //    int startPageIndex = Grid1.PageIndex * Grid1.PageSize;
        //    for (int i = startPageIndex, count = Math.Min(startPageIndex + Grid1.PageSize, Grid1.RecordCount); i < count; i++)
        //    {
        //        string id = Grid1.DataKeys[i][0].ToString();
        //        GridRow row = Grid1.Rows[i];
        //        AspNet.RadioButtonList relationCtrl = (AspNet.RadioButtonList)row.FindControl("Relation");
        //        string relation = relationCtrl.SelectedValue;
        //        if (selectedRows.Contains(i - startPageIndex))
        //        {
        //            if (!ids.Contains(id))
        //            {
        //                ids.Add(id + ":" +relation);
        //            }
        //        }
        //        else
        //        {
        //            if (ids.Contains(id))
        //            {
        //                ids.Remove(id + ":" + relation);
        //            }
        //        }

        //    }

        //    hfSelectedIDS.Text = new JArray(ids).ToString(Formatting.None);
        //}

        private void SyncSelectedRowIndexArrayToHiddenField()
        {
            Dictionary<string, string> dic = GetSelectedRowIndexArrayFromHiddenField();
            List<int> selectedRows = new List<int>();
            if (Grid1.SelectedRowIndexArray != null && Grid1.SelectedRowIndexArray.Length > 0)
            {
                selectedRows = new List<int>(Grid1.SelectedRowIndexArray);
            }
            int startPageIndex = Grid1.PageIndex * Grid1.PageSize;
            for (int i = startPageIndex, count = Math.Min(startPageIndex + Grid1.PageSize, Grid1.RecordCount); i < count; i++)
            {
                string id = Grid1.DataKeys[i][0].ToString();
                GridRow row = Grid1.Rows[i];
                AspNet.RadioButtonList relationCtrl = (AspNet.RadioButtonList)row.FindControl("Relation");
                string relation = relationCtrl.SelectedValue;
                if (selectedRows.Contains(i - startPageIndex))
                {
                    if (!dic.Keys.Contains(id))
                    {
                        dic.Add(id, relation);
                    }
                }
                else
                {
                    if (dic.Keys.Contains(id))
                    {
                        dic.Remove(id);
                    }
                }

            }

            hfSelectedIDS.Text = (new JavaScriptSerializer()).Serialize(dic);
        }


        //private void UpdateSelectedRowIndexArray()
        //{
        //    List<string> ids = GetSelectedRowIndexArrayFromHiddenField();

        //    List<int> nextSelectedRowIndexArray = new List<int>();
        //    int nextStartPageIndex = Grid1.PageIndex * Grid1.PageSize;
        //    for (int i = nextStartPageIndex, count = Math.Min(nextStartPageIndex + Grid1.PageSize, Grid1.RecordCount); i < count; i++)
        //    {
        //        string id = Grid1.DataKeys[i][0].ToString();
        //        if (ids.Contains(id))
        //        {
        //            nextSelectedRowIndexArray.Add(i - nextStartPageIndex);
        //        }
        //    }
        //    Grid1.SelectedRowIndexArray = nextSelectedRowIndexArray.ToArray();
        //}

        private void UpdateSelectedRowIndexArray()
        {
            Dictionary<string, string> dic = GetSelectedRowIndexArrayFromHiddenField();

            List<int> nextSelectedRowIndexArray = new List<int>();
            int nextStartPageIndex = Grid1.PageIndex * Grid1.PageSize;
            for (int i = nextStartPageIndex, count = Math.Min(nextStartPageIndex + Grid1.PageSize, Grid1.RecordCount); i < count; i++)
            {
                string id = Grid1.DataKeys[i][0].ToString();
                if (dic.Keys.Contains(id))
                {
                    nextSelectedRowIndexArray.Add(i - nextStartPageIndex);
                }
            }
            Grid1.SelectedRowIndexArray = nextSelectedRowIndexArray.ToArray();
        }

        #endregion
    }
}