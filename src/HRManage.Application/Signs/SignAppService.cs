using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System.Threading.Tasks;
using HRManager.Entitys;
using HRManage.Signs.Dto;

namespace HRManage.Signs
{
    public class SignAppService:CrudAppService<Sign_In_Tb, SignDto,Guid,PagedAndSortedResultRequestDto,
        CreateUpdateSignDto
        >
    {
        public SignAppService(IRepository<Sign_In_Tb, Guid> repository) : base(repository)
        { 
        
        }
        public override SignDto Create(CreateUpdateSignDto input)
        {
            return base.Create(input);
        }
    }
    
}
