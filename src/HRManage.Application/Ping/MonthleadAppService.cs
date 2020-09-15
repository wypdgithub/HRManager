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
   public class MonthleadAppService : CrudAppService<Monthlead, MonthleadDto, Guid, PagedAndSortedResultRequestDto, CreatMonthleadDto>, IMonthleadAppService
    {
        public MonthleadAppService(IRepository<Monthlead, Guid> repository)
          : base(repository)
        {

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }
        public override MonthleadDto Update(CreatMonthleadDto input)
        {
            return base.Update(input);
        }
        public override void Delete(EntityDto<Guid> input)
        {
            base.Delete(input);
        }
        public override MonthleadDto Get(EntityDto<Guid> input)
        {
            return base.Get(input);

        }
    }
}
