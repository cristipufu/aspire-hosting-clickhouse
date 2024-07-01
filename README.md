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


## Feedback & contributing

Contributions are welcome! Whether you're fixing a bug, adding a new feature, or improving the documentation, please feel free to make a pull request.
