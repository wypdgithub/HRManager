using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRManage.All.Please_Leaves.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.All.Please_Leaves
{
    public interface IPlease_LeaveAppService : ICrudAppService<Please_LeaveDto, Guid, PagedAndSortedResultRequestDto, CreateUptPlease_LeaveDto>
    {

    }
}
