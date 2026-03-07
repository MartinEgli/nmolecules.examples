# Architecture Style Sample: Microservices

This sample focuses only on microservices architecture markers.

## Why This Style Sample Exists

Microservice edge roles are easiest to learn when gateways, contracts, events, and saga roles are presented without unrelated architectural noise.

## What You Learn

Covered markers:

- `[Microservice]`
- `[ApiGateway]`
- `[BackendForFrontend]`
- `[ServiceContract]`
- `[IntegrationEvent]`
- `[SagaOrchestrator]`
- `[SagaParticipant]`

## Code Walkthrough

- `MicroservicesSample.cs` keeps the service-edge vocabulary in one compact place
- the sample distinguishes service contracts from concrete microservice implementations
- saga and integration-event roles are included so cross-service collaboration is visible

## Try Next

1. Add a second service contract and let the gateway depend on both.
2. Add an integration event consumed by a saga participant.
3. Build `Samples.Architecture.Microservices.Violations.csproj` and compare the edge-role diagnostics with the green sample.
