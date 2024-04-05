package repositories

import (
	"app/models"
	"context"
	"errors"
	"go.mongodb.org/mongo-driver/bson"
	"go.mongodb.org/mongo-driver/mongo"
	"go.mongodb.org/mongo-driver/mongo/options"
	"log"
	"os"
)

func GetUser(id int) (*models.User, error) {

	var client = CreateSession()
	coll := client.Database("mongo").Collection("users")
	var user models.User
	err := coll.FindOne(context.TODO(), bson.D{{"_id", id}}).Decode(&user)
	if errors.Is(err, mongo.ErrNoDocuments) {
		return nil, err
	}
	if err != nil {
		panic(err)
	}

	if err := client.Disconnect(context.TODO()); err != nil {
		panic(err)
	}

	user.Id = id
	return &user, nil
}

func CreateSession() *mongo.Client {
	uri := os.Getenv("CONNECTION_STRING")
	if uri == "" {
		log.Fatal("CONNECTION_STRING not set")
	}
	client, err := mongo.Connect(context.TODO(), options.Client().ApplyURI(uri))
	if err != nil {
		panic(err)
	}

	return client
}
