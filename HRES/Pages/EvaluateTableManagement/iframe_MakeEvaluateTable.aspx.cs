﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using Controls;
using DataStructure;

namespace HRES.Pages.EvaluateTableManagement
{
    public partial class iframe_MakeEvaluateTable : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!checkPostBook())
                {
                    Alert.ShowInTop("被考评人岗位责任书尚未通过审核！\n窗口即将关闭", MessageBoxIcon.Error);
                    PageContext.RegisterStartupScript(ActiveWindow.GetHideReference());
                }

                //TriggerBox_KeyResponse_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyResponse_1.ClientID, TextArea_KeyResponse_1.ClientID, HiddenField_KeyResponse_1.ClientID)
                    //+ Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");

                //关键岗位职责指标
                TriggerBox_KeyResponse_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyResponse_1.ClientID, TextArea_KeyResponse_1.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_KeyResponse_2.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyResponse_2.ClientID, TextArea_KeyResponse_2.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_KeyResponse_3.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyResponse_3.ClientID, TextArea_KeyResponse_3.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_KeyResponse_4.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyResponse_4.ClientID, TextArea_KeyResponse_4.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_KeyResponse_5.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyResponse_5.ClientID, TextArea_KeyResponse_5.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                
                //岗位职责指标
                TriggerBox_Response_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Response_1.ClientID, TextArea_Response_1.ClientID)
                   + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_Response_2.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Response_2.ClientID, TextArea_Response_2.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_Response_3.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Response_3.ClientID, TextArea_Response_3.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_Response_4.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Response_4.ClientID, TextArea_Response_4.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);
                TriggerBox_Response_5.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Response_5.ClientID, TextArea_Response_5.ClientID)
                    + Window_ShowQuota.GetShowReference("iframe_ShowWCR.aspx?id=" + Request.QueryString["id"]);

                //关键岗位胜任能力指标
                TriggerBox_KeyQualify_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyQualify_1.ClientID, TextArea_KeyQualify_1.ClientID, HiddenField_KeyQualify_1.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyQualify_2.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyQualify_2.ClientID, TextArea_KeyQualify_2.ClientID, HiddenField_KeyQualify_2.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyQualify_3.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyQualify_3.ClientID, TextArea_KeyQualify_3.ClientID, HiddenField_KeyQualify_3.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyQualify_4.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyQualify_4.ClientID, TextArea_KeyQualify_4.ClientID, HiddenField_KeyQualify_4.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyQualify_5.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyQualify_5.ClientID, TextArea_KeyQualify_5.ClientID, HiddenField_KeyQualify_5.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");

                //关键岗位态度指标
                TriggerBox_KeyAttitude_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyAttitude_1.ClientID, TextArea_KeyAttitude_1.ClientID, HiddenField_KeyAttitude_1.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyAttitude_2.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyAttitude_2.ClientID, TextArea_KeyAttitude_2.ClientID, HiddenField_KeyAttitude_2.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyAttitude_3.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyAttitude_3.ClientID, TextArea_KeyAttitude_3.ClientID, HiddenField_KeyAttitude_3.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyAttitude_4.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyAttitude_4.ClientID, TextArea_KeyAttitude_4.ClientID, HiddenField_KeyAttitude_4.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_KeyAttitude_5.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_KeyAttitude_5.ClientID, TextArea_KeyAttitude_5.ClientID, HiddenField_KeyAttitude_5.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");

                //岗位胜任能力指标
                TriggerBox_Qualify_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Qualify_1.ClientID, TextArea_Qualify_1.ClientID, HiddenField_Qualify_1.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Qualify_2.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Qualify_2.ClientID, TextArea_Qualify_2.ClientID, HiddenField_Qualify_2.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Qualify_3.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Qualify_3.ClientID, TextArea_Qualify_3.ClientID, HiddenField_Qualify_3.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Qualify_4.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Qualify_4.ClientID, TextArea_Qualify_4.ClientID, HiddenField_Qualify_4.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Qualify_5.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Qualify_5.ClientID, TextArea_Qualify_5.ClientID, HiddenField_Qualify_5.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");

                //工作态度指标
                TriggerBox_Attitude_1.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Attitude_1.ClientID, TextArea_Attitude_1.ClientID, HiddenField_Attitude_1.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Attitude_2.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Attitude_2.ClientID, TextArea_Attitude_2.ClientID, HiddenField_Attitude_2.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Attitude_3.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Attitude_3.ClientID, TextArea_Attitude_3.ClientID, HiddenField_Attitude_3.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Attitude_4.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Attitude_4.ClientID, TextArea_Attitude_4.ClientID, HiddenField_Attitude_4.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");
                TriggerBox_Attitude_5.OnClientTriggerClick = Window_ShowQuota.GetSaveStateReference(TriggerBox_Attitude_5.ClientID, TextArea_Attitude_5.ClientID, HiddenField_Attitude_5.ClientID)
                + Window_ShowQuota.GetShowReference("iframe_ShowQuota.aspx");

                Button_Close.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();

                DocStatus curStatus = (DocStatus)Enum.Parse(typeof(DocStatus), Request.QueryString["status"]);
                if (curStatus == DocStatus.submitted || curStatus == DocStatus.passed)
                {
                    Button_Save.Enabled = false;
                    Button_Submit.Enabled = false;
                }

                loadEvaluateTable();
            }
        }
        #endregion

        #region Event
        protected void Window_ShowQuota_Close(object sender, WindowCloseEventArgs e)
        { 
            
        }

        protected void Button_Save_Click(object sender, EventArgs e)
        {
            DocStatus curStatus = (DocStatus)Enum.Parse(typeof(DocStatus), Request.QueryString["status"]);
            DocStatus nextStatus = GetNextDocStatus(curStatus, DocOperation.save);
            EvaluateTable evaluateTable = getNewEvaluateTable();
            string evaluatedID = Request.QueryString["id"];
            string exception = "";
            if (EvaluateTableManagementCtrl.UpdateEvaluateTable(evaluatedID, evaluateTable, nextStatus, ref exception))
            {
                Alert.ShowInTop("保存成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("保存失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            DocStatus curStatus = (DocStatus)Enum.Parse(typeof(DocStatus), Request.QueryString["status"]);
            DocStatus nextStatus = GetNextDocStatus(curStatus, DocOperation.submit);
            EvaluateTable evaluateTable = getNewEvaluateTable();
            string evaluatedID = Request.QueryString["id"];
            string exception = "";
            if (EvaluateTableManagementCtrl.UpdateEvaluateTable(evaluatedID, evaluateTable, nextStatus, ref exception))
            {
                Alert.ShowInTop("保存成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("保存失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Private Method
        private void loadEvaluateTable()
        {
            string evaluatedID = Request.QueryString["id"];
            EvaluateTable evaluateTable = new EvaluateTable();
            string exception = "";
            if (EvaluateTableManagementCtrl.GetEvaluateTable(evaluatedID, ref evaluateTable, ref exception))
            {
                Label_Comment.Text = evaluateTable.Comment;

                Label_EvaluatedName.Text = evaluateTable.EvaluatedName;
                Label_PostName.Text = evaluateTable.PostName;
                Label_LaborDep.Text = evaluateTable.LaborDep;
                Label_LaborUnit.Text = evaluateTable.LaborUnit;
                Label_Period.Text = evaluateTable.StartTime + " ~ " + evaluateTable.StopTime;

                for (int i = 0; i < evaluateTable.KeyResponse.Count; i++)
                {
                    SimpleForm sf = Panel3.Items[i] as SimpleForm;
                    sf.Collapsed = false;
                    TriggerBox tb = sf.Items[0] as TriggerBox;
                    TextArea ta = sf.Items[1] as TextArea;
                    tb.Text = evaluateTable.KeyResponse[i].Title;
                    ta.Text = evaluateTable.KeyResponse[i].Content[0];
                }

                for (int i = 0; i < evaluateTable.KeyQualify.Count; i++)
                {
                    SimpleForm sf = Panel4.Items[i] as SimpleForm;
                    sf.Collapsed = false;
                    TriggerBox tb = sf.Items[0] as TriggerBox;
                    TextArea ta = sf.Items[1] as TextArea;
                    tb.Text = evaluateTable.KeyQualify[i].Title;
                    ta.Text = "优：" + evaluateTable.KeyQualify[i].Content[0]
                        + " 良：" + evaluateTable.KeyQualify[i].Content[1]
                        + " 中：" + evaluateTable.KeyQualify[i].Content[2]
                        + " 差：" + evaluateTable.KeyQualify[i].Content[3];

                    FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                        hf.Text = evaluateTable.KeyQualify[i].Title
                        + "&" + evaluateTable.KeyQualify[i].Content[0]
                        + "^" + evaluateTable.KeyQualify[i].Content[1]
                        + "^" + evaluateTable.KeyQualify[i].Content[2]
                        + "^" + evaluateTable.KeyQualify[i].Content[3];
                }

                for (int i = 0; i < evaluateTable.KeyAttitude.Count; i++)
                {
                    SimpleForm sf = Panel5.Items[i] as SimpleForm;
                    sf.Collapsed = false;
                    TriggerBox tb = sf.Items[0] as TriggerBox;
                    TextArea ta = sf.Items[1] as TextArea;
                    tb.Text = evaluateTable.KeyAttitude[i].Title;
                    ta.Text = "优：" + evaluateTable.KeyAttitude[i].Content[0]
                        + " 良：" + evaluateTable.KeyAttitude[i].Content[1]
                        + " 中：" + evaluateTable.KeyAttitude[i].Content[2]
                        + " 差：" + evaluateTable.KeyAttitude[i].Content[3];

                    FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                    hf.Text = evaluateTable.KeyAttitude[i].Title
                    + "&" + evaluateTable.KeyAttitude[i].Content[0]
                    + "^" + evaluateTable.KeyAttitude[i].Content[1]
                    + "^" + evaluateTable.KeyAttitude[i].Content[2]
                    + "^" + evaluateTable.KeyAttitude[i].Content[3];
                }

                for (int i = 0; i < evaluateTable.Response.Count; i++)
                {
                    SimpleForm sf = Panel6.Items[i] as SimpleForm;
                    sf.Collapsed = false;
                    TriggerBox tb = sf.Items[0] as TriggerBox;
                    TextArea ta = sf.Items[1] as TextArea;
                    tb.Text = evaluateTable.Response[i].Title;
                    ta.Text = evaluateTable.Response[i].Content[0];
                }

                for (int i = 0; i < evaluateTable.Qualify.Count; i++)
                {
                    SimpleForm sf = Panel7.Items[i] as SimpleForm;
                    sf.Collapsed = false;
                    TriggerBox tb = sf.Items[0] as TriggerBox;
                    TextArea ta = sf.Items[1] as TextArea;
                    tb.Text = evaluateTable.Qualify[i].Title;
                    ta.Text = "优：" + evaluateTable.Qualify[i].Content[0]
                        + " 良：" + evaluateTable.Qualify[i].Content[1]
                        + " 中：" + evaluateTable.Qualify[i].Content[2]
                        + " 差：" + evaluateTable.Qualify[i].Content[3];

                    FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                    hf.Text = evaluateTable.Qualify[i].Title
                    + "&" + evaluateTable.Qualify[i].Content[0]
                    + "^" + evaluateTable.Qualify[i].Content[1]
                    + "^" + evaluateTable.Qualify[i].Content[2]
                    + "^" + evaluateTable.Qualify[i].Content[3];
                }

                for (int i = 0; i < evaluateTable.Attitude.Count; i++)
                {
                    SimpleForm sf = Panel8.Items[i] as SimpleForm;
                    sf.Collapsed = false;
                    TriggerBox tb = sf.Items[0] as TriggerBox;
                    TextArea ta = sf.Items[1] as TextArea;
                    tb.Text = evaluateTable.Attitude[i].Title;
                    ta.Text = "优：" + evaluateTable.Attitude[i].Content[0]
                        + " 良：" + evaluateTable.Attitude[i].Content[1]
                        + " 中：" + evaluateTable.Attitude[i].Content[2]
                        + " 差：" + evaluateTable.Attitude[i].Content[3];

                    FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                    hf.Text = evaluateTable.Attitude[i].Title
                    + "&" + evaluateTable.Attitude[i].Content[0]
                    + "^" + evaluateTable.Attitude[i].Content[1]
                    + "^" + evaluateTable.Attitude[i].Content[2]
                    + "^" + evaluateTable.Attitude[i].Content[3];
                }

                if (evaluateTable.Reject.Count == 0)
                {
                    TextArea_Reject1.Text = "累计旷工3天以上的；严重失职，营私舞弊，给本单位造成3000元以上经济损失或者其它严重后果的；同时与其他用人单位建立劳动关系，对完成本单位工作任务造成严重影响，或者经本单位提出，拒不改正的；违背职业道德，行贿、受贿价值超过3000元以上的；被依法追究刑事责任的；";
                    TextArea_Reject2.Text = "";
                }
                else
                {
                    TextArea_Reject1.Text = evaluateTable.Reject[0].Content[0];
                    TextArea_Reject2.Text = evaluateTable.Reject[1].Content[0];
                }
            }
        }

        private EvaluateTable getNewEvaluateTable()
        {
            EvaluateTable evaluateTable = new EvaluateTable();
            evaluateTable.EvaluatedName = Label_EvaluatedName.Text.Trim();
            evaluateTable.PostName = Label_PostName.Text.Trim();
            evaluateTable.LaborDep = Label_LaborDep.Text.Trim();
            evaluateTable.LaborUnit = Label_LaborUnit.Text.Trim();
            evaluateTable.StartTime = Label_Period.Text.Split('~')[0].Trim();
            evaluateTable.StopTime = Label_Period.Text.Split('~')[1].Trim();
            foreach (ControlBase item in Panel3.Items)
            {
                SimpleForm sf = item as SimpleForm;
                TriggerBox tb = sf.Items[0] as TriggerBox;
                if (tb.Text == "")
                {
                    break;
                }
                TextArea ta = sf.Items[1] as TextArea;
                evaluateTable.KeyResponse.Add(new Quota(tb.Text.Trim(), new string[] { ta.Text.Trim() }));
            }

            foreach (ControlBase item in Panel4.Items)
            {
                SimpleForm sf = item as SimpleForm;
                TriggerBox tb = sf.Items[0] as TriggerBox;
                if (tb.Text.Trim() == "")
                {
                    break;
                }
                FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                string title = hf.Text.Split('&')[0].Trim();
                string[] content = hf.Text.Split('&')[1].Split('^');
                evaluateTable.KeyQualify.Add(new Quota(title, content));
            }

            foreach (ControlBase item in Panel5.Items)
            {
                SimpleForm sf = item as SimpleForm;
                TriggerBox tb = sf.Items[0] as TriggerBox;
                if (tb.Text.Trim() == "")
                {
                    break;
                }
                FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                string title = hf.Text.Split('&')[0].Trim();
                string[] content = hf.Text.Split('&')[1].Split('^');
                evaluateTable.KeyAttitude.Add(new Quota(title, content));
            }

            foreach (ControlBase item in Panel6.Items)
            {
                SimpleForm sf = item as SimpleForm;
                TriggerBox tb = sf.Items[0] as TriggerBox;
                if (tb.Text == "")
                {
                    break;
                }
                TextArea ta = sf.Items[1] as TextArea;
                evaluateTable.Response.Add(new Quota(tb.Text.Trim(), new string[] { ta.Text.Trim() }));
            }

            foreach (ControlBase item in Panel7.Items)
            {
                SimpleForm sf = item as SimpleForm;
                TriggerBox tb = sf.Items[0] as TriggerBox;
                if (tb.Text.Trim() == "")
                {
                    break;
                }
                FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                string title = hf.Text.Split('&')[0].Trim();
                string[] content = hf.Text.Split('&')[1].Split('^');
                evaluateTable.Qualify.Add(new Quota(title, content));
            }

            foreach (ControlBase item in Panel8.Items)
            {
                SimpleForm sf = item as SimpleForm;
                TriggerBox tb = sf.Items[0] as TriggerBox;
                if (tb.Text.Trim() == "")
                {
                    break;
                }
                FineUI.HiddenField hf = sf.Items[2] as FineUI.HiddenField;
                string title = hf.Text.Split('&')[0].Trim();
                string[] content = hf.Text.Split('&')[1].Split('^');
                evaluateTable.Attitude.Add(new Quota(title, content));
            }
            evaluateTable.Reject.Add(new Quota("严重违反规章制度", new string[] { TextArea_Reject1.Text.Trim() }));
            evaluateTable.Reject.Add(new Quota("其他", new string[] { TextArea_Reject2.Text.Trim() }));

            return evaluateTable;
        }

        /// <summary>
        /// 查询被考评人的岗位责任书是否已通过，已通过返回true，否则返回false
        /// </summary>
        /// <returns></returns>
        private bool checkPostBook()
        {
            string evaluatedID = Request.QueryString["id"];
            string exception = "";
            if (EvaluateTableManagementCtrl.IsExist(ID, ref exception))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}