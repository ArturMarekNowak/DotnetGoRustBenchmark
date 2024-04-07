use mongodb::{
    bson::doc,
    error::Error,
    Client, 
    options::ClientOptions
};
use crate::models::user::User;

pub async fn get_user(id: u32) -> Result<User, Error> {
    let mut client_options = ClientOptions::parse("mongodb://admin:admin@host.docker.internal:27017/?directConnection=true").await?;
    let client = Client::with_options(client_options)?;
    let usersCollection = client.database("mongo").collection("users");
    let user: User = usersCollection.find_one(doc! {"_id": id}, None)
                                    .await
                                    .expect("Couldn't find user")
                                    .expect("Couldn't deserialize user");
                                           
    Ok(user)
}
