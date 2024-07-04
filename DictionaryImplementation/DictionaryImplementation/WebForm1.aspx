<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DictionaryImplementation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">

            <asp:Label ID="Label1" runat="server" Text="Country Code:"></asp:Label>
            <asp:TextBox ID="txtCountryCode" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged" style="margin-left: 85px" Width="221px"></asp:TextBox>

        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="margin-left: 186px" Width="219px"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Capital"></asp:Label>
        <asp:TextBox ID="txtCapital" runat="server" style="margin-left: 177px" Width="222px"></asp:TextBox>
        <p>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
