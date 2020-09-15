using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Application.Services;
using HRManage.Ping.Dto;
using HRManage.Models.Grades;
using Abp.Domain.Repositories;

namespace HRManage.Ping
{
    public class PingService : CrudAppService<
        Yearstaff, 
        YearstaffDto,
        Guid,
        PagedAndSortedResultRequestDto,
        ModifyYearstaff>,IPingService
    {
        public PingService(IRepository<Yearstaff, Guid> repository)
            : base(repository)
        {

        }

        public override YearstaffDto Create(ModifyYearstaff input)
        {
            return base.Create(input);
        }

        public override YearstaffDto Get(EntityDto<Guid> input)
        {
            return base.Get(input);
        }
    }
}
