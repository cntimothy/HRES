using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controls;
using DataStructure;
using FineUI;
using System.Data;

namespace HRES.Pages.SecondManagement
{
    public partial class MakeSecond : PageBase
    {
        #region Public Method
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDepartListToDropDownList();
                BindSecondToGrid();
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
                ExcelFile.Reset();
                Alert.ShowInTop("上传成功！", MessageBoxIcon.Information);
                BindSecondToGrid();
            }
            else
            {
                ExcelFile.Reset();
                Alert.ShowInTop("上传失败！\n失败原因：" + exception, MessageBoxIcon.Error);
            }
        }

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
        }

        protected void DepartChange(object sender, EventArgs e)
        {
            BindSecondToGrid();
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
            if (e.CommandName == "Reset")
            {
                object[] keys = Grid1.DataKeys[e.RowIndex];
                if (SecondManagementCtrl.ResetPassword((string)keys[0], ref exception))
                {
                    Alert.ShowInTop("重置成功！", MessageBoxIcon.Information);
                }
                else
                {
                    Alert.ShowInTop("重置失败！\n原因：" + exception, MessageBoxIcon.Error);
                }
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

        private void BindSecondToGrid()
        {
            string exception = "";
            DataTable table = new DataTable();
            if (DepartDropDownList.SelectedValue == "所有部门")
            {
                if (SecondManagementCtrl.GetAll(ref table, ref exception))
                {
                    Grid1.DataSource = table;
                    Grid1.DataBind();
                }
            }
            else
            {
                string depart = DepartDropDownList.SelectedValue;
                if (SecondManagementCtrl.GetAllByDepart(ref table, depart, ref exception))
                {
                    Grid1.DataSource = table;
                    Grid1.DataBind();
                }
            }
        }
        #endregion
    }
}