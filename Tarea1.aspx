<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tarea1.aspx.cs" Inherits="tema4.Tarea1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form runat="server">
        <input type="text" id="valor1" runat="server" /><br />
        <input type="text" id="valor2" runat="server" /><br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Sumar</asp:ListItem>
            <asp:ListItem>Restar</asp:ListItem>
            <asp:ListItem>Multiplicar</asp:ListItem>
        </asp:DropDownList>
        <br /><br /><br /><br />
        <input type="Submit" name="botonCalcula" value="Calcula" OnServerClick="AddButton_Click" runat="server" /><br />
        <asp:Label id="resultado" Text="" runat="server"/>

    </form>
</body>
</html>
