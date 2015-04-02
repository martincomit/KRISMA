<%@ Page Title="" Language="C#" MasterPageFile="~/mp.master" AutoEventWireup="true" CodeFile="Estados.aspx.cs" Inherits="Web_Canchas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:Panel runat="server" CssClass="pagina" ScrollBars="Auto">
        <asp:Label ID="Label1" runat="server" CssClass="titulo" 
            Text="Estado de Solicitud"/>        
        <br />
        <asp:Label ID="Label2" runat="server" Text="Documento"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDocumento" runat="server" Width="161px" Enabled="False"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="height: 26px" Text="Consultar" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Estado de Estudios Medicos"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEstudios" runat="server" Enabled="False" Width="159px"></asp:TextBox>
        <asp:Label ID="lblaviso" runat="server"></asp:Label>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label5" runat="server" Text="Usuario Asignado"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUsuario" runat="server" Width="157px" Enabled="False"></asp:TextBox>
    </asp:Panel>
</asp:Content>

