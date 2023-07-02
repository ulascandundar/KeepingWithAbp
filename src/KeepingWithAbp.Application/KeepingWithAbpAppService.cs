using System;
using System.Collections.Generic;
using System.Text;
using KeepingWithAbp.Localization;
using Volo.Abp.Application.Services;

namespace KeepingWithAbp;

/* Inherit your application services from this class.
 */
public abstract class KeepingWithAbpAppService : ApplicationService
{
    protected KeepingWithAbpAppService()
    {
        LocalizationResource = typeof(KeepingWithAbpResource);
    }
}
