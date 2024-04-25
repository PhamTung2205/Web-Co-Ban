<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="Web12.Members" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Members</title>
    <style>
        .Text{
            margin-bottom:10px;
            text-align:center;
        }
        .Nickname{
            margin-bottom: 10px;
            padding:10px;
            list-style:none;
            font-size:18px;
        }
    </style>
    <script>
        function loadPage() {
            location.reload();
        }
        function startReload() {
            setInterval(loadPage, 5000);
        }
        window.onload = startReload;
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="Text">Members</h1>
            <ul>
                <% for (int i = 0; i < ((List<Web12.Member>)HttpContext.Current.Application["ListMember"]).Count; i++) {

                        string name = ((List<Web12.Member>)HttpContext.Current.Application["ListMember"])[i].Nickname;
                        string color = ((List<Web12.Member>)HttpContext.Current.Application["ListMember"])[i].Color;%>
                
                     <li class="Nickname" style="background-color:<% =color %>"><% =name %></li>
                    
              <% } %>
                 
            </ul>
            
        </div>
    </form>
</body>
</html>
