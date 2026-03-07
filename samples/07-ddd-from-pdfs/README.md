# Block 07: DDD Samples Derived from PDFs

This block maps recurring DDD examples from local PDF books in `books/` into compilable C# samples.

## Why This Block Exists

Book explanations are useful, but they are easier to internalize when the same ideas appear as small compilable samples in the workspace.
This block turns narrative DDD guidance into explicit nMolecules role modeling.

## What You Learn

- how book-level DDD guidance maps to concrete nMolecules markers
- how aggregate consistency, value objects, and application-service boundaries look in executable samples
- how to keep the original DDD intent without copying book code verbatim

## Source Mapping

The files below are derived from patterns in these PDFs:

- `books/Implementing Domain-Driven Design - Vernon.pdf`
- `books/Domain-Driven Design Distilled.pdf`

## Sample Files

- `PdfDerivedApplicationServiceSample.cs`  
  derived from IDDD p.67: one application-service method per explicit use case
- `PdfDerivedAggregateConsistencySample.cs`  
  derived from DDD Distilled p.79-82: aggregate identity references and eventual consistency via domain event
- `PdfDerivedAuthorValueObjectSample.cs`  
  derived from IDDD p.119-121: explicit `Author` value object and cleaner application-service orchestration

## Code Walkthrough

- `PdfDerivedApplicationServiceSample.cs` focuses on explicit use-case orchestration
- `PdfDerivedAggregateConsistencySample.cs` focuses on aggregate references and eventual consistency via domain events
- `PdfDerivedAuthorValueObjectSample.cs` focuses on value-object modeling and cleaner collaboration boundaries

## Notes

- The samples are intentionally modeled in C# with nMolecules attributes.
- They are not verbatim copies of book code snippets.
- The focus is on the same DDD intent in executable sample form.

## Exercises

1. Pick one PDF-derived sample and explain which nMolecules markers make the book concept explicit.
2. Add a second small example derived from the same book section without copying the original snippet.
3. Compare one PDF-derived sample with its nearest equivalent in Block 01 or Block 03.
