<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGDI.master" AutoEventWireup="true" CodeBehind="Buscar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Diplomado.Buscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="margin-left:50px;" border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label0" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Buscar Diplomado"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top" style="text-align: left">
                            <asp:Label ID="Label1" runat="server" 
                                style="font-family: Calibri; font-size: large; color:#1D1D1D;" 
                                Text="Descripcion"></asp:Label>
                            &nbsp;
                            <asp:TextBox ID="TextBox1" runat="server" 
                                style="font-family: Calibri; font-size: large" Width="477px"></asp:TextBox>
                            &nbsp;
                            <asp:Button ID="Button1_registrar" runat="server" CssClass="boton" Text="Buscar" OnClick="Button1_registrar_Click" />
                        
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
                                    <asp:BoundField DataField="IdDiplomado" HeaderText="Id" />
                                    <asp:BoundField DataField="Categoria" HeaderText="Categ" />
                                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                    <asp:BoundField DataField="Matricula" HeaderText="Matricula" />
                                    <asp:BoundField DataField="Mensualidad" HeaderText="Mensual" />
                                    <asp:BoundField DataField="NumeroCuotas" HeaderText="N° Cuotas" />
                                    <asp:BoundField DataField="HorasAcademicas" HeaderText="Hrs Acad" />
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
