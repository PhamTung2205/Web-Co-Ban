<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageList.aspx.cs" Inherits="Web12.MessageList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        *{
            margin:0;
            padding:0;
        }
        body{
            background-color:white;
            position:relative;
        }
        .name{
            font-weight:bold;
            margin-bottom:5px;
            width:fit-content;
        }
        .container{
            margin-bottom:20px;
            padding:10px;
        }
        .content{
            border-radius:10px;
            width:fit-content;
            max-width:40%;
            height:fit-content;
            padding:10px;
            margin-bottom:5px;
        }
        

        .time{
            font-size:12px;
            color:grey;
            text-align:right;
            width:fit-content;
        }
        
    </style>
    <script>
        function loadPage() {
            location.reload();
        }
        function startReload() {
            setInterval(loadPage, 2000);
        }
        window.onload = startReload;
    </script>
</head>
<body>
  <%  
      for (int i = 0; i < ((List<Web12.Message>)Application["ListMessage"]).Count; i++)
      {
          Web12.Message mass = ((List<Web12.Message>)Application["ListMessage"])[i];
          string name = mass.Member.Nickname;
          string content = mass.msg;
          string color = mass.Member.Color;
          DateTime d = mass.date;%>
          
            <div class="container">
                <p class="name" ><% =name %></p>
                <fieldset class="content" style="background-color:<%=mass.Member.Color %>"><p><%=content %></p></fieldset>
                <p class="time"><%=d.ToString() %></p>
            </div>  
            
            <%} %>
    
</body>
   
</html>
