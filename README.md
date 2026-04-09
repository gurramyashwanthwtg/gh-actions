# Minimal .NET + GitHub Actions Playground

This repository is intentionally tiny so you can experiment with GitHub Actions jobs for build, test, and deploy.

## Project layout

- `src/DemoApp`: Minimal console app with one function (`MathOps.Add`).
- `tests/DemoApp.Tests`: One xUnit test for that function.
- `.github/workflows/test.yml`: CI workflow with 3 jobs:
  - `build`
  - `test`
  - `deploy` (publishes and uploads artifact)

## Run locally

```bash
dotnet restore src/DemoApp/DemoApp.csproj
dotnet build src/DemoApp/DemoApp.csproj -c Release
dotnet test tests/DemoApp.Tests/DemoApp.Tests.csproj -c Release
dotnet publish src/DemoApp/DemoApp.csproj -c Release -o out
```

## Trigger workflow

- Push to `main`
- Open a PR targeting `main`
- Run manually from **Actions** -> **dotnet-ci** -> **Run workflow**
