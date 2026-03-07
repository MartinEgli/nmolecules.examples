# Architecture Style Sample: Hexagonal

This sample focuses only on hexagonal markers.

## Why This Style Sample Exists

Hexagonal architecture is easiest to read when the application core, ports, and adapters are separated from other style concerns.

## What You Learn

Covered markers:

- `[Application]`
- `[PrimaryPort]`
- `[SecondaryPort]`
- `[PrimaryAdapter]`
- `[SecondaryAdapter]`

## Code Walkthrough

- `HexagonalSample.cs` models the application core and both adapter directions in one compact file
- the sample keeps inbound and outbound boundaries visible through primary and secondary ports
- adapters are shown as outer implementation roles rather than as core logic

## Try Next

1. Add a second secondary adapter that implements the same outbound port.
2. Introduce a direct adapter-to-core shortcut and compare it with the intended port-based structure.
3. Build `Samples.Architecture.Hexagonal.Violations.csproj` and compare the broken port and adapter boundaries with the green sample.
