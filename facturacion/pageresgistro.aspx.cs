using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pageresgistro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void GUIEdicion()
    {
        txt_cedula.Enabled = true;
        txt_nombre.Enabled = true;
        txt_apellido.Enabled = true;
        txt_direccion.Enabled = true;
        txt_celular.Enabled = true;
        txt_usuario.Enabled = true;
        txt_password.Enabled = true;
        rbtipo_usuario.Enabled = true;
        lbl_estado.Text = "";
        
        btn_eliminar.Enabled = false;
       
        btn_modificar.Enabled = false;


    }

    public void GUILimpiar()
    {
        txt_cedula.Text = "";
        txt_nombre.Text = "";
        txt_apellido.Text = "";
        txt_celular.Text = "";
        txt_direccion.Text = "";
        txt_usuario.Text = "";
        txt_password.Text = "";
        txt_password.Attributes.Add("Value", "");
        rbtipo_usuario.ClearSelection();

    }
    public void GUIEdicionTerminada()
    {
        txt_buscar.Enabled = true;
        txt_cedula.Enabled = false;
        txt_nombre.Enabled = false;
        txt_apellido.Enabled = false;
        txt_direccion.Enabled = false;
        txt_celular.Enabled = false;
        txt_usuario.Enabled = false;
        txt_password.Enabled = false;
        rbtipo_usuario.Enabled = false;
        lbl_estado.Text = "";
        btn_nuevo.Text = "Nuevo";

        btn_modificar.Enabled = true;
        btn_eliminar.Enabled = true;



    }



    protected void btn_nuevo_Click(object sender, EventArgs e)
    {
        if (btn_nuevo.Text == "Nuevo")
        {
            GUIEdicion();
            GUILimpiar();
            btn_nuevo.Text = "Guardar";
        }
        else if (btn_nuevo.Text == "Guardar")
        {  
            try
            {
                clsusuario usuario = new clsusuario(0, 0, "", "", "", "", "", "");
                if (usuario.existe(int.Parse(txt_cedula.Text.Trim())))
                {
                    usuario.Idusuario = int.Parse(txt_cedula.Text);
                    usuario.Id_tipo_usuario = int.Parse(rbtipo_usuario.SelectedValue);
                    usuario.Nombre = txt_nombre.Text;
                    usuario.Apellido = txt_apellido.Text;
                    usuario.Celular = txt_celular.Text;
                    usuario.Direccion = txt_direccion.Text;
                    usuario.Usuario = txt_usuario.Text;
                    usuario.Password = txt_password.Text;
                    usuario.modificar();
                    GUIEdicionTerminada();
                    lbl_estado.Text = "Usuario Modificado con exito";
                    btn_nuevo.Text = "Nuevo";
                }
                else
                {
                    usuario.Idusuario = int.Parse(txt_cedula.Text);
                    usuario.Id_tipo_usuario = int.Parse(rbtipo_usuario.SelectedValue);
                    usuario.Nombre = txt_nombre.Text;
                    usuario.Apellido = txt_apellido.Text;
                    usuario.Celular = txt_celular.Text;
                    usuario.Direccion = txt_direccion.Text;
                    usuario.Usuario = txt_usuario.Text;
                    usuario.Password = txt_password.Text;

                    usuario.agregar();

                    GUIEdicionTerminada();
                    lbl_estado.Text = "Nuevo registro guardado";
                    btn_nuevo.Text = "Nuevo";
                }

            }
            catch
            {
                lbl_estado.Text = "No debe dejar espacion en blanco";
            }
            
            
        }
        


    }

    protected void btn_modificar_Click(object sender, EventArgs e)
    {
       if(btn_nuevo.Text == "Nuevo")
        {
            GUIEdicion();
            btn_nuevo.Text = "Guardar";
        }
       
    }

    protected void btn_eliminar_Click(object sender, EventArgs e)
    {
        try
        {
            clsusuario usuario = new clsusuario(0, 0, "", "", "", "", "", "");
            usuario.eliminar(int.Parse(txt_cedula.Text));

            lbl_estado.Text = "usuario eliminado con exito";


        }
        catch
        {
            lbl_estado.Text = "No hay conexion con la base de datos";
        }



    }

    protected void btn_buscar_Click(object sender, EventArgs e)
    {
        try
        {
            clsusuario usuario = new clsusuario(0, 0, "", "", "", "", "", "");
            if (usuario.existe(int.Parse(txt_buscar.Text.Trim())))
            {
                txt_cedula.Text = usuario.Idusuario.ToString();
                txt_nombre.Text = usuario.Nombre;
                txt_apellido.Text = usuario.Apellido;
                txt_celular.Text = usuario.Celular;
                txt_direccion.Text = usuario.Direccion;
                txt_usuario.Text = usuario.Usuario;
                //txt_password.Text = usuario.Password;
                txt_password.Attributes.Add("Value", usuario.Password);
                rbtipo_usuario.SelectedIndex = rbtipo_usuario.Items.IndexOf(rbtipo_usuario.Items.FindByValue(usuario.Id_tipo_usuario.ToString()));
                lbl_estado.Text = "Registro";
            }
            else
            {
                lbl_estado.Text = "no existe el registro";
            }

        }
        catch
        {
            lbl_estado.Text = "no existe un patrono de busqueda";
        }


      

    }

    protected void btn_cancelar_Click(object sender, EventArgs e)
    {
        GUIEdicionTerminada();
    }
}