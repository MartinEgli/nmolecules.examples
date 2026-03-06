# Block 02: Architecture Styles

This block is now split into one sample project per architecture style.

## Projects

- `layered/Samples.Architecture.Layered.csproj`
- `cqrs/Samples.Architecture.Cqrs.csproj`
- `onion-classic/Samples.Architecture.OnionClassic.csproj`
- `onion-simplified/Samples.Architecture.OnionSimplified.csproj`
- `hexagonal/Samples.Architecture.Hexagonal.csproj`
- `microservices/Samples.Architecture.Microservices.csproj`
- `event-storming/Samples.Architecture.EventStorming.csproj`
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

## Why This Split Exists

Cross-style combinations in one project can produce style-mixing diagnostics.
Separate projects make each style easier to learn and keep examples unambiguous.
