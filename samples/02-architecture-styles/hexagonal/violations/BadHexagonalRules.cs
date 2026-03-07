using NMolecules.Architecture.Hexagonal;

namespace Samples.Architecture.Hexagonal.Violations;

// XMoleculesHexagonal0001
// Violates because the application core depends on a primary port instead of
// owning the use-case boundary itself.
[Application]
public sealed class ApplicationCoreDependingOnPort
{
    private readonly IPrimaryCommandPort _port = default!;
}

// XMoleculesHexagonal0002
// Violates because a primary port references a primary adapter.
[PrimaryPort]
public interface IPrimaryCommandPort
{
    void Execute(HttpPrimaryAdapter adapter);
}

// XMoleculesHexagonal0003
// Violates because a secondary port references a secondary adapter.
[SecondaryPort]
public interface ISecondaryStoragePort
{
    void Save(SqlSecondaryAdapter adapter);
}

// XMoleculesHexagonal0004
// Violates because the primary adapter is not wired through a matching port.
[PrimaryAdapter]
public sealed class HttpPrimaryAdapter
{
}

// XMoleculesHexagonal0005
// Violates because the secondary adapter is not wired through a matching port.
[SecondaryAdapter]
public sealed class SqlSecondaryAdapter
{
}
