<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JuegoCalculadora.aspx.cs" Inherits="tema4.JuegoCalculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Numero 1:
            <asp:Label ID="Sumando1" runat="server"></asp:Label>
        </div>
        <p>
            Numero 2:
            <asp:Label ID="Sumando2" runat="server"></asp:Label>
        </p>
        <p>
            Resultado:
            <asp:TextBox ID="Resultado" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Mensaje" runat="server"></asp:Label>
        </p>
        <asp:Button ID="Comprobar" runat="server" OnClick="Comprobar_Click" Text="Comprobar" />
        <asp:Button ID="Nuevo" runat="server" OnClick="Nuevo_Click" Text="Nuevo" />
    </form>
</body>
</html>
