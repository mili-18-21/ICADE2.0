<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/ParticipanteGPA.master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Participante.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Editar mis datos"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">     
                            <table border="0" width="100%">
                                                                        <tr>
                                                                            <td>
                                                                    <asp:Button ID="Button1_actualizarnombre" runat="server" CssClass="boton" Text="Editar nombre" OnClick="Button1_actualizarnombre_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label1" runat="server" 
                                                                        style="font-size: large; font-family: Calibri; color: #666666; "></asp:Label>
                                                                                <asp:TextBox ID="TextBox1" runat="server" 
                                                                                    style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                                            </td>
                                    
                                    
                                                                        </tr>
                                                                        <tr>
                                    
                                                                            <td style="margin-left: 40px">
                                                                    <asp:Button ID="Button2_actualizarapellidos" runat="server" CssClass="boton" Text="Editar apellidos" OnClick="Button2_actualizarapellidos_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label2" runat="server" 
                                                                        style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                                                <asp:TextBox ID="TextBox2" runat="server" 
                                                                                    style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                                            </td>

                                    
                                                                        </tr>
                                                                        <tr>
                                    
                                                                            <td>
                                                                    <asp:Button ID="Button3_actualizaremail" runat="server" CssClass="boton" Text="Editar email" OnClick="Button3_actualizaremail_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label3" runat="server" 
                                                                        style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                                                <asp:TextBox ID="TextBox3" runat="server" 
                                                                                    style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                                            </td>

                                    
                                                                        </tr>
                                                                        <tr>
                                    
                                                                            <td>
                                                                    <asp:Button ID="Button4_actualizarcontraseña" runat="server" CssClass="boton" Text="Editar contraseña" OnClick="Button4_actualizarcontraseña_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label4" runat="server" 
                                                                        style="font-family: Calibri; font-size: large; color: #666666">***************</asp:Label>
                                                                                <asp:TextBox ID="TextBox4" runat="server" 
                                                                                    style="font-family: Calibri; font-size: large" Width="321px" Visible="False" TextMode="Password"></asp:TextBox>
                                                                            </td>

                                    
                                                                        </tr>
                                                                        <tr>
                                    
                                                                            <td>
                                                                    <asp:Button ID="Button5_actualizarprofesion" runat="server" CssClass="boton" Text="Editar profesion" OnClick="Button5_actualizarprofesion_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label5" runat="server" 
                                                                        style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                                                <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" style="font-size: large; font-family:Calibri" Width="325px" Visible="False">
                                                                                </asp:DropDownList>
                                                                            </td>

                                    
                                                                        </tr>
                                                                        <tr>
                                    
                                                                            <td>
                                                                    <asp:Button ID="Button6_actualizardireccion" runat="server" CssClass="boton" Text="Editar direccion" OnClick="Button6_actualizardireccion_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label6" runat="server" 
                                                                        style="color: #666666; font-family: Calibri; font-size: large"></asp:Label>
                                                                                <asp:TextBox ID="TextBox6" runat="server" 
                                                                                    style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                                            </td>

                                    
                                                                        </tr>
                                                                        <tr>
                                    
                                                                            <td>
                                                                    <asp:Button ID="Button7_actualizartelefono" runat="server" CssClass="boton" Text="Editar telefono" OnClick="Button7_actualizartelefono_Click" />
                                                                            </td>

                                                                            <td>
                                                                    <asp:Label ID="Label7" runat="server" 
                                                                        style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                                                <asp:TextBox ID="TextBox7" runat="server" 
                                                                                    style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                                            </td>

                                    
                                                                        </tr>
                                
                                                                    </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
