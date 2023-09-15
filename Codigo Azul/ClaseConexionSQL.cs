using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

public class ClassConexionSQL
{

    public SqlConnection conexion;

    public bool Conectar()
    {
        try
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();
            }
            return true;
        }
        catch (SqlException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    MessageBox.Show("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }

    public bool Desconectar()
    {
        try
        {
            conexion.Close();
            return true;
        }
        catch (SqlException ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }

    public bool CrearConexion(string BaseDatos)
    {
        try
        {
            string strConexion = String.Format("Server=localhost;Database={0}; integrated security = true", BaseDatos);
            conexion = new SqlConnection(strConexion);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool LLenarGrid(ref DataGridView grid, string Consulta)
    {
        try
        {
            // Se abre la conexion
            if (this.Conectar())
            {
                // Se crea un MySqlAdapter para obtener los datos de la base
                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(Consulta, conexion);

                //crea un datatable
                DataTable dtDatos = new DataTable();

                // Con la información del adaptador se rellena el DataTable
                adaptadorDatos.Fill(dtDatos);

                //se asigna el contenido del datatable a la grilla

                grid.DataSource = dtDatos;
                
                // Se cierra la conexión a la base de datos
                this.Desconectar();

                return true;
            }
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }

    public DataRow ObtenerData(String Consulta)
    {
        try
        {
            // Se abre la conexion
            if (this.Conectar())
            {
                // Se crea un MySqlAdapter para obtener los datos de la base
                SqlDataAdapter adaptadorDatos = new SqlDataAdapter(Consulta, conexion);

                //crea un datatable
                DataTable dtDatos = new DataTable();

                adaptadorDatos.Fill(dtDatos);

                // Se cierra la conexión a la base de datos
                this.Desconectar();

                return dtDatos.Rows[0];
            }
            else
            {
                return null;
            }
        }
        catch
        {
            return null;
        }
    }
    public void EjecutarComandoSQL(string sql)
    {
        if (this.Conectar())
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.ExecuteNonQuery();
            this.Desconectar();
        }
    }

  
}
