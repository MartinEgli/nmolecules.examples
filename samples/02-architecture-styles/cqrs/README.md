# Architecture Style Sample: CQRS

This sample focuses only on CQRS markers.

## Why This Style Sample Exists

CQRS is easiest to understand when the read-side and write-side markers are shown without other structural styles mixed in.

## What You Learn

Covered markers:

- `[Command]`
- `[Query]`
- `[CommandHandler]`
- `[QueryHandler]`
- `[CommandDispatcher]`
- `[QueryModel]`
- `[Projection]`

## Code Walkthrough

- `CqrsSample.cs` keeps the entire CQRS example in one focused file
- the sample shows write-side intent (`Command`, `CommandHandler`) next to read-side intent (`Query`, `QueryHandler`, `QueryModel`)
- `Projection` is included so the read-model update path is visible

## Try Next

1. Add a second query and query handler pair.
2. Add a projection-fed query model and keep it read-only.
3. Build `Samples.Architecture.Cqrs.Violations.csproj` and compare the local CQRS diagnostics with the green sample.
