using NMolecules.DDD;

// Violates because the module metadata is declared without Id, Name, or BoundedContextId.
[module: Module]

namespace Samples.Block06.AnalyzerWorkbench.ModuleMissing;

public static class Marker
{
}
