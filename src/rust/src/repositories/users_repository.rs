use mongodb::{Client, options::ClientOptions};

pub fn get_user(id: u32) -> mongodb::error::Result<()> {
    let mut client_options = ClientOptions::parse("mongodb://localhost:27017").await?;
    let client = Client::with_options(client_options)?;
    let usersCollection = client.database("mongo").collection("users");
    let user = usersCollection.find_one(doc!{"Id": id}, None).await?;

    Ok(())
}
