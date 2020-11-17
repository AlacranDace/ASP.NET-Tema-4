<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="tema4.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <asp:DataList   runat="server"
                    ID="DataList1"
                    BorderColor="Black"
                    CellPadding="3"
                    Font-Name="Verdana"
                    Font-Size="8pt">
    <HeaderStyle BackColor="#aaaadd"/>
    <AlternatingItemStyle BackColor="Gainsboro" />
        <ItemTemplate>
            <table border="1" style="width:300px; height:100px; border:dashed 2px #04AFEF; background-color:#FFFFFF">
                <tr>
                    <td>
                        <b> ID: </b><span class="city"><%# Eval("id")%></span><br />
                        <b> Name: </b><span class="postal"><%# Eval("Nombre")%></span><br />
                        <b> Email: </b><span class="country"><%# Eval("Correo")%></span><br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
                    
    </asp:DataList>
</body>
</html>
