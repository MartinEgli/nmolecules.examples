# Block 02: Architecture Styles

This block is now split into one sample project per architecture style, with architecture-specific analyzer violations living next to the green samples instead of in Block 06.

## Why This Block Exists

Mixing multiple structural styles in one sample quickly becomes noisy and can even trigger intentional cross-style diagnostics.
This block keeps each style isolated so its markers and dependency direction stay easy to read.

## Projects

- `layered/Samples.Architecture.Layered.csproj`
- `layered/Samples.Architecture.Layered.Violations.csproj`
- `layered/Samples.Architecture.Layered.CrossStyle.csproj`
- `cqrs/Samples.Architecture.Cqrs.csproj`
- `cqrs/Samples.Architecture.Cqrs.Violations.csproj`
- `onion-classic/Samples.Architecture.OnionClassic.csproj`
- `onion-classic/Samples.Architecture.OnionClassic.Violations.csproj`
- `onion-simplified/Samples.Architecture.OnionSimplified.csproj`
- `onion-simplified/Samples.Architecture.OnionSimplified.Violations.csproj`
- `onion-simplified/Samples.Architecture.OnionSimplified.CrossStyle.csproj`
- `hexagonal/Samples.Architecture.Hexagonal.csproj`
- `hexagonal/Samples.Architecture.Hexagonal.Violations.csproj`
- `microservices/Samples.Architecture.Microservices.csproj`
- `microservices/Samples.Architecture.Microservices.Violations.csproj`
- `event-storming/Samples.Architecture.EventStorming.csproj`
- `event-storming/Samples.Architecture.EventStorming.Violations.csproj`
- `mvvm/Samples.Architecture.Mvvm.csproj`

## Style-Specific Solutions

- `../../nMolecules.Examples.Layered.slnx`
- `../../nMolecules.Examples.Cqrs.slnx`
- `../../nMolecules.Examples.OnionClassic.slnx`
- `../../nMolecules.Examples.OnionSimplified.slnx`
- `../../nMolecules.Examples.Hexagonal.slnx`
- `../../nMolecules.Examples.Microservices.slnx`
- `../../nMolecules.Examples.EventStorming.slnx`
- `../../nMolecules.Examples.Mvvm.slnx`

## What You Learn

- how each architecture style is represented with dedicated nMolecules markers
- how one focused sample file can express the structural intent of a style
- how to compare each green sample with a colocated violations project for the same style

## Code Walkthrough

- each subfolder contains one focused green sample and, where analyzer rules exist, one adjacent violations project
- the green project files stay intentionally small and reference only the marker package they need
- cross-style violations remain local to the affected style folder, so Block 06 no longer carries architecture-specific detours
- the style-specific `.slnx` files let you open one style in isolation

## Exercises

1. Build one style-specific project and identify the marker set it uses.
2. Compare the `layered` and `onion-classic` samples and note how dependency direction is expressed differently.
3. Open one style-specific `.slnx` file and keep only that style in view while exploring the markers.
