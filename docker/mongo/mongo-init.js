db = new Mongo().getDB("mongo");

db.createCollection('users', { capped: false });

db.users.insert([
    { "id": 1, "name": "Arthur", "surname": "Morgan", "email": "ArthurMorgan@mail.com" },
]);