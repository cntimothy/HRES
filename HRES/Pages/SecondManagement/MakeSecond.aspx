<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MakeSecond.aspx.cs" Inherits="HRES.Pages.SecondManagement.MakeSecond" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .photo
        {
            height: 150px;
            line-height: 150px;
            text-align: right;
        }
        .photo img
        {
            width: 200px;
            vertical-align: middle;
        }
        
        
        
        .mytoolbar td
        {
            vertical-align: top;
        }
        .mytoolbar .x-form-field-wrap
        {
            /* Only fileupload in toolbar */
            height:23px;
            width:50px;
        }
        .mytoolbar .x-form-field
        {
            /* fix for IE */
            float: left;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <x:PageManager ID="PageManager1" runat="server" />
    <Toolbars>
        <x:Toolbar ID="Toolbar1" Position="Top" CssClass="mytoolbar" runat="server">
            <Items>
                <x:FileUpload runat="server" ID="ExcelFile" ButtonText="选择Excel文件" ButtonOnly="true"
                        AutoPostBack="true" OnFileSelected="FileSelected">
                    </x:FileUpload>
                <x:Label ID="FilePath" runat="server"></x:Label> 
                <x:ToolbarSeparator ID="Seperator1" runat="server"></x:ToolbarSeparator>
                <x:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="上传"></x:Button>
            </Items>
        </x:Toolbar>
    </Toolbars>    
                <x:DropDownList runat="server" ID="DepartDropDownList">
                    </x:DropDownList>
    </form>
</body>
</html>
