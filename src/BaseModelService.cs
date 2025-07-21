using Gay.Silverbranch.Api.Utilities.Common.Interfaces;

namespace Gay.Silverbranch.Api.Utilities.Common;

public abstract class BaseModelService : IBaseModelService
{
    // public Fin<int> GetNextCommonID(IEnumerable<BaseModel> models)
    // {
    //     //return 0;
    //     if (models is null || models.Count() == 0) return 0;
    //     try { return models.Max(x => x.CommonIdentity) + 1; }
    //     catch (Exception ex) { return Error.New(ex); }
    // }
}
