using Microsoft.SemanticKernel;
using Microsoft.Extensions.Configuration;

// Get the current environment (defaults to "Production" if not set)
var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";

// Build configuration to read from multiple appsettings files
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables() // Ensure the correct using directive is added
    .Build();
