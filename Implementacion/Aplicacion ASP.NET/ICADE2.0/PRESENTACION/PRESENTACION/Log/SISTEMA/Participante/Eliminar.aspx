<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/ParticipanteGPA.master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Participante.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" style="margin-left:50px;">
        <tr>
            <td valign="top" align="left">
                <table border="0">
                    <tr>
                        <td style="text-align: left">
                            <asp:Label ID="Label1" runat="server" 
                                style="font-family: 'Eras Demi ITC'; font-size: xx-large; color: #1D1D1D" 
                                Text="Cancelación de mi cuenta"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                        <asp:TextBox ID="TextBox1" runat="server" 
                                            style="font-family: Calibri; font-size: large" 
                                            Width="400px" Height="120px" TextMode="MultiLine"></asp:TextBox>
                                        <br />
                                    </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                                                                    <asp:Button ID="Button1_enviarsolicitud" runat="server" CssClass="boton" Text="Enviar solicitud"  />
                                                                </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>

</asp:Content>
