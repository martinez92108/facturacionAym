using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



/// <summary>
/// clse del objeto empleado
/// </summary>
public class clsusuario: clsconexion
{
    //declarar las variables globales
    string tabla = "usuario";
    protected string nombre, apellido, celular, direccion, usuario, password; 
    protected int idusuario, id_tipo_usuario;
    //costructor de la clase usuario
    public clsusuario(int idusuario, int id_tipo_usuario, string nombre,string apellido, 
        string celular, string direccion, string usuario,string password)
    {
        this.idusuario = idusuario;
        this.id_tipo_usuario = id_tipo_usuario;
        this.nombre = nombre;
        this.apellido = apellido;
        this.celular = celular;
        this.direccion = direccion;
        this.usuario = usuario;
        this.password = password;
                     
    }

    // metodos de la clase

    public int Idusuario
    {
        set { idusuario = value; }
        get { return idusuario; }

    }
    public int Id_tipo_usuario
    {
        set { id_tipo_usuario = value; }
        get { return id_tipo_usuario; }
    }
    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public string Apellido
    {
        set { apellido = value; }
        get { return apellido; }
    }
    public string Celular
    {
        set { celular = value; }
        get { return celular; }
    }
    public string Direccion
    {
        set { direccion = value; }
        get { return direccion; }
    }
    public string Usuario
    {
        set { usuario = value; }
        get { return usuario; }
    }
    public string Password
    {
        set { password = value; }
        get { return password; }
    }
    // metodos de manipulacion de datos

        //agragar registro a la basede datos
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["idusuario"] = Idusuario;
        fila["id_tipo_usuario"] = Id_tipo_usuario;
        fila["nombre"] = Nombre;
        fila["apellido"] = Apellido;
        fila["celular"] = Celular;
        fila["direccion"] = Direccion;
        fila["usuario"] = Usuario;
        fila["password"] = Password;
        Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDeDatos.Update(Data, tabla);

    }
    //  actualizar registros
    public void modificar()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i=0; i<=x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if(int.Parse(fila["idusuario"].ToString().Trim())== Idusuario)
            {
                fila["idusuario"] = Idusuario;
                fila["id_tipo_usuario"] = Id_tipo_usuario;
                fila["nombre"] = Nombre;
                fila["apellido"] = Apellido;
                fila["celular"] = Celular;
                fila["direccion"] = Direccion;
                fila["usuario"] = Usuario;
                fila["password"] = Password;
                AdaptadorDeDatos.Update(Data, tabla);

            }
        }
    }
    // verifica si existe el registro
    public bool existe(int valor)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idusuario"].ToString().Trim()) == valor)
            {
                 Idusuario = int.Parse(fila["idusuario"].ToString());
                Id_tipo_usuario = int.Parse(fila["id_tipo_usuario"].ToString());
                Nombre = fila["nombre"].ToString() ;
                Apellido =  fila["apellido"].ToString() ;
                Celular = fila["celular"].ToString() ;
                Direccion = fila["direccion"].ToString() ;
                Usuario = fila["usuario"].ToString();
                Password =  fila["password"].ToString();
                return true;

            }

        }
        // el objeto no existe
        return false;

    }

    // metodo eliminar registro
    public bool eliminar (int valor)
    {

        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idusuario"].ToString().Trim()) == valor)
            {
                fila = Data.Tables[tabla].Rows[i];
                fila.Delete();
                DataTable tablaborrados;
                tablaborrados = Data.Tables[tabla].GetChanges(DataRowState.Deleted);
                AdaptadorDeDatos.Update(tablaborrados);
                Data.Tables[tabla].AcceptChanges();
                return true;

            }

        }
        // el objeto no existe
        return false;

    }
    public bool login(string user, string pass)
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (fila["usuario"].ToString().Trim().ToLower() == user.Trim().ToLower() &&
                fila["password"].ToString().Trim()== pass.Trim())
            {
                Idusuario = int.Parse(fila["idusuario"].ToString());
                Id_tipo_usuario = int.Parse(fila["id_tipo_usuario"].ToString());
                Nombre = fila["nombre"].ToString();
                Apellido = fila["apellido"].ToString();
                Celular = fila["celular"].ToString();
                Direccion = fila["direccion"].ToString();
                Usuario = fila["usuario"].ToString();
                Password = fila["password"].ToString();
                return true;

            }          

        }
        // el objeto no existe
        return false;
    }
    //cargar grid view
    public void CargarDatos()
    {
        conectar(tabla);
        DataRow fila;

    }


}