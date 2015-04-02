<%@ Page Title="" Language="C#" MasterPageFile="~/mp.master" AutoEventWireup="true" CodeFile="SolicitarPreinscripcion.aspx.cs" Inherits="Web_Carnet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenido" Runat="Server">

    <asp:Panel runat="server" CssClass="pagina" Height="100%" Width="80%">

     
        <asp:Label ID="Label1" runat="server" CssClass="titulo" Text="&nbsp&nbsp&nbsp&nbsp&nbspPRE-INSCRIPCION" Height="23px" Width="100%"/>   
                
        <table class="SolInsDep" style="height: 100%; margin-left: 0%; margin-right: 0%;">
            <tr>
                <td style="width: 20px; height:100px">
                </td>

                <td style="width: 100px; height:100px;font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold;">                    
                </td>

                <td style="width: 316px; height:100px">
                    &nbsp;<asp:Image ID="pbFoto" runat="server" Height="111px" Width="123px" 
                        ImageUrl="~/Imagenes/perfil.png" />
                    <br />
                    <asp:Button ID="btnExaminar" runat="server" onclick="btnExaminar_Click" 
                        Text="Examinar" Width="128px" CausesValidation="False" />
                </td>

                <td style="width: 120px; height:100px">                    
                </td>
            </tr>

            <tr>
                <td rowspan="16" style="width: 20px;">
                
                </td>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                    Documento
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                    
                    <asp:TextBox ID="txtDocumento" runat="server" Width="140px" Height="16px"></asp:TextBox>
                    <asp:Label ID="Label5" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtDocumento" ErrorMessage="Ingrese Documento"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="RangeValidator4" runat="server" 
                        ControlToValidate="txtDocumento" ErrorMessage="Solo Numeros Validos (1000000-99999999)" 
                        MaximumValue="99999999" MinimumValue="1000000" Type="Integer"></asp:RangeValidator>
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; height: 26px; width: 200px;" 
                    colspan="6">
                    &nbsp;</td>

                <td rowspan="16" style="width: 100px;height: 26px;">
                
                </td>
            </tr>
            
            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                    Fecha de Nacimiento
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    <asp:TextBox ID="txtFecNac" runat="server" Width="140px" Height="16px">01-01-1990</asp:TextBox>
                
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtFecNac" 
                        ErrorMessage="Formato de Fecha Incorrecto (MM/DD/AAAA)" 
                        MaximumValue="01-01-2016" MinimumValue="01-01-1900" Type="Date"></asp:RangeValidator>
                
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; height: 26px; width: 220px;" 
                    colspan="6">
                    &nbsp;</td>

            </tr>    

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 28px;">
                    Apellido
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 28px;">
                
                    <asp:TextBox ID="txtApellido" runat="server" Width="176px" Height="18px" OnTextChanged="txtApellido_TextChanged"></asp:TextBox>
                
                    <asp:Label ID="Label6" runat="server" Text="*"></asp:Label>
                
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="Ingrese Apellido"></asp:RequiredFieldValidator>
                
                    &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtApellido" ErrorMessage="Solo Letras" ValidationExpression="^[a-zA-Z  ñ Ñ]*$"></asp:RegularExpressionValidator>
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; width: 120px; height: 28px;">
                    &nbsp;</td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 28px;" 
                    colspan="5">
                
                    &nbsp;</td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 28px;">
                    Nombres
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 28px;">
                
                    <asp:TextBox ID="txtNombres" runat="server" Height="16px" Width="180px"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="*"></asp:Label>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtNombres" ErrorMessage="Ingrese Nombres"></asp:RequiredFieldValidator>
                
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtNombres" ErrorMessage="Solo Letras" ValidationExpression="^[a-zA-Z  ñ Ñ]*$"></asp:RegularExpressionValidator>
                
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; width: 120px; height: 28px;">
                    </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 28px;">
                    </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 28px;">
                    </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 28px;">
                    </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 28px;">
                    </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 28px;">
                    </td>

            </tr>

            <tr>
                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                    Dirección
                </td>
                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                    <asp:TextBox ID="txtDireccion" runat="server" Height="20px" Width="301px"></asp:TextBox>
                </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; width: 120px; height: 26px;">
                </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 26px;">
                </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 26px;">
                </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 26px;">
                </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 26px;">
                </td>
                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; width: 25px; height: 26px;">
                </td>
            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold;">
                    Localidad
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    <asp:DropDownList ID="cmbLocalidades" runat="server" Height="22px" 
                        Width="225px" AppendDataBoundItems="True" AutoPostBack="True" 
                        onselectedindexchanged="cmbLocalidades_SelectedIndexChanged" 
                        ontextchanged="cmbLocalidades_TextChanged">
                    </asp:DropDownList>
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; width: 120px; height: 26px;">
                
                    
                    <asp:Label ID="Label4" runat="server" Text="Sexo"></asp:Label>
                
                    
                </td>

                <td style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: left; height: 26px;" colspan="5">
                
                    <asp:RadioButton ID="rbFem" runat="server" GroupName="Sexo" 
                        oncheckedchanged="F_CheckedChanged" Text="F" />
                    <asp:RadioButton ID="rbMasc" runat="server" Checked="True" GroupName="Sexo" 
                        Text="M" />                    
                    </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                    Barrio
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    <asp:DropDownList ID="cmbBarrios" runat="server" Width="225px" Height="22px">
                    </asp:DropDownList>
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; width: 120px; height: 26px;">
                
                </td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 26px;" 
                    colspan="5">
                
                    &nbsp;</td>

            </tr>


            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                    Tel.Fijo
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<asp:TextBox ID="txtCaractFijo" runat="server" Width="67px"></asp:TextBox>
                
                    )
                    <asp:RangeValidator ID="RangeValidator5" runat="server" 
                        ControlToValidate="txtCaractFijo" ErrorMessage="Solo Numeros" 
                        MaximumValue="99999" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                    <br />
                
                    <asp:TextBox ID="txtFijo" runat="server" Height="22px" 
                        style="margin-left: 83px; margin-top: 0px;" Width="143px"></asp:TextBox>
                
                    <asp:RangeValidator ID="RangeValidator2" runat="server" 
                        ControlToValidate="txtFijo" ErrorMessage="Solo Numeros" 
                        MaximumValue="999999999" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: right; width: 120px; height: 26px;">
                
                    Tel.Celular</td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 26px;" 
                    colspan="5">
                
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<asp:TextBox ID="txtCaractCel" runat="server" Height="20px" 
                        Width="69px"></asp:TextBox>
                
                    )<asp:RangeValidator ID="RangeValidator6" runat="server" 
                        ControlToValidate="txtCaractCel" ErrorMessage="Solo Numeros" 
                        MaximumValue="99999" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                    <asp:TextBox ID="txtCel" runat="server" Width="116px" Height="16px" 
                        style="margin-left: 72px"></asp:TextBox>
                
                    <asp:RangeValidator ID="RangeValidator3" runat="server" 
                        ControlToValidate="txtCel" ErrorMessage="Solo Numeros" MaximumValue="999999999" 
                        MinimumValue="0" Type="Integer"></asp:RangeValidator>
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                    E-Mail
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px">
                
                    <asp:TextBox ID="txtEmail" runat="server" Width="220px" Height="16px"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" Text="*"></asp:Label>
                    <br />
                
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Ingrese Email"></asp:RequiredFieldValidator>
                
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Formato de email Incorrecto" 
                        ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                
                </td>

                <td style="font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 26px; width: 220px;" 
                    colspan="6">
                
                    <br />
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                
                </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                </td>

                <td style="width: 120px; font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 26px;">
                
                </td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 26px;" 
                    colspan="5">
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                
                    Condición</td>

                <td colspan="7" 
                    
                    
                    
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 200px; height: 26px;">
                
                    <asp:DropDownList ID="cmbCondiciones" runat="server" Width="225px" 
                        Height="22px" AppendDataBoundItems="True" AutoPostBack="True" 
                        onselectedindexchanged="cmbCondiciones_SelectedIndexChanged" 
                        ontextchanged="cmbCondiciones_TextChanged">
                    </asp:DropDownList>
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                
                    Becado</td>

                <td style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 316px; height: 26px;">
                
                    &nbsp;
                    <asp:RadioButton ID="rbSIBeca" runat="server" GroupName="Becado" Text="SI" />
                    <asp:RadioButton ID="rbNOBeca" runat="server" Checked="True" GroupName="Becado" 
                        Text="NO" />
                
                </td>

                <td style="width: 120px; font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 26px;">
                
                </td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 26px;" 
                    colspan="5">
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                
                    Unidad Academica</td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    <asp:DropDownList ID="cmbUnidad" runat="server" Height="22px" Width="225px" 
                        AppendDataBoundItems="True" 
                        onselectedindexchanged="cmbUnidad_SelectedIndexChanged" 
                        AutoPostBack="True" ontextchanged="cmbUnidad_TextChanged">
                    </asp:DropDownList>
                </td>

                <td style="width: 120px; font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 26px;">
                
                </td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 26px;" 
                    colspan="5">
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                
                    Escuela</td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    <asp:DropDownList ID="cmbEscuela" runat="server" Height="22px" Width="225px">
                    </asp:DropDownList>
                </td>

                <td style="width: 120px; font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 26px;">
                
                </td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; width: 100px; text-align: right; height: 26px;" 
                    colspan="5">
                
                </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 190px;">
                
                    Deportes</td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 190px; margin-left: 40px;">
                
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="cmbTipo" runat="server" AppendDataBoundItems="True" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>Recreativo</asp:ListItem>
                                <asp:ListItem>Federado</asp:ListItem>
                            </asp:DropDownList>
                            <asp:DropDownList ID="cmbDeportes" runat="server" Height="22px" Width="225px">
                            </asp:DropDownList>
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <asp:Button ID="Button1" runat="server" CausesValidation="False" onclick="Button1_Click" Text="Consultar Horarios y Lugar" Width="176px" />
                    <br />
                    <br />
                    <asp:Label ID="lblHorario" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblSectores" runat="server"></asp:Label>
                    <br />
                </td>

                <td style="width: 120px; font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 190px;">
                
                    </td>

                <td 
                    
                    
                    style="font-family: Verdana; font-size: 11px; font-weight: bold; text-align: right; height: 190px;" 
                    colspan="5">
                
                    </td>

            </tr>

            <tr>

                <td style="width: 120px; font-family: Verdana; text-align: right; font-size: 11px; font-weight: bold; height: 26px;">
                
                    </td>

                <td style="width: 316px; font-family: Verdana; font-size: 11px; font-weight: bold; height: 26px;">
                
                    <asp:Button ID="txtEnviar" runat="server" onclick="txtEnviar_Click" 
                        Text="Solicitar Preinscripcion" Width="294px" Height="24px" />
                </td>

                <td style="width: 120px; font-size: 11px; font-family: Verdana; font-weight: bold; text-align: left; height: 26px;">
                
                    <asp:Label ID="lblSolicitud" runat="server"></asp:Label>
                
                </td>

            </tr>

        </table>

    </asp:Panel>


</asp:Content>

