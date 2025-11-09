# Employee Admin Portal API

An ASP.NET Core Web API project for managing employees and users, featuring authentication, role-based authorization, and CRUD operations using  Entity Framework Core and SQL Server.

## Features
- RESTful API for employee management
- Entity Framework Core integration
- SQL Server database
- Swagger/OpenAPI documentation


## Technologies Used
- ASP.NET Core 8.0
- Entity Framework Core 8
- SQL Server
- Swashbuckle (Swagger)

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Setup
1. Clone the repository:
	```powershell
	git clone <repo-url>
	cd ASPNETWebApi
	```
2. Update the connection string in `EmployeeAdminPortal/appsettings.json` if needed:
	```json
	"ConnectionStrings": {
	  "DefaultConnection": "Server=.;Database=EmployeesAdminPortalDb;Trusted_Connection=True;TrustServerCertificate=true;"
	}
	```
3. Apply migrations and update the database:
	```powershell
	dotnet ef database update --project EmployeeAdminPortal
	```
4. Run the API:
	```powershell
	dotnet run --project EmployeeAdminPortal
	```
5. Access Swagger UI at [https://localhost:5001/swagger](https://localhost:5001/swagger) (or the port shown in the console).

## API Endpoints

### Users
- `GET /api/users` - List all users
- `POST /api/users` - Add a new user

### Auth
- `POST /api/auth/login` - Authenticate user and receive JWT token

### Employees
- `GET /api/employees` - List all employees
- `GET /api/employees/{id}` - Get employee by ID
- `POST /api/employees` - Add a new employee
- `PUT /api/employees/{id}` - Update employee by ID
- `DELETE /api/employees/{id}` - Delete employee by ID



## Project Structure

- `EmployeeAdminPortal/Controllers` - API controllers
- `EmployeeAdminPortal/Models/Entities` - Entity models
- `EmployeeAdminPortal/Data` - EF Core DbContext
- `EmployeeAdminPortal/Migrations` - Database migrations
- `EmployeeAdminPortal/Services` - Utility services (e.g., password hashing)

## License

This project is licensed under the MIT License.
