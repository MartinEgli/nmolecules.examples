# Block 01: DDD Core

This block introduces the DDD marker family from `NMolecules.DDD`.

## Why This Block Exists

Many teams use DDD words in class names, but the role is still implicit.
nMolecules makes those roles explicit with attributes so humans and tools share the same model.

## What You Learn

- how to model `AggregateRoot`, `Entity`, `ValueObject`, `Identity`
- how to separate `DomainService` and `ApplicationService`
- how to describe context/module metadata via `BoundedContext` and `Module`
- how legacy `Service` and explicit `AllowRepositoryComposition` are represented for compatibility cases

## Code Walkthrough

- `DddCoreSample.cs`: complete mini-domain in one file
- `DddLegacyAndCompositionSample.cs`: compatibility-focused examples for `[Entity]`, legacy `[Service]`, and `[AllowRepositoryComposition]`
- assembly-level context/module metadata at the top
- aggregate root + value object identity pattern
- domain service for business policy
- application service for use-case orchestration

## Exercises

1. Add a second aggregate root and reuse the same context metadata.
2. Move an orchestration method from `OpenCustomerAccountUseCase` into `CustomerCreditPolicy` and verify whether that still fits the domain-service responsibility.
3. Rename `CustomerRepository` to a domain language name and keep the `[Repository]` marker so the role remains explicit.
