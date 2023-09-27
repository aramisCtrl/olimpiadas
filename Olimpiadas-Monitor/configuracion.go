package main

import (
	"encoding/json"
	"fmt"
	"os"
)

type Config struct {
	Server   string `json:"server"`
	UserID   string `json:"user"`
	Password string `json:"password"`
	Database string `json:"database"`
	Port     int    `json:"port"`
	AreaID   string `json:"area_id"`
}

var ConnectionString string
var ConfigData Config

func CargarConfiguracion() (Config, error) {

	ConnectionString = "server=localhost;integrated security=true;database=codigo_azul"

	configFile, err := os.Open("config.json")
	if err != nil {
		return ConfigData, err
	}
	defer configFile.Close()

	jsonParser := json.NewDecoder(configFile)
	if err := jsonParser.Decode(&ConfigData); err != nil {
		return ConfigData, err
	}

	ConnectionString = fmt.Sprintf("server=%s;user id=%s;password=%s;database=%s", ConfigData.Server, ConfigData.UserID, ConfigData.Password, ConfigData.Database)
	return ConfigData, nil
}
