<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="Bai10.Bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div{
            margin:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <textarea id="txtNoidung" cols="20" rows="5" runat="server"></textarea>
        </div>
        <div>
            <asp:FileUpload ID="txtFile" runat="server" />
        </div>
        <div>
            <input id="Submit" type="submit" value="Gửi dữ liệu" runat="server" />
        </div>
    </form>
</body>
</html>
