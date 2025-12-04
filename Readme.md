## E-Voter — Clean Architecture (.NET)

## 📌 Example: Voter CRUD Flow
✔ POST → Create Voter
API → Application → Infrastructure → Database

domain has the entity (tables)
api has controllers
application has the services (business logic), DTO
    service class calls IRepository class
    does not know the implementation of IRepository class
infrastructure has the implementation of IRepository class ie Repository class


## 🚀 How Each Layer Works (Simple)

API
Receives HTTP request → calls Application.

Application
Runs use-case logic → calls a Repository interface.

Infrastructure
Implements the Repository → talks to the database.

Domain
Holds the core entity (e.g., Voter).

## ----------------------------------------------------------------

This solution follows Clean Architecture to keep the code clean, testable, and easy to extend.
The system is split into four projects, each with a clear responsibility.

## 🧱 Project Structure
1. Domain
→ Holds the Voter entity and business rules
Depends on: No one
Contains the core business rules:
Entities (e.g., Voter)
Enums
Value objects
Repository interfaces (e.g., IVoterRepository)

2. Application
→ Handler validates and performs business logic, has services
→ Calls IVoterRepository.AddAsync()
Depends on: Domain
Contains the use cases and business logic:
Commands & Queries (e.g., CreateVoterCommand)
DTOs/Request models
Validators

3. Infrastructure
→ Repository saves the Voter to the database (EF Core)
Depends on: Application + Domain
Contains the real implementations:
EF Core DbContext
Repository implementations
Database migrations
External services

4. API
→ Receives POST /api/voters
→ Sends CreateVoterCommand to Application
Depends on: Application + Infrastructure
The entry point of the application:
Controllers / Endpoints
Dependency Injection configuration
Swagger


## -------------------------------------------
DB Migration
## -------------------------------------------
dotnet ef migrations add InitialCreate -p src/E-Voter.Infrastructure -s src/E-Voter.Api
dotnet ef database update -p src/E-Voter.Infrastructure -s src/E-Voter.Api
