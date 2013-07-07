using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controls;
using DataStructure;

namespace HRES
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void IBLogin_Click(object sender, ImageClickEventArgs e)
        {
            string exception = "";
            UserInfo userInfo = new UserInfo();
            string ID = UserName.Text; ;
            string passWord = Password.Text;
            LoginType loginType = (LoginType)Convert.ToInt32(LoginType.SelectedValue);
            if (LoginManagementCtrl.LoginIn(ref userInfo, ID, passWord, loginType, ref exception))
            {
                Session["UserID"] = userInfo.Id;
                Session["UserName"] = userInfo.Name;
                Session["AccessLevel"] = userInfo.AccessLevel;
                Session["Depart"] = userInfo.Depart;
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //登录错误
            }
        }
    }
}