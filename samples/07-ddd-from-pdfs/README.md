# Block 07: DDD Samples Derived from PDFs

This block maps recurring DDD examples from local PDF books in `books/` into compilable C# samples.

## Goal

Turn book-level DDD patterns into concrete nMolecules examples that can be read and built in the workspace.

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

## Notes

- The samples are intentionally modeled in C# with nMolecules attributes.
- They are not verbatim copies of book code snippets.
- The focus is on the same DDD intent in executable sample form.
