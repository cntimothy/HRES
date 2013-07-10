using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using DataStructure;
using Controls;
using System.Data;

namespace HRES.Pages.EvaluatedManagement
{
    public partial class MakeEvaluated : System.Web.UI.Page
    {        
        #region Protected Method
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDepartListToDropDownList();
                BindEvaluatedToGrid();
            }
        }

        protected void FileSelected(object sender, EventArgs e)
        {
            if (ExcelFile.HasFile)
            {
                string fileName = ExcelFile.ShortFileName;
                if (fileName.EndsWith(".xls"))
                {
                    FilePath.Text = fileName;
                    fileName = Server.MapPath("../../upload/" + fileName);
                    ExcelFile.SaveAs(fileName);
                    Submit.Enabled = true;
                }
                else
                {
                    FilePath.Text = "不正确";
                    Submit.Enabled = false;
                    return;
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string exception = "";
            string fileName = Server.MapPath("../../upload/" + FilePath.Text);
            if (EvaluatedManagementCtrl.AddNewByExl(fileName, ref exception))
            {
                Alert.ShowInTop("上传成功！", MessageBoxIcon.Information);
                BindEvaluatedToGrid();
            }
            else
            {
                Alert.ShowInTop("上传失败！\n失败原因：" + exception, MessageBoxIcon.Error);
            }
        }

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
        }

        protected void DepartChange(object sender, EventArgs e)
        {
            BindEvaluatedToGrid();
        }

        protected void Grid1_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            string exception = "";
            if (e.CommandName == "Delete")
            {
                object[] keys = Grid1.DataKeys[e.RowIndex];
                if (SecondManagementCtrl.Delete((string)keys[0], ref exception))
                {
                    Alert.ShowInTop("删除成功！", MessageBoxIcon.Information);
                }
                else
                {
                    Alert.ShowInTop("删除失败！\n原因：" + exception, MessageBoxIcon.Error);
                }
            }
        }

        protected void GridRowSelect(object sender, FineUI.GridRowSelectEventArgs e)
        {
            object[] keys = Grid1.DataKeys[e.RowIndex];
            SetDetail(keys);
        }

        #endregion

        #region Private Method
        private void BindDepartListToDropDownList()
        {
            List<string> departs = new List<string>();
            string exception = "";
            if (EvaluatedManagementCtrl.GetDeparts(ref departs, ref exception))
            {
                departs.Insert(0, "所有部门");
                DepartDropDownList.DataSource = departs;
                DepartDropDownList.DataBind();
            }
        }

        private void BindEvaluatedToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (DepartDropDownList.SelectedValue == "所有部门")
            {
                if (EvaluatedManagementCtrl.GetAll(ref table, ref exception))
                {
                    Grid1.DataSource = table;
                    Grid1.DataBind();
                }
            }
            else
            {
                string depart = DepartDropDownList.SelectedValue;
                if (EvaluatedManagementCtrl.GetAllByDepart(ref table, depart, ref exception))
                {
                    Grid1.DataSource = table;
                    Grid1.DataBind();
                }
            }
        }

        private void SetDetail(object[] keys)
        {
            labID.Text = (string)keys[0];
            labDate.Text = (string)keys[1];
            labName.Text = (string)keys[2];
            labSex.Text = (string)keys[3];
            labDepart.Text = (string)keys[4];
            labJob.Text = (string)keys[5];
            labIDNo.Text = (string)keys[6];
            labBirthday.Text = (string)keys[7];
            labTelephone.Text = (string)keys[8];
            labEmail.Text = (string)keys[9];
            LabFund.Text = (string)keys[10];
            LabCharacter.Text = (string)keys[11];
            LabCompany.Text = (string)keys[12];
            LabStartTime.Text = (string)keys[13];
            LabStopTime.Text = (string)keys[14];
        }
        #endregion
    }
}