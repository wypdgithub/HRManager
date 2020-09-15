using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRManage.AuthorityManagement.Dto;
using System;

namespace HRManage.AuthorityManagement
{
    public interface IDepartmentAppService : ICrudAppService<
        DepartmentDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateDepartmentDto
        >
    {
    }
}
