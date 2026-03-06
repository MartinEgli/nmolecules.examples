using NMolecules.Architecture.Cqrs;

namespace Samples.Block06.AnalyzerWorkbench.CqrsCompleteness;

// XMoleculesCQRS0001
// Violates because the compilation declares a query but no [QueryHandler]
// for that query exists anywhere in this isolated project.
[Query(Name = "FindMissingHandler", Namespace = "Samples.Bad.Cqrs")]
public sealed class FindMissingHandler
{
}
