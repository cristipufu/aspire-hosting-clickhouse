using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ClickHouse.Hosting.Tests")]
namespace ClickHouse.Hosting;

internal static class ClickHouseContainerImageTags
{
    public const string Registry = "docker.io";
    public const string Image = "clickhouse/clickhouse-server";
    public const string Tag = "25.6";
}
