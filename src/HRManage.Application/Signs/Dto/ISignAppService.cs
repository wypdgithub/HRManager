using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using HRManage.Signs.Dto;

namespace HRManage.Signs.Dto
{
    public interface ISignAppService:ICrudAppService<SignDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateSignDto>
    {

    }
}
