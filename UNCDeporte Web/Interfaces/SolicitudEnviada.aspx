<%@ Page Title="" Language="C#" MasterPageFile="~/mp.master" AutoEventWireup="true" CodeFile="SolicitudEnviada.aspx.cs" Inherits="Web_SolicitudEnviada" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <p>
        asd</p>
    <asp:Panel ID="Panel1" runat="server" CssClass="pagina" Height="219px">
        Solicitud Enviada, para consultar su estado consulte proximamente con su 
        Documento:
        <asp:Label ID="lblDoc" runat="server" Text="1"></asp:Label>
        &nbsp;en consultar Solicitudes.<br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Ir a Consultar Estado" />
    </asp:Panel>
</asp:Content>

