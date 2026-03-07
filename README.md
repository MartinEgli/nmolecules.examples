# nmolecules.examples

Pedagogical sample repository for the nMolecules workspace.

This repository is organized as a guided learning path with clearly separated blocks.
Each block is a standalone sample project with detailed explanations and concrete tasks.

## Learning Goals

The sample path is designed to help you:

- understand the intent behind each nMolecules attribute family
- see correct modeling patterns first
- inspect intentionally problematic patterns in a controlled way
- learn how Roslyn diagnostics map to DDD and architecture decisions

## Pedagogical Structure

All samples live in `samples/` and are grouped by increasing complexity.

| Block | Focus | Covered Workspace Project |
|---|---|---|
| `01` | DDD core markers, role boundaries, and DDD/metadata violations | `nmolecules/src/nMolecules.DDD` |
| `02` | Architecture styles (one green project per style, plus colocated violations where analyzers exist) | `nmolecules/src/nMolecules.Architecture` |
| `03` | Domain events, handlers, and event violations | `nmolecules/src/nMolecules.Events` |
| `04` | Custom role modeling with Bricks plus Bricks violations | `nmolecules/src/nMolecules.Bricks` |
| `05` | EF metadata markers | `nmolecules/src/nMolecules.Persistence.EntityFramework` |
| `06` | Analyzer diagnostics baseline (green checkout project with analyzers active) | `nmolecules-integrations/nmolecules-roslyn/src/nMolecules.Analyzers` |
| `07` | DDD patterns derived from local PDF books | `nmolecules/src/nMolecules.DDD`, `nmolecules/src/nMolecules.Events` |

This means each core nMolecules project and the analyzer project has at least one dedicated sample project.

Sample projects intentionally follow one shared baseline:

- common SDK defaults are centralized under `samples/Directory.Build.props`
- block-level READMEs use the same teaching flow where possible
- scenario-heavy blocks prefer `scenarios/` folders over flat file lists

## Quick Start

From the superproject root (`C:\Reops\nmolecules`):

```powershell
dotnet build .\nmolecules.examples\nMolecules.Examples.sln -v minimal
```

Solution variants:

- `nMolecules.Examples.Green.sln` / `nMolecules.Examples.Green.slnx`: all sample projects that are expected to build cleanly
- `nMolecules.Examples.All.sln` / `nMolecules.Examples.All.slnx`: includes the intentional violations corpus
- architecture-specific `.slnx` entry points:
- `nMolecules.Examples.Layered.slnx`
- `nMolecules.Examples.Cqrs.slnx`
- `nMolecules.Examples.OnionClassic.slnx`
- `nMolecules.Examples.OnionSimplified.slnx`
- `nMolecules.Examples.Hexagonal.slnx`
- `nMolecules.Examples.Microservices.slnx`
- `nMolecules.Examples.EventStorming.slnx`
- `nMolecules.Examples.Mvvm.slnx`

```powershell
dotnet build .\nmolecules.examples\nMolecules.Examples.Green.sln -v minimal
dotnet build .\nmolecules.examples\nMolecules.Examples.All.sln -v minimal
dotnet build .\nmolecules.examples\nMolecules.Examples.Layered.slnx -v minimal
dotnet build .\nmolecules.examples\nMolecules.Examples.Cqrs.slnx -v minimal
```

Note: `All` is expected to report analyzer errors because it includes intentional violation samples from Blocks 01 to 04.

Or build sample projects individually:

```powershell
dotnet build .\nmolecules.examples\samples\01-ddd-core\Samples.Block01.DddCore.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\layered\Samples.Architecture.Layered.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\cqrs\Samples.Architecture.Cqrs.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\onion-classic\Samples.Architecture.OnionClassic.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\onion-simplified\Samples.Architecture.OnionSimplified.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\hexagonal\Samples.Architecture.Hexagonal.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\microservices\Samples.Architecture.Microservices.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\event-storming\Samples.Architecture.EventStorming.csproj -v minimal
dotnet build .\nmolecules.examples\samples\02-architecture-styles\mvvm\Samples.Architecture.Mvvm.csproj -v minimal
dotnet build .\nmolecules.examples\samples\03-events\Samples.Block03.Events.csproj -v minimal
dotnet build .\nmolecules.examples\samples\04-bricks\Samples.Block04.Bricks.csproj -v minimal
dotnet build .\nmolecules.examples\samples\05-entity-framework\Samples.Block05.EntityFramework.csproj -v minimal
dotnet build .\nmolecules.examples\samples\06-analyzer-workbench\Samples.Block06.AnalyzerWorkbench.csproj -v minimal
dotnet build .\nmolecules.examples\samples\07-ddd-from-pdfs\Samples.Block07.DddFromPdfs.csproj -v minimal
```

If you want to focus on one architecture style without the rest of the learning path, open the matching style-specific `.slnx` file from the repository root.

## How To Work Through The Blocks

Use the same sequence for each block:

1. Read the block README first (`samples/xx-*/README.md`).
2. Inspect the "good" model classes and annotations.
3. Build the project and inspect diagnostics.
4. Apply the suggested exercises from the README.
5. Rebuild and compare diagnostics before/after.

For explicit attribute-to-sample mapping, see:

- `samples/attribute-coverage.md`

## Important Note About The Analyzer Workbench

Block `06` is now only the green analyzer baseline.
Intentional violations live next to the matching sample families in Blocks `01` to `04`.

Block `06` has these explicit entry points:

- `Samples.Block06.AnalyzerWorkbench.csproj`: green baseline with analyzers enabled
