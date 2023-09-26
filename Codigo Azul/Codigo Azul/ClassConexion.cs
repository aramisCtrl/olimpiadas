using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.IO;
using System.Xml;



public class ClassConexionSQL
{

	public SqlConnection conexion;
	public string AreaPuesto;
	public string UrlMetabase;

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

	public bool CrearConexionOLD(string BaseDatos)
	{
		try
		{
//			string strConexion = String.Format("Server=localhost;Database={0}; integrated security = true", BaseDatos);
			string strConexion = String.Format("Data Source=localhost;Initial Catalog= codigo_azul; User id=sa;Password=123456", BaseDatos);
			conexion = new SqlConnection(strConexion);
			return true;
		}
		catch
		{
			return false;
		}
	}
	
	public bool CrearConexion()
	{
		try
		{
			// Obtener el directorio actual de la aplicación
			string directorioActual = AppDomain.CurrentDomain.BaseDirectory;

			// Combinar la ruta del directorio actual con el nombre del archivo config.xml
			string rutaConfigXml = Path.Combine(directorioActual, "config.xml");

			// Verificar si el archivo config.xml existe
			if (!File.Exists(rutaConfigXml))
			{
				MessageBox.Show("El archivo config.xml no se encontró en el directorio de la aplicación.");
				return false;
			}

			// Cargar la configuración desde el archivo XML
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(rutaConfigXml);

			string server = xmlDoc.SelectSingleNode("/Config/Server").InnerText;
			string database = xmlDoc.SelectSingleNode("/Config/Database").InnerText;
			string username = xmlDoc.SelectSingleNode("/Config/Username").InnerText;
			string password = xmlDoc.SelectSingleNode("/Config/Password").InnerText;
			AreaPuesto = xmlDoc.SelectSingleNode("/Config/AreaPuesto").InnerText;
			UrlMetabase = xmlDoc.SelectSingleNode("/Config/Url").InnerText;			

			// Construir la cadena de conexión
			string strConexion = "Data Source=" + server + ";Initial Catalog=" + database + ";User ID=" + username + ";Password=" + password;

			conexion = new SqlConnection(strConexion);
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error al crear la conexión: " + ex.Message);
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
	
	public bool ValidarUsuario(string nombreUsuario, string contraseña){
		try
		{
			string query = "EXEC sp_ValidarUsuario @NombreUsuario, @Contraseña";
			using (SqlCommand cmd = new SqlCommand(query, conexion))
			{
				cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
				cmd.Parameters.AddWithValue("@Contraseña", contraseña);
				
				conexion.Open();
				int resultado = (int)cmd.ExecuteScalar();
				conexion.Close();
				
				return resultado != 0;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error al validar usuario: " + ex.Message);
			return false;
		}
	}
	
	
	public DataSet EjecutarSentencia(string consulta)
	{
		try
		{
			if (this.Conectar())
			{
				// Se crea un SqlDataAdapter para obtener los datos de la base
				SqlDataAdapter adaptadorDatos = new SqlDataAdapter(consulta, conexion);

				// Se crea un DataSet para almacenar el resultado de la consulta
				DataSet dsResultado = new DataSet();

				// Llena el DataSet con los datos obtenidos de la consulta
				adaptadorDatos.Fill(dsResultado);

				// Cierra la conexión a la base de datos
				this.Desconectar();

				return dsResultado;
			}
			else
			{
				return null;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show("Error al ejecutar sentencia: " + ex.Message);
			return null;
		}
	}

}
