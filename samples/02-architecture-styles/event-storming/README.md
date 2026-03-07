# Architecture Style Sample: Event Storming

This sample focuses only on Event Storming design-model markers.

## Why This Style Sample Exists

Event Storming roles become clearer when actors, commands, events, policies, and read models are shown in one compact flow.

## What You Learn

Covered markers:

- `[Actor]`
- `[Command]`
- `[DomainEvent]`
- `[Policy]`
- `[ReadModel]`
- `[ExternalSystem]`
- `[Aggregate]`

## Code Walkthrough

- `EventStormingSample.cs` keeps the event-storming language in one place
- the sample highlights how commands target aggregates and how policies react to domain events
- read models and external systems are included as separate roles instead of being mixed into aggregate behavior

## Try Next

1. Add a second policy that reacts to the same domain event.
2. Add an external-system integration point that does not touch the aggregate directly.
3. Build `Samples.Architecture.EventStorming.Violations.csproj` and compare the broken event flow with the green sample.
