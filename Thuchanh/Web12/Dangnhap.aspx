<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="Web12.Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <style>
        form{
            border:solid black 1px;
            width:300px;
            margin:auto;
        }
        div{
            display:flex;
            margin:5px;
        }
        input[type="text"]{
            width : 150px;
            height: 20px;
            margin:10px;
        }
        input[type="submit"]{
            margin-left : 100px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <p>Nhập Tên:</p>
            <input type="text" id="txtNickName" name="txtNickName" placeholder="Nhập tên" value="" />
        </div>
        <div>
            <p>Nhập mầu:</p>
            <input type="text" id="txtColor" name="txtColor" placeholder="Nhập mầu"   />
        </div>
        <div>
            <input type="submit" id="txtDangnhap" name="txtDangnhap" value="Đăng nhập" />
        </div>
    </form>
    
</body>
</html>
