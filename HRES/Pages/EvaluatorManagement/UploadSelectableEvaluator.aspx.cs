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

namespace HRES.Pages.EvaluatorManagement
{
    public partial class UploadSelectableEvaluator : PageBase
    {
        #region Protected Method
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEvaluatorToGrid();
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
            string depart = Session["Depart"].ToString();
            if (EvaluatorManagementCtrl.UploadSelectable(fileName, depart, ref exception))
            {
                ExcelFile.Reset();
                Alert.ShowInTop("上传成功！", MessageBoxIcon.Information);
                BindEvaluatorToGrid();
            }
            else
            {
                ExcelFile.Reset();
                Alert.ShowInTop("上传失败！\n失败原因：" + exception, MessageBoxIcon.Error);
            }
        }

        protected void DeleteAll_Click(object sender, EventArgs e)
        {
            string exception = "";
            if (EvaluatorManagementCtrl.DeleteAll(ref exception))
            {
                Alert.ShowInTop("删除成功！", MessageBoxIcon.Information);
            }
            else
            {
                Alert.ShowInTop("删除失败\n失败原因：" + exception, MessageBoxIcon.Error);
            }
        }

        protected void Grid1_PageIndexChange(object sender, FineUI.GridPageEventArgs e)
        {
            Grid1.PageIndex = e.NewPageIndex;
        }

        protected void Grid1_RowCommand(object sender, FineUI.GridCommandEventArgs e)
        {
            string exception = "";
            if (e.CommandName == "Delete")
            {
                object[] keys = Grid1.DataKeys[e.RowIndex];
                List<string> IDs = new List<string>();
                IDs.Add((string)keys[0]);
                if (EvaluatorManagementCtrl.Delete(IDs, ref exception))
                {
                    Alert.ShowInTop("删除成功！", MessageBoxIcon.Information);
                }
                else
                {
                    Alert.ShowInTop("删除失败！\n原因：" + exception, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Private Method

        private void BindEvaluatorToGrid()
        {
            string exception = "";
            string depart = Session["Depart"].ToString();
            DataTable table = new DataTable();
            if (EvaluatorManagementCtrl.GetSelectableEvaluatorByDepart(ref table, depart, ref exception))
            {
                Grid1.DataSource = table;
                Grid1.DataBind();
            }
        }
        #endregion
    }
}