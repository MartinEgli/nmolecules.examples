# Analyzer Rule Coverage Matrix

Status baseline: March 6, 2026

This matrix maps every current Roslyn analyzer rule id to at least one intentional violation sample in `samples/06-analyzer-workbench`.

## AggregateRootAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesAggregateRoot0001` - `XMoleculesAggregateRoot0008` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## ApplicationServiceAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesApplicationService0001` - `XMoleculesApplicationService0004` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## BoundedContextAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesBoundedContext0001`, `XMoleculesBoundedContext0002` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadBoundedContextMissing.cs` via `Samples.Block06.AnalyzerViolations.BoundedContextMissing.csproj` |
| `XMoleculesBoundedContext0003`, `XMoleculesBoundedContext0007` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadBoundedContextConsistency.cs` via `Samples.Block06.AnalyzerViolations.BoundedContextConsistency.csproj` |
| `XMoleculesBoundedContext0004`, `XMoleculesBoundedContext0005` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadBoundedContextNamesAndOwnership.cs` via `Samples.Block06.AnalyzerViolations.BoundedContextNamesAndOwnership.csproj` |
| `XMoleculesBoundedContext0006`, `XMoleculesBoundedContext0008`, `XMoleculesBoundedContext0009` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadBoundedContextDependencies.cs` via `Samples.Block06.AnalyzerViolations.BoundedContextDependencies.csproj` |

## BricksAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesBricks0001`, `XMoleculesBricks0002` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadMetadataAndBrickRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## CqrsAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesCQRS0001` | `samples/06-analyzer-workbench/scenarios/violations/isolated/BadCqrsCompleteness.cs` via `Samples.Block06.AnalyzerViolations.CqrsCompleteness.csproj` |
| `XMoleculesCQRS0002` - `XMoleculesCQRS0006` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadCqrsAndHexagonalRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## CrossStyleAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesCrossStyle0001` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadLayeredAndOnionRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |
| `XMoleculesCrossStyle0002` | `samples/06-analyzer-workbench/scenarios/violations/isolated/BadCrossStyleCqrs.cs` via `Samples.Block06.AnalyzerViolations.CrossStyleCqrs.csproj` |
| `XMoleculesCrossStyle0003` | `samples/06-analyzer-workbench/scenarios/violations/isolated/BadCrossStyleOnion.cs` via `Samples.Block06.AnalyzerViolations.CrossStyleOnion.csproj` |

## DomainServiceAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesDomainService0001` - `XMoleculesDomainService0004` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## EntityAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesEntity0001` - `XMoleculesEntity0008` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## EventAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesDomainEvent0001` - `XMoleculesDomainEvent0009` | `samples/06-analyzer-workbench/scenarios/violations/events/BadDomainEventRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## EventStormingAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesEventStorming0001` - `XMoleculesEventStorming0005` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadMicroservicesAndEventStormingRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## FactoryAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesFactory0001` - `XMoleculesFactory0004` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## HexagonalAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesHexagonal0001` - `XMoleculesHexagonal0005` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadCqrsAndHexagonalRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## IdentityAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesIdentity0001` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## LayerAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesLayered0001` - `XMoleculesLayered0006` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadLayeredAndOnionRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## MicroservicesAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesMicroservices0001` - `XMoleculesMicroservices0006` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadMicroservicesAndEventStormingRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## ModuleAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesModule0001`, `XMoleculesModule0002`, `XMoleculesModule0003` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadModuleMissing.cs` via `Samples.Block06.AnalyzerViolations.ModuleMissing.csproj` |
| `XMoleculesModule0004` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadModuleUnknownContext.cs` via `Samples.Block06.AnalyzerViolations.ModuleUnknownContext.csproj` |
| `XMoleculesModule0005`, `XMoleculesModule0006` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadModuleConsistency.cs` via `Samples.Block06.AnalyzerViolations.ModuleConsistency.csproj` |
| `XMoleculesModule0007` | `samples/06-analyzer-workbench/scenarios/violations/metadata/BadModuleNameMap.cs` via `Samples.Block06.AnalyzerViolations.ModuleNameMap.csproj` |

## OnionAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesOnion0001` - `XMoleculesOnion0004` | `samples/06-analyzer-workbench/scenarios/violations/architecture/BadLayeredAndOnionRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |
| `XMoleculesOnion0005` | `samples/06-analyzer-workbench/scenarios/violations/isolated/BadCrossStyleOnion.cs` via `Samples.Block06.AnalyzerViolations.CrossStyleOnion.csproj` |

## RepositoryAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesRepository0001` - `XMoleculesRepository0007` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## ServiceAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesService0001` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |

## ValueObjectAnalyzers

| Rule ids | Sample |
|---|---|
| `XMoleculesValueObject0001` - `XMoleculesValueObject0009`, `XMoleculesValueObject1001`, `XMoleculesValueObject1002` | `samples/06-analyzer-workbench/scenarios/violations/ddd/BadDddRules.cs` via `Samples.Block06.AnalyzerViolations.csproj` |
