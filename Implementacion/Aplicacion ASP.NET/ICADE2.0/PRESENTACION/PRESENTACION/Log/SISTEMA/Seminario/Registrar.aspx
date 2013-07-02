<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGSE.master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Seminario.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label7" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Registrar Seminario"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                                        <asp:Label ID="Label1" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Diplomado"></asp:Label>
                                        <br />
                                        <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" style="font-size: large; font-family:Calibri" Width="325px">
                                        </asp:DropDownList>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label2" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Descripcion"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox2" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="321px"></asp:TextBox>
                                        <br />
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
