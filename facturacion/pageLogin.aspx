<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLogin.master" AutoEventWireup="true" CodeFile="pageLogin.aspx.cs" Inherits="pageLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form1"  runat="server" style="margin:80px; width: 918px; height: 117px" >
       <!--
        <p>
            <br />
            <table style="width: 99%; height: 150px">
                <tr>
                    <td rowspan="7" style="width: 259px">
                        <img alt="" src="images/login/login.png" style="width: 257px; height: 177px" /></td>
                    <td style="height: 24px; width: 167px"></td>
                    <td style="width: 469px; height: 24px">Iniciar sesion</td>
                </tr>
                <tr>
                    <td style="width: 150px; height: 16px">Usuario</td>
                    <td style="width: 250px; height: 16px;">
                        <asp:TextBox ID="txt_usuario" runat="server" Width="227px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 16px">Contraseña</td>
                    <td style="width: 469px; height: 16px">
                        <asp:TextBox ID="txt_contra" runat="server" Width="229px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 17px"></td>
                    <td style="width: 469px; height: 17px">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Recordar " />
                    </td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 4px"></td>
                    <td style="width: 469px; height: 4px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 167px; height: 17px"></td>
                    <td style="width: 469px; height: 17px; margin-left: 120px">
                        <asp:Button ID="btn_inicio" runat="server" Text="Inicio de Sesion" Width="111px" OnClick="btn_inicio_Click" />
                        <asp:HyperLink ID="lkn_registro" runat="server" NavigateUrl="~/pageresgistro.aspx">Registrar</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td style="height: 17px" colspan="2">
                        <h1>
                        <asp:Label ID="lbl_estado" runat="server" Text="Label"></asp:Label>
                    </h1>
                     </td>
                </tr>
            </table>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
        <p>
        </p>
    -->
     <link href="Content/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
         <div class="form-group">
    <label for="exampleInputEmail1">Usuario</label>
   <!-- <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email"> -->
    <asp:TextBox ID="txt_usuario1" runat="server" placeholder="Ingrese su Usuario" class="form-control" Width="600px"></asp:TextBox>
    
  </div>

 <div class="form-group">
    <label for="exampleInputPassword1">Contraseña</label>
    <!--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">-->
    <asp:TextBox ID="txt_password1" runat="server" placeholder="Ingrese su Contraseña" class="form-control" Width="600px" TextMode="Password"></asp:TextBox>
 </div>
 
        <asp:Button ID="Button1" runat="server" Text="Iniciar" class="btn btn-primary" OnClick="Button1_Click" Width="74px" />
   <!--<button type="submit" class="btn btn-primary">Submit</button> -->

    </form>
      
   
   
   
    

</asp:Content>

