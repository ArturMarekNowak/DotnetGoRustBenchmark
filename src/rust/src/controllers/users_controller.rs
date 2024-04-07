use crate::services;
use rocket::{http::Status, serde::json::Json};
use crate::models::user::User;

#[get("/<id>")]
pub async fn get_user(id: u32) -> Result<Json<User>, Status> {
    let user = services::users_service::get_user(id).await;
    match user {
        Ok(user) => Ok(Json(user)),
        Err(_) => Err(Status::NotFound),
    }
}

