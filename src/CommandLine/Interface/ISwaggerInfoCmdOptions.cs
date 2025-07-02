namespace Gay.Silverbranch.Api.Utilities.CommandLine.Interface;

public interface ISwaggerInfoCmdOptions
{
    // [Option(Default = "Tiabeanie Cazier")]
    // public string ContactName { get; set; } = "Tiabeanie Cazier";
    //
    // [Option(Default = "beanieroxiicazier@gmail.com")]
    // public string ContactEmail { get; set; } = "beanieroxiicazier@gmail.com";
    //
    // [Option(Default = "https://silverbranch-codeworks.com/contact")]
    // public string ContactUrl { get; set; } = "https://silverbranch-codeworks.com/contact";
    //
    // [Option(Default = "https://silverbranch-codeworks.com/terms")]
    // public string TermsOfServiceUrl { get; set; } = "https://silverbranch-codeworks.com/terms";

    string ContactName { get; set; }
    string ContactEmail { get; set; }
    string ContactUrl { get; set; }
    string TermsOfServiceUrl { get; set; }
}