using NMolecules.Architecture.Layered;
using NMolecules.DDD;

namespace Samples.Block01.DddCore.Violations;

// This file intentionally groups classic DDD violations.
// Each sample keeps the broken dependency in-place so the matching analyzer id
// can be understood directly from the surrounding code.

// Aggregate-root support types.
[Repository]
public interface IAggregateRepository
{
}

[Factory]
public interface IAggregateFactory
{
}

[DomainService]
public sealed class PricingDomainPolicy
{
}

[ApplicationService]
public sealed class CheckoutApplicationService
{
}

[Service]
public sealed class LegacyPricingService
{
}

[AggregateRoot]
public sealed class SupportingAggregateRoot
{
    [Identity]
    public string Id { get; } = "aggregate-root";
}

// XMoleculesAggregateRoot0001
// Violates because an aggregate root reaches into a repository directly.
[AggregateRoot]
public sealed class AggregateUsingRepository
{
    private readonly IAggregateRepository _repository = default!;

    [Identity]
    public string Id { get; } = "aggregate-repository";
}

// XMoleculesAggregateRoot0002
// Violates because an aggregate root depends on a domain service instead of
// protecting its own invariants.
[AggregateRoot]
public sealed class AggregateUsingDomainService
{
    private readonly PricingDomainPolicy _policy = default!;

    [Identity]
    public string Id { get; } = "aggregate-domain-service";
}

// XMoleculesAggregateRoot0003
// Violates because an aggregate root must expose exactly one identity.
[AggregateRoot]
public sealed class AggregateWithoutIdentity
{
}

// XMoleculesAggregateRoot0004
// Violates because an aggregate root exposes multiple identities.
[AggregateRoot]
public sealed class AggregateWithMultipleIdentities
{
    [Identity]
    public string AggregateId { get; } = "aggregate-multi-1";

    [Identity]
    public string ExternalId { get; } = "aggregate-multi-2";
}

// XMoleculesAggregateRoot0005
// Violates because one aggregate root should not hold a direct reference to
// another aggregate root.
[AggregateRoot]
public sealed class AggregateUsingAggregate
{
    private readonly SupportingAggregateRoot _otherAggregate = default!;

    [Identity]
    public string Id { get; } = "aggregate-aggregate";
}

// XMoleculesAggregateRoot0006
// Violates because domain state depends on application orchestration.
[AggregateRoot]
public sealed class AggregateUsingApplicationService
{
    private readonly CheckoutApplicationService _applicationService = default!;

    [Identity]
    public string Id { get; } = "aggregate-application";
}

// XMoleculesAggregateRoot0007
// Violates because aggregate roots should not coordinate creation through
// factories they depend on.
[AggregateRoot]
public sealed class AggregateUsingFactory
{
    private readonly IAggregateFactory _factory = default!;

    [Identity]
    public string Id { get; } = "aggregate-factory";
}

// XMoleculesAggregateRoot0008
// Violates because the legacy [Service] role is too unspecific for aggregate
// dependencies.
[AggregateRoot]
public sealed class AggregateUsingLegacyService
{
    private readonly LegacyPricingService _legacyService = default!;

    [Identity]
    public string Id { get; } = "aggregate-legacy";
}

// Entity support types.
[Repository]
public interface IEntityRepository
{
}

[Factory]
public interface IEntityFactory
{
}

[Entity]
public sealed class SupportingEntity
{
    [Identity]
    public string Id { get; } = "entity";
}

// XMoleculesEntity0001
// Violates because entities should not talk to repositories.
[Entity]
public sealed class EntityUsingRepository
{
    private readonly IEntityRepository _repository = default!;

    [Identity]
    public string Id { get; } = "entity-repository";
}

// XMoleculesEntity0002
// Violates because entities should not hold direct aggregate-root references.
[Entity]
public sealed class EntityUsingAggregateRoot
{
    private readonly SupportingAggregateRoot _aggregateRoot = default!;

    [Identity]
    public string Id { get; } = "entity-aggregate";
}

// XMoleculesEntity0003
// Violates because entities should not depend on domain services.
[Entity]
public sealed class EntityUsingDomainService
{
    private readonly PricingDomainPolicy _policy = default!;

    [Identity]
    public string Id { get; } = "entity-domain-service";
}

// XMoleculesEntity0004
// Violates because an entity must expose exactly one identity.
[Entity]
public sealed class EntityWithoutIdentity
{
}

// XMoleculesEntity0005
// Violates because an entity exposes more than one identity.
[Entity]
public sealed class EntityWithMultipleIdentities
{
    [Identity]
    public string EntityId { get; } = "entity-multi-1";

    [Identity]
    public string TrackingId { get; } = "entity-multi-2";
}

// XMoleculesEntity0006
// Violates because entities should not depend on factories.
[Entity]
public sealed class EntityUsingFactory
{
    private readonly IEntityFactory _factory = default!;

    [Identity]
    public string Id { get; } = "entity-factory";
}

// XMoleculesEntity0007
// Violates because entities should stay independent from application services.
[Entity]
public sealed class EntityUsingApplicationService
{
    private readonly CheckoutApplicationService _applicationService = default!;

    [Identity]
    public string Id { get; } = "entity-application";
}

// XMoleculesEntity0008
// Violates because entities should not depend on the legacy [Service] role.
[Entity]
public sealed class EntityUsingLegacyService
{
    private readonly LegacyPricingService _legacyService = default!;

    [Identity]
    public string Id { get; } = "entity-legacy";
}

// XMoleculesApplicationService0001
// Violates because one type is marked as both application service and entity.
[ApplicationService]
[Entity]
public sealed class MixedRoleApplicationService
{
    [Identity]
    public string Id { get; } = "mixed-application";
}

[ApplicationService]
public sealed class SupportingApplicationService
{
}

// XMoleculesApplicationService0002
// Violates because application services should use explicit roles instead of
// the obsolete [Service] marker.
[ApplicationService]
public sealed class ApplicationServiceUsingLegacyService
{
    private readonly LegacyPricingService _legacyService = default!;
}

// XMoleculesApplicationService0003
// Violates because application services should not orchestrate each other.
[ApplicationService]
public sealed class ApplicationServiceUsingApplicationService
{
    private readonly SupportingApplicationService _otherApplicationService = default!;
}

// XMoleculesApplicationService0004
// Violates because an application-service signature leaks infrastructure types.
[InfrastructureLayer]
public sealed class SqlInfrastructureDto
{
}

[ApplicationService]
public sealed class ApplicationServiceExposingInfrastructureSignature
{
    public SqlInfrastructureDto Load()
    {
        return new SqlInfrastructureDto();
    }
}

// XMoleculesDomainService0001
// Violates because a domain service depends on an application service.
[DomainService]
public sealed class DomainServiceUsingApplicationService
{
    private readonly SupportingApplicationService _applicationService = default!;
}

// XMoleculesDomainService0002
// Violates because a domain service depends on a concrete repository
// implementation instead of staying persistence-agnostic.
[Repository]
public sealed class ConcreteBillingRepository
{
}

[DomainService]
public sealed class DomainServiceUsingConcreteRepository
{
    private readonly ConcreteBillingRepository _repository = default!;
}

// XMoleculesDomainService0003
// Violates because the public API of a domain service exposes infrastructure.
[DomainService]
public sealed class DomainServiceExposingInfrastructureSignature
{
    public SqlInfrastructureDto Load()
    {
        return new SqlInfrastructureDto();
    }
}

// XMoleculesDomainService0004
// Violates because a domain service depends on the legacy [Service] marker.
[DomainService]
public sealed class DomainServiceUsingLegacyService
{
    private readonly LegacyPricingService _legacyService = default!;
}

// XMoleculesRepository0001
// Violates because repositories should not depend on domain services.
[Repository]
public sealed class RepositoryUsingDomainService
{
    private readonly PricingDomainPolicy _policy = default!;
}

// XMoleculesRepository0002
// Violates because the repository API leaks infrastructure DTOs.
[Repository]
public sealed class RepositoryExposingInfrastructureSignature
{
    public SqlInfrastructureDto Save(SqlInfrastructureDto dto)
    {
        return dto;
    }
}

[Repository]
public interface IOtherRepository
{
}

// XMoleculesRepository0003
// Violates because repository-to-repository dependencies are not allowed by default.
[Repository]
public sealed class RepositoryUsingRepository
{
    private readonly IOtherRepository _otherRepository = default!;
}

// XMoleculesRepository0004
// Violates because approved repository composition still has to use repository
// contracts, not concrete repository implementations.
[Repository]
[AllowRepositoryComposition]
public interface IApprovedButInvalidRepository
{
    void Store(ConcreteBillingRepository repository);
}

// XMoleculesRepository0005
// Violates because repositories should not depend on factories.
[Repository]
public sealed class RepositoryUsingFactory
{
    private readonly IEntityFactory _factory = default!;
}

// XMoleculesRepository0006
// Violates because repositories should not depend on application services.
[Repository]
public sealed class RepositoryUsingApplicationService
{
    private readonly SupportingApplicationService _applicationService = default!;
}

// XMoleculesRepository0007
// Violates because repositories should not depend on the legacy [Service] role.
[Repository]
public sealed class RepositoryUsingLegacyService
{
    private readonly LegacyPricingService _legacyService = default!;
}

// XMoleculesFactory0001
// Violates because factories should not depend on application services.
[Factory]
public sealed class FactoryUsingApplicationService
{
    private readonly SupportingApplicationService _applicationService = default!;
}

// XMoleculesFactory0002
// Violates because factories should not depend on repositories.
[Factory]
public sealed class FactoryUsingRepository
{
    private readonly IEntityRepository _repository = default!;
}

// XMoleculesFactory0003
// Violates because one type is marked as both factory and value object.
[Factory]
[ValueObject]
public sealed class MixedRoleFactory
{
}

// XMoleculesFactory0004
// Violates because factories should not depend on other factories.
[Factory]
public sealed class FactoryUsingFactory
{
    private readonly IAggregateFactory _otherFactory = default!;
}

// XMoleculesService0001
// Violates because the legacy [Service] marker should be replaced by an explicit role.
[Service]
public sealed class LegacyStandaloneService
{
}

// XMoleculesIdentity0001
// Violates because [Identity] is only valid inside entities or aggregate roots.
public sealed class IdentityOutsideEntity
{
    [Identity]
    public string Id { get; } = "invalid-identity";
}

// XMoleculesValueObject0001
// Violates because a value object should not depend on an entity.
[ValueObject]
public sealed class ValueObjectUsingEntity : IEquatable<ValueObjectUsingEntity>
{
    private readonly SupportingEntity _entity = default!;

    public bool Equals(ValueObjectUsingEntity other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0002
// Violates because a value object should not depend on a domain service.
[ValueObject]
public sealed class ValueObjectUsingDomainService : IEquatable<ValueObjectUsingDomainService>
{
    private readonly PricingDomainPolicy _policy = default!;

    public bool Equals(ValueObjectUsingDomainService other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0003
// Violates because a value object should not depend on a repository.
[ValueObject]
public sealed class ValueObjectUsingRepository : IEquatable<ValueObjectUsingRepository>
{
    private readonly IEntityRepository _repository = default!;

    public bool Equals(ValueObjectUsingRepository other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0004
// Violates because a value object should not depend on an aggregate root.
[ValueObject]
public sealed class ValueObjectUsingAggregateRoot : IEquatable<ValueObjectUsingAggregateRoot>
{
    private readonly SupportingAggregateRoot _aggregateRoot = default!;

    public bool Equals(ValueObjectUsingAggregateRoot other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0005
// Violates because a value object is mutable.
[ValueObject]
public sealed class MutableValueObject : IEquatable<MutableValueObject>
{
    public string Value { get; set; } = string.Empty;

    public bool Equals(MutableValueObject other)
    {
        return other is not null && Value == other.Value;
    }
}

// XMoleculesValueObject0006
// Violates because value objects must not define an identity.
[ValueObject]
public sealed class ValueObjectWithIdentity : IEquatable<ValueObjectWithIdentity>
{
    [Identity]
    public string Id { get; } = "value-object-identity";

    public bool Equals(ValueObjectWithIdentity other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0007
// Violates because a value object should not depend on a factory.
[ValueObject]
public sealed class ValueObjectUsingFactory : IEquatable<ValueObjectUsingFactory>
{
    private readonly IEntityFactory _factory = default!;

    public bool Equals(ValueObjectUsingFactory other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0008
// Violates because a value object should not depend on an application service.
[ValueObject]
public sealed class ValueObjectUsingApplicationService : IEquatable<ValueObjectUsingApplicationService>
{
    private readonly SupportingApplicationService _applicationService = default!;

    public bool Equals(ValueObjectUsingApplicationService other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject0009
// Violates because a value object should not depend on the legacy [Service] role.
[ValueObject]
public sealed class ValueObjectUsingLegacyService : IEquatable<ValueObjectUsingLegacyService>
{
    private readonly LegacyPricingService _legacyService = default!;

    public bool Equals(ValueObjectUsingLegacyService other)
    {
        return other is not null;
    }
}

// XMoleculesValueObject1001
// Violates because a value object must implement IEquatable<T>.
[ValueObject]
public sealed class ValueObjectWithoutIEquatable
{
    public string Value { get; } = "value-object-no-equatable";
}

// XMoleculesValueObject1002
// Violates because value objects are expected to be sealed.
[ValueObject]
public class UnsealedValueObject : IEquatable<UnsealedValueObject>
{
    public bool Equals(UnsealedValueObject other)
    {
        return other is not null;
    }
}
