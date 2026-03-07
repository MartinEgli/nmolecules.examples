# Architecture Style Sample: Layered

This sample focuses only on layered architecture markers.

## Why This Style Sample Exists

Layered architecture is mostly about dependency direction, so a minimal isolated sample makes the intended boundaries easier to inspect.

## What You Learn

Covered markers:

- `[DomainLayer]`
- `[ApplicationLayer]`
- `[InfrastructureLayer]`
- `[InterfaceLayer]`
- `[UserInterfaceLayer]`

## Code Walkthrough

- `LayeredSample.cs` keeps all layer markers close together for quick comparison
- the sample distinguishes interface and user-interface concerns explicitly
- the focus is on role visibility, not on a large business domain

## Try Next

1. Add a second application-layer type and keep the dependency direction unchanged.
2. Build `Samples.Architecture.Layered.Violations.csproj` and compare the invalid dependency directions with the good sample.
3. Build `Samples.Architecture.Layered.CrossStyle.csproj` to inspect the dedicated Layered-versus-Onion style clash.
