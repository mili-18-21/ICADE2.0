<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGPR.master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Profesion.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label7" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Registrar Profesion"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                                        <asp:Label ID="Label1" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Descripcion"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox1" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="321px"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label2" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Estado"></asp:Label>
                                        <asp:CheckBox ID="CheckBox1" runat="server"
                                            style="font-size: large; font-family:Calibri; color: #1D1D1D;" Text="Activo" />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            <asp:Button ID="Button1_registrar" runat="server" CssClass="boton" Text="Registrar" OnClick="Button1_registrar_Click" />
                        
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
