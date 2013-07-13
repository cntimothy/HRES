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
                
            }
        }
        #endregion
    }
}