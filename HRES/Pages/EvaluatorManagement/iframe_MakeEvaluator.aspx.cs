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
    public partial class iframe_MakeEvaluator : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Button_Close.OnClientClick = ActiveWindow.GetConfirmHidePostBackReference();
                bindEvaluatorToGrid();
                SetSubmitted();
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
        #endregion
    }
}