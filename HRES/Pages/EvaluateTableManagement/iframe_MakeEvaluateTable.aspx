<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="iframe_MakeEvaluateTable.aspx.cs"
    Inherits="HRES.Pages.EvaluateTableManagement.iframe_MakeEvaluateTable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" AutoSizePanelID="Panel1" />
    <x:Panel ID="Panel1" runat="server" BodyPadding="0px" ShowBorder="true" ShowHeader="true"
        Title="考核表" Layout="Fit" AutoScroll="true">
        <Items>
            <x:Panel ID="Panel2" runat="server" BodyPadding="0px" ShowBorder="false" ShowHeader="false"
                Title="Panel2" AutoScroll="true" AutoHeight="true">
                <Items>
                    <x:Toolbar ID="Toolbar1" runat="server" CssStyle="width:99.7%">
                        <Items>
                            <x:Button ID="关闭" runat="server" Text="Button">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator1" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="保存" runat="server" Text="Button">
                            </x:Button>
                            <x:ToolbarSeparator ID="ToolbarSeparator2" runat="server">
                            </x:ToolbarSeparator>
                            <x:Button ID="提交" runat="server" Text="Button">
                            </x:Button>
                            <x:ToolbarFill ID="ToolbarFill1" runat="server">
                            </x:ToolbarFill>
                            <x:Label ID="Label1" runat="server" Label="Label" Text="审核意见">
                            </x:Label>
                            <x:Label ID="Label2" runat="server" Label="Label" Text="">
                            </x:Label>
                        </Items>
                    </x:Toolbar>
                    <x:Panel ID="Panel3" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="关键岗位职责指标" EnableCollapse="true">
                        <Items>
                            <x:SimpleForm ID="SimpleForm1" runat="server" BodyPadding="5px" Title="1)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyResponse_1" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyResponse_1" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm2" runat="server" BodyPadding="5px" Title="2)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyResponse_2" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyResponse_2" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm3" runat="server" BodyPadding="5px" Title="3)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyResponse_3" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyResponse_3" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm4" runat="server" BodyPadding="5px" Title="4)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyResponse_4" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyResponse_4" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm5" runat="server" BodyPadding="5px" Title="5)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyResponse_5" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyResponse_5" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel4" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="关键岗位胜任能力指标" EnableCollapse="true">
                        <Items>
                            <x:SimpleForm ID="SimpleForm6" runat="server" BodyPadding="5px" Title="1)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyQualify_1" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyQualify_1" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyQualify_1" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm7" runat="server" BodyPadding="5px" Title="2)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyQualify_2" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyQualify_2" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyQualify_2" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm8" runat="server" BodyPadding="5px" Title="3)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyQualify_3" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyQualify_3" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyQualify_3" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm9" runat="server" BodyPadding="5px" Title="4)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyQualify_4" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyQualify_4" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyQualify_4" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm10" runat="server" BodyPadding="5px" Title="5)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyQualify_5" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyQualify_5" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyQualify_5" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel5" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="关键工作态度指标" EnableCollapse="true">
                        <Items>
                            <x:SimpleForm ID="SimpleForm11" runat="server" BodyPadding="5px" Title="1)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyAttitude_1" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyAttitude_1" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyAttitude_1" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm12" runat="server" BodyPadding="5px" Title="2)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyAttitude_2" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyAttitude_2" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyAttitude_2" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm13" runat="server" BodyPadding="5px" Title="3)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyAttitude_3" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyAttitude_3" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyAttitude_3" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm14" runat="server" BodyPadding="5px" Title="4)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyAttitude_4" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyAttitude_4" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyAttitude_4" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm15" runat="server" BodyPadding="5px" Title="5)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_KeyAttitude_5" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_KeyAttitude_5" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_KeyAttitude_5" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel6" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="岗位职责指标" EnableCollapse="true">
                        <Items>
                            <x:SimpleForm ID="SimpleForm16" runat="server" BodyPadding="5px" Title="1)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Response_1" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Response_1" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm17" runat="server" BodyPadding="5px" Title="2)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Response_2" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Response_2" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm18" runat="server" BodyPadding="5px" Title="3)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Response_3" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Response_3" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm19" runat="server" BodyPadding="5px" Title="4)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Response_4" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Response_4" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm20" runat="server" BodyPadding="5px" Title="5)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Response_5" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Response_5" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                </Items>
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel7" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="岗位胜任能力指标" EnableCollapse="true">
                        <Items>
                            <x:SimpleForm ID="SimpleForm21" runat="server" BodyPadding="5px" Title="1)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Qualify_1" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Qualify_1" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Qualify_1" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm22" runat="server" BodyPadding="5px" Title="2)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Qualify_2" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Qualify_2" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Qualify_2" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm23" runat="server" BodyPadding="5px" Title="3)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Qualify_3" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Qualify_3" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Qualify_3" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm24" runat="server" BodyPadding="5px" Title="4)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Qualify_4" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Qualify_4" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Qualify_4" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm25" runat="server" BodyPadding="5px" Title="5)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Qualify_5" runat="server" Label="标题" TriggerIcon="Search"
                                        EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Qualify_5" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Qualify_5" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                    <x:Panel ID="Panel8" runat="server" BodyPadding="5px" ShowBorder="true" ShowHeader="true"
                        Title="工作态度指标" EnableCollapse="true">
                        <Items>
                            <x:SimpleForm ID="SimpleForm26" runat="server" BodyPadding="5px" Title="1)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Attitude_1" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Attitude_1" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Attitude_1" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm27" runat="server" BodyPadding="5px" Title="2)" Collapsed="false"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Attitude_2" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Attitude_2" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Attitude_2" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm28" runat="server" BodyPadding="5px" Title="3)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Attitude_3" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Attitude_3" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Attitude_3" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm29" runat="server" BodyPadding="5px" Title="4)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Attitude_4" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Attitude_4" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Attitude_4" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                            <x:SimpleForm ID="SimpleForm30" runat="server" BodyPadding="5px" Title="5)" Collapsed="true"
                                EnableCollapse="true">
                                <Items>
                                    <x:TriggerBox ID="TriggerBox_Attitude_5" runat="server" Label="标题" TriggerIcon="Search" EnableEdit="true">
                                    </x:TriggerBox>
                                    <x:TextArea ID="TextArea_Attitude_5" runat="server" Height="50px" Label="内容" Text="">
                                    </x:TextArea>
                                    <x:HiddenField ID="HiddenField_Attitude_5" runat="server">
                                    </x:HiddenField>
                                </Items>
                            </x:SimpleForm>
                        </Items>
                    </x:Panel>
                </Items>
            </x:Panel>
        </Items>
    </x:Panel>
    <x:Window ID="Window_ShowQuota" Title="选择指标" Popup="false" EnableIFrame="true" runat="server"
        IFrameUrl="about:blank" EnableMaximize="true" EnableResize="true" Target="Self"
        OnClose="Window_ShowQuota_Close" IsModal="True" Width="650px" Height="450px">
    </x:Window>
    </form>
</body>
</html>
