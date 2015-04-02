<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AutoGestionProfe.aspx.cs" Inherits="Interfaces_AutoGestionProfe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">





.pagina
{			
	float: right;
	background-color: #CEECF5;
    margin-right: 0px;
    margin-left: 0px;
    margin-top: 0px;
    margin-bottom: 0px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Panel runat="server" CssClass="pagina" ScrollBars="Auto" Height="1059px" 
        Width="851px" ID="Panel1">
        <asp:Label ID="Label1" runat="server" Text="Usuario: "></asp:Label>
        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
        <br />
        Deportes
        <asp:DropDownList ID="ddlDeportes" runat="server" Height="46px" 
            onselectedindexchanged="ddlDeportes_SelectedIndexChanged" Width="173px">
        </asp:DropDownList>
        <asp:Button ID="btnSeleccionar" runat="server" onclick="btnSeleccionar_Click" 
            Text="Seleccionar" Width="96px" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblHorarios" runat="server" Text="Horarios:" Visible="False"></asp:Label>
        &nbsp;
        <br />
        <br />
        <asp:Label ID="lblHorario" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblSectores" runat="server" Text="Sector" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvDeportistas" runat="server" 
            onselectedindexchanged="gvDeportistas_SelectedIndexChanged">
        </asp:GridView>
        <br />
        &nbsp;<asp:Label ID="lblObs" runat="server" 
            Text="Observaciones (para pedir que no se inscriban mas)" Visible="False"></asp:Label>
        &nbsp;
        <asp:TextBox ID="txtObservacion" runat="server" Visible="False" Width="290px"></asp:TextBox>
        <asp:Button ID="btnEnviarObs" runat="server" Text="Enviar" Visible="False" 
            Width="83px" />
        <br />
        <br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server" Width="213px"></asp:Calendar>
        <br />
&nbsp;<br />
        <asp:Button ID="btnMensaje" runat="server" Enabled="False" 
            onclick="Button1_Click" Text="Enviar mensaje al Curso" Width="155px" />
        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="txtMensaje" runat="server" Height="94px" Width="345px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Borrar Msjs Viejos" 
            Width="119px" onclick="Button1_Click1" />
        <asp:GridView ID="gvMensajes" runat="server" AutoGenerateSelectButton="True" 
            onselectedindexchanged="gvMensajes_SelectedIndexChanged2">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Logout" runat="server" onclick="Logout_Click" Text="Logout" 
            Width="99px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>    
    <br />
    <br />
    <br />
    
    </div>
    </form>
</body>
</html>
