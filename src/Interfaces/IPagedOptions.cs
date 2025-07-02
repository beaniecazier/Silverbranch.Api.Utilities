namespace Gay.Silverbranch.API.Utilities.Common.Interfaces;

public interface IPagedOptions
{
    public int PageSize { get; init; }
    public int PageIndex { get; init; }
}
