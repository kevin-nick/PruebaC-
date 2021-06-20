<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="WebApplication1.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="ddlLista_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
        </p>
        <p>
            &nbsp;</p>
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
    </form>
</body>
</html>
