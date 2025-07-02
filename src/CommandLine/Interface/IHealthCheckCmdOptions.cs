using CommandLine;

namespace Gay.Silverbranch.Api.Utilities.CommandLine.Interface;

public interface IHealthCheckCmdOptions
{
    int ReadyCheckPort { get; set; }
    int LivenessCheckPort { get; set; }
    int StartupCheckPort { get; set; }
    string HealthChecksHostAddress { get; set; }

    //int FakedStartupDurationInSeconds { get; set; }
}