#BACKEND

# Admin Dashboard API

A RESTful backend API built with ASP.NET Core and Entity Framework Core.

## Features
- JWT Authentication with Refresh Tokens
- Role-based Authorization (Admin / User)
- CRUD operations for Products and Users
- Pagination & Filtering
- SQL Server with EF Core
- Global Exception Handling Middleware
- Secure Logout & Token Revocation
- Automatic Admin Seeding

## Tech Stack
- ASP.NET Core (.NET 8)
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger (OpenAPI)

## Authentication Flow
1. User logs in and receives an access token + refresh token
2. Access token is used for protected endpoints
3. Refresh token is used to obtain a new access token
4. Logout revokes the refresh token

## Roles
- Admin: Full access (create/update/delete)
- User: Read-only access

## Getting Started
1. Clone the repository
2. Update connection string in `appsettings.json`
3. Run database migrations
4. Run the project

## Default Admin Account
- Email: admin@dashboard.com
- Password: Admin123
