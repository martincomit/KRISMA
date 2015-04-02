<%@ Page Language="C#" MasterPageFile="~/mp.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Web_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">
    <asp:Panel runat="server" CssClass="pagina" ScrollBars="Auto" Width="843px">
        <asp:Label runat="server" CssClass="titulo" Text="Login de Usuario"/>

        <br />

        <table border="0" cellpadding="0" class="logincss">
            <tr>
                <td align="center" colspan="2" 
                    style="color: White; background-color: #507CD1; font-size: 0.9em; font-weight: bold;">
                    Iniciar sesión</td>
            </tr>
            <tr>
                <td align="right">
                    Usuario:
                </td>
                <td style="width: 200px">
                    <asp:TextBox ID="txtUsuario" runat="server" Font-Size="0.8em" Height="21px" 
                        Width="170px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUsuario" EnableViewState="False" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="right">
                    Pass:
                </td>
                <td style="width: 200px">
                    <asp:TextBox ID="txtPass" runat="server" Font-Size="0.8em" TextMode="Password" 
                        Width="170px" Height="20px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPass" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" style="color: Red;">
                    <asp:Literal ID="lblIncorrecto" runat="server" EnableViewState="False" 
                        Text="Usuario o Contraseña incorrecta" Visible="False"></asp:Literal>
                    <br />
                    <asp:Button ID="btnLogin" runat="server" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" onclick="LoginButton_Click" style="margin-left: 0px" Text="Inicio de sesión" Width="277px" />
                </td>
            </tr>
            <tr>
                <td align="right" colspan="2">
                    <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Solo Numeros Validos (1-99999999)" MaximumValue="99999999" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
        </table>

    </asp:Panel>
</asp:Content>

