using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controls;

namespace HRES.Pages.SecondManagement
{
    public partial class MakeSecond : System.Web.UI.Page
    {
        #region Public Method
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDepartListToDropDownList();
            }
        }

        public void FileSelected(object sender, EventArgs e)
        {
            if (ExcelFile.HasFile)
            {
                string fileName = ExcelFile.ShortFileName;
                fileName = Server.MapPath("../../upload/" + fileName);
                fileName = "";
            }
        }
        #endregion

        #region Private Method
        private void BindDepartListToDropDownList()
        { 
            List<string> departs = new List<string>();
            string exception = "";
            if (SecondManagementCtrl.GetDeparts(ref departs, ref exception))
            {
                departs.Insert(0, "所有部门");
                DepartDropDownList.DataSource = departs;
                DepartDropDownList.DataBind();
            }
        }
        #endregion
    }
}