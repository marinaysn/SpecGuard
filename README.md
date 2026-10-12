# SpecGuard
Specification management and continuous requirements verification platform

SpecGuard helps teams define, manage, and continuously verify requirements so that specifications and delivered software stay aligned.

## Planned Technology Stack

- C# / ASP.NET Core 10
- Angular / TypeScript
- PostgreSQL / Entity Framework Core
- xUnit
- GitHub Actions
- Modular monolith architecture

## Goals

- Centralize specification management.
- Verify requirements continuously.
- Keep the codebase simple, tested, and maintainable.

## Getting Started

### Requirements

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later

### Build

```bash
dotnet restore
dotnet build
```

### Run the API

```bash
dotnet run --project src/SpecGuard.Api
```

Then check the health endpoint at the URL printed on startup, for example `http://localhost:5000/health` (see `src/SpecGuard.Api/Properties/launchSettings.json` for the configured ports). It returns HTTP 200 with `Healthy`.

### Run the tests

```bash
dotnet test
```

See [AGENTS.md](AGENTS.md) for development standards.
