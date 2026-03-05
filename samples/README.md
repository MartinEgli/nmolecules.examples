# Pedagogical Sample Blocks

This folder contains the complete guided sample path.

Coverage reference:

- `attribute-coverage.md` maps all current attributes to concrete sample files.

## Blocks

1. `01-ddd-core`  
   DDD role modeling and bounded-context metadata.
2. `02-architecture-styles`  
   One dedicated project per style:
   `layered`, `cqrs`, `onion-classic`, `onion-simplified`, `hexagonal`, `microservices`, `event-storming`, `mvvm`.
3. `03-events`  
   Domain event payload, publisher, and handler flow.
4. `04-bricks`  
   Generic custom-role and rule modeling with Bricks.
5. `05-entity-framework`  
   EF mapping metadata as a dedicated layer on top of DDD roles.
6. `06-analyzer-workbench`  
   Separate `good` and `violations` projects to inspect analyzer diagnostics.
7. `07-ddd-from-pdfs`  
   DDD patterns derived from local PDF books and mapped to nMolecules C# samples.

## Build Everything

From superproject root:

```powershell
pwsh .\nmolecules.examples\samples\build-all.ps1
```
