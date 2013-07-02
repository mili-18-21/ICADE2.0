<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGTE.master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Tema.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Editar tema"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                            <table border="0" width="100%">
                                <tr>
                                    <td>
                            <asp:Button ID="Button1_actualizarsemiario" runat="server" BackColor="#0066FF" 
                                BorderColor="#0066FF" BorderStyle="Dotted" 
                                style="font-family: Calibri; font-size: large; color: #FFFFFF" 
                                Text="Editar seminario" Width="151px" OnClick="Button1_actualizarsemiario_Click" />
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
                            <asp:Button ID="Button2_actualizardescripcion" runat="server" BackColor="#0066FF" 
                                BorderColor="#0066FF" BorderStyle="Dotted" 
                                style="font-family: Calibri; font-size: large; color: #FFFFFF" 
                                Text="Editar descripcion" Width="151px" OnClick="Button2_actualizardescripcion_Click" />
                                    </td>

                                    <td>
                            <asp:Label ID="Label2" runat="server" 
                                style="font-size: large; font-family: Calibri; color: #666666; "></asp:Label>
                                        <asp:TextBox ID="TextBox2" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="321px" Visible="False"></asp:TextBox>
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
