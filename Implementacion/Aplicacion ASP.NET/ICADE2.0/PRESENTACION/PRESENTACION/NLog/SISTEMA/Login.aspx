<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/NLog/MenuHead/MenuHead.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PRESENTACION.PRESENTACION.NLog.SISTEMA.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%; height:400px" border="0">
            <tr>
                <td align="center">
                    <table border="0">
                        <tr>
                            <td>
                                <img alt="" src="/Imagenes/Login/Login1.png" />
                            </td>
                            <td>
                                &nbsp;&nbsp;
                                &nbsp;&nbsp;
                            </td>
                            <td>
                                <table border="0">
                                    <tr>
                                        <td>
                                            <img alt="" src="/Imagenes/Login/Login2.png" style="width: 500px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table border="0">
                                                <tr>
                                                    <td>
                                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                                        &nbsp;&nbsp;&nbsp;
                                                    </td>
                                                    <td style="text-align: left; font-size: xx-small;">
                                                        <asp:Label ID="Label1" runat="server" 
                                                            style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D;" 
                                                            Text="Inicio de sesión" ForeColor="#FC8E01">
                                                        </asp:Label>
                                                        <br />
                                                        <asp:Label ID="Label2" runat="server" 
                                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                                            Text="Correo electronico">
                                                        </asp:Label>
                                                        <br />
                                                        <asp:TextBox ID="TextBox1" runat="server" style="font-family: Calibri; font-size: large" Width="321px"></asp:TextBox>
                                                        <br />
                                                        <br />
                                                        <asp:Label ID="Label3" runat="server" 
                                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                                            Text="Contraseña">
                                                        </asp:Label>
                                                        <br />
                                                        <asp:TextBox ID="TextBox2" runat="server" style="font-family: Calibri; font-size: large" Width="321px" TextMode="Password"></asp:TextBox>
                                                        <br />
                                                        <asp:Label ID="Label4" runat="server" 
                                                            style="font-family: Calibri; color: #FF0000; font-size: large; ">
                                                        </asp:Label>
                                                        <br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td></td>
                                                    <td>
                                                        <table width="100%" border="0">
                                                            <tr>
                                                                <td style="text-align: left">
                                                                    <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0066FF" 
                                                                        NavigateUrl="~/PRESENTACION/NLog/SISTEMA/Registrate.aspx" 
                                                                        style="font-family: Calibri; font-size: large; color: #666666;">
                                                                        Registrate ahora
                                                                    </asp:HyperLink>
                                                                </td>
                                                                <td style="text-align: right">
                                                                    <!--<asp:LinkButton runat="server" ID="qwe" class="btn" OnClick="Button1_login_Click" style="text-decoration:none">Iniciar sesión</asp:LinkButton>-->
                                                                    <asp:Button ID="Button1_login" runat="server" CssClass="boton" Text="Iniciar sesión" OnClick="Button1_login_Click" />
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
                </td>
            </tr>    
        </table>
    <%Session.Abandon(); %>

</asp:Content>
