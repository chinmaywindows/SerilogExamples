var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Serilog_AspireApp_Net9_ApiService>("apiservice");

builder.AddProject<Projects.Serilog_AspireApp_Net9_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
