# Architecture Style Sample: Onion Classic

This sample focuses only on classic onion markers.

## Why This Style Sample Exists

Classic onion architecture has more ring distinctions than the simplified version, so it helps to show those rings in isolation.

## What You Learn

Covered markers:

- `[DomainModelRing]`
- `[DomainServiceRing]`
- `[ApplicationServiceRing]`
- `[InfrastructureRing]`

## Code Walkthrough

- `OnionClassicSample.cs` separates the domain model ring, domain service ring, application service ring, and infrastructure ring
- the sample focuses on ring identity and dependency direction, not on a large business domain
- it is intended to be compared directly with the simplified onion sample next door

## Try Next

1. Add another domain-service-ring type and keep it independent from outer rings.
2. Compare the ring split here with the simplified onion sample.
3. Build `Samples.Architecture.OnionClassic.Violations.csproj` and compare the inward violations with the green sample.
