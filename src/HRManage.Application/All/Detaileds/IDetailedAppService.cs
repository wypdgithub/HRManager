using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRManage.All.KQ.Dto;
using HRManager.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.All.KQ
{
   public interface IDetailedAppService:ICrudAppService<DetailedDto ,Guid,PagedAndSortedResultRequestDto,CreateUptDetailedDto>
    {

    }
}
