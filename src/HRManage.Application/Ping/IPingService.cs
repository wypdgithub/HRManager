using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Application.Services;
using HRManage.Ping.Dto;

namespace HRManage.Ping
{
    public interface IPingService : ICrudAppService<YearstaffDto,Guid,PagedAndSortedResultRequestDto, ModifyYearstaff>
    {
    }
}
