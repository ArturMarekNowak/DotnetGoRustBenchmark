use crate::repositories;
use crate::models::user::User;
use mongodb::error::Error;

pub async fn get_user(id: u32) -> Result<User, Error> {
    repositories::users_repository::get_user(id).await
}
