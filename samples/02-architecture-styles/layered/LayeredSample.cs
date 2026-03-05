using NMolecules.Architecture.Layered;

namespace Samples.Architecture.Layered;

[DomainLayer]
public sealed class Account
{
    public string Id { get; init; } = string.Empty;
}

[ApplicationLayer]
public sealed class OpenAccountUseCase
{
    public Account Open(string id)
    {
        return new Account { Id = id };
    }
}

[InfrastructureLayer]
public sealed class SqlAccountStore
{
}

[InterfaceLayer]
public interface IAccountsApi
{
}

[UserInterfaceLayer]
public sealed class AccountsPage
{
}
