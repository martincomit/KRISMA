<%@ Page Language="C#" MasterPageFile="~/mp.master" AutoEventWireup="true" CodeFile="AutoGestion.aspx.cs" Inherits="index"%>

<asp:Content ContentPlaceHolderID="contenido" Runat="Server">
    <asp:Panel runat="server" CssClass="pagina" ScrollBars="Auto" Height="899px" 
        Width="851px">
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
        <asp:Calendar ID="Calendar1" runat="server" Width="213px"></asp:Calendar>
        <br />
        Mensajes
        <br />
        <br />
        <asp:ListBox ID="lstMensajes" runat="server" Height="106px" Width="374px">
        </asp:ListBox>
        <br />
        <br />
        <br />
        <asp:GridView ID="gvTorneos" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:GridView ID="gvMisTorneos" runat="server">
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Logout" 
            Width="131px" />
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
</asp:Content>



