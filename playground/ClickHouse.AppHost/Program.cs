var builder = DistributedApplication.CreateBuilder(args);

var clickhouse = builder.AddClickHouse("clickhouse", imageTag: "latest")
                    .AddDatabase("default");

builder.AddProject<Projects.ClickHouse_DemoApi>("api")
       .WithReference(clickhouse);

builder.Build().Run();
