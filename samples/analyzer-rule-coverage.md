# Analyzer Rule Coverage Matrix

Status baseline: March 7, 2026

This matrix maps every current Roslyn analyzer rule id to at least one intentional violation sample in the owning sample blocks.
Intentional violations now live in Blocks `01` to `04`, while Block `06` remains the green analyzer comparison baseline.

## AggregateRootAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesAggregateRoot0001` - `XMoleculesAggregateRoot0008` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## ApplicationServiceAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesApplicationService0001` - `XMoleculesApplicationService0004` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## BoundedContextAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesBoundedContext0001`, `XMoleculesBoundedContext0002` | `samples/01-ddd-core/violations/metadata/BadBoundedContextMissing.cs` via `Samples.Block01.DddCore.BoundedContextMissing.csproj` |
| `XMoleculesBoundedContext0003`, `XMoleculesBoundedContext0007` | `samples/01-ddd-core/violations/metadata/BadBoundedContextConsistency.cs` via `Samples.Block01.DddCore.BoundedContextConsistency.csproj` |
| `XMoleculesBoundedContext0004`, `XMoleculesBoundedContext0005` | `samples/01-ddd-core/violations/metadata/BadBoundedContextNamesAndOwnership.cs` via `Samples.Block01.DddCore.BoundedContextNamesAndOwnership.csproj` |
| `XMoleculesBoundedContext0006`, `XMoleculesBoundedContext0008`, `XMoleculesBoundedContext0009` | `samples/01-ddd-core/violations/metadata/BadBoundedContextDependencies.cs` via `Samples.Block01.DddCore.BoundedContextDependencies.csproj` |

## BricksAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesBricks0001`, `XMoleculesBricks0002` | `samples/04-bricks/violations/BadBrickRules.cs` via `Samples.Block04.Bricks.Violations.csproj` |
| `XMoleculesBricks0003` | `samples/04-bricks/member-contracts/use-cases/OnlyOneUseCase.cs` via `Samples.Block04.Bricks.Violations.csproj` |
| `XMoleculesBricks0004` | `samples/04-bricks/member-contracts/use-cases/AndAPlusBUseCase.cs` via `Samples.Block04.Bricks.Violations.csproj` |
| `XMoleculesBricks0005` | `samples/04-bricks/member-contracts/use-cases/ExactlyTwoUseCase.cs` via `Samples.Block04.Bricks.Violations.csproj` |
| `XMoleculesBricks0006` | `samples/04-bricks/member-contracts/use-cases/XorUseCase.cs` via `Samples.Block04.Bricks.Violations.csproj` |

## CqrsAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesCQRS0001` | `samples/02-architecture-styles/cqrs/violations/BadCqrsCompleteness.cs` via `Samples.Architecture.Cqrs.Violations.csproj` |
| `XMoleculesCQRS0002` - `XMoleculesCQRS0006` | `samples/02-architecture-styles/cqrs/violations/BadCqrsRules.cs` via `Samples.Architecture.Cqrs.Violations.csproj` |

## CrossStyleAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesCrossStyle0001` | `samples/02-architecture-styles/layered/violations/BadLayeredStyleMix.cs` via `Samples.Architecture.Layered.CrossStyle.csproj` |
| `XMoleculesCrossStyle0002` | `samples/02-architecture-styles/cqrs/violations/BadCrossStyleCqrs.cs` via `Samples.Architecture.Cqrs.Violations.csproj` |
| `XMoleculesCrossStyle0003` | `samples/02-architecture-styles/onion-simplified/violations/BadOnionStyleMix.cs` via `Samples.Architecture.OnionSimplified.CrossStyle.csproj` |

## DomainServiceAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesDomainService0001` - `XMoleculesDomainService0004` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## EntityAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesEntity0001` - `XMoleculesEntity0008` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## EventAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesDomainEvent0001` - `XMoleculesDomainEvent0009` | `samples/03-events/violations/events/BadDomainEventRules.cs` via `Samples.Block03.Events.Violations.csproj` |

## EventStormingAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesEventStorming0001` - `XMoleculesEventStorming0005` | `samples/02-architecture-styles/event-storming/violations/BadEventStormingRules.cs` via `Samples.Architecture.EventStorming.Violations.csproj` |

## FactoryAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesFactory0001` - `XMoleculesFactory0004` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## HexagonalAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesHexagonal0001` - `XMoleculesHexagonal0005` | `samples/02-architecture-styles/hexagonal/violations/BadHexagonalRules.cs` via `Samples.Architecture.Hexagonal.Violations.csproj` |

## IdentityAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesIdentity0001` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## LayerAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesLayered0001` - `XMoleculesLayered0006` | `samples/02-architecture-styles/layered/violations/BadLayeredRules.cs` via `Samples.Architecture.Layered.Violations.csproj` |

## MicroservicesAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesMicroservices0001` - `XMoleculesMicroservices0006` | `samples/02-architecture-styles/microservices/violations/BadMicroservicesRules.cs` via `Samples.Architecture.Microservices.Violations.csproj` |

## ModuleAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesModule0001`, `XMoleculesModule0002`, `XMoleculesModule0003` | `samples/01-ddd-core/violations/metadata/BadModuleMissing.cs` via `Samples.Block01.DddCore.ModuleMissing.csproj` |
| `XMoleculesModule0004` | `samples/01-ddd-core/violations/metadata/BadModuleUnknownContext.cs` via `Samples.Block01.DddCore.ModuleUnknownContext.csproj` |
| `XMoleculesModule0005`, `XMoleculesModule0006` | `samples/01-ddd-core/violations/metadata/BadModuleConsistency.cs` via `Samples.Block01.DddCore.ModuleConsistency.csproj` |
| `XMoleculesModule0007` | `samples/01-ddd-core/violations/metadata/BadModuleNameMap.cs` via `Samples.Block01.DddCore.ModuleNameMap.csproj` |

## OnionAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesOnion0001` | `samples/02-architecture-styles/onion-simplified/violations/BadOnionSimplifiedRules.cs` via `Samples.Architecture.OnionSimplified.Violations.csproj` |
| `XMoleculesOnion0002` - `XMoleculesOnion0004` | `samples/02-architecture-styles/onion-classic/violations/BadOnionClassicRules.cs` via `Samples.Architecture.OnionClassic.Violations.csproj` |
| `XMoleculesOnion0005` | `samples/02-architecture-styles/onion-simplified/violations/BadOnionStyleMix.cs` via `Samples.Architecture.OnionSimplified.CrossStyle.csproj` |

## RepositoryAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesRepository0001` - `XMoleculesRepository0007` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## ServiceAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesService0001` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |

## ValueObjectAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesValueObject0001` - `XMoleculesValueObject0009`, `XMoleculesValueObject1001`, `XMoleculesValueObject1002` | `samples/01-ddd-core/violations/ddd/BadDddRules.cs` via `Samples.Block01.DddCore.Violations.csproj` |
