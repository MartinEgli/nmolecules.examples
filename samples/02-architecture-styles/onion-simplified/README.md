# Architecture Style Sample: Onion Simplified

This sample focuses only on simplified onion markers.

## Why This Style Sample Exists

The simplified onion style collapses some classic rings, so it deserves its own focused sample instead of being mixed with the classic variant.

## What You Learn

Covered markers:

- `[DomainRing]`
- `[ApplicationRing]`
- `[InfrastructureRing]`

## Code Walkthrough

- `OnionSimplifiedSample.cs` shows the three-ring simplified onion interpretation
- the sample highlights the reduced ring set compared with classic onion
- it is intentionally compact so the marker model stays easy to compare

## Try Next

1. Add a second application-ring type and keep dependencies pointing inward.
2. Compare the simplified ring set with the classic onion sample.
3. Build `Samples.Architecture.OnionSimplified.Violations.csproj` for simplified onion rules and `Samples.Architecture.OnionSimplified.CrossStyle.csproj` for classic-versus-simplified mixing.
