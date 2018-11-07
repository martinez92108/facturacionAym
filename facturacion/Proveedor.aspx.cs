using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Proveedor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void GUIEdicion()
    {
        txt_nit.Enabled = true;
        txt_nombre.Enabled = true;       
        txt_direccion.Enabled = true;
        txt_num_cuenta.Enabled = true;        
        lbl_estado.Text = "";
        btn_eliminar.Enabled = false;
        btn_modificar.Enabled = false;


    }

    public void GUILimpiar()
    {
      txt_nit.Text = "";
        txt_nombre.Text = "";
       
        txt_direccion.Text = "";
       txt_num_cuenta.Text = "";
       

    }
    public void GUIEdicionTerminada()
    {
        txt_buscar.Enabled = true;
        txt_nit.Enabled = false;
        txt_nombre.Enabled = false;
        
        txt_direccion.Enabled = false;
        txt_num_cuenta.Enabled = false;
       
        lbl_estado.Text = "";
        btn_nuevo.Text = "Nuevo";

        btn_modificar.Enabled = true;
        btn_eliminar.Enabled = true;



    }
    public void actualizar()
    {
        btn_nuevo.Enabled = false;
        btn_eliminar.Enabled = false;
        txt_nombre.Enabled = true;
        txt_direccion.Enabled = true;
        txt_num_cuenta.Enabled = true;

    }
    public void actualizacionterminada()
    {
        txt_nit.Enabled = false;
        txt_nombre.Enabled = false;
        txt_direccion.Enabled = false;
        txt_num_cuenta.Enabled = false;
        btn_nuevo.Enabled = true;
        btn_eliminar.Enabled = true;

    }
    public void verificacionusuario()
    {
        txt_buscar.Enabled = true;
        txt_nit.Enabled = false;
        txt_nombre.Enabled = false;
        txt_direccion.Enabled = false;
        txt_num_cuenta.Enabled = false;
        lbl_estado.Text = "";

        btn_nuevo.Text = "Nuevo";
        btn_modificar.Enabled = true;
        btn_eliminar.Enabled = true;

    }
    public void cancelar()
    {
        txt_buscar.Enabled = true;
        txt_nit.Enabled = false;
        txt_nombre.Enabled = false;
        txt_direccion.Enabled = false;
        txt_num_cuenta.Enabled = false;
        lbl_estado.Text = "";
        btn_nuevo.Text = "Nuevo";
        btn_modificar.Text = "Actualizar";
        btn_modificar.Enabled = true;
        btn_eliminar.Enabled = true;
        btn_nuevo.Enabled = true;

    }


    protected void Button1_Click(object sender, EventArgs e)
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
            clsProveedor proveedor = new clsProveedor(0,"","","");
                if (proveedor.existe(int.Parse(txt_nit.Text.Trim())))
                {
                    //proveedor.Idproveedor = int.Parse(txt_nit.Text);                    
                    //proveedor.Nombre = txt_nombre.Text;
                    //proveedor.Direccion = txt_direccion.Text;
                    //proveedor.Numero_cuenta = txt_num_cuenta.Text;                    
                    //proveedor.modificar();
                    //GUIEdicionTerminada();
                    //lbl_estado.Text = "Usuario Modificado con exito";
                    //btn_nuevo.Text = "Nuevo";
                    verificacionusuario();
                    lbl_estado.Text = "el usuario ya esta registrado ";
                   
                }
                else
                {
                    proveedor.Idproveedor = int.Parse(txt_nit.Text);
                    proveedor.Nombre = txt_nombre.Text;
                    proveedor.Direccion = txt_direccion.Text;
                    proveedor.Numero_cuenta = txt_num_cuenta.Text;                 
                    proveedor.agregar();
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
        if (btn_modificar.Text == "Actualizar")
        {
            actualizar();
            btn_modificar.Text = "Guardar";
        }
        else if (btn_modificar.Text == "Guardar")
        {
            try
            {
                clsProveedor proveedor = new clsProveedor(0, "", "", "");
                if (proveedor.existe(int.Parse(txt_nit.Text.Trim())))
                {
                    proveedor.Idproveedor = int.Parse(txt_nit.Text);
                    proveedor.Nombre = txt_nombre.Text;
                    proveedor.Direccion = txt_direccion.Text;
                    proveedor.Numero_cuenta = txt_num_cuenta.Text;
                    proveedor.modificar();
                    actualizacionterminada();
                    GUILimpiar();

                    lbl_estado.Text = "Proveedor actualizado con exito";
                    btn_modificar.Text = "Actualizar";
                    
                }
                else
                {
                    lbl_estado.Text = "Error al conectar a la base de datos";
                }

            }
            catch
            {
                lbl_estado.Text = "No debe dejar espacion en blanco";
            }


        }

    }

    protected void btn_eliminar_Click(object sender, EventArgs e)
    {
        try
        {
            clsProveedor proveedor = new clsProveedor(0, "", "", "");
            proveedor.eliminar(int.Parse(txt_nit.Text));
            lbl_estado.Text = "proveedor  eliminado con exito";


        }
        catch
        {
            lbl_estado.Text = "No hay conexion con la base de datos";
        }
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        try
        {
            clsProveedor proveedor = new clsProveedor(0, "", "", "");
            if (proveedor.existe(int.Parse(txt_buscar.Text.Trim())))
            {
               txt_nit.Text = proveedor.Idproveedor.ToString();
                txt_nombre.Text = proveedor.Nombre;
                txt_direccion.Text = proveedor.Direccion;
                txt_num_cuenta.Text = proveedor.Numero_cuenta;
               
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
        GUILimpiar();
        cancelar();

    }
}