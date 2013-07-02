<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/ParticipanteRMA.master" AutoEventWireup="true" CodeBehind="Registrar2.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Matricula.Registrar2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="margin-left:20px;" border="0">
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label0" 
                            runat="server" 
                            style="font-family: 'Eras Demi ITC'; 
                                   font-size: xx-large; 
                                   color: #1D1D1D" 
                            Text="Obtener Diplomado">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">

                <asp:GridView ID="GridView1" 
                    runat="server" GridLines="None" AlternatingRowStyle-CssClass="alt" 
                    AutoGenerateColumns="False" AllowPaging="true" PageSize="5" 
                    DataKeyNames="IdDiplomado" CssClass="mGrid" OnRowCommand="GridView1_RowCommand"
                    DataSourceID="SqlDataSource1" PagerStyle-CssClass="pgr" HeaderStyle-CssClass="hiddencol" 
                    OnRowDataBound="GridView1_RowDataBound" OnPageIndexChanging="GridView1_PageIndexChanging">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                    <Columns>
                        <asp:BoundField DataField="IdDiplomado" ItemStyle-CssClass="hiddencol"  
                                    HeaderText="IdDiplomado"  
                                    InsertVisible="False" 
                                    ReadOnly="True" 
                                    SortExpression="IdDiplomado" >
                        
<ItemStyle CssClass="hiddencol"></ItemStyle>
                        </asp:BoundField>
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                                <table style="width:720px" border="0">
                                    <tr>
                                        <td style="width:150px">
                                            <asp:Image ID="Image1" runat="server" Width="150px"  Height="200px" ImageUrl='<%# Eval("Imagen") %>' />
                                            <br />
                                            <asp:Button ID="Button1" runat="server" CommandName="Ver" 
                                                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" 
                                                        Text="Ver mas detalles" CssClass="botonv" OnClick="Button1_Click" />
                                        </td>
                                        <td style="text-align: left" valign="top">
                                            <br />
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label2" runat="server" Text="DIPLOMADO:" 
                                                style="font-size: small; font-family: Calibri; color: #0066FF; ">
                                            </asp:Label>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Descripcion") %>' 
                                                style="font-size: small; font-weight: 700; color: #1D1D1D; font-family: Calibri">
                                            </asp:Label>
                                            <br />
                                            <br />
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label4" runat="server" Text="MATRICULA: " 
                                                style="font-size: small; font-family: Calibri; color: #666699; ">
                                            </asp:Label>
                                            <asp:Label ID="Label6" runat="server" Text="S/." 
                                                style="font-size: small; font-family: Calibri; color: #1D1D1D; font-weight: 700">
                                            </asp:Label>
                                            <asp:Label ID="Label5" runat="server" Text='<%# Eval("Matricula") %>' 
                                                style="font-size: small; font-weight: 700; color: #1D1D1D; font-family:Calibri">
                                            </asp:Label>
                                            <br />
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label7" runat="server" Text="MENSUALIDAD: " 
                                                style="font-size: small; font-family: Calibri; color: #666699; ">
                                            </asp:Label>
                                            <asp:Label ID="Label8" runat="server" Text="S/." 
                                                style="font-size: small; font-family: Calibri; color: #1D1D1D; font-weight: 700">
                                            </asp:Label>
                                            <asp:Label ID="Label9" runat="server" Text='<%# Eval("Mensualidad") %>' 
                                                style="font-size: small; font-weight: 700; color: #1D1D1D; font-family: Calibri">
                                            </asp:Label>
                                            <br />
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label10" runat="server" Text="Nº DE CUOTAS:" 
                                                style="font-size: small; font-family: Calibri; color: #666699; ">
                                            </asp:Label>
                                            <asp:Label ID="Label11" runat="server" Text='<%# Eval("NumeroCuotas") %>'
                                                 style="font-size: small; font-weight: 700; color: #1D1D1D; font-family: Calibri">
                                            </asp:Label>
                                            <br />
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label12" runat="server" Text="HRS ACADEMICAS:" 
                                                style="font-size: small; font-family: Calibri; color: #666699; ">
                                            </asp:Label>
                                            <asp:Label ID="Label13" runat="server" Text='<%# Eval("HorasAcademicas") %>' 
                                                style="font-size: small; font-weight: 700; color: #1D1D1D; font-family: Calibri">
                                            </asp:Label>
                                            <br />
                                            <br />
                                            <asp:GridView ID="GridView2" 
                                                            runat="server" HeaderStyle-CssClass="hiddencol" 
                                                            AutoGenerateColumns="False" CssClass="mqGrid"  
                                                            DataKeyNames="IdSeminario" 
                                                            DataSourceID="SqlDataSource2">
                                                            <Columns>
                                                                <asp:TemplateField>
                                                                    <ItemTemplate>
                                                                        <table style="width:600px" border="0">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label ID="Label18" runat="server" 
                                                                                        style="color: #FFFFFF; font-size: small; font-family: Calibri" Text="TOMO">
                                                                                    </asp:Label>
                                                                                    <asp:Label ID="Label14" runat="server" 
                                                                                        style="color: #0066FF; font-size: small; font-family: Calibri" Text="TOMO">
                                                                                    </asp:Label>
                                                                                    <asp:Label ID="Label15" runat="server" 
                                                                                        style="font-family: Calibri; font-size: small; color: #0066FF" Text="1">
                                                                                    </asp:Label>
                                                                                    <asp:Label ID="Label16" runat="server" 
                                                                                        style="font-family: Calibri; font-size: small; color: #0066FF" Text=":">
                                                                                    </asp:Label>
                                                                                    <asp:Label ID="Label17" runat="server" Text='<%# Eval("Descripcion") %>' 
                                                                                        style="font-family: Calibri; font-size: small; color: #1D1D1D">
                                                                                    </asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                            </Columns>
                                                            <HeaderStyle CssClass="hiddencol" />
                                            </asp:GridView>
                                            <asp:SqlDataSource ID="SqlDataSource2" 
                                                                runat="server" 
                                                                ConnectionString="Data Source=idea-PC;Initial Catalog=ICADEVIRTUAL2013;Integrated Security=True" 
                                                                ProviderName="System.Data.SqlClient" 
                                                                SelectCommand="SELECT * FROM [Seminario] WHERE ([Diplomado] = @Diplomado)">
                                                                <SelectParameters>
                                                                    <asp:Parameter Name="Diplomado" Type="Int32" />
                                                                </SelectParameters>
                                            </asp:SqlDataSource>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

<HeaderStyle CssClass="hiddencol"></HeaderStyle>

<PagerStyle CssClass="pgr"></PagerStyle>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" 
                                    runat="server" 
                                    ConnectionString="Data Source=idea-PC;Initial Catalog=ICADEVIRTUAL2013;Integrated Security=True" 
                                    ProviderName="System.Data.SqlClient" 
                                    SelectCommand="SELECT * FROM [Diplomado]">
                </asp:SqlDataSource>

            </td>
        </tr>
    </table>

</asp:Content>
