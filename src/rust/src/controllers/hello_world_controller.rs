use rocket::get;

#[get("/helloWorld")]
pub fn hello_world() -> &'static str {
    "{\"message:\" \"Hello world!\"}"
}
