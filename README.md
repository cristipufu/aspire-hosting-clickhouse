# ClickHouse.Hosting library

[![NuGet](https://img.shields.io/nuget/v/ClickHouse.Hosting)](https://www.nuget.org/packages/ClickHouse.Hosting)
[![GitHub](https://img.shields.io/github/license/cristipufu/aspire-hosting-clickhouse)](https://github.com/cristipufu/aspire-hosting-clickhouse/blob/master/LICENSE)

Provides extension methods and resource definitions for a .NET Aspire AppHost to configure a ClickHouse resource.

## Getting started

### Install the package

In your AppHost project, install the .NET Aspire ClickHouse Hosting library with NuGet:

```dotnetcli
dotnet add package ClickHouse.Hosting
```

## Usage example

Then, in the _Program.cs_ file of `AppHost`, add a ClickHouse resource and consume the connection using the following methods:

```csharp
var db = builder.AddClickHouse("clickhouse")
                    .AddDatabase("default");

var api = builder.AddProject<Projects.ClickHouse_DemoApi>("api")
       .WithReference(db);
```

## Optional Parameters
When using the `AddClickHouse` method, you can specify the following optional parameters:

| Parameter | Description | Default Value |
|-----------|-------------|---------------|
| `userName` | Username for ClickHouse authentication | - |
| `password` | Password for ClickHouse authentication | - |
| `port` | Port number for ClickHouse container | 8123 |
| `imageTag` | Version tag of ClickHouse server image | "25.6" |


## Feedback & contributing

Contributions are welcome! Whether you're fixing a bug, adding a new feature, or improving the documentation, please feel free to make a pull request.
