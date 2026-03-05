using NMolecules.Architecture.Mvvm;

namespace Samples.Architecture.Mvvm;

[Model]
public sealed class InvoiceEditorModel
{
    public string Id { get; init; } = string.Empty;
    public decimal Amount { get; init; }
}

[ViewModel]
public sealed class InvoiceEditorViewModel
{
    public InvoiceEditorModel Model { get; } = new();
}

[View]
public sealed class InvoiceEditorView
{
}
