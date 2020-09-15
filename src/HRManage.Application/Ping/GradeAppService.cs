using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using HRManage.Models.Grade;
using HRManage.Ping.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace HRManage.Ping
{
   public class GradeAppService : CrudAppService<Grade, GradeDto, Guid, PagedAndSortedResultRequestDto, CreateGradeDto>, IGradeAppService
    {
        public GradeAppService(IRepository<Grade, Guid> repository)
           : base(repository)
        {

        }
        public override GradeDto Create(CreateGradeDto input)
        {
            return base.Create(input);  
        }
        public override GradeDto Update(CreateGradeDto input)
        {
            return base.Update(input);
        }
        public override void Delete(EntityDto<Guid> input)
        {
            base.Delete(input);
        }
        public override GradeDto Get(EntityDto<Guid> input)
        {
            return base.Get(input);
        }
    }
}
