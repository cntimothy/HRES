<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_CheckEvaluateTable.aspx.cs"
    Inherits="HRES.Pages.EvaluateTableManagement.iframe_CheckEvaluateTable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel" Layout="Fit">
        <Items>
            <x:Panel ID="Panel2" runat="server" BodyPadding="0px" ShowBorder="true" ShowHeader="true"
                Title="考评表" AutoScroll="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server">
                        <Items>
                            <x:Button ID="Button_Close" runat="server" Text="关闭">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Pass" runat="server" Text="通过">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Reject" runat="server" Text="退回">
                            </x:Button>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Label ID="Label1" runat="server" Label="Label" Text="审核意见：">
                            </x:Label>
                            <x:Label ID="Label_Comment" runat="server" Label="Label" Text="Label">
                            </x:Label>
                        </Items>
                    </x:Toolbar>
                    <x:Form ID="Form2" runat="server" BodyPadding="5px" Title="Form" ShowBorder="false" ShowHeader="false">
                        <Rows>
                            <x:FormRow ID="FormRow1" runat="server">
                                <Items>
                                    <x:Label ID="Label_EvaluatedName" runat="server" Label="被考核人姓名" Text="Label">
                                    </x:Label>
                                    <x:Label ID="Label_PostName" runat="server" Label="岗位名称" Text="Label">
                                    </x:Label>
                                    <x:Label ID="Label_LaborDep" runat="server" Label="用工部门" Text="Label">
                                    </x:Label>
                                    <x:Label ID="Label_LaborUnit" runat="server" Label="用工单位" Text="Label">
                                    </x:Label>
                                </Items>
                            </x:FormRow>
                            <x:FormRow ID="FormRow2" runat="server">
                            <Items>
                                <x:Label ID="Label_Period" runat="server" Label="考评时间段" Text="Label">
                                </x:Label>
                            </Items>
                            </x:FormRow>
                        </Rows>
                    </x:Form>
                    <x:Grid ID="Grid1" runat="server" Title="Grid">
                        <Columns>
                        </Columns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
