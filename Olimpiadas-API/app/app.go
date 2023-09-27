package app

import (
	"database/sql"
	"encoding/json"
	"fmt"
	"net/http"
	"time"
)

// Estructuras de datos para Usuarios y Artículos
type Usuario struct {
	Nombre     string `json:"nombre"`
	Contraseña string `json:"contraseña"`
}

type Articulo struct {
	Nombre      string  `json:"nombre"`
	Precio      float64 `json:"precio"`
	Descripcion string  `json:"descripcion"`
	Habilitado  bool    `json:"habilitado"`
}

type Credenciales struct {
	UsuarioID  int    `json:"usuario_id"`
	Usuario    string `json:"usuario"`
	Contraseña string `json:"contraseña"`
}
type Suceso struct {
	PacienteNombre string    `json:"PacienteNombre"`
	PacienteID     string    `json:"PacienteID"`
	Descripcion    string    `json:"Descripcion"`
	Suceso         string    `json:"Suceso"`
	Area           string    `json:"Area"`
	Origen         string    `json:"Origen"`
	Fecha          time.Time `json:"Fecha"`
	FechaString    string    `json:"FechaString"`
	Estado         string    `json:"Estado"`
	Tipo           string    `json:"Tipo"`
	Ubicacion      string    `json:"Ubicacion"`
	Asignado       string    `json:"Asignado"`
}

func LoginUsuario(w http.ResponseWriter, r *http.Request) {

	// Decodificar el JSON de la solicitud en una estructura Credenciales
	var credenciales Credenciales
	if err := json.NewDecoder(r.Body).Decode(&credenciales); err != nil {
		http.Error(w, "Error al decodificar el JSON", http.StatusBadRequest)
		return
	}

	// Validar que usuario y contraseña no estén vacíos
	if credenciales.Usuario == "" || credenciales.Contraseña == "" {
		http.Error(w, "Usuario y contraseña no pueden estar vacíos", http.StatusBadRequest)
		return
	}

	// Establecer la conexión a la base de datos SQL Server
	db, err := sql.Open("sqlserver", ConnectionString)
	if err != nil {
		http.Error(w, "Error al conectar a la base de datos", http.StatusInternalServerError)
		return
	}
	defer db.Close()

	// Llamar al procedimiento almacenado ValidarUsuario
	var usua_id int // Cambia esta variable para almacenar el usua_id en lugar de rolID
	err = db.QueryRow("EXEC sp_ValidarUsuario '" + credenciales.Usuario + "','" + credenciales.Contraseña + "'").Scan(&usua_id)
	if err != nil {
		http.Error(w, "Error al ejecutar el procedimiento almacenado", http.StatusInternalServerError)
		return
	}

	// Comprobar el resultado (usua_id) y responder con un código de estado apropiado
	if usua_id != 0 {
		// Usuario autenticado correctamente
		// Devolver el usua_id como parte de la respuesta
		w.Header().Set("Content-Type", "application/json")
		responseJSON := struct {
			UsuaID int `json:"usua_id"`
		}{
			UsuaID: usua_id,
		}
		json.NewEncoder(w).Encode(responseJSON)
	} else {
		// Usuario no válido
		http.Error(w, "Usuario y/o contraseña incorrectos", http.StatusUnauthorized) // 401 Unauthorized
	}
}

func formatFecha(fecha time.Time) string {
	// Formatea la fecha en el formato deseado
	formatted := fecha.Format("15:04:05 02/01/2006")
	return formatted
}

func GetSucesos(w http.ResponseWriter, r *http.Request) {
	// Obtener el ID del usuario desde la solicitud (puedes obtenerlo de la sesión o de otro lugar según tu aplicación)
	var credenciales Credenciales
	if err := json.NewDecoder(r.Body).Decode(&credenciales); err != nil {
		http.Error(w, "Error al decodificar el JSON", http.StatusBadRequest)
		return
	}

	// Validar el id de usuario
	if credenciales.UsuarioID == 0 {
		http.Error(w, "Id de usuario invalido", http.StatusBadRequest)
		return
	}

	// Establecer la conexión a la base de datos SQL Server
	db, err := sql.Open("sqlserver", ConnectionString)
	if err != nil {
		http.Error(w, "Error al conectar a la base de datos", http.StatusInternalServerError)
		return
	}
	defer db.Close()

	// Llamar al procedimiento almacenado sp_ObtenerSucesosUsuario y obtener los resultados
	rows, err := db.Query("EXEC sp_ObtenerSucesosUsuario @usua_id", sql.Named("usua_id", credenciales.UsuarioID))
	if err != nil {
		http.Error(w, "Error al ejecutar el procedimiento almacenado", http.StatusInternalServerError)
		return
	}
	defer rows.Close()

	// Crear una estructura para almacenar los resultados
	var sucesos []Suceso // Reemplaza Suceso con la estructura que corresponda a tu resultado

	// Iterar a través de los resultados y llenar la estructura
	for rows.Next() {
		var suceso Suceso // Reemplaza Suceso con la estructura que corresponda a tu resultado
		err := rows.Scan(&suceso.Suceso, &suceso.Area, &suceso.PacienteID, &suceso.Ubicacion,
			&suceso.PacienteNombre, &suceso.Descripcion, &suceso.Origen, &suceso.Fecha, &suceso.Estado, &suceso.Tipo, &suceso.Asignado)
		if err != nil {
			http.Error(w, "Error al escanear los resultados", http.StatusInternalServerError)
			return
		}
		suceso.FechaString = formatFecha(suceso.Fecha)

		sucesos = append(sucesos, suceso)
	}

	// Convertir la estructura de sucesos a JSON
	sucesosJSON, err := json.Marshal(sucesos)
	if err != nil {
		http.Error(w, "Error al convertir a JSON", http.StatusInternalServerError)
		return
	}

	// Escribir la respuesta JSON en la respuesta HTTP
	w.Header().Set("Content-Type", "application/json")
	w.WriteHeader(http.StatusOK)
	w.Write(sucesosJSON)
}

func IndexRoute(w http.ResponseWriter, r *http.Request) {
	fmt.Fprintf(w, "API Codigo Azul")
}
