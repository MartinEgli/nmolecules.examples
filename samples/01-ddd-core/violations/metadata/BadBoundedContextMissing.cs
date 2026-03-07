using NMolecules.DDD;

// Violates because the bounded context metadata is declared without Id or Name.
[assembly: BoundedContext]

namespace Samples.Block06.AnalyzerWorkbench.BoundedContextMissing;

public static class Marker
{
}
