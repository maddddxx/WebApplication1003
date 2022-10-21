<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="input_msg_save.aspx.cs" Inherits="WebApplication1003.input_msg_save" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 27px" Text="Resume" />
            <asp:Button ID="Button3" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
