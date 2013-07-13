<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_MakePostBook.aspx.cs"
    Inherits="HRES.Pages.PostBookManagement.iframe_MakePostBook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" AutoSizePanelID="Panel1" runat="server" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="true"
        Layout="Fit" Title="岗位责任书" AutoScroll="true">
        <Items>
            <x:Panel ID="Panel2" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
                Title="Panel" AutoScroll="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server" Position="top" CssStyle="width:100%">
                        <Items>
                            <x:Button ID="Button_Close" runat="server" Text="关闭">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator5" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Save" runat="server" Text="保存">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Submit" runat="server" Text="提交">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Clear" runat="server" Text="清空">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator3" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Pass" runat="server" Text="通过">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator4" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button_Return" runat="server" Text="退回">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                    <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="一、岗位概述" ShowBorder="false"
                        CssStyle="width:100%">
                        <Items>
                            <x:RadioButtonList ID="Radio_Employer" runat="server" ColumnNumber="1" Label="1.用人单位"
                                Required="true" ColumnVertical="true">
                                <x:RadioItem Text="上海市东凌国际人才有限公司" Value="0" Selected="true" />
                                <x:RadioItem Text="上海黄渡同济人力资源有限公司" Value="1" />
                            </x:RadioButtonList>
                            <x:TextBox ID="TextBox_LaborUnit" runat="server" Label="2.用工单位" Text="" Required="true"
                                Width="300px">
                            </x:TextBox>
                            <x:TextBox ID="TextBox_LaborDepart" runat="server" Label="3.用工部门" Text="" Required="true"
                                Width="300px">
                            </x:TextBox>
                            <x:TextBox ID="TextBox_PostName" runat="server" Label="4.岗位名称" Text="" Required="true"
                                Width="300px">
                            </x:TextBox>
                            <x:RadioButtonList ID="Radio_PostType" runat="server" ColumnVertical="false" Label="5.岗位类别"
                                Required="true" Width="300px">
                                <x:RadioItem Text="管理" Value="0" Selected="true" />
                                <x:RadioItem Text="教辅" Value="1" />
                                <x:RadioItem Text="思政" Value="2" />
                                <x:RadioItem Text="教师" Value="3" />
                            </x:RadioButtonList>
                        </Items>
                    </x:SimpleForm>
                    <x:Panel ID="Panel3" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="true"
                        CssStyle="width:100%" Title="二、岗位职责" BoxConfigChildMargin="5">
                        <Items>
                            <x:SimpleForm ID="SimpleForm2" runat="server" BodyPadding="5px" Title="（一）任职条件" CssStyle="width:100%"
                                ShowBorder="true">
                                <Items>
                                    <x:TextArea ID="TextBox_EduBg" runat="server" Label="1.学历背景" Text="" Required="true"
                                        CssStyle="width:100%">
                                    </x:TextArea>
                                    <x:TextArea ID="TextBox_Certificate" runat="server" Label="2.培训及资历" Text="" Required="true"
                                        CssStyle="width:100%">
                                    </x:TextArea>
                                    <x:TextArea ID="TextBox_Experience" runat="server" Label="3.工作经验" Text="" Required="true"
                                        CssStyle="width:100%">
                                    </x:TextArea>
                                    <x:TextArea ID="TextBox_Skill" runat="server" Label="4.基本技能和素质" Text="" Required="true"
                                        CssStyle="width:100%">
                                    </x:TextArea>
                                    <x:TextArea ID="TextBox_Personality" runat="server" Label="5.个性特征" Text="" Required="true"
                                        CssStyle="width:100%">
                                    </x:TextArea>
                                    <x:TextArea ID="TextBox_PhyCond" runat="server" Label="6.体质条件" Text="" Required="true"
                                        CssStyle="width:100%">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:Panel ID="Panel4" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                Title="（二）工作内容、工作要求">
                                <Items>
                                    <x:Panel ID="Panel5" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                        CssStyle="width:100%" Title="1.岗位概述">
                                        <Items>
                                            <x:TextArea ID="TextArea_WorkOutline" runat="server" Label="" Text="" Required="true"
                                                CssStyle="width:97%">
                                            </x:TextArea>
                                        </Items>
                                    </x:Panel>
                                    <x:Panel ID="Panel6" runat="server" BodyPadding="0px" ShowBorder="true" ShowHeader="true"
                                        CssStyle="width:100%" Title="2.工作内容及工作要求">
                                        <Items>
                                            <x:Toolbar ID="Toolbar2" runat="server">
                                                <Items>
                                                    <x:Button ID="Button_AddItem" runat="server" Text="新增">
                                                    </x:Button>
                                                    <x:Button ID="Button_DeleteItem" runat="server" Text="删除">
                                                    </x:Button>
                                                </Items>
                                            </x:Toolbar>
                                        </Items>
                                    </x:Panel>
                                </Items>
                            </x:Panel>
                            <x:Panel ID="Panel7" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                Title="（三）权责范围">
                                <Items>
                                    <x:Panel ID="Panel8" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                        CssStyle="width:100%" Title="1.权利">
                                        <Items>
                                            <x:TextArea ID="TextArea_Power" runat="server" Label="" Text="" Required="true" CssStyle="width:97%">
                                            </x:TextArea>
                                        </Items>
                                    </x:Panel>
                                    <x:Panel ID="Panel9" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                        CssStyle="width:100%" Title="2.责任">
                                        <Items>
                                            <x:TextArea ID="TextArea_Response" runat="server" Label="" Text="" Required="true"
                                                CssStyle="width:97%">
                                            </x:TextArea>
                                        </Items>
                                    </x:Panel>
                                </Items>
                            </x:Panel>
                            <x:SimpleForm ID="SimpleForm3" runat="server" BodyPadding="5px" Title="（四）工作关系">
                                <Items>
                                    <x:TextBox ID="TextBox_DirectLeader" runat="server" Label="1.直接领导" Text="">
                                    </x:TextBox>
                                    <x:TextBox ID="TextBox_Subordinate" runat="server" Label="2.下属" Text="">
                                    </x:TextBox>
                                    <x:TextBox ID="TextBox_Colleague" runat="server" Label="3.同事" Text="">
                                    </x:TextBox>
                                    <x:TextBox ID="TextBox_Service" runat="server" Label="4.服务对象" Text="">
                                    </x:TextBox>
                                    <x:TextBox ID="TextBox_Relations" runat="server" Label="5.外部关系" Text="">
                                    </x:TextBox>
                                </Items>
                            </x:SimpleForm>
                            <x:Panel ID="Panel10" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                                Title="（五）工作环境">
                                <Items>
                                    <x:TextArea ID="TextArea_WorkEnter" runat="server" Height="50px" Label="Label" Text=""
                                        CssStyle="width:97%">
                                    </x:TextArea>
                                </Items>
                            </x:Panel>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel11" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="true"
                        Title="三、岗位考核">
                        <Items>
                            <x:TextArea ID="TextArea_PostAssess" runat="server" Height="50px" Label="Label" Text=""
                                CssStyle="width:97%" AutoGrowHeight="true">
                            </x:TextArea>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel12" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="true"
                        Title="四、其他约定">
                        <Items>
                            <x:TextArea ID="TextArea_Others" runat="server" Height="50px" Label="Label" Text=""
                                CssStyle="width:97%" AutoGrowHeight="true">
                            </x:TextArea>
                        </Items>
                    </x:Panel>
                    <x:Toolbar ID="Toolbar3" runat="server" Position="top" CssStyle="width:100%">
                        <Items>
                            <x:Button ID="Button1" runat="server" Text="关闭">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator6" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button2" runat="server" Text="保存">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator7" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button3" runat="server" Text="提交">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator8" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button4" runat="server" Text="清空">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator9" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button5" runat="server" Text="通过">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator10" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="Button6" runat="server" Text="退回">
                            </x:Button>
                        </Items>
                    </x:Toolbar>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
