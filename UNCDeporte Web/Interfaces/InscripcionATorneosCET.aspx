<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InscripcionATorneosCET.aspx.cs" Inherits="Interfaces_InscripcionATorneosCET" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuario:
        <asp:Label ID="lblUsuario" runat="server"></asp:Label>
        <br />
        <br />
        Tipo de Deporte:
    <asp:DropDownList ID="cmbTipoDeporte" runat="server" Height="31px" Width="150px" 
            onselectedindexchanged="cmbTipoDeporte_SelectedIndexChanged" 
            AutoPostBack="True">
    </asp:DropDownList>
        <br />
        <br />
    
    </div>
    Deporte:
    <asp:DropDownList ID="cmbDeportes" runat="server" Height="31px" Width="150px" 
        AutoPostBack="True" onselectedindexchanged="cmbDeportes_SelectedIndexChanged" 
        ontextchanged="cmbDeportes_TextChanged">
    </asp:DropDownList>
    <br />
    <br />
    Torneo:&nbsp; 
    <asp:DropDownList ID="cmbTorneos" runat="server" Width="152px" Height="28px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Ver Descripcion" style="width: 138px" />
    <br />
    <br />
    Descripcion: 
    <asp:Label ID="lblCaract" runat="server" Text="Label"></asp:Label>
    <br />
    Inscriptos:
    <asp:Label ID="lblInscriptos" runat="server"></asp:Label>
    <br />
    Estado:
    <asp:Label ID="lblEstado" runat="server"></asp:Label>
    <br />
    <asp:Label ID="lblnocupo" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnAvisar" runat="server" 
        Text="Avisar a Encargado de Torneos " Visible="False" Width="208px" 
        onclick="btnAvisar_Click" />
    <asp:TextBox ID="txtMensaje" runat="server" Height="25px" 
        style="margin-top: 0px" Visible="False" Width="503px"></asp:TextBox>
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
    <br />
    Documento Interesado:
     <asp:TextBox ID="txtDocumento" runat="server" Width="158px" Enabled="False"></asp:TextBox>
    &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="txtDocumento" ErrorMessage="Solo Numeros" 
        MaximumValue="99999999" MinimumValue="0" Type="Integer"></asp:RangeValidator>
&nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" Enabled="False" 
        onclick="btnBuscar_Click" Width="92px" />
    <br />
    <br />
   Datos deportista:
    <asp:Label ID="lblDatosDeportista" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnInscribir" runat="server" Text="Inscribir Participante" 
        onclick="Button1_Click" Enabled="False" Width="178px" />
&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Volver" Width="102px" 
        onclick="Button2_Click" />
    <br />
    <br />
    <asp:Label ID="lblGuardado" runat="server"></asp:Label>
    </form>
</body>
</html>
