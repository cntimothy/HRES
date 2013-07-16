using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using FineUI;
using DataStructure;
using Controls;

namespace HRES.Pages.EvaluatorManagement
{
    public partial class iframe_MakeOrCheckEvaluator : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindEvaluatorToGrid();
            }
        }

        #region Event
        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
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
        #endregion
    }
}