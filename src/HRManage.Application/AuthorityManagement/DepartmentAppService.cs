using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HRManage.AuthorityManagement.Dto;
using HRManage.Models.AuthorityManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManage.AuthorityManagement
{
    public class DepartmentAppService : CrudAppService<
       Department,
              DepartmentDto,Guid,
       PagedAndSortedResultRequestDto,
       CreateUpdateDepartmentDto
       >, IDepartmentAppService
    {
        public DepartmentAppService(IRepository<Department, Guid> repository) : base(repository) { }
        public override DepartmentDto Create(CreateUpdateDepartmentDto input)
        {
            return base.Create(input);  
        }
        public override DepartmentDto Update(CreateUpdateDepartmentDto input)
        {
            return base.Update(input);  
        }
        public override void Delete(EntityDto<Guid> input)
        {
            base.Delete(input);
        }
        public override DepartmentDto Get(EntityDto<Guid> input)
        {
            return base.Get(input); 
        }
        public override PagedResultDto<DepartmentDto> GetAll(PagedAndSortedResultRequestDto input)
        {
            return base.GetAll(input);
        }
    }
}
