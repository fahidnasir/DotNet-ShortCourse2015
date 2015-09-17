<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FirstWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx">Second Page</asp:HyperLink>
    </div>
    </form>
</body>
</html>
