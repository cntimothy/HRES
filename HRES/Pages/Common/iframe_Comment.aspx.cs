using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using Controls;

namespace HRES.Pages.Common
{
    public partial class iframe_Comment : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button_Cancel.OnClientClick = ActiveWindow.GetConfirmHideReference();
        }

        protected void Button_Return_Click(object sender, EventArgs e)
        {
            string exception = "";
            if (TextArea_Comment.Text == "")
            {
                Alert.Show("请输入审核意见！");
            }
            if (PostBookManagementCtrl.SetReturned(Request.QueryString["id"], ref exception) &&
                PostBookManagementCtrl.UpdateComment(TextArea_Comment.Text, Request.QueryString["id"], ref exception))
            {
                Alert.ShowInTop("设置成功！", MessageBoxIcon.Information);
            }
        }
    }
}