using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
/// <summary>
/// Descripción breve de clsProveedor
/// </summary>
public class clsProveedor:clsconexion
{    //declarar las variables globales
    string tabla = "proveedor";
    protected string nombre,  numero_cuenta, direccion;
    protected int idproveedor;
    //costructor de la clase usuario
    public clsProveedor(int idproveedor,string nombre,string 
        numero_cuenta,string direccion)
        
    {
        this.idproveedor = idproveedor;
        this.nombre = nombre;
       
        this.numero_cuenta = numero_cuenta;
        this.direccion = direccion;
    }
    // metodos de la clase
    public int Idproveedor
    {
        set { idproveedor = value; }
        get { return idproveedor; }
    }

    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }

    }
   
    public string Numero_cuenta
    {
        set { numero_cuenta = value; }
        get { return numero_cuenta; }
    }
    public string Direccion
    {
        set { direccion = value; }
        get { return direccion; }
    }
    // metodos de manipulacion de datos

    //agragar registro a la basede datos
    public void agregar()
    {
        conectar(tabla);
        DataRow fila;
        fila = Data.Tables[tabla].NewRow();
        fila["idproveedor"] = Idproveedor;       
        fila["nombre"] = Nombre;
        fila["direccion"] = Direccion;
        fila["numero_cuenta"] = Numero_cuenta;            
         Data.Tables[tabla].Rows.Add(fila);
        AdaptadorDeDatos.Update(Data, tabla);

    }
    //  actualizar registros
    public void modificar()
    {
        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idproveedor"].ToString().Trim()) == Idproveedor)
            {
                fila["idproveedor"] = Idproveedor;
                fila["nombre"] = Nombre;
                fila["numero_cuenta"] = Numero_cuenta;               
                fila["direccion"] = Direccion;
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
            if (int.Parse(fila["idproveedor"].ToString().Trim()) == valor)
            {
                Idproveedor = int.Parse(fila["idproveedor"].ToString());             
                Nombre = fila["nombre"].ToString();
               
                Numero_cuenta = fila["numero_cuenta"].ToString();
                Direccion = fila["direccion"].ToString();                
                return true;

            }

        }
        // el objeto no existe
        return false;

    }
    // metodo eliminar registro
    public bool eliminar(int valor)
    {

        conectar(tabla);
        DataRow fila;
        int x = Data.Tables[tabla].Rows.Count - 1;
        for (int i = 0; i <= x; i++)
        {
            fila = Data.Tables[tabla].Rows[i];
            if (int.Parse(fila["idproveedor"].ToString().Trim()) == valor)
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
}