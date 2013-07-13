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
            }

        }

        #region Event
        protected void Button_AddItem_Click(object sender, EventArgs e)
        {
        }

        protected void Button_RemoveItem_Click(object sender, EventArgs e)
        {
            
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

        private void addWorkContentRequest(List<string[]> workContentRequest)
        {
            for (int i = 0; i < workContentRequest.Count; i++)
            {
                Panel6.Items[i].Visible = true;
                SimpleForm sf = Panel6.Items[i+1] as SimpleForm;
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

        private TextArea[] genTextAreas(string[] content, int i)
        {
            TextArea[] tas = new TextArea[4];

            TextArea ta0 = new TextArea();
            ta0.ID = "TextArea_WorkContentRequest_Title" + Convert.ToString(i);
            ta0.Label = "标题";
            ta0.Text = content[0];
            ta0.CssStyle = "width:100%";
            ta0.AutoGrowHeight = true;


            TextArea ta1 = new TextArea();
            ta1.ID = "TextArea_WorkContentRequest_Content" + Convert.ToString(i);
            ta1.Label = "具体内容";
            ta1.Text = content[1];
            ta1.CssStyle = "width:100%";
            ta1.AutoGrowHeight = true;


            TextArea ta2 = new TextArea();
            ta2.ID = "TextArea_WorkContentRequest_Request" + Convert.ToString(i);
            ta2.Label = "具体要求";
            ta2.Text = content[2];
            ta2.CssStyle = "width:100%";
            ta2.AutoGrowHeight = true;


            TextArea ta3 = new TextArea();
            ta3.ID = "TextArea_WorkContentRequest_Point" + Convert.ToString(i);
            ta3.Label = "考核要点";
            ta3.Text = content[3];
            ta3.CssStyle = "width:100%";
            ta3.AutoGrowHeight = true;

            tas[0] = ta0;
            tas[1] = ta1;
            tas[2] = ta2;
            tas[3] = ta3;

            return tas;
        }
        #endregion
    }
}