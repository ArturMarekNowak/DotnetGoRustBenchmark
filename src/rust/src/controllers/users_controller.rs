mod services;

#[get("/<id>")]
pub fn get_user(id: u32) -> _ {
    services::get_user(id)
}
