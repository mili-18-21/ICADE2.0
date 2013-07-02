<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGCA.master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Categoria.Buscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="margin-left:50px;" border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Buscar Categoria"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                            <asp:Label ID="Label1" runat="server" 
                                style="font-family: Calibri; font-size: large; color:#1D1D1D;" 
                                Text="Descripcion"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="TextBox1" runat="server" 
                                style="font-family: Calibri; font-size: large" Width="220px"></asp:TextBox>
                            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="28px" style="font-size: large; font-family:Calibri" Width="225px">
                                <asp:ListItem Value="1">Todas las profesiones</asp:ListItem>
                                <asp:ListItem Value="2">Derecho</asp:ListItem>
                                <asp:ListItem Value="1014">Administracion</asp:ListItem>
                                        </asp:DropDownList>
                                    &nbsp;<asp:Button ID="Button1_registrar" runat="server" CssClass="boton" Text="Buscar" OnClick="Button1_registrar_Click" />
                        
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:GridView ID="gvCustomres" runat="server"
                                AutoGenerateColumns="False"
                                GridLines="None"
                                AllowPaging="true"
                                CssClass="mGrid"
                                PagerStyle-CssClass="pgr"
                                AlternatingRowStyle-CssClass="alt" 
                                onpageindexchanging="gvCustomres_PageIndexChanging" PageSize="5" 
                                onrowcommand="gvCustomres_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="IdCategoria" HeaderText="IdCategoria" />
                                    <asp:BoundField DataField="Profesion" HeaderText="Profesion" />
                                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                    <asp:ButtonField CommandName="Editar" ButtonType="Image" HeaderText="Editar" ImageUrl="~/Imagenes/GridView/Edit.png" ControlStyle-CssClass="imgw" />
                                    <asp:ButtonField CommandName="Eliminar" ButtonType="Image" HeaderText="Eliminar" ImageUrl="~/Imagenes/GridView/Eliminar.png" ControlStyle-CssClass="imgw" />
                                </Columns>
                            </asp:GridView>        
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

</asp:Content>
