#[macro_use] extern crate rocket;
mod controllers;

#[launch]
fn startServer() -> _ {
    rocket::build().mount("/", routes![controllers::hello_world_controller::hello_world])
}
