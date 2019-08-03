
# Run the Program

This program uses .NET Core 2.2.401, please ensure you have this version

## Creating the db

run dbup scripts to build DB using the commands below from the root of the repo

```powershell
  dotnet build
  dotnet run --project .\CarFinance247DBUpScripts\
```

This will create an database called CarFinance247TechTestRobStone in your local SQLEXPRESS instance with an prepopulated DB Table. You can pass it another connection string if you wish to build the database somewhere else. Note: if you do change the location of the db make sure you change the connection string in appsettings.Development.json

## Running the WEB API
First of all run  

```powershell
dotnet build
```

Then to launch to the server

```powershell
 dotnet run --project .\CarFinance247TechTest\
```

The Http server will be running on <http://localhost:5000/>

### GET all Customers

Http Get  <http://localhost:5000/api/Customer> will return a json array with all customers

## Running the Unit Tests

Simply run ```dotnet test```
