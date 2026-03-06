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
  - builds the green path under `scenarios/good/`
  - this project is part of `build-all.ps1`
- `Samples.Block06.AnalyzerViolations.csproj`
  - builds the broad mixed violation corpus under `scenarios/violations/`
  - expected to fail with diagnostics (training mode)
- `Samples.Block06.AnalyzerViolations.*.csproj`
  - isolated mini-projects for compilation-sensitive rules such as metadata consistency, CQRS completeness, and cross-style constraints
  - together with the main violations project they cover every current analyzer rule id
- `scenarios/good/checkout/`
  - contains the coherent checkout use case used as the valid comparison baseline
- `scenarios/violations/ddd/`, `architecture/`, `events/`, `metadata/`, `isolated/`
  - group violations by scenario family instead of one flat file list
- `..\analyzer-rule-coverage.md`
  - maps every analyzer rule id to the concrete violation sample file/project that triggers it

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
- bounded-context and module metadata diagnostics from `XMoleculesBoundedContext*` and `XMoleculesModule*`
- CQRS completeness and cross-style diagnostics from the dedicated mini-projects

## Exercises

1. Refactor `BadPricingDomainService` to remove its application-service dependency.
2. Refactor `BadCartAggregate` so aggregate logic does not depend on application service orchestration.
3. Compare diagnostics before and after refactoring.
