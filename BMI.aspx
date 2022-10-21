<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="WebApplication1003.BMI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Gender :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            Height : <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>inch</asp:ListItem>
                <asp:ListItem>cm</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="TextBox2" runat="server" Height="16px"></asp:TextBox>
            <br />
&nbsp;&nbsp;<br />
            Weight :
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>pound</asp:ListItem>
                <asp:ListItem>kg</asp:ListItem>
            </asp:RadioButtonList>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BMI" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
