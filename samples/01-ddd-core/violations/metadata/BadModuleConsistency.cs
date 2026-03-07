using NMolecules.DDD;

// Violates because the same module Id is declared with different names and
// different bounded-context ownership.
[assembly: Module(Id = "Accounts", Name = "Accounts Core", BoundedContextId = "Billing")]
[module: Module(Id = "Accounts", Name = "Accounts Api", BoundedContextId = "Sales")]

namespace Samples.Block06.AnalyzerWorkbench.ModuleConsistency;

public static class Marker
{
}
