use serde::{ Deserialize, Serialize };

#[derive(Serialize, Deserialize, Debug)]
pub struct User {
    #[serde(rename = "_id")]
    pub id: u32,
    pub name: String,
    pub surname: String, 
    pub email: String
}
