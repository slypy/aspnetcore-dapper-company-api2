# aspnetcore-dapper-company-api2
ASP.NET Core Web API using Dapper

## Flow

 ![UML Flow](docs/Company%20Uml.png)

## Setup
-  Create CompanyDb by running `initCompanyDB.sql` to your DB server.
-  Dont forget to change the value of `SqlConnection` in `ConnectionStrings` in `appsetings.json` to your local Db's connection string.
 
## Endpoints

### GET `/api/companies`
Returns all companies
### GET `/api/companies/[id]`
Return a company with that Id
### POST `/api/companies`
Create a company
### PUT `/api/companies/[id]`
Update a company
### DELETE `/api/companies/[id]`
Delete a company
