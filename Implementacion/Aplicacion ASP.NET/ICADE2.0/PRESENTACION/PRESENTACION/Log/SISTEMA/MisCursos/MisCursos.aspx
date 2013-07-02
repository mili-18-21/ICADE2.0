<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/ParticipanteGCU.master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.MisCursos.MisCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table style="margin-left:20px;" border="0">
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label0" 
                            runat="server" 
                            style="font-family: 'Eras Demi ITC'; 
                                   font-size: xx-large; 
                                   color: #1D1D1D" 
                            Text="Mis Cursos">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">



                <table border="0" style=" width: 100%;">
            <tr>
                <td align="center">
                    <table border="0" style=" width: 700px; height: 700px">
                        <tr>
                            
                            <td id="html">
                                
                                    <div id="example" class="k-content">
                                        <div class="k-widget k-grid" id="grid" style="height:630px;">
                                            <div class="k-toolbar k-grid-toolbar k-grid-top">
                                                <a class="k-button k-button-icontext k-grid-add" href="#">
                                                    <span class="k-icon k-add">
                                                    </span>
                                                    Comprar
                                                </a>
                                            </div>
                                            <div class="k-grid-header">
                                                
                                            </div>
                                            <div  style="height:560px">
                                                <table border="1" style="width:100%">
                                                    <tr>
                                                        <td >
                                                            <table>
                                                                <tr>
                                                                    <td style="width:100px">
                                                                        <asp:Label ID="Label4" runat="server" style="font-weight: 700; font-size: medium; color: #FFFFFF;" Text="DERECHO"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:GridView ID="GridView1" runat="server" HeaderStyle-CssClass="hiddencol"
                                                                            AutoGenerateColumns="False"
                                                                            GridLines="None"
                                                                            AllowPaging="true"
                                                                            CssClass="mGrid"
                                                                            PagerStyle-CssClass="pgr"
                                                                            AlternatingRowStyle-CssClass="alt" 
                                                                            onpageindexchanging="gvCustomres_PageIndexChanging" PageSize="10" 
                                                                            onrowcommand="gvCustomres_RowCommand">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                                                                            <Columns>
                                                                                <asp:BoundField DataField="IdDiplomado" ItemStyle-CssClass="hiddencol"  
                                                                                    HeaderText="IdDiplomado"  
                                                                                    InsertVisible="False" 
                                                                                    ReadOnly="True" 
                                                                                    SortExpression="IdDiplomado" >
                        
                                                <ItemStyle CssClass="hiddencol"></ItemStyle>
                                                                        </asp:BoundField>
                                                                                <asp:BoundField DataField="IdDiplomado" HeaderText="Descripcion" />
                                                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />

                                                                                <asp:TemplateField>
                                                                                    <ItemTemplate>
                                                                                        <asp:GridView ID="GridView2" 
                                                            runat="server" HeaderStyle-CssClass="hiddencol" 
                                                            AutoGenerateColumns="False" CssClass="mqGrid"  
                                                            DataKeyNames="IdSeminario" 
                                                            DataSourceID="SqlDataSource2">
                                                            <Columns>
                                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
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
                                                                                    </ItemTemplate>
                                                                                </asp:TemplateField>

                                                                            </Columns>

<HeaderStyle CssClass="hiddencol"></HeaderStyle>

<PagerStyle CssClass="pgr"></PagerStyle>
                                                                        </asp:GridView>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div class="k-pager-wrap k-grid-pager">
                                                <a class="k-link k-state-disabled" data-page="1" href="#" title="Ir a la primera página">
                                                    <span class="k-icon k-i-seek-w">
                                                        seek-w
                                                    </span>
                                                </a>
                                                <a class="k-link k-state-disabled" data-page="0" href="#" title="Ir a la página anterior">
                                                    <span class="k-icon k-i-arrow-w">
                                                        arrow-w
                                                    </span>
                                                </a>
                                                <ul class="k-pager-numbers k-reset">
                                                    <li>
                                                        <span class="k-state-selected" data-page="1">
                                                            1
                                                        </span>
                                                    </li>
                                                </ul>
                                                <a class="k-link k-state-disabled" data-page="2" href="#" title="Ir a la página siguiente">
                                                    <span class="k-icon k-i-arrow-e">
                                                        arrow-e
                                                    </span>
                                                </a>
                                                <a class="k-link k-state-disabled" data-page="1" href="#" title="Ir a la última página">
                                                    <span class="k-icon k-i-seek-e">
                                                        seek-e
                                                    </span>
                                                </a>
                                                <span class="k-pager-info k-label">
                                                    Mis cursos.
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                
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
