<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/NLog/MenuHead/MenuHead.Master" AutoEventWireup="true" CodeBehind="Registrate.aspx.cs" Inherits="PRESENTACION.PRESENTACION.NLog.SISTEMA.Registrate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table width="100%">
        <tr>
            <td align="center">
                <table border="0" style=" width: 1020px; height: 400px">
                    <tr>
                        <td align="center">
                            <table border="0">
                                <tr>
                                    <td>
                                        <asp:Label ID="Label8" runat="server" Text="Ingresa tus datos" 
                                            
                                            
                                            style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D; "></asp:Label>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label9" runat="server" Text="Crea tu cuenta AQUÍ" 
                                            style="color: #1D1D1D; font-size: xx-large; font-family: 'Eras Demi ITC'"></asp:Label>
                                    </td>
                                    <td>
                                    </td>
                                    <td>
                                        <asp:Label ID="Label10" runat="server" Text="Acerca de nosotros" 
                                            style="font-size: xx-large; font-family: 'Eras Demi ITC'; color: #1D1D1D"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" style="text-align: left; font-size: xx-small;">
                                        <asp:Label ID="Label1" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Nombre"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <asp:Label ID="Label2" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Apellidos"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox1" runat="server" style="font-family: Calibri; font-size: large" Width="155px"></asp:TextBox>
                                        &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="font-family: Calibri; font-size: large" Width="155px"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label3" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Correo electronico"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox3" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="321px"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label4" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Contraseña"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox4" runat="server" 
                                            style="font-family: Calibri; font-size: large" Width="321px" 
                                            TextMode="Password"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label0" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Confirma tu contraseña"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox0" runat="server" style="font-family: Calibri; font-size: large" Width="321px" TextMode="Password"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label5" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Profesion"></asp:Label>
                                        <br />
                                        <asp:DropDownList ID="DropDownList1" runat="server" Height="28px" style="font-size: large; font-family:Calibri" Width="325px">
                                        </asp:DropDownList>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label6" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Direccion"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox5" runat="server" style="font-family: Calibri; font-size: large" Width="321px"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label ID="Label11" runat="server" 
                                            style="font-family: Calibri; font-size: large; color: #1D1D1D;" 
                                            Text="Telefono"></asp:Label>
                                        <br />
                                        <asp:TextBox ID="TextBox6" runat="server" style="font-family: Calibri; font-size: large" Width="321px"></asp:TextBox>
                                        <br />
                                        <br />
                                    </td>
                                    <td></td>
                                    <td valign="top">
                                        <img alt="" style="width:220px; height:160px;" src="/Imagenes/Registrate/Registrate1.jpg" />
                                        <br />
                                        <img alt="" style="width:220px; height:160px;" src="/Imagenes/Registrate/Registrate2.jpg" />
                                        <br />
                                        <span style="color: #666666">inicia sesión</span><span style="color:White;"> </span>
                                        <asp:HyperLink ID="HyperLink1" runat="server" 
                                            NavigateUrl="~/PRESENTACION/NLog/SISTEMA/Login.aspx" 
                                            style="font-size: large; font-family: Calibri; color: #666666;">
                                            aquí
                                        </asp:HyperLink>
                                    </td>
                                    <td></td>
                                    <td valign="top" style="text-align: justify; width:320px; color:#FFFFFF;">
                                        <span style="color: #1D1D1D">ICADE VIRTUAL</span><span><span style="color: #1D1D1D"> es la mayor plataforma de compras y ventas por Internet de la ciudad de trujillo 
                                            en donde podras encontrar una gran gama de productos y podras intercambiar informacion y 
                                            realizar transacciones de comercio electronico con una gama amplia de productos y servicios, 
                                            a precios realmente competitivos.<br />
                                        <br />
                                        </span>
                                        </span>
                                        <span style="color: #1D1D1D">
                                            Tambien permite que los vendedores publiquen vehiculos, inmuebles y servicios en una seccion 
                                            exclusiva de avisos clasificados en linea en la moderna plataforma de 
                                        ICADEVIRTUAL.com
                                        </span>
                                        <br />
                                        <br />
                                        <span style="color: #1D1D1D">
                                            Tambien permite que los vendedores publiquen vehiculos, inmuebles y servicios en una seccion 
                                            exclusiva de avisos clasificados en linea en la moderna plataforma de 
                                        ICADEVIRTUAL.com
                                        <br />
                                        <br />
                                        Registrate como
                                        </span>
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/PRESENTACION/NLog/SISTEMA/Administrador.aspx" style="font-size: large; font-family: Calibri; color: #666666;">
                                            Administrador
                                        </asp:HyperLink>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="text-align: right">
                                        <asp:Button ID="Button1_registrate" runat="server" BackColor="#8EBC00" 
                                                                        BorderColor="#8EBC00" BorderStyle="Dotted" 
                                            style="font-family: Calibri; font-size: large; color: #FFFFFF" 
                                            Text="Registrate" Width="151px" OnClick="Button1_registrate_Click" />
                                    </td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
