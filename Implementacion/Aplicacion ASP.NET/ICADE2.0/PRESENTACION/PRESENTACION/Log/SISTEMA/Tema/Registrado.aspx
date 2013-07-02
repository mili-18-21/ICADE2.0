<%@ Page Title="" Language="C#" MasterPageFile="~/PRESENTACION/PaginasMaestras/Log/MenuBody/AdministradorGTE.master" AutoEventWireup="true" CodeBehind="Registrado.aspx.cs" Inherits="PRESENTACION.PRESENTACION.Log.SISTEMA.Tema.Registrado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border="1" width="90%" style="margin-top:35px; background-color:white">
        <tr>
            <td align="right" style="width:70%">
                <asp:Label ID="Label1" runat="server" Text="¡El tema" 
                    style="font-size: large; color: #666666; font-family: Calibri"></asp:Label>
                <asp:Label ID="Label2" runat="server" Text="Gino Richard"
                    style="font-size: large; color: #1D1D1D; font-family: Calibri; font-weight: 700;"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="ha sido registrado exitosamente, clickea para continuar!" 
                    style="font-size: large; color: #666666; font-family: Calibri"></asp:Label>
            </td>
            <td align="left" style="width:30%">
                <div>
                    <div class="button_wrap">
                        <a class="button_aRight" id="A1"><span>Bienvenido a ICADE</span></a>
                        <a style="text-decoration:none" href="Buscar.aspx" class="button_bRight slidebttn" id="A2">Go <span>on</span></a>
                    </div>
                </div>
            </td>
        </tr>
    </table>

</asp:Content>
