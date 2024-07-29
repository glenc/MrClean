# Mr Clean Solution Template

This solution template is based heavily on the [Clean Architecture Solution Template](https://github.com/jasontaylordev/CleanArchitecture/) created by [Jason Taylor](https://github.com/jasontaylordev). You might ask, why does this project exist then? It seems like it is basically the same thing, but with fewer features and options. You would be right.

This project exists simply as my own personal learning exercise. I wanted to utilize the template above for my own projects, but understand the inner workings of the solution from the ground up. My objective was to learn the following:

- **DDD and Clean Architecture in practice in the .NET world** - I've come across numerous examples over the years but none of them really felt right. I found myself needing to bend the rules of DDD and Clean Architecture as I understood them to make the solution work without incurring huge development costs. In addition, as a student of DDD and CA I was very much learning as I went and couldn't understand which design choices were important, which could be compromised, and which were unnecessary. The Clean Architecture Solution is the first that resonated and didn't feel too heavy.
- **Solution Templates and Code Generation** - The ability to create a new solution from a template, and then create new use cases within the solution was great. This seemed like a huge way to both save time, but also ensure consistency in the application structure. However, I also saw opportunities to improve this such as creating use cases and assocated tests at the same time. I wanted to learn more about automating aspects of solution development through the tools and methods available today.
- **Creating a truly _clean_ starting point** - I understand why many solution templates come with starter code (entities, commands, API endpoionts, etc), but once I become familiar with a solution I want to start fresh with no remnents of the demo content. Having them there is useful for learning, but call me a purest, but I don't want any remnents of that in my code base or commit history. I don't want to have to run a DB migration just to get rid of something I didn't want to begin with. For me this meant really understanding the inner workings of what was there and why so I could strip it down to the bare bones. I wanted to understand each tool in use, understand its purpose, and then decide if I would want that for my needs.

Ultimately this is a work in progress. This readme is serving as my own note-taking document as I go as well as sample commands for how I intend it to function.

I cannot stress enough that the credit for this solution belongs with [Jason Taylor](https://github.com/jasontaylordev) - I am not trying to build a _better_ Clean Architecture template, I'm just trying to learn and improve my understanding of how to apply these principles in practice.

## Getting Started

1. Install the MrClean Template (replace with nuget package eventually)

   ```bash
   git clone https://github.com/glenc/MrClean
   cd MrClean
   dotnet new install .
   ```

1. Create a new solution using React as the client framework

   ```bash
   dotnet new mrc-sln -n MyApplication --client-framework React
   cd MyApplication
   dotnet run --project src/WebApi
   ```

   The web api is now running on https://localhost:7000. Open a browser window to view the API documentation.

1. Next, set up and start the client app by opening a new terminal window and entering the following:

   ```bash
   cd src/WebClient
   npm install
   npm run dev
   ```

   The client app is now running on http://localhost:5010

### Supported Client Frameworks

- React (TypeScript)
- Vue (TypeScript)
- None (Web API only)

  ```bash
  dotnet new mrc-sln -n MyReactApp -cf React
  dotnet new mrc-sln -n MyVueApp -cf Vue
  dotnet new mrc-sln -n MyApiOnly -cf None
  ```

## Scaffolding and Migrations

### Domain Entities

Create a new domain entity and associated unit tests

```bash
dotnet new mrc-entity -n Employee -o src/Domain --project src/Domain/Domain.csproj
dotnet new mrc-entity-test -n Employee -o tests/Domain.UnitTests --project src/Domain/Domain.csproj
```

Or, using VSCode run one of the following tasks:

- **Create Entity** (creates a new entity)
- **Create Entity Tests** (creates the unit test for a given entity)
- **Create Entity and Tests** (creates a new entity and associated tests)

### Use Cases (Commands and Queries)

Create a new command use case and associated tests

```bash
dotnet new mrc-usecase -n CreateEmployee -feature-name Employees -usecase-type command -return-type int -o src/Application --project src/Application/Application.csproj
dotnet new mrc-usecase-test -n CreateEmployee -fn Employees -ut command -rt int -o tests/Application.FunctionalTests --project src/Application/Application.csprojcsproj
```

Create a new query use case which returns an EmployeeList View Model return type

```bash
dotnet new mrc-usecase -n ListEmployees -fn Employees -ut query -rt EmployeeListVm -o src/Application --project src/Application/Application.csproj
```

Or, using VSCode run one of the following tasks:

- **Create Use Case** (creates a new use case)
- **Create Use Case Tests** (creates the unit test for a given use case)
- **Create Use Case and Tests** (creates a new use case and associated tests)

### Database Migrations

Create a new migration using the **Create Migration** task in VSCode.

## NOT SUPPORTED

- SQL Server
- Deployment

## Technologies

- [ASP.NET Core 8](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
- [Entity Framework Core 8](https://docs.microsoft.com/en-us/ef/core/)
- [React 18](https://react.dev/)
- [MediatR](https://github.com/jbogard/MediatR)
- [AutoMapper](https://automapper.org/)
- [FluentValidation](https://fluentvalidation.net/)
- [NUnit](https://nunit.org/), [FluentAssertions](https://fluentassertions.com/), [Moq](https://github.com/moq) & [Respawn](https://github.com/jbogard/Respawn)

## Learn More

- [Clean Architecture with ASP.NET Core 3.0 (GOTO 2019)](https://youtu.be/dK4Yb6-LxAk)
- [Clean Architecture with .NET Core: Getting Started](https://jasontaylor.dev/clean-architecture-getting-started/)

## License

This project is licensed with the [MIT license](LICENSE).
