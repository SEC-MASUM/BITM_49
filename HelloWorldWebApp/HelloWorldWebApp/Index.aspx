<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HelloWorldWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hello World</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <%--<asp:TextBox ID="nameTextBox" runat="server" Width="205px"></asp:TextBox>--%>
            <input name="nameTextBox" type="text" runat="server" id="nameTextBox" style="width:205px;"/>
            <br />
            <br />
            <br />
            <asp:Button ID="showButton" runat="server" Text="Display" OnClick="showButton_Click" />
            <asp:Label ID="messageLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
