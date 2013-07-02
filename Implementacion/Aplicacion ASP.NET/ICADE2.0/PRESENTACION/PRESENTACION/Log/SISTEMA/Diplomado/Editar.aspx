<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGDI.master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Diplomado.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Editar Diplomado"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                            
                            
                            <table>
                                <tr>
                                    <td valign="top" style="width:200px; text-align:center">
                                        <table>
                                            <tr>
                                                <td style="background-color:black; width:200px; height:220px">
                                                    <asp:Image ID="Image1" runat="server" Width="140px" />
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td>
                                        <table border="0" width="100%">
                                            <tr>
                                                <td>
                                        <asp:Button ID="Button1_actualizarcategoria" runat="server" CssClass="boton" Text="Editar categoria" OnClick="Button1_actualizarcategoria_Click" />
                                                </td>

                                                <td>
                                        <asp:Label ID="Label1" runat="server" 
                                            style="font-size: large; font-family: Calibri; color: #666666; "></asp:Label>
                                                    <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" style="font-size: large; font-family:Calibri" Width="325px" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                    
                                    
                                            </tr>
                                            
                                            <tr>
                                    
                                                <td>
                                        <asp:Button ID="Button3_actualizarmatricula" runat="server" CssClass="boton" Text="Editar matricula" OnClick="Button3_actualizarmatricula_Click" />
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
                                        <asp:Button ID="Button4_actualizarmensualidad" runat="server" CssClass="boton" Text="Editar mensual" OnClick="Button4_actualizarmensualidad_Click" />
                                                </td>

                                                <td>
                                        <asp:Label ID="Label4" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                    <asp:TextBox ID="TextBox4" runat="server" 
                                                        style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                </td>

                                    
                                            </tr>
                                            <tr>
                                    
                                                <td>
                                        <asp:Button ID="Button5_actualizarnumerocuotas" runat="server" CssClass="boton" Text="Editar N cuotas" OnClick="Button5_actualizarnumerocuotas_Click" />
                                                </td>

                                                <td>
                                        <asp:Label ID="Label5" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                    <asp:TextBox ID="TextBox5" runat="server" 
                                                        style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                                </td>

                                    
                                            </tr>
                                            <tr>
                                    
                                                <td>
                                        <asp:Button ID="Button6_actualizarhorasacademicas" runat="server" CssClass="boton" Text="Editar hrs. acad." OnClick="Button6_actualizarhorasacademicas_Click" />
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
                                        <asp:Button ID="Button7_actualizarimagen" runat="server" CssClass="boton" Text="Editar imagen" OnClick="Button7_actualizarimagen_Click" />
                                                </td>

                                                <td>
                                        <asp:Label ID="Label7" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                        <asp:FileUpload ID="FileUpload1" runat="server" style="font-size: large; font-family:Calibri" Width="325px" Visible="False" />
                                                </td>

                                    
                                            </tr>
                                            <tr>
                                    
                                                <td style="margin-left: 40px" valign="top">
                                        <asp:Button ID="Button2_actualizardescripcion" runat="server" CssClass="boton" Text="Editar descripcion" OnClick="Button2_actualizardescripcion_Click" />
                                                </td>

                                                <td>
                                        <asp:Label ID="Label2" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #666666"></asp:Label>
                                                    <asp:TextBox ID="TextBox2" runat="server" 
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
            </td>
        </tr>
    </table>

</asp:Content>
