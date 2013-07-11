using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using Controls;
using DataStructure;
using System.Data;
using System.Net;

namespace HRES.Pages.PostBookManagement
{
    public partial class MakePostBook : PageBase
    {
        #region Page Init
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEvaluatedToGrid();
            }

        }
        #endregion

        #region Event
        protected void Refresh_Click(object sender, EventArgs e)
        {
            BindEvaluatedToGrid();
        }

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
        }

        protected void Grid1_RowClick(object sender, FineUI.GridRowClickEventArgs e)
        {
            object[] keys = Grid1.DataKeys[e.RowIndex];
            Session["EvaluatedID"] = keys[0];            
            SetSimpleForm(keys);
        }

        protected void Window_MakePostBook_Close(object sender, FineUI.WindowCloseEventArgs e)
        {
            BindEvaluatedToGrid();
        }

        #endregion

        #region Private Method

        private void BindEvaluatedToGrid()
        {
            string exception = "";
            string depart = (string)Session["Depart"];
            DataTable table = new DataTable();
            if(PostBookManagementCtrl.GetAllByDepart(ref table, depart, ref exception))
            {
                string sortField = "Status";
                string sortDirection = "ASC";
                DataView dv = table.DefaultView;
                dv.Sort = String.Format("{0} {1}", sortField, sortDirection);
                Grid1.DataSource = dv;
                Grid1.DataBind();
            }
        }

        private void SetSimpleForm(object[] keys)
        {
            LabID.Text = (string)keys[0];
            LabDate.Text = (string)keys[1];
            LabName.Text = (string)keys[2];
            LabSex.Text = (string)keys[3];
            LabDepart.Text = (string)keys[4];
            LabJob.Text = (string)keys[5];
            LabIDNo.Text = (string)keys[6];
            LabBirthday.Text = (string)keys[7];
            LabTelephone.Text = (string)keys[8];
            LabEmail.Text = (string)keys[9];
            LabFund.Text = (string)keys[10];
            LabCharacter.Text = (string)keys[11];
            LabCompany.Text = (string)keys[12];
            LabStartTime.Text = (string)keys[13];
            LabStopTime.Text = (string)keys[14];
            LabStatus.Text = GetDocStatus(keys[15]);
            LabComment.Text = (string)keys[16];
        }
        #endregion
    }
}