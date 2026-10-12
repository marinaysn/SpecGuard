# AGENTS.md

Instructions for AI coding agents working on SpecGuard.

## Project Context

SpecGuard is a general-purpose specification management and continuous requirements verification platform.

- Backend: C# / ASP.NET Core 10
- Frontend: Angular / TypeScript
- Data: PostgreSQL / Entity Framework Core
- Testing: xUnit
- CI/CD: GitHub Actions
- Architecture: modular monolith

## Development Standards

- No blank lines inside method bodies.
- No comments inside method bodies.
- Prefer meaningful single-word variable names.
- Keep code simple, readable, and maintainable.
- Remove obsolete code; Git preserves its history.

## Testing Rules

- Exactly one assertion per automated test.
- Each test must end with its assertion.
- Write reasonable, focused automated tests. Manual testing remains part of development.
- Never weaken existing tests merely to make new code pass.

## Dependencies and Confidentiality

- Use only dependencies licensed for commercial production use.
- Never include employer-specific or proprietary source code, data, test results, or references to private evaluations.

## Pull Request Workflow

- Implement only the approved issue scope.
- Use a feature branch and submit a pull request.
- Do not merge automatically.
- Explain changes, testing performed, and any limitations.
