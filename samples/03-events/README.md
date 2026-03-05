# Block 03: Events

This block demonstrates event markers from `NMolecules.Events`.

## Why This Block Exists

Teams often publish events but do not model them as first-class domain concepts.
This block shows how event payloads, publishers, and handlers become explicit roles.

## What You Learn

- how to mark payload types with `[DomainEvent]`
- how to mark publishers with `[DomainEventPublisher]`
- how to mark handlers with `[DomainEventHandler]`
- how to keep event flow readable for architecture reviews

## Code Walkthrough

- `EventsSample.cs` contains a simple "invoice created" flow
- the publisher abstraction and in-memory implementation are separated
- an audit handler and a projection handler react to the same event

## Exercises

1. Add a second event type (`InvoiceCancelled`) and separate handlers.
2. Add a publisher method that emits both events and inspect diagnostics.
3. Move one handler method to a delegate and keep the event marker explicit.
