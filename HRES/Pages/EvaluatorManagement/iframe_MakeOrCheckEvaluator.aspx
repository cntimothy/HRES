<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_MakeOrCheckEvaluator.aspx.cs"
    Inherits="HRES.Pages.EvaluatorManagement.iframe_MakeOrCheckEvaluator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="true" ShowHeader="true"
        Title="考评人名单" Layout="Fit" AutoScroll="true">
        <Items>
            <x:Panel ID="Panel2" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
                Title="Panel2" AutoScroll="true" AutoHeight="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server" CssStyle="width:99.7%">
                        <Items>
                            <x:Button ID="Button1" runat="server" Text="关闭">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button2" runat="server" Text="提交">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button3" runat="server" Text="通过">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator3" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button4" runat="server" Text="退回">
                            </x:Button>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Label ID="Label1" runat="server" Label="Label" Text="审核意见：">
                            </x:Label>
                            <x:Label ID="Label2" runat="server" Label="Label" Text="Label">
                            </x:Label>
                        </Items>
                    </x:Toolbar>
                    <x:Grid ID="Grid1" runat="server" Title="Grid" ShowHeader="false" AllowPaging="true"
                        PageSize="200" AutoHeight="true" OnPageIndexChange="Grid1_PageIndexChange" EnableRowNumber="True"
                        AutoPostBack="true" DataKeyNames="ID, Name, Sex, Company, Telephone, Relation"
                        EnableMultiSelect="true" ClearSelectedRowsAfterPaging="false" EnableCheckBoxSelect="true"
                        CheckBoxSelectOnly="true">
                        <Columns>
                            <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="用户名" />
                            <x:BoundField Width="100px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                            <x:BoundField Width="100px" DataField="Sex" DataFormatString="{0}" HeaderText="性别" />
                            <x:BoundField Width="100px" DataField="Company" DataFormatString="{0}" HeaderText="工作单位" />
                            <x:BoundField Width="100px" DataField="Telephone" DataFormatString="{0}" HeaderText="联系电话" />
                            <x:BoundField Width="100px" DataField="Relation" DataFormatString="{0}" HeaderText="关系" />
                        </Columns>
                    </x:Grid>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
