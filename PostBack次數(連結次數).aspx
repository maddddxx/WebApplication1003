<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack次數(連結次數).aspx.cs" Inherits="WebApplication1003.PostBack次數_連結次數_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            第幾次連接到 server :
            <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
