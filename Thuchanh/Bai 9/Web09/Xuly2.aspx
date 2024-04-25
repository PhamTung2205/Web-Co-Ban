<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly2.aspx.cs" Inherits="Web09.Xuly2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        
        .content{
            margin-top: 20px;
            border: #333 solid 1px;
            padding: 10px;
            width: 500px;
        }
        .fullname{
            display: flex;
        }
        #fname{
            width: 200px;
            margin: 10px;
        }
        .Name{
            display: flex;
        }
        #name{
            width: 200px;
            margin: 10px;
        }
        .datetime{
            display: flex;
        }
        #date{
            width: 200px;
            margin: 10px;
        }
        .gia{
            display: flex;
        }
        #gia{
            width: 200px;
            margin: 10px;
        }
        .button{
            display: flex;
            justify-content: flex-end;
        }
        .button>input{
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <div class="fullname">
                <p>Tên VXL :</p>
                <asp:TextBox runat="server" name="fname" id="fname" />
                
            </div>
            <div class="Name">
                <p>Hãng :</p>
                <asp:TextBox runat="server" name="name" id="name" />
                
            </div>
            <div class="datetime">
                <p>Ngày ra mắt : </p>
                <asp:TextBox runat="server" name="date" id="date" />
                
            </div>
            <div class="gia">
                <p>Giá</p>
                <asp:TextBox runat="server" name="Gia" ID="Gia" />
                
            </div>
            <div class="button">
                <input  type="submit" name="them" id="them" value="Thêm">
                <input type="reset" name="huy" id="huy">

            </div>
        </div>
    </form>
</body>
</html>
