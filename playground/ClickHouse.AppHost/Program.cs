var builder = DistributedApplication.CreateBuilder(args);

var clickhouse = builder.AddClickHouse("clickhouse")
                    .AddDatabase("default");

builder.AddProject<Projects.ClickHouse_DemoApi>("api")
       .WithReference(clickhouse);

builder.Build().Run();
