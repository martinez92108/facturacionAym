<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="Proveedor.aspx.cs" Inherits="Proveedor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <form id="form1" runat="server">
        <table style="width: 100%">
            <tr>
                <td style="width: 31%">
                    <asp:TextBox ID="txt_buscar" runat="server"></asp:TextBox>
                    <asp:Button ID="Button5" runat="server" Text="Buscar" OnClick="Button5_Click" />
                </td>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registro Proveedores</td>
            </tr>
            <tr>
                <td rowspan="6" style="width: 31%">
                    <img alt="" src="images/proveedor/proveedor.jpg" style="width: 235px; height: 180px" /></td>
                <td style="width: 117px">Nit</td>
                <td style="width: 54%">
                    <asp:TextBox ID="txt_nit" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 117px">Nombre</td>
                <td style="width: 54%">
                    <asp:TextBox ID="txt_nombre" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 117px">Direccion</td>
                <td style="width: 54%">
                    <asp:TextBox ID="txt_direccion" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 117px">Numero de cuneta</td>
                <td style="width: 54%">
                    <asp:TextBox ID="txt_num_cuenta" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 117px">
                  <h1>  <asp:Label ID="lbl_estado" runat="server" ForeColor="Red"></asp:Label> </h1>
                </td>
                <td style="width: 54%">
                    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="Button1_Click" style="height: 26px" />
                    <asp:Button ID="btn_modificar" runat="server" Text="Actualizar" OnClick="btn_modificar_Click" />
                    <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" OnClick="btn_eliminar_Click" />
                    <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />
                </td>
            </tr>
            <tr>
                <td style="width: 117px; height: 54px;">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin.aspx">Regresar</asp:HyperLink>
                </td>
                <td style="width: 54%; height: 54px;"></td>
            </tr>
        </table>
    </form>

</asp:Content>

