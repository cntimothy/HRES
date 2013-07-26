using System;
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
            }
        }
        #endregion

        #region Event
        protected void Window_ShowQuota_Close(object sender, WindowCloseEventArgs e)
        { 
            
        }
        #endregion

        #region Private Method
        #endregion
    }
}