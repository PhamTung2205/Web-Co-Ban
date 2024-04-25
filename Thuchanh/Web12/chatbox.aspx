<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chatbox.aspx.cs" Inherits="Web12.chatbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<frameset rows="75%,25%" >
    <frameset cols="20%,80%">
        <frame src="Members.aspx"></frame>
        <frame src="MessageList.aspx"></frame>
    </frameset>
    <frame src="./HTML/Message.html?name=<%=Request.Url.ToString().Split('=')[1]%>"scrolling="no"></frame>
</frameset>
</html>
