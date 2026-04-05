# CLAUDE.md -- Neon SDK

## Overview

Auto-generated C# SDK for [Neon](https://neon.tech/) -- a serverless Postgres platform with branching, autoscaling, and bottomless storage. 956 generated files from the official OpenAPI 3.0.3 spec.

## Build & Test

```bash
dotnet build Neon.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard Bearer token auth:

```csharp
var client = new NeonClient(apiKey); // NEON_API_KEY env var
```

## Key Files

- `src/libs/Neon/openapi.yaml` -- Downloaded from `https://neon.com/api_spec/release/v2.json`
- `src/libs/Neon/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Neon/Generated/` -- **Never edit** -- auto-generated code (956 files)
- `src/libs/Neon/Extensions/NeonClientExtensions.AIFunctions.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## API Endpoints (93 paths)

| Category | Sub-client | Examples |
|----------|-----------|----------|
| Project | `client.Project` | List, create, update, delete, get connection URI, permissions, JWKS, VPC |
| Branch | `client.Branch` | List, create, delete, restore, schema, roles, databases, anonymization |
| Endpoint | `client.Endpoint` | List, create, update, delete, start, stop, restart compute endpoints |
| Operation | `client.Operation` | List, get project operations |
| Organizations | `client.Organizations` | Get org, members, invitations, API keys, VPC endpoints |
| Users | `client.Users` | Get current user, auth details, organizations |
| API Key | `client.ApiKey` | List, create, revoke API keys |
| Region | `client.Region` | List supported regions |
| Snapshot | `client.Snapshot` | List, create, delete, restore, schedule snapshots |
| Consumption | `client.Consumption` | Get consumption history per project |
| Auth | `client.Auth` | Neon Auth (OAuth providers, trusted domains, email config) |
| DataAPI | `client.DataAPI` | Create, get, update, delete Data API configuration |

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsListProjectsTool()` | Lists Neon projects with pagination and search |
| `AsCreateProjectTool()` | Creates a new serverless Postgres project |
| `AsListBranchesTool()` | Lists branches for a project |
| `AsGetConnectionUriTool()` | Gets a PostgreSQL connection URI for a database |
