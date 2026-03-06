using NMolecules.Events;

namespace Samples.Block03.Events;

[DomainEvent]
public readonly record struct InvoiceCreated(string InvoiceId, decimal Amount);
