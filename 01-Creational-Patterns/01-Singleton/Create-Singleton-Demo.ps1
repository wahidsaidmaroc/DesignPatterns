$ErrorActionPreference = "Stop"

$RootFolder = $PSScriptRoot

Write-Host "Creating Singleton Training Structure..." -ForegroundColor Green

Set-Location $RootFolder

# Create Solution
dotnet new sln -n SingletonPattern

$SolutionPath = Join-Path $RootFolder "SingletonPattern.sln"
if (-not (Test-Path $SolutionPath)) {
    $SolutionPath = Join-Path $RootFolder "SingletonPattern.slnx"
}

# ==========================
# Demo Projects
# ==========================

$demos = @(
    "Demo01-Logger",
    "Demo02-ConfigurationManager",
    "Demo03-CacheManager",
    "Demo04-PrinterManager",
    "Demo05-CounterService"
)

foreach($demo in $demos)
{
    $beforeProject = "src\$demo\Before\$($demo.Replace('Demo','Singleton.'))" + ".Before"
    $afterProject  = "src\$demo\After\$($demo.Replace('Demo','Singleton.'))" + ".After"

    dotnet new console `
        -n ((Split-Path $beforeProject -Leaf)) `
        -o $beforeProject

    dotnet new console `
        -n ((Split-Path $afterProject -Leaf)) `
        -o $afterProject
}

# ==========================
# Test Projects
# ==========================

$tests = @(
    "Singleton.Logger.Tests",
    "Singleton.Configuration.Tests",
    "Singleton.Cache.Tests",
    "Singleton.Printer.Tests",
    "Singleton.Counter.Tests"
)

foreach($test in $tests)
{
    dotnet new xunit `
        -n $test `
        -o "tests\$test"
}

# ==========================
# Add projects to solution
# ==========================

Get-ChildItem -Recurse -Filter *.csproj |
ForEach-Object {
    dotnet sln $SolutionPath add $_.FullName
}

# ==========================
# Restore & Build
# ==========================

dotnet restore
dotnet build

Write-Host ""
Write-Host "==========================================" -ForegroundColor Green
Write-Host " Singleton Training Created Successfully" -ForegroundColor Green
Write-Host "==========================================" -ForegroundColor Green

Write-Host ""
Write-Host "Generated Structure:"
Write-Host ""

tree /f