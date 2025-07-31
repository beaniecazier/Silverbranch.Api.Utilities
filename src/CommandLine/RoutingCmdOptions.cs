using CommandLine;
using Gay.Silverbranch.Utilities.General.CommandLine;

namespace Gay.Silverbranch.Api.Utilities.Common.CommandLine;

public class RoutingCmdOptions : BaseCmdOptions
{
    [Option("http",
        Default = 5000)]
    public int HttpPort { get; set; }

    [Option('p',
        "port",
        Required = false,
        Default = 7005,
        HelpText = "the port number, https")]
    public int Port { get; set; }
    
    [Option('h',
        "host",
        Required = false,
        Default = "localhost",
        HelpText = "the host url, subdomain.domain.xxx"
    )]
    public string? Host { get; set; }
    
    [Option('s',
        "subdirectory",
        Required = false,
        HelpText = "the host subdirectory")]
    public string? Subdirectory { get; set; }
    
    public string BaseAddress => $"http://{Host}:{Port}/{Subdirectory}"; 
}