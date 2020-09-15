using Abp.Application.Services;
using HRManage.MultiTenancy.Dto;

namespace HRManage.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

