# Pedagogical Sample Blocks

This folder contains the complete guided sample path.

Coverage reference:

- `attribute-coverage.md` maps all current attributes to concrete sample files.
- `analyzer-rule-coverage.md` maps all current analyzer rule ids to intentional violation samples.

## Blocks

1. `01-ddd-core`  
   DDD role modeling, bounded-context metadata, and the colocated DDD/metadata violations.
2. `02-architecture-styles`  
   One dedicated green project per style, plus colocated violations projects where analyzer rules exist:
   `layered`, `cqrs`, `onion-classic`, `onion-simplified`, `hexagonal`, `microservices`, `event-storming`, `mvvm`.
3. `03-events`  
   Domain event payload, publisher, handler flow, and the colocated event violations.
4. `04-bricks`  
   Generic custom-role and rule modeling with Bricks, plus the colocated Bricks violations.
5. `05-entity-framework`  
   EF mapping metadata as a dedicated layer on top of DDD roles.
6. `06-analyzer-workbench`  
   Analyzer-enabled green baseline only; intentional violations now live with the relevant sample families.
7. `07-ddd-from-pdfs`  
   DDD patterns derived from local PDF books and mapped to nMolecules C# samples.

## Folder Style

Newer or refreshed blocks use `scenarios/` subfolders so one block reads like one logical use case instead of a flat file dump.
Entry-point files such as `BricksSample.cs` or `EventsSample.cs` stay at block root, while the actual domain/application/infrastructure pieces live underneath the scenario folder.

## Project Style

Sample projects also share a common baseline:

- one sample project per teaching unit or isolated violation constellation
- shared SDK defaults via `samples/Directory.Build.props`
- local project files keep only sample-specific references or compile filtering
- block READMEs follow the same learning structure where possible: `Why`, `What`, `Code Walkthrough`, `Exercises`

## Build Everything

From superproject root:

```powershell
pwsh .\nmolecules.examples\samples\build-all.ps1
```
