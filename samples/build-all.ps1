$ErrorActionPreference = "Stop"

$projects = @(
    "01-ddd-core/Samples.Block01.DddCore.csproj",
    "02-architecture-styles/layered/Samples.Architecture.Layered.csproj",
    "02-architecture-styles/cqrs/Samples.Architecture.Cqrs.csproj",
    "02-architecture-styles/onion-classic/Samples.Architecture.OnionClassic.csproj",
    "02-architecture-styles/onion-simplified/Samples.Architecture.OnionSimplified.csproj",
    "02-architecture-styles/hexagonal/Samples.Architecture.Hexagonal.csproj",
    "02-architecture-styles/microservices/Samples.Architecture.Microservices.csproj",
    "02-architecture-styles/event-storming/Samples.Architecture.EventStorming.csproj",
    "02-architecture-styles/mvvm/Samples.Architecture.Mvvm.csproj",
    "03-events/Samples.Block03.Events.csproj",
    "04-bricks/Samples.Block04.Bricks.csproj",
    "05-entity-framework/Samples.Block05.EntityFramework.csproj",
    "06-analyzer-workbench/Samples.Block06.AnalyzerWorkbench.csproj",
    "07-ddd-from-pdfs/Samples.Block07.DddFromPdfs.csproj"
)

foreach ($project in $projects) {
    $path = Join-Path $PSScriptRoot $project
    Write-Host "Building $project ..."
    dotnet build $path -v minimal
    if ($LASTEXITCODE -ne 0) {
        throw "Build failed for $project"
    }
}

Write-Host ""
Write-Host "All pedagogical sample projects built."
