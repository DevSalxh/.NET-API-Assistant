dotnet new list  # to show list of all posible project that can u create with the comands

dotnet new webapi -controllers -n API # to create webapi project with controllers and name gonna be API

dotnet ef migrations add InitialCreate # to add migration called "InitialCreate" (for Db)

dotnet ef database update # to update the db with the latest file of migration
