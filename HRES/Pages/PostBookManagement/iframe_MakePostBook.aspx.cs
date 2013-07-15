using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using Controls;
using DataStructure;

namespace HRES.Pages.PostBookManagement
{
    public partial class iframe_MakePostBook : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadPostBook();
                Button_Close.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();
                Button_Close_Shadow.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();
                Button_Return.OnClientClick = Window1.GetShowReference("../Common/iframe_Comment.aspx?id=" + Request.QueryString["id"], "审核意见");
                Button_Return_Shadow.OnClientClick = Window1.GetShowReference("../Common/iframe_Comment.aspx?id=" + Request.QueryString["id"], "审核意见");
                setToolbarVisible();
            }
        }

        #region Event
        protected void Button_Save_Click(object sender, EventArgs e)
        {
            DocStatus curStatus = (DocStatus)Convert.ToInt32(Request.QueryString["status"]);
            DocStatus status = DocStatus.unmake;
            if (curStatus == DocStatus.unmake)
            {
                status = DocStatus.saved;
            }
            else if (curStatus == DocStatus.saved)
            {
                status = DocStatus.saved;
            }
            else if (curStatus == DocStatus.returned)
            {
                status = DocStatus.returned;
            }
            if (savePostBook(status))
            {
                Alert.ShowInTop("保存成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("保存失败！", MessageBoxIcon.Error);
            }
        }

        protected void Button_Submit_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                Alert.ShowInTop("有未填项，请检查！", MessageBoxIcon.Error);
                return;
            }

            DocStatus curStatus = (DocStatus)Convert.ToInt32(Request.QueryString["status"]);
            DocStatus status = DocStatus.unmake;
            if (curStatus == DocStatus.unmake)
            {
                status = DocStatus.submitted;
            }
            else if (curStatus == DocStatus.saved)
            {
                status = DocStatus.submitted;
            }
            else if (curStatus == DocStatus.returned)
            {
                status = DocStatus.modified;
            }
            if (savePostBook(status))
            {
                Alert.ShowInTop("提交成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("提交失败！", MessageBoxIcon.Error);
            }
        }

        protected void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_LaborUnit.Text = "";
            TextBox_LaborDepart.Text = "";
            TextBox_PostName.Text = "";
            TextArea_EduBg.Text = "";
            TextArea_Certificate.Text = "";
            TextArea_Experience.Text = "";
            TextArea_Skill.Text = "";
            TextArea_Personality.Text = "";
            TextArea_PhyCond.Text = "";
            TextArea_WorkOutline.Text = "";
            TextArea_Power.Text = "";
            TextArea_Response.Text = "";
            TextBox_DirectLeader.Text = "";
            TextBox_Subordinate.Text = "";
            TextBox_Colleague.Text = "";
            TextBox_Services.Text = "";
            TextBox_Relations.Text = "";
            TextArea_WorkEnter.Text = "";
            TextArea_PostAssess.Text = "";
            TextArea_Others.Text = "";
            foreach (ControlBase item in Panel6.Items)
            {
                try
                {
                    SimpleForm sf = item as SimpleForm;
                    TextArea ta0 = sf.Items[0] as TextArea;
                    TextArea ta1 = sf.Items[1] as TextArea;
                    TextArea ta2 = sf.Items[2] as TextArea;
                    TextArea ta3 = sf.Items[3] as TextArea;
                    ta0.Text = "";
                    ta1.Text = "";
                    ta2.Text = "";
                    ta3.Text = "";
                    sf.Collapsed = true;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        protected void Button_Pass_Click(object sender, EventArgs e)
        {
            string exception = "";
            string evaluatedID = Request.QueryString["id"];
            if (PostBookManagementCtrl.SetPass(evaluatedID, ref exception))
            {
                Alert.ShowInTop("设置成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("设置失败！\n原因：" + exception, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Private Method
        /// <summary>
        /// 载入岗位责任书
        /// </summary>
        private void loadPostBook()
        {
            string exception = "";
            string evaluatedID = Request.QueryString["id"];
            string name = Request.QueryString["name"];
            PostBook pb = new PostBook();
            if (PostBookManagementCtrl.GetPostBook(ref pb, evaluatedID, ref exception))
            {

                foreach (string[] content in pb.WorkContentRequest)
                {
                    if (content.Length != 4)
                    {
                        return;
                    }
                }
                string evaluatedName = Request.QueryString["name"];
                Panel1.Title = evaluatedName + "的" + Panel1.Title;
                Label_Comment.Text = pb.Comment;

                Radio_Employer.SelectedValue = pb.Employer;
                TextBox_LaborUnit.Text = pb.LaborUnit;
                TextBox_LaborDepart.Text = pb.LaborDepart;
                TextBox_PostName.Text = pb.PostName;
                Radio_PostType.SelectedValue = pb.PostType;
                TextArea_EduBg.Text = pb.EduBg;
                TextArea_Certificate.Text = pb.Certificate;
                TextArea_Experience.Text = pb.Experience;
                TextArea_Skill.Text = pb.Skill;
                TextArea_Personality.Text = pb.Personality;
                TextArea_PhyCond.Text = pb.PhyCond;
                TextArea_WorkOutline.Text = pb.WorkOutline;
                TextArea_Power.Text = pb.Power;
                TextArea_Response.Text = pb.Response;
                TextBox_DirectLeader.Text = pb.DirectLeader;
                TextBox_Subordinate.Text = pb.Subordinate;
                TextBox_Colleague.Text = pb.Colleague;
                TextBox_Services.Text = pb.Services;
                TextBox_Relations.Text = pb.Relations;
                TextArea_WorkEnter.Text = pb.WorkEnter;
                TextArea_PostAssess.Text = pb.PostAssess;
                TextArea_Others.Text = pb.Others;

                addWorkContentRequest(pb.WorkContentRequest);
            }
        }

        /// <summary>
        /// 想页面中增加工作内容与要求的simpleform
        /// </summary>
        /// <param name="workContentRequest"></param>
        private void addWorkContentRequest(List<string[]> workContentRequest)
        {
            for (int i = 0; i < workContentRequest.Count; i++)
            {
                SimpleForm sf = Panel6.Items[i] as SimpleForm;
                sf.Collapsed = false;
                TextArea title = sf.Items[0] as TextArea;
                TextArea content = sf.Items[1] as TextArea;
                TextArea request = sf.Items[2] as TextArea;
                TextArea point = sf.Items[3] as TextArea;
                title.Text = workContentRequest[i][0];
                content.Text = workContentRequest[i][1];
                request.Text = workContentRequest[i][2];
                point.Text = workContentRequest[i][3];
            }
        }

        /// <summary>
        /// 保存岗位责任书并将其状态设置成指定状态
        /// </summary>
        /// <param name="status">指定的状态</param>
        /// <returns></returns>
        private bool savePostBook(DocStatus status)
        {
            string exception = "";

            PostBook pb = new PostBook();
            pb.EvaluatedID = Request.QueryString["id"];
            pb.Employer = Radio_Employer.SelectedValue;
            pb.LaborUnit = TextBox_LaborUnit.Text;
            pb.LaborDepart = TextBox_LaborDepart.Text;
            pb.PostName = TextBox_PostName.Text;
            pb.PostType = Radio_PostType.SelectedValue;
            pb.EduBg = TextArea_EduBg.Text;
            pb.Certificate = TextArea_Certificate.Text;
            pb.Experience = TextArea_Experience.Text;
            pb.Skill = TextArea_Skill.Text;
            pb.Personality = TextArea_Personality.Text;
            pb.PhyCond = TextArea_PhyCond.Text;
            pb.WorkOutline = TextArea_WorkOutline.Text;
            pb.Power = TextArea_Power.Text;
            pb.Response = TextArea_Response.Text;
            pb.DirectLeader = TextBox_DirectLeader.Text;
            pb.Subordinate = TextBox_Subordinate.Text;
            pb.Colleague = TextBox_Colleague.Text;
            pb.Services = TextBox_Services.Text;
            pb.Relations = TextBox_Relations.Text;
            pb.WorkEnter = TextArea_WorkEnter.Text;
            pb.PostAssess = TextArea_PostAssess.Text;
            pb.Others = TextArea_Others.Text;

            pb.Comment = Label_Comment.Text;
            pb.Status = status;

            List<string[]> wcr = new List<string[]>();
            foreach (ControlBase item in Panel6.Items)
            {
                try
                {
                    SimpleForm sf = item as SimpleForm;
                    TextArea ta0 = sf.Items[0] as TextArea;
                    if (ta0.Text != "")
                    {
                        TextArea ta1 = sf.Items[1] as TextArea;
                        TextArea ta2 = sf.Items[2] as TextArea;
                        TextArea ta3 = sf.Items[3] as TextArea;
                        string[] content = new string[] { ta0.Text, ta1.Text, ta2.Text, ta3.Text };
                        wcr.Add(content);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            pb.WorkContentRequest = wcr;
            if (PostBookManagementCtrl.UpdatePostBook(pb, ref exception))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkNull()
        {
            if (TextBox_LaborUnit.Text != "" &&
                TextBox_LaborDepart.Text != "" &&
                TextBox_PostName.Text != "" &&
                TextArea_EduBg.Text != "" &&
                TextArea_Certificate.Text != "" &&
                TextArea_Experience.Text != "" &&
                TextArea_Skill.Text != "" &&
                TextArea_Personality.Text != "" &&
                TextArea_PhyCond.Text != "" &&
                TextArea_WorkOutline.Text != "" &&
                TextArea_Power.Text != "" &&
                TextArea_Response.Text != "" &&
                TextBox_DirectLeader.Text != "" &&
                TextBox_Subordinate.Text != "" &&
                TextBox_Colleague.Text != "" &&
                TextBox_Services.Text != "" &&
                TextBox_Relations.Text != "" &&
                TextArea_WorkEnter.Text != "" &&
                TextArea_PostAssess.Text != "" &&
                TextArea_Others.Text != "" && checkWCR())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkWCR()
        {
            foreach (ControlBase item in Panel6.Items)
            {
                try
                {
                    SimpleForm sf = item as SimpleForm;
                    TextArea ta0 = sf.Items[0] as TextArea;
                    if (ta0.Text != "")
                    {
                        TextArea ta1 = sf.Items[1] as TextArea;
                        TextArea ta2 = sf.Items[2] as TextArea;
                        TextArea ta3 = sf.Items[3] as TextArea;
                        if (ta1.Text == "" || ta2.Text == "" || ta3.Text == "")
                        {
                            return false;
                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return true;
        }

        private void setToolbarVisible()
        {
            AccessLevel accessLevel = AccessLevel.firstManager;
            try
            {
                accessLevel = (AccessLevel)Enum.Parse(typeof(AccessLevel), Session["AccessLevel"].ToString());
            }
            catch (Exception)
            {
                Alert.ShowInTop("系统错误，请重新登录！", MessageBoxIcon.Error);
                Session["UserID"] = "";
                Session["UserName"] = "";
                Session["AccessLevel"] = "";
                Session["Depart"] = "";
                Response.Redirect("../Login.aspx");
            }
            if (accessLevel == AccessLevel.firstManager)
            {
                Button_Save.Visible = false;
                Button_Submit.Visible = false;
                Button_Clear.Visible = false; 
                Button_Save_Shadow.Visible = false;
                Button_Submit_Shadow.Visible = false;
                Button_Clear_Shadow.Visible = false;
                ToolbarSeparator1.Visible = false;
                ToolbarSeparator2.Visible = false;
                ToolbarSeparator3.Visible = false;
                ToolbarSeparator6.Visible = false;
                ToolbarSeparator7.Visible = false;
                ToolbarSeparator8.Visible = false;
            }
            else if (accessLevel == AccessLevel.secondManager)
            {
                Button_Return.Visible = false;
                Button_Pass.Visible = false;
                Button_Return_Shadow.Visible = false;
                Button_Pass_Shadow.Visible = false;
                ToolbarSeparator4.Visible = false;
                ToolbarSeparator5.Visible = false;
                ToolbarSeparator9.Visible = false;
                ToolbarSeparator10.Visible = false;
            }
        }
        #endregion
    }
}