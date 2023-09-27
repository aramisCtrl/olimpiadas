package main

import (
	"database/sql"
	"html/template"
	"log"
	"net/http"
	"os"
	"strconv"
	"time"

	_ "github.com/denisenkom/go-mssqldb"
	"github.com/hajimehoshi/oto/v2"
	htgotts "github.com/hegedustibor/htgo-tts"
	handlers "github.com/hegedustibor/htgo-tts/handlers"
	"github.com/hegedustibor/htgo-tts/voices"

	"github.com/hajimehoshi/go-mp3"
)

var (
	latestData string
	plantillas *template.Template
)

func main() {

	// Cargar la configuracion
	CargarConfiguracion()

	// Conecta a la base de datos
	db, err := sql.Open("mssql", ConnectionString)
	if err != nil {
		log.Fatal(err)
	}
	defer db.Close()

	// Carga los archivos de template
	plantillas = template.Must(template.ParseGlob("templates/*"))

	// Inicia un bucle que consulta el procedimiento almacenado y actualiza latestData cada 5 segundos
	go func() {
		for {
			time.Sleep(5 * time.Second)
			// Consulta el procedimiento almacenado "sp_ObtenerAlarmasArea"
			rows, err := db.Query("EXEC sp_ObtenerAlarmasArea " + ConfigData.AreaID)
			if err != nil {
				log.Println(err)
				return
			}
			defer rows.Close()

			// Verifica si el procedimiento almacenado retornó algún resultado
			if rows.Next() {
				var resultado string
				if err := rows.Scan(&resultado); err != nil {
					log.Println(err)
					return
				}

				// Actualiza latestData con el nuevo resultado
				if resultado != latestData {
					latestData = resultado
					if latestData != "" {
						// Llama a la función para convertir el texto a voz
						go textToSpeech(latestData)

					}
				}
			} else {
				// Si el procedimiento almacenado no arrojó registros, latestData queda en blanco
				latestData = ""
			}
		}
	}()

	// Configura el servidor web
	http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
		// Muestra latestData en la página web
		if latestData != "" {
			plantillas.ExecuteTemplate(w, "alarma.html", struct{ LatestData string }{LatestData: latestData})
		} else {
			plantillas.ExecuteTemplate(w, "index.html", nil)
		}
	})

	// Inicia el servidor web en el puerto 8080
	// log.Fatal(http.ListenAndServe(":8080", nil))
	log.Fatal(http.ListenAndServe(":"+strconv.Itoa(ConfigData.Port), nil))
}

func textToSpeech(text string) {
	playAudio("attention.mp3")
	speech := htgotts.Speech{Folder: "audio", Language: voices.Spanish, Handler: &handlers.Native{}}
	err := speech.Speak(text)
	if err != nil {
		log.Println("Error al generar el discurso:", err)
	}
}

func playAudio(filename string) error {
	f, err := os.Open(filename)
	if err != nil {
		return err
	}
	defer f.Close()

	d, err := mp3.NewDecoder(f)
	if err != nil {
		return err
	}

	c, ready, err := oto.NewContext(d.SampleRate(), 2, 2)
	if err != nil {
		return err
	}
	<-ready

	p := c.NewPlayer(d)
	defer p.Close()
	p.Play()

	// fmt.Printf("Length: %d[bytes]\n", d.Length())
	for {
		time.Sleep(time.Second)
		if !p.IsPlaying() {
			break
		}
	}

	return err
}
