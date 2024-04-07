#[macro_use] extern crate rocket;
mod controllers;
mod services;
mod repositories;
mod models;

#[launch]
fn startServer() -> _ {
    rocket::build().mount("/", routes![controllers::hello_world_controller::hello_world])
                   .mount("/users", routes![controllers::users_controller::get_user])
}
