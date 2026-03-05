# Block 05: Entity Framework Metadata

This block demonstrates `NMolecules.Persistence.EntityFramework`.

## Why This Block Exists

Core DDD roles should stay persistence-agnostic.
EF-specific mapping intent belongs in a separate metadata layer.
This block shows how to keep that split explicit.

## What You Learn

- context metadata with `[EfDbContext]`
- entity/table metadata with `[EfEntityType]`
- owned value object hints via `[EfOwnedValueObject]`
- member-level mapping hints (`EfBackingField`, `EfConcurrencyToken`, `EfValueConverter`, `EfIgnore`)

## Code Walkthrough

- `EntityFrameworkSample.cs` models one aggregate (`Order`) with EF metadata
- DDD and EF markers are used together, but each keeps a clear responsibility
- converter type is represented by a lightweight marker class

## Exercises

1. Add a second aggregate and map it to a different table/schema.
2. Add a second owned value object and set `Owner` explicitly.
3. Add a calculated property and annotate it with `EfIgnore`.
