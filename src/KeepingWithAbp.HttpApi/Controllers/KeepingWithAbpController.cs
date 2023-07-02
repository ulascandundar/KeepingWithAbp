using KeepingWithAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace KeepingWithAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class KeepingWithAbpController : AbpControllerBase
{
    protected KeepingWithAbpController()
    {
        LocalizationResource = typeof(KeepingWithAbpResource);
    }
}
