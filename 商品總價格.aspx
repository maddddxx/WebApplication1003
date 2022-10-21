<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="商品總價格.aspx.cs" Inherits="WebApplication1003.商品總價格" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Width="61px">
                <asp:ListItem Value="10">A</asp:ListItem>
                <asp:ListItem Value="15">B</asp:ListItem>
                <asp:ListItem Value="20">C</asp:ListItem>
            </asp:ListBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove" />
            <asp:ListBox ID="ListBox2" runat="server" SelectionMode="Multiple"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
