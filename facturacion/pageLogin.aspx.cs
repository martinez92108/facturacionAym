using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_inicio_Click(object sender, EventArgs e)
    {
        try
        {
            clsusuario usuario = new clsusuario(0, 0, "", "", "", "", "", "");
            if (usuario.login(txt_usuario.Text,txt_contra.Text))
            {
               
                lbl_estado.Text = "validacion exitosa";

                //validacion tipo d eusuario
                if (usuario.Id_tipo_usuario ==1)
                {
                    //menu administracion
                    Response.Redirect("~/Admin.aspx");

                }else if (usuario.Id_tipo_usuario == 2)
                {
                    // menu opciones limitadas
                    Response.Redirect("~/paginainicio");

                }
                else if (usuario.Id_tipo_usuario == 3)
                {
                    // menu opciones limitadas
                    Response.Redirect("~/paginainicio");

                }
            }
            else
            {
                lbl_estado.Text = "validacion fallida";
                txt_usuario.Focus();
            }

        }
        catch
        {

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            clsusuario usuario = new clsusuario(0, 0, "", "", "", "", "", "");
            if (usuario.login(txt_usuario1.Text, txt_password1.Text))
            {

                lbl_estado.Text = "validacion exitosa";

                //validacion tipo d eusuario
                if (usuario.Id_tipo_usuario == 1)
                {
                    //menu administracion
                    Response.Redirect("~/Admin.aspx");

                }
                else if (usuario.Id_tipo_usuario == 2)
                {
                    // menu opciones limitadas
                    Response.Redirect("~/paginainicio");

                }
                
            }
            else
            {
                lbl_estado.Text = "validacion fallida";
                txt_usuario.Focus();
            }

        }
        catch
        {

        }
    }
}