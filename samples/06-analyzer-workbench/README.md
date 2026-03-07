# Block 06: Analyzer Workbench

This block is now the analyzer-enabled **green baseline** only.
Intentional violations live next to the relevant samples in Blocks `01` to `04`.

## Why This Block Exists

A warning is much easier to understand when you can compare:

- a valid model in the same context
- the violating model directly next to it

This project is a training ground for diagnostics interpretation and rule discussions.

Current analyzer diagnostics are designed to answer three questions explicitly:

- why does this violation happen in the code shown here?
- which architectural boundary or invariant is being broken?
- what refactoring direction should be preferred?

## What You Learn

- how analyzer diagnostics appear on a coherent green sample
- how to compare the green checkout path with the colocated violations in the other sample blocks
- how to use one stable baseline when debugging analyzer behavior in the IDE

## Structure

- `Samples.Block06.AnalyzerWorkbench.csproj`
  - builds the green path under `scenarios/good/`
  - this project is part of `build-all.ps1`
- `scenarios/good/checkout/`
  - contains the coherent checkout use case used as the valid comparison baseline
- `..\analyzer-rule-coverage.md`
  - maps every analyzer rule id to the concrete sample file/project that triggers it across Blocks 01 to 04

## Expected Outcome

Run the good (green) path:

```powershell
dotnet build .\samples\06-analyzer-workbench\Samples.Block06.AnalyzerWorkbench.csproj -v minimal
```

Typical diagnostics you should observe there include:

- no analyzer errors on the checkout baseline
- a stable reference model for comparing DDD, metadata, event, brick, and style-specific violations in the other blocks

Relevant violation entry points now live here:

- Block 01: `Samples.Block01.DddCore.Violations.csproj` and `Samples.Block01.DddCore.*.csproj`
- Block 02: style-specific `Samples.Architecture.*.Violations.csproj`
- Block 03: `Samples.Block03.Events.Violations.csproj`
- Block 04: `Samples.Block04.Bricks.Violations.csproj`

## Exercises

1. Build the green baseline and keep the editor free of diagnostics.
2. Open one colocated violations project from Blocks 01 to 04 and compare its diagnostics with the checkout baseline.
3. Use the baseline project to verify a diagnostics refresh after changing analyzer code.

When comparing diagnostics, read both the short message and the full description. The message identifies the concrete offending symbol; the description explains the violated architectural rule and the target correction direction.
