package main

import (
	"database/sql"
	"log"
	"net/http"
	"strconv"
	"text/template"

	app "olimpiadas-api/app"

	_ "github.com/denisenkom/go-mssqldb"
	"github.com/gorilla/mux"
)

var (
	plantillas = template.Must(template.ParseGlob("plantillas/*"))
	db         *sql.DB // Declarar una variable para la conexión de la base de datos
)

func Inicio(w http.ResponseWriter, r *http.Request) {
	// Conectar a la base de datos SQL Server
	var err error
	db, err = sql.Open("mssql", app.ConnectionString)
	if err != nil {
		log.Fatal(err)
	}

	defer db.Close() // Asegúrate de cerrar la conexión cuando ya no se necesite

	// Llamar al procedimiento almacenado "sp_ObtenerAreas"
	rows, err := db.Query("EXEC sp_ObtenerAreas")
	if err != nil {
		log.Fatal(err)
	}
	defer rows.Close()

	// Procesar los resultados y almacenarlos en una estructura adecuada
	var areas []Area
	for rows.Next() {
		var areaID int
		var areaDescripcion string
		if err := rows.Scan(&areaID, &areaDescripcion); err != nil {
			log.Fatal(err)
		}
		areas = append(areas, Area{ID: areaID, Descripcion: areaDescripcion})
	}

	// Ejecutar la plantilla HTML y pasar los resultados
	plantillas.ExecuteTemplate(w, "inicio", areas)
}

func AlarmaCodigoAzul(w http.ResponseWriter, r *http.Request) {
	// Obtiene el valor de "areaID" de las variables de ruta
	vars := mux.Vars(r)
	areaID := vars["areaID"]

	// Conectar a la base de datos SQL Server
	var err error
	db, err = sql.Open("mssql", app.ConnectionString)
	if err != nil {
		log.Fatal(err)
	}

	defer db.Close() // Asegúrate de cerrar la conexión cuando ya no se necesite

	// Llamar al procedimiento almacenado "sp_InsertarSucesoAlarmaCodigoAzul"
	rows, err := db.Query("EXEC sp_InsertarSucesoAlarmaCodigoAzul " + areaID)
	if err != nil {
		log.Fatal(err)
	}
	defer rows.Close()

	// Variables para capturar el valor de "ID_INSERTADO"
	var idInsertado int

	// Recorrer las filas (asumiendo que solo hay una fila devuelta)
	for rows.Next() {
		err := rows.Scan(&idInsertado)
		if err != nil {
			log.Fatal(err)
		}
	}

	if idInsertado == -1 {
		http.Error(w, "Error: No se pudo insertar la alarma", http.StatusInternalServerError)
		return
	}

	// Si no es -1, todo está bien, responde con un mensaje "OK"
	w.WriteHeader(http.StatusOK)
}

func RegistrarAlarma(id_area int) {
	// Conexión a la base de datos
	db, err := sql.Open("mssql", app.ConnectionString)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()

}

type Area struct {
	ID          int
	Descripcion string
}

func main() {
	app.CargarConfiguracion()
	router := mux.NewRouter()

	router.HandleFunc("/", app.IndexRoute).Methods("GET")
	router.HandleFunc("/login", app.LoginUsuario).Methods("POST")
	router.HandleFunc("/getsucesos", app.GetSucesos).Methods("POST")
	router.HandleFunc("/inicio", Inicio).Methods("GET")
	router.HandleFunc("/alarma/{areaID}", AlarmaCodigoAzul).Methods("GET")

	log.Fatal(http.ListenAndServe(":"+strconv.Itoa(app.ConfigData.Port), router))
}
