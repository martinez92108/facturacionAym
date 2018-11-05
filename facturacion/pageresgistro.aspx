<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="pageresgistro.aspx.cs" Inherits="pageresgistro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1" runat="server">
        <table style="width: 100%">
            <tr>
                <td style="width: 255px">
                    <asp:TextBox ID="txt_buscar" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_buscar" runat="server" Text="Buscar" OnClick="btn_buscar_Click" />
                </td>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registar Usuarios</td>
            </tr>
            <tr>
                <td style="width: 255px">&nbsp;</td>
                <td style="width: 196px; height: 25px">cedula </td>
                <td style="height: 25px">
                    <asp:TextBox ID="txt_cedula" runat="server" Width="178px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td rowspan="6" style="width: 255px">
                    <img alt="" src="images/usuario/usuario.jpg" style="width: 245px; height: 174px" /></td>
                <td style="width: 196px">Nombre</td>
                <td>
                    <asp:TextBox ID="txt_nombre" runat="server" Width="178px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 196px">Apellido</td>
                <td>
                    <asp:TextBox ID="txt_apellido" runat="server" Width="178px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 196px">Celular</td>
                <td>
                    <asp:TextBox ID="txt_celular" runat="server" Width="178px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 196px">Direccion</td>
                <td>
                    <asp:TextBox ID="txt_direccion" runat="server" Width="178px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 196px">Usuario</td>
                <td>
                    <asp:TextBox ID="txt_usuario" runat="server" Width="178px" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 196px">Contraseña</td>
                <td>
                    <asp:TextBox ID="txt_password" runat="server" Width="178px" Enabled="False" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 255px" rowspan="2">&nbsp;</td>
                <td style="width: 196px">Tipo de Usuario</td>
                <td>
                    <asp:RadioButtonList ID="rbtipo_usuario" runat="server" DataSourceID="SqlDataSourceNivelAcceso" DataTextField="descripcion" DataValueField="id_tipo_usuario" Enabled="False" Width="284px">
                        <asp:ListItem Value="1">nivel 1</asp:ListItem>
                        <asp:ListItem Value="2">nivel 2</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:SqlDataSource ID="SqlDataSourceNivelAcceso" runat="server" ConnectionString="<%$ ConnectionStrings:FacturacionConnectionString %>" SelectCommand="SELECT * FROM [tipo_usuario]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 196px; height: 63px;">
                    <h1>
                        <asp:Label ID="lbl_estado" runat="server" Text="Label"></asp:Label>
                    </h1>
                    <p>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/pageLogin.aspx">Regresar</asp:HyperLink>
                    </p>
                </td>
                <td style="height: 63px">
                    
                    <asp:Button ID="btn_nuevo" runat="server" Text="Nuevo" OnClick="btn_nuevo_Click" />
                    
                    <asp:Button ID="btn_modificar" runat="server" Text="Modificar" OnClick="btn_modificar_Click" />
                    <asp:Button ID="btn_eliminar" runat="server" Text="eliminar" OnClick="btn_eliminar_Click" />
                    <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />
                </td>
            </tr>
            </table>
    </form>
</asp:Content>

