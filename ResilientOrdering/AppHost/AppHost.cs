using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.APIGateway>("apigateway");
builder.AddProject<OrdersAPI>("OrdersAPI");

builder.Build().Run();
