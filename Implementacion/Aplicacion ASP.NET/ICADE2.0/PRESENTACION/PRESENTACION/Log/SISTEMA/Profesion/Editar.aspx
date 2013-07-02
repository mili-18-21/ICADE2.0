<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGPR.master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Profesion.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Editar profesion"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                            <table border="0" width="100%">
                                <tr>
                                    <td>
                            <asp:Button ID="Button1_actualizardescripcion" runat="server" CssClass="boton" Text="Editar descripcion" OnClick="Button1_actualizardescripcion_Click" />
                                    </td>

                                    <td>
                            <asp:Label ID="Label1" runat="server" 
                                style="font-size: large; font-family: Calibri; color: #666666; "></asp:Label>
                                        <asp:TextBox ID="TextBox1" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
                                    </td>
                                    
                                    
                                </tr>
                                <tr>
                                    <td>
                            <asp:Button ID="Button2_editarestado" runat="server" CssClass="boton" Text="Editar estado" OnClick="Button2_editarestado_Click" />
                                    </td>

                                    <td>
                            <asp:Label ID="Label2" runat="server" 
                                style="font-size: large; font-family: Calibri; color: #666666; "></asp:Label>
                                        <asp:CheckBox ID="CheckBox1" runat="server"
                                            style="font-size: large; font-family:Calibri; color: #1D1D1D;" Text="Activo" Visible="False" />
                                    </td>
                                    
                                    
                                </tr>
                                <tr>
                                    <td>
                                        <br />
                                        <br />
                                        <br />
                                        <br />
                                    </td>
                                    <td>
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
