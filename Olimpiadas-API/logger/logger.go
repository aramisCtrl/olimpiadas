package logger

import (
	"os"

	"github.com/sirupsen/logrus"
)

var log *logrus.Logger

func init() {
	// Configura el formato del registro
	log = logrus.New()
	log.Formatter = &logrus.TextFormatter{
		FullTimestamp: true,
	}

	// Abre un archivo para escribir los registros
	file, err := os.OpenFile("app.log", os.O_CREATE|os.O_WRONLY|os.O_APPEND, 0666)
	if err == nil {
		log.Out = file
		defer file.Close()
	} else {
		log.Info("Falla al abrir el archivo de registro. Se utilizará la salida estándar.")
	}
}

// Info registra un mensaje de información
func Info(message string) {
	log.Info(message)
}

// Warn registra un mensaje de advertencia
func Warn(message string) {
	log.Warn(message)
}

// Error registra un mensaje de error
func Error(message string) {
	log.Error(message)
}
