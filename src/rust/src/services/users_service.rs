mod repositories;

pub fn get_user(id: u32) -> _ {
    repositories::get_user(id)
}
