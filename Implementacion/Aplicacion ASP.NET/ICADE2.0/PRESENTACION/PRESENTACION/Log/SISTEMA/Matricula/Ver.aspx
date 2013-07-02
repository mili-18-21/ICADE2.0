<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/ParticipanteRMA.master" AutoEventWireup="true" CodeBehind="Ver.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Matricula.Ver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="margin-left:20px;" border="0">
        <tr>
            <td style="text-align: left">
                <asp:Label ID="Label0" 
                            runat="server" 
                            style="font-family: 'Eras Demi ITC'; 
                                   font-size: xx-large; 
                                   color: #1D1D1D" 
                            Text="Ver detalles">
                </asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">



                <table border="0" style=" width: 100%;">
            <tr>
                <td align="center">
                    <table border="0" style=" width: 700px; height: 800px">
                        <tr>
                            
                            <td id="html">
                                
                                    <div id="example" class="k-content">
                                        <div class="k-widget k-grid" id="grid" style="height:730px;">
                                            <div class="k-toolbar k-grid-toolbar k-grid-top">
                                                <a class="k-button k-button-icontext k-grid-add" href="#">
                                                    <span class="k-icon k-add">
                                                    </span>
                                                    Comprar
                                                </a>
                                            </div>
                                            <div class="k-grid-header">
                                                
                                            </div>
                                            <div  style="height:660px">
                                                <table border="1" style="width:100%">
                                                    <tr>
                                                        <td >
                                                            <asp:Label ID="Label1" runat="server" Text="DESCRIPCION DEL DIPLOMADO:" style="font-weight: 700; font-size: medium; color: #0066FF;"></asp:Label>
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td style="width:100px">
                                                                        <asp:Label ID="Label3" runat="server" style="font-weight: 700; font-size: medium; color: #FFFFFF;" Text="DERECHO"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label5" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="DERECHO PROCESAL PENAL AQAQAQ AQ AQAQ AQAQAQ AQAQAQA QA QA Q AQAQAQ AQAQ AQAQ"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br />
                                                            <asp:Label ID="Label2" runat="server" Text="LISTA DE SEMINARIOS:" style="font-weight: 700; font-size: medium; color: #0066FF;"></asp:Label>
                                                            <br />
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
                                                                            onpageindexchanging="gvCustomres_PageIndexChanging" PageSize="5" 
                                                                            onrowcommand="gvCustomres_RowCommand" OnRowDataBound="GridView1_RowDataBound">
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>
                                                                            <Columns>
                                                                                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                                                                            </Columns>

<HeaderStyle CssClass="hiddencol"></HeaderStyle>

<PagerStyle CssClass="pgr"></PagerStyle>
                                                                        </asp:GridView>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label6" runat="server" Text="COSTO DE MATRICULA:" style="font-weight: 700; font-size: medium; color: #0066FF;"></asp:Label>
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td style="width:100px">
                                                                        <asp:Label ID="Label7" runat="server" style="font-weight: 700; font-size: medium; color: #FFFFFF;" Text="DERECHO"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label9" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="S/."></asp:Label>
                                                                        <asp:Label ID="Label8" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="HOO"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br />
                                                            <asp:Label ID="Label10" runat="server" Text="MENSUALIDAD:" style="font-weight: 700; font-size: medium; color: #0066FF;"></asp:Label>
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td style="width:100px">
                                                                        <asp:Label ID="Label11" runat="server" style="font-weight: 700; font-size: medium; color: #FFFFFF;" Text="DERECHO"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label12" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="S/."></asp:Label>
                                                                        <asp:Label ID="Label13" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="HOO"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br />
                                                            <asp:Label ID="Label14" runat="server" Text="N° DE CUOTAS:" style="font-weight: 700; font-size: medium; color: #0066FF;"></asp:Label>
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td style="width:100px">
                                                                        <asp:Label ID="Label15" runat="server" style="font-weight: 700; font-size: medium; color: #FFFFFF;" Text="DERECHO"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label16" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="S/."></asp:Label>
                                                                        <asp:Label ID="Label17" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text=" CUOTAS"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br />
                                                            <asp:Label ID="Label18" runat="server" Text="HORAS ACADEMICAS:" style="font-weight: 700; font-size: medium; color: #0066FF;"></asp:Label>
                                                            <br />
                                                            <table>
                                                                <tr>
                                                                    <td style="width:100px">
                                                                        <asp:Label ID="Label19" runat="server" style="font-weight: 700; font-size: medium; color: #FFFFFF;" Text="DERECHO"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label20" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text="S/."></asp:Label>
                                                                        <asp:Label ID="Label21" runat="server" style="font-weight: 700; font-size: medium; color: #333333;" Text=" HRS"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                            <br />
                                                                    </td>
                                                                    <td>
                                                                        <img src="../../../../Imagenes/Ver/icade.png" style="width:400px"/>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                            <div class="k-pager-wrap k-grid-pager">
                                                <a class="k-link k-state-disabled" data-page="1" href="#" title="Ir al primer diplomado">
                                                    <span class="k-icon k-i-seek-w">
                                                        seek-w
                                                    </span>
                                                </a>
                                                <a class="k-link k-state-disabled" data-page="0" href="#" title="Ir al diplomado anterior">
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
                                                <a class="k-link k-state-disabled" data-page="2" href="#" title="Ir al siguiente diplomado">
                                                    <span class="k-icon k-i-arrow-e">
                                                        arrow-e
                                                    </span>
                                                </a>
                                                <a class="k-link k-state-disabled" data-page="1" href="#" title="Ir al ultimo diplomado">
                                                    <span class="k-icon k-i-seek-e">
                                                        seek-e
                                                    </span>
                                                </a>
                                                <span class="k-pager-info k-label">
                                                    Detalles del producto.
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="Button1_Comprar" runat="server" CssClass="boton" Text="Comprar" OnClick="Button1_Comprar_Click" />
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
