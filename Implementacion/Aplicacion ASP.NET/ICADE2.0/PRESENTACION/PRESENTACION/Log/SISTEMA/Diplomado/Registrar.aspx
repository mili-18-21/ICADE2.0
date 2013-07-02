<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGDI.master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Diplomado.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Registrar Diplomado"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                                        <asp:Label ID="Label1" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Categoria"></asp:Label>
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
                                        <asp:Label ID="Label3" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Matricula"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="Label4" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" Text="Mensualidad"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox3" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="154px"></asp:TextBox>
                                        &nbsp;<asp:TextBox ID="TextBox4" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="155px"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label5" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Numero de cuotas"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label6" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Horas academicas"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox5" runat="server" style="font-family: Calibri; font-size: large" Width="154px"></asp:TextBox>
                                        &nbsp;<asp:TextBox ID="TextBox6" runat="server" style="font-family: Calibri; font-size: large" Width="155px"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label7" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Imagen"></asp:Label>
                                        <br />
                                        <asp:FileUpload ID="FileUpload1" runat="server" style="font-size: large; font-family:Calibri" Width="325px" />
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
