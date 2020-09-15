using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRManage.Ping.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRManage.Ping
{
   public interface IGradeAppService:ICrudAppService<GradeDto,Guid,PagedAndSortedResultRequestDto,CreateGradeDto>
    {
    }
}
