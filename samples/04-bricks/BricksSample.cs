using NMolecules.Bricks;

// Assembly-level brick rule:
// Types tagged as Billing.Domain must not depend on types tagged as Billing.Infrastructure.
[assembly: Rule(
    id: "BILL-BRICK-001",
    sourceRole: "Billing.Domain",
    targetRole: "Billing.Infrastructure",
    mode: RuleMode.ForbidDependency,
    message: "Rule {rule}: {source} must not depend on {target} ({member}).")]

namespace Samples.Block04.Bricks
{
    /// <summary>
    /// Central catalog of role keys used by the billing brick model.
    /// </summary>
    public static class BillingRoles
    {
        /// <summary>
        /// Domain role key.
        /// </summary>
        public const string Domain = "Billing.Domain";

        /// <summary>
        /// Application role key.
        /// </summary>
        public const string Application = "Billing.Application";

        /// <summary>
        /// Infrastructure role key.
        /// </summary>
        public const string Infrastructure = "Billing.Infrastructure";
    }

    /// <summary>
    /// Central catalog of rule ids used by the billing brick model.
    /// </summary>
    public static class BillingRules
    {
        /// <summary>
        /// Rule id: domain role must not depend on infrastructure role.
        /// </summary>
        public const string DomainMustNotDependOnInfrastructure = "BILL-BRICK-001";
    }

    /// <summary>
    /// Domain marker for billing components.
    /// </summary>
    /// <remarks>
    /// This wraps the generic brick role to provide a domain-specific and readable attribute name.
    /// </remarks>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Struct)]
    [RoleAlias(BillingRoles.Domain)]
    public sealed class BillingDomainRoleAttribute : RoleAttribute
    {
        /// <summary>
        /// Initializes the domain marker with the billing domain role key.
        /// </summary>
        public BillingDomainRoleAttribute() : base(BillingRoles.Domain)
        {
        }
    }

    /// <summary>
    /// Infrastructure marker for technical adapters and implementations.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Struct)]
    [RoleAlias(BillingRoles.Infrastructure)]
    public sealed class BillingInfrastructureRoleAttribute : RoleAttribute
    {
        /// <summary>
        /// Initializes the infrastructure marker with the billing infrastructure role key.
        /// </summary>
        public BillingInfrastructureRoleAttribute() : base(BillingRoles.Infrastructure)
        {
        }
    }

    /// <summary>
    /// Application marker for orchestration and use-case components.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Interface |
        AttributeTargets.Struct)]
    [RoleAlias(BillingRoles.Application)]
    public sealed class BillingApplicationRoleAttribute : RoleAttribute
    {
        /// <summary>
        /// Initializes the application marker with the billing application role key.
        /// </summary>
        public BillingApplicationRoleAttribute() : base(BillingRoles.Application)
        {
        }
    }

    /// <summary>
    /// Domain policy containing a business decision for contract creation.
    /// </summary>
    [BillingDomainRole]
    public sealed class ContractPolicy
    {
        /// <summary>
        /// Validates whether a contract can be created for the given customer name.
        /// </summary>
        /// <param name="customerName">Candidate customer display name.</param>
        /// <returns>
        /// <see langword="true"/> if a non-empty customer name is provided; otherwise <see langword="false"/>.
        /// </returns>
        public bool CanCreateContract(string customerName)
        {
            return !string.IsNullOrWhiteSpace(customerName);
        }
    }

    /// <summary>
    /// Application service that orchestrates the "open contract" use case.
    /// </summary>
    [BillingApplicationRole]
    public sealed class ContractApplicationService
    {
        private readonly IContractRepository _repository;
        private readonly ContractPolicy _policy;

        /// <summary>
        /// Initializes the service with required domain collaborators.
        /// </summary>
        /// <param name="repository">Repository contract for persistence actions.</param>
        /// <param name="policy">Domain policy for business validation.</param>
        public ContractApplicationService(IContractRepository repository, ContractPolicy policy)
        {
            _repository = repository;
            _policy = policy;
        }

        /// <summary>
        /// Opens a contract when policy checks are satisfied.
        /// </summary>
        /// <param name="customerName">Customer name used by policy and persistence flow.</param>
        /// <returns>
        /// <see langword="true"/> when the contract was accepted and stored; otherwise <see langword="false"/>.
        /// </returns>
        public bool Open(string customerName)
        {
            if (!_policy.CanCreateContract(customerName))
            {
                return false;
            }

            _repository.Store(customerName);
            return true;
        }
    }

    /// <summary>
    /// Domain-side repository contract for contract persistence.
    /// </summary>
    [BillingDomainRole]
    public interface IContractRepository
    {
        /// <summary>
        /// Stores contract data for the given customer name.
        /// </summary>
        /// <param name="customerName">Customer name to store.</param>
        void Store(string customerName);
    }

    /// <summary>
    /// Infrastructure implementation of <see cref="IContractRepository"/>.
    /// </summary>
    [BillingInfrastructureRole]
    public sealed class SqlContractRepository : IContractRepository
    {
        /// <summary>
        /// Stores contract data using an infrastructure-specific persistence implementation.
        /// </summary>
        /// <param name="customerName">Customer name to store.</param>
        public void Store(string customerName)
        {
        }
    }
}
