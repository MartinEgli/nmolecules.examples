# Attribute Coverage Matrix

This matrix maps every current nMolecules attribute to at least one sample location.

Status baseline: March 5, 2026

## DDD (`NMolecules.DDD`)

| Attribute | Sample |
|---|---|
| `AggregateRoot` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/06-analyzer-workbench/GoodExample.cs` |
| `AllowRepositoryComposition` | `samples/01-ddd-core/DddLegacyAndCompositionSample.cs`, `samples/06-analyzer-workbench/BadExample.cs` |
| `ApplicationService` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/06-analyzer-workbench/GoodExample.cs` |
| `BoundedContext` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `DomainService` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/06-analyzer-workbench/GoodExample.cs` |
| `Entity` | `samples/01-ddd-core/DddLegacyAndCompositionSample.cs` |
| `Factory` | `samples/01-ddd-core/DddCoreSample.cs` |
| `Identity` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/06-analyzer-workbench/GoodExample.cs` |
| `Module` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `Repository` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/06-analyzer-workbench/GoodExample.cs` |
| `Service` (legacy) | `samples/01-ddd-core/DddLegacyAndCompositionSample.cs`, `samples/06-analyzer-workbench/BadExample.cs` |
| `ValueObject` | `samples/01-ddd-core/DddCoreSample.cs`, `samples/05-entity-framework/EntityFrameworkSample.cs` |

## Architecture (`NMolecules.Architecture`)

### Layered

| Attribute | Sample |
|---|---|
| `ApplicationLayer` | `samples/02-architecture-styles/layered/LayeredSample.cs` |
| `DomainLayer` | `samples/02-architecture-styles/layered/LayeredSample.cs` |
| `InfrastructureLayer` | `samples/02-architecture-styles/layered/LayeredSample.cs` |
| `InterfaceLayer` | `samples/02-architecture-styles/layered/LayeredSample.cs` |
| `UserInterfaceLayer` | `samples/02-architecture-styles/layered/LayeredSample.cs` |

### CQRS

| Attribute | Sample |
|---|---|
| `Command` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |
| `CommandDispatcher` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |
| `CommandHandler` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |
| `Projection` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |
| `Query` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |
| `QueryHandler` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |
| `QueryModel` | `samples/02-architecture-styles/cqrs/CqrsSample.cs` |

### Microservices

| Attribute | Sample |
|---|---|
| `ApiGateway` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |
| `BackendForFrontend` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |
| `IntegrationEvent` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |
| `Microservice` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |
| `SagaOrchestrator` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |
| `SagaParticipant` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |
| `ServiceContract` | `samples/02-architecture-styles/microservices/MicroservicesSample.cs` |

### Event Storming

| Attribute | Sample |
|---|---|
| `Actor` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |
| `Aggregate` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |
| `Command` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |
| `DomainEvent` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |
| `ExternalSystem` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |
| `Policy` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |
| `ReadModel` | `samples/02-architecture-styles/event-storming/EventStormingSample.cs` |

### Onion Classic

| Attribute | Sample |
|---|---|
| `ApplicationServiceRing` | `samples/02-architecture-styles/onion-classic/OnionClassicSample.cs` |
| `DomainModelRing` | `samples/02-architecture-styles/onion-classic/OnionClassicSample.cs` |
| `DomainServiceRing` | `samples/02-architecture-styles/onion-classic/OnionClassicSample.cs` |
| `InfrastructureRing` | `samples/02-architecture-styles/onion-classic/OnionClassicSample.cs` |

### Onion Simplified

| Attribute | Sample |
|---|---|
| `ApplicationRing` | `samples/02-architecture-styles/onion-simplified/OnionSimplifiedSample.cs` |
| `DomainRing` | `samples/02-architecture-styles/onion-simplified/OnionSimplifiedSample.cs` |
| `InfrastructureRing` | `samples/02-architecture-styles/onion-simplified/OnionSimplifiedSample.cs` |

### Hexagonal

| Attribute | Sample |
|---|---|
| `Application` | `samples/02-architecture-styles/hexagonal/HexagonalSample.cs` |
| `PrimaryAdapter` | `samples/02-architecture-styles/hexagonal/HexagonalSample.cs` |
| `PrimaryPort` | `samples/02-architecture-styles/hexagonal/HexagonalSample.cs` |
| `SecondaryAdapter` | `samples/02-architecture-styles/hexagonal/HexagonalSample.cs` |
| `SecondaryPort` | `samples/02-architecture-styles/hexagonal/HexagonalSample.cs` |

### MVVM

| Attribute | Sample |
|---|---|
| `Model` | `samples/02-architecture-styles/mvvm/MvvmSample.cs` |
| `View` | `samples/02-architecture-styles/mvvm/MvvmSample.cs` |
| `ViewModel` | `samples/02-architecture-styles/mvvm/MvvmSample.cs` |

## Events (`NMolecules.Events`)

| Attribute | Sample |
|---|---|
| `DomainEvent` | `samples/03-events/EventsSample.cs` |
| `DomainEventHandler` | `samples/03-events/EventsSample.cs` |
| `DomainEventPublisher` | `samples/03-events/EventsSample.cs` |

## Bricks (`NMolecules.Bricks`)

| Attribute | Sample |
|---|---|
| `BrickRole` | `samples/04-bricks/BricksSample.cs` |
| `BrickRoleAlias` | `samples/04-bricks/BricksSample.cs` |
| `BrickRule` | `samples/04-bricks/BricksSample.cs` |

## Persistence Entity Framework (`NMolecules.Persistence.EntityFramework`)

| Attribute | Sample |
|---|---|
| `EfBackingField` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `EfConcurrencyToken` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `EfDbContext` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `EfEntityType` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `EfIgnore` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `EfOwnedValueObject` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
| `EfValueConverter` | `samples/05-entity-framework/EntityFrameworkSample.cs` |
