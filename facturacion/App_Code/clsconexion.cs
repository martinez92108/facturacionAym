using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;



/// <summary>
/// clase de conexion del proyecto
/// </summary>
public class clsconexion
{
    protected SqlDataAdapter AdaptadorDeDatos;
    protected SqlDataReader reader;
    protected DataSet data;
    protected SqlConnection oconexion = new SqlConnection();

    public clsconexion()
    {

        
    }
    public void conectar(string tabla)
    {
        string strConexion = ConfigurationManager.ConnectionStrings["FacturacionConnectionString"].ConnectionString;
        oconexion.ConnectionString = strConexion;
        oconexion.Open();
        AdaptadorDeDatos = new SqlDataAdapter("select * from "+tabla,oconexion);
        SqlCommandBuilder ejecutacomandos = new SqlCommandBuilder(AdaptadorDeDatos);
        Data = new DataSet();
        AdaptadorDeDatos.Fill(Data, tabla);
        oconexion.Close();

    }
    public DataSet Data
    {
        set { data = value; }
        get { return data; }
    }
    public SqlDataReader DataReder
    {
        set { reader = value; }
        get { return reader; }
    }
}