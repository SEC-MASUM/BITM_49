<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="ViewStateWithCollection.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server" Width="158px"></asp:TextBox>
            <br />
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
            <asp:Button ID="showAllButton" runat="server" Text="Show All" OnClick="showAllButton_Click" />
        </div>
        <asp:ListBox ID="nameListBox" runat="server" Height="124px" Width="201px"></asp:ListBox>
    </form>
</body>
</html>
