namespace Gay.Silverbranch.Api.Utilities.Common.CommandLine.Interface;

public interface IVersionedSoftwareCmdOptions
{

    // [Option("versions", Required = true, Separator = ';')]
    // public IEnumerable<string> VersionsToLoad { get; set; } = new List<string>() { "v1" };

    IEnumerable<string> VersionsToLoad { get; set; }
}