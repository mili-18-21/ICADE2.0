<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGTE.master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Tema.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="0" width="100%" style="margin-top:35px; background-color:white">
        <tr>
            <td align="right" style="width:70%">
                <asp:Label ID="Label1" runat="server" Text="¿Realmente deseas eliminar el tema" 
                    style="font-size: large; color: #666666; font-family: Calibri"></asp:Label>
                <asp:Label ID="Label2" runat="server"
                    style="font-size: large; color: #1D1D1D; font-family: Calibri; font-weight: 700;"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="?" 
                    style="font-size: large; color: #666666; font-family: Calibri"></asp:Label>
                <asp:Button ID="Button1_eliminar" runat="server" BackColor="#0066FF" BorderColor="#0066FF" BorderStyle="Dotted" style="font-family: Calibri; font-size: large; color: #FFFFFF" Text="Confirmar" Width="151px" />
            </td>
            <td align="left" style="width:30%">
                <div>
                    <div class="button_wrap">
                        <a class="button_aRight" id="A1"><span>Eliminar PROFESION</span></a>
                        <a style="text-decoration:none" href="#" class="button_bRight slidebttn" id="A2">Go <span>on</span></a>
                    </div>
                </div>
            </td>
        </tr>
    </table>

</asp:Content>
