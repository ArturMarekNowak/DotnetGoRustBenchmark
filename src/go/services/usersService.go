package services

import (
	"app/models"
	"app/repositories"
)

func GetUser(id int) (*models.User, error) {
	user, err := repositories.GetUser(id)
	if err != nil {
		return nil, err
	}
	return user, nil
}
