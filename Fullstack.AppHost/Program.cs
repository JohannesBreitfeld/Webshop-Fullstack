var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Fullstack_ApiService>("apiservice");

builder.AddProject<Projects.Fullstack_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
