<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakePostBook.aspx.cs" Inherits="HRES.Pages.PostBookManagement.MakePostBook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
        Title="Panel1">
        <Items>
            <x:Toolbar ID="Toolbar1" runat="server" CssStyle="width:100%">
                <Items>
                    <x:Button ID="Refresh" runat="server" Text="刷新" OnClick="Refresh_Click">
                    </x:Button>
                </Items>
            </x:Toolbar>
            <x:Panel ID="Panel2" runat="server" BodyPadding="5px" ShowBorder="false" ShowHeader="false"
                Title="" CssStyle="width:100%" Layout="HBox" BoxConfigChildMargin="0, 5, 0, 0">
                <Items>
                    <x:Grid ID="Grid1" runat="server" Title="被考评人名单" Width="700px" PageSize="20" ShowBorder="true"
                        ShowHeader="true" AutoHeight="true" AllowPaging="true" OnPageIndexChange="Grid1_PageIndexChange"
                        EnableRowNumber="True" DataKeyNames="ID, Date, Name, Sex, Department, Job, IDNo, Birthday, Telephone, Email, Fund, Character, Company, StartTime, StopTime, Comment, Status">
                        <Columns>
                            <x:BoundField Width="100px" DataField="ID" DataFormatString="{0}" HeaderText="用户名"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="Date" DataFormatString="{0}" HeaderText="入职时间"
                                Hidden="true" />
                            <x:BoundField Width="50px" DataField="Name" DataFormatString="{0}" HeaderText="姓名" />
                            <x:BoundField Width="40px" DataField="Sex" DataFormatString="{0}" HeaderText="性别" />
                            <x:BoundField Width="80px" DataField="Department" DataFormatString="{0}" HeaderText="工作单位" />
                            <x:BoundField Width="100px" DataField="Job" DataFormatString="{0}" HeaderText="岗位（职务）" />
                            <x:BoundField Width="100px" DataField="IDNo" DataFormatString="{0}" HeaderText="身份证号"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="Birthday" DataFormatString="{0}" HeaderText="出生年月"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="Telephone" DataFormatString="{0}" HeaderText="电话" />
                            <x:BoundField Width="100px" DataField="Email" DataFormatString="{0}" HeaderText="邮件"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="Fund" DataFormatString="{0}" HeaderText="经费来源"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="Character" DataFormatString="{0}" HeaderText="派遣性质"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="Company" DataFormatString="{0}" HeaderText="派遣公司"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="StartTime" DataFormatString="{0}" HeaderText="考评开始时间"
                                Hidden="true" />
                            <x:BoundField Width="100px" DataField="StopTime" DataFormatString="{0}" HeaderText="考评结束时间"
                                Hidden="true" />
                            <x:TemplateField Width="50px" HeaderText="状态">
                                <ItemTemplate>
                                    <asp:Label ID="Status" runat="server" Text='<%# GetDocStatus(Eval("Status")) %>'></asp:Label>
                                </ItemTemplate>
                            </x:TemplateField>
                            <x:BoundField Width="200px" DataField="Comment" DataFormatString="{0}" HeaderText="审核意见" />
                        </Columns>
                    </x:Grid>
                    <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="详细信息"
                        Width="300px">
                        <Items>
                            <x:Label runat="server" ID="LabID" Label="用户名" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabDate" Label="入职时间" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabName" Label="姓名" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabSex" Label="性别" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabDepart" Label="工作单位" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabJob" Label="岗位（职务）" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabIDNo" Label="身份证号" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabBirthday" Label="出生年月" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabTelephone" Label="电话" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabEmail" Label="邮件" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabFund" Label="经费来源" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabCharacter" Label="派遣性质" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabCompany" Label="派遣公司" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabStartTime" Label="考评开始时间" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabStopTime" Label="考评结束时间" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabStatus" Label="考评开始时间" Text="">
                            </x:Label>
                            <x:Label runat="server" ID="LabComment" Label="考评结束时间" Text="">
                            </x:Label>
                        </Items>
                    </x:SimpleForm>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    </form>
</body>
</html>
