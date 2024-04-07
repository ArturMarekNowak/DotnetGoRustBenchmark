package main

import (
	"app/controllers"
	"github.com/gin-gonic/gin"
)

func ConfigureEndpoints(router *gin.Engine) {
	router.GET("/users/:id", controllers.GetUser)
	router.GET("/helloWorld", controllers.GetHelloWorld)
}

func ConfigureServer() {
	router := gin.Default()
	ConfigureEndpoints(router)
	err := router.Run(":8080")
	if err != nil {
		panic("Couldn't start host")
	}
}

func main() {
	ConfigureServer()
}
