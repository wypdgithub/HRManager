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
   public class MonthstaffAppService: CrudAppService<Monthstaff, MonthstaffDto, Guid, PagedAndSortedResultRequestDto, CreatMonthstaffDto>, IMonthstaffAppService
    {
        public MonthstaffAppService(IRepository<Monthstaff,Guid> repository)
            :base(repository)
        {

        }
        public override MonthstaffDto Create(CreatMonthstaffDto input)
        {
            return base.Create(input);
        }
        public override MonthstaffDto Update(CreatMonthstaffDto input)
        {
            return base.Update(input);
        }
        public override void Delete(EntityDto<Guid> input)
        {
            base.Delete(input);

        }
        public override MonthstaffDto Get(EntityDto<Guid> input)
        {
            return base.Get(input);
        }
    }
}
