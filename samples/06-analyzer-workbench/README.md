# Block 06: Analyzer Workbench

This block is intentionally split into **good** and **bad** constellations with separate projects.

## Why This Block Exists

A warning is much easier to understand when you can compare:

- a valid model in the same context
- the violating model directly next to it

This project is a training ground for diagnostics interpretation and rule discussions.

## What You Learn

- how analyzer diagnostics reflect DDD role boundaries
- how to map a warning back to the violating dependency
- how to refactor from "bad" to "good" while preserving use-case intent

## Structure

- `Samples.Block06.AnalyzerWorkbench.csproj`
  - builds `GoodExample.cs` with analyzers active
  - this project is part of `build-all.ps1`
- `Samples.Block06.AnalyzerViolations.csproj`
  - builds `BadExample.cs` with analyzers active
  - expected to fail with diagnostics (training mode)

## Expected Outcome

Run the good (green) path:

```powershell
dotnet build .\samples\06-analyzer-workbench\Samples.Block06.AnalyzerWorkbench.csproj -v minimal
```

Run the violations (expected diagnostics/failures):

```powershell
dotnet build .\samples\06-analyzer-workbench\Samples.Block06.AnalyzerViolations.csproj -v minimal
```

Typical diagnostics you should observe there include:

- `XMoleculesAggregateRoot0006`
- `XMoleculesDomainService0001`
- `XMoleculesService0001`
- repository composition diagnostics from `XMoleculesRepository*`

## Exercises

1. Refactor `BadPricingDomainService` to remove its application-service dependency.
2. Refactor `BadCartAggregate` so aggregate logic does not depend on application service orchestration.
3. Compare diagnostics before and after refactoring.
